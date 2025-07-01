Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools

Namespace GradientPanelExtDemo
	Public Partial Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Declaration"
		Private textPrimitive1 As Syncfusion.Windows.Forms.Tools.TextPrimitive
		Private imagePrimitive1 As Syncfusion.Windows.Forms.Tools.ImagePrimitive

		Private collapsePrimitive1 As Syncfusion.Windows.Forms.Tools.CollapsePrimitive
		Private hostPrimitive1 As Syncfusion.Windows.Forms.Tools.HostPrimitive

		#End Region ' Declaration

		#Region "Form constructor"
		Public Sub New()
			InitializeComponent()
			Me.checkBoxAdv1.Visible = False
		  Me.comboBox1.SelectedIndex = 0
		Me.gradientStyleCombo.SelectedIndex = 4
		Me.backcolorEdit.TextBox.BackColor = Color.FromArgb(191, 219, 254)
		Me.foreColorEdit.TextBox.BackColor = Color.White
		Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor)

		End Sub

		#End Region ' Form constructor

		#Region "Color Options"
		Private Sub backColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles backcolorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
		   backcolorEdit.TextBox.BackColor = colorDialog1.Color
		   Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor)

			End If
		End Sub

		Private Sub foreColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles foreColorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.foreColorEdit.TextBox.BackColor = colorDialog1.Color
			 Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor)
			End If

		End Sub

		Private Sub gradientStyleCombo_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gradientStyleCombo.SelectedValueChanged
			Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(CType(gradientStyleCombo.SelectedIndex, Syncfusion.Drawing.GradientStyle), backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor)

		End Sub
		#End Region ' Color Options

		#Region "Primitives"

		Private Sub Primitive_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles hostPrimitive_rB.CheckChanged, collapsePrimitive_rB.CheckChanged, imagePrimitive_rB.CheckChanged, textPrimitive_rB.CheckChanged
			Dim radioButton As RadioButtonAdv = CType(sender, RadioButtonAdv)

			Select Case radioButton.Text
				Case "Text Primitive"
					AddTextPrimitive()

				Case "Image Primitive"
					AddImagePrimitive()

				Case "Collapse Primitive"
					AddCollapsePrimitive()

				Case "Host Primitive"
					AddHostPrimitive()
			End Select


		End Sub

		Private Sub AddHostPrimitive()
		   Me.gradientPanelExt1.Primitives.Clear()

		   Me.comboBox1.Enabled = False
			Me.hostPrimitive1 = New Syncfusion.Windows.Forms.Tools.HostPrimitive()
			Me.hostPrimitive1.BackColor = System.Drawing.Color.Transparent
			Me.checkBoxAdv1.Visible = True
				Me.hostPrimitive1.HostControl = Me.checkBoxAdv1
				Me.hostPrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top
				Me.hostPrimitive1.Size = New Size(100, 20)
				  Me.hostPrimitive1.PrimitiveBorderStyle = Syncfusion.Windows.Forms.Tools.PrimitiveBorderStyle.None
			Me.gradientPanelExt1.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.Primitive() { Me.hostPrimitive1})
		End Sub

		Private Sub AddCollapsePrimitive()

			Me.checkBoxAdv1.Visible = False
			Me.comboBox1.Enabled = True

			Me.gradientPanelExt1.Primitives.Clear()
			Me.checkBoxAdv1.Visible = False
			Me.collapsePrimitive1 = New Syncfusion.Windows.Forms.Tools.CollapsePrimitive()
			Me.collapsePrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Bottom
			Me.collapsePrimitive1.BackColor = System.Drawing.Color.Transparent '.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			Me.collapsePrimitive1.Collapsed = False

			Me.collapsePrimitive1.BorderColor = Color.Transparent
			Me.collapsePrimitive1.CollapseImage = Image.FromFile("..\..\Data\navigate_up2.png")
			Me.collapsePrimitive1.ExpandImage = Image.FromFile("..\..\Data\navigate_down2.png")
			Me.collapsePrimitive1.Size = New System.Drawing.Size(20, 20)
			AddHandler collapsePrimitive1.CollapsedChanged, AddressOf collapsePrimitive1_CollapsedChanged
			Me.gradientPanelExt1.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.Primitive() { Me.collapsePrimitive1})
			primitiveAlignment()
		End Sub

		Private Sub collapsePrimitive1_CollapsedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.gradientPanelExt1.Collapsed) Then
				Me.checkBoxAdv1.Visible = False
			End If

		End Sub
		Private Sub AddImagePrimitive()


			Me.checkBoxAdv1.Visible = False
			Me.comboBox1.Enabled = True
			Me.gradientPanelExt1.Primitives.Clear()
			Me.checkBoxAdv1.Visible = False
			Me.imagePrimitive1 = New Syncfusion.Windows.Forms.Tools.ImagePrimitive()
			Me.imagePrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top
			Me.imagePrimitive1.Image = Image.FromFile("..\..\Data\about.png")
			Me.imagePrimitive1.PrimitiveBorderStyle = Syncfusion.Windows.Forms.Tools.PrimitiveBorderStyle.None
			Me.imagePrimitive1.Size = New System.Drawing.Size(30, 30)
			 Me.gradientPanelExt1.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.Primitive() { Me.imagePrimitive1})
			 primitiveAlignment()

		End Sub

		Private Sub AddTextPrimitive()

			Me.checkBoxAdv1.Visible = False
			Me.comboBox1.Enabled = True
			Me.gradientPanelExt1.Primitives.Clear()
			Me.checkBoxAdv1.Visible = False
			Me.textPrimitive1 = New Syncfusion.Windows.Forms.Tools.TextPrimitive()
			Me.textPrimitive1.TextFont = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textPrimitive1.TextColor = System.Drawing.Color.MidnightBlue
			Me.textPrimitive1.BackColor = System.Drawing.Color.Transparent '.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			Me.textPrimitive1.Size = New System.Drawing.Size(90, 30)
			Me.textPrimitive1.Text = "Text Primitive"
			Me.textPrimitive1.BorderColor = Color.FromArgb(44, 137, 252)
			 Me.gradientPanelExt1.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.Primitive() { Me.textPrimitive1})
			primitiveAlignment()
		End Sub
		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			AddHostPrimitive()
		End Sub


		#End Region ' Primitives

		#Region "Properties"
		Private Sub borderGapUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles borderGapUpDown.ValueChanged
			Me.gradientPanelExt1.BorderGap = Convert.ToInt32(Me.borderGapUpDown.Value)
		End Sub

		Private Sub cornerRadiusUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cornerRadiusUpDown.ValueChanged
			Me.gradientPanelExt1.CornerRadius = Convert.ToInt32(Me.cornerRadiusUpDown.Value)
		End Sub

		#End Region ' Properties

		#Region "primitiveAlignment"
	Public Sub primitiveAlignment()
			For Each pm As Primitive In Me.gradientPanelExt1.Primitives
				If Me.comboBox1.SelectedIndex = 0 Then
					pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top
				End If
				If Me.comboBox1.SelectedIndex = 1 Then
					pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Bottom
				End If
				If Me.comboBox1.SelectedIndex = 2 Then
					pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Left
				End If
				If Me.comboBox1.SelectedIndex = 3 Then
					pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Right
				End If
			Next pm
	End Sub



		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			primitiveAlignment()
		End Sub
	#End Region

	End Class
End Namespace