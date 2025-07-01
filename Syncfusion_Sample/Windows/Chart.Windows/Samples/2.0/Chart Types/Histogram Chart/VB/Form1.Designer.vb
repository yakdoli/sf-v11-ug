Imports Microsoft.VisualBasic
Imports System
Namespace HistogramChart
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 329)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(454, 30)
            Me.panel1.TabIndex = 1
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.checkBox1.Location = New System.Drawing.Point(389, 0)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(65, 30)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "3D view"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 0)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(92, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(303, 70)
            Me.chartControl1.Location = New System.Drawing.Point(22, 19)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.Size = New System.Drawing.Size(412, 305)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(454, 359)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Histogram Chart"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private WithEvents panel1 As System.Windows.Forms.Panel
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl

	End Class
End Namespace

