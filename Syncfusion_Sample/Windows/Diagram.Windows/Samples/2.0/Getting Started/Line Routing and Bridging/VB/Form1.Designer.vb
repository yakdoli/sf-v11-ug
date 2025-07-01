Imports Microsoft.VisualBasic
Imports System
Namespace LineRouting
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
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.panel2 = New DemoCommon.Diagram.Expander()
			Me.apply = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.txtDistanceObstcl = New System.Windows.Forms.TextBox()
			Me.comboLineRouting = New System.Windows.Forms.ComboBox()
			Me.chkLineRouting = New System.Windows.Forms.CheckBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.txtLineBridgeSize = New System.Windows.Forms.TextBox()
			Me.comboLineBridge = New System.Windows.Forms.ComboBox()
			Me.chkLineBridge = New System.Windows.Forms.CheckBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel2.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1018, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "LineRouting and LineBridging Demo"
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel2.Caption = "Properties"
			Me.panel2.Controls.Add(Me.apply)
			Me.panel2.Controls.Add(Me.groupBox2)
			Me.panel2.Controls.Add(Me.groupBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(744, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(10)
			Me.panel2.Size = New System.Drawing.Size(276, 516)
			Me.panel2.TabIndex = 1
			' 
			' apply
			' 
			Me.apply.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.apply.FlatAppearance.BorderSize = 0
			Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.apply.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.apply.ForeColor = System.Drawing.Color.White
			Me.apply.Location = New System.Drawing.Point(108, 371)
			Me.apply.Name = "apply"
			Me.apply.Size = New System.Drawing.Size(80, 30)
			Me.apply.TabIndex = 34
			Me.apply.Text = "Apply"
			Me.apply.UseVisualStyleBackColor = False
'			Me.apply.Click += New System.EventHandler(Me.apply_Click)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.txtDistanceObstcl)
			Me.groupBox2.Controls.Add(Me.comboLineRouting)
			Me.groupBox2.Controls.Add(Me.chkLineRouting)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.Location = New System.Drawing.Point(13, 201)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(260, 151)
			Me.groupBox2.TabIndex = 6
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "LineRouting"
			' 
			' txtDistanceObstcl
			' 
			Me.txtDistanceObstcl.Location = New System.Drawing.Point(163, 114)
			Me.txtDistanceObstcl.Name = "txtDistanceObstcl"
			Me.txtDistanceObstcl.Size = New System.Drawing.Size(91, 23)
			Me.txtDistanceObstcl.TabIndex = 5
			' 
			' comboLineRouting
			' 
			Me.comboLineRouting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboLineRouting.FormattingEnabled = True
			Me.comboLineRouting.Items.AddRange(New Object() { "Inactive", "Automatic", "SemiAutomatic"})
			Me.comboLineRouting.Location = New System.Drawing.Point(163, 69)
			Me.comboLineRouting.Name = "comboLineRouting"
			Me.comboLineRouting.Size = New System.Drawing.Size(91, 23)
			Me.comboLineRouting.TabIndex = 4
			' 
			' chkLineRouting
			' 
			Me.chkLineRouting.AutoSize = True
			Me.chkLineRouting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkLineRouting.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkLineRouting.Location = New System.Drawing.Point(163, 35)
			Me.chkLineRouting.Name = "chkLineRouting"
			Me.chkLineRouting.Size = New System.Drawing.Size(12, 11)
			Me.chkLineRouting.TabIndex = 3
			Me.chkLineRouting.UseVisualStyleBackColor = True
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(6, 122)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(117, 15)
			Me.label4.TabIndex = 2
			Me.label4.Text = "DistanceToObstacles"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.Location = New System.Drawing.Point(6, 77)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(80, 15)
			Me.label5.TabIndex = 1
			Me.label5.Text = "RoutingMode"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.Location = New System.Drawing.Point(6, 37)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(113, 15)
			Me.label6.TabIndex = 0
			Me.label6.Text = "LineRoutingEnabled"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.txtLineBridgeSize)
			Me.groupBox1.Controls.Add(Me.comboLineBridge)
			Me.groupBox1.Controls.Add(Me.chkLineBridge)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(13, 35)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(260, 151)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "LineBridging"
			' 
			' txtLineBridgeSize
			' 
			Me.txtLineBridgeSize.Location = New System.Drawing.Point(163, 114)
			Me.txtLineBridgeSize.Name = "txtLineBridgeSize"
			Me.txtLineBridgeSize.Size = New System.Drawing.Size(91, 23)
			Me.txtLineBridgeSize.TabIndex = 5
			' 
			' comboLineBridge
			' 
			Me.comboLineBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboLineBridge.FormattingEnabled = True
			Me.comboLineBridge.Items.AddRange(New Object() { "Arc", "Gap", "Square", "Side2", "Side3", "Side4", "Side5", "Side6", "Side7"})
			Me.comboLineBridge.Location = New System.Drawing.Point(163, 69)
			Me.comboLineBridge.Name = "comboLineBridge"
			Me.comboLineBridge.Size = New System.Drawing.Size(91, 23)
			Me.comboLineBridge.TabIndex = 4
			' 
			' chkLineBridge
			' 
			Me.chkLineBridge.AutoSize = True
			Me.chkLineBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkLineBridge.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkLineBridge.Location = New System.Drawing.Point(163, 35)
			Me.chkLineBridge.Name = "chkLineBridge"
			Me.chkLineBridge.Size = New System.Drawing.Size(12, 11)
			Me.chkLineBridge.TabIndex = 3
			Me.chkLineBridge.UseVisualStyleBackColor = True
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(6, 122)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(83, 15)
			Me.label3.TabIndex = 2
			Me.label3.Text = "LineBridgeSize"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(6, 77)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(65, 15)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Bridgestyle"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(6, 37)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(116, 15)
			Me.label1.TabIndex = 0
			Me.label1.Text = "LineBridgingEnabled"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.diagram1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(2, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(742, 516)
			Me.panel3.TabIndex = 2
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(742, 516)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			' 
			' model1
			' 
			Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model1.DocumentScale.DisplayName = "No Scale"
			Me.model1.DocumentScale.Height = 1F
			Me.model1.DocumentScale.Width = 1F
			Me.model1.DocumentSize.Height = 1169F
			Me.model1.DocumentSize.Width = 827F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model1.LineStyle.LineWidth = 0F
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1022, 590)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel2.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.panel3.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As DemoCommon.Diagram.Expander
		Private panel3 As System.Windows.Forms.Panel
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private txtLineBridgeSize As System.Windows.Forms.TextBox
		Private comboLineBridge As System.Windows.Forms.ComboBox
		Private chkLineBridge As System.Windows.Forms.CheckBox
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private txtDistanceObstcl As System.Windows.Forms.TextBox
		Private comboLineRouting As System.Windows.Forms.ComboBox
		Private chkLineRouting As System.Windows.Forms.CheckBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents apply As System.Windows.Forms.Button
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace

