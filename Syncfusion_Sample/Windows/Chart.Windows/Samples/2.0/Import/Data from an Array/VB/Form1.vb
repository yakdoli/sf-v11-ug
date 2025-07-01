#Region "Copyright Syncfusion Inc. 2001 - 2005"
'
'  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
Imports System.Xml
Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart

Namespace ChartImportData
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private lastTime As DateTime = DateTime.Now
        Private dataGrid1 As DataGrid
        Private chartControl1 As ChartControl
        Private panel2 As Panel
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's Constructor, Main And Dispose"
        Public Sub New()
            InitializeComponent()
            Application.EnableVisualStyles()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dataGrid1
            '
            Me.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.Color.Black
            Me.dataGrid1.LinkColor = System.Drawing.Color.Black
            Me.dataGrid1.Location = New System.Drawing.Point(19, 18)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(142, 106)
            Me.dataGrid1.TabIndex = 1
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(173, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(337, 110)
            Me.chartControl1.Location = New System.Drawing.Point(7, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.Rotation = 40.0!
            Me.chartControl1.Size = New System.Drawing.Size(481, 376)
            Me.chartControl1.TabIndex = 5
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
            Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel2.Controls.Add(Me.dataGrid1)
            Me.panel2.Location = New System.Drawing.Point(355, 300)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(181, 142)
            Me.panel2.TabIndex = 8
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(552, 449)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data from an Array"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartFromArray()
            'Updates the datagrid.
            FillDataset(Me.chartControl1.Series(0))
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartFromArray"
        ''' <summary>
        ''' Initializes chart data from array.
        ''' </summary>
        Protected Sub InitializeChartFromArray()
            'Initializes new chart series.
            Dim series As ChartSeries = New ChartSeries()
            series.Type = ChartSeriesType.Pie

            Dim names As String() = {"New York", "Houston", "Tokyo", "London", "Los Angeles"}
            Dim values As Double() = {13, 11, 17, 15, 14}

            'Turns on the text display.
            series.Style.DisplayText = True

            For i As Integer = 0 To values.Length - 1
                series.Points.Add(i, values(i))
                series.Styles(i).Text = names(i).ToString()
            Next i

            'Adds the series to the ChartSeriesCollection.
            Me.chartControl1.Series.Add(series)
            AddHandler series.PrepareStyle, AddressOf series_PrepareStyle

            Me.chartControl1.Series(0).ConfigItems.PieItem.AngleOffset = 13

            'Turns off the legend.
            Me.chartControl1.Legend.Visible = False

            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.CaptionVisible = False
            Me.dataGrid1.PreferredColumnWidth = 63
            Me.dataGrid1.PreferredRowHeight = 7
            Me.dataGrid1.HeaderBackColor = Color.FromArgb(229, 234, 241)
            Me.dataGrid1.BackColor = Color.FromArgb(239, 239, 239)
            Me.dataGrid1.BorderStyle = BorderStyle.None
            Me.dataGrid1.RowHeadersVisible = False
        End Sub
#End Region

#Region "FillDataset"
        ''' <summary>
        ''' Fills the dataset with the chart series.
        ''' </summary>
        ''' <param name="serie"></param>
        Protected Sub FillDataset(ByVal serie As ChartSeries)
            'Creates data table
            Dim dt As DataTable = New DataTable("Data Table")

            'Initializes and adds the datarow to the table.
            Dim dr As DataRow
            For i As Integer = 0 To serie.Points.Count - 1
                dr = dt.NewRow()
                dt.Rows.Add(dr)
            Next i

            'Initializes and adds the datacolumn to the table.
            Dim XValue As DataColumn = dt.Columns.Add("X Value", GetType(String))
            Dim YValue As DataColumn = dt.Columns.Add("Y Value", GetType(Integer))

            'Populate the datatable with the series points.
            For i As Integer = 0 To serie.Points.Count - 1
                dt.Rows(i)("X Value") = serie.Styles(i).Text
                dt.Rows(i)("Y Value") = serie.Points(i).YValues(0)
            Next i

            'Creates a new dataset.
            Dim arrayDataSet As DataSet = New DataSet("Data DataSet")

            'Add the populated datatable to the dataset.
            arrayDataSet.Tables.Add(dt)

            'Bind the dataset with the datagrid to display the chart data.
            Me.dataGrid1.SetDataBinding(arrayDataSet, "Data Table")

        End Sub
#End Region
#End Region

#Region "Series_PrepareStyle Event"
        Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            series.ConfigItems.PieItem.PieType = ChartPieType.OutSide
            If Not series Is Nothing Then
                Dim color1 As Color() = New Color() {Color.FromArgb(57, 120, 194), Color.FromArgb(67, 134, 216)}
                Dim color2 As Color() = New Color() {Color.FromArgb(213, 67, 63), Color.FromArgb(255, 114, 110)}
                Dim color3 As Color() = New Color() {Color.FromArgb(156, 197, 72), Color.FromArgb(168, 212, 79)}
                Dim color4 As Color() = New Color() {Color.FromArgb(130, 95, 173), Color.FromArgb(177, 139, 225)}
                Dim color5 As Color() = New Color() {Color.FromArgb(217, 117, 36), Color.FromArgb(255, 194, 102)}
                Dim color6 As Color() = New Color() {Color.FromArgb(55, 163, 193), Color.FromArgb(45, 141, 167)}
                Dim color7 As Color() = New Color() {Color.FromArgb(255, 255, 62), Color.FromArgb(255, 205, 5)}
                If args.Index = 0 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color1)
                ElseIf args.Index = 1 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color2)
                ElseIf args.Index = 2 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color3)
                ElseIf args.Index = 3 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color4)
                ElseIf args.Index = 4 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color5)
                ElseIf args.Index = 5 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color6)
                Else
                    args.Style.Interior = New BrushInfo(GradientStyle.Vertical, color7)
                End If

                args.Style.Border.Color = Color.Transparent
            End If

        End Sub
#End Region

    End Class
End Namespace