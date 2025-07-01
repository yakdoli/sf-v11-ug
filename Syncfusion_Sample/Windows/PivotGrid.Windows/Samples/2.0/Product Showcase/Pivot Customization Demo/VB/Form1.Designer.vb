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
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.pivotGridControl1)
            Me.panel1.Location = New System.Drawing.Point(12, 12)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1043, 556)
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
            Me.pivotGridControl1.ShowGrandTotals = False
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowPivotTableFieldList = False
            Me.pivotGridControl1.ShowSubTotals = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(1043, 556)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Location = New System.Drawing.Point(12, 573)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(1043, 58)
            Me.panel2.TabIndex = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.checkBoxAdv2)
            Me.groupBox1.Controls.Add(Me.checkBoxAdv1)
            Me.groupBox1.Controls.Add(Me.checkBox3)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox1.Location = New System.Drawing.Point(0, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(1043, 58)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Customization"
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.DrawFocusRectangle = False
            Me.checkBoxAdv2.Location = New System.Drawing.Point(613, 25)
            Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.Size = New System.Drawing.Size(88, 19)
            Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv2.TabIndex = 4
            Me.checkBoxAdv2.Text = "Apply RTL"
            Me.checkBoxAdv2.ThemesEnabled = False
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.DrawFocusRectangle = False
            Me.checkBoxAdv1.Location = New System.Drawing.Point(52, 25)
            Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(171, 19)
            Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv1.TabIndex = 3
            Me.checkBoxAdv1.Text = "Show PivotTableFieldList"
            Me.checkBoxAdv1.ThemesEnabled = False
            '
            'checkBox3
            '
            Me.checkBox3.DrawFocusRectangle = False
            Me.checkBox3.Location = New System.Drawing.Point(480, 25)
            Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(127, 19)
            Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox3.TabIndex = 2
            Me.checkBox3.Text = "Show GrandTotals"
            Me.checkBox3.ThemesEnabled = False
            '
            'checkBox2
            '
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Location = New System.Drawing.Point(362, 25)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(112, 19)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "Show Subtotals"
            Me.checkBox2.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.checkBox1.Location = New System.Drawing.Point(229, 25)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(127, 19)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Enable GroupBar"
            Me.checkBox1.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1067, 643)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.panel2)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pivot Customization Demo"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private panel2 As System.Windows.Forms.Panel
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv


	End Class
End Namespace

