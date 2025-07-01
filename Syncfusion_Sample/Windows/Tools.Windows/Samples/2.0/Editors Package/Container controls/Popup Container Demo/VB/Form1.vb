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
	Imports System.Reflection
Namespace PopupControlContainerDemo

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private label1 As System.Windows.Forms.Label
		Private WithEvents sourceTextBox As System.Windows.Forms.TextBox
		Private popupTextBox As System.Windows.Forms.TextBox
		Private WithEvents OK As System.Windows.Forms.Button
		Private WithEvents cancel As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents dropDownBtn As System.Windows.Forms.Button
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

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

		' <samplecodeblock name="PopupControlContainer Initialization">
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			' It's recommended that you keep the PopupControlContainer unparented by
			' any Control on the Form (which will be the default case as set up during design-time).
			' Otherwise, the Form wouldn't close sometimes, after dropping down this popup!
			Me.popupControlContainer1.Parent.Controls.Remove(Me.popupControlContainer1)
		End Sub

		#Region "Windows Form Designer generated code"
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
            Me.cancel = New System.Windows.Forms.Button
            Me.OK = New System.Windows.Forms.Button
            Me.popupTextBox = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.sourceTextBox = New System.Windows.Forms.TextBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.dropDownBtn = New System.Windows.Forms.Button
            Me.popupControlContainer1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.popupControlContainer1.Controls.Add(Me.cancel)
            Me.popupControlContainer1.Controls.Add(Me.OK)
            Me.popupControlContainer1.Controls.Add(Me.popupTextBox)
            Me.popupControlContainer1.Location = New System.Drawing.Point(16, 104)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(120, 128)
            Me.popupControlContainer1.TabIndex = 0
            Me.popupControlContainer1.Visible = False
            '
            'cancel
            '
            Me.cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cancel.Location = New System.Drawing.Point(56, 96)
            Me.cancel.Name = "cancel"
            Me.cancel.Size = New System.Drawing.Size(56, 24)
            Me.cancel.TabIndex = 2
            Me.cancel.Text = "Cancel"
            '
            'OK
            '
            Me.OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OK.Location = New System.Drawing.Point(8, 96)
            Me.OK.Name = "OK"
            Me.OK.Size = New System.Drawing.Size(48, 24)
            Me.OK.TabIndex = 1
            Me.OK.Text = "OK"
            '
            'popupTextBox
            '
            Me.popupTextBox.Location = New System.Drawing.Point(0, 0)
            Me.popupTextBox.Multiline = True
            Me.popupTextBox.Name = "popupTextBox"
            Me.popupTextBox.Size = New System.Drawing.Size(118, 90)
            Me.popupTextBox.TabIndex = 0
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label1.ImageIndex = 1
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(240, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(272, 80)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Associate a PopupControlContainer with this TextBox. And also transfer data back " & _
                "and forth between the popup and the TextBox."
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            '
            'sourceTextBox
            '
            Me.sourceTextBox.Location = New System.Drawing.Point(8, 40)
            Me.sourceTextBox.Name = "sourceTextBox"
            Me.sourceTextBox.Size = New System.Drawing.Size(176, 20)
            Me.sourceTextBox.TabIndex = 2
            Me.sourceTextBox.Text = "Alt+DownArrow for popup"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.dropDownBtn)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.sourceTextBox)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Location = New System.Drawing.Point(8, 8)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(536, 320)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "PopupControlContainer demo"
            '
            'dropDownBtn
            '
            Me.dropDownBtn.Image = CType(resources.GetObject("dropDownBtn.Image"), System.Drawing.Image)
            Me.dropDownBtn.Location = New System.Drawing.Point(192, 40)
            Me.dropDownBtn.Name = "dropDownBtn"
            Me.dropDownBtn.Size = New System.Drawing.Size(26, 20)
            Me.dropDownBtn.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(552, 332)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Popup Container Demo"
            Me.popupControlContainer1.ResumeLayout(False)
            Me.popupControlContainer1.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New Form1())
		End Sub


        Private Sub textBoxPopupParent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sourceTextBox.KeyDown
            ' Using this unconventional if statement syntax to avoid "and" symbol (documentation restriction, please ignore).

            ' If user pressed key down, then show the popup.
            If e.Alt Then
                If e.KeyCode = Keys.Down Then
                    If (Not Me.popupControlContainer1.IsShowing()) Then
                        ' Let the popup align around the source textBox.
                        Me.popupControlContainer1.ParentControl = Me.sourceTextBox
                        ' Passing Point.Empty will align it automatically around the above ParentControl.
                        Me.popupControlContainer1.ShowPopup(Point.Empty)

                        e.Handled = True
                    End If
                End If
            End If
            ' Escape should close the popup.
            If e.KeyCode = Keys.Escape Then
                If Me.popupControlContainer1.IsShowing() Then
                    Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
                End If
            End If
        End Sub

        Private Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
            Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
        End Sub

        Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancel.Click
            Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
        End Sub


        Private Sub popupControlContainer1_BeforePopup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles popupControlContainer1.BeforePopup
            ' Set the text to be edited with the text in the form text box.
            Me.popupTextBox.Text = Me.sourceTextBox.Text
            Me.popupControlContainer1.BackColor = Color.FromArgb(227, 241, 254)
        End Sub

        Private Sub popupControlContainer1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupControlContainer1.Popup
            ' Set the focus on the text box inside the popup after its open.
            Me.popupTextBox.Focus()
            Me.popupTextBox.SelectionStart = 0
            Me.popupTextBox.SelectionLength = 0
        End Sub

        Private Sub popupControlContainer1_CloseUp(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.PopupClosedEventArgs) Handles popupControlContainer1.CloseUp
            ' Transfer data from the popup.
            If args.PopupCloseType = PopupCloseType.Done Then
                Me.sourceTextBox.Text = Me.popupTextBox.Text
            End If
            ' Set focus back to textbox.
            If args.PopupCloseType = PopupCloseType.Done OrElse args.PopupCloseType = PopupCloseType.Canceled Then
                Me.sourceTextBox.Focus()
            End If
        End Sub

        ' </samplecodeblock>
#Region "ShowPopup"
        Private Sub dropDownBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropDownBtn.Click
            Me.popupControlContainer1.ParentControl = Me.sourceTextBox
            Me.popupControlContainer1.ShowPopup(Point.Empty)
        End Sub
#End Region
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
