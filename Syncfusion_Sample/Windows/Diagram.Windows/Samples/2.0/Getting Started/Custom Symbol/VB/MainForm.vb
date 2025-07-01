Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace Syncfusion.Windows.Forms.Diagram.Samples
	''' <summary>
	''' Main application for CustomSymbol sample.
	''' </summary>
	Public Class MainForm
		Inherits Form
		#Region "Members"

		Private panel1 As Panel
		Private WithEvents toolStrip1 As ToolStrip
		Private toolStripButton2 As ToolStripButton
		Private toolStripButton3 As ToolStripButton
		Private propertyEditor1 As PropertyEditor
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Model
		#End Region

		#Region "Form controls"

		Private components As IContainer
		#End Region

		#Region "Class Initialize/Finalize methods"
		''' <summary>
		''' 
		''' </summary>
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.diagram1.Model = Me.model1
		End Sub

		''' <summary>
		''' 
		''' </summary>
		''' <param name="disposing"></param>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.toolStrip1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(754, 25)
			Me.panel1.TabIndex = 0
			' 
			' toolStrip1
			' 
			Me.toolStrip1.AutoSize = False
			Me.toolStrip1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton2, Me.toolStripButton3})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(754, 25)
			Me.toolStrip1.TabIndex = 1
			Me.toolStrip1.Text = "toolStrip1"
'			Me.toolStrip1.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.toolStrip1_ItemClicked)
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(92, 22)
			Me.toolStripButton2.Text = "Add Symbol"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(58, 22)
			Me.toolStripButton3.Text = "Clone"
			' 
			' propertyEditor1
			' 
			Me.propertyEditor1.Diagram = Me.diagram1
			Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Right
			Me.propertyEditor1.Location = New System.Drawing.Point(507, 25)
			Me.propertyEditor1.Name = "propertyEditor1"
			Me.propertyEditor1.Size = New System.Drawing.Size(247, 416)
			Me.propertyEditor1.TabIndex = 1
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 25)
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(507, 416)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 2
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.BackgroundColor = System.Drawing.Color.White
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
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.ClientSize = New System.Drawing.Size(754, 441)
			Me.Controls.Add(Me.diagram1)
			Me.Controls.Add(Me.propertyEditor1)
			Me.Controls.Add(Me.panel1)
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "MainForm"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom Symbol"
'			Me.Load += New System.EventHandler(Me.MainForm_Load)
			Me.panel1.ResumeLayout(False)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region


		#End Region

		#Region "MAIN"
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New MainForm())
		End Sub
		#End Region

		#Region "Event handlers"
		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			DiagramAppearance()
		End Sub

		Private Sub toolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
			If e.ClickedItem.Name = toolStrip1.Items(0).Name Then
				Dim symb As New MySymbol()
				Me.diagram1.Model.AppendChild(symb)
			ElseIf (e.ClickedItem.Name = toolStrip1.Items(1).Name) AndAlso (Me.diagram1.View.SelectionList.Count > 0) Then
				Dim selectedSymbol As Group = TryCast(Me.diagram1.View.SelectionList(0), Group)

				If selectedSymbol IsNot Nothing Then
					Dim symbolClone As Group = CType(selectedSymbol.Clone(), Group)
					symbolClone.Translate(5, 5)
					Me.diagram1.Model.AppendChild(symbolClone)
				End If
			End If
			diagram1.Focus()
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' change's the appearance of the diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region        
	End Class
End Namespace