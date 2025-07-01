Imports Microsoft.VisualBasic
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
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace TestEngineOptimizations
	''' <summary>
	''' Summary description for LogWindow.
	''' </summary>
	Public Class LogWindow
		Inherits MetroForm
		Private listBox1 As System.Windows.Forms.ListBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			tw = New ListboxTextWriter(Me.listBox1)
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private tw As ListboxTextWriter

		Public ReadOnly Property Log() As ListboxTextWriter
			Get
				Return tw
			End Get
		End Property


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.SuspendLayout()
            '
            'listBox1
            '
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.HorizontalScrollbar = True
            Me.listBox1.Location = New System.Drawing.Point(0, 0)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(680, 277)
            Me.listBox1.TabIndex = 0
            '
            'LogWindow
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(680, 278)
            Me.Controls.Add(Me.listBox1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "LogWindow"
            Me.Text = "Log Window"
            Me.ResumeLayout(False)

        End Sub
		#End Region
	End Class

	Public Class ListboxTextWriter
		Inherits TextWriter
		Private lb As ListBox
		Private lastItem As String = ""

		Public Sub New(ByVal lb As ListBox)
			Me.lb = lb
		End Sub

		Public Overrides Overloads Sub Write(ByVal buffer() As Char, ByVal index As Integer, ByVal count As Integer)
			lastItem = New String(buffer, index, count).TrimEnd(ControlChars.Cr, ControlChars.Lf, ControlChars.NullChar)
			MyBase.Write (buffer, index, count)
			lb.Items.Add(lastItem)
			lb.SelectedIndex = lb.Items.Count-1
		End Sub

		Public Overrides ReadOnly Property Encoding() As System.Text.Encoding
			Get
				Return System.Text.Encoding.Unicode
			End Get
		End Property


	End Class
End Namespace
