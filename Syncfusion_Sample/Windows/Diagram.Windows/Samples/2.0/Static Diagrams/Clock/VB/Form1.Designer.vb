Imports Microsoft.VisualBasic
Imports System
Namespace Clock
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
			Me.panel3 = New DemoCommon.Diagram.TitlePanel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.panel2.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel3.ControlBox = False
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel3.Form = Me
			Me.panel3.Location = New System.Drawing.Point(2, 2)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(786, 70)
			Me.panel3.TabIndex = 7
			Me.panel3.TitleText = "Clock Demo"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.diagram1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(2, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(786, 296)
			Me.panel2.TabIndex = 9
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.Model = Me.model2
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(786, 296)
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
			' model2
			' 
			Me.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model2.DocumentScale.DisplayName = "No Scale"
			Me.model2.DocumentScale.Height = 1F
			Me.model2.DocumentScale.Width = 1F
			Me.model2.DocumentSize.Height = 1169F
			Me.model2.DocumentSize.Width = 827F
			Me.model2.LineStyle.DashPattern = Nothing
			Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model2.LineStyle.LineWidth = 0F
			Me.model2.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.White
			Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.button1.FlatAppearance.BorderSize = 0
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.Image = (CType(resources.GetObject("button1.Image"), System.Drawing.Image))
			Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.button1.Location = New System.Drawing.Point(643, 312)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(42, 39)
			Me.button1.TabIndex = 10
			Me.button1.Text = "Play"
			Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.White
			Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.button2.FlatAppearance.BorderSize = 0
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.Image = (CType(resources.GetObject("button2.Image"), System.Drawing.Image))
			Me.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.button2.Location = New System.Drawing.Point(695, 312)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(42, 39)
			Me.button2.TabIndex = 11
			Me.button2.Text = "Stop"
			Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' timer1
			' 
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(790, 370)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel3)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Clock Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel2.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel3 As DemoCommon.Diagram.TitlePanel
		Private panel2 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model2 As Syncfusion.Windows.Forms.Diagram.Model
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class

End Namespace

