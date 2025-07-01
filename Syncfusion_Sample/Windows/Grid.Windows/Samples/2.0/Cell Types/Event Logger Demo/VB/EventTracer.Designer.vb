Imports Microsoft.VisualBasic
Imports System
Namespace ComboboxCells
	Partial Public Class EventTracer
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.output = New Syncfusion.Windows.Forms.Grid.GridControl()
			CType(Me.output, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' output
			' 
			Me.output.Location = New System.Drawing.Point(0, 0)
			Me.output.ThemesEnabled = True
			Me.output.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.output.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.BackColor = System.Drawing.Color.White
			'this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			'this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			Me.output.Name = "output"
			Me.output.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.output.Size = New System.Drawing.Size(600, 150)
			Me.output.SmartSizeBox = False
			Me.output.TabIndex = 0
			Me.output.Text = "gridControl1"
			Me.output.UseRightToLeftCompatibleTextBox = True
			' 
			' EventTracer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.output)
			Me.Name = "EventTracer"
			Me.Size = New System.Drawing.Size(516, 151)
			CType(Me.output, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Public output As Syncfusion.Windows.Forms.Grid.GridControl

	End Class
End Namespace
