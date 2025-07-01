Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace MarkHeaderDemo_2008
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Location = New System.Drawing.Point(26, 21)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(697, 355)
			Me.panel1.TabIndex = 4
			' 
			' gridControl1
			' 
			Me.gridControl1.ColCount = 15
			Me.gridControl1.DefaultColWidth = 90
			Me.gridControl1.DefaultRowHeight = 25
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RowCount = 20
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(697, 355)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.comboBox2)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(757, 21)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(285, 100)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Apply Theme Here"
			' 
			' comboBox2
			' 
			Me.comboBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Items.AddRange(New Object() { "Office2010Blue", "Office2010Black", "Office2010Silver", "Metro"})
			Me.comboBox2.Location = New System.Drawing.Point(111, 65)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(159, 23)
			Me.comboBox2.TabIndex = 7
'			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox2_SelectedIndexChanged)
			' 
			' comboBox1
			' 
			Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Both", "RowHeader", "ColHeader"})
			Me.comboBox1.Location = New System.Drawing.Point(111, 27)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(159, 23)
			Me.comboBox1.TabIndex = 6
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(9, 70)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(78, 15)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Visual Theme"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(6, 29)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(75, 15)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Mark Header"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1069, 401)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MarkHeader Demo"
			Me.panel1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label



	End Class
End Namespace