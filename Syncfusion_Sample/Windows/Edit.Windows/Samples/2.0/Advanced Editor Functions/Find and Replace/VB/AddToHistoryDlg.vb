Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace FindReplaceDemo
	''' <summary>
	''' Summary description for History.
	''' </summary>
	Public Class AddToHistoryDlg : Inherits System.Windows.Forms.Form
		Private label2 As System.Windows.Forms.Label
		Private txtaddedItem As System.Windows.Forms.TextBox
		Private WithEvents btnOK As System.Windows.Forms.Button
		Private WithEvents BtnCancel As System.Windows.Forms.Button

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
            InitializeComponent()

            Me.AcceptButton.DialogResult = Windows.Forms.DialogResult.OK
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
            Me.label2 = New System.Windows.Forms.Label
            Me.txtaddedItem = New System.Windows.Forms.TextBox
            Me.btnOK = New System.Windows.Forms.Button
            Me.BtnCancel = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(16, 24)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(72, 16)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Add Item"
            '
            'txtaddedItem
            '
            Me.txtaddedItem.Location = New System.Drawing.Point(96, 22)
            Me.txtaddedItem.Name = "txtaddedItem"
            Me.txtaddedItem.Size = New System.Drawing.Size(192, 20)
            Me.txtaddedItem.TabIndex = 4
            '
            'btnOK
            '
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(48, 56)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(90, 28)
            Me.btnOK.TabIndex = 5
            Me.btnOK.Text = "Add"
            '
            'BtnCancel
            '
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.Location = New System.Drawing.Point(200, 56)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(90, 28)
            Me.BtnCancel.TabIndex = 6
            Me.BtnCancel.Text = "Cancel"
            '
            'AddToHistoryDlg
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(312, 102)
            Me.Controls.Add(Me.BtnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.txtaddedItem)
            Me.Controls.Add(Me.label2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "AddToHistoryDlg"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "History"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region




		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

		End Sub

		Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
			Return
		End Sub

		Public ReadOnly Property addedItem() As String
			Get
				Return Me.txtaddedItem.Text
			End Get
		End Property
	End Class
End Namespace
