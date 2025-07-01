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


Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class FormMain
		Inherits Syncfusion.Windows.Forms.Office2007Form
		Private components As IContainer
		#Region "Private Members"

		Private panel1 As System.Windows.Forms.Panel
		Private cursor1 As ChartInteractiveCursor
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
        Private label2 As Label
        Private label3 As Label
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private chartControl1 As ChartControl
#End Region

#Region "Constructor, Main and Dispose"
        Public Sub New()
            InitializeComponent()

        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New FormMain())
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
            Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
            Dim StringFormat2 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.CursorLocation = New System.Drawing.Point(0, 0)
            Me.chartControl1.ChartArea.CursorReDraw = False
            Me.chartControl1.IsWindowLess = False
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(389, 75)
            Me.chartControl1.Localize = Nothing
            Me.chartControl1.Location = New System.Drawing.Point(9, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
            StringFormat1.Alignment = System.Drawing.StringAlignment.Near
            StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
            StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
            StringFormat1.Trimming = System.Drawing.StringTrimming.Character
            Me.chartControl1.PrimaryXAxis.LabelStringFormat = StringFormat1
            Me.chartControl1.PrimaryXAxis.Margin = True
            Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
            StringFormat2.Alignment = System.Drawing.StringAlignment.Far
            StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
            StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
            StringFormat2.Trimming = System.Drawing.StringTrimming.Character
            Me.chartControl1.PrimaryYAxis.LabelStringFormat = StringFormat2
            Me.chartControl1.PrimaryYAxis.Margin = True
            Me.chartControl1.Size = New System.Drawing.Size(498, 345)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5R
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.colorPickerButton1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 381)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(604, 69)
            Me.panel1.TabIndex = 2
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"100", "150", "200"})
            Me.comboBox2.Location = New System.Drawing.Point(228, 41)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(121, 21)
            Me.comboBox2.TabIndex = 20
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(161, 41)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(49, 13)
            Me.label4.TabIndex = 19
            Me.label4.Text = "YInterval"
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"2", "4", "6"})
            Me.comboBox1.Location = New System.Drawing.Point(228, 4)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 18
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(161, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(49, 13)
            Me.label1.TabIndex = 17
            Me.label1.Text = "XInterval"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(12, 8)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(116, 17)
            Me.checkBox1.TabIndex = 16
            Me.checkBox1.Text = "MoveTo ChartArea"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(407, 7)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(71, 16)
            Me.label2.TabIndex = 10
            Me.label2.Text = "Cursor Color"
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton1.Location = New System.Drawing.Point(484, 1)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton1.Size = New System.Drawing.Size(24, 24)
            Me.colorPickerButton1.TabIndex = 2
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.White
            Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.Location = New System.Drawing.Point(57, 360)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(430, 14)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Click on the interactive cursor line and drag to chart area or series points"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(604, 450)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Interactive Cursor"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeChartData()
            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 0

            Me.label1.Enabled = True
            Me.label4.Enabled = True
            Me.comboBox1.Enabled = True
            Me.comboBox2.Enabled = True
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Server 1"
            series1.Type = ChartSeriesType.Line
            series1.Text = series1.Name
            Dim r1 As Integer() = New Integer() {256, 491, 382, 437, 321, 234, 425, 257, 382, 296, 437, 451, 490, 366, 422, 361, 185, 384, 461, 258}
            For i As Integer = 2 To 19 Step 2
                series1.Points.Add(i, r1(i))
            Next i

            AddHandler series1.PrepareStyle, AddressOf ChartControlSeries_PrepareStyle

            Me.chartControl1.Series.Add(series1)
            cursor1 = New ChartInteractiveCursor(Me.chartControl1.Series(0))
            Me.chartControl1.ChartArea.InteractiveCursors.Add(cursor1)
            cursor1.Color = Color.Black
            Me.chartControl1.ShowLegend = False
            Me.chartControl1.ChartArea.InteractiveCursors(0).XPosition = 2
            Me.chartControl1.ChartArea.InteractiveCursors(0).YPosition = 5
            Me.chartControl1.ChartArea.InteractiveCursors(0).MoveToChartArea = Me.checkBox1.Checked
            If Me.chartControl1.ChartArea.InteractiveCursors(0).MoveToChartArea Then
                Me.chartControl1.ChartArea.InteractiveCursors(0).XInterval = 2
                Me.chartControl1.ChartArea.InteractiveCursors(0).YInterval = 50
            End If
        End Sub
#End Region
#End Region

#Region "Events"
#Region "PrepareStyle"
        ''' <summary>
        ''' Handler for the PrepareStyle event of ChartSeries. 
        ''' </summary>
        ''' <param name="sender">The ChartSeries object that raises this event.</param>
        ''' <param name="args">The event data. Can be modified to change series appearance.</param>
        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            ' Style formatting using a callback. You can apply the same settings directly on the series style on the
            ' point styles.
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If Not series Is Nothing Then
                args.Style.DisplayText = True
                args.Style.TextFormat = "{0}"
                args.Style.TextOrientation = ChartTextOrientation.Up
                args.Style.Symbol.Shape = ChartSymbolShape.Circle
                args.Style.Symbol.Size = New Size(10, 10)
                args.Style.Symbol.Color = Color.White
                args.Style.Symbol.Border.Color = Color.FromArgb(129, 115, 27)
                args.Style.Symbol.Border.Width = 2
            End If
        End Sub
#End Region


        Private Sub Color_selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected
            cursor1.Color = Me.colorPickerButton1.SelectedColor

            Me.chartControl1.Redraw(True)
        End Sub

       
#End Region

        Private Sub checkBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkBox1.CheckedChanged
            If Me.checkBox1.Checked AndAlso Me.chartControl1.ChartArea.InteractiveCursors.Count > 0 Then
                Me.chartControl1.ChartArea.InteractiveCursors(0).MoveToChartArea = Me.checkBox1.Checked
                Me.label1.Enabled = True
                Me.label4.Enabled = True
                Me.comboBox1.Enabled = True
                Me.comboBox2.Enabled = True
            Else
                If Me.chartControl1.ChartArea.InteractiveCursors.Count > 0 Then
                    Me.chartControl1.ChartArea.InteractiveCursors(0).MoveToChartArea = Me.checkBox1.Checked
                End If
                Me.label1.Enabled = False
                Me.label4.Enabled = False
                Me.comboBox1.Enabled = False
                Me.comboBox2.Enabled = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.ChartArea.InteractiveCursors(0).XInterval = Convert.ToDouble(Me.comboBox1.SelectedItem)
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            Me.chartControl1.ChartArea.InteractiveCursors(0).YInterval = Convert.ToDouble(Me.comboBox2.SelectedItem)
        End Sub
    End Class
End Namespace