Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2009"
' Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace CustomizableFindDialogDemo
	Partial Public Class MainForm
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
			Dim config1 As New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.editControl2 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.label4 = New System.Windows.Forms.Label()
			Me.panel1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			CType(Me.editControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.checkBox1)
			Me.panel1.Controls.Add(Me.groupBox1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(187, 495)
			Me.panel1.TabIndex = 0
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(12, 44)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(158, 17)
			Me.checkBox1.TabIndex = 2
			Me.checkBox1.Text = "Use Customized Find Dialog"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.comboBox2)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Location = New System.Drawing.Point(10, 100)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(168, 217)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(25, 177)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(84, 30)
			Me.button1.TabIndex = 6
			Me.button1.Text = "Set"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' comboBox2
			' 
			Me.comboBox2.AutoCompleteCustomSource.AddRange(New String() { "Grey", "Green"})
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Items.AddRange(New Object() { "Gray", "DarkGray"})
			Me.comboBox2.Location = New System.Drawing.Point(9, 145)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(130, 21)
			Me.comboBox2.TabIndex = 5
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(6, 129)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(111, 13)
			Me.label3.TabIndex = 4
			Me.label3.Text = "CheckBox Back Color"
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Gray", "LightGray", "Dark Gray"})
			Me.comboBox1.Location = New System.Drawing.Point(7, 86)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(130, 21)
			Me.comboBox1.TabIndex = 3
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(11, 70)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(98, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Buttons Back Color"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(4, 14)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(115, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Type Custom Message"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(6, 38)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(132, 20)
			Me.textBox1.TabIndex = 0
			Me.textBox1.Text = "Type Custom message.."
			' 
			' editControl2
			' 
			Me.editControl2.Configurator = config1
			Me.editControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl2.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl2.Location = New System.Drawing.Point(187, 0)
			Me.editControl2.Name = "editControl2"
			Me.editControl2.ScrollPosition = New System.Drawing.Point(0, 0)
			Me.editControl2.Size = New System.Drawing.Size(510, 495)
			Me.editControl2.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl2.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl2.TabIndex = 1
			Me.editControl2.Text = "editControl2"
			Me.editControl2.VisualColumn = 1
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(24, 84)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(141, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Set Properties of Find Dialog"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.CaptionFont = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.ClientSize = New System.Drawing.Size(697, 495)
			Me.Controls.Add(Me.editControl2)
			Me.Controls.Add(Me.panel1)
			Me.ForeColor = System.Drawing.Color.Navy
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.HelpButton = True
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Location = New System.Drawing.Point(250, 450)
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Customizable Find Dialog"
			Me.UseOffice2007SchemeBackColor = True
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.editControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private editControl2 As Syncfusion.Windows.Forms.Edit.EditControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label


	End Class
End Namespace