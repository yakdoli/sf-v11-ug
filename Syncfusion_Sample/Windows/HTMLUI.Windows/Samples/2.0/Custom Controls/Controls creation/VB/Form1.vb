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
Imports Microsoft.VisualBasic

Imports Syncfusion.Windows.Forms.HTMLUI



    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>
    
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private customControlTemplateString As String
        Private controlsString As String
        Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
        Private panel1 As System.Windows.Forms.Panel
        Private richTextBox1 As System.Windows.Forms.RichTextBox

    '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
        
        
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        Me.customControlTemplateString = "<custom assembly='$$assembly$$' class='$$classname$$'  width='280'/><p/>"
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
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(301, 281)
        Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.Size = New System.Drawing.Size(328, 296)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 4
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=66, Height=15}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
        "y></html>"
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.label1, Me.textBox1, Me.comboBox1, Me.button2, Me.button1, Me.listView1})
        Me.panel1.Location = New System.Drawing.Point(328, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(224, 296)
        Me.panel1.TabIndex = 3
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(172, Byte), CType(85, Byte))
        Me.label2.Location = New System.Drawing.Point(8, 160)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(200, 16)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Assembly Name"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(172, Byte), CType(85, Byte))
        Me.label1.Location = New System.Drawing.Point(11, 208)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(200, 16)
        Me.label1.TabIndex = 32
        Me.label1.Text = "Class Name"
        '
        'textBox1
        '
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox1.Location = New System.Drawing.Point(8, 183)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(200, 20)
        Me.textBox1.TabIndex = 31
        Me.textBox1.Text = "System.Windows.Forms"
        '
        'comboBox1
        '
        Me.comboBox1.Items.AddRange(New Object() {"HScrollBar", "CheckBox", "DataGrid", "TabControl", "ListBox", "RadioButton"})
        Me.comboBox1.Location = New System.Drawing.Point(8, 231)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(200, 21)
        Me.comboBox1.TabIndex = 30
        Me.comboBox1.Text = "Button"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.button2.Enabled = False
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Maroon
        Me.button2.Location = New System.Drawing.Point(56, 127)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 24)
        Me.button2.TabIndex = 27
        Me.button2.Text = "Delete"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(48, 263)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 24)
        Me.button1.TabIndex = 26
        Me.button1.Text = "Add"
        '
        'listView1
        '
        Me.listView1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.listView1.BackColor = System.Drawing.Color.White
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
        Me.listView1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.FullRowSelect = True
        Me.listView1.Location = New System.Drawing.Point(7, 7)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(209, 113)
        Me.listView1.TabIndex = 25
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Class Name"
        Me.columnHeader1.Width = 86
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Assembly"
        Me.columnHeader2.Width = 188
        '
        'richTextBox1
        '
        Me.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.richTextBox1.BackColor = System.Drawing.Color.White
        Me.richTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(0, 296)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(552, 80)
        Me.richTextBox1.TabIndex = 7
        Me.richTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox1, Me.htmluiControl1, Me.panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controls creation"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
        
        
        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()>  _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub 'Main
        
        
        Private Sub FillInitialHTML()
            CreateControl("Syncfusion.Windows.Forms.ButtonAdv", "Syncfusion.Shared.Base")
            CreateControl("Syncfusion.Windows.Forms.Tools.CurrencyTextBox", "Syncfusion.Shared.Base")
            CreateControl("DateTimePicker", "System.Windows.Forms")
            CreateControl("DataGrid", "System.Windows.Forms")
            
            AddToListView("Syncfusion.Windows.Forms.ButtonAdv", "Syncfusion.Shared.Base")
            AddToListView("Syncfusion.Windows.Forms.Tools.CurrencyTextBox", "Syncfusion.Shared.Base")
            AddToListView("DateTimePicker", "System.Windows.Forms")
            AddToListView("DataGrid", "System.Windows.Forms")
            
            SyncHTML()
        End Sub 'FillInitialHTML
        
        
        Private Sub SyncHTML()
        Dim htmlStr As String = "<html><title>Click add button to add the control to HTMLUI</title><body>" + Me.controlsString + "</body></html>"
            Me.htmluiControl1.LoadFromString(htmlStr)
        Me.richTextBox1.Text = htmlStr.Replace("<p/>", "<p/>" + vbCr + vbLf)
        End Sub 'SyncHTML
        
        
        
        Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            FillInitialHTML()
        End Sub 'Form1_Load
        
        
    Private Overloads Sub CreateControl(ByVal className As String, ByVal assemblyName As String)
        Dim customHTML As String = Me.customControlTemplateString.Replace("$$classname$$", className)
        customHTML = customHTML.Replace("$$assembly$$", assemblyName)
        Me.controlsString += customHTML
    End Sub 'CreateControl
        
        
        Private Sub CreateAllControls()
            Me.controlsString = ""
            
            Dim i As Integer
            For i = 0 To (Me.listView1.Items.Count) - 1
                CreateControl(Me.listView1.Items(i).SubItems(0).Text, Me.listView1.Items(i).SubItems(1).Text)
            Next i
            
            SyncHTML()
        End Sub 'CreateAllControls
        
        
    Private Sub AddToListView(ByVal className As String, ByVal assemblyName As String)
        Dim item As ListViewItem = Me.listView1.Items.Add(className)
        item.SubItems.Add(assemblyName)
    End Sub 'AddToListView


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        AddToListView(Me.comboBox1.Text, Me.textBox1.Text)
        CreateAllControls()
    End Sub 'button1_Click


    Private Sub listView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listView1.SelectedIndexChanged
        If Me.listView1.SelectedItems.Count > 0 Then
            Me.button2.Enabled = True
        End If
    End Sub 'listView1_SelectedIndexChanged

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        If Me.listView1.SelectedItems.Count > 0 Then
            Me.listView1.Items.Remove(Me.listView1.SelectedItems(0))
        End If
        CreateAllControls()

        If Me.listView1.Items.Count > 0 Then
            Me.listView1.Items(0).Selected = True
        End If
    End Sub 'button2_Click


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show(Me.controlsString)
    End Sub 'button3_Click


End Class 'Form1
