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


Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace PopupControls
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		' Syncfusion Changes: Using this custom PopupControlContainer derived class.
		Private popupControlContainer1 As PopupControlContainer
		Private popupParentControl1 As PopupControls.PopupParentControl
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			' Syncfusion notes: Setup the parent/child relationship.
			'this.popupParentControl1.popupControlContainer1.PopupParent = this.popupControlContainer1;
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.button1 = New System.Windows.Forms.Button()
			Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
			Me.popupParentControl1 = New PopupControls.PopupParentControl()
			Me.popupControlContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(32, 16)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(192, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Show Popup"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.popupControlContainer1.Controls.AddRange(New System.Windows.Forms.Control() { Me.popupParentControl1})
			Me.popupControlContainer1.Location = New System.Drawing.Point(32, 64)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.ParentControl = Me.button1
			Me.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.popupControlContainer1.Size = New System.Drawing.Size(376, 104)
			Me.popupControlContainer1.TabIndex = 2
			Me.popupControlContainer1.Visible = False
			' 
			' popupParentControl1
			' 
			Me.popupParentControl1.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.popupParentControl1.Location = New System.Drawing.Point(8, 16)
			Me.popupParentControl1.Name = "popupParentControl1"
			Me.popupParentControl1.Size = New System.Drawing.Size(432, 448)
			Me.popupParentControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(584, 390)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.popupControlContainer1, Me.button1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "PopUp In PopUp "
			Me.popupControlContainer1.ResumeLayout(False)
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

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			' Toggle popup.
			If Me.popupControlContainer1.IsShowing() Then
				popupControlContainer1.HidePopup(PopupCloseType.Canceled)
			Else
				popupControlContainer1.ShowPopup(Point.Empty)
				popupControlContainer1.Focus()
			End If
		End Sub
	End Class
End Namespace
