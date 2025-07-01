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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms

Namespace GradientPanelDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label2 As Label
		Private label1 As Label
		Private textBox3 As TextBox
		Private textBox2 As TextBox
		Private textBox1 As TextBox
		Private button1 As Button
		Private label3 As Label
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label3 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.None, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.gradientPanel3)
            Me.gradientPanel2.Location = New System.Drawing.Point(12, 12)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(528, 350)
            Me.gradientPanel2.TabIndex = 1
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(254, Byte), Integer)))
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.textBox1)
            Me.gradientPanel3.Controls.Add(Me.gradientPanel1)
            Me.gradientPanel3.Controls.Add(Me.button1)
            Me.gradientPanel3.Controls.Add(Me.textBox2)
            Me.gradientPanel3.Controls.Add(Me.textBox3)
            Me.gradientPanel3.Controls.Add(Me.label2)
            Me.gradientPanel3.Controls.Add(Me.label1)
            Me.gradientPanel3.Location = New System.Drawing.Point(15, 16)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(495, 312)
            Me.gradientPanel3.TabIndex = 8
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(19, 18)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(100, 20)
            Me.textBox1.TabIndex = 0
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(140, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(157, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(157, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(166, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(166, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White})
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(122, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label3)
            Me.gradientPanel1.Location = New System.Drawing.Point(368, 13)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(111, 95)
            Me.gradientPanel1.TabIndex = 6
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Maroon
            Me.label3.Location = New System.Drawing.Point(18, 37)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(72, 14)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Display Photo"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Location = New System.Drawing.Point(21, 223)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(108, 23)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Submit Comment"
            Me.button1.UseVisualStyleBackColor = False
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(19, 61)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(100, 20)
            Me.textBox2.TabIndex = 1
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(21, 105)
            Me.textBox3.Multiline = True
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox3.Size = New System.Drawing.Size(237, 109)
            Me.textBox3.TabIndex = 2
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(127, 64)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(76, 14)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Mail (required)"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(127, 21)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(88, 14)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Name (Required)"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.Add(Me.gradientPanel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Gradient Panel"
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.gradientPanel3.PerformLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
