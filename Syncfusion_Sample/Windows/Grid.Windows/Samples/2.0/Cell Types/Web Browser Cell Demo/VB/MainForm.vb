Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics

Namespace GridSample
	''' <summary>
	''' Summary description for MainForm.
	''' </summary>
	Public Class MainForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private splitterControl1 As Syncfusion.Windows.Forms.SplitterControl
		Private dataSet11 As DataSet1
		Private form As Form1
		Private axWebBrowser1 As AxSHDocVw.AxWebBrowser

		Public Sub New(ByVal form As Form1)
			Me.form = form
			Me.gridControl1 = form.gridControl1
			Me.splitterControl1 = form.splitterControl1
			Me.dataSet11 = form.dataSet11
			InitializeForm()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Dim form As New Form1()
            Dim main As New MainForm(form)
            Application.Run(form)
        End Sub

		Private Sub axWebBrowser1_NavigateComplete2(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event)
			Me.splitterControl1.ActivePane.Invalidate()
		End Sub

		Private Sub axWebBrowser1_ProgressChange(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent)
			Me.splitterControl1.ActivePane.Invalidate()
		End Sub

		Private Sub InitializeForm()
			' Form
			form.Text = "Web Browser Cell Demo"

			' disable splitting grid view - with this type of cell renderer,
			' only a single view is supported. 
			splitterControl1.SplitBars = DynamicSplitBars.None

			' Web Browser
			Me.axWebBrowser1 = New AxSHDocVw.AxWebBrowser()
			Me.axWebBrowser1.BeginInit()

			' 
			' axWebBrowser1
			' 
			Me.axWebBrowser1.Enabled = True
			Me.axWebBrowser1.Location = New System.Drawing.Point(72, 16)
			Me.axWebBrowser1.Size = New System.Drawing.Size(300, 150)
			Me.axWebBrowser1.TabIndex = 4
			Me.axWebBrowser1.CausesValidation = False

			form.Controls.Add(Me.axWebBrowser1)

			Me.axWebBrowser1.EndInit()

			'this.axWebBrowser1.Visible = false;//.Location = new System.Drawing.Point(10000,10000);

			Dim url As Object = "http://www.syncfusion.com"
			Dim flags As Object = Nothing
			Dim tfn As Object = Nothing
			Dim pd As Object = Nothing
			Dim head As Object = Nothing
			Me.axWebBrowser1.Navigate2(url, flags, tfn, pd, head)
			AddHandler axWebBrowser1.NavigateComplete2, AddressOf axWebBrowser1_NavigateComplete2
			AddHandler axWebBrowser1.ProgressChange, AddressOf axWebBrowser1_ProgressChange

			' Grid
			gridControl1.BeginUpdate()
			gridControl1.AllowSelection = GridSelectionFlags.None
			'gridControl1.CausesValidation = false;

			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(6, 2, 22, 10))
			Me.gridControl1(6,2).CellType = "Control"
			Me.gridControl1(6,2).Control = Me.axWebBrowser1

			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(4,2,5,6))
			Me.gridControl1(4,2).Text = "Host Internet Explorer as CellType"
			Me.gridControl1(4,2).Font.Facename = "Arial"
			Me.gridControl1(4,2).Font.Bold = True
			Me.gridControl1(4,2).TextColor = Color.FromArgb(255, 153, 51)
			Me.gridControl1(4,2).Font.Size = 14
			Me.gridControl1(4,2).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1.EndUpdate(True)
		End Sub
	End Class
End Namespace
