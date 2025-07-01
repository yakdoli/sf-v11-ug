Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace SaveDiagramAsBinary
	Partial Public Class SaveDialog
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SaveDialog))
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.lblName = New System.Windows.Forms.Label()
			Me.txtName = New System.Windows.Forms.TextBox()
			Me.lblResult = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' btnSave
			' 
			Me.btnSave.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnSave.Location = New System.Drawing.Point(302, 54)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(63, 25)
			Me.btnSave.TabIndex = 0
			Me.btnSave.Text = "Save"
			Me.btnSave.UseVisualStyleBackColor = True
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnCancel.Location = New System.Drawing.Point(379, 54)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(63, 25)
			Me.btnCancel.TabIndex = 0
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' lblName
			' 
			Me.lblName.AutoSize = True
			Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblName.Location = New System.Drawing.Point(18, 9)
			Me.lblName.Name = "lblName"
			Me.lblName.Size = New System.Drawing.Size(273, 22)
			Me.lblName.TabIndex = 1
			Me.lblName.Text = "Enter a name for the Diagram"
			' 
			' txtName
			' 
			Me.txtName.Location = New System.Drawing.Point(302, 12)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New System.Drawing.Size(153, 20)
			Me.txtName.TabIndex = 2
			' 
			' lblResult
			' 
			Me.lblResult.AutoSize = True
			Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblResult.ForeColor = System.Drawing.Color.Red
			Me.lblResult.Location = New System.Drawing.Point(17, 127)
			Me.lblResult.Name = "lblResult"
			Me.lblResult.Size = New System.Drawing.Size(0, 18)
			Me.lblResult.TabIndex = 3
			' 
			' SaveDialog
			' 
			Me.AcceptButton = Me.btnSave
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(467, 96)
			Me.Controls.Add(Me.lblResult)
			Me.Controls.Add(Me.txtName)
			Me.Controls.Add(Me.lblName)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSave)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SaveDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Save"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.SaveDialog_FormClosing)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnSave As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private lblName As System.Windows.Forms.Label
		Private txtName As System.Windows.Forms.TextBox
		Private lblResult As System.Windows.Forms.Label
	End Class
End Namespace