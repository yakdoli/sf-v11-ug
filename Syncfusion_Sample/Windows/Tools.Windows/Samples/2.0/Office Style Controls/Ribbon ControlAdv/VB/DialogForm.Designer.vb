#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace RibbonControlAdv_2005
	Partial Public Class DialogForm
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogForm))
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel3 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New System.Drawing.Point(0, 23)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(228, 82)
			Me.listBox1.TabIndex = 0
			' 
			' listBox2
			' 
			Me.listBox2.Dock = System.Windows.Forms.DockStyle.Top
			Me.listBox2.FormattingEnabled = True
			Me.listBox2.Location = New System.Drawing.Point(0, 128)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(228, 82)
			Me.listBox2.TabIndex = 1
			' 
			' gradientLabel1
			' 
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(247)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(247)))))))
			Me.gradientLabel1.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
			Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientLabel1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel1.Location = New System.Drawing.Point(0, 105)
			Me.gradientLabel1.Name = "gradientLabel1"
			Me.gradientLabel1.Size = New System.Drawing.Size(228, 23)
			Me.gradientLabel1.TabIndex = 4
			Me.gradientLabel1.Text = "Items in Ribbon Panel"
			Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel2
			' 
			Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(247)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(247)))))))
			Me.gradientLabel2.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
			Me.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientLabel2.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel2.Location = New System.Drawing.Point(0, 0)
			Me.gradientLabel2.Name = "gradientLabel2"
			Me.gradientLabel2.Size = New System.Drawing.Size(228, 23)
			Me.gradientLabel2.TabIndex = 5
			Me.gradientLabel2.Text = "Items in Quick Access Panel"
			Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel3
			' 
			Me.gradientLabel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(247)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(247)))))))
			Me.gradientLabel3.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel3.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel3.Location = New System.Drawing.Point(79, 3)
			Me.gradientLabel3.Name = "gradientLabel3"
			Me.gradientLabel3.Size = New System.Drawing.Size(70, 23)
			Me.gradientLabel3.TabIndex = 6
			Me.gradientLabel3.Text = "OK"
			Me.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.gradientLabel3.Click += New System.EventHandler(Me.gradientLabel3_Click);
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(247)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(247)))))))
			Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel1.Controls.Add(Me.gradientLabel3)
			Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientPanel1.Location = New System.Drawing.Point(0, 210)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(228, 33)
			Me.gradientPanel1.TabIndex = 7
			' 
			' DialogForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(247))))))
			Me.ClientSize = New System.Drawing.Size(228, 239)
			Me.ControlBox = False
			Me.Controls.Add(Me.gradientPanel1)
			Me.Controls.Add(Me.listBox2)
			Me.Controls.Add(Me.gradientLabel1)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.gradientLabel2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "DialogForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Items Collection"
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Public listBox1 As System.Windows.Forms.ListBox
		Public listBox2 As System.Windows.Forms.ListBox
	Public gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Public gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Public WithEvents gradientLabel3 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Public gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
	End Class
End Namespace