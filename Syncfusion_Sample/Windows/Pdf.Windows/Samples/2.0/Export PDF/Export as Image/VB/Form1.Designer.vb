Imports Microsoft.VisualBasic
Imports System
Namespace ExportasImage_2005
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
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.allPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.selectedPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
			Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.pdfDocumentView1 = New Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView()
			Me.toolStrip1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripSeparator2, Me.toolStripDropDownButton1, Me.toolStripSeparator1, Me.toolStripLabel1, Me.toolStripTextBox1, Me.toolStripLabel2, Me.toolStripTextBox2})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(284, 25)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' toolStripDropDownButton1
			' 
			Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.allPagesToolStripMenuItem, Me.selectedPagesToolStripMenuItem})
			Me.toolStripDropDownButton1.Image = (CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
			Me.toolStripDropDownButton1.Size = New System.Drawing.Size(82, 22)
			Me.toolStripDropDownButton1.Text = "Page Range"
			' 
			' allPagesToolStripMenuItem
			' 
			Me.allPagesToolStripMenuItem.Checked = True
			Me.allPagesToolStripMenuItem.CheckOnClick = True
			Me.allPagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.allPagesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.allPagesToolStripMenuItem.Name = "allPagesToolStripMenuItem"
			Me.allPagesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.allPagesToolStripMenuItem.Text = "All Pages"
'			Me.allPagesToolStripMenuItem.Click += New System.EventHandler(Me.pageRange_Clicked)
			' 
			' selectedPagesToolStripMenuItem
			' 
			Me.selectedPagesToolStripMenuItem.CheckOnClick = True
			Me.selectedPagesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.selectedPagesToolStripMenuItem.Name = "selectedPagesToolStripMenuItem"
			Me.selectedPagesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.selectedPagesToolStripMenuItem.Text = "Selected Pages"
'			Me.selectedPagesToolStripMenuItem.Click += New System.EventHandler(Me.pageRange_Clicked)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(35, 22)
			Me.toolStripLabel1.Text = "From"
			' 
			' toolStripTextBox1
			' 
			Me.toolStripTextBox1.Name = "toolStripTextBox1"
			Me.toolStripTextBox1.Size = New System.Drawing.Size(25, 25)
			' 
			' toolStripLabel2
			' 
			Me.toolStripLabel2.Name = "toolStripLabel2"
			Me.toolStripLabel2.Size = New System.Drawing.Size(21, 22)
			Me.toolStripLabel2.Text = "To"
			' 
			' toolStripTextBox2
			' 
			Me.toolStripTextBox2.Name = "toolStripTextBox2"
			Me.toolStripTextBox2.Size = New System.Drawing.Size(25, 25)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton1.Text = "Export"
'			Me.toolStripButton1.Click += New System.EventHandler(Me.toolStripButton1_Click)
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.pdfDocumentView1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 25)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(284, 237)
			Me.panel1.TabIndex = 1
			' 
			' pdfDocumentView1
			' 
			Me.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(204))))), (CInt(Fix((CByte(204))))))
			Me.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfDocumentView1.Location = New System.Drawing.Point(0, 0)
			Me.pdfDocumentView1.Name = "pdfDocumentView1"
			Me.pdfDocumentView1.Size = New System.Drawing.Size(284, 237)
			Me.pdfDocumentView1.TabIndex = 1
			Me.pdfDocumentView1.Text = "pdfDocumentView1"
			'this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "Export as Image"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents allPagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents selectedPagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
		Private toolStripLabel2 As System.Windows.Forms.ToolStripLabel
		Private toolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private panel1 As System.Windows.Forms.Panel
		Private pdfDocumentView1 As Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
	End Class
End Namespace

