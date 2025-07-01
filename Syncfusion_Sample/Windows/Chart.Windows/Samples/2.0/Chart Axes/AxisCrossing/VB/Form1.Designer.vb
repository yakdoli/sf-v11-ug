Imports Microsoft.VisualBasic
Imports System
Namespace Crossing_Demo_2008
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
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(57, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "X Crossing"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(12, 58)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(57, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Y Crossing"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(87, 110)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(69, 17)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "Series3D"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Location = New System.Drawing.Point(527, 113)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(221, 206)
            Me.panel1.TabIndex = 8
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(87, 147)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(67, 17)
            Me.checkBox2.TabIndex = 10
            Me.checkBox2.Text = "Zooming"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"Min", "2", "4", "6", "8", "10", "Max"})
            Me.comboBox2.Location = New System.Drawing.Point(87, 58)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(121, 21)
            Me.comboBox2.TabIndex = 9
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Min", "50", "100", "150", "200", "Max"})
            Me.comboBox1.Location = New System.Drawing.Point(87, 25)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 8
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(387, 75)
            Me.chartControl1.Location = New System.Drawing.Point(25, 22)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryXAxis.Margin = True
            Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryYAxis.Margin = True
            Me.chartControl1.Size = New System.Drawing.Size(496, 404)
            Me.chartControl1.TabIndex = 9
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(760, 449)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.ForeColor = System.Drawing.Color.Maroon
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Crossing Demo"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
	End Class
End Namespace

