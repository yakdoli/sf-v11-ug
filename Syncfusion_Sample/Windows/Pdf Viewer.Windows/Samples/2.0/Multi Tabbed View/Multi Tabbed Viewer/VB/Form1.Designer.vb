Namespace TabbedViewer_2008
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
            Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
            Me.Tab1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.pdfDocumentView1 = New Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.Tab2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.pdfDocumentView2 = New Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
            Me.Tab3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.pdfDocumentView3 = New Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.btnPrint = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.btnGoToFirstPage = New System.Windows.Forms.ToolStripButton
            Me.btnGoToPreviousPage = New System.Windows.Forms.ToolStripButton
            Me.txtCurrentPageIndex = New System.Windows.Forms.ToolStripTextBox
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
            Me.lblTotalPageCount = New System.Windows.Forms.ToolStripLabel
            Me.btnGoToNextPage = New System.Windows.Forms.ToolStripButton
            Me.btnGoToLastPage = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripSeparator
            Me.btnZoomIn = New System.Windows.Forms.ToolStripButton
            Me.btnZoomOut = New System.Windows.Forms.ToolStripButton
            Me.cmbCurrentZoomLevel = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.FitPage = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.FitWidth = New System.Windows.Forms.ToolStripButton
            Me.Tab1.SuspendLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.Tab2.SuspendLayout()
            Me.Tab3.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Tab1
            '
            Me.Tab1.Controls.Add(Me.pdfDocumentView1)
            Me.Tab1.Image = Nothing
            Me.Tab1.ImageSize = New System.Drawing.Size(16, 16)
            Me.Tab1.Location = New System.Drawing.Point(3, 33)
            Me.Tab1.Name = "Tab1"
            Me.Tab1.Size = New System.Drawing.Size(626, 324)
            Me.Tab1.TabIndex = 1
            Me.Tab1.Text = "DataSheet.pdf"
            Me.Tab1.ThemesEnabled = True
            Me.Tooltip.SetToolTip(Me.Tab1, "hello")
            '
            'pdfDocumentView1
            '
            Me.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfDocumentView1.Location = New System.Drawing.Point(0, 0)
            Me.pdfDocumentView1.Name = "pdfDocumentView1"
            Me.pdfDocumentView1.Size = New System.Drawing.Size(626, 324)
            Me.pdfDocumentView1.TabIndex = 0
            Me.pdfDocumentView1.Text = "pdfDocumentView1"
            'Me.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.Controls.Add(Me.Tab1)
            Me.tabControlAdv1.Controls.Add(Me.Tab2)
            Me.tabControlAdv1.Controls.Add(Me.Tab3)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 25)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.ShowTabCloseButton = True
            Me.tabControlAdv1.Size = New System.Drawing.Size(633, 361)
            Me.tabControlAdv1.TabIndex = 3
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2008)
            Me.tabControlAdv1.ThemesEnabled = True
            '
            'Tab2
            '
            Me.Tab2.Controls.Add(Me.pdfDocumentView2)
            Me.Tab2.Image = Nothing
            Me.Tab2.ImageSize = New System.Drawing.Size(16, 16)
            Me.Tab2.Location = New System.Drawing.Point(3, 33)
            Me.Tab2.Name = "Tab2"
            Me.Tab2.Size = New System.Drawing.Size(626, 633)
            Me.Tab2.TabIndex = 2
            Me.Tab2.Text = "SimpleTable.pdf"
            Me.Tab2.ThemesEnabled = True
            '
            'pdfDocumentView2
            '
            Me.pdfDocumentView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pdfDocumentView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfDocumentView2.Location = New System.Drawing.Point(0, 0)
            Me.pdfDocumentView2.Name = "pdfDocumentView2"
            Me.pdfDocumentView2.Size = New System.Drawing.Size(626, 633)
            Me.pdfDocumentView2.TabIndex = 0
            Me.pdfDocumentView2.Text = "pdfDocumentView2"
            'Me.pdfDocumentView2.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
            '
            'Tab3
            '
            Me.Tab3.Controls.Add(Me.pdfDocumentView3)
            Me.Tab3.Image = Nothing
            Me.Tab3.ImageSize = New System.Drawing.Size(16, 16)
            Me.Tab3.Location = New System.Drawing.Point(3, 33)
            Me.Tab3.Name = "Tab3"
            Me.Tab3.Size = New System.Drawing.Size(626, 633)
            Me.Tab3.TabIndex = 3
            Me.Tab3.Text = "EmpReport.pdf"
            Me.Tab3.ThemesEnabled = True
            '
            'pdfDocumentView3
            '
            Me.pdfDocumentView3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pdfDocumentView3.Dock = System.Windows.Forms.DockStyle.Top
            Me.pdfDocumentView3.Location = New System.Drawing.Point(0, 0)
            Me.pdfDocumentView3.Name = "pdfDocumentView3"
            Me.pdfDocumentView3.Size = New System.Drawing.Size(626, 633)
            Me.pdfDocumentView3.TabIndex = 0
            Me.pdfDocumentView3.Text = "pdfDocumentView3"
            'Me.pdfDocumentView3.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripSeparator2, Me.btnPrint, Me.toolStripSeparator1, Me.btnGoToFirstPage, Me.btnGoToPreviousPage, Me.txtCurrentPageIndex, Me.toolStripLabel1, Me.lblTotalPageCount, Me.btnGoToNextPage, Me.btnGoToLastPage, Me.toolStripButton3, Me.btnZoomIn, Me.btnZoomOut, Me.cmbCurrentZoomLevel, Me.toolStripSeparator3, Me.FitPage, Me.toolStripSeparator5, Me.FitWidth})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(633, 25)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'toolStripButton1
            '
            Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton1.Text = "btnOpenFile"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'btnPrint
            '
            Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(23, 22)
            Me.btnPrint.Text = "Click to Print this PDF file or pages from it."
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'btnGoToFirstPage
            '
            Me.btnGoToFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnGoToFirstPage.Image = CType(resources.GetObject("btnGoToFirstPage.Image"), System.Drawing.Image)
            Me.btnGoToFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnGoToFirstPage.Name = "btnGoToFirstPage"
            Me.btnGoToFirstPage.Size = New System.Drawing.Size(23, 22)
            Me.btnGoToFirstPage.Text = "toolStripButton2"
            Me.btnGoToFirstPage.ToolTipText = "Click to go to first page in the document."
            '
            'btnGoToPreviousPage
            '
            Me.btnGoToPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnGoToPreviousPage.Image = CType(resources.GetObject("btnGoToPreviousPage.Image"), System.Drawing.Image)
            Me.btnGoToPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnGoToPreviousPage.Name = "btnGoToPreviousPage"
            Me.btnGoToPreviousPage.Size = New System.Drawing.Size(23, 22)
            Me.btnGoToPreviousPage.Text = "toolStripButton3"
            Me.btnGoToPreviousPage.ToolTipText = "Click to go to previous page in the document."
            '
            'txtCurrentPageIndex
            '
            Me.txtCurrentPageIndex.Name = "txtCurrentPageIndex"
            Me.txtCurrentPageIndex.Size = New System.Drawing.Size(30, 25)
            Me.txtCurrentPageIndex.Text = "1"
            Me.txtCurrentPageIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.toolStripLabel1.Size = New System.Drawing.Size(17, 22)
            Me.toolStripLabel1.Text = "/"
            '
            'lblTotalPageCount
            '
            Me.lblTotalPageCount.Name = "lblTotalPageCount"
            Me.lblTotalPageCount.Size = New System.Drawing.Size(25, 22)
            Me.lblTotalPageCount.Text = "100"
            '
            'btnGoToNextPage
            '
            Me.btnGoToNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnGoToNextPage.Image = CType(resources.GetObject("btnGoToNextPage.Image"), System.Drawing.Image)
            Me.btnGoToNextPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnGoToNextPage.Name = "btnGoToNextPage"
            Me.btnGoToNextPage.Size = New System.Drawing.Size(23, 22)
            Me.btnGoToNextPage.Text = "toolStripButton4"
            Me.btnGoToNextPage.ToolTipText = "Click to go to next page in the document."
            '
            'btnGoToLastPage
            '
            Me.btnGoToLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnGoToLastPage.Image = CType(resources.GetObject("btnGoToLastPage.Image"), System.Drawing.Image)
            Me.btnGoToLastPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnGoToLastPage.Name = "btnGoToLastPage"
            Me.btnGoToLastPage.Size = New System.Drawing.Size(23, 22)
            Me.btnGoToLastPage.Text = "toolStripButton5"
            Me.btnGoToLastPage.ToolTipText = "Click to go to last page in the document."
            '
            'toolStripButton3
            '
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(6, 25)
            '
            'btnZoomIn
            '
            Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"), System.Drawing.Image)
            Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnZoomIn.Name = "btnZoomIn"
            Me.btnZoomIn.Size = New System.Drawing.Size(23, 22)
            Me.btnZoomIn.Text = "toolStripButton4"
            Me.btnZoomIn.ToolTipText = "Click to decrease the magnification of the entire page."
            '
            'btnZoomOut
            '
            Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
            Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnZoomOut.Name = "btnZoomOut"
            Me.btnZoomOut.Size = New System.Drawing.Size(23, 22)
            Me.btnZoomOut.ToolTipText = "Click to increase the magnification of the entire page."
            '
            'cmbCurrentZoomLevel
            '
            Me.cmbCurrentZoomLevel.Name = "cmbCurrentZoomLevel"
            Me.cmbCurrentZoomLevel.Size = New System.Drawing.Size(75, 25)
            Me.cmbCurrentZoomLevel.Text = "100%"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'FitPage
            '
            Me.FitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.FitPage.Image = CType(resources.GetObject("FitPage.Image"), System.Drawing.Image)
            Me.FitPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.FitPage.Name = "FitPage"
            Me.FitPage.Size = New System.Drawing.Size(23, 22)
            Me.FitPage.Text = "Fit Page"
            '
            'toolStripSeparator5
            '
            Me.toolStripSeparator5.Name = "toolStripSeparator5"
            Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
            '
            'FitWidth
            '
            Me.FitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.FitWidth.Image = CType(resources.GetObject("FitWidth.Image"), System.Drawing.Image)
            Me.FitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.FitWidth.Name = "FitWidth"
            Me.FitWidth.Size = New System.Drawing.Size(23, 22)
            Me.FitWidth.Text = "Fit Width"
            '
            'Form1
            '
            Me.AutoSize = True
            Me.ClientSize = New System.Drawing.Size(633, 386)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Controls.Add(Me.toolStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Multi Tabbed Viewer"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Tab1.ResumeLayout(False)
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.Tab2.ResumeLayout(False)
            Me.Tab3.ResumeLayout(False)
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region
		Private Tooltip As ToolTip
		Private WithEvents tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private Tab1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private Tab2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private pdfDocumentView1 As Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
		Private pdfDocumentView2 As Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView

		Private toolStrip1 As ToolStrip
		Private WithEvents btnPrint As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents btnGoToFirstPage As ToolStripButton
		Private WithEvents btnGoToPreviousPage As ToolStripButton
		Private txtCurrentPageIndex As ToolStripTextBox
		Private toolStripLabel1 As ToolStripLabel
		Private lblTotalPageCount As ToolStripLabel
		Private WithEvents btnGoToNextPage As ToolStripButton
		Private WithEvents btnGoToLastPage As ToolStripButton
		Private WithEvents cmbCurrentZoomLevel As ToolStripComboBox
		Private toolStripSeparator3 As ToolStripSeparator
		Private toolStripButton3 As ToolStripSeparator
		Private WithEvents btnZoomIn As ToolStripButton
		Private WithEvents btnZoomOut As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents toolStripButton1 As ToolStripButton
		Private Tab3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private pdfDocumentView3 As Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView
		Private WithEvents FitPage As ToolStripButton
		Private toolStripSeparator5 As ToolStripSeparator
		Private WithEvents FitWidth As ToolStripButton
	End Class
End Namespace

