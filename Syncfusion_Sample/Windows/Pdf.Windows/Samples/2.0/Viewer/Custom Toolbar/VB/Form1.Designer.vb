Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace ToolbarCustomization_2005
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.CustomPanel = New System.Windows.Forms.Panel()
			Me.Open = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.btnFirst = New System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
			Me.txtPageNumber = New System.Windows.Forms.ToolStripTextBox()
			Me.btnNext = New System.Windows.Forms.ToolStripButton()
			Me.btnLast = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
			Me.pdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.DefaultToolbar = New System.Windows.Forms.RadioButton()
			Me.CustomToolbar = New System.Windows.Forms.RadioButton()
			Me.CustomPanel.SuspendLayout()
			Me.Open.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' CustomPanel
			' 
			Me.CustomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.CustomPanel.Controls.Add(Me.Open)
			Me.CustomPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.CustomPanel.Location = New System.Drawing.Point(0, 30)
			Me.CustomPanel.Name = "CustomPanel"
			Me.CustomPanel.Size = New System.Drawing.Size(284, 32)
			Me.CustomPanel.TabIndex = 2
			Me.CustomPanel.Visible = False
			' 
			' Open
			' 
			Me.Open.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripSeparator1, Me.btnFirst, Me.btnPrevious, Me.txtPageNumber, Me.btnNext, Me.btnLast, Me.toolStripSeparator2})
			Me.Open.Location = New System.Drawing.Point(0, 0)
			Me.Open.Name = "Open"
			Me.Open.Size = New System.Drawing.Size(284, 27)
			Me.Open.TabIndex = 0
			Me.Open.Text = "toolStrip1"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.AutoSize = False
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(24, 24)
			Me.toolStripButton1.Text = "Open"
'			Me.toolStripButton1.Click += New System.EventHandler(Me.toolStripButton1_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
			' 
			' btnFirst
			' 
			Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.btnFirst.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.btnFirst.Image = (CType(resources.GetObject("btnFirst.Image"), System.Drawing.Image))
			Me.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnFirst.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
			Me.btnFirst.Name = "btnFirst"
			Me.btnFirst.Size = New System.Drawing.Size(27, 24)
			Me.btnFirst.Text = "<<"
'			Me.btnFirst.Click += New System.EventHandler(Me.btnFirst_Click)
			' 
			' btnPrevious
			' 
			Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.btnPrevious.Image = (CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image))
			Me.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnPrevious.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
			Me.btnPrevious.Name = "btnPrevious"
			Me.btnPrevious.Size = New System.Drawing.Size(23, 24)
			Me.btnPrevious.Text = "<"
'			Me.btnPrevious.Click += New System.EventHandler(Me.btnPrevious_Click)
			' 
			' txtPageNumber
			' 
			Me.txtPageNumber.AutoSize = False
			Me.txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtPageNumber.Name = "txtPageNumber"
			Me.txtPageNumber.Size = New System.Drawing.Size(35, 23)
			Me.txtPageNumber.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' btnNext
			' 
			Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.btnNext.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.btnNext.Image = (CType(resources.GetObject("btnNext.Image"), System.Drawing.Image))
			Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnNext.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
			Me.btnNext.Name = "btnNext"
			Me.btnNext.Size = New System.Drawing.Size(23, 24)
			Me.btnNext.Text = ">"
'			Me.btnNext.Click += New System.EventHandler(Me.btnNext_Click)
			' 
			' btnLast
			' 
			Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.btnLast.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.btnLast.Image = (CType(resources.GetObject("btnLast.Image"), System.Drawing.Image))
			Me.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnLast.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
			Me.btnLast.Name = "btnLast"
			Me.btnLast.Size = New System.Drawing.Size(27, 24)
			Me.btnLast.Text = ">>"
'			Me.btnLast.Click += New System.EventHandler(Me.btnLast_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 27)
			' 
			' pdfViewerControl1
			' 
			Me.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 62)
			Me.pdfViewerControl1.Name = "pdfViewerControl1"
			Me.pdfViewerControl1.ShowToolBar = True
			Me.pdfViewerControl1.Size = New System.Drawing.Size(284, 200)
			Me.pdfViewerControl1.TabIndex = 3
			Me.pdfViewerControl1.Text = "pdfViewerControl1"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.DefaultToolbar)
			Me.panel2.Controls.Add(Me.CustomToolbar)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(284, 30)
			Me.panel2.TabIndex = 4
			' 
			' DefaultToolbar
			' 
			Me.DefaultToolbar.AutoSize = True
			Me.DefaultToolbar.Checked = True
			Me.DefaultToolbar.Font = New System.Drawing.Font("Verdana", 9.75F)
			Me.DefaultToolbar.Location = New System.Drawing.Point(3, 9)
			Me.DefaultToolbar.Name = "DefaultToolbar"
			Me.DefaultToolbar.Size = New System.Drawing.Size(168, 20)
			Me.DefaultToolbar.TabIndex = 0
			Me.DefaultToolbar.TabStop = True
			Me.DefaultToolbar.Text = "Show Default Toolbar"
			Me.DefaultToolbar.UseVisualStyleBackColor = True
'			Me.DefaultToolbar.CheckedChanged += New System.EventHandler(Me.DefaultToolbar_Click)
			' 
			' CustomToolbar
			' 
			Me.CustomToolbar.AutoSize = True
			Me.CustomToolbar.Font = New System.Drawing.Font("Verdana", 9.75F)
			Me.CustomToolbar.Location = New System.Drawing.Point(176, 9)
			Me.CustomToolbar.Name = "CustomToolbar"
			Me.CustomToolbar.Size = New System.Drawing.Size(170, 20)
			Me.CustomToolbar.TabIndex = 1
			Me.CustomToolbar.Text = "Show Custom Toolbar"
			Me.CustomToolbar.UseVisualStyleBackColor = True
'			Me.CustomToolbar.CheckedChanged += New System.EventHandler(Me.DefaultToolbar_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.pdfViewerControl1)
			Me.Controls.Add(Me.CustomPanel)
			Me.Controls.Add(Me.panel2)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "Custom Toolbar"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.CustomPanel.ResumeLayout(False)
			Me.CustomPanel.PerformLayout()
			Me.Open.ResumeLayout(False)
			Me.Open.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private Tooltip As System.Windows.Forms.ToolTip
		Private pdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents CustomToolbar As System.Windows.Forms.RadioButton
		Private WithEvents DefaultToolbar As System.Windows.Forms.RadioButton
		Private CustomPanel As System.Windows.Forms.Panel
		Private Open As System.Windows.Forms.ToolStrip
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private WithEvents btnFirst As System.Windows.Forms.ToolStripButton
		Private WithEvents btnPrevious As System.Windows.Forms.ToolStripButton
		Private WithEvents btnNext As System.Windows.Forms.ToolStripButton
		Private WithEvents btnLast As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private txtPageNumber As System.Windows.Forms.ToolStripTextBox
	End Class
End Namespace

