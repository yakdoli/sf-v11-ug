Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports DemoCommon.Diagram

Namespace ControlsGalore
	''' <summary>
	''' Sample application form.
	''' </summary>
	Public Class Form1
		Inherits DemoForm
		#Region "Form controls"

		Private openDiagramDialog As OpenFileDialog
		Private saveDiagramDialog As SaveFileDialog
		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As Panel
		Private paletteGroupBar1 As PaletteGroupBar
		Private panel3 As Panel
		Private propertyEditor1 As PropertyEditor
		Private panel4 As Panel
		Private panel6 As Panel
		Private WithEvents diagram2 As Diagram
		Private panel5 As Panel
		Private WithEvents diagram1 As Diagram
		Private model As Model
		Private components As System.ComponentModel.IContainer
		Private selectedDiagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram = Nothing
		#End Region

		#Region "Class Initialize/Finalize methods"
		''' <summary>
		''' Default Applcation constructor.
		''' </summary>
		Public Sub New()

			InitializeComponent()
			Me.diagram2.View.Grid.GridStyle = GridStyle.Point
			Me.diagram2.View.Grid.Color = Color.Black
			'
			' Create a model and attach it to both diagrams
			'
			Me.selectedDiagram = Me.diagram1
			Me.selectedDiagram.Model = Me.model
			Me.diagram2.Model = Me.model
			Me.propertyEditor1.Diagram = Me.selectedDiagram
			Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.openDiagramDialog = New System.Windows.Forms.OpenFileDialog()
			Me.saveDiagramDialog = New System.Windows.Forms.SaveFileDialog()
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.diagram2 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.panel6.SuspendLayout()
			CType(Me.diagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel5.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' openDiagramDialog
			' 
			Me.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*"
			Me.openDiagramDialog.Title = "Open Diagram"
			' 
			' saveDiagramDialog
			' 
			Me.saveDiagramDialog.FileName = "doc1"
			Me.saveDiagramDialog.Filter = "Diagram files|*.edd|All files|*.*"
			Me.saveDiagramDialog.Title = "SaveDiagram"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(946, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Multiple Views"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.paletteGroupBar1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(2, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(211, 563)
			Me.panel2.TabIndex = 1
			' 
			' paletteGroupBar1
			' 
			Me.paletteGroupBar1.AllowDrop = True
			Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))))
			Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
			Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.paletteGroupBar1.Diagram = Nothing
			Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.paletteGroupBar1.EditMode = False
			Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
			Me.paletteGroupBar1.FlatLook = True
			Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
			Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
			Me.paletteGroupBar1.GroupBarItemHeight = 32
			Me.paletteGroupBar1.IndexOnVisibleItems = True
			Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 0)
			Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
			Me.paletteGroupBar1.Name = "paletteGroupBar1"
			Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
			Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.paletteGroupBar1.Size = New System.Drawing.Size(211, 563)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.propertyEditor1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel3.Location = New System.Drawing.Point(695, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(253, 563)
			Me.panel3.TabIndex = 0
			' 
			' propertyEditor1
			' 
			Me.propertyEditor1.Diagram = Nothing
			Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyEditor1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyEditor1.Location = New System.Drawing.Point(0, 0)
			Me.propertyEditor1.Name = "propertyEditor1"
			Me.propertyEditor1.Size = New System.Drawing.Size(253, 563)
			Me.propertyEditor1.TabIndex = 0
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.panel6)
			Me.panel4.Controls.Add(Me.panel5)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(213, 72)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(482, 563)
			Me.panel4.TabIndex = 2
			' 
			' panel6
			' 
			Me.panel6.Controls.Add(Me.diagram2)
			Me.panel6.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel6.Location = New System.Drawing.Point(0, 266)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(482, 297)
			Me.panel6.TabIndex = 0
			' 
			' diagram2
			' 
			Me.diagram2.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram2.HScroll = True
			Me.diagram2.LayoutManager = Nothing
			Me.diagram2.Location = New System.Drawing.Point(0, 0)
			Me.diagram2.MetroScrollBars = True
			Me.diagram2.Model = Me.model
			Me.diagram2.Name = "diagram2"
			Me.diagram2.ScrollVirtualBounds = (CType(resources.GetObject("diagram2.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram2.Size = New System.Drawing.Size(482, 297)
			Me.diagram2.SmartSizeBox = False
			Me.diagram2.TabIndex = 0
			Me.diagram2.Text = "diagram2"
			' 
			' 
			' 
			Me.diagram2.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram2.View.Controller = Me.diagram2.Controller
			Me.diagram2.View.Grid.MinPixelSpacing = 4F
			Me.diagram2.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram2.VScroll = True
'			Me.diagram2.Click += New System.EventHandler(Me.diagram2_Click)
			' 
			' model
			' 
			Me.model.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model.DocumentScale.DisplayName = "No Scale"
			Me.model.DocumentScale.Height = 1F
			Me.model.DocumentScale.Width = 1F
			Me.model.DocumentSize.Height = 1169F
			Me.model.DocumentSize.Width = 827F
			Me.model.LineStyle.DashPattern = Nothing
			Me.model.LineStyle.LineColor = System.Drawing.Color.LightGray
			Me.model.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' panel5
			' 
			Me.panel5.Controls.Add(Me.diagram1)
			Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel5.Location = New System.Drawing.Point(0, 0)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(482, 266)
			Me.panel5.TabIndex = 0
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.HScroll = True
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(482, 266)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds1"), System.Drawing.RectangleF))
			Me.diagram1.VScroll = True
'			Me.diagram1.Click += New System.EventHandler(Me.diagram1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(950, 637)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Mutiple views"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel2.ResumeLayout(False)
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			Me.panel6.ResumeLayout(False)
			CType(Me.diagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel5.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#End Region

		#Region "MAIN"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region       

		#Region "Class events"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()


			Me.diagram2.View.HandleColor = Color.AliceBlue
			Me.diagram2.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram2.View.Grid.Visible = False
			Me.diagram2.View.BackgroundColor = Color.White
			Me.diagram2.View.SelectionList.Clear()
			GroupBarAppearance()
		End Sub

		Private Sub diagram1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles diagram1.Click
			Me.SelectDiagram(Me.diagram1)
		End Sub

		Private Sub diagram2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles diagram2.Click
			Me.SelectDiagram(Me.diagram2)
		End Sub

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Select the Diagram
		''' </summary>
		''' <param name="diagram">Diagram to select</param>
		Private Sub SelectDiagram(ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram)
			Me.selectedDiagram = diagram
			Me.selectedDiagram.Model = Me.model
			Me.propertyEditor1.Diagram = Me.selectedDiagram
		End Sub

		''' <summary>
		''' Change's Appearance of GroupBar
		''' </summary>
		Private Sub GroupBarAppearance()
			Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
			For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.FlowView = True
					view.ShowToolTips = True
					view.ShowFlowViewItemText = True
					view.SelectedItemColor = Color.FromArgb(255, 219, 118)
					view.HighlightItemColor = Color.FromArgb(255, 227, 149)
					view.SelectingItemColor = Color.FromArgb(255, 238, 184)
					view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
					view.FlowViewItemTextLength = 80
					view.BackColor = Color.White
					view.TextWrap = True
					view.FlatLook = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
			Next item
		End Sub
		#End Region

	End Class
End Namespace
