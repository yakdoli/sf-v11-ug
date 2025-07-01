Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace WindowsFormsApplication11
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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
            Me.panel2 = New System.Windows.Forms.Panel
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.pivotGridControl1)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Location = New System.Drawing.Point(4, 1)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1099, 501)
            Me.panel1.TabIndex = 0
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(794, 501)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(794, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(305, 501)
            Me.panel2.TabIndex = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.checkBoxAdv1)
            Me.groupBox1.Controls.Add(Me.checkBoxAdv3)
            Me.groupBox1.Controls.Add(Me.checkBoxAdv2)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox1.Location = New System.Drawing.Point(25, 3)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(257, 120)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "GroupBar"
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.Checked = True
            Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv1.DrawFocusRectangle = False
            Me.checkBoxAdv1.Location = New System.Drawing.Point(38, 86)
            Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(110, 28)
            Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv1.TabIndex = 6
            Me.checkBoxAdv1.Text = "Allow Sorting"
            Me.checkBoxAdv1.ThemesEnabled = False
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.Checked = True
            Me.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv3.DrawFocusRectangle = False
            Me.checkBoxAdv3.Location = New System.Drawing.Point(38, 22)
            Me.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.Size = New System.Drawing.Size(184, 28)
            Me.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv3.TabIndex = 4
            Me.checkBoxAdv3.Text = "Enable/Disable GroupBar"
            Me.checkBoxAdv3.ThemesEnabled = False
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.Checked = True
            Me.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv2.DrawFocusRectangle = False
            Me.checkBoxAdv2.Location = New System.Drawing.Point(38, 53)
            Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.Size = New System.Drawing.Size(110, 28)
            Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv2.TabIndex = 5
            Me.checkBoxAdv2.Text = "Allow Filtering"
            Me.checkBoxAdv2.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1107, 506)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.BackColor = Drawing.Color.White
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " GroupBar Demo"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private panel2 As System.Windows.Forms.Panel
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv


	End Class
End Namespace

