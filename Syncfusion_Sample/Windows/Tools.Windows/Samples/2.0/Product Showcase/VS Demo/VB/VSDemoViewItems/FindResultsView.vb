Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for FindResults1.
	''' </summary>
	Public Class FindResultsView : Inherits System.Windows.Forms.UserControl
		Private listBox1 As System.Windows.Forms.ListBox
		Private panelfindResults As System.Windows.Forms.Panel
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

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

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panelfindResults = New System.Windows.Forms.Panel()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.panelfindResults.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelfindResults
			' 
			Me.panelfindResults.Controls.Add(Me.listBox1)
			Me.panelfindResults.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelfindResults.Location = New System.Drawing.Point(0, 0)
			Me.panelfindResults.Name = "panelfindResults"
			Me.panelfindResults.Size = New System.Drawing.Size(672, 190)
			Me.panelfindResults.TabIndex = 0
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.listBox1.ItemHeight = 15
			Me.listBox1.Items.AddRange(New Object() { "Find all ""BarManager"", SubFolders, Find Results 2, ""Current Project"".."})
			Me.listBox1.Location = New System.Drawing.Point(0, 0)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(672, 184)
			Me.listBox1.TabIndex = 0
			' 
			' FindResultsView
			' 
			Me.Controls.Add(Me.panelfindResults)
			Me.Name = "FindResultsView"
			Me.Size = New System.Drawing.Size(672, 190)
			Me.panelfindResults.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
