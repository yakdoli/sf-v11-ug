Imports Microsoft.VisualBasic
Imports System
Namespace MultiPagePrinting_2005
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
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(382, 75)
            Me.chartControl1.Location = New System.Drawing.Point(7, 21)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryXAxis.Margin = True
            Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryYAxis.Margin = True
            Me.chartControl1.Size = New System.Drawing.Size(491, 383)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(504, 61)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(117, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Choose Divided Range"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(625, 202)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(73, 17)
            Me.checkBox1.TabIndex = 3
            Me.checkBox1.Text = "Grayscale"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(625, 140)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(100, 23)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Print"
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(625, 98)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(100, 23)
            Me.button1.TabIndex = 4
            Me.button1.Text = "Print Preview"
            Me.button1.UseVisualStyleBackColor = True
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"10", "20", "30", "40"})
            Me.ComboBox1.Location = New System.Drawing.Point(625, 61)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
            Me.ComboBox1.TabIndex = 6
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(758, 550)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "MultiPage Printing"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label1 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace

