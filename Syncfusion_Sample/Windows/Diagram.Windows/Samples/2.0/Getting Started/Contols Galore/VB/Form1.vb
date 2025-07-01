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
		Private panel3 As Panel
		Private propertyEditor1 As PropertyEditor
		Private panel4 As Panel
		Private diagram1 As Diagram
		Private model1 As Model
		Private panel2 As Panel
		Private paletteGroupBar1 As PaletteGroupBar
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Class Initialize/Finalize methods"
		''' <summary>
		''' Default Applcation constructor.
		''' </summary>
		Public Sub New()
			' The Syncfusion.Windows.Forms.Diagram.ControlNode and Syncfusion.Windows.Forms.Diagram.ActivateStyle types 
			' have been moved from the Syncfusion.Diagram.Base to the Syncfusion.Diagram.Windows assembly.
			' The following binding information is required to correctly resolve the ControlNode and ActivateStyle types.
			Dim controlnodebinding As String = "Syncfusion.Windows.Forms.Diagram.ControlNodeSyncfusion.Diagram.Base"
			Dim activatestylebinding As String = "Syncfusion.Windows.Forms.Diagram.ActivateStyleSyncfusion.Diagram.Base"
			Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder.TypeNamesVsAssembly.Add(controlnodebinding.ToLower(), GetType(Diagram).Assembly)
			Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder.TypeNamesVsAssembly.Add(activatestylebinding.ToLower(), GetType(Diagram).Assembly)

			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.diagram1.Model = Me.model1

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
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel3.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel4.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panel1.Size = New System.Drawing.Size(1002, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Control Galore"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.propertyEditor1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panel3.Location = New System.Drawing.Point(764, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(240, 423)
			Me.panel3.TabIndex = 0
			' 
			' propertyEditor1
			' 
			Me.propertyEditor1.Diagram = Me.diagram1
			Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyEditor1.Location = New System.Drawing.Point(0, 0)
			Me.propertyEditor1.Name = "propertyEditor1"
			Me.propertyEditor1.Size = New System.Drawing.Size(240, 423)
			Me.propertyEditor1.TabIndex = 0
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.paletteGroupBar1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(2, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(200, 423)
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
			Me.paletteGroupBar1.Size = New System.Drawing.Size(200, 423)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.diagram1)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(202, 72)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(562, 423)
			Me.panel4.TabIndex = 2
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
			Me.diagram1.Size = New System.Drawing.Size(562, 423)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
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
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(1006, 497)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Controls Galore"
'			Me.Load += New System.EventHandler(Me.MainForm_Load)
			Me.panel3.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel4.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
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

		#Region "Class Public Methods"
		#End Region

		#Region "File Menu Handlers"
		''' <summary>
		''' Open diagram menu item.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Open diagram
			If Me.openDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Me.OpenFile(Me.openDiagramDialog.FileName)
				Me.diagram1.Refresh()
			End If
		End Sub

		''' <summary>
		''' Save diagram menu item.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Save diagram
			Dim docForm As Diagram = Me.diagram1
			If docForm IsNot Nothing Then
				If Me.saveDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					Dim fileName As String = Me.saveDiagramDialog.FileName
					Dim oStream As FileStream

					Try
						oStream = New FileStream(fileName, FileMode.Create)
					Catch ex As Exception
						oStream = Nothing ' just to be sure
						MessageBox.Show("Error opening " & fileName & " - " & ex.Message)
					End Try

					If oStream IsNot Nothing Then
						Try
							Me.diagram1.SaveBinary(oStream)
						Catch ex As Exception
							MessageBox.Show("Serialization error - " & ex.Message)
						Finally
							oStream.Close()
						End Try
					End If
				End If
			End If
		End Sub

		''' <summary>
		''' Exit diagram menu item.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Application.Exit()
		End Sub

		''' <summary>
		''' Close diagram menu item.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.Controller.Delete()
			Me.diagram1.Model.Clear()
			Me.diagram1.Refresh()
		End Sub
		#End Region

		#Region "Links Menu Handlers"
		''' <summary>
		''' Create LinkTool
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemLink_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.ActivateTool("LineLinkTool")
		End Sub

		''' <summary>
		''' Create OrthogonalLink tool.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemOrthogonalLink_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.ActivateTool("OrthogonalLinkTool")
		End Sub

		''' <summary>
		''' Create DirectedlineLink tool.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemDirectedlineLink_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.ActivateTool("DirectedLineLinkTool")
		End Sub

		''' <summary>
		''' Create ArcLink tool.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemArcLink_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.ActivateTool("SplineTool")
		End Sub

		#End Region

		#Region "Edit Menu Handlers"
		''' <summary>
		''' Copy selection nodes.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim diagram As Diagram = Me.diagram1
			If diagram IsNot Nothing Then
				diagram.Controller.Copy()
			End If
		End Sub

		''' <summary>
		''' Cut selection nodes.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemCut_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim diagram As Diagram = Me.diagram1
			If diagram IsNot Nothing Then
				diagram.Controller.Cut()
			End If
		End Sub

		''' <summary>
		''' Paste saved nodes.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub menuItemPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim diagram As Diagram = Me.diagram1
			If diagram IsNot Nothing Then
				diagram.Controller.Paste()
			End If
		End Sub

		#End Region

		#Region "Helper methods"
		''' <summary>
		''' Open diagram file in sample.
		''' </summary>
		''' <param name="fileName"></param>
		Public Sub OpenFile(ByVal fileName As String)
			Using iStream As New FileStream(fileName, FileMode.OpenOrCreate)
				diagram1.LoadBinary(iStream)
			End Using
		End Sub
		Private Sub LoadDocument()
			InsertTextNode()
			InsertTreeNode()
			InsertButton()
		End Sub
		Private Sub LoadPalette()
			Dim pal As New SymbolPalette()
			pal.Name = "ControlNodes"
			Dim btn As New ButtonAdv()
			btn.Text = "Button Node"
			btn.UseVisualStyle = True
			btn.UseVisualStyleBackColor = True
			btn.Office2007ColorScheme = Office2007Theme.Blue
			btn.Appearance = ButtonAppearance.Office2007

			Dim ctrlnode As New ControlNode(btn, New RectangleF(100, 100, 125, 50))
			ctrlnode.Name = "Button Node"
			pal.AppendChild(ctrlnode)

			Dim txtBox As New TextBox()
			txtBox.Multiline = True
			txtBox.Text = "This is text in a TextBox"

			ctrlnode = New ControlNode(txtBox, New RectangleF(100, 100, 140, 50))
			ctrlnode.Name = "Text Node"
			pal.AppendChild(ctrlnode)

			' ListBox
			ctrlnode = New ListBoxControNode()
			ctrlnode.Name = "ListBox Node"
			pal.AppendChild(ctrlnode)

			paletteGroupBar1.AddPalette(pal)
			paletteGroupBar1.FlatLook = True
		End Sub
		Private Sub InsertTextNode()
			Dim txtBox As New TextBox()
			txtBox.Multiline = True
			txtBox.Text = "This is text in a TextNode"

			Dim ctrlnode As New ControlNode(txtBox, New RectangleF(100, 30, 140, 50))
			ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough
			Me.diagram1.Model.AppendChild(ctrlnode)
		End Sub
		Private Sub InsertButton()
			Dim btn As New ButtonAdv()
			btn.Text = "Click to activate me"
			btn.UseVisualStyle = True
			btn.UseVisualStyleBackColor = True
			btn.Office2007ColorScheme = Office2007Theme.Blue
			btn.Appearance = ButtonAppearance.Office2007
			AddHandler btn.Click, AddressOf btn_Click

			Dim ctrlnode As New ControlNode(btn, New RectangleF(100, 200, 150, 50))
			ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough
			Me.diagram1.Model.AppendChild(ctrlnode)
		End Sub
		Private Sub InsertTreeNode()
			Dim ctrlTree As New TreeView()
			ctrlTree.Nodes.AddRange(New TreeNode() { New TreeNode("QuickSolutions", 7, 7, New TreeNode() { New TreeNode("Solution 1", 3, 3), New TreeNode("Solution 2", 4, 4), New TreeNode("Trial", 5, 5), New TreeNode("Clerks", 5, 5), New TreeNode("WorkIssue", 6, 6) }), New TreeNode("BG Group", 4, 4, New TreeNode() { New TreeNode("Office1", 4, 4, New TreeNode() { New TreeNode("Clients") }) }), New TreeNode("XYZ Org", 8, 8, New TreeNode() { New TreeNode("Contacts", 3, 3), New TreeNode("Referrals") }), New TreeNode("XYZ Sales", 5, 5), New TreeNode("BetaSoft", 7, 7), New TreeNode("MicroCorp", 6, 6, New TreeNode() { New TreeNode("Sales 1", 6, 6), New TreeNode("Sales 2", 6, 6), New TreeNode("Complaints", 4, 4) }) })

			Dim ctrlnode As New ControlNode(ctrlTree, New RectangleF(340, 200, 180, 100))
			ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough
			Me.diagram1.Model.AppendChild(ctrlnode)
		End Sub
		#End Region

		#Region "Class events"
		''' <summary>
		''' Load sample pallete.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			LoadDocument()
			LoadPalette()
			GroupBarAppearance()
			diagram1.View.SelectionList.Clear()

		End Sub
		''' <summary>
		''' Change's the Appearance of Diagram 
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Office2007ScrollBars = True
			Me.diagram1.View.SelectionList.Clear()

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
					view.BackColor = Color.White
					view.TextWrap = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
			Next item

		End Sub
		''' <summary>
		''' Delete selection nodes.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub barItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing Then
				Me.diagram1.Controller.Delete()
			End If
		End Sub

		''' <summary>
		''' Use the ControlNodeTool to create a ControlNode initialized with a Windows Forms TextBox control
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub miInsertTextBox_Click(ByVal sender As Object, ByVal e As EventArgs)
			InsertTextNode()
		End Sub

		''' <summary>
		''' Use the ControlNodeTool to create a ControlNode that initialized with a Windows Forms Button control
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub miInsertButton_Click_2(ByVal sender As Object, ByVal e As EventArgs)
			InsertButton()
		End Sub
		''' <summary>
		''' Show control button action on click.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
			MessageBoxAdv.Office2007Theme = Office2007Theme.Blue
			MessageBoxAdv.Show("I am all wired up!", "Controls Galore", MessageBoxButtons.OK,MessageBoxIcon.Information)
		End Sub
		#End Region

	End Class
End Namespace
