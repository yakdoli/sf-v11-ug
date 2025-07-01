Imports Microsoft.VisualBasic
Imports System
Namespace SplitButtonDemo
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
            Dim SplitButtonRenderer1 As Syncfusion.Windows.Forms.Tools.SplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.SplitButtonRenderer
            Dim SplitButtonRenderer2 As Syncfusion.Windows.Forms.Tools.SplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.SplitButtonRenderer
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.splitButton1 = New Syncfusion.Windows.Forms.Tools.SplitButton
            Me.panel5 = New System.Windows.Forms.Panel
            Me.splitButton2 = New Syncfusion.Windows.Forms.Tools.SplitButton
            Me.label3 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel3 = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.panel4 = New System.Windows.Forms.Panel
            Me.label2 = New System.Windows.Forms.Label
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label4 = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.panel5.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.LightCyan
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.gradientPanel1)
            Me.panel1.Location = New System.Drawing.Point(26, 19)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(206, 272)
            Me.panel1.TabIndex = 0
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.AliceBlue
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.Lavender, System.Drawing.SystemColors.Window)
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner
            Me.gradientPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.gradientPanel1.Controls.Add(Me.splitButton1)
            Me.gradientPanel1.Controls.Add(Me.panel5)
            Me.gradientPanel1.Location = New System.Drawing.Point(-1, -1)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(206, 272)
            Me.gradientPanel1.TabIndex = 3
            '
            'splitButton1
            '
            Me.splitButton1.BackColor = System.Drawing.SystemColors.Control
            Me.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal
            Me.splitButton1.DropDownIconColor = System.Drawing.Color.Black
            Me.splitButton1.IsButtonChecked = False
            Me.splitButton1.Location = New System.Drawing.Point(33, 49)
            Me.splitButton1.Name = "splitButton1"
            SplitButtonRenderer1.SplitButton = Nothing
            Me.splitButton1.Renderer = SplitButtonRenderer1
            Me.splitButton1.Size = New System.Drawing.Size(139, 35)
            Me.splitButton1.TabIndex = 3
            Me.splitButton1.Text = "splitButton1"
            '
            'panel5
            '
            Me.panel5.BackColor = System.Drawing.Color.Lavender
            Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel5.Controls.Add(Me.splitButton2)
            Me.panel5.Controls.Add(Me.label3)
            Me.panel5.Location = New System.Drawing.Point(22, 146)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(157, 102)
            Me.panel5.TabIndex = 2
            '
            'splitButton2
            '
            Me.splitButton2.BackColor = System.Drawing.SystemColors.Control
            Me.splitButton2.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal
            Me.splitButton2.DropDownIconColor = System.Drawing.Color.Black
            Me.splitButton2.IsButtonChecked = False
            Me.splitButton2.Location = New System.Drawing.Point(35, 38)
            Me.splitButton2.Name = "splitButton2"
            SplitButtonRenderer2.SplitButton = Nothing
            Me.splitButton2.Renderer = SplitButtonRenderer2
            Me.splitButton2.Size = New System.Drawing.Size(85, 45)
            Me.splitButton2.TabIndex = 1
            Me.splitButton2.Text = "Click"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.label3.Location = New System.Drawing.Point(8, 6)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(65, 12)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Customized"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.LightCyan
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.gradientPanel2)
            Me.panel2.Location = New System.Drawing.Point(249, 19)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(187, 272)
            Me.panel2.TabIndex = 1
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Lavender, System.Drawing.SystemColors.Window)
            Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner
            Me.gradientPanel2.Controls.Add(Me.panel3)
            Me.gradientPanel2.Controls.Add(Me.panel4)
            Me.gradientPanel2.Location = New System.Drawing.Point(-1, -1)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(187, 272)
            Me.gradientPanel2.TabIndex = 2
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.Lavender
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Controls.Add(Me.radioButton2)
            Me.panel3.Controls.Add(Me.radioButton1)
            Me.panel3.Location = New System.Drawing.Point(12, 20)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(158, 95)
            Me.panel3.TabIndex = 0
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Lavender
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.label1.Location = New System.Drawing.Point(2, 3)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(66, 12)
            Me.label1.TabIndex = 2
            Me.label1.Text = "ButtonMode"
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(36, 51)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(85, 17)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.TabStop = True
            Me.radioButton2.Text = "NormalMode"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Location = New System.Drawing.Point(36, 28)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(85, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "ToogleMode"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.Lavender
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.label2)
            Me.panel4.Controls.Add(Me.buttonAdv1)
            Me.panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel4.Location = New System.Drawing.Point(12, 146)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(158, 102)
            Me.panel4.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.label2.Location = New System.Drawing.Point(3, 7)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(84, 12)
            Me.label2.TabIndex = 4
            Me.label2.Text = "DropDown Item"
            '
            'buttonAdv1
            '
            Me.buttonAdv1.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.Location = New System.Drawing.Point(30, 41)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(91, 28)
            Me.buttonAdv1.TabIndex = 1
            Me.buttonAdv1.Text = "Remove Items"
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackColor = System.Drawing.Color.Lavender
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.Lavender, System.Drawing.SystemColors.Window)
            Me.gradientPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner
            Me.gradientPanel3.BorderColor = System.Drawing.Color.Teal
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.textBox1)
            Me.gradientPanel3.Controls.Add(Me.label4)
            Me.gradientPanel3.Location = New System.Drawing.Point(26, 309)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(410, 156)
            Me.gradientPanel3.TabIndex = 4
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(17, 36)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(376, 105)
            Me.textBox1.TabIndex = 2
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.label4.Location = New System.Drawing.Point(15, 10)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(56, 12)
            Me.label4.TabIndex = 1
            Me.label4.Text = "Event Log"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Lavender
            Me.ClientSize = New System.Drawing.Size(458, 477)
            Me.Controls.Add(Me.gradientPanel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplitButton Demo"
            Me.panel1.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            Me.panel5.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.gradientPanel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private panel5 As System.Windows.Forms.Panel
		Private label3 As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents splitButton1 As Syncfusion.Windows.Forms.Tools.SplitButton
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label4 As System.Windows.Forms.Label
		Private WithEvents splitButton2 As Syncfusion.Windows.Forms.Tools.SplitButton
		Private textBox1 As System.Windows.Forms.TextBox
	End Class
End Namespace

