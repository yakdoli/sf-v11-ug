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


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.IO

Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls

Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms
Imports System.Reflection

Namespace ExportImage
    Partial Friend Class MainForm : Inherits Office2007Form
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.diagram1.Model = Me.Model
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New MainForm())
        End Sub

#Region "ClassMethods"

        Private Sub AddInfotoImage()
            Dim txtnode As TextNode = New TextNode("Image created using Syncfusion Essential Diagram")

            txtnode.LineStyle.LineColor = Color.Transparent
            txtnode.Name = "ImageInfo"
            txtnode.BackgroundStyle.Color = Color.Azure
            txtnode.FontStyle.Family = "Arial"
            txtnode.SizeToText(New SizeF(0, 0))

            Dim location As PointF = New PointF((Me.diagram1.Model.DocumentSize.Width / 2), (Me.diagram1.Model.DocumentSize.Height - (2 * (txtnode.Size.Height))))
            txtnode.PinPoint = location

            Me.diagram1.Controller.Model.AppendChild(txtnode)
        End Sub

        Private Sub RemoveInfofromImage()
            Dim tnode As TextNode = CType(Me.diagram1.Controller.Model.Nodes.FindNodeByName("ImageInfo"), TextNode)

            If Not tnode Is Nothing Then
                Me.diagram1.Controller.Model.RemoveChild(tnode)
            End If
        End Sub

        Private Sub SaveImage(ByVal filename As String, ByVal imageformat As ImageFormat)
            If Not imageformat Is Imaging.ImageFormat.Emf Then
                Dim img As Image = Me.diagram1.View.ExportDiagramAsImage(True)
                img.Save(filename, imageformat)
            Else ' Export diagram to a metafile
                Me.SaveDiagramAsEmf(filename)
            End If
        End Sub

        ' Create a Metafile with the provided file name and draw teh diagram to it.
        Private Sub SaveDiagramAsEmf(ByVal filename As String)
            ' Create a Metafile with the provided file name and draw the diagram to it.
            Dim diagramimage As Image = New Bitmap(1, 1, PixelFormat.Format24bppRgb)
            Dim grfx As Graphics = Graphics.FromImage(diagramimage)
            Dim hdc As IntPtr = grfx.GetHdc()
            Dim emf As Metafile = New Metafile(filename, hdc, EmfType.EmfOnly)
            Dim emfgrfx As Graphics = Graphics.FromImage(emf)

            Me.diagram1.ExportDiagramToGraphics(emfgrfx)

            grfx.ReleaseHdc(hdc)
            grfx.Dispose()
            emfgrfx.Dispose()
            diagramimage.Dispose()
            emf.Dispose()
        End Sub
#End Region

#Region "Main_Load"
        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

            Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\ExportImage_DataFlow.edd")
            Me.paletteGroupView1.ShowToolTips = True
            Me.diagram1.View.Grid.GridStyle = GridStyle.Line
            Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.diagram1.View.Grid.Color = Color.LightGray
            Me.diagram1.View.Grid.VerticalSpacing = 15
            Me.diagram1.View.Grid.HorizontalSpacing = 15
            Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5F
            Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
            Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram1.View.SelectionList.Clear()

            ' Make the diagram Readonly
            For Each n As Node In diagram1.Model.Nodes
                n.EditStyle.AllowSelect = False
            Next
            diagram1.AllowDrop = False
        End Sub
#End Region

#Region "Export"
        ' Exports the Diagram as Image file format.
#Region "ExportImageFormat"
        Private Sub ExportImage()
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Windows Bitmap(*.bmp)|*.bmp|Exchangeable Image Format(*.exif)|*.exif|Graphics Interchange Format(*.gif)|*.gif|Windows Icon Image(*.ico)|*.ico|Joint Photographic Experts Group(*.jpeg)|*.jpeg|W3C Portable Network Graphics(*.png)|*.png|Tag Image File Format(*.tiff)|*.tiff" '|Enhanced Metafile Format(*.emf)|*.emf";
            saveFileDialog1.Title = "Export Diagram As:"

            Dim imgformat As ImageFormat = ImageFormat.Bmp
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        imgformat = ImageFormat.Bmp
                    Case 2
                        imgformat = ImageFormat.Exif
                    Case 3
                        imgformat = ImageFormat.Gif
                    Case 4
                        imgformat = ImageFormat.Icon
                    Case 5
                        imgformat = ImageFormat.Jpeg
                    Case 6
                        imgformat = ImageFormat.Png
                    Case 7
                        imgformat = ImageFormat.Tiff
                End Select
                AddInfotoImage()
                SaveImage(saveFileDialog1.FileName, imgformat)
                RemoveInfofromImage()
            Else
                Return
            End If
        End Sub
#End Region


        ' Exports the Diagram as Emf file format
#Region "ExportEmf"
        Private Sub ExportEmf()
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Enhanced Metafile Format(*.emf)|*.emf"
            saveFileDialog1.Title = "Export Diagram As:"

            Dim imgformat As ImageFormat = ImageFormat.Emf
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                imgformat = ImageFormat.Emf
                AddInfotoImage()
                SaveImage(saveFileDialog1.FileName, imgformat)
                RemoveInfofromImage()
            Else
                Return
            End If

        End Sub
#End Region

        ' Exports the Diagram as Svg file format
#Region "ExportSvg"
        Private Sub ExportSvg()
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Scalable Vector Graphics Format(*.svg)|*.svg"
            saveFileDialog1.Title = "Export Diagram As:"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then

                Dim tosvg As ToSvg = New ToSvg()
                ' Get Diagram Nodes Bounding Rectangle.
                Dim rectBounding As RectangleF = Me.diagram1.Model.GetBoundingRect()
                Dim gfx As Graphics = tosvg.GetRealGraphics(New Size(CInt(rectBounding.Width), CInt(rectBounding.Height)))
                AddInfotoImage()
                Me.diagram1.ExportDiagramToGraphics(gfx)
                tosvg.Save(saveFileDialog1.FileName)
                RemoveInfofromImage()
            Else
                Return
            End If
        End Sub


#End Region


        ' Exports the Diagram as Pdf file format
#Region "ExportPDF"

#If Essential_PDF_Installed Then

		Private Sub menuExportPdf_Click(ByVal sender As Object, ByVal e As EventArgs)

			AddInfotoImage()

			Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
			saveFileDialog1.Filter = "Portable Document Format(*.pdf)|*.pdf"
			saveFileDialog1.Title = "Export Diagram As:"

			If saveFileDialog1.ShowDialog() = DialogResult.OK Then
				Select Case saveFileDialog1.FilterIndex
					Case 1
						AddInfotoImage()
						Me.SaveDiagramAsPdf(saveFileDialog1.FileName)
						RemoveInfofromImage()
				End Select
			Else
				Return
			End If

		End Sub

		Private Sub SaveDiagramAsPdf(ByVal filename As String)
			Try
				Dim diagramimage As Image = New Bitmap(1, 1, PixelFormat.Format24bppRgb)
				Dim grfx As Graphics = Graphics.FromImage(diagramimage)
				Dim hdc As IntPtr = grfx.GetHdc()
				Dim emf As Metafile = New Metafile(hdc, EmfType.EmfOnly)
				Dim emfgrfx As Graphics = Graphics.FromImage(emf)

				Me.diagram1.ExportDiagramToGraphics(emfgrfx)

				grfx.ReleaseHdc(hdc)
				grfx.Dispose()
				emfgrfx.Dispose()
				diagramimage.Dispose()

				'Create a new PDF Document. This object represents the whole PDF document.
				'This document had One page by default. Additional pages have to be added.



			   Dim pdfDoc As Syncfusion.Pdf.PdfDocument = New Syncfusion.Pdf.PdfDocument()



				pdfDoc.Pages.Add()
				'Draw the WMF Image
				pdfDoc.Pages(pdfDoc.Pages.Count - 1).Graphics.DrawImage(Syncfusion.Pdf.Graphics.PdfImage.FromImage(emf), New PointF(3, 3))

				'Save the PDF Document to disk.
				pdfDoc.Save(filename)

			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub
#End If
#End Region
#End Region

#Region "Event Handlers"
        ' Displays popup menu on right click the mouse on Diagram
#Region "PopupMenu"
        Private Sub diagram1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles diagram1.MouseClick

            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim conMenu As ContextMenu = New ContextMenu()
                Me.contextMenu2.Show(CType(IIf(TypeOf sender Is Diagram, sender, Nothing), Diagram), New Point(e.X, e.Y))
            End If
        End Sub
#End Region


#Region "PalatteGroupBar color setting"
        Private Sub PaletteGroupBar1_ProvideGroupBarItemBrush(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ProvideGroupBarItemBrushEventArgs)

            Dim blend As Blend = New Blend()
            blend.Factors = New Single() {0.0F, 0.0F, 1.0F}
            blend.Positions = New Single() {0.0F, 0.5F, 1.0F}
            ' Estimate the GroupBarItem bounds
            Dim rcgroupbaritem As System.Drawing.Rectangle = args.Bounds
            ' Create and initialize the LinearGradientBrush
            Dim lgbrush As LinearGradientBrush = New LinearGradientBrush(rcgroupbaritem, Color.WhiteSmoke, Color.FromArgb(218, 231, 249), 90, True)
            lgbrush.Blend = blend
            args.BackgroundBrush = lgbrush
            args.BackgroundBrush = lgbrush

        End Sub
#End Region
#End Region

        Private Sub ExportAsImageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAsImageToolStripMenuItem1.Click
            ExportImage()
        End Sub

        Private Sub ExportAsSvgToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAsSvgToolStripMenuItem1.Click
            ExportSvg()
        End Sub

        Private Sub ExportAsEmfToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAsEmfToolStripMenuItem1.Click
            ExportEmf()
        End Sub
        Private Sub menuExportEmf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuExportEmf.Click
            ExportEmf()
        End Sub

        Private Sub menuExportSvg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuExportSvg.Click
            ExportSvg()
        End Sub

        Private Sub menuExportImg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuExportImg.Click
            ExportImage()
        End Sub
     
    End Class
End Namespace
