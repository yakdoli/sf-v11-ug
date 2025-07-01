Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics

Namespace DataBoundGridEvents
    ''' <summary>
    ''' Summary description for Class1.
    ''' </summary>
    Public Class MainForm
        Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private splitterControl1 As Syncfusion.Windows.Forms.SplitterControl

        Private form As Form1

        Public Sub New(ByVal form As Form1)
            Me.form = form
            Me.gridDataBoundGrid1 = form.gridDataBoundGrid1
            Me.splitterControl1 = form.splitterControl1
            InitializeForm()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Public Shared Sub Main()
            Dim form As Form1 = New Form1()
            Dim main As MainForm = New MainForm(form)
            Application.Run(form)
        End Sub

        Private Sub InitializeForm()
            form.Text = "Data Bound Grid Events Demo"

            gridDataBoundGrid1.BeginUpdate()
            gridDataBoundGrid1.TableStyle.FloatCell = True
            'gridDataBoundGrid1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;		
            'gridDataBoundGrid1.ColWidths[3] *= 2;
            gridDataBoundGrid1.EndUpdate(True)
            gridDataBoundGrid1.ForceCurrentCellMoveTo = True

        End Sub

    End Class
End Namespace





