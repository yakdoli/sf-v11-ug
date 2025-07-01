Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports System.IO

Namespace ChartTemplate_2005
    Partial Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
        Private color1 As Color() = New Color() {Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231)}
        Private color2 As Color() = New Color() {Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206)}
        Private frm As Form2 = New Form2()
        Private filePath As String
        Private defaultPath As String
#Region "Constructor"
        Public Sub New()
            InitializeComponent()

            Me.propertyGrid1.SelectedObject = Me.chartControl1
            Me.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(213, 228, 242)
            Me.propertyGrid1.LineColor = System.Drawing.Color.FromArgb(213, 228, 242)
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(213, 228, 242)
            Me.ActiveControl = Me.buttonAdv1
            Me.buttonAdv1.State = ButtonAdvState.Pressed
            AddHandler frm.buttonAdv1.Click, AddressOf buttonAdv1_Click
            AddHandler frm.buttonAdv2.Click, AddressOf buttonAdv2_Click

            'Copies the required template files to the Debug folder from Template folder
            Dim di As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            di = di.Parent.Parent
            filePath = di.FullName & "\..\Templates"

            defaultPath = Application.StartupPath.ToString()
            Dim dir As DirectoryInfo = New DirectoryInfo(filePath)
            Dim files As FileInfo() = dir.GetFiles("*.*")
            For Each file As FileInfo In files
                Dim ch As Char() = New Char() {"D"c, "e"c, "b"c, "u"c, "g"c}
                Dim newFile As String = file.Name.TrimStart(ch)
                defaultPath = Application.StartupPath.ToString() & "\" & newFile
                file.CopyTo(defaultPath, True)
            Next file
            InitializeChart()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.chartControl1.LegendsPlacement = ChartPlacement.Outside
            Me.chartControl1.LegendAlignment = ChartAlignment.Center
        End Sub
#End Region

#Region "InitializeChartData"
        Public Sub InitializeChart()
            ' Initialize ChartSeries
            Dim series1 As ChartSeries = New ChartSeries("Hard Derive")

            series1.Points.Add(1, 187)
            series1.Points.Add(2, 151)
            series1.Points.Add(3, 180)
            series1.Points.Add(4, 206)
            series1.Points.Add(5, 122)
            series1.Points.Add(6, 31)
            series1.Points.Add(7, 189)
            series1.Points.Add(8, 54)
            series1.Points.Add(9, 181)
            series1.Points.Add(10, 201)
            series1.Points.Add(11, 381)
            series1.Points.Add(12, 301)
            series1.Styles(0).Text = String.Format("{0}", series1.Points(0).YValues(0))
            series1.Styles(1).Text = String.Format("{0}", series1.Points(1).YValues(0))
            series1.Styles(2).Text = String.Format("{0}", series1.Points(2).YValues(0))
            series1.Styles(3).Text = String.Format("{0}", series1.Points(3).YValues(0))
            series1.Styles(4).Text = String.Format("{0}", series1.Points(4).YValues(0))

            series1.Style.TextColor = Color.Black
            Me.chartControl1.Series.Add(series1)
            Dim series2 As ChartSeries = New ChartSeries("Monitor")
            series2.Points.Add(1, 256)
            series2.Points.Add(2, 451)
            series2.Points.Add(3, 382)
            series2.Points.Add(4, 437)
            series2.Points.Add(5, 321)
            series2.Points.Add(6, 234)
            series2.Points.Add(7, 425)
            series2.Points.Add(8, 257)
            series2.Points.Add(9, 382)
            series2.Points.Add(10, 301)
            series2.Points.Add(11, 472)
            series2.Points.Add(12, 401)
            series2.Styles(0).Text = String.Format("{0}", series1.Points(0).YValues(0))
            series2.Styles(1).Text = String.Format("{0}", series1.Points(1).YValues(0))
            series2.Styles(2).Text = String.Format("{0}", series1.Points(2).YValues(0))
            series2.Styles(3).Text = String.Format("{0}", series1.Points(3).YValues(0))
            series2.Styles(4).Text = String.Format("{0}", series1.Points(4).YValues(0))
            series2.Style.TextColor = Color.Black

            Me.chartControl1.Series.Add(series2)
            chartControl1.Series(0).Style.Border.Color = Color.Gray
            chartControl1.Series(1).Style.Border.Color = Color.Gray
            Dim ct As ChartTemplate = New ChartTemplate(GetType(ChartControl))
            chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 13, 1)
            ct.Load("Column_Square.xml")
            chartControl1.Series3D = False
            ct.Apply(Me.chartControl1)
            Me.chartControl1.Legends(0).BackColor = Color.Transparent
        End Sub
#End Region

#Region "Save Template"
        Private templateCount As Integer = 0
        Private saveTemplateFile As String = ""
        Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Saves file to the same template
            If frm.radioButton1.Checked Then
                ChartTemplate.Save(Me.chartControl1, currentTemplate)
            End If
            'Saves file to a new template
            If frm.radioButton2.Checked Then
                If templateCount < 2 Then
                    If templateCount = 0 Then
                        Me.buttonAdv7.Visible = True
                    End If
                    If templateCount = 1 Then
                        Me.buttonAdv10.Visible = True
                    End If
                    templateCount = templateCount + 1
                    saveTemplateFile = "Template" & templateCount.ToString() & ".xml"
                    ChartTemplate.Save(Me.chartControl1, saveTemplateFile)
                Else
                    MessageBox.Show("Programmed to add only two user defined templates")
                End If
            End If
            frm.Hide()

        End Sub
        Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs)
            frm.Hide()
        End Sub

        Private Sub SaveTemplate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Savebutton.Click

            frm.Show()

        End Sub
#End Region

