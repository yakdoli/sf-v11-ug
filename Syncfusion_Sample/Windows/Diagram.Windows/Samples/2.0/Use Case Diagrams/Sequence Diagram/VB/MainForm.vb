Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Printing
Imports Syncfusion.Windows.Forms.Diagram
Imports System.IO

Namespace Sequence_Diagram_2005
	''' <summary>
	''' Sample application form.
	''' </summary>
	Partial Public Class MainForm
		Inherits Form
		#Region "Class Members"
		Private strFileName As String = String.Empty
		#End Region

		#Region "Class Initialization"
		''' <summary>
		''' Intializes the new instance of MainForm class
		''' </summary>
		Public Sub New()
			InitializeComponent()
            'load sequence diagram
            strFileName = "..//..//Data//Sequence Diagram.edd"
			diagram1.LoadBinary("..//..//Data//Sequence Diagram.edd")
			diagram1.Model.LineStyle.LineColor = Color.LightGray
			'diagram view settings
			diagram1.View.Grid.GridStyle = Syncfusion.Windows.Forms.Diagram.GridStyle.Line
			diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
			diagram1.View.Grid.Color = Color.LightGray
			diagram1.View.HandleRenderer.HandleColor = Color.White
			diagram1.View.HandleRenderer.HandleOutlineColor = Color.Gray
			diagram1.View.BackgroundColor = Color.White
			diagram1.View.Grid.HorizontalSpacing = 15
			diagram1.View.Grid.VerticalSpacing = 15
			'load sequence diagram shapes into the palette
			paletteGroupBar1.LoadPalette("..//..//Data//Sequence Diagram Shapes.edp")
			For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.FlowView = True
					view.ShowToolTips = True
					view.ShowFlowViewItemText = True
					view.SelectedItemColor = Color.FromArgb(255, 219, 118)
					view.HighlightItemColor = Color.FromArgb(255, 227, 149)
					view.SelectingItemColor = Color.FromArgb(255, 238, 184)
					view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
					view.FlowViewItemTextLength = 80
					view.BackColor = Color.White
					view.TextWrap = True
					view.FlatLook = True
					view.BorderStyle = BorderStyle.None
				End If
			Next item
			AddHandler Application.Idle, AddressOf Application_Idle
			btnRuler.Checked = diagram1.ShowRulers
			btnGrid.Checked = diagram1.View.Grid.Visible
			btnSnapToGrid.Checked = diagram1.View.Grid.SnapToGrid
		End Sub
		#End Region

		#Region "Class Events"
		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			btnCut.Enabled = diagram1.Controller.CanCut
			btnCopy.Enabled = diagram1.Controller.CanCopy
			If Me.WindowState <> FormWindowState.Minimized Then
				btnPaste.Enabled = diagram1.Controller.CanPaste
			End If
			btnUndo.Enabled = diagram1.Model.HistoryManager.CanUndo
			btnRedo.Enabled = diagram1.Model.HistoryManager.CanRedo
		End Sub

		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			'creates a print document
			Dim printDoc As PrintDocument = diagram1.CreatePrintDocument()
			Dim printPreviewDlg As New PrintPreviewDialog()
			printDoc.PrinterSettings.FromPage = 0
			printDoc.PrinterSettings.ToPage = 0
			printDoc.PrinterSettings.PrintRange = PrintRange.AllPages

			printPreviewDlg.Document = printDoc
			printPreviewDlg.ShowDialog(Me)
		End Sub

		Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			If diagram1.Model.Modified Then
				If MessageBox.Show("The Diagram has been modified. Save Changes?", "Save Changes", MessageBoxButtons.YesNoCancel) = System.Windows.Forms.DialogResult.Yes Then
					btnSave_Click(sender, e)
				End If
			Else
				'Create a new diagram document
				diagram1.Model.Clear()
				Dim model As New Model()
				model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
				model.LineStyle.LineColor = Color.LightGray
				diagram1.Model = model
				strFileName = String.Empty
			End If
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			If diagram1.Model.Modified Then
                If strFileName = String.Empty Then
                    saveFileDialog.Filter = "EDD file(*.edd)|*.edd"
                    If saveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        diagram1.SaveBinary(saveFileDialog.FileName)
                        strFileName = saveFileDialog.FileName
                    End If
                Else
                    'Serialize the diagram document as either binary or xml document
                    Dim fileInfo As New FileInfo(strFileName)
                    If fileInfo.Extension = ".edd" Then
                        diagram1.SaveBinary(strFileName)
                    End If
                    If fileInfo.Extension = ".xml" Then
                        diagram1.SaveSoap(strFileName)
                    End If
                End If
			End If
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			If diagram1.Model.Modified Then
				If MessageBox.Show("The Diagram has been modified. Save Changes?", "Save Changes", MessageBoxButtons.YesNoCancel) = System.Windows.Forms.DialogResult.Yes Then
					btnSave_Click(sender, e)
				End If
			Else
				'Open a serialized binary/xml diagram document
				If openFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					Dim fileInfo As New FileInfo(openFileDialog.FileName)
                    strFileName = openFileDialog.FileName
					If fileInfo.Extension = ".edd" Then
						diagram1.LoadBinary(strFileName)
					End If
					If fileInfo.Extension = ".xml" Then
						diagram1.LoadSoap(strFileName)
					End If
				End If
			End If
		End Sub

		Private Sub btnSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveAs.Click
			'Save as the diagram with given file format
			If saveAsFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				diagram1.SaveSoap(saveAsFileDialog.FileName)
				strFileName = saveAsFileDialog.FileName
			End If
		End Sub

		Private Sub exportPng_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exportPng.Click
			'Export diagram as png
			exportFileDialog.Filter = "PNG | *.png"
			If exportFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				diagram1.ExportDiagramAsImage(True).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
			End If
		End Sub

		Private Sub exportJpg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exportJpg.Click
			'Export diagram as jpg
			exportFileDialog.Filter = "JPG | *.jpg"
			If exportFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				diagram1.ExportDiagramAsImage(True).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
			End If
		End Sub

		Private Sub exportPdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exportPdf.Click
			'Export diagram as gif
			exportFileDialog.Filter = "GIF | *.gif"
			If exportFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				diagram1.ExportDiagramAsImage(True).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif)
			End If
		End Sub

		Private Sub btnUndo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUndo.Click
			'Undo
			Me.diagram1.Model.HistoryManager.Undo()
		End Sub

		Private Sub btnRedo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRedo.Click
			'Redo
			Me.diagram1.Model.HistoryManager.Redo()
		End Sub

		Private Sub btnCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCut.Click
			'Cut
			Me.diagram1.Controller.Cut()
		End Sub

		Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopy.Click
			'Copy
			Me.diagram1.Controller.Copy()
		End Sub

		Private Sub btnPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPaste.Click
			'Paste
			Me.diagram1.Controller.Paste()
		End Sub

		Private Sub btnRuler_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRuler.Click
			'Enable ruler
			Me.diagram1.ShowRulers = btnRuler.Checked
		End Sub

		Private Sub btnSnapToGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapToGrid.Click
			'Enable snap to grid
			diagram1.View.Grid.SnapToGrid = btnSnapToGrid.Checked
		End Sub

		Private Sub btnGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGrid.Click
			'Enable grid
			diagram1.View.Grid.Visible = btnGrid.Checked
		End Sub

		Private Sub btnSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSize.Click
			'Open a page size dialog for change the model document size
			Using dlgPageSize As New PageSizeDialog()
				dlgPageSize.PageSize = CType(Me.diagram1.Model.DocumentSize.Clone(), PageSize)
				dlgPageSize.PrinterSettings = CType(Me.diagram1.View.PageSettings.Clone(), System.Drawing.Printing.PageSettings)
				If dlgPageSize.ShowDialog(Me.diagram1) = System.Windows.Forms.DialogResult.OK Then
					Me.diagram1.Model.DocumentSize = dlgPageSize.PageSize
					Me.diagram1.View.PageSettings.Landscape = dlgPageSize.PrinterSettings.Landscape
				End If
			End Using
		End Sub

		Private Sub btnAutoSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAutoSize.Click
			'Fit the document to the diagram content
			Me.diagram1.Model.SizeToContent = True
		End Sub

		Private Sub btnPageSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPageSettings.Click
			'Open a page setup dialog for diagram page setup
			Using dlgPageSetup As New Syncfusion.Windows.Forms.Diagram.PageSetupDialog(diagram1.View)
				If dlgPageSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					diagram1.UpdateView()
				End If
			End Using
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			'print the diagram document
			Dim printDoc As DiagramPrintDocument = diagram1.CreatePrintDocument()
            printDialog.Document = printDoc
            printDialog.UseEXDialog = True
			printDialog.AllowSomePages = True
			If printDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				printDoc.PrinterSettings = printDialog.PrinterSettings
				printDoc.Print()
			End If
		End Sub
		#End Region
	End Class
End Namespace