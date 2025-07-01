Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
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
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.cbInterlacedGridXAxis = New System.Windows.Forms.CheckBox
            Me.cbInterlacedGridYAxis = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 1, 10, 1)
            Me.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(410, 66)
            Me.chartControl1.Location = New System.Drawing.Point(13, 18)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryXAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 14, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100, 100, 20)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(553, 332)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Market Shares"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image)})
            '
            'cbInterlacedGridXAxis
            '
            Me.cbInterlacedGridXAxis.AutoSize = True
            Me.cbInterlacedGridXAxis.Checked = True
            Me.cbInterlacedGridXAxis.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbInterlacedGridXAxis.Dock = System.Windows.Forms.DockStyle.Right
            Me.cbInterlacedGridXAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cbInterlacedGridXAxis.Location = New System.Drawing.Point(272, 0)
            Me.cbInterlacedGridXAxis.Name = "cbInterlacedGridXAxis"
            Me.cbInterlacedGridXAxis.Size = New System.Drawing.Size(127, 21)
            Me.cbInterlacedGridXAxis.TabIndex = 1
            Me.cbInterlacedGridXAxis.Text = "X Axis Interlaced Grid"
            Me.cbInterlacedGridXAxis.UseVisualStyleBackColor = True
            '
            'cbInterlacedGridYAxis
            '
            Me.cbInterlacedGridYAxis.AutoSize = True
            Me.cbInterlacedGridYAxis.Dock = System.Windows.Forms.DockStyle.Right
            Me.cbInterlacedGridYAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cbInterlacedGridYAxis.Location = New System.Drawing.Point(399, 0)
            Me.cbInterlacedGridYAxis.Name = "cbInterlacedGridYAxis"
            Me.cbInterlacedGridYAxis.Size = New System.Drawing.Size(127, 21)
            Me.cbInterlacedGridYAxis.TabIndex = 2
            Me.cbInterlacedGridYAxis.Text = "Y Axis Interlaced Grid"
            Me.cbInterlacedGridYAxis.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.cbInterlacedGridXAxis)
            Me.panel1.Controls.Add(Me.cbInterlacedGridYAxis)
            Me.panel1.Location = New System.Drawing.Point(12, 356)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(526, 21)
            Me.panel1.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(578, 393)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Interlaced Grid"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private WithEvents cbInterlacedGridXAxis As System.Windows.Forms.CheckBox
		Private WithEvents cbInterlacedGridYAxis As System.Windows.Forms.CheckBox
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace

