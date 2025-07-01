Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


Namespace PrivotGridSample
	''' <summary>
	''' Summary description for PropertyGridForm.
	''' </summary>
	Public Class PropertyGridForm
		Inherits System.Windows.Forms.Form
		Public AppearancePropertyGrid1 As System.Windows.Forms.PropertyGrid
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

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
			Me.AppearancePropertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.SuspendLayout()
			' 
			' AppearancePropertyGrid1
			' 
			Me.AppearancePropertyGrid1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(255))))))
			Me.AppearancePropertyGrid1.CommandsForeColor = System.Drawing.Color.MidnightBlue
			Me.AppearancePropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.AppearancePropertyGrid1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.AppearancePropertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(255))))))
			Me.AppearancePropertyGrid1.HelpForeColor = System.Drawing.Color.MidnightBlue
			Me.AppearancePropertyGrid1.LineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229))))))
			Me.AppearancePropertyGrid1.Location = New System.Drawing.Point(0, 0)
			Me.AppearancePropertyGrid1.Name = "AppearancePropertyGrid1"
			Me.AppearancePropertyGrid1.Size = New System.Drawing.Size(376, 614)
			Me.AppearancePropertyGrid1.TabIndex = 0
			' 
			' PropertyGridForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CausesValidation = False
			Me.ClientSize = New System.Drawing.Size(376, 614)
			Me.Controls.Add(Me.AppearancePropertyGrid1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "PropertyGridForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "PivotTable Appearance Properties"
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
