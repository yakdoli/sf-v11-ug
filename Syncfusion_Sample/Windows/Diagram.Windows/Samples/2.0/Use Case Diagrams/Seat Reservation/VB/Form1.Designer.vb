Imports Microsoft.VisualBasic
Imports System
Namespace SeatReservation
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.lbl = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel2.SuspendLayout()
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
			Me.panel1.Size = New System.Drawing.Size(1070, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Seat Reservation"
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel2.Caption = "Properties"
			Me.panel2.Controls.Add(Me.label1)
			Me.panel2.Controls.Add(Me.textBox2)
			Me.panel2.Controls.Add(Me.button1)
			Me.panel2.Controls.Add(Me.textBox1)
			Me.panel2.Controls.Add(Me.lbl)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(829, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(10)
			Me.panel2.Size = New System.Drawing.Size(243, 530)
			Me.panel2.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(13, 40)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(98, 19)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Selected Seats:"
			' 
			' textBox2
			' 
			Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBox2.Enabled = False
			Me.textBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox2.Location = New System.Drawing.Point(17, 243)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(213, 150)
			Me.textBox2.TabIndex = 10
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.FlatAppearance.BorderSize = 0
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(98, 399)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(69, 30)
			Me.button1.TabIndex = 7
			Me.button1.Text = "Submit"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' textBox1
			' 
			Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBox1.Enabled = False
			Me.textBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox1.Location = New System.Drawing.Point(17, 62)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(213, 150)
			Me.textBox1.TabIndex = 9
			' 
			' lbl
			' 
			Me.lbl.AutoSize = True
			Me.lbl.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lbl.Location = New System.Drawing.Point(13, 221)
			Me.lbl.Name = "lbl"
			Me.lbl.Size = New System.Drawing.Size(103, 19)
			Me.lbl.TabIndex = 6
			Me.lbl.Text = "Reserved Seats:"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.diagram1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(2, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(827, 530)
			Me.panel3.TabIndex = 1
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
			Me.diagram1.Size = New System.Drawing.Size(827, 530)
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
			Me.model1.BackgroundStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(47))))), (CInt(Fix((CByte(47))))))
			Me.model1.BackgroundStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(174))))), (CInt(Fix((CByte(174))))))
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
			Me.ClientSize = New System.Drawing.Size(1074, 604)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "SeatReservation Diagram"

			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.panel3.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As DemoCommon.Diagram.Expander
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private lbl As System.Windows.Forms.Label
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox

	End Class
End Namespace

