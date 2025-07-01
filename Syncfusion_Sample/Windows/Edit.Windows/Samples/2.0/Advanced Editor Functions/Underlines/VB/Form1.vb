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
Imports System.IO

Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Interfaces


Namespace UnderlineDemo
    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>
    
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private radioButton2 As System.Windows.Forms.RadioButton
        Private radioButton3 As System.Windows.Forms.RadioButton
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private radioButton4 As System.Windows.Forms.RadioButton
        Private radioButton5 As System.Windows.Forms.RadioButton
        Private radioButton6 As System.Windows.Forms.RadioButton
        Private mainMenu1 As System.Windows.Forms.MainMenu
        Private menuItem1 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
        Private menuItem4 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
        Private menuItem7 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private radioButton7 As System.Windows.Forms.RadioButton
        Private radioButton8 As System.Windows.Forms.RadioButton
        Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
        Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
        Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Test.cs"
        
        
        
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            
            Me.editControl1.LoadFile(BasePath)

            editControl1.ShowHorizontalSplitters = False
            editControl1.ShowVerticalSplitters = False
            editControl1.ShowSelectionMargin = False
            editControl1.WordWrap = True
            SizeGripStyle = Windows.Forms.SizeGripStyle.Hide
            editControl1.BorderStyle = BorderStyle.Fixed3D

        End Sub 'New
        
        
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
            Dim resources As New System.Resources.ResourceManager(GetType(Form1))
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton3 = New System.Windows.Forms.RadioButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.radioButton6 = New System.Windows.Forms.RadioButton()
            Me.radioButton5 = New System.Windows.Forms.RadioButton()
            Me.radioButton4 = New System.Windows.Forms.RadioButton()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.menuItem5 = New System.Windows.Forms.MenuItem()
            Me.menuItem6 = New System.Windows.Forms.MenuItem()
            Me.menuItem7 = New System.Windows.Forms.MenuItem()
            Me.menuItem8 = New System.Windows.Forms.MenuItem()
            Me.radioButton7 = New System.Windows.Forms.RadioButton()
            Me.radioButton8 = New System.Windows.Forms.RadioButton()
            Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
            Me.menuItem9 = New System.Windows.Forms.MenuItem()
            Me.menuItem10 = New System.Windows.Forms.MenuItem()
            Me.groupBox1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(16, 24)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(120, 24)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Double"
            ' 
            ' radioButton1
            ' 
            Me.radioButton1.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton1.Checked = True
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.ForeColor = System.Drawing.Color.Red
            Me.radioButton1.Location = New System.Drawing.Point(8, 24)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(104, 16)
            Me.radioButton1.TabIndex = 2
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Red"
            ' 
            ' radioButton2
            ' 
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.ForeColor = System.Drawing.Color.Blue
            Me.radioButton2.Location = New System.Drawing.Point(8, 48)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(104, 16)
            Me.radioButton2.TabIndex = 3
            Me.radioButton2.Text = "Blue"
            ' 
            ' radioButton3
            ' 
            Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton3.ForeColor = System.Drawing.Color.Green
            Me.radioButton3.Location = New System.Drawing.Point(8, 72)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(104, 16)
            Me.radioButton3.TabIndex = 4
            Me.radioButton3.Text = "Green"
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox3, Me.groupBox2, Me.checkBox1})
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(152, 445)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Active Underline Setting"
            ' 
            ' groupBox3
            ' 
            Me.groupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton8, Me.radioButton7, Me.radioButton6, Me.radioButton5, Me.radioButton4})
            Me.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox3.Location = New System.Drawing.Point(16, 208)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(120, 176)
            Me.groupBox3.TabIndex = 6
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Style"
            ' 
            ' radioButton6
            ' 
            Me.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton6.Location = New System.Drawing.Point(8, 80)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.TabIndex = 2
            Me.radioButton6.Text = "Wave"
            ' 
            ' radioButton5
            ' 
            Me.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton5.Location = New System.Drawing.Point(8, 48)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.TabIndex = 1
            Me.radioButton5.Text = "DashDot"
            ' 
            ' radioButton4
            ' 
            Me.radioButton4.Checked = True
            Me.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton4.Location = New System.Drawing.Point(8, 16)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.TabIndex = 0
            Me.radioButton4.TabStop = True
            Me.radioButton4.Text = "Solid"
            ' 
            ' groupBox2
            ' 
            Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton3, Me.radioButton1, Me.radioButton2})
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox2.Location = New System.Drawing.Point(16, 72)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(120, 96)
            Me.groupBox2.TabIndex = 5
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Color"
            ' 
            ' mainMenu1
            ' 
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9, Me.menuItem10})
            ' 
            ' menuItem1
            ' 
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8})
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
            ' radioButton7
            ' 
            Me.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton7.Location = New System.Drawing.Point(8, 112)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.TabIndex = 3
            Me.radioButton7.Text = "Dot"
            ' 
            ' radioButton8
            ' 
            Me.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton8.Location = New System.Drawing.Point(8, 144)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.TabIndex = 4
            Me.radioButton8.Text = "Dash"
            ' 
            ' editControl1
            ' 
            Me.editControl1.AutoIndentMode = AutoIndentMode.Smart
            Me.editControl1.CurrentColumn = 13
            Me.editControl1.CurrentLine = 1
            Me.editControl1.CurrentPosition = New System.Drawing.Point(13, 1)
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.FileOpened = Nothing
            Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
            Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
            Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
            Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            Me.editControl1.Location = New System.Drawing.Point(152, 0)
            Me.editControl1.Name = "editControl1"
            Me.editControl1.ShowCollapse = True
            Me.editControl1.ShowHorizontalSplitters = True
            Me.editControl1.ShowLineNumbers = True
            Me.editControl1.ShowMarkers = False
            Me.editControl1.ShowVerticalSplitters = True
            Me.editControl1.ShowWhitespaces = False
            Me.editControl1.Size = New System.Drawing.Size(390, 445)
			Me.editControl1.SpaceBetweenLines = 3
            Me.editControl1.TabIndex = 6
            Me.editControl1.TabSize = 2
            Me.editControl1.Text = "editControl1"
            Me.editControl1.TransferFocusOnTab = True
            Me.editControl1.UserMarginWidth = 100
            ' 
            ' menuItem9
            ' 
            Me.menuItem9.Index = 1
            Me.menuItem9.Text = "UnderlineSelection"
            ' 
            ' menuItem10
            ' 
            Me.menuItem10.Index = 2
            Me.menuItem10.Text = "RemoveUnderline"
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(542, 445)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1, Me.groupBox1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.Text = "Underlines"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub 'InitializeComponent 
#End Region


        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()> _
        Shared Sub Main()
Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub 'Main


        Private ReadOnly Property SelectedColor() As Color
            Get
                If radioButton1.Checked Then
                    Return radioButton1.ForeColor
                End If
                If radioButton2.Checked Then
                    Return radioButton2.ForeColor
                End If
                If radioButton3.Checked Then
                    Return radioButton3.ForeColor
                End If
                Return Color.Black
            End Get
        End Property


        Private ReadOnly Property SelectedStyle() As UnderlineStyle
            Get
                If radioButton4.Checked Then
                    Return UnderlineStyle.Solid
                End If
                If radioButton5.Checked Then
                    Return UnderlineStyle.DashDot
                End If
                If radioButton6.Checked Then
                    Return UnderlineStyle.Wave
                End If
                If radioButton7.Checked Then
                    Return UnderlineStyle.Dot
                End If
                If radioButton8.Checked Then
                    Return UnderlineStyle.Dash
                End If
                Return UnderlineStyle.Solid
            End Get
        End Property


        Private ReadOnly Property SelectedWeight() As UnderlineWeight
            Get
                If checkBox1.Checked Then
                    Return UnderlineWeight.Double
                End If
                Return UnderlineWeight.Thin
            End Get
        End Property


        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
            Me.editControl1.NewFile()
        End Sub 'menuItem2_Click


        Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
            Me.editControl1.LoadFile()
        End Sub 'menuItem3_Click


        Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
            Me.editControl1.Save()
        End Sub 'menuItem5_Click


        Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
            Me.editControl1.SaveAs()
        End Sub 'menuItem6_Click


        Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
            Me.Close()
        End Sub 'menuItem8_Click


        Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
            If Not (editControl1.Selection Is Nothing) Then
                Dim format As ISnippetFormat = editControl1.RegisterUnderlineFormat(SelectedColor, SelectedStyle, SelectedWeight)
                Me.editControl1.SetUnderline(editControl1.Selection.Top, editControl1.Selection.Bottom, format)
            End If
        End Sub 'menuItem9_Click


        Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
            If Not (editControl1.Selection Is Nothing) Then
                Me.editControl1.RemoveUnderline(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom)
            End If
        End Sub 'menuItem10_Click
    End Class 'Form1
End Namespace 'UnderlineDemo