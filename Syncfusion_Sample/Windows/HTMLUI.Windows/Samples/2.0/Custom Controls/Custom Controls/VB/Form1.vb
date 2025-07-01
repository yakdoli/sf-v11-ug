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
Imports System.IO
Imports System.Reflection

Imports Syncfusion.Windows.Forms.HTMLUI

Public Class Form1 : Inherits System.Windows.Forms.Form
    Private _assembly As System.Reflection.Assembly
    Private _htmlStream As Stream

    Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private imageList1 As System.Windows.Forms.ImageList
    Private monthCalendar1 As System.Windows.Forms.MonthCalendar
    Private dataGrid1 As System.Windows.Forms.DataGrid
    Private components As System.ComponentModel.IContainer
    Private toolTip1 As System.Windows.Forms.ToolTip
    Private calculatorControl1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
    Private fontListBox1 As Syncfusion.Windows.Forms.Tools.FontListBox
    Private fileloaded As Integer = 0

    Private prodDs1 As DataSet


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
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.fontListBox1 = New Syncfusion.Windows.Forms.Tools.FontListBox()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me.monthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.calculatorControl1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.htmluiControl1.SuspendLayout()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 315)
        Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(241, Byte))
        Me.htmluiControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.fontListBox1, Me.dataGrid1, Me.monthCalendar1})
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(0, 48)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 330)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=66, Height=15}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
        "y></html>"
        '
        'fontListBox1
        '
        Me.fontListBox1.Location = New System.Drawing.Point(248, 80)
        Me.fontListBox1.Name = "fontListBox1"
        Me.fontListBox1.Size = New System.Drawing.Size(120, 95)
        Me.fontListBox1.TabIndex = 4
        '
        'dataGrid1
        '
        Me.dataGrid1.AccessibleName = "DataGrid"
        Me.dataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(8, 176)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(304, 144)
        Me.dataGrid1.TabIndex = 2
        Me.toolTip1.SetToolTip(Me.dataGrid1, "This is a DataGrid control inside HTMLUI")
        '
        'monthCalendar1
        '
        Me.monthCalendar1.Location = New System.Drawing.Point(56, 8)
        Me.monthCalendar1.Name = "monthCalendar1"
        Me.monthCalendar1.TabIndex = 1
        '
        'calculatorControl1
        '
        Me.calculatorControl1.AccessibleDescription = "Calculator control"
        Me.calculatorControl1.AccessibleName = "Calculator Control"
        Me.calculatorControl1.AutoSize = False
        Me.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.calculatorControl1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.calculatorControl1.DoubleValue = 0
        Me.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.calculatorControl1.Location = New System.Drawing.Point(208, 0)
        Me.calculatorControl1.Name = "calculatorControl1"
        Me.calculatorControl1.RepeatAssignAction = True
        Me.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.calculatorControl1.Size = New System.Drawing.Size(184, 200)
        Me.calculatorControl1.TabIndex = 3
        Me.calculatorControl1.Text = "calculatorControl1"
        Me.calculatorControl1.ThemesEnabled = True
        Me.calculatorControl1.UseUserOverride = True
        Me.calculatorControl1.UseVisualStyle = False
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem4})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3})
        Me.menuItem1.Text = "File"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 0
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
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button2, Me.button1})
        Me.panel1.Location = New System.Drawing.Point(-9, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(569, 48)
        Me.panel1.TabIndex = 6
        '
        'button2
        '
        Me.button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Maroon
        Me.button2.Location = New System.Drawing.Point(344, 7)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(138, 30)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Load Custom Page2"
        '
        'button1
        '
        Me.button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(80, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(152, 31)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Load Custom Page1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
        Me.ClientSize = New System.Drawing.Size(550, 351)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Controls"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.htmluiControl1.ResumeLayout(False)
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fileloaded = 1
        LoadHTMLResource()
    End Sub

#Region "LOADUI"
    Private Function LoadHTMLResource() As Boolean
        Dim success As Boolean = False

        Try
            _assembly = System.Reflection.Assembly.GetExecutingAssembly()
            _htmlStream = CType(_assembly.GetManifestResourceStream("customcontrols.htm"), Stream)
            If Not _htmlStream Is Nothing Then
                Me.htmluiControl1.LoadHTML(_htmlStream)
                success = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return success
    End Function
#End Region



#Region "MENU_HANDLING"

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        MessageBox.Show(Me.htmluiControl1.Text)
    End Sub

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        Application.Exit()
    End Sub
#End Region

    Private Sub htmluiControl1_PreRenderDocument(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs) Handles htmluiControl1.PreRenderDocument
        Dim htmlelements As Hashtable = New Hashtable()
        htmlelements = e.Document.ElementsByUserID

        If Me.fileloaded = 1 Then
            Dim monthCalendarElement1 As BaseElement = CType(IIf(TypeOf htmlelements("monthCalendar1") Is BaseElement, htmlelements("monthCalendar1"), Nothing), BaseElement)
            Dim oTemp1 As CustomControlBase = New CustomControlBase(monthCalendarElement1, Me.monthCalendar1)


            Dim dataGridElement1 As BaseElement = CType(IIf(TypeOf htmlelements("dataGrid1") Is BaseElement, htmlelements("dataGrid1"), Nothing), BaseElement)
            Dim oTemp2 As CustomControlBase = New CustomControlBase(dataGridElement1, Me.dataGrid1)

        Else
            Dim calculatorElement1 As BaseElement = CType(IIf(TypeOf htmlelements("calc") Is BaseElement, htmlelements("calc"), Nothing), BaseElement)
            If calculatorElement1 IsNot Nothing Then

                Dim oTemp3 As CustomControlBase = New CustomControlBase(calculatorElement1, Me.calculatorControl1)
            End If
            Dim fontListElement1 As BaseElement = CType(IIf(TypeOf htmlelements("font") Is BaseElement, htmlelements("font"), Nothing), BaseElement)
            If fontListElement1 IsNot Nothing Then
                Dim oTemp4 As CustomControlBase = New CustomControlBase(fontListElement1, Me.fontListBox1)
            End If
        End If
    End Sub

    Private Sub CreateDataSet()
        Dim tableName As String = "Products"
        prodDs1 = New DataSet()
        prodDs1.Tables.Add(tableName)

        Dim ExpiresIn As DataColumn = prodDs1.Tables(tableName).Columns.Add("ExpiresIn", GetType(System.TimeSpan))
        Dim Quantity As DataColumn = prodDs1.Tables(tableName).Columns.Add("Quantity", GetType(Double))
        Dim Value As DataColumn = prodDs1.Tables(tableName).Columns.Add("Value", GetType(Double))

        Dim drEmpty As DataRow = prodDs1.Tables(tableName).NewRow()

        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(0)("ExpiresIn") = New TimeSpan(0, 8, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(0)("Quantity") = 45
        prodDs1.Tables(tableName).Rows(0)("Value") = 2000

        drEmpty = prodDs1.Tables(tableName).NewRow()

        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(1)("ExpiresIn") = New TimeSpan(0, 9, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(1)("Quantity") = 27
        prodDs1.Tables(tableName).Rows(1)("Value") = 3000

        drEmpty = prodDs1.Tables(tableName).NewRow()

        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(2)("ExpiresIn") = New TimeSpan(0, 10, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(2)("Quantity") = 35
        prodDs1.Tables(tableName).Rows(2)("Value") = 4000

        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(3)("ExpiresIn") = New TimeSpan(0, 11, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(3)("Quantity") = 49
        prodDs1.Tables(tableName).Rows(3)("Value") = 5000

        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(4)("ExpiresIn") = New TimeSpan(0, 12, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(4)("Quantity") = 55
        prodDs1.Tables(tableName).Rows(4)("Value") = 6000

        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(5)("ExpiresIn") = New TimeSpan(0, 13, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(5)("Quantity") = 16
        prodDs1.Tables(tableName).Rows(5)("Value") = 7000

        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(6)("ExpiresIn") = New TimeSpan(0, 14, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(6)("Quantity") = 26
        prodDs1.Tables(tableName).Rows(6)("Value") = 300


        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(7)("ExpiresIn") = New TimeSpan(0, 15, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(7)("Quantity") = 46
        prodDs1.Tables(tableName).Rows(7)("Value") = 6700


        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(8)("ExpiresIn") = New TimeSpan(0, 16, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(8)("Quantity") = 36
        prodDs1.Tables(tableName).Rows(8)("Value") = 5600


        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(9)("ExpiresIn") = New TimeSpan(0, 17, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(9)("Quantity") = 22
        prodDs1.Tables(tableName).Rows(9)("Value") = 3800


        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(10)("ExpiresIn") = New TimeSpan(0, 18, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(10)("Quantity") = 42
        prodDs1.Tables(tableName).Rows(10)("Value") = 4500


        drEmpty = prodDs1.Tables(tableName).NewRow()
        prodDs1.Tables(tableName).Rows.Add(drEmpty)
        prodDs1.Tables(tableName).Rows(11)("ExpiresIn") = New TimeSpan(0, 19, 0, 0, 0)
        prodDs1.Tables(tableName).Rows(11)("Quantity") = 52
        prodDs1.Tables(tableName).Rows(11)("Value") = 4350

        Me.dataGrid1.DataSource = Me.prodDs1.Tables(0)

    End Sub

    Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
        CreateDataSet()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.fileloaded = 1
        LoadHTMLResource()
    End Sub
    Private Sub LoadFromFile(ByVal fileName As String)
        Dim remString As String = "\\bin\\debug"
        Dim path As String = Application.StartupPath.Remove(Application.StartupPath.Length - remString.Length, remString.Length) + "files\" & fileName
        Me.htmluiControl1.LoadHTML(path)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.fileloaded = 2
        LoadFromFile("customcontrols2.htm")
    End Sub
End Class
