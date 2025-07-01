Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for OutputWindow.
	''' </summary>
	Public Class OutputWindowView : Inherits System.Windows.Forms.UserControl
		Private panelOutputWindow As System.Windows.Forms.Panel
		Private outputTextBox As System.Windows.Forms.TextBox
		Private outputTypeComboBox As System.Windows.Forms.ComboBox
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
			Me.panelOutputWindow = New System.Windows.Forms.Panel()
			Me.outputTextBox = New System.Windows.Forms.TextBox()
			Me.outputTypeComboBox = New System.Windows.Forms.ComboBox()
			Me.panelOutputWindow.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelOutputWindow
			' 
			Me.panelOutputWindow.Controls.Add(Me.outputTextBox)
			Me.panelOutputWindow.Controls.Add(Me.outputTypeComboBox)
			Me.panelOutputWindow.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelOutputWindow.Location = New System.Drawing.Point(0, 0)
			Me.panelOutputWindow.Name = "panelOutputWindow"
			Me.panelOutputWindow.Size = New System.Drawing.Size(728, 190)
			Me.panelOutputWindow.TabIndex = 0
			' 
			' outputTextBox
			' 
			Me.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
			Me.outputTextBox.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.outputTextBox.Location = New System.Drawing.Point(0, 23)
			Me.outputTextBox.Multiline = True
			Me.outputTextBox.Name = "outputTextBox"
			Me.outputTextBox.Size = New System.Drawing.Size(728, 167)
			Me.outputTextBox.TabIndex = 3
			Me.outputTextBox.Text = "'VSDemo.exe': Loaded 'c:\suite showcase\tools\vsdemo\bin\debug\syncfusion.edit.dl" & "l', Symbols loaded."
			' 
			' outputTypeComboBox
			' 
			Me.outputTypeComboBox.Dock = System.Windows.Forms.DockStyle.Top
			Me.outputTypeComboBox.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.outputTypeComboBox.Location = New System.Drawing.Point(0, 0)
			Me.outputTypeComboBox.Name = "outputTypeComboBox"
			Me.outputTypeComboBox.Size = New System.Drawing.Size(728, 23)
			Me.outputTypeComboBox.TabIndex = 2
			Me.outputTypeComboBox.Text = "Debug"
			' 
			' OutputWindowView
			' 
			Me.Controls.Add(Me.panelOutputWindow)
			Me.Name = "OutputWindowView"
			Me.Size = New System.Drawing.Size(728, 190)
			Me.panelOutputWindow.ResumeLayout(False)
			Me.panelOutputWindow.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
