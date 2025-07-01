Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace DiagramORM.Sample
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
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.button1 = New System.Windows.Forms.Button
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer
            Me.label3 = New System.Windows.Forms.Label
            Me.btnRemove = New System.Windows.Forms.Button
            Me.tabControl1 = New System.Windows.Forms.TabControl
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.diagram2 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            CType(Me.diagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.Office2007ScrollBars = True
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(742, 555)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 0
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.BackgroundColor = System.Drawing.Color.White
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 708.6614!
            Me.model1.DocumentSize.Width = 730.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.LightGray
            Me.model1.LogicalSize = New System.Drawing.SizeF(730.0!, 708.6614!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.DimGray
            Me.model1.ShadowStyle.ColorAlphaFactor = 255
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.DimGray
            Me.model1.ShadowStyle.ForeColorAlphaFactor = 255
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(9, 297)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(115, 28)
            Me.comboBox1.TabIndex = 2
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(6, 275)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(110, 20)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Employee List:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(6, 370)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 20)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Enter Name:"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(9, 388)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(115, 27)
            Me.textBox1.TabIndex = 5
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Location = New System.Drawing.Point(9, 417)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(115, 31)
            Me.button1.TabIndex = 6
            Me.button1.Text = "Add Employee"
            Me.button1.UseVisualStyleBackColor = True
            '
            'splitContainer1
            '
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
            Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
            Me.splitContainer1.Name = "splitContainer1"
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.label3)
            Me.splitContainer1.Panel1.Controls.Add(Me.btnRemove)
            Me.splitContainer1.Panel1.Controls.Add(Me.label1)
            Me.splitContainer1.Panel1.Controls.Add(Me.button1)
            Me.splitContainer1.Panel1.Controls.Add(Me.comboBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.textBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.diagram1)
            Me.splitContainer1.Size = New System.Drawing.Size(901, 550)
            Me.splitContainer1.SplitterDistance = 155
            Me.splitContainer1.TabIndex = 7
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(6, 10)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(146, 254)
            Me.label3.TabIndex = 8
            Me.label3.Text = resources.GetString("label3.Text")
            '
            'btnRemove
            '
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Location = New System.Drawing.Point(9, 325)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(115, 31)
            Me.btnRemove.TabIndex = 7
            Me.btnRemove.Text = "Remove Employee"
            Me.btnRemove.UseVisualStyleBackColor = True
            '
            'tabControl1
            '
            Me.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabControl1.Location = New System.Drawing.Point(1, 2)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.Padding = New System.Drawing.Point(6, 4)
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(915, 594)
            Me.tabControl1.TabIndex = 8
            '
            'tabPage1
            '
            Me.tabPage1.Controls.Add(Me.splitContainer1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 34)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(907, 556)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Self Relation"
            Me.tabPage1.UseVisualStyleBackColor = True
            '
            'tabPage2
            '
            Me.tabPage2.Controls.Add(Me.diagram2)
            Me.tabPage2.Location = New System.Drawing.Point(4, 34)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(907, 556)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Parent-Child Relationship"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'diagram2
            '
            Me.diagram2.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.diagram2.LayoutManager = Nothing
            Me.diagram2.Location = New System.Drawing.Point(3, 3)
            Me.diagram2.Model = Me.model2
            Me.diagram2.Name = "diagram2"
            Me.diagram2.Office2007ScrollBars = True
            Me.diagram2.ScrollVirtualBounds = CType(resources.GetObject("diagram2.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram2.Size = New System.Drawing.Size(901, 550)
            Me.diagram2.SmartSizeBox = False
            Me.diagram2.TabIndex = 0
            Me.diagram2.Text = "diagram2"
            '
            '
            '
            Me.diagram2.View.BackgroundColor = System.Drawing.Color.White
            Me.diagram2.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram2.View.Controller = Me.diagram2.Controller
            Me.diagram2.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram2.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds1"), System.Drawing.RectangleF)
            '
            'model2
            '
            Me.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model2.DocumentScale.DisplayName = "No Scale"
            Me.model2.DocumentScale.Height = 1.0!
            Me.model2.DocumentScale.Width = 1.0!
            Me.model2.DocumentSize.Height = 1169.0!
            Me.model2.DocumentSize.Width = 827.0!
            Me.model2.LineStyle.DashPattern = Nothing
            Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model2.LineStyle.LineWidth = 0.0!
            Me.model2.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model2.ShadowStyle.Color = System.Drawing.Color.DimGray
            Me.model2.ShadowStyle.ColorAlphaFactor = 255
            Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.DimGray
            Me.model2.ShadowStyle.ForeColorAlphaFactor = 255
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(916, 596)
            Me.Controls.Add(Me.tabControl1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(1, 2, 0, 0)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Diagram Data Binding"
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage2.ResumeLayout(False)
            CType(Me.diagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private WithEvents btnRemove As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private diagram2 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model2 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace