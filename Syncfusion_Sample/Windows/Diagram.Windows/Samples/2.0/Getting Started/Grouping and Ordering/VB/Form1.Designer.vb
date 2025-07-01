Imports Microsoft.VisualBasic
Imports System
Namespace Grouping
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
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            Me.panel2 = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.groupingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.groupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.unGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.orderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bringToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bringForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sendBackwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sendToBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(2, 2)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(694, 70)
            Me.panel1.TabIndex = 0
            Me.panel1.TitleText = "Grouping and Ordering"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(462, 72)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(10)
            Me.panel2.Size = New System.Drawing.Size(234, 462)
            Me.panel2.TabIndex = 1
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(13, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(208, 51)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Right-clicking on the selected node will pop up a context menu which lets you to " & _
                "group or order the selected nodes."
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.diagram1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(2, 72)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(460, 462)
            Me.panel3.TabIndex = 0
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(460, 462)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 0
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.Grid.Visible = False
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 1169.0!
            Me.model1.DocumentSize.Width = 827.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.groupingToolStripMenuItem, Me.orderToolStripMenuItem})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(125, 48)
            '
            'groupingToolStripMenuItem
            '
            Me.groupingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.groupToolStripMenuItem, Me.unGroupToolStripMenuItem})
            Me.groupingToolStripMenuItem.Name = "groupingToolStripMenuItem"
            Me.groupingToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.groupingToolStripMenuItem.Text = "Grouping"
            '
            'groupToolStripMenuItem
            '
            Me.groupToolStripMenuItem.Name = "groupToolStripMenuItem"
            Me.groupToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
            Me.groupToolStripMenuItem.Text = "Group"
            '
            'unGroupToolStripMenuItem
            '
            Me.unGroupToolStripMenuItem.Name = "unGroupToolStripMenuItem"
            Me.unGroupToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
            Me.unGroupToolStripMenuItem.Text = "UnGroup"
            '
            'orderToolStripMenuItem
            '
            Me.orderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bringToFrontToolStripMenuItem, Me.bringForwardToolStripMenuItem, Me.sendBackwardToolStripMenuItem, Me.sendToBackToolStripMenuItem})
            Me.orderToolStripMenuItem.Name = "orderToolStripMenuItem"
            Me.orderToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.orderToolStripMenuItem.Text = "Order"
            '
            'bringToFrontToolStripMenuItem
            '
            Me.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem"
            Me.bringToFrontToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.bringToFrontToolStripMenuItem.Text = "Bring To Front"
            '
            'bringForwardToolStripMenuItem
            '
            Me.bringForwardToolStripMenuItem.Name = "bringForwardToolStripMenuItem"
            Me.bringForwardToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.bringForwardToolStripMenuItem.Text = "Bring Forward"
            '
            'sendBackwardToolStripMenuItem
            '
            Me.sendBackwardToolStripMenuItem.Name = "sendBackwardToolStripMenuItem"
            Me.sendBackwardToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.sendBackwardToolStripMenuItem.Text = "Send backward"
            '
            'sendToBackToolStripMenuItem
            '
            Me.sendToBackToolStripMenuItem.Name = "sendToBackToolStripMenuItem"
            Me.sendToBackToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.sendToBackToolStripMenuItem.Text = "Send To Back"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(698, 536)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grouping"
            Me.panel2.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
        Private label1 As System.Windows.Forms.Label
        Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
		Private groupingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents groupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents unGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private orderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents bringToFrontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents bringForwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents sendBackwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents sendToBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

