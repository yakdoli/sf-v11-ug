Imports System.ComponentModel
Imports System.Text
Imports Syncfusion.PdfViewer.Windows
Imports Syncfusion.Windows.Forms.PdfViewer

Namespace TabbedViewer_2008
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			' Position and size of the form.
			Dim rect As Rectangle = Screen.PrimaryScreen.Bounds
			Me.MinimumSize = New Size(rect.Width * 2 \ 3, rect.Height * (3 \ 2))
			Me.Location = New Point(rect.Width \ 6, 0)
		End Sub
		Private docViewer As New PdfDocumentView()
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'Load all the pdf documents into the tab control
            LoadDocument(pdfDocumentView3, GetFullTemplatePath("EmpReport.pdf"))
			LoadDocument(pdfDocumentView2, GetFullTemplatePath("SimpleTable.pdf"))
            LoadDocument(pdfDocumentView1, GetFullTemplatePath("SyncfusionBrochure.pdf"))
            ActivateControl()
            Me.cmbCurrentZoomLevel.Items.AddRange(New Object() {"50%", "75%", "100%", "125%", "150%", "200%", "400%"})
		End Sub
		#Region "Helper methods"

		''' <summary>
		''' Load a PDF document.
		''' </summary>
		Private Sub LoadDocument(ByVal viewer As PdfDocumentView, ByVal fileName As String)
			viewer.Load(fileName)
			lblTotalPageCount.Text = viewer.PageCount.ToString()
			EnablePagination()
		End Sub

		''' <summary>
		''' Assigning page index.
		''' </summary>
		Private Sub docViewer_CurrentPageChanged(ByVal sender As Object, ByVal args As EventArgs)
			Dim pageIndex As Integer = (TryCast(sender, PdfDocumentView)).CurrentPageIndex
			Me.txtCurrentPageIndex.Text = pageIndex.ToString()
			EnablePagination()
		End Sub

		''' <summary>
		''' Enable or disable paginate buttons.
		''' </summary>
		Private Sub EnablePagination()
			Dim pageIndex As Integer = docViewer.CurrentPageIndex
			Me.btnGoToNextPage.Enabled = docViewer.CanGoToNextPage
			Me.btnGoToLastPage.Enabled = docViewer.CanGoToLastPage
			Me.btnGoToPreviousPage.Enabled = docViewer.CanGoToPreviousPage
			Me.btnGoToFirstPage.Enabled = docViewer.CanGoToFirstPage
		End Sub

		 ''' <summary>
		''' Gets the full path of the PDF template or image.
		''' </summary>
		''' <param name="fileName">Name of the file</param>
		''' <param name="image">True if image</param>
		''' <returns>Path of the file</returns>
		Private Function GetFullTemplatePath(ByVal fileName As String) As String
			Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\"

			Return String.Format("{0}{1}", fullPath, fileName)
		End Function

		''' <summary>
		''' Activates the current tab control
		''' </summary>
		Private Sub ActivateControl()
			'Find a pdf document viewer in the selected tab page.
			Dim pdfControl() As Control = tabControlAdv1.SelectedTab.Controls.Find("pdfDocumentView" & (tabControlAdv1.SelectedIndex + 1), True)
			If pdfControl.Length > 0 AndAlso TypeOf pdfControl(0) Is PdfDocumentView Then
				docViewer = TryCast(pdfControl(0), PdfDocumentView)
			End If
			'Adding event handler for current page index
			AddHandler docViewer.CurrentPageChanged, AddressOf docViewer_CurrentPageChanged
			Me.txtCurrentPageIndex.Text = docViewer.CurrentPageIndex.ToString()
			Me.lblTotalPageCount.Text = docViewer.PageCount.ToString()
			docViewer.Focus()
		End Sub

		''' <summary>
		''' Reset all the fields
		''' </summary>
		Private Sub Reset()
			btnGoToFirstPage.Enabled = False
			btnGoToLastPage.Enabled = False
			btnGoToNextPage.Enabled = False
			btnGoToPreviousPage.Enabled = False
			txtCurrentPageIndex.Text = "0"
			lblTotalPageCount.Text = "0"
		End Sub
		#End Region

		#Region "Event handler"

		''' <summary>
		''' On tab control changed.
		''' </summary>
		Private Sub tabControlAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tabControlAdv1.Click
			ActivateControl()
			EnablePagination()
		End Sub

		''' <summary>
		''' Open a new document in the new tab.
		''' </summary>
		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Pdf Files (.pdf)|*.pdf"
			dialog.ShowDialog()
			If Not String.IsNullOrEmpty(dialog.FileName) Then
				'Adding a new tab and pdf document viewer control
				Dim separator() As String = { "\", "\" }
				Dim FileName() As String = dialog.FileName.Split(separator, StringSplitOptions.RemoveEmptyEntries)
				tabControlAdv1.TabPages.Add(New Syncfusion.Windows.Forms.Tools.TabPageAdv(FileName(FileName.Length - 1).ToString()))
				Dim pdfDocViewer As New PdfDocumentView()
				pdfDocViewer.BackColor = Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(204))))), (CInt(Fix((CByte(204))))))
				pdfDocViewer.Dock = DockStyle.Fill
				pdfDocViewer.Location = New Point(0, 0)
				pdfDocViewer.Name = "pdfDocumentView" & (tabControlAdv1.TabPages.Count)
				pdfDocViewer.Size = New Size(626, 633)
				pdfDocViewer.Text = "pdfDocumentView" & (tabControlAdv1.TabPages.Count)
				'Loads the document into the pdf document viewer
				LoadDocument(pdfDocViewer, dialog.FileName)
				tabControlAdv1.TabPages(tabControlAdv1.TabPages.Count - 1).Controls.Add(pdfDocViewer)
				tabControlAdv1.SelectedIndex = tabControlAdv1.TabPages.Count - 1
				tabControlAdv1.SelectedTab.Text = FileName(FileName.Length - 1).ToString()
				ActivateControl()
				EnablePagination()
			End If
		End Sub

		''' <summary>
		''' Handles next page navigation.
		''' </summary>
		Private Sub btnGoToNextPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoToNextPage.Click
			If docViewer.CanGoToNextPage Then
				docViewer.GoToNextPage()
			End If
		End Sub

		''' <summary>
		''' Handles previous page navigation.
		''' </summary>
		Private Sub btnGoToPreviousPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoToPreviousPage.Click
			If docViewer.CanGoToPreviousPage Then
				docViewer.GoToPreviousPage()
			End If
		End Sub

		''' <summary>
		''' Handles last page navigation.
		''' </summary>
		Private Sub btnGoToLastPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoToLastPage.Click
			If docViewer.CanGoToLastPage Then
				docViewer.GoToLastPage()
			End If
		End Sub

		''' <summary>
		''' Handles first page navigation.
		''' </summary>
		Private Sub btnGoToFirstPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoToFirstPage.Click
			If docViewer.CanGoToFirstPage Then
				docViewer.GoToFirstPage()
			End If
		End Sub

		''' <summary>
		''' Handles zoom.
		''' </summary>
		Private Sub cmbCurrentZoomLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrentZoomLevel.SelectedIndexChanged
			Dim ZoomLevel As Integer = Convert.ToInt32(cmbCurrentZoomLevel.SelectedItem.ToString().Replace("%", ""))
			docViewer.ZoomTo(ZoomLevel)
		End Sub

		''' <summary>
		''' Handles zoom in.
		''' </summary>
		Private Sub btnZoomIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoomIn.Click
			If cmbCurrentZoomLevel.SelectedIndex <> 0 Then
				cmbCurrentZoomLevel.SelectedIndex = cmbCurrentZoomLevel.SelectedIndex - 1
			End If
		End Sub

		''' <summary>
		''' Handles zoom out.
		''' </summary>
		Private Sub btnZoomOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoomOut.Click
			If cmbCurrentZoomLevel.SelectedIndex <> cmbCurrentZoomLevel.Items.Count - 1 Then
				cmbCurrentZoomLevel.SelectedIndex = cmbCurrentZoomLevel.SelectedIndex + 1
			End If
		End Sub

		''' <summary>
		''' Prints the document.
		''' </summary>
		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Dim dialog As New PrintDialog()

			Dim pageCount As Integer = docViewer.PageCount
			dialog.AllowPrintToFile = True
			dialog.AllowSomePages = True
			dialog.PrinterSettings.FromPage = 1
			dialog.PrinterSettings.ToPage = pageCount
			dialog.PrinterSettings.MaximumPage = pageCount
			dialog.PrinterSettings.MinimumPage = 1

			If dialog.ShowDialog() = DialogResult.OK Then
				dialog.Document = docViewer.PrintDocument
			End If
		End Sub

		''' <summary>
		''' On tab closed, reorder the document viewer control
		''' </summary>
		Private Sub tabControlAdv1_ControlRemoved(ByVal sender As Object, ByVal e As ControlEventArgs) Handles tabControlAdv1.ControlRemoved
			If tabControlAdv1.SelectedIndex > -1 Then
				For i As Integer = tabControlAdv1.SelectedIndex To tabControlAdv1.TabPages.Count - 1
					Dim pdfControl() As Control = tabControlAdv1.TabPages(i).Controls.Find("pdfDocumentView" & (i + 2), True)
					If pdfControl.Length > 0 AndAlso TypeOf pdfControl(0) Is PdfDocumentView Then
						Dim viewer As PdfDocumentView = TryCast(pdfControl(0), PdfDocumentView)
						viewer.Name = "pdfDocumentView" & (i + 1)
					End If
				Next i
				ActivateControl()
				EnablePagination()
			Else
				Reset()
			End If
		End Sub

		''' <summary>
		''' Handles the fit page
		''' </summary>
		Private Sub FitPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FitPage.Click
			docViewer.ZoomTo(ZoomMode.FitPage)
		End Sub

		''' <summary>
		''' Handles the fit width
		''' </summary>
		Private Sub FitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FitWidth.Click
			docViewer.ZoomTo(ZoomMode.FitWidth)
		End Sub
		#End Region
	End Class
End Namespace