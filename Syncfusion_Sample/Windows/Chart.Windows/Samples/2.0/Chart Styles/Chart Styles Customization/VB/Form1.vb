Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartStyles
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private label1 As System.Windows.Forms.Label
        Private WithEvents chkSeries1 As System.Windows.Forms.CheckBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents enumEditComboBoxTextOrientation As Syncfusion.Windows.Forms.Chart.EnumEditComboBox
        Private WithEvents chkSeries2 As System.Windows.Forms.CheckBox
        Private imageList1 As System.Windows.Forms.ImageList
        Private WithEvents cmbSymbolStyle As System.Windows.Forms.ComboBox
        Private WithEvents rbSymbolSeries1 As System.Windows.Forms.RadioButton
        Private WithEvents rbSymbolSeries2 As System.Windows.Forms.RadioButton
        Private label9 As Label
        Private label3 As Label
        Private label4 As Label
        Private label5 As Label
        Private WithEvents chkItalics As System.Windows.Forms.CheckBox
        Private WithEvents btnSymbol As System.Windows.Forms.Button
        Dim flag As Boolean = False
        Private WithEvents series1 As ChartSeries
        Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown

        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.tabControl1 = New System.Windows.Forms.TabControl
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.btnSymbol = New System.Windows.Forms.Button
            Me.label4 = New System.Windows.Forms.Label
            Me.cmbSymbolStyle = New System.Windows.Forms.ComboBox
            Me.rbSymbolSeries2 = New System.Windows.Forms.RadioButton
            Me.label9 = New System.Windows.Forms.Label
            Me.rbSymbolSeries1 = New System.Windows.Forms.RadioButton
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.chkItalics = New System.Windows.Forms.CheckBox
            Me.label5 = New System.Windows.Forms.Label
            Me.chkSeries2 = New System.Windows.Forms.CheckBox
            Me.enumEditComboBoxTextOrientation = New Syncfusion.Windows.Forms.Chart.EnumEditComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.chkSeries1 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 329)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(13, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(456, 382)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.NumericUpDown1)
            Me.panel1.Controls.Add(Me.NumericUpDown2)
            Me.panel1.Controls.Add(Me.Label10)
            Me.panel1.Controls.Add(Me.Label8)
            Me.panel1.Controls.Add(Me.Label6)
            Me.panel1.Controls.Add(Me.Label7)
            Me.panel1.Controls.Add(Me.tabControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(475, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(198, 406)
            Me.panel1.TabIndex = 1
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(141, 34)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(42, 20)
            Me.NumericUpDown1.TabIndex = 20
            '
            'NumericUpDown2
            '
            Me.NumericUpDown2.Location = New System.Drawing.Point(142, 61)
            Me.NumericUpDown2.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
            Me.NumericUpDown2.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.NumericUpDown2.Name = "NumericUpDown2"
            Me.NumericUpDown2.Size = New System.Drawing.Size(41, 20)
            Me.NumericUpDown2.TabIndex = 19
            Me.NumericUpDown2.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(12, 63)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(122, 13)
            Me.Label10.TabIndex = 17
            Me.Label10.Text = "Spacing between Series"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(12, 37)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(122, 13)
            Me.Label8.TabIndex = 16
            Me.Label8.Text = "Spacing between Points"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(13, 29)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(170, 1)
            Me.Label6.TabIndex = 15
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label7.Location = New System.Drawing.Point(9, 9)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(50, 14)
            Me.Label7.TabIndex = 14
            Me.Label7.Text = "Spacing"
            '
            'tabControl1
            '
            Me.tabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Location = New System.Drawing.Point(12, 101)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(173, 281)
            Me.tabControl1.TabIndex = 0
            '
            'tabPage2
            '
            Me.tabPage2.BackColor = System.Drawing.Color.White
            Me.tabPage2.Controls.Add(Me.btnSymbol)
            Me.tabPage2.Controls.Add(Me.label4)
            Me.tabPage2.Controls.Add(Me.cmbSymbolStyle)
            Me.tabPage2.Controls.Add(Me.rbSymbolSeries2)
            Me.tabPage2.Controls.Add(Me.label9)
            Me.tabPage2.Controls.Add(Me.rbSymbolSeries1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Size = New System.Drawing.Size(165, 255)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "SymbolStyle"
            '
            'btnSymbol
            '
            Me.btnSymbol.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSymbol.ForeColor = System.Drawing.Color.MidnightBlue
            Me.btnSymbol.Location = New System.Drawing.Point(14, 193)
            Me.btnSymbol.Name = "btnSymbol"
            Me.btnSymbol.Size = New System.Drawing.Size(112, 24)
            Me.btnSymbol.TabIndex = 23
            Me.btnSymbol.Text = "Change Symbol"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(15, 54)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(130, 1)
            Me.label4.TabIndex = 13
            '
            'cmbSymbolStyle
            '
            Me.cmbSymbolStyle.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cmbSymbolStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSymbolStyle.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cmbSymbolStyle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cmbSymbolStyle.Location = New System.Drawing.Point(14, 146)
            Me.cmbSymbolStyle.Name = "cmbSymbolStyle"
            Me.cmbSymbolStyle.Size = New System.Drawing.Size(112, 21)
            Me.cmbSymbolStyle.TabIndex = 12
            '
            'rbSymbolSeries2
            '
            Me.rbSymbolSeries2.Location = New System.Drawing.Point(14, 101)
            Me.rbSymbolSeries2.Name = "rbSymbolSeries2"
            Me.rbSymbolSeries2.Size = New System.Drawing.Size(104, 24)
            Me.rbSymbolSeries2.TabIndex = 1
            Me.rbSymbolSeries2.Text = "Series 2"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Location = New System.Drawing.Point(11, 34)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(48, 14)
            Me.label9.TabIndex = 2
            Me.label9.Text = "Symbol"
            '
            'rbSymbolSeries1
            '
            Me.rbSymbolSeries1.Location = New System.Drawing.Point(16, 71)
            Me.rbSymbolSeries1.Name = "rbSymbolSeries1"
            Me.rbSymbolSeries1.Size = New System.Drawing.Size(104, 24)
            Me.rbSymbolSeries1.TabIndex = 0
            Me.rbSymbolSeries1.Text = "Series 1"
            '
            'tabPage1
            '
            Me.tabPage1.BackColor = System.Drawing.Color.White
            Me.tabPage1.Controls.Add(Me.chkItalics)
            Me.tabPage1.Controls.Add(Me.label5)
            Me.tabPage1.Controls.Add(Me.chkSeries2)
            Me.tabPage1.Controls.Add(Me.enumEditComboBoxTextOrientation)
            Me.tabPage1.Controls.Add(Me.label3)
            Me.tabPage1.Controls.Add(Me.chkSeries1)
            Me.tabPage1.Controls.Add(Me.label2)
            Me.tabPage1.Controls.Add(Me.label1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Size = New System.Drawing.Size(165, 255)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "PointTextStyle"
            '
            'chkItalics
            '
            Me.chkItalics.AutoSize = True
            Me.chkItalics.ForeColor = System.Drawing.Color.Black
            Me.chkItalics.Location = New System.Drawing.Point(20, 218)
            Me.chkItalics.Name = "chkItalics"
            Me.chkItalics.Size = New System.Drawing.Size(75, 17)
            Me.chkItalics.TabIndex = 8
            Me.chkItalics.Text = "Use Italics"
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.Location = New System.Drawing.Point(13, 53)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(140, 1)
            Me.label5.TabIndex = 6
            '
            'chkSeries2
            '
            Me.chkSeries2.ForeColor = System.Drawing.Color.Black
            Me.chkSeries2.Location = New System.Drawing.Point(19, 118)
            Me.chkSeries2.Name = "chkSeries2"
            Me.chkSeries2.Size = New System.Drawing.Size(72, 24)
            Me.chkSeries2.TabIndex = 12
            Me.chkSeries2.Text = "Series 2"
            '
            'enumEditComboBoxTextOrientation
            '
            Me.enumEditComboBoxTextOrientation.Cursor = System.Windows.Forms.Cursors.Hand
            Me.enumEditComboBoxTextOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.enumEditComboBoxTextOrientation.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.enumEditComboBoxTextOrientation.ForeColor = System.Drawing.Color.MidnightBlue
            Me.enumEditComboBoxTextOrientation.Location = New System.Drawing.Point(18, 182)
            Me.enumEditComboBoxTextOrientation.Name = "enumEditComboBoxTextOrientation"
            Me.enumEditComboBoxTextOrientation.Size = New System.Drawing.Size(96, 21)
            Me.enumEditComboBoxTextOrientation.TabIndex = 3
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(12, 36)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(92, 14)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Point Text Style"
            '
            'chkSeries1
            '
            Me.chkSeries1.ForeColor = System.Drawing.Color.Black
            Me.chkSeries1.Location = New System.Drawing.Point(20, 88)
            Me.chkSeries1.Name = "chkSeries1"
            Me.chkSeries1.Size = New System.Drawing.Size(72, 24)
            Me.chkSeries1.TabIndex = 10
            Me.chkSeries1.Text = "Series 1"
            '
            'label2
            '
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(16, 155)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(100, 23)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Text Orientation"
            '
            'label1
            '
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(16, 64)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(56, 23)
            Me.label1.TabIndex = 0
            Me.label1.Text = "ShowText"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(673, 406)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Styles Customization"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
        Protected Sub InitializeChartData()

            Me.chartControl1.Indexed = True
            series1 = New ChartSeries(" Volvo", ChartSeriesType.Column)
            series1.Text = series1.Name

            series1.Points.Add(2001, 451)
            series1.Points.Add(2002, 437)
            series1.Points.Add(2003, 234)
            series1.Style.Images = New ChartImageCollection(Me.imageList1.Images)

            Dim series2 As ChartSeries = New ChartSeries(" Saab", ChartSeriesType.Column)
            series2.Text = series2.Name

            series2.Points.Add(2001, 491)
            series2.Points.Add(2002, 366)
            series2.Points.Add(2003, 361)

            series2.Style.Images = New ChartImageCollection(Me.imageList1.Images)
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)
            Me.chartControl1.Series(0).Style.DisplayText = Me.chkSeries1.Checked
            Me.chartControl1.Series(1).Style.DisplayText = Me.chkSeries2.Checked
            series1.Style.TextFormat = "{0:C}"
            series2.Style.TextFormat = "{0:C}"

        End Sub

        Protected Sub FillControlPanel()
            For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.cmbSymbolStyle.Items.Add(symbol)
            Next symbol
            Me.cmbSymbolStyle.SelectedIndex = 8
        End Sub

        Protected Sub ChangeSymbol()
            If Me.rbSymbolSeries1.Checked Then
                If Me.cmbSymbolStyle.SelectedItem.ToString() = "Image" Then
                    Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                    Me.chartControl1.Series(0).Style.Symbol.Color = Color.Red
                    Me.chartControl1.Series(0).Style.Symbol.ImageIndex = 0
                Else
                    Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                End If
                Me.chartControl1.Series(0).Style.Symbol.Color = Color.Red
            Else
                If Me.cmbSymbolStyle.SelectedItem.ToString() = "Image" Then
                    Me.chartControl1.Series(1).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                    Me.chartControl1.Series(1).Style.Symbol.ImageIndex = 0
                    Me.chartControl1.Series(1).Style.Symbol.Color = Color.Red

                Else
                    Me.chartControl1.Series(1).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                End If
                Me.chartControl1.Series(1).Style.Symbol.Color = Color.Red
            End If
        End Sub

        Protected Sub ResetSymbol()
            If Me.rbSymbolSeries1.Checked Then
                Me.chartControl1.Series(0).Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
                Me.chartControl1.Series(0).Style.Symbol.Color = Color.Red
            ElseIf Me.rbSymbolSeries2.Checked Then
                Me.chartControl1.Series(1).Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
                Me.chartControl1.Series(1).Style.Symbol.Color = Color.Red
            End If
        End Sub


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.enumEditComboBoxTextOrientation.EnumType = GetType(ChartTextOrientation)
            InitializeChartData()
            FillControlPanel()
            flag = True
            Me.rbSymbolSeries1.Checked = True
            Me.enumEditComboBoxTextOrientation.SelectedIndex = 9
            Me.chkSeries2.Checked = True
            Me.chkSeries1.Checked = True
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub

        Private Sub enumEditComboBoxTextOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles enumEditComboBoxTextOrientation.SelectedIndexChanged
            If (flag) Then


                Me.chartControl1.Series(1).Style.TextOrientation = CType(enumEditComboBoxTextOrientation.SelectedEnumValue, ChartTextOrientation)
                Me.chartControl1.Series(0).Style.TextOrientation = CType(enumEditComboBoxTextOrientation.SelectedEnumValue, ChartTextOrientation)
                Me.chartControl1.Redraw(True)
            End If
        End Sub

        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs) Handles series1.PrepareStyle
            ' Style formatting using a callback. You can apply the same settings directly on the series style on the
            ' point styles.
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            Dim rand As Random = New Random()
            If Not series Is Nothing Then
                args.Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                args.Style.Symbol.Size = New Size(7, 7)
                If args.Index Mod 2 = 0 Then
                    args.Style.Symbol.Color = Color.Red
                Else
                    args.Style.Symbol.Color = Color.White
                End If
            End If
        End Sub

        Private Sub Symbol_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSymbol.Click
            ChangeSymbol()
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSymbolSeries2.CheckedChanged, rbSymbolSeries1.CheckedChanged
            ChangeSymbol()
            Me.chartControl1.Redraw(True)
        End Sub


        Private Sub checkBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItalics.CheckedChanged
            If chkItalics.Checked Then
                Me.chartControl1.Series(0).Style.Font.FontStyle = FontStyle.Italic
                Me.chartControl1.Series(1).Style.Font.FontStyle = FontStyle.Italic
            Else
                Me.chartControl1.Series(0).Style.Font.FontStyle = FontStyle.Regular
                Me.chartControl1.Series(1).Style.Font.FontStyle = FontStyle.Regular
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub Showtext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeries2.CheckedChanged, chkSeries1.CheckedChanged
            Me.chartControl1.Series(0).Style.DisplayText = Me.chkSeries1.Checked
            Me.chartControl1.Series(1).Style.DisplayText = Me.chkSeries2.Checked
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
            Me.chartControl1.SpacingBetweenPoints = Convert.ToSingle(Me.NumericUpDown1.Value)
        End Sub

        Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
            Me.chartControl1.Spacing = Convert.ToSingle(Me.NumericUpDown2.Value)
        End Sub

        Private Sub NumericUpDown1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
    End Class
End Namespace
