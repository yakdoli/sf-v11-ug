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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace PopupControls
	''' <summary>
	''' Summary description for PopupParentControl.
	''' </summary>
	Public Class PopupParentControl : Inherits System.Windows.Forms.UserControl
	Public WithEvents popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
	Private popupUserControl1 As PopupControls.PopupUserControl
	Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
	Private components As System.ComponentModel.IContainer

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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupParentControl))
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.popupUserControl1 = New Popup.PopupControls.PopupUserControl
            Me.button1 = New System.Windows.Forms.Button
            Me.popupControlContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.popupControlContainer1.Controls.Add(Me.label1)
            Me.popupControlContainer1.Controls.Add(Me.popupUserControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(32, 8)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.ParentControl = Me.button1
            Me.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.popupControlContainer1.Size = New System.Drawing.Size(384, 272)
            Me.popupControlContainer1.TabIndex = 1
            Me.popupControlContainer1.Visible = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
            Me.label1.ImageIndex = 0
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(208, 88)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(168, 88)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Demonstrates the implementation of a popup within another popup using PopUpContro" & _
                "lContainer."
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'popupUserControl1
            '
            Me.popupUserControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.popupUserControl1.Location = New System.Drawing.Point(8, 40)
            Me.popupUserControl1.Name = "popupUserControl1"
            Me.popupUserControl1.Size = New System.Drawing.Size(200, 224)
            Me.popupUserControl1.TabIndex = 0
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(40, 16)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(264, 32)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Show Popup in Popup:"
            '
            'PopupParentControl
            '
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Name = "PopupParentControl"
            Me.Size = New System.Drawing.Size(448, 312)
            Me.popupControlContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Me.popupControlContainer1.IsShowing() Then
				popupControlContainer1.HidePopup(PopupCloseType.Canceled)
			Else
				' Find my parent PopupControlContainer:
				If TypeOf Me.FindForm() Is PopupHost Then
					Dim pcc As PopupControlContainer = Nothing
					' Find the PopupControlContainer
					Dim c As Control
					For Each c In Me.FindForm().Controls
						If TypeOf c Is PopupControlContainer Then
							pcc = CType(IIf(TypeOf c Is PopupControlContainer, c, Nothing), PopupControlContainer)
							Exit For
						End If
					Next c
					' Need to do this only if the PopupControlContainer is currently showing
					If Not pcc Is Nothing AndAlso pcc.IsShowing() Then
						' Set up key relationship
						pcc.CurrentPopupChild = Me.popupControlContainer1
						Me.popupControlContainer1.PopupParent = pcc
					End If
				End If

				popupControlContainer1.ShowPopup(Point.Empty)
			End If
		End Sub
		' So that the child popup will close on MouseDown.
        Private Sub PopupParentControl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, button1.MouseDown
            Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
        End Sub
		Private Sub popupControlContainer1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupControlContainer1.Popup
			Me.popupControlContainer1.Focus()
		End Sub
	End Class
End Namespace
