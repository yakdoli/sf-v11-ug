Imports Microsoft.VisualBasic
Imports System
Namespace ChartAxisLabelTooltip_2005
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl1.Legend.Location = New System.Drawing.Point(291, 75)
			 
			Me.chartControl1.Localize = Nothing
			Me.chartControl1.Location = New System.Drawing.Point(83, 34)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryXAxis.Margin = True
			Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryYAxis.Margin = True
			Me.chartControl1.Size = New System.Drawing.Size(400, 300)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "chartControl1"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Default"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Location = New System.Drawing.Point(546, 100)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(89, 17)
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "ShowToolTip"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(768, 388)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.chartControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ChartAxisLabel ToolTip"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
	End Class
End Namespace

