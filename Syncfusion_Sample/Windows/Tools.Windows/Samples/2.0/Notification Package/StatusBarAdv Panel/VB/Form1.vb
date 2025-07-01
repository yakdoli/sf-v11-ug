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

Namespace StatusBarAdvPanelDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private statusBarAdvPanel1 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdvPanel2 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private WithEvents statusBarAdvPanel3 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdvPanel4 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdvPanel5 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdv1 As Syncfusion.Windows.Forms.Tools.StatusBarAdv
		Private statusBarAdvPanel7 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdvPanel6 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private statusBarAdvPanel8 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private imageList1 As System.Windows.Forms.ImageList
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer

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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.statusBarAdvPanel1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel2 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel3 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel4 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel5 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdv1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdv()
			Me.statusBarAdvPanel8 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel6 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel7 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.statusBarAdvPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.statusBarAdvPanel1.SuspendLayout()
			CType(Me.statusBarAdvPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.statusBarAdv1.SuspendLayout()
			CType(Me.statusBarAdvPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' statusBarAdvPanel1
			' 
			Me.statusBarAdvPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel1.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel1.Controls.AddRange(New System.Windows.Forms.Control() { Me.statusBarAdvPanel2})
			Me.statusBarAdvPanel1.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel1.Location = New System.Drawing.Point(280, 32)
			Me.statusBarAdvPanel1.Name = "statusBarAdvPanel1"
			Me.statusBarAdvPanel1.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate
			Me.statusBarAdvPanel1.Size = New System.Drawing.Size(216, 24)
			Me.statusBarAdvPanel1.TabIndex = 0
			Me.statusBarAdvPanel1.Text = "statusBarAdvPanel1"
			' 
			' statusBarAdvPanel2
			' 
			Me.statusBarAdvPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel2.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel2.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel2.Location = New System.Drawing.Point(-2, -2)
			Me.statusBarAdvPanel2.Name = "statusBarAdvPanel2"
			Me.statusBarAdvPanel2.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate
			Me.statusBarAdvPanel2.Size = New System.Drawing.Size(216, 24)
			Me.statusBarAdvPanel2.TabIndex = 1
			Me.statusBarAdvPanel2.Text = "statusBarAdvPanel1"
			' 
			' statusBarAdvPanel3
			' 
			Me.statusBarAdvPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.SystemColors.Window)
			Me.statusBarAdvPanel3.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel3.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel3.Location = New System.Drawing.Point(280, 112)
			Me.statusBarAdvPanel3.Name = "statusBarAdvPanel3"
			Me.statusBarAdvPanel3.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate
			Me.statusBarAdvPanel3.Size = New System.Drawing.Size(216, 24)
			Me.statusBarAdvPanel3.TabIndex = 1
			Me.statusBarAdvPanel3.Text = "statusBarAdvPanel1"
'			Me.statusBarAdvPanel3.Paint += New System.Windows.Forms.PaintEventHandler(Me.statusBarAdvPanel3_Paint);
			' 
			' statusBarAdvPanel4
			' 
			Me.statusBarAdvPanel4.BackColor = System.Drawing.Color.Transparent
			Me.statusBarAdvPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel4.BorderColor = System.Drawing.Color.Blue
			Me.statusBarAdvPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.statusBarAdvPanel4.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel4.Location = New System.Drawing.Point(280, 184)
			Me.statusBarAdvPanel4.Name = "statusBarAdvPanel4"
			Me.statusBarAdvPanel4.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState
			Me.statusBarAdvPanel4.Size = New System.Drawing.Size(216, 24)
			Me.statusBarAdvPanel4.TabIndex = 2
			Me.statusBarAdvPanel4.Text = "statusBarAdvPanel1"
			' 
			' statusBarAdvPanel5
			' 
			Me.statusBarAdvPanel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel5.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel5.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel5.Location = New System.Drawing.Point(280, 272)
			Me.statusBarAdvPanel5.Name = "statusBarAdvPanel5"
			Me.statusBarAdvPanel5.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ScrollLockState
			Me.statusBarAdvPanel5.Size = New System.Drawing.Size(216, 24)
			Me.statusBarAdvPanel5.TabIndex = 3
			Me.statusBarAdvPanel5.Text = "statusBarAdvPanel1"
			' 
			' statusBarAdv1
			' 
			Me.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(241)), (CByte(254)))
			Me.statusBarAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdv1.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdv1.Controls.AddRange(New System.Windows.Forms.Control() { Me.statusBarAdvPanel8, Me.statusBarAdvPanel6, Me.statusBarAdvPanel7})
			Me.statusBarAdv1.CustomLayoutBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.statusBarAdv1.DockPadding.All = 3
			Me.statusBarAdv1.Location = New System.Drawing.Point(0, 342)
			Me.statusBarAdv1.Name = "statusBarAdv1"
			Me.statusBarAdv1.Size = New System.Drawing.Size(552, 32)
			Me.statusBarAdv1.SizingGrip = False
			Me.statusBarAdv1.Spacing = New System.Drawing.Size(2, 2)
			Me.statusBarAdv1.TabIndex = 8
			Me.statusBarAdv1.ThemesEnabled = True
			' 
			' statusBarAdvPanel8
			' 
			Me.statusBarAdvPanel8.Alignment = System.Windows.Forms.HorizontalAlignment.Left
			Me.statusBarAdvPanel8.BackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(241)), (CByte(254)))
			Me.statusBarAdvPanel8.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb((CByte(128)), (CByte(64)), (CByte(64))))
			Me.statusBarAdvPanel8.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel8.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed
			Me.statusBarAdvPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.statusBarAdvPanel8.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel8.Location = New System.Drawing.Point(0, 2)
			Me.statusBarAdvPanel8.Name = "statusBarAdvPanel8"
			Me.statusBarAdvPanel8.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongTime
			Me.statusBarAdvPanel8.Size = New System.Drawing.Size(67, 24)
			Me.statusBarAdvPanel8.SizeToContent = True
			Me.statusBarAdvPanel8.TabIndex = 12
			Me.statusBarAdvPanel8.Text = Nothing
			Me.statusBarAdvPanel8.ThemesEnabled = True
			' 
			' statusBarAdvPanel6
			' 
			Me.statusBarAdvPanel6.BackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(241)), (CByte(254)))
			Me.statusBarAdvPanel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel6.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel6.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted
			Me.statusBarAdvPanel6.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify
			Me.statusBarAdvPanel6.Location = New System.Drawing.Point(69, 2)
			Me.statusBarAdvPanel6.Name = "statusBarAdvPanel6"
			Me.statusBarAdvPanel6.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture
			Me.statusBarAdvPanel6.PreferredSize = New System.Drawing.Size(183, 24)
			Me.statusBarAdvPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.statusBarAdvPanel6.Size = New System.Drawing.Size(286, 24)
			Me.statusBarAdvPanel6.TabIndex = 11
			Me.statusBarAdvPanel6.Text = "statusBarAdvPanel6"
			' 
			' statusBarAdvPanel7
			' 
			Me.statusBarAdvPanel7.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.SystemColors.InactiveBorder)
			Me.statusBarAdvPanel7.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel7.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted
			Me.statusBarAdvPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.statusBarAdvPanel7.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right
			Me.statusBarAdvPanel7.Location = New System.Drawing.Point(357, 2)
			Me.statusBarAdvPanel7.Name = "statusBarAdvPanel7"
			Me.statusBarAdvPanel7.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.InsertKeyState
			Me.statusBarAdvPanel7.Size = New System.Drawing.Size(184, 24)
			Me.statusBarAdvPanel7.TabIndex = 10
			Me.statusBarAdvPanel7.Text = Nothing
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(56, 272)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(200, 24)
			Me.label4.TabIndex = 13
			Me.label4.Text = "Scroll Lock state"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(56, 184)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(200, 24)
			Me.label3.TabIndex = 12
			Me.label3.Text = "CAPS lock state with color border"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(56, 112)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(200, 24)
			Me.label2.TabIndex = 11
			Me.label2.Text = "Short date with gradient"
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Location = New System.Drawing.Point(56, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(200, 24)
			Me.label1.TabIndex = 10
			Me.label1.Text = "Long Date"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(552, 374)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.statusBarAdv1, Me.statusBarAdvPanel5, Me.statusBarAdvPanel4, Me.statusBarAdvPanel3, Me.statusBarAdvPanel1, Me.label4, Me.label3, Me.label2, Me.label1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "StatusBarAdv Panel"
			CType(Me.statusBarAdvPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.statusBarAdvPanel1.ResumeLayout(False)
			CType(Me.statusBarAdvPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.statusBarAdv1.ResumeLayout(False)
			CType(Me.statusBarAdvPanel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel7, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub statusBarAdvPanel3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles statusBarAdvPanel3.Paint

		End Sub
	End Class
End Namespace
