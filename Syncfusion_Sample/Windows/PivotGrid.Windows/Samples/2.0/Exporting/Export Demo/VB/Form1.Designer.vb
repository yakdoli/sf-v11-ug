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
			Me.components = New System.ComponentModel.Container()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.pivotGridControl1)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Location = New System.Drawing.Point(4, 1)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1099, 501)
			Me.panel1.TabIndex = 0
			' 
			' pivotGridControl1
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
			' panel2
			' 
			Me.panel2.Controls.Add(Me.groupBox2)
			Me.panel2.Controls.Add(Me.groupBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(794, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(305, 501)
			Me.panel2.TabIndex = 1
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.groupBox3)
			Me.groupBox2.Controls.Add(Me.buttonAdv1)
			Me.groupBox2.Controls.Add(Me.button1)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
			Me.groupBox2.Location = New System.Drawing.Point(25, 129)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(257, 235)
			Me.groupBox2.TabIndex = 5
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Export"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.comboBoxAdv1)
			Me.groupBox3.Controls.Add(Me.buttonAdv2)
			Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
			Me.groupBox3.Location = New System.Drawing.Point(15, 107)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(207, 109)
			Me.groupBox3.TabIndex = 2
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Excel Export"
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv1.Location = New System.Drawing.Point(23, 32)
			Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(110, 21)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv1.TabIndex = 4
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv2.ForeColor = System.Drawing.Color.White
			Me.buttonAdv2.Location = New System.Drawing.Point(19, 69)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(121, 34)
			Me.buttonAdv2.TabIndex = 6
			Me.buttonAdv2.Text = "Export to Excel"
			Me.buttonAdv2.UseVisualStyle = True
			Me.buttonAdv2.UseVisualStyleBackColor = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.Location = New System.Drawing.Point(34, 67)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(121, 34)
			Me.buttonAdv1.TabIndex = 6
			Me.buttonAdv1.Text = "Export to Word"
			Me.buttonAdv1.UseVisualStyle = True
			Me.buttonAdv1.UseVisualStyleBackColor = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(34, 21)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(121, 34)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Export to PDF"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.checkBoxAdv1)
			Me.groupBox1.Controls.Add(Me.checkBoxAdv3)
			Me.groupBox1.Controls.Add(Me.checkBoxAdv2)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(25, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(257, 120)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "GroupBar"
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.Checked = True
			Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBoxAdv1.DrawFocusRectangle = False
			Me.checkBoxAdv1.Location = New System.Drawing.Point(38, 86)
			Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Size = New System.Drawing.Size(110, 28)
			Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv1.TabIndex = 6
			Me.checkBoxAdv1.Text = "Allow Sorting"
			Me.checkBoxAdv1.ThemesEnabled = False
'			Me.checkBoxAdv1.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv1_CheckStateChanged)
			' 
			' checkBoxAdv3
			' 
			Me.checkBoxAdv3.Checked = True
			Me.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBoxAdv3.DrawFocusRectangle = False
			Me.checkBoxAdv3.Location = New System.Drawing.Point(38, 22)
			Me.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv3.Name = "checkBoxAdv3"
			Me.checkBoxAdv3.Size = New System.Drawing.Size(184, 28)
			Me.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv3.TabIndex = 4
			Me.checkBoxAdv3.Text = "Enable/Disable GroupBar"
			Me.checkBoxAdv3.ThemesEnabled = False
'			Me.checkBoxAdv3.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv3_CheckStateChanged)
			' 
			' checkBoxAdv2
			' 
			Me.checkBoxAdv2.Checked = True
			Me.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBoxAdv2.DrawFocusRectangle = False
			Me.checkBoxAdv2.Location = New System.Drawing.Point(38, 53)
			Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv2.Name = "checkBoxAdv2"
			Me.checkBoxAdv2.Size = New System.Drawing.Size(110, 28)
			Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv2.TabIndex = 5
			Me.checkBoxAdv2.Text = "Allow Filtering"
			Me.checkBoxAdv2.ThemesEnabled = False
'			Me.checkBoxAdv2.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv2_CheckStateChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1107, 506)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.BackColor = Drawing.Color.White
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = " PivotGrid Export Demo"
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv


	End Class
End Namespace

