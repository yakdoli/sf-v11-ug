Imports Microsoft.VisualBasic
Imports System
Namespace ChartLocalization_2005
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl1.Legend.Location = New System.Drawing.Point(291, 75)
			Me.chartControl1.Location = New System.Drawing.Point(52, 46)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryXAxis.Margin = True
			Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryYAxis.Margin = True
			Me.chartControl1.ShowContextMenu = True
			Me.chartControl1.ShowToolbar = True
			Me.chartControl1.Size = New System.Drawing.Size(400, 300)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "chartControl1"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Default"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			Me.chartControl1.ToolBar.Visible = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(470, 125)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(73, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Select Culture"
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "en-US", "de-DE", "fr-FR"})
			Me.comboBox1.Location = New System.Drawing.Point(566, 116)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 2
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(732, 406)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.chartControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chart Localization"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace

