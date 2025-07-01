Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Drawing
Imports System.Reflection
Imports System.IO

Namespace TaskBar
	Friend Class StyleTaskBox
		Inherits XPTaskBarBox
		Private color1 As Color() = New Color() { Color.FromArgb(115, 137, 184), Color.FromArgb(127, 151, 199), Color.FromArgb(162, 183, 226), Color.FromArgb(178, 200, 250) }
		Protected Overrides Sub DrawHeader(ByVal e As PaintEventArgs)
			Dim g As Graphics = e.Graphics
			Dim header_rect As Rectangle = Me.GetHeaderRect()
			Dim font As Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold) ', System.Drawing.GraphicsUnit.Point, ((byte)(0)));

'			#Region "GradientBar appearance OnMouse hover"
			Dim bf As BrushInfo = New BrushInfo(GradientStyle.Vertical, color1)
			BrushPaint.FillRectangle(g, header_rect, bf)
'			#End Region

'			#Region "Set Image for Expander"
			Dim rect As Rectangle = New Rectangle(Me.ExpanderButton.Bounds.X - 10, Me.ExpanderButton.Bounds.Y - 5, Me.GetHeaderButtonSize().Height + 10, Me.GetHeaderButtonSize().Width + 10)
'			#Region "Embedding image as a resource"
			Dim asm As System.Reflection.Assembly = Me.GetType().Assembly
			Dim Xpand_str As Stream = asm.GetManifestResourceStream("Button-up.png")
			Dim Collapse_str As Stream = asm.GetManifestResourceStream("Button-down.png")
'			#End Region
			If Me.Collapsed AndAlso Me.Focused = True Then
				Dim img As Image = Image.FromStream(Collapse_str)

				g.DrawImage(img, rect)
			Else
				Dim img As Image = Image.FromStream(Xpand_str)
				g.DrawImage(img, rect)
			End If
'			#End Region

'			#Region "Border"
			Dim pen As Pen = New Pen(Color.FromArgb(117, 135, 185), 3)
			g.DrawRectangle(pen, header_rect)
'			#End Region

'			#Region "Draw Text"
			Dim bu As Brush = New SolidBrush(Color.White)
			g.DrawString(Me.Text, font, bu, header_rect.X + 10, header_rect.Y + 5)
'			#End Region
		End Sub


	End Class
End Namespace
