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
      Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
      Private _assembly As [Assembly]
      Private _htmlStream As Stream
      
      Private htmlelements As New Hashtable()
      
      Private text1Element As BaseElement
      Private radio1Element As BaseElement
      Private checkBox1Element As BaseElement
      Private image1Element As BaseElement
      Private button1Element As BaseElement
      Private outputCellElement As BaseElement
      
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
    Friend WithEvents label1 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 289)
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(0, 72)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 304)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=77, Height=14}"" xlocation=""{X=10,Y=20}"">htmluiControl1</bo" & _
        "dy></html>"
        '
        'label1
        '
        Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(552, 72)
        Me.label1.TabIndex = 3
        Me.label1.Text = "HTMLUI Element Events"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Element Events"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
      
      
      Private Function LoadHTMLResource() As Boolean
         Dim success As Boolean = False
         
         Try
            _assembly = [Assembly].GetExecutingAssembly()
            _htmlStream = CType(_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.events.htm"), Stream)
            If Not (_htmlStream Is Nothing) Then
               Me.htmluiControl1.LoadHTML(_htmlStream)
               success = True
            End If
         Catch ex As Exception
            MessageBox.Show(ex.ToString())
         End Try
         Return success
      End Function 'LoadHTMLResource
      
      
      Private Sub WireElements()
         Try
            htmlelements = Me.htmluiControl1.Document.GetElementsByUserIdHash()
            
            Me.text1Element = htmlelements("Text1") '
            'ToDo: Error processing original source shown below
            '
            '    this.text1Element  = htmlelements["text1"] as BaseElement;
            '------------------------------------------------^--- Syntax error: ';' expected
            Me.radio1Element = htmlelements("Radio1") '
            'ToDo: Error processing original source shown below
            '    this.text1Element  = htmlelements["text1"] as BaseElement;
            '    this.radio1Element = htmlelements["radio1"] as BaseElement;
            '-------------------------------------------------^--- Syntax error: ';' expected
            Me.checkBox1Element = htmlelements("CheckBox1") '
            'ToDo: Error processing original source shown below
            '    this.radio1Element = htmlelements["radio1"] as BaseElement;
            '    this.checkBox1Element = htmlelements["checkBox1"] as BaseElement;
            '-------------------------------------------------------^--- Syntax error: ';' expected
            Me.image1Element = htmlelements("Image1") '
            'ToDo: Error processing original source shown below
            '    this.checkBox1Element = htmlelements["checkBox1"] as BaseElement;
            '    this.image1Element = htmlelements["image1"] as BaseElement;
            '-------------------------------------------------^--- Syntax error: ';' expected
            Me.button1Element = htmlelements("Button1") '
            'ToDo: Error processing original source shown below
            '    this.image1Element = htmlelements["image1"] as BaseElement;
            '    this.button1Element = htmlelements["button1"] as BaseElement;
            '---------------------------------------------------^--- Syntax error: ';' expected
            Me.outputCellElement = htmlelements("outputCell") '
            'ToDo: Error processing original source shown below
            '    this.button1Element = htmlelements["button1"] as BaseElement;
            '    this.outputCellElement = htmlelements["outputCell"] as BaseElement;
            '---------------------------------------------------------^--- Syntax error: ';' expected
            
            AddHandler Me.text1Element.Click, AddressOf element_Click
            AddHandler Me.text1Element.DoubleClick, AddressOf element_DoubleClick
            AddHandler Me.text1Element.KeyDown, AddressOf element_KeyDown
            AddHandler Me.text1Element.KeyPress, AddressOf element_KeyPress
            AddHandler Me.text1Element.KeyUp, AddressOf element_KeyUp
            AddHandler Me.text1Element.MouseDown, AddressOf element_MouseDown
            AddHandler Me.text1Element.MouseEnter, AddressOf element_MouseEnter
            AddHandler Me.text1Element.MouseLeave, AddressOf element_MouseLeave
            AddHandler Me.text1Element.MouseMove, AddressOf element_MouseMove
            
            AddHandler Me.radio1Element.Click, AddressOf element_Click
            AddHandler Me.radio1Element.DoubleClick, AddressOf element_DoubleClick
            AddHandler Me.radio1Element.KeyDown, AddressOf element_KeyDown
            AddHandler Me.radio1Element.KeyPress, AddressOf element_KeyPress
            AddHandler Me.radio1Element.KeyUp, AddressOf element_KeyUp
            AddHandler Me.radio1Element.MouseDown, AddressOf element_MouseDown
            AddHandler Me.radio1Element.MouseEnter, AddressOf element_MouseEnter
            AddHandler Me.radio1Element.MouseLeave, AddressOf element_MouseLeave
            AddHandler Me.radio1Element.MouseMove, AddressOf element_MouseMove
            
            
            AddHandler Me.checkBox1Element.Click, AddressOf element_Click
            AddHandler Me.checkBox1Element.DoubleClick, AddressOf element_DoubleClick
            AddHandler Me.checkBox1Element.KeyDown, AddressOf element_KeyDown
            AddHandler Me.checkBox1Element.KeyPress, AddressOf element_KeyPress
            AddHandler Me.checkBox1Element.KeyUp, AddressOf element_KeyUp
            AddHandler Me.checkBox1Element.MouseDown, AddressOf element_MouseDown
            AddHandler Me.checkBox1Element.MouseEnter, AddressOf element_MouseEnter
            AddHandler Me.checkBox1Element.MouseLeave, AddressOf element_MouseLeave
            AddHandler Me.checkBox1Element.MouseMove, AddressOf element_MouseMove
            
            AddHandler Me.image1Element.Click, AddressOf element_Click
            AddHandler Me.image1Element.DoubleClick, AddressOf element_DoubleClick
            AddHandler Me.image1Element.KeyDown, AddressOf element_KeyDown
            AddHandler Me.image1Element.KeyPress, AddressOf element_KeyPress
            AddHandler Me.image1Element.KeyUp, AddressOf element_KeyUp
            AddHandler Me.image1Element.MouseDown, AddressOf element_MouseDown
            AddHandler Me.image1Element.MouseEnter, AddressOf element_MouseEnter
            AddHandler Me.image1Element.MouseLeave, AddressOf element_MouseLeave
            AddHandler Me.image1Element.MouseMove, AddressOf element_MouseMove
            
            AddHandler Me.button1Element.Click, AddressOf element_Click
            AddHandler Me.button1Element.DoubleClick, AddressOf element_DoubleClick
            AddHandler Me.button1Element.KeyDown, AddressOf element_KeyDown
            AddHandler Me.button1Element.KeyPress, AddressOf element_KeyPress
            AddHandler Me.button1Element.KeyUp, AddressOf element_KeyUp
            AddHandler Me.button1Element.MouseDown, AddressOf element_MouseDown
            AddHandler Me.button1Element.MouseEnter, AddressOf element_MouseEnter
            AddHandler Me.button1Element.MouseLeave, AddressOf element_MouseLeave
            AddHandler Me.button1Element.MouseMove, AddressOf element_MouseMove
         Catch ex As Exception
            Console.WriteLine(ex.ToString())
         End Try
      End Sub 'WireElements
      
      
    Private Sub element_Click(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "Click")
    End Sub 'element_Click


    Private Sub element_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "DoubleClick")
    End Sub 'element_DoubleClick


    Private Sub element_KeyDown(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "KeyDown")
    End Sub 'element_KeyDown


    Private Sub element_KeyPress(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "KeyPress")
    End Sub 'element_KeyPress


    Private Sub element_KeyUp(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "KeyUp")
    End Sub 'element_KeyUp


    Private Sub element_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "MouseDown")
    End Sub 'element_MouseDown


    Private Sub element_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "MouseLeave")
    End Sub 'element_MouseLeave


    Private Sub element_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "MouseEnter")
    End Sub 'element_MouseEnter


    Private Sub element_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        OutputEvent(sender, "MouseMove")
    End Sub 'element_MouseMove


    Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
        WireElements()
    End Sub 'htmluiControl1_LoadFinished


    Private Sub OutputEvent(ByVal sender As Object, ByVal eventName As String)
        Me.outputCellElement.InnerHTML = CType(sender, BaseElement).ID + " " + eventName + "<br>" + Me.outputCellElement.InnerHTML
    End Sub 'OutputEvent


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadHTMLResource()
    End Sub 'Form1_Load
End Class 'Form1