Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace ExcelLikeUI_2005
	''' <summary>
	''' Summary description for Unhide.
	''' </summary>
	Public Class Unhide
		Inherits Office2007Form
		Private okButton As ButtonAdv
        Private Shadows cancelButton As ButtonAdv
		Friend sheetListBox As System.Windows.Forms.ListBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK

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
			Me.sheetListBox = New System.Windows.Forms.ListBox()
			Me.okButton = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.cancelButton = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.SuspendLayout()
			' 
			' sheetListBox
			' 
			Me.sheetListBox.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sheetListBox.Location = New System.Drawing.Point(8, 16)
			Me.sheetListBox.Name = "sheetListBox"
			Me.sheetListBox.Size = New System.Drawing.Size(216, 108)
			Me.sheetListBox.TabIndex = 0
			' 
			' okButton
			' 
			Me.okButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.okButton.Location = New System.Drawing.Point(45, 147)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New System.Drawing.Size(75, 23)
			Me.okButton.TabIndex = 1
			Me.okButton.Text = "OK"
			Me.okButton.UseVisualStyle = True
			' 
			' cancelButton
			' 
			Me.cancelButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.cancelButton.Location = New System.Drawing.Point(149, 147)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(75, 23)
			Me.cancelButton.TabIndex = 2
			Me.cancelButton.Text = "Cancel"
			Me.cancelButton.UseVisualStyle = True
			' 
			' Unhide
			' 
			Me.AcceptButton = Me.okButton
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(254))))))
			Me.CancelButton = Me.cancelButton
			Me.ClientSize = New System.Drawing.Size(236, 182)
			Me.Controls.Add(Me.cancelButton)
			Me.Controls.Add(Me.okButton)
			Me.Controls.Add(Me.sheetListBox)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(248, 248)
			Me.MinimizeBox = False
			Me.Name = "Unhide"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Unhide"
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
