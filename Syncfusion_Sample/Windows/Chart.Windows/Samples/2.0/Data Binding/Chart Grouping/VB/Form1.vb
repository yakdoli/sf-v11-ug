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
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Grouping
Imports Syncfusion.Drawing

Namespace ChartGroupingSample
    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>
    
    Public Class Form1
        Inherits Office2007Form

#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Dim a() As Integer = New Integer(10) {}
        Dim list As ArrayList = New ArrayList()
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form Constructor, Main And Dispose"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()


        End Sub 'New
        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub 'Main


        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose
#End Region

#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label11 = New System.Windows.Forms.Label
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.label9 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.CheckBox1)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.Label1)
            Me.panel1.Controls.Add(Me.TextBox1)
            Me.panel1.Controls.Add(Me.Label2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(469, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(152, 390)
            Me.panel1.TabIndex = 0
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.Location = New System.Drawing.Point(12, 120)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(120, 1)
            Me.label11.TabIndex = 3
            '
            'CheckBox1
            '
            Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.CheckBox1.Location = New System.Drawing.Point(15, 197)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "Filter Data"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.Location = New System.Drawing.Point(10, 104)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(111, 14)
            Me.label9.TabIndex = 2
            Me.label9.Text = "Filtering Chart Data"
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(12, 134)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 23)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Filter Value"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(15, 160)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(88, 20)
            Me.TextBox1.TabIndex = 3
            Me.TextBox1.Text = "425"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(15, 230)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(117, 51)
            Me.Label2.TabIndex = 2
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 284)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(11, 14)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(444, 361)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Peak Average Network Load"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Peak Average Network Load"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(621, 390)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Grouping"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region

#Region "Helper Methods"


#Region "InitializeChartData"

        Public Sub InitializeChartData()
            Dim r As Random = New Random()

            Dim series As ChartSeries = New ChartSeries("Filter Series", ChartSeriesType.Column)
            series.Text = series.Name

            list.Clear()

            Dim i As Integer
            For i = 0 To 10 - 1 Step i + 1
                a(i) = r.Next(300, 500)
                series.Points.Add(i, a(i))
                list.Add(New Data(i, a(i)))
            Next
            Me.chartControl1.Series.Add(series)
            Me.chartControl1.Indexed = True
        End Sub

#End Region

#Region "FilterData"
        Protected Sub FilterData()
            ' Minimum requirement for Grouping Engine - DataSource should be a IList collection

            Dim group As Engine = New Engine()
            group.SetSourceList(list)

            Dim exp As ExpressionFieldDescriptor = New ExpressionFieldDescriptor()
            exp.Expression = "[Y] >" + Me.TextBox1.Text.ToString()

            Dim rfd As RecordFilterDescriptor = New RecordFilterDescriptor(exp.Expression)
            group.TableDescriptor.RecordFilters.Add(rfd)

            'System.Diagnostics.Trace.WriteLine(group.Table.FilteredRecords.Count.ToString(), "Filtered Record Count")

            'System.Diagnostics.Trace.WriteLine("Values greater than 30:")

            Me.chartControl1.Series(0).Points.Clear()
            Dim j As Integer = 0
            Dim rec As Record
            For Each rec In group.Table.FilteredRecords
                Dim b As String = rec.GetData().ToString()
                'System.Diagnostics.Trace.WriteLine(b)

                Me.chartControl1.Series(0).Points.Add(j, Convert.ToDouble(b))
                j = j + 1
            Next
            Me.Label2.Text = "Number of Filtered points: " + group.Table.FilteredRecords.Count.ToString()
        End Sub
#End Region
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Events"
        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            If (Me.CheckBox1.Checked) Then
                FilterData()
            Else
                Me.chartControl1.Series.Clear()
                InitializeChartData()
            End If
        End Sub
#End Region
    End Class 'Form1
#Region "Data"
    Public Class Data
        Dim x1 As Double
        Dim y1 As Double

        Public Sub New(ByVal X As Double, ByVal Y As Double)
            Me.x1 = X
            Me.y1 = Y
        End Sub

        Public Property X() As Double
            Get
                Return Me.x1
            End Get
            Set(ByVal Value As Double)
                Me.x1 = Value
            End Set
        End Property

        Public Property Y() As Double
            Get
                Return Me.y1
            End Get
            Set(ByVal Value As Double)
                Me.y1 = Value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return String.Format(Me.y1.ToString())
        End Function
    End Class 'Data
#End Region
End Namespace 'ChartGroupingSample