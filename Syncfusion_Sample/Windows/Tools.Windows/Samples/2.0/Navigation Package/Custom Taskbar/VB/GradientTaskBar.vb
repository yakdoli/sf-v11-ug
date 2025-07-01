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
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools

Namespace TaskBar
	''' <summary>
	''' Summary description for GradientTaskBar.
	''' </summary>
	Public Class GradientTaskBar
		Inherits XPTaskBar
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private blendImage_Renamed As Image
		Private gradientStartColor_Renamed As Color
		Private gradientEndColor_Renamed As Color

		Public Sub New(ByVal container As System.ComponentModel.IContainer)
			''' <summary>
			''' Required for Windows.Forms Class Composition Designer support
			''' </summary>
			container.Add(Me)
			InitializeComponent()

			gradientStartColor_Renamed = Color.FromArgb(255, 237, 241, 242)
			gradientEndColor_Renamed = Color.FromArgb(255, 42, 78, 129)

			' Activates double buffering
			SetStyle(ControlStyles.UserPaint, True)
			SetStyle(ControlStyles.AllPaintingInWmPaint, True)
			SetStyle(ControlStyles.DoubleBuffer, True)
			SetStyle(ControlStyles.ResizeRedraw, True)
		End Sub

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			gradientStartColor_Renamed = Color.FromArgb(255, 237, 241, 242)
			gradientEndColor_Renamed = Color.FromArgb(255, 42, 78, 129)

			' Activates double buffering
			SetStyle(ControlStyles.UserPaint, True)
			SetStyle(ControlStyles.AllPaintingInWmPaint, True)
			SetStyle(ControlStyles.DoubleBuffer, True)
		End Sub

		<Browsable(True), Category("Appearance"), Description("Gradient starting color (used at the left edge)")> _
		Public Property GradientStartColor() As Color
			Get
				Return gradientStartColor_Renamed
			End Get

			Set(ByVal value As Color)
				Me.gradientStartColor_Renamed = value
				Invalidate()
			End Set
		End Property

		<Browsable(True), Category("Appearance"), Description("Gradient ending color")> _
		Public Property GradientEndColor() As Color
			Get
				Return gradientEndColor_Renamed
			End Get

			Set(ByVal value As Color)
				Me.gradientEndColor_Renamed = value
				Invalidate()
			End Set
		End Property

		<Browsable(True), Category("Appearance"), Description("Background image to be blended in at the bottom of the panel")> _
		Public Property BlendImage() As Image
			Get
				Return blendImage_Renamed
			End Get

			Set(ByVal value As Image)
				Me.blendImage_Renamed = value
				Invalidate()
			End Set
		End Property

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()
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

		Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
			Dim rc As Rectangle = Me.ClientRectangle
			Dim gradientWidth As Integer = rc.Width
			Dim linGrBrush As LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(New Point(0, 10), New Point(gradientWidth, 10), gradientStartColor_Renamed, gradientEndColor_Renamed)

			Dim positions As Single() = { 0.0f, 0.05f, 0.95f, 1.0f }
			Dim factors As Single() = { 0.4f, 1.0f, 0.5f, 0.4f }

			'Create a Blend object and assign it to linGrBrush.
			Dim blend As Blend = New Blend()
			blend.Factors = factors
			blend.Positions = positions
			linGrBrush.Blend = blend

			' draw the gradient on the left edge
			e.Graphics.FillRectangle(linGrBrush, 0, 0, gradientWidth + 5, rc.Height)

			' draw a filled rectangle rest of the area
			Using brush As Brush = New SolidBrush(gradientEndColor_Renamed)
				e.Graphics.FillRectangle(brush, gradientWidth, 0, rc.Width - gradientWidth, rc.Height)
			End Using
			linGrBrush.Dispose()


			' get the image from a resource file
			If Not blendImage_Renamed Is Nothing Then
				Dim ia As ImageAttributes = New ImageAttributes()
				Dim cm As ColorMatrix = New ColorMatrix()
				cm.Matrix00 = 1
				cm.Matrix11 = 1
				cm.Matrix22 = 1
				Dim transparancy As Single =.14f
				cm.Matrix33 = transparancy
				ia.SetColorMatrix(cm)
				Dim imgWidth As Integer = blendImage_Renamed.Width
				Dim imgHeight As Integer = blendImage_Renamed.Height
				Dim destRect As Rectangle = New Rectangle(rc.Width - imgWidth, rc.Height - imgHeight, imgWidth, imgHeight)
				e.Graphics.DrawImage(blendImage_Renamed, destRect, 0, 0, imgWidth, imgHeight, GraphicsUnit.Pixel, ia)
			End If
		End Sub
	End Class
End Namespace