#Region "ContextMenu - Copy To clipboard"
        Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
            Dim cc As String = ""
            Select Case Me.contextMenuStrip1.SourceControl.Name
                Case "buttonAdv1"
                    cc = Application.StartupPath.ToString() & "\Column_Cylinder.xml"
                Case "buttonAdv2"
                    cc = Application.StartupPath.ToString() & "\Column_Square.xml"
                Case "buttonAdv3"
                    cc = Application.StartupPath.ToString() & "\Area.xml"
                Case "buttonAdv4"
                    cc = Application.StartupPath.ToString() & "\Area_3D.xml"
                Case "buttonAdv5"
                    cc = Application.StartupPath.ToString() & "\Line.xml"
                Case "buttonAdv6"
                    cc = Application.StartupPath.ToString() & "\Line_3D.xml"
                Case "buttonAdv7"
                    cc = Application.StartupPath.ToString() & "\Template1.xml"
                Case "buttonAdv10"
                    cc = Application.StartupPath.ToString() & "\Template2.xml"
            End Select
            Clipboard.SetDataObject(cc, True)
        End Sub
#End Region

#Region "Load template"
        Private currentTemplate As String = "Column_Square.xml"
        Private Sub ChartType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv7.Click, buttonAdv6.Click, buttonAdv5.Click, buttonAdv4.Click, buttonAdv3.Click, buttonAdv2.Click, buttonAdv10.Click, buttonAdv1.Click
            Dim chartButton As ButtonAdv = TryCast(sender, ButtonAdv)
            Dim filePath As String = Application.StartupPath.ToString()
            For Each buttonAdv As ButtonAdv In Me.panel1.Controls
                buttonAdv.State = ButtonAdvState.Default
                buttonAdv.Refresh()
            Next buttonAdv
            If chartButton Is Me.buttonAdv1 Then

                color2 = New Color() {Color.FromArgb(255, 158, 49), Color.FromArgb(255, 158, 49), Color.FromArgb(255, 158, 49)}
                color1 = New Color() {Color.FromArgb(255, 199, 165), Color.FromArgb(255, 199, 165), Color.FromArgb(255, 199, 165)}
                Me.toolStripStatusLabel1.Text = filePath & "\Column_Cylinder.xml"
                currentTemplate = "Column_Cylinder.xml"
                Me.buttonAdv1.State = ButtonAdvState.Pressed
            End If
            If chartButton Is Me.buttonAdv2 Then
                color1 = New Color() {Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231)}
                color2 = New Color() {Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206)}
                Me.toolStripStatusLabel1.Text = filePath & "\Column_Square.xml"
                Me.buttonAdv2.State = ButtonAdvState.Pressed
                currentTemplate = "Column_Square.xml"
            End If
            If chartButton Is Me.buttonAdv3 Then
                color1 = New Color() {Color.FromArgb(189, 178, 206), Color.FromArgb(189, 178, 206), Color.FromArgb(189, 178, 206)}
                color2 = New Color() {Color.FromArgb(132, 101, 173), Color.FromArgb(132, 101, 173), Color.FromArgb(132, 101, 173)}
                Me.toolStripStatusLabel1.Text = filePath & "\Area.xml"
                Me.buttonAdv3.State = ButtonAdvState.Pressed
                currentTemplate = "Area.xml"
            End If
            If chartButton Is Me.buttonAdv4 Then
                color1 = New Color() {Color.FromArgb(198, 195, 198), Color.FromArgb(198, 195, 198), Color.FromArgb(198, 195, 198)}
                color2 = New Color() {Color.FromArgb(140, 142, 140), Color.FromArgb(140, 142, 140), Color.FromArgb(140, 142, 140)}
                Me.toolStripStatusLabel1.Text = filePath & "\Area_3D.xml"
                Me.buttonAdv4.State = ButtonAdvState.Pressed
                currentTemplate = "Area_3D.xml"
            End If
            If chartButton Is Me.buttonAdv5 Then
                color1 = New Color() {Color.FromArgb(156, 186, 82), Color.FromArgb(156, 186, 82), Color.FromArgb(156, 186, 82)}
                color2 = New Color() {Color.FromArgb(132, 154, 74), Color.FromArgb(132, 154, 74), Color.FromArgb(132, 154, 74)}
                Me.toolStripStatusLabel1.Text = filePath & "\Line.xml"
                Me.buttonAdv5.State = ButtonAdvState.Pressed
                currentTemplate = "Line.xml"
            End If
            If chartButton Is Me.buttonAdv6 Then
                color1 = New Color() {Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194)}
                color2 = New Color() {Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90)}
                Me.toolStripStatusLabel1.Text = filePath & "\Line_3D.xml"
                Me.buttonAdv6.State = ButtonAdvState.Pressed
                currentTemplate = "Line_3D.xml"
            End If
            If chartButton Is Me.buttonAdv7 Then
                color1 = New Color() {Color.White, Color.WhiteSmoke, Color.White}
                color2 = New Color() {Color.Black, Color.Gray, Color.Black}
                Me.toolStripStatusLabel1.Text = filePath & "\Template1.xml"
                Me.buttonAdv7.State = ButtonAdvState.Pressed
                currentTemplate = "Template1.xml"
            End If
            If chartButton Is Me.buttonAdv10 Then
                Me.toolStripStatusLabel1.Text = filePath & "\Template2.xml"
                Me.buttonAdv10.State = ButtonAdvState.Pressed
                currentTemplate = "Template2.xml"
            End If

            ChartTemplate.Load(Me.chartControl1, currentTemplate)


            Me.chartControl1.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color1)
            Me.chartControl1.Series(1).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color2)
            Me.propertyGrid1.Refresh()

        End Sub
#End Region


    End Class
End Namespace