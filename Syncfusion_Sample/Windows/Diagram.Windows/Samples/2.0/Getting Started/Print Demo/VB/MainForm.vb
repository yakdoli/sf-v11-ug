#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports DemoCommon.Diagram
Imports System.Runtime.Serialization.Formatters.Binary


Namespace Syncfusion.Windows.Forms.Diagram.Samples.Printing
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Partial Friend Class MainForm : Inherits DemoForm

#Region "Properties"
        Public Property DiagramFileName() As String
            Get
                Return Me.fileName
            End Get
            Set(ByVal value As String)
                Me.fileName = value
                Me.Text = Path.GetFileNameWithoutExtension(Me.fileName)
            End Set
        End Property

        Public ReadOnly Property HasFileName() As Boolean
            Get
                Return (Not Me.fileName Is Nothing AndAlso Me.fileName.Length > 0)
            End Get
        End Property

#End Region

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.diagram1.Model = Me.model1

        End Sub

#Region "MAIN"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New MainForm())
        End Sub

#End Region

#Region "Event Handlers"

#Region "Form Load"

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\SDLC.edd")
            Me.diagram1.View.Grid.GridStyle = GridStyle.Line
            Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.diagram1.View.Grid.Color = Color.LightGray
            Me.diagram1.View.Grid.VerticalSpacing = 15
            Me.diagram1.View.Grid.HorizontalSpacing = 15
            Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5F
            Me.diagram1.View.HandleRenderer.HandleColor = Color.BlanchedAlmond
            Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.Orange
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram1.View.SelectionList.Clear()

            For Each n As Node In diagram1.Model.Nodes
                n.EditStyle.AllowSelect = False
            Next
            diagram1.AllowDrop = False

        End Sub
#End Region

#Region "File Event Handler"
        Private Sub FileItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printToolStripMenuItem.Click, printPreviewToolStripMenuItem.Click, pageSetupToolStripMenuItem.Click, pageBordersToolStripMenuItem.Click, headerFooterToolStripMenuItem.Click
            Dim toolStripMenuItem As ToolStripMenuItem = CType(IIf(TypeOf sender Is ToolStripMenuItem, sender, Nothing), ToolStripMenuItem)
            Select Case toolStripMenuItem.Tag.ToString()
                Case "Header Footer"
                    If Not Me.diagram1 Is Nothing AndAlso Not Me.diagram1.Model Is Nothing Then
                        Dim dlgHF As HeaderFooterDialog = New HeaderFooterDialog()
                        dlgHF.Header = Me.diagram1.Model.HeaderFooterData.Header
                        dlgHF.Footer = Me.diagram1.Model.HeaderFooterData.Footer
                        dlgHF.MeasurementUnits = Me.diagram1.Model.MeasurementUnits
                        If dlgHF.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Me.diagram1.Model.HeaderFooterData.Header = dlgHF.Header
                            Me.diagram1.Model.HeaderFooterData.Footer = dlgHF.Footer
                        End If
                    End If
                Case "Page Borders"
                    If Not Me.diagram1 Is Nothing AndAlso Not Me.diagram1.View Is Nothing Then
                        Dim borderDialog As PageBorderDialog = New PageBorderDialog()
                        borderDialog.PageBorderStyle = Me.diagram1.View.PageBorderStyle
                        If borderDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Me.diagram1.View.PageBorderStyle = borderDialog.PageBorderStyle
                        End If
                    End If
                Case "Page Setup"
                    If Not Me.diagram1 Is Nothing AndAlso Not Me.diagram1.Model Is Nothing Then
                        Dim dlgPrintSetup As PageSetupDialog = New PageSetupDialog(diagram1.View)

                        ' Made to make values more user friendly 
                        dlgPrintSetup.PrintSettings = Me.diagram1.View.PageSettings
                        dlgPrintSetup.PrintZoom = Me.diagram1.View.PrintZoom

                        If dlgPrintSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Me.diagram1.View.PageSettings = dlgPrintSetup.PrintSettings
                            Me.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom
                            Me.diagram1.View.RefreshPageSettings()
                        End If
                    End If
                Case "Print Preview"
                    Me.PrintPreview()
                Case "Print"
                    Me.Print()

            End Select


        End Sub

        Public Sub PrintPreview()
            If Not Me.diagram1 Is Nothing Then
                Dim printDoc As PrintDocument = Me.diagram1.CreatePrintDocument()
                Dim printPreviewDlg As PrintPreviewDialog = New PrintPreviewDialog()

                printDoc.PrinterSettings.FromPage = 0
                printDoc.PrinterSettings.ToPage = 0
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages

                printPreviewDlg.Document = printDoc
                printPreviewDlg.ShowDialog(Me)
            End If
        End Sub

        Public Sub Print()
            If Not Me.diagram1 Is Nothing Then
                Dim printDoc As PrintDocument = Me.diagram1.CreatePrintDocument()
                Dim printDlg As PrintDialog = New PrintDialog()
                printDlg.Document = printDoc

                printDlg.AllowSomePages = True

                If printDlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    printDoc.PrinterSettings = printDlg.PrinterSettings
                    printDoc.Print()
                End If
            End If

        End Sub
#End Region

#End Region
    End Class
End Namespace
