Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace CustomCodeEditorDemo
	''' <summary>
	''' Summary description for InsertText.
	''' </summary>
	Public Class InsertText : Inherits System.Windows.Forms.Form
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
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
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richTextBox1.Location = New System.Drawing.Point(8, 16)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Size = New System.Drawing.Size(252, 105)
			Me.richTextBox1.TabIndex = 0
			Me.richTextBox1.Text = ""
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Location = New System.Drawing.Point(12, 139)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(112, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Accept"
			' 
			' button2
			' 
			Me.button2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button2.Location = New System.Drawing.Point(148, 139)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(112, 23)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Cancel"
			' 
			' InsertText
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(272, 174)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.richTextBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "InsertText"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "InsertText"
'			Me.Closed += New System.EventHandler(Me.Form2_Closed);
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub Form2_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
			Me.richTextBox1.Text = String.Empty
		End Sub


		Public Shadows ReadOnly Property AcceptButton() As Button
			Get
				Return Me.button1
			End Get
		End Property

		Public Shadows ReadOnly Property CancelButton() As Button
			Get
				Return Me.button2
			End Get
		End Property

		Public ReadOnly Property InputString() As String
			Get
				Return Me.richTextBox1.Text
			End Get
		End Property



	End Class
End Namespace
