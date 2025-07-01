Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports DemoCommon.Diagram

Namespace ControlsGalore
	''' <summary>
	''' Sample application form.
	''' </summary>
	Public Class Form1
		Inherits DemoForm
		#Region "Form controls"

		Private openDiagramDialog As OpenFileDialog
		Private saveDiagramDialog As SaveFileDialog
		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel3 As Expander
		Private diagram1 As Diagram
		Private model1 As Model
		Private panel4 As Panel
		Private label17 As System.Windows.Forms.Label
		Private WithEvents colorPickerButton2 As ColorPickerButton
		Private WithEvents colorPickerButton1 As ColorPickerButton
		Private label2 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Class Initialize/Finalize methods"
		''' <summary>
		''' Default Applcation constructor.
		''' </summary>
		Public Sub New()
			InitializeComponent()
			Application.EnableVisualStyles()
			Me.diagram1.Model = Me.model1
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.diagram1.View.CustomHandleRenderer = New CustomStyle1HandleRenderer()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.openDiagramDialog = New System.Windows.Forms.OpenFileDialog()
			Me.saveDiagramDialog = New System.Windows.Forms.SaveFileDialog()
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.panel3 = New DemoCommon.Diagram.Expander()
			Me.label17 = New System.Windows.Forms.Label()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label2 = New System.Windows.Forms.Label()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' openDiagramDialog
			' 
			Me.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*"
			Me.openDiagramDialog.Title = "Open Diagram"
			' 
			' saveDiagramDialog
			' 
			Me.saveDiagramDialog.FileName = "doc1"
			Me.saveDiagramDialog.Filter = "Diagram files|*.edd|All files|*.*"
			Me.saveDiagramDialog.Title = "SaveDiagram"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(799, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Custom Selection Handle"
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel3.Caption = "Properties"
			Me.panel3.Controls.Add(Me.label17)
			Me.panel3.Controls.Add(Me.colorPickerButton2)
			Me.panel3.Controls.Add(Me.colorPickerButton1)
			Me.panel3.Controls.Add(Me.label2)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel3.Location = New System.Drawing.Point(601, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Padding = New System.Windows.Forms.Padding(10)
			Me.panel3.Size = New System.Drawing.Size(200, 474)
			Me.panel3.TabIndex = 0
			' 
			' label17
			' 
			Me.label17.BackColor = System.Drawing.Color.Transparent
			Me.label17.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label17.ForeColor = System.Drawing.Color.Black
			Me.label17.Location = New System.Drawing.Point(13, 40)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(81, 18)
			Me.label17.TabIndex = 170
			Me.label17.Text = "Handle Color"
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.colorPickerButton2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
			Me.colorPickerButton2.FlatAppearance.BorderSize = 0
			Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.colorPickerButton2.Location = New System.Drawing.Point(158, 36)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.SelectedAsBackcolor = True
			Me.colorPickerButton2.Size = New System.Drawing.Size(25, 20)
			Me.colorPickerButton2.TabIndex = 174
			Me.colorPickerButton2.Text = "...."
			Me.colorPickerButton2.UseVisualStyleBackColor = False
'			Me.colorPickerButton2.ColorSelected += New System.EventHandler(Me.colorPickerButton2_ColorSelected)
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.colorPickerButton1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
			Me.colorPickerButton1.FlatAppearance.BorderSize = 0
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.colorPickerButton1.Location = New System.Drawing.Point(158, 69)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedAsBackcolor = True
			Me.colorPickerButton1.Size = New System.Drawing.Size(25, 20)
			Me.colorPickerButton1.TabIndex = 171
			Me.colorPickerButton1.Text = "...."
			Me.colorPickerButton1.UseVisualStyleBackColor = False
'			Me.colorPickerButton1.ColorSelected += New System.EventHandler(Me.colorPickerButton1_ColorSelected)
			' 
			' label2
			' 
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.Black
			Me.label2.Location = New System.Drawing.Point(12, 73)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(118, 18)
			Me.label2.TabIndex = 173
			Me.label2.Text = "Handle Outline Color"
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(599, 474)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.BackgroundColor = System.Drawing.Color.White
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			' 
			' model1
			' 
			Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model1.DocumentScale.DisplayName = "No Scale"
			Me.model1.DocumentScale.Height = 1F
			Me.model1.DocumentScale.Width = 1F
			Me.model1.DocumentSize.Height = 1169F
			Me.model1.DocumentSize.Width = 827F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model1.LineStyle.LineWidth = 0F
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.diagram1)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(2, 72)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(599, 474)
			Me.panel4.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(803, 548)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Controls Galore"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel3.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel4.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#End Region

		#Region "MAIN"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region    

		#Region "Class events"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.LoadBinary("..\..\FlowDiagram.edd")
			DiagramAppearance()
			Me.colorPickerButton1.BackColor = Me.diagram1.View.HandleRenderer.HandleOutlineColor
			Me.colorPickerButton2.BackColor = Me.diagram1.View.HandleRenderer.HandleColor
		End Sub
		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
			Me.diagram1.View.HandleRenderer.HandleColor = Me.colorPickerButton2.SelectedColor
			Me.diagram1.Refresh()
		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Me.colorPickerButton1.SelectedColor
			Me.diagram1.Refresh()
		End Sub

		''' <summary>
		''' Change's the Appearance of the Diagram 
		''' </summary>
		Public Sub DiagramAppearance()
			diagram1.Model.LineStyle.LineWidth = 0
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.White
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.Model.DocumentSize = New PageSize(600, 500)
		End Sub
		#End Region

		#Region "CustomHandleRenderer1"
		Public Class CustomStyle1HandleRenderer
			Inherits UserHandleRenderer

			Public Overrides Sub OnDrawEndPointOutline(ByVal gfx As Graphics, ByVal rectHandle As RectangleF, ByVal endpoint As EndPoint)
				Using pen As New Pen(Color.FromArgb(77, 115, 153), 1f / gfx.PageScale)
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Dot
					' Create brush to fill PinPoint interiors
					Dim br As New LinearGradientBrush(rectHandle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical)
					Dim clrBlend As New ColorBlend(5)
					clrBlend.Colors = New Color() { Color.FromArgb(163, 185, 204), Color.FromArgb(243, 255, 255), Color.FromArgb(235, 255, 255), Color.FromArgb(202, 245, 248), Color.FromArgb(202, 245, 248), Color.FromArgb(243, 255, 255), Color.FromArgb(163, 185, 204) }
					clrBlend.Positions = New Single() { 0f, 0.2f, 0.3f, 0.4f, 0.5f, 0.75f, 1f }
					br.InterpolationColors = clrBlend
					Using brush As Brush = br
						' Fill handle interiors
						gfx.FillRectangle(brush, rectHandle)

						' Outline handle
						gfx.DrawRectangle(pen, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height)
					End Using
				End Using
			End Sub

			Public Overrides Sub OnDrawOutlineRectangle(ByVal gfx As Graphics, ByVal size As SizeF)
				Using pen As New Pen(Color.FromArgb(77, 115, 153), 1f / gfx.PageScale)
					pen.DashStyle = DashStyle.Solid
					gfx.DrawRectangle(pen, 0, 0, size.Width, size.Height)
				End Using
			End Sub

			Public Overrides Sub OnDrawRotationHandleInterior(ByVal gfx As Graphics, ByVal node As Node)

				Dim fPageScale As Single = gfx.PageScale
				Dim fHandleSize As Single = CommonUsedValues.ROTATION_HANDLE_SIZE / fPageScale
				' get node's dimensions in unit independent values
				Dim szUnitIndependentPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(MeasureUnits.Pixel)

				Dim fRHO As Single = CommonUsedValues.ROTATION_HANDLE_OFFSET / fPageScale
				Dim fYOffset As Single
				If (szUnitIndependentPinOffset.Height < 0) Then
					fYOffset = szUnitIndependentPinOffset.Height - fRHO
				Else
					fYOffset = -fRHO
				End If

				Dim ptRotationHandleLocation As New PointF(szUnitIndependentPinOffset.Width, fYOffset)

				' PointF array for transforming.
				Dim pts() As PointF = { ptRotationHandleLocation }

				Dim matrixTemp As New Matrix()
				' Get parents rotation angle
				matrixTemp.RotateAt(node.RotationAngle, New PointF(szUnitIndependentPinOffset.Width, szUnitIndependentPinOffset.Height), MatrixOrder.Append)

				' Transform points
				matrixTemp.TransformPoints(pts)

				Using pen As New Pen(m_handleOutlineColor)
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Solid
					pen.Color = Color.FromArgb(77, 115, 153)

					'Fill Handled Interior
					Dim rect As New RectangleF(0, 0, fHandleSize, fHandleSize)
					Dim br As New LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical)
					Dim clrBlend As New ColorBlend(7)
					clrBlend.Colors = New Color() { Color.FromArgb(214, 255, 179), Color.FromArgb(191, 215, 177), Color.FromArgb(167, 255, 92), Color.FromArgb(148, 240, 70), Color.FromArgb(133, 225, 55), Color.FromArgb(167, 255, 92), Color.FromArgb(214, 255, 179) }
					clrBlend.Positions = New Single() { 0f, 0.25f, 0.45f, 0.55f, 0.75f, 0.8f, 1f }
					br.InterpolationColors = clrBlend

					Using brush As Brush = br
						Using gp As GraphicsPath = CreateRotationHandleShape(pts(0), New SizeF(fHandleSize, fHandleSize))
							gfx.FillPath(brush, gp)
							' Outline handle
							gfx.DrawPath(pen, gp)
						End Using
					End Using
				End Using
			End Sub

			Public Overrides Sub OnDrawResizeHandleShape(ByVal gfx As Graphics, ByVal handle As BoxPosition, ByVal node As Node, ByVal rectHandle As RectangleF)
				Using pen As New Pen(m_handleOutlineColor)
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Solid
					pen.Color = Color.FromArgb(77, 115, 153)

					Dim br As New LinearGradientBrush(rectHandle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical)
					Dim clrBlend As New ColorBlend(5)
					clrBlend.Colors = New Color() { Color.FromArgb(163, 185, 204), Color.FromArgb(243, 255, 255), Color.FromArgb(235, 255, 255), Color.FromArgb(202, 245, 248), Color.FromArgb(202, 245, 248), Color.FromArgb(243, 255, 255), Color.FromArgb(163, 185, 204) }
					clrBlend.Positions = New Single() { 0f, 0.2f, 0.3f, 0.4f, 0.5f, 0.75f, 1f }
					br.InterpolationColors = clrBlend

					' Create brush to fill PinPoint interiors
					Using brush As Brush = br
						Using gp As GraphicsPath = PathFactory.CreateEllipse(rectHandle)
							gfx.FillPath(brush, gp)
							' Outline handle
							gfx.DrawPath(pen, gp)
						End Using
					End Using
				End Using
			End Sub
		End Class
		#End Region

		#Region "CustomHandleRenderer2"
		Public Class CustomStyle2HandleRenderer
			Inherits UserHandleRenderer

			Public Overrides Sub OnDrawEndPointOutline(ByVal gfx As Graphics, ByVal rectHandle As RectangleF, ByVal endpoint As EndPoint)
				Using pen As New Pen(Color.Black, 1f / gfx.PageScale)
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Dot

					Using brush As Brush = New SolidBrush(Color.LightGreen)
						' Fill handle interiors
						gfx.FillRectangle(brush, rectHandle)

						' Outline handle
						gfx.DrawRectangle(pen, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height)
					End Using
				End Using
			End Sub

			Public Overrides Sub OnDrawOutlineRectangle(ByVal gfx As Graphics, ByVal size As SizeF)
				Using pen As New Pen(Color.Transparent, 1f / gfx.PageScale)
					pen.DashStyle = DashStyle.Solid
					gfx.DrawRectangle(pen, 0, 0, size.Width, size.Height)
				End Using
			End Sub

			Public Overrides Sub OnDrawRotationHandleInterior(ByVal gfx As Graphics, ByVal node As Node)

				Dim fPageScale As Single = gfx.PageScale
				Dim fHandleSize As Single = CommonUsedValues.ROTATION_HANDLE_SIZE / fPageScale
				' get node's dimensions in unit independent values
				Dim szUnitIndependentPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(MeasureUnits.Pixel)

				Dim fRHO As Single = CommonUsedValues.ROTATION_HANDLE_OFFSET / fPageScale
				Dim fYOffset As Single
				If (szUnitIndependentPinOffset.Height < 0) Then
					fYOffset = szUnitIndependentPinOffset.Height - fRHO
				Else
					fYOffset = -fRHO
				End If

				Dim ptRotationHandleLocation As New PointF(szUnitIndependentPinOffset.Width, fYOffset)

				' PointF array for transforming.
				Dim pts() As PointF = { ptRotationHandleLocation }

				Dim matrixTemp As New Matrix()
				' Get parents rotation angle
				matrixTemp.RotateAt(node.RotationAngle, New PointF(szUnitIndependentPinOffset.Width, szUnitIndependentPinOffset.Height), MatrixOrder.Append)

				' Transform points
				matrixTemp.TransformPoints(pts)

				Using pen As New Pen(Color.FromArgb(68, 108, 157))
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Solid

					Using brush As Brush = New SolidBrush(Color.FromArgb(0, 255, 0))
						Using gp As GraphicsPath = CreateRotationHandleShape(pts(0), New SizeF(fHandleSize, fHandleSize))
							gfx.FillPath(brush, gp)
							' Outline handle
							gfx.DrawPath(pen, gp)
						End Using
					End Using
				End Using
			End Sub

			Public Overrides Sub OnDrawResizeHandleShape(ByVal gfx As Graphics, ByVal handle As BoxPosition, ByVal node As Node, ByVal rectHandle As RectangleF)
				Using pen As New Pen(Color.FromArgb(68, 108, 157))
					pen.Width = 1f / gfx.PageScale
					pen.DashStyle = DashStyle.Solid
					pen.Color = Color.FromArgb(77, 115, 153)

					' Create brush to fill PinPoint interiors
					Using brush As Brush = New SolidBrush(Color.FromArgb(99, 154, 231))
						Using gp As GraphicsPath = PathFactory.CreateEllipse(rectHandle)
							gfx.FillPath(brush, gp)
							' Outline handle
							gfx.DrawPath(pen, gp)
						End Using
					End Using
				End Using
			End Sub
		End Class
		#End Region



	End Class
End Namespace
