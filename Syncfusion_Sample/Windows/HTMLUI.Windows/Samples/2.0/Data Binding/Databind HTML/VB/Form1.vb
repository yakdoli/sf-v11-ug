Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms.HTMLUI

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    ''' <summary>
    ''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private manager As BindingManagerBase
		Private dataset As DataSet = New DataSet()
    Private panel1 As System.Windows.Forms.Panel
    Private elem As IHTMLElement
    Private Shared filePath As String = String.Empty

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
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.button3 = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.AutoRunScripts = True
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(507, 167)
        Me.htmluiControl1.BackColor = System.Drawing.Color.White
        Me.htmluiControl1.DefaultFormat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(534, 182)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html/>"
        '
        'panel1
        '
        Me.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
        Me.panel1.Location = New System.Drawing.Point(8, 184)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(536, 184)
        Me.panel1.TabIndex = 7
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
        Me.panel2.Location = New System.Drawing.Point(8, 32)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(536, 144)
        Me.panel2.TabIndex = 10
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.button3, Me.textBox2, Me.label4, Me.label3, Me.button2, Me.button1, Me.textBox1, Me.label2})
        Me.panel3.Location = New System.Drawing.Point(4, 4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(528, 136)
        Me.panel3.TabIndex = 9
        '
        'button3
        '
        Me.button3.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Maroon
        Me.button3.Location = New System.Drawing.Point(368, 26)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(136, 24)
        Me.button3.TabIndex = 17
        Me.button3.Text = "Apply Modified Style"
        '
        'textBox2
        '
        Me.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.textBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(112, 60)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(400, 22)
        Me.textBox2.TabIndex = 16
        Me.textBox2.Text = ""
        '
        'label4
        '
        Me.label4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(16, 60)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 16)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Style"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(16, 100)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Navigate"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button2
        '
        Me.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Maroon
        Me.button2.Location = New System.Drawing.Point(376, 94)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 24)
        Me.button2.TabIndex = 13
        Me.button2.Text = "Next >>"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(128, 94)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 24)
        Me.button1.TabIndex = 12
        Me.button1.Text = "<< Previous"
        '
        'textBox1
        '
        Me.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.textBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(112, 28)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(240, 22)
        Me.textBox1.TabIndex = 11
        Me.textBox1.Text = ""
        '
        'label2
        '
        Me.label2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(16, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 16)
        Me.label2.TabIndex = 10
        Me.label2.Text = "CSS Attribute"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Maroon
        Me.label1.Location = New System.Drawing.Point(96, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(376, 24)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Essential HTMLUI supports Cascading Style Sheets"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.label1, Me.panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Databind HTML"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.htmluiControl1.LoadFromString("<html><body style='padding-left: 8'><TABLE width='100%' height='100%'><TR><TD height='100%' width='100%'id='elem'>CSS Support for HTML Elements.</TD></TR></table></body></html>")
			elem = Me.htmluiControl1.Document.GetElementByUserId("elem")
			BindData()
		End Sub

		Private Sub BindData()

			Dim conn As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data source=" & "..\\..\\..\\..\\..\\..\\..\\..\\..\\common\\data\\pages.mdb"

			Dim adapter As OleDbDataAdapter = New OleDbDataAdapter()
			Dim query As String = "select * from pages"
			adapter.SelectCommand = New OleDbCommand(query, conn)

			adapter.Fill(dataset)

			manager = BindingContext(dataset.Tables(0))

			AddHandler manager.PositionChanged, AddressOf manager_PositionChanged

			RefreshPageText()
		End Sub

		Private Sub MovePosition(ByVal forward As Boolean)
			Dim currentPos As Integer = manager.Position
			Dim count As Integer = manager.Count

			If forward Then
				currentPos += 1
			Else
				currentPos = Math.Max(0, currentPos-1)
			End If

			If currentPos < count Then
				manager.Position = currentPos
			Else
				Return
			End If
		End Sub

		Private Sub manager_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
			RefreshPageText()
		End Sub

		Private Sub RefreshPageText()
			Dim currentPos As Integer = manager.Position
			GetAttributeToTextBox(currentPos)
			GetStyleToElem(currentPos)
		End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        MovePosition(False)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        MovePosition(True)
    End Sub

    Private Sub GetAttributeToTextBox(ByVal position As Integer)
        Dim attribute As String = CType(IIf(TypeOf dataset.Tables(0).Rows(position)("CSSAttribute") Is String, dataset.Tables(0).Rows(position)("CSSAttribute"), Nothing), String)
        Me.textBox1.Text = attribute
    End Sub

    Private Sub GetStyleToElem(ByVal position As Integer)
        Dim text As String = CType(IIf(TypeOf dataset.Tables(0).Rows(position)("PageText") Is String, dataset.Tables(0).Rows(position)("PageText"), Nothing), String)
        Me.elem.InnerHTML = text
        Dim styleCSS As String = CType(IIf(TypeOf dataset.Tables(0).Rows(position)("Style") Is String, dataset.Tables(0).Rows(position)("Style"), Nothing), String)
        Me.textBox2.Text = styleCSS
        If Me.elem.Attributes.Contains("style") = False Then
            Me.elem.Attributes.Add("style")
        End If
        If styleCSS <> String.Empty Then
            Me.elem.Attributes("style").Value = styleCSS
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        If Me.textBox1.Text = String.Empty OrElse Me.textBox2.Text = String.Empty Then
            Return

        Else
            If Me.elem.Attributes.Contains("style") = False Then
                Me.elem.Attributes.Add("style")
            End If
            If Me.textBox2.Text <> String.Empty Then
                Me.elem.Attributes("style").Value = Me.textBox2.Text
            End If
        End If
    End Sub

    Private Shared Function GetFilesLocation() As String
        If filePath <> String.Empty Then
            Return Nothing
        End If

        Dim path As String
        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        Dim slashPos As Integer = path.LastIndexOf("\", path.Length)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        If slashPos > 0 Then
            path = path.Substring(0, slashPos)
        End If
        path = path.Replace("file:\", "")
        filePath = path & "\files\"
        Return filePath
    End Function
End Class
