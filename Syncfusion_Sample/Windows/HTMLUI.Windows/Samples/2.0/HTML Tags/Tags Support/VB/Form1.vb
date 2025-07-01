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


Namespace HTMLUITagsSample
   '/ <summary>
   '/ Summary description for Form1.
   '/ </summary>
   
   Public Class Form1
      Inherits System.Windows.Forms.Form
      Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
      Private panel1 As System.Windows.Forms.Panel

        Private templateText As String = "<html><head>$head<title>Supported tags in HTMLUI control</title></head><body>$body</body></html>"
        Private WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing


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
        Friend WithEvents listBox1 As System.Windows.Forms.ListBox
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.Panel2 = New System.Windows.Forms.Panel
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'htmluiControl1
            '
            Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(3, 16)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.ShowTitle = False
            Me.htmluiControl1.Size = New System.Drawing.Size(340, 258)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 0
            Me.htmluiControl1.Text = resources.GetString("htmluiControl1.Text")
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(154, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(6, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(334, 39)
            Me.label1.TabIndex = 2
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel1
            '
            Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.panel1.Controls.Add(Me.listBox1)
            Me.panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(208, 376)
            Me.panel1.TabIndex = 1
            '
            'listBox1
            '
            Me.listBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.listBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.listBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listBox1.HorizontalScrollbar = True
            Me.listBox1.ItemHeight = 16
            Me.listBox1.Items.AddRange(New Object() {"A (Link) ", "B (Bold) ", "BR (Break line) ", "EM (Makes text italic) ", "FONT (Inline element for text) ", "H1 (Heading 1)", "H2 (Heading 2)", "H3 (Heading 3)", "H4 (Heading 4)", "H5 (Heading 5)", "H6 (Heading 6)", "HR (Horizontal line) ", "I (Makes text italic) ", "U(Underlines text) ", "IMG (Displays images) ", "LINK (Used for attaching CSS document) ", "SPAN (Inline element for applying CSS style) ", "STRONG (Makes text bold) ", "STYLE (Used for attaching CSS inside html document) ", "TITLE (You can see it on the top of control) ", "INPUT(Windows Forms controls, such a button, textbox, etc...) ", "SELECT(ListBox or ComboBox win controls) ", "TEXTAREA(Multiline TextBox win control) ", "CHECKBOX(CheckBox win control) ", "RADIO(RadioBox win control) ", "CODE(Inlinetag for representing code sample) ", "DIV(Block tag container) ", "FORM(Container for win controls) ", "BODY(Container of visual document data) ", "HEAD(Container for document's settings) ", "LI(Simple item of the list) ", "OL(Ordered list container) ", "P(Container of text paragraph) ", "PRE(Container of formated text) ", "SCRIPT(Container of script code) ", "TABLE(Represents table container) ", "TR(Container of single row in the table) ", "TD(Container of single cell in the table) ", "TH(Header of the column in the table) ", "UL(Unordered list container) "})
            Me.listBox1.Location = New System.Drawing.Point(8, 10)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(192, 356)
            Me.listBox1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.GroupBox2)
            Me.Panel2.Controls.Add(Me.GroupBox1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(206, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(346, 374)
            Me.Panel2.TabIndex = 3
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(346, 73)
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "HTML Tag code:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.htmluiControl1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox2.Location = New System.Drawing.Point(0, 97)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(346, 277)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "HTML Output:"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Tags Support"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
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


        Private Sub LoadHTML()
            Me.htmluiControl1.LoadFromString(templateText)
        End Sub 'LoadHTML


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            LoadHTML()
        End Sub 'Form1_Load


        Private Sub listBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBox1.SelectedIndexChanged
            Dim changedText As String = String.Empty
            Dim elementText As String = String.Empty
            Select Case Me.listBox1.SelectedIndex
                Case 0 'A Link
                    elementText = "<a href='test.htm'>Link</a>"
                    changedText = templateText.Replace("$body", elementText)
                Case 1 'B
                    elementText = "<b>Sample Text</b>"
                    changedText = templateText.Replace("$body", elementText)
                Case 2 'BR
                    elementText = "Line 1 <br />Line 2 <br />Line 3"
                    changedText = templateText.Replace("$body", elementText)
                Case 3 'EM
                    elementText = "<em>This &lt;em&gt; tag</em>"
                    changedText = templateText.Replace("$body", elementText)
                Case 4 'FONT
                    elementText = "<font face=""Courier New"" size=""6"">This is Courier New</font>"
                    changedText = templateText.Replace("$body", elementText)
                Case 5 'H1
                    elementText = "<h1>This is Heading 1</h1>"
                    changedText = templateText.Replace("$body", elementText)
                Case 6 'H2
                    elementText = "<h2>This is Heading 2</h2>"
                    changedText = templateText.Replace("$body", elementText)
                Case 7 'H3
                    elementText = "<h3>This is Heading 3</h3>"
                    changedText = templateText.Replace("$body", elementText)
                Case 8 'H4
                    elementText = "<h4>This is Heading 4</h4>"
                    changedText = templateText.Replace("$body", elementText)
                Case 9 'H5
                    elementText = "<h5>This is Heading 5</h5>"
                    changedText = templateText.Replace("$body", elementText)
                Case 10 'H6
                    elementText = "<h6>This is Heading 6</h6>"
                    changedText = templateText.Replace("$body", elementText)
                Case 11 'HR
                    elementText = "<hr>"
                    changedText = templateText.Replace("$body", elementText)
                Case 12 'I
                    elementText = "<i>This is &lt;i&gt; tag</i>"
                    changedText = templateText.Replace("$body", elementText)
                Case 13 'U
                    elementText = "<u>This is underlined text</u>"
                    changedText = templateText.Replace("$body", elementText)
                Case 14 'IMG
                    elementText = "<img src=""http://www.syncfusion.com/common/images/prodimages/htmlui_590_150.gif""></img>"
                    changedText = templateText.Replace("$body", elementText)
                Case 15 'LINK
                    elementText = "<LINK href=""http://www.syncfusion.com/include/ie4.css"" rel=""stylesheet"" type=""text/css"">"
                    changedText = templateText.Replace("$head", elementText)
                    elementText = "<p>Link to style sheet</p>"
                    changedText = templateText.Replace("$body", elementText)
                Case 16 'SPAN
                    elementText = "<p>This is a paragraph <span style=""color:#0000FF;"">This is a paragraph</span> This is a paragraph</p>"
                    changedText = templateText.Replace("$body", elementText)
                Case 17 'STRONG (Makes text bold) 
                    elementText = "<strong>Bold Text</strong>"
                    changedText = templateText.Replace("$body", elementText)
                Case 18 'STYLE (Used for attaching CSS inside html document) 
                    elementText = "<p>This is a paragraph <span style=""color:#0000FF;"">This is a paragraph</span> This is a paragraph</p>"
                    changedText = templateText.Replace("$body", elementText)
                Case 19 'TITLE (You can see it on the top of control) 
                    elementText = "<title>HTMLUI Sample Title</title>"
                    changedText = templateText.Replace("$head", elementText)
                Case 20 'INPUT(Windows Forms controls, such a button, textbox, etc...) 
                    elementText = "<form><input type=""text""></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 21 'SELECT(ListBox or ComboBox win controls) 
                    elementText = "<form><select><option value =""volvo"">Volvo</option><option value =""saab"">Saab</option><option value =""opel"">Opel</option><option value =""audi"">Audi</option></select></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 22 'TEXTAREA(Multiline TextBox win control) 
                    elementText = "<form><textarea rows=""2"" cols=""20"">Sample for textarea tag in HTMLUI.....</textarea></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 23 'CHECKBOX(CheckBox win control) 
                    elementText = "<form><input type=""checkbox""></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 24 'RADIO(RadioBox win control) 
                    elementText = "<form><input type=""radio""></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 25 'CODE(Inlinetag for representing code sample) 
                    elementText = "<code>Computer code text</code>"
                    changedText = templateText.Replace("$body", elementText)
                Case 26 'DIV(Block tag container) 
                    elementText = "This is some text <div style=""color:#FF0000;""><h4>This is a header in a div section</h4><p>This is a paragraph in a div section</p></div>"
                    changedText = templateText.Replace("$body", elementText)
                Case 27 'FORM(Container for win controls) 
                    elementText = "<form><input type=""radio""><p/><input type=""text""><p/><input type=""checkbox""></form>"
                    changedText = templateText.Replace("$body", elementText)
                Case 28 'BODY(Container of visual document data) 
                    elementText = "Text in body tag"
                    changedText = templateText.Replace("$body", elementText)
                Case 29 'HEAD(Container for document\'s settings) 
                    elementText = "Head tag"
                    changedText = templateText.Replace("$head", elementText)
                Case 30 'LI(Simple item of the list) 
                    elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>"
                    changedText = templateText.Replace("$body", elementText)
                Case 31 'OL(Ordered list container)
                    elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>"
                    changedText = templateText.Replace("$body", elementText)
                Case 32 'P(Container of text paragraph)
                    elementText = "<p>This is some text in a paragraph</p>"
                    changedText = templateText.Replace("$body", elementText)
                Case 33 'PRE(Container of formated text)
                    elementText = "<pre>This text is in a fixed-pitch font, and it preserves       spaces</pre>"
                    changedText = templateText.Replace("$body", elementText)
                Case 34 'SCRIPT(Container of script code)
                    elementText = "<script language=""C#"">Please refer to the scripting sample</script>"
                    changedText = templateText.Replace("$head", elementText)
                Case 35 'TABLE(Represents table container)
                    elementText = "<table border = ""1""><tr><td>Cell A</td><td>Cell B</td></tr></table>"
                    changedText = templateText.Replace("$body", elementText)
                Case 36 'TR(Container of single row in the table)
                    elementText = "<table border = ""1""><tr><td>Cell A</td><td>Cell B</td></tr></table>"
                    changedText = templateText.Replace("$body", elementText)
                Case 37 'TD(Container of single cell in the table)
                    elementText = "<table border = ""1""><tr><td>Cell A</td><td>Cell B</td></tr></table>"
                    changedText = templateText.Replace("$body", elementText)
                Case 38 'TH(Header of the column in the table) 
                    elementText = "<table border = ""1""><tr><th>Header 1</th><th>Header 2</th></tr><tr><td>Cell A</td><td>Cell B</td></tr></table>"
                    changedText = templateText.Replace("$body", elementText)
                Case 39 'UL(Unordered list container)
                    elementText = "<ul><li>Windows Forms</li><li>ASP.NET</li></ul>"
                    changedText = templateText.Replace("$body", elementText)
                Case Else
                    elementText = "Tag not specified"
                    changedText = templateText.Replace("$body", elementText)
            End Select

            Me.label1.Text = elementText
            Me.htmluiControl1.LoadFromString(changedText)
        End Sub 'listBox1_SelectedIndexChanged

    End Class 'Form1
End Namespace 'HTMLUITagsSample