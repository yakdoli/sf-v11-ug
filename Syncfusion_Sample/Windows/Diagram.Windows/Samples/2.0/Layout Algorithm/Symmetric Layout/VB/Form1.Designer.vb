Imports Microsoft.VisualBasic
Imports System
Namespace SymmetricLayout
	Partial Public Class Form1
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            Me.panel2 = New DemoCommon.Diagram.Expander
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.txtMaxIter = New System.Windows.Forms.TextBox
            Me.apply = New System.Windows.Forms.Button
            Me.tMarigin = New System.Windows.Forms.Label
            Me.sLength = New System.Windows.Forms.Label
            Me.chkAutoLayout = New System.Windows.Forms.CheckBox
            Me.txtSLength = New System.Windows.Forms.TextBox
            Me.txtSFactor = New System.Windows.Forms.TextBox
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(3, 2)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1034, 86)
            Me.panel1.TabIndex = 0
            Me.panel1.TitleText = "Symmetric Layout"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.panel2.Caption = "Properties"
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.txtMaxIter)
            Me.panel2.Controls.Add(Me.apply)
            Me.panel2.Controls.Add(Me.tMarigin)
            Me.panel2.Controls.Add(Me.sLength)
            Me.panel2.Controls.Add(Me.chkAutoLayout)
            Me.panel2.Controls.Add(Me.txtSLength)
            Me.panel2.Controls.Add(Me.txtSFactor)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(678, 88)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.panel2.Size = New System.Drawing.Size(359, 671)
            Me.panel2.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(16, 158)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(135, 20)
            Me.label2.TabIndex = 34
            Me.label2.Text = "Maximum Iteration"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 207)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 20)
            Me.label1.TabIndex = 28
            Me.label1.Text = "Auto Layout"
            '
            'txtMaxIter
            '
            Me.txtMaxIter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxIter.Location = New System.Drawing.Point(204, 154)
            Me.txtMaxIter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtMaxIter.Name = "txtMaxIter"
            Me.txtMaxIter.Size = New System.Drawing.Size(132, 27)
            Me.txtMaxIter.TabIndex = 35
            '
            'apply
            '
            Me.apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.apply.FlatAppearance.BorderSize = 0
            Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.apply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.apply.ForeColor = System.Drawing.Color.White
            Me.apply.Location = New System.Drawing.Point(133, 256)
            Me.apply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.apply.Name = "apply"
            Me.apply.Size = New System.Drawing.Size(107, 37)
            Me.apply.TabIndex = 33
            Me.apply.Text = "Apply"
            Me.apply.UseVisualStyleBackColor = False
            '
            'tMarigin
            '
            Me.tMarigin.AutoSize = True
            Me.tMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tMarigin.Location = New System.Drawing.Point(16, 108)
            Me.tMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.tMarigin.Name = "tMarigin"
            Me.tMarigin.Size = New System.Drawing.Size(97, 20)
            Me.tMarigin.TabIndex = 23
            Me.tMarigin.Text = "Spring Factor"
            '
            'sLength
            '
            Me.sLength.AutoSize = True
            Me.sLength.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.sLength.Location = New System.Drawing.Point(17, 59)
            Me.sLength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.sLength.Name = "sLength"
            Me.sLength.Size = New System.Drawing.Size(101, 20)
            Me.sLength.TabIndex = 22
            Me.sLength.Text = "Spring Length"
            '
            'chkAutoLayout
            '
            Me.chkAutoLayout.FlatAppearance.BorderSize = 0
            Me.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkAutoLayout.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAutoLayout.Location = New System.Drawing.Point(204, 190)
            Me.chkAutoLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkAutoLayout.Name = "chkAutoLayout"
            Me.chkAutoLayout.Size = New System.Drawing.Size(21, 41)
            Me.chkAutoLayout.TabIndex = 26
            Me.chkAutoLayout.UseVisualStyleBackColor = True
            '
            'txtSLength
            '
            Me.txtSLength.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSLength.Location = New System.Drawing.Point(204, 55)
            Me.txtSLength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtSLength.Name = "txtSLength"
            Me.txtSLength.Size = New System.Drawing.Size(132, 27)
            Me.txtSLength.TabIndex = 24
            '
            'txtSFactor
            '
            Me.txtSFactor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSFactor.Location = New System.Drawing.Point(204, 105)
            Me.txtSFactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtSFactor.Name = "txtSFactor"
            Me.txtSFactor.Size = New System.Drawing.Size(132, 27)
            Me.txtSFactor.TabIndex = 25
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(3, 88)
            Me.diagram1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(675, 671)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 2
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.Grid.Visible = False
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center
            Me.diagram1.VScroll = True
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 1169.0!
            Me.model1.DocumentSize.Width = 1000.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(1000.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1040, 761)
            Me.Controls.Add(Me.diagram1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Symmetrical Layout"
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region   

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As DemoCommon.Diagram.Expander
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private label1 As System.Windows.Forms.Label
		Private WithEvents apply As System.Windows.Forms.Button
		Private chkAutoLayout As System.Windows.Forms.CheckBox
		Private txtSFactor As System.Windows.Forms.TextBox
		Private txtSLength As System.Windows.Forms.TextBox
		Private tMarigin As System.Windows.Forms.Label
		Private sLength As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private txtMaxIter As System.Windows.Forms.TextBox

	End Class
End Namespace

