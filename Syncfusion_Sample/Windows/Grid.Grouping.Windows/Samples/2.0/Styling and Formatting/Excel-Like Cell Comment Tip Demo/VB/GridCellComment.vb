Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Security.Permissions
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms

Namespace ExcelToolTip
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class GridCellComment
		Inherits MetroForm
		Friend comment As Label
		Friend editTextBox As RichTextBox
		Private dx As Integer = 20
		Private dy As Integer = 20


		Public Property CommentText() As String
			Get
				Return comment.Text
			End Get
			Set(ByVal value As String)
				comment.Text = value
			editTextBox.Text = value
			End Set
		End Property

		Public Property CommentFont() As Font
			Get
				Return comment.Font
			End Get
			Set(ByVal value As Font)
				comment.Font = value
			End Set
		End Property

		Public Property CommentCorner() As Size
			Get
				Return New Size(dx, dy)
			End Get
			Set(ByVal value As Size)
				dx = value.Width
				dy = value.Height
			End Set
		End Property

		Private minCommentWidth As Integer = 80
		Private minCommentHeight As Integer = 18

		Public Sub New()
			Dim width As Integer = minCommentWidth
			Dim height As Integer = minCommentHeight

			Me.comment = New System.Windows.Forms.Label()
			Me.editTextBox = New RichTextBox()
			Me.editTextBox.Visible = False
			Me.editTextBox.Multiline = True
			Me.editTextBox.BorderStyle = BorderStyle.None

			Me.SuspendLayout()
			' 
			' comment
			' 
			Me.comment.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)
			Me.comment.Location = New System.Drawing.Point(dx, dy)
			Me.comment.Name = "comment"
			Me.comment.Size = New System.Drawing.Size(width - 2 * dx, height - 2 * dy)
			Me.comment.TabIndex = 0
			Me.comment.Text = "Author:"
			Me.comment.Font = New Font(Me.Font, FontStyle.Bold)
			Me.comment.Dock = DockStyle.Fill

			' 
			' GridCellComment
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(width, height)
			Me.ControlBox = False
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.comment, Me.editTextBox})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "GridCellComment"
			Me.ResumeLayout(False)
			Me.CausesValidation = False
			Me.Visible = False
			Me.TopLevel = False


			Dim myGraphicsPath As New System.Drawing.Drawing2D.GraphicsPath()

			Dim points() As Point = {New Point(0, dy), New Point(0, height - dy), New Point(dx, height), New Point(width - dx, height), New Point(width, height - dy), New Point(width, dy), New Point(width - dx, 0), New Point(dx, 0), New Point(0, dy)}
			myGraphicsPath.AddPolygon(points)


			'BackColor = SystemColors.Info;


			dx = 10
			dy = 10
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then

			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub

		Private Sub InitializeComponent()
			Me.SuspendLayout()
			' 
			' GridCellComment
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(320, 246)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "GridCellComment"
			Me.ResumeLayout(False)

		End Sub

		Public Sub InitializeComment(ByVal row As Integer, ByVal col As Integer, ByVal pt As Point, ByVal text As String)
			Dim xPad As Integer = 15
			Dim yPad As Integer = 5
			Dim dy1 As Integer = 10
			Dim dx1 As Integer = 10

			If row = 0 Then
				dy1 = 0
			End If

			CommentCorner = New Size(dx1, dy1)

			Dim panelPoint As New Point(CInt(Fix(0.5)) * dy1, yPad)

			Me.CommentText = text

			pt.Offset(dx1, - dy1)
			Me.Location = pt

			Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
			Dim sz As SizeF = g.MeasureString(Me.CommentText, Me.Font)
			Dim height As Integer = CInt(Fix(2 * yPad + sz.Height)) '10 is fudge
			Dim width As Integer = CInt(Fix(2 * xPad + sz.Width))

			Me.Size = New Size(Math.Max(width, minCommentWidth), Math.Max(height, minCommentHeight))

			Me.comment.Location = panelPoint
			Me.comment.Size = New Size(width - 2 * panelPoint.X, height - 2 * panelPoint.Y)
		End Sub


	End Class

End Namespace
