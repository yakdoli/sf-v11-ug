Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace GettingStarted
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.pdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
			Me.lblText = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.AutoSize = True
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(529, 0)
			Me.panel1.TabIndex = 0
			' 
			' pdfViewerControl1
			' 
			Me.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewerControl1.Name = "pdfViewerControl1"
			Me.pdfViewerControl1.ShowToolBar = True
			Me.pdfViewerControl1.Size = New System.Drawing.Size(529, 307)
			Me.pdfViewerControl1.TabIndex = 3
			Me.pdfViewerControl1.Text = "pdfViewerControl1"
			' 
			' lblText
			' 
			Me.lblText.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lblText.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblText.Location = New System.Drawing.Point(32, 141)
			Me.lblText.Name = "lblText"
			Me.lblText.Size = New System.Drawing.Size(214, 24)
			Me.lblText.TabIndex = 5
			Me.lblText.Text = "Select a PDF file from the list : "
			Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' comboBox1
			' 
			Me.comboBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.comboBox1.Cursor = System.Windows.Forms.Cursors.Default
			Me.comboBox1.DropDownHeight = 206
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.comboBox1.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.IntegralHeight = False
			Me.comboBox1.Location = New System.Drawing.Point(270, 141)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(200, 24)
			Me.comboBox1.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(529, 307)
			Me.Controls.Add(Me.lblText)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.pdfViewerControl1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "Pdf Viewer Demo"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private panel1 As System.Windows.Forms.Panel
		Private pdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
		Private lblText As System.Windows.Forms.Label
		Private comboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace

