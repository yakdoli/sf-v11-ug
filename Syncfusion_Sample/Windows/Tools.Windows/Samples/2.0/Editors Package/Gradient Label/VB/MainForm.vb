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
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Drawing
Namespace GradientLabelDemo

	''' <summary>
	''' Summary description for MainForm.
	''' </summary>
	Public Class MainForm
		Inherits System.Windows.Forms.Form
		Private gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel3 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel4 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private errorProvider1 As System.Windows.Forms.ErrorProvider
		Private components As IContainer
		Private gradientLabel5 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientLabel7 As GradientLabel
		Private gradientLabel6 As GradientLabel

		Private hashLabelNames As Hashtable

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel3 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel4 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
			Me.gradientLabel5 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.gradientLabel6 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel7 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gradientLabel2
			' 
			Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.DiagonalBrick, System.Drawing.SystemColors.Highlight, System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192)))))))
			Me.gradientLabel2.BorderSides = (CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom) Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide))
			Me.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
			Me.gradientLabel2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel2.ForeColor = System.Drawing.Color.SlateBlue
			Me.gradientLabel2.Location = New System.Drawing.Point(3, 54)
			Me.gradientLabel2.Name = "gradientLabel2"
			Me.gradientLabel2.Size = New System.Drawing.Size(156, 136)
			Me.gradientLabel2.TabIndex = 7
			Me.gradientLabel2.Text = "Background Patterns"
			Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel3
			' 
			Me.gradientLabel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(249))))), (CInt(Fix((CByte(252))))), (CInt(Fix((CByte(248)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(201)))))))
			Me.gradientLabel3.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel3.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gradientLabel3.Location = New System.Drawing.Point(353, 54)
			Me.gradientLabel3.Name = "gradientLabel3"
			Me.gradientLabel3.Size = New System.Drawing.Size(181, 136)
			Me.gradientLabel3.TabIndex = 8
			Me.gradientLabel3.Text = "You have received a new message from Syncfusion."
			Me.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel4
			' 
			Me.gradientLabel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(128)))))))
			Me.gradientLabel4.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel4.ForeColor = System.Drawing.Color.Teal
			Me.gradientLabel4.Location = New System.Drawing.Point(170, 54)
			Me.gradientLabel4.Name = "gradientLabel4"
			Me.gradientLabel4.Size = New System.Drawing.Size(177, 33)
			Me.gradientLabel4.TabIndex = 9
			Me.gradientLabel4.Text = "10 Feeds Updated"
			Me.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			Me.errorProvider1.Icon = (CType(resources.GetObject("errorProvider1.Icon"), System.Drawing.Icon))
			' 
			' gradientLabel5
			' 
			Me.gradientLabel5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
			Me.gradientLabel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.DarkGray, System.Drawing.Color.Black)
			Me.gradientLabel5.BorderSides = System.Windows.Forms.Border3DSide.Left
			Me.gradientLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel5.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel5.ForeColor = System.Drawing.Color.White
			Me.gradientLabel5.Image = (CType(resources.GetObject("gradientLabel5.Image"), System.Drawing.Image))
			Me.gradientLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.gradientLabel5.Location = New System.Drawing.Point(3, 208)
			Me.gradientLabel5.Name = "gradientLabel5"
			Me.gradientLabel5.Size = New System.Drawing.Size(531, 46)
			Me.gradientLabel5.TabIndex = 10
			Me.gradientLabel5.Text = " P O W E R   T O O L S"
			Me.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' gradientLabel1
			' 
			Me.gradientLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))))
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(116))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(148)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(116))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(148)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(116))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(148)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(140))))), (CInt(Fix((CByte(140))))), (CInt(Fix((CByte(172)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(156))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(180)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(164))))), (CInt(Fix((CByte(166))))), (CInt(Fix((CByte(188))))))})
			Me.gradientLabel1.BorderSides = (CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom) Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide))
			Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientLabel1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel1.ForeColor = System.Drawing.Color.White
			Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
			Me.gradientLabel1.Name = "gradientLabel1"
			Me.gradientLabel1.Size = New System.Drawing.Size(544, 40)
			Me.gradientLabel1.TabIndex = 16
			Me.gradientLabel1.Text = "Column Editor"
			Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(146))))), (CInt(Fix((CByte(145))))), (CInt(Fix((CByte(174))))))
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.gradientLabel1)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel2)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel5)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel3)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel7)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel6)
			Me.gradientPanel1.Controls.Add(Me.gradientLabel4)
			Me.gradientPanel1.Location = New System.Drawing.Point(12, 16)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(546, 268)
			Me.gradientPanel1.TabIndex = 22
			' 
			' gradientLabel6
			' 
			Me.gradientLabel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255)))))))
			Me.gradientLabel6.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel6.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gradientLabel6.Image = (CType(resources.GetObject("gradientLabel6.Image"), System.Drawing.Image))
			Me.gradientLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.gradientLabel6.Location = New System.Drawing.Point(170, 111)
			Me.gradientLabel6.Name = "gradientLabel6"
			Me.gradientLabel6.Size = New System.Drawing.Size(177, 32)
			Me.gradientLabel6.TabIndex = 9
			Me.gradientLabel6.Text = "Attachments"
			Me.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel7
			' 
			Me.gradientLabel7.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(221))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(227)))))))
			Me.gradientLabel7.BorderSides = (CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom) Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide))
			Me.gradientLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel7.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel7.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gradientLabel7.Location = New System.Drawing.Point(170, 170)
			Me.gradientLabel7.Name = "gradientLabel7"
			Me.gradientLabel7.Size = New System.Drawing.Size(177, 20)
			Me.gradientLabel7.TabIndex = 9
			Me.gradientLabel7.Text = "Mail Folders"
			Me.gradientLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(254))))))
			Me.ClientSize = New System.Drawing.Size(570, 299)
			Me.Controls.Add(Me.gradientPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Gradient Label"
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
