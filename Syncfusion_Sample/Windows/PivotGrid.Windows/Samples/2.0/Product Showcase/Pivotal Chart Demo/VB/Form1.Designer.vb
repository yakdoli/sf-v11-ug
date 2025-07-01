Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace PivotGridDemo
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer
            Me.panel1 = New System.Windows.Forms.Panel
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(605, 526)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.CursorLocation = New System.Drawing.Point(0, 0)
            Me.chartControl1.ChartArea.CursorReDraw = False
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.chartControl1.IsWindowLess = False
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(414, 75)
            Me.chartControl1.Localize = Nothing
            Me.chartControl1.Location = New System.Drawing.Point(-2, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryXAxis.Margin = True
            Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryYAxis.Margin = True
            Me.chartControl1.Size = New System.Drawing.Size(523, 526)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'splitContainer1
            '
            Me.splitContainer1.BackColor = System.Drawing.Color.White
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.pivotGridControl1)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.chartControl1)
            Me.splitContainer1.Size = New System.Drawing.Size(1134, 526)
            Me.splitContainer1.SplitterDistance = 608
            Me.splitContainer1.SplitterWidth = 5
            Me.splitContainer1.TabIndex = 2
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.splitContainer1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1134, 526)
            Me.panel1.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1134, 526)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(1150, 564)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " Pivotal Chart Demo"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private panel1 As System.Windows.Forms.Panel

	End Class
End Namespace

