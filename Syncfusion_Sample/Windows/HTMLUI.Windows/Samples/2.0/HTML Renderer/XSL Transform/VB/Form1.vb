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
Imports System.Xml
Imports System.Xml.XPath
Imports System.Xml.Xsl
Imports Syncfusion.Windows.Forms.HTMLUI

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
        Private htmluiControl1 As HTMLUIControl
		Private _assembly As System.Reflection.Assembly
		Private _htmlStream As Stream

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'htmluiControl1
            '
            Me.htmluiControl1.AutoRunScripts = True
            Me.htmluiControl1.AutoScroll = True
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 359)
            Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.Size = New System.Drawing.Size(552, 374)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 0
            Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
            "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
            "=""True"" xsize=""{Width=71, Height=15}"" xlocation=""{X=10,Y=20}"">htmluiControl1</bo" & _
            "dy></html>"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "XSL Transform"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Function LoadHTMLResource() As Boolean
			Dim success As Boolean = False

			Try
				_assembly = System.Reflection.Assembly.GetExecutingAssembly()
				_htmlStream = CType(_assembly.GetManifestResourceStream("resfile.htm"), Stream)
				If Not _htmlStream Is Nothing Then
					Me.htmluiControl1.LoadHTML(_htmlStream)
					success = True
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
			Return success
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'LoadHTMLResource();
			Transform()
		End Sub

		Private Sub Transform()
			Try
				Dim _xmlStream As Stream = New MemoryStream()
				Dim _htmlStream As Stream = New MemoryStream()
				_assembly = System.Reflection.Assembly.GetExecutingAssembly()
				_xmlStream = CType(_assembly.GetManifestResourceStream("xmldata.xml"), Stream)
				Dim myXPathDoc As XPathDocument = New XPathDocument(_xmlStream)
                Dim myXslTrans As XslCompiledTransform = LoadXslTransformResource("xsltfile.xslt")
				myXslTrans.Transform(myXPathDoc,Nothing, _htmlStream)
				Dim myWriter As XmlTextWriter = New XmlTextWriter("result.html", Nothing)
				myXslTrans.Transform(myXPathDoc,Nothing, myWriter)
				myWriter.Close()
				Me.htmluiControl1.LoadHTML(Application.StartupPath.ToString() & "\result.html")
			Catch e As Exception

				Console.WriteLine("Exception: {0}", e.ToString())
			End Try

		End Sub

        Public Function LoadXslTransformResource(ByVal ResourceName As String) As XslCompiledTransform
            Dim xslt As XslCompiledTransform = New XslCompiledTransform()
            Dim sXML As String = ResourceToString(ResourceName)
            Dim rdr As XmlTextReader = New XmlTextReader(sXML, XmlNodeType.Document, Nothing)
            xslt.Load(rdr)
            Return xslt
        End Function

		Private Function ResourceToString(ByVal ResourceName As String) As String
			Dim strNameSpace As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString()
			Dim str As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("" & ResourceName)
			If str Is Nothing Then
				Return String.Empty
			End If

			Dim ba As Byte() = New Byte(str.Length - 1) {}
			str.Read(ba, 0, CInt(str.Length))
			Dim oEncoder As System.Text.ASCIIEncoding = New System.Text.ASCIIEncoding()
			Return oEncoder.GetString(ba)
		End Function



	End Class
End Namespace
