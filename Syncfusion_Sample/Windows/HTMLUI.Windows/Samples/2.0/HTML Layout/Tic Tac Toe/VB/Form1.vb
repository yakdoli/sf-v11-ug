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
Imports System.Reflection

Imports Syncfusion.Windows.Forms.HTMLUI

'/ <summary>
    '/ Summary description for Form1.
    '/ </summary>

    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private _assembly As [Assembly]
        Private _htmlStream As Stream

        Private Shared GameEndIndexes(,) As Integer = {{0, 1, 2}, {3, 4, 5}, {6, 7, 8}, {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, {0, 4, 8}, {2, 4, 6}}

        Private htmlelements As New Hashtable()
        Private ttt1 As BaseElement
        Private ttt2 As BaseElement
        Private ttt3 As BaseElement
        Private ttt4 As BaseElement
        Private ttt5 As BaseElement
        Private ttt6 As BaseElement
        Private ttt7 As BaseElement
        Private ttt8 As BaseElement
        Private ttt9 As BaseElement
        Private _elementArray() As BaseElement


        Private gameOver As Boolean = False

        Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
        Private mainMenu1 As System.Windows.Forms.MainMenu
        Private menuItem1 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
        Private menuItem4 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
        Private imageList1 As System.Windows.Forms.ImageList
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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 338)
        Me.htmluiControl1.BackColor = System.Drawing.SystemColors.Control
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 353)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=77, Height=14}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
        "y></html>"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem4})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3})
        Me.menuItem1.Text = "Game"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "Reset"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Exit"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 1
        Me.menuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem5})
        Me.menuItem4.Text = "View"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 0
        Me.menuItem5.Text = "HTML"
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(212, Byte), CType(243, Byte))
        Me.ClientSize = New System.Drawing.Size(552, 353)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
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


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            LoadHTMLResource()
        End Sub 'Form1_Load

#Region "LOADUI"

        Private Function LoadHTMLResource() As Boolean
            Dim success As Boolean = False

            Try
                _assembly = [Assembly].GetExecutingAssembly()
            _htmlStream = CType(_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.dialog.htm"), Stream)
                If Not (_htmlStream Is Nothing) Then
                    Me.htmluiControl1.LoadHTML(_htmlStream)
                    success = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Return success
        End Function 'LoadHTMLResource
#End Region

#Region "UI_EVENTS"

        Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
            WireElements()
        End Sub 'htmluiControl1_LoadFinished


        Private Sub WireElements()
            Try
                htmlelements = Me.htmluiControl1.Document.GetElementsByUserIdHash()

                Me.ttt1 = htmlelements("ttt1")
                Me.ttt2 = htmlelements("ttt2")
                Me.ttt3 = htmlelements("ttt3")
                Me.ttt4 = htmlelements("ttt4")
                Me.ttt5 = htmlelements("ttt5")
                Me.ttt6 = htmlelements("ttt6")
                Me.ttt7 = htmlelements("ttt7")
                Me.ttt8 = htmlelements("ttt8")
                Me.ttt9 = htmlelements("ttt9")

                Me.ttt1.QuietMode = False
                Me.ttt2.QuietMode = False
                Me.ttt3.QuietMode = False
                Me.ttt4.QuietMode = False
                Me.ttt5.QuietMode = False
                Me.ttt6.QuietMode = False
                Me.ttt7.QuietMode = False
                Me.ttt8.QuietMode = False
                Me.ttt9.QuietMode = False

                AddHandler Me.ttt1.Click, AddressOf ttt1_Click
                AddHandler Me.ttt2.Click, AddressOf ttt2_Click
                AddHandler Me.ttt3.Click, AddressOf ttt3_Click
                AddHandler Me.ttt4.Click, AddressOf ttt4_Click
                AddHandler Me.ttt5.Click, AddressOf ttt5_Click
                AddHandler Me.ttt6.Click, AddressOf ttt6_Click
                AddHandler Me.ttt7.Click, AddressOf ttt7_Click
                AddHandler Me.ttt8.Click, AddressOf ttt8_Click
                AddHandler Me.ttt9.Click, AddressOf ttt9_Click

                _elementArray = New BaseElement(8) {ttt1, ttt2, ttt3, ttt4, ttt5, ttt6, ttt7, ttt8, ttt9}

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End Sub 'WireElements


        Private Sub ttt1_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt1)
        End Sub 'ttt1_Click


        Private Sub ttt2_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt2)
        End Sub 'ttt2_Click


        Private Sub ttt3_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt3)
        End Sub 'ttt3_Click


        Private Sub ttt4_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt4)
        End Sub 'ttt4_Click


        Private Sub ttt5_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt5)
        End Sub 'ttt5_Click


        Private Sub ttt6_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt6)
        End Sub 'ttt6_Click


        Private Sub ttt7_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt7)
        End Sub 'ttt7_Click


        Private Sub ttt8_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt8)
        End Sub 'ttt8_Click


        Private Sub ttt9_Click(ByVal sender As Object, ByVal e As EventArgs)
            HandleElementClick(Me.ttt9)
        End Sub 'ttt9_Click

#End Region

#Region "TIC_TAC_TOE"

        Private lastWasX As Boolean = False

        Private Function GetXorO() As String
            Dim ret As String = "X"
            If lastWasX = True Then
                ret = "O"
            End If
            lastWasX = Not lastWasX
            Return ret
        End Function 'GetXorO


        Private Sub HandleElementClick(ByVal target As BaseElement)
            If target.InnerHTML = "" AndAlso Me.gameOver = False Then
                target.InnerHTML = Me.GetXorO()
            End If
            Me.ApplyGameRules()
        End Sub 'HandleElementClick


        Private Sub ResetGame()
            Dim i As Integer
            For i = 0 To 8
                Me._elementArray(i).InnerHTML = ""
                Me._elementArray(i).Attributes("class").Value = "tttDisplay"
            Next i

            Me.lastWasX = False
            Me.gameOver = False
        End Sub 'ResetGame


        Public Function ApplyGameRules() As Boolean
            Dim gameEndCombinations As Integer = GameEndIndexes.Length / 3
            Dim i As Integer
            For i = 0 To gameEndCombinations - 1
                Dim element1 As BaseElement = _elementArray(GameEndIndexes(i, 0))
                Dim element2 As BaseElement = _elementArray(GameEndIndexes(i, 1))
                Dim element3 As BaseElement = _elementArray(GameEndIndexes(i, 2))

                If element1.InnerHTML <> "" AndAlso element2.InnerHTML <> "" AndAlso element3.InnerHTML <> "" Then
                    If element1.InnerHTML = element2.InnerHTML AndAlso element1.InnerHTML = element3.InnerHTML Then
                        element1.Attributes("class").Value = "tttWinDisplay"
                        element2.Attributes("class").Value = "tttWinDisplay"
                        element3.Attributes("class").Value = "tttWinDisplay"
                        gameOver = True
                        Exit For
                    End If
                End If
            Next i
            Return False
        End Function 'ApplyGameRules

#End Region

#Region "MENU_HANDLING"


        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
            Me.ResetGame()
        End Sub 'menuItem2_Click


        Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
            MessageBox.Show(Me.htmluiControl1.Text)
        End Sub 'menuItem5_Click


        Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
            Application.Exit()
        End Sub 'menuItem3_Click
#End Region
    End Class 'Form1