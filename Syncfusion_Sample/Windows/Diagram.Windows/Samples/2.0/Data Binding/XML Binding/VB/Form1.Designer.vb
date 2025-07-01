Imports Microsoft.VisualBasic
Imports System
Namespace XMLBinding
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
			Me.panel1 = New DemoCommon.Diagram.Expander()
			Me.label2 = New System.Windows.Forms.Label()
			Me.comboXml = New System.Windows.Forms.ComboBox()
			Me.lytProp = New System.Windows.Forms.Label()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel1.SuspendLayout()
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
			Me.panel3.Size = New System.Drawing.Size(1345, 70)
			Me.panel3.TabIndex = 7
			Me.panel3.TitleText = "XML Binding"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel1.Caption = "Properties"
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.comboXml)
			Me.panel1.Controls.Add(Me.lytProp)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel1.Location = New System.Drawing.Point(1064, 72)
			Me.panel1.Name = "panel1"
			Me.panel1.Padding = New System.Windows.Forms.Padding(10)
			Me.panel1.Size = New System.Drawing.Size(283, 640)
			Me.panel1.TabIndex = 8
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(13, 50)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(80, 13)
			Me.label2.TabIndex = 34
			Me.label2.Text = "Select XML file"
			' 
			' comboXml
			' 
			Me.comboXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboXml.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboXml.FormattingEnabled = True
			Me.comboXml.Items.AddRange(New Object() { "XML File1", "XML FIle2"})
			Me.comboXml.Location = New System.Drawing.Point(170, 48)
			Me.comboXml.Name = "comboXml"
			Me.comboXml.Size = New System.Drawing.Size(100, 21)
			Me.comboXml.TabIndex = 35
			' 
			' lytProp
			' 
			Me.lytProp.AutoEllipsis = True
			Me.lytProp.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.lytProp.Font = New System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lytProp.Location = New System.Drawing.Point(50, 9)
			Me.lytProp.Name = "lytProp"
			Me.lytProp.Size = New System.Drawing.Size(149, 20)
			Me.lytProp.TabIndex = 29
			Me.lytProp.Text = "Properties"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.diagram1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(2, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1062, 640)
			Me.panel2.TabIndex = 9
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model2
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(1062, 640)
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
			Me.model2.DocumentSize.Width = 1527F
			Me.model2.LineStyle.DashPattern = Nothing
			Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model2.LineStyle.LineWidth = 0F
			Me.model2.LogicalSize = New System.Drawing.SizeF(1527F, 1169F)
			Me.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1349, 714)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panel3)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "XML Binding"
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel3 As DemoCommon.Diagram.TitlePanel
		Private panel1 As DemoCommon.Diagram.Expander
		Private lytProp As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model2 As Syncfusion.Windows.Forms.Diagram.Model
		Private comboXml As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
	End Class

End Namespace

