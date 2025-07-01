#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace PdfConverter
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gridGroupingControl2 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
            Me.domainUpDown4 = New System.Windows.Forms.NumericUpDown()
            Me.domainUpDown3 = New System.Windows.Forms.NumericUpDown()
            Me.domainUpDown2 = New System.Windows.Forms.NumericUpDown()
            Me.domainUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.splitContainer1.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.gridGroupingControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.splitContainer1.Size = New System.Drawing.Size(730, 369)
			Me.splitContainer1.SplitterDistance = 257
			Me.splitContainer1.TabIndex = 3
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(665, 492)
			Me.gridGroupingControl1.TabIndex = 1
			Me.gridGroupingControl1.Text = "gridGroupingControl2"
			Me.gridGroupingControl1.VersionInfo = "6.303.0.30"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridGroupingControl2)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.groupBox1)
			Me.panel1.Controls.Add(Me.groupBox2)
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(759, 454)
			Me.panel1.TabIndex = 8
			' 
			' gridGroupingControl2
			' 
			Me.gridGroupingControl2.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl2.Location = New System.Drawing.Point(11, 5)
			Me.gridGroupingControl2.Name = "gridGroupingControl2"
			Me.gridGroupingControl2.ShowGroupDropArea = True
			Me.gridGroupingControl2.Size = New System.Drawing.Size(543, 350)
			Me.gridGroupingControl2.TabIndex = 9
			Me.gridGroupingControl2.Text = "gridGroupingControl2"
			Me.gridGroupingControl2.VersionInfo = "6.303.0.30"
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(590, 296)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(102, 34)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Export to PDF"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.checkBoxAdv2)
			Me.groupBox1.Controls.Add(Me.checkBoxAdv1)
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(571, 24)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(144, 92)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Header Footer"
			' 
			' checkBoxAdv2
			' 
			Me.checkBoxAdv2.Location = New System.Drawing.Point(15, 55)
			Me.checkBoxAdv2.MetroColor = System.Drawing.Color.Blue
			Me.checkBoxAdv2.Name = "checkBoxAdv2"
			Me.checkBoxAdv2.Size = New System.Drawing.Size(105, 21)
			Me.checkBoxAdv2.TabIndex = 3
			Me.checkBoxAdv2.Text = "Show Footer"
			Me.checkBoxAdv2.ThemesEnabled = False
			Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.Location = New System.Drawing.Point(15, 19)
			Me.checkBoxAdv1.MetroColor = System.Drawing.Color.Blue
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Size = New System.Drawing.Size(106, 21)
			Me.checkBoxAdv1.TabIndex = 2
			Me.checkBoxAdv1.Text = "Show Header"
			Me.checkBoxAdv1.ThemesEnabled = False
			Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Controls.Add(Me.label2)
			Me.groupBox2.Controls.Add(Me.label1)
			Me.groupBox2.Controls.Add(Me.domainUpDown4)
			Me.groupBox2.Controls.Add(Me.domainUpDown3)
			Me.groupBox2.Controls.Add(Me.domainUpDown2)
			Me.groupBox2.Controls.Add(Me.domainUpDown1)
			Me.groupBox2.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox2.Location = New System.Drawing.Point(571, 142)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(144, 125)
			Me.groupBox2.TabIndex = 8
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Margin"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(14, 100)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(45, 13)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Bottom"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(14, 72)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(26, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Top"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(14, 46)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(35, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Right"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(14, 21)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(26, 13)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Left"
			' 
			' domainUpDown4
			' 
			Me.domainUpDown4.Location = New System.Drawing.Point(75, 98)
			Me.domainUpDown4.Name = "domainUpDown4"
			Me.domainUpDown4.Size = New System.Drawing.Size(54, 22)
			Me.domainUpDown4.TabIndex = 3
			Me.domainUpDown4.Text = "domainUpDown4"
			' 
			' domainUpDown3
			' 
			Me.domainUpDown3.Location = New System.Drawing.Point(75, 70)
			Me.domainUpDown3.Name = "domainUpDown3"
			Me.domainUpDown3.Size = New System.Drawing.Size(54, 22)
			Me.domainUpDown3.TabIndex = 2
			Me.domainUpDown3.Text = "domainUpDown3"
			' 
			' domainUpDown2
			' 
			Me.domainUpDown2.Location = New System.Drawing.Point(75, 44)
			Me.domainUpDown2.Name = "domainUpDown2"
			Me.domainUpDown2.Size = New System.Drawing.Size(54, 22)
			Me.domainUpDown2.TabIndex = 1
			Me.domainUpDown2.Text = "domainUpDown2"
			' 
			' domainUpDown1
			' 
			Me.domainUpDown1.Location = New System.Drawing.Point(75, 19)
			Me.domainUpDown1.Name = "domainUpDown1"
			Me.domainUpDown1.Size = New System.Drawing.Size(54, 22)
			Me.domainUpDown1.TabIndex = 0
			Me.domainUpDown1.Text = "domainUpDown1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(730, 369)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.splitContainer1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "PDF Export Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.gridGroupingControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolTip1 As System.Windows.Forms.ToolTip
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel1 As System.Windows.Forms.Panel
		Private gridGroupingControl2 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Public groupBox1 As System.Windows.Forms.GroupBox
		Public checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Public checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Public groupBox2 As System.Windows.Forms.GroupBox
		Public label4 As System.Windows.Forms.Label
		Public label3 As System.Windows.Forms.Label
		Public label2 As System.Windows.Forms.Label
		Public label1 As System.Windows.Forms.Label
        Public domainUpDown4 As System.Windows.Forms.NumericUpDown
        Public domainUpDown3 As System.Windows.Forms.NumericUpDown
        Public domainUpDown2 As System.Windows.Forms.NumericUpDown
        Public domainUpDown1 As System.Windows.Forms.NumericUpDown

	End Class
End Namespace

