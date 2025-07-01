Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TabSplitterContainer_2005
	Public partial Class SplitWindowForm : Inherits Form
		Private basePath As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Resources\"
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal title As String, ByVal filename As String)
			Me.New()
			Me.Text = title
			Me.richTextBox1.LoadFile(basePath & filename)
		End Sub

		Public Property DesignWindow() As Image
			Get
				Return Me.pictureBox1.Image
			End Get
			Set
				Me.pictureBox1.Image = Value
			End Set
		End Property

		Public ReadOnly Property SplitView() As TabSplitterContainer
			Get
				Return Me.tabSplitterContainer1
			End Get
		End Property
	End Class
End Namespace