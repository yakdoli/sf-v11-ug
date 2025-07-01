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
Imports System.Windows.Forms
Imports System.Resources
Imports System.Reflection
Imports System.IO
Imports Syncfusion.Scripting
Imports Syncfusion.Scripting.Design
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls


Namespace Syncfusion.Windows.Forms.Diagram.Samples.Scripting
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class MainForm
		Inherits Form
		#Region "Fields"
		Private m_strFileName As String
		Private promptOnSave As Boolean = True
		Private mload As Boolean = True
		#End Region

		#Region "Form Controls"

		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents runToolStripButton As System.Windows.Forms.ToolStripButton
		Private ImageList As System.Windows.Forms.ImageList
		Private groupBarItemTestSymbols As Tools.GroupBarItem
		Private openFileDialog1 As OpenFileDialog
		Private saveFileDialog1 As SaveFileDialog
		Private resStringMgr As ResourceManager = Nothing
		Private imagrList1 As ImageList
		Private components As System.ComponentModel.IContainer = Nothing
		Private panel1 As Panel
		Private WithEvents edittToolStripButton As ToolStripButton
		Private WithEvents stopToolStripButton As ToolStripButton
		Private panel2 As Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Model
		Private panel4 As Panel
		Private scriptingMgr As ScriptingManager
		#End Region

		#Region "Initialize\finalize methods"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.diagram1.Model = Me.model1

			Me.StartPosition = FormStartPosition.CenterScreen
			'
			' Create resource manager for strings
			'
			Me.resStringMgr = New ResourceManager("Strings", GetType(MainForm).Assembly)

			' Setup the Diagram control for scripting capability
			Me.InitializeScriptingManager()

			'
			' Set default filename
			'
			Me.FileName = "Diagram1"
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.groupBarItemTestSymbols = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.runToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.edittToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.stopToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
            Me.imagrList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.panel2 = New System.Windows.Forms.Panel
            Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel4 = New System.Windows.Forms.Panel
            Me.toolStrip1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupBarItemTestSymbols
            '
            Me.groupBarItemTestSymbols.Client = Nothing
            Me.groupBarItemTestSymbols.Text = "Test Symbols"
            '
            'toolStrip1
            '
            Me.toolStrip1.AutoSize = False
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripButton, Me.runToolStripButton, Me.edittToolStripButton, Me.stopToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(630, 77)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'openToolStripButton
            '
            Me.openToolStripButton.AutoSize = False
            Me.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
            Me.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.openToolStripButton.Name = "openToolStripButton"
            Me.openToolStripButton.Size = New System.Drawing.Size(100, 60)
            Me.openToolStripButton.Text = "Open Script"
            Me.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'runToolStripButton
            '
            Me.runToolStripButton.AutoSize = False
            Me.runToolStripButton.Image = CType(resources.GetObject("runToolStripButton.Image"), System.Drawing.Image)
            Me.runToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.runToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.runToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.runToolStripButton.Name = "runToolStripButton"
            Me.runToolStripButton.Size = New System.Drawing.Size(100, 60)
            Me.runToolStripButton.Text = "Run Script"
            Me.runToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.runToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'edittToolStripButton
            '
            Me.edittToolStripButton.AutoSize = False
            Me.edittToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.edittToolStripButton.Image = CType(resources.GetObject("edittToolStripButton.Image"), System.Drawing.Image)
            Me.edittToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.edittToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.edittToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.edittToolStripButton.Name = "edittToolStripButton"
            Me.edittToolStripButton.Size = New System.Drawing.Size(100, 60)
            Me.edittToolStripButton.Text = "Edit Script"
            Me.edittToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.edittToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'stopToolStripButton
            '
            Me.stopToolStripButton.AutoSize = False
            Me.stopToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.stopToolStripButton.Image = CType(resources.GetObject("stopToolStripButton.Image"), System.Drawing.Image)
            Me.stopToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.stopToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.stopToolStripButton.Name = "stopToolStripButton"
            Me.stopToolStripButton.Size = New System.Drawing.Size(100, 60)
            Me.stopToolStripButton.Text = "Stop Script"
            Me.stopToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.stopToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'openFileDialog1
            '
            Me.openFileDialog1.DefaultExt = "edp"
            Me.openFileDialog1.Filter = "Essential Diagram Files|*.edd|All files|*.*"
            Me.openFileDialog1.Title = "Open Diagram"
            '
            'saveFileDialog1
            '
            Me.saveFileDialog1.DefaultExt = "edp"
            Me.saveFileDialog1.Filter = "Essential Diagram Files|*.edd|All files|*.*"
            Me.saveFileDialog1.Title = "Save Diagram"
            '
            'imagrList1
            '
            Me.imagrList1.ImageStream = CType(resources.GetObject("imagrList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imagrList1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imagrList1.Images.SetKeyName(0, "")
            Me.imagrList1.Images.SetKeyName(1, "")
            Me.imagrList1.Images.SetKeyName(2, "")
            Me.imagrList1.Images.SetKeyName(3, "")
            Me.imagrList1.Images.SetKeyName(4, "palette_groupbar.png")
            Me.imagrList1.Images.SetKeyName(5, "property_editor.png")
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.panel1.Controls.Add(Me.toolStrip1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(630, 77)
            Me.panel1.TabIndex = 0
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.paletteGroupBar1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 77)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(215, 416)
            Me.panel2.TabIndex = 1
            '
            'paletteGroupBar1
            '
            Me.paletteGroupBar1.AllowDrop = True
            Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
            Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.paletteGroupBar1.Diagram = Nothing
            Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.paletteGroupBar1.EditMode = False
            Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
            Me.paletteGroupBar1.FlatLook = True
            Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
            Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
            Me.paletteGroupBar1.GroupBarItemHeight = 32
            Me.paletteGroupBar1.IndexOnVisibleItems = True
            Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 0)
            Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
            Me.paletteGroupBar1.Name = "paletteGroupBar1"
            Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
            Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.paletteGroupBar1.Size = New System.Drawing.Size(215, 416)
            Me.paletteGroupBar1.TabIndex = 1
            Me.paletteGroupBar1.Text = "paletteGroupBar1"
            Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
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
            Me.diagram1.Size = New System.Drawing.Size(415, 416)
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
            Me.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center
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
            'panel4
            '
            Me.panel4.Controls.Add(Me.diagram1)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel4.Location = New System.Drawing.Point(215, 77)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(415, 416)
            Me.panel4.TabIndex = 3
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(8, 17)
            Me.ClientSize = New System.Drawing.Size(630, 493)
            Me.Controls.Add(Me.panel4)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Scripting"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			' Register scripting engines
			ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.VisualBasic, GetType(Microsoft.VisualBasic.Vsa.VsaEngine))
			ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.JScript, GetType(Microsoft.JScript.Vsa.VsaEngine))
			Application.Run(New MainForm())
		End Sub


		#Region "Properties"
		''' <summary>
		''' Name of the File
		''' </summary>
		Private Property FileName() As String
			Get
				Return m_strFileName
			End Get
			Set(ByVal value As String)
				m_strFileName = value
				Dim title As String = resStringMgr.GetString("MainFormTitle")
				Dim docName As String = Path.GetFileNameWithoutExtension(m_strFileName)

			End Set
		End Property
		#End Region

		#Region "Event handlers"

		Private Sub openToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click
			If Me.scriptingMgr IsNot Nothing Then
				Me.scriptingMgr.ApplicationBase = New DirectoryInfo(GetAssembliesPath()).FullName
			End If

			Dim fileDlg As New OpenFileDialog()
			fileDlg.InitialDirectory = Application.StartupPath


			If fileDlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Dim sourceFile As String = fileDlg.FileName
				Me.scriptingMgr.LoadScript(sourceFile)
			End If
		End Sub

		Private Sub runToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles runToolStripButton.Click
			If Me.scriptingMgr IsNot Nothing Then
				Me.scriptingMgr.ApplicationBase = New DirectoryInfo(GetAssembliesPath()).FullName
			End If

			Dim compiled As Boolean = Me.scriptingMgr.CompileScript()

			If compiled Then
				Me.scriptingMgr.RunScript()
			End If

		End Sub

		Private Sub edittToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles edittToolStripButton.Click
			' Create the ScriptEditControl and initialize it with the diagram's ScriptingManager instance
			Dim scripteditform As New ScriptEditForm()
			Dim scriptedit As ScriptEditControl = scripteditform.ScriptEditControl
			scriptedit.InitializeScriptEditor(Me.scriptingMgr)
			' Disable external compilation
			scriptedit.EnableExternalCompile = True
			' Show the ScriptEditForm as a modal dialog
			scripteditform.ShowDialog(Me)
			scripteditform.Dispose()
		End Sub

		Private Sub stopToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles stopToolStripButton.Click
			If Me.scriptingMgr.IsScriptRunning Then
				Me.scriptingMgr.ResetScriptEngine()
			End If
		End Sub

		Private Sub helpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim targetURL As String = "http://help.syncfusion.com/"
			System.Diagnostics.Process.Start(targetURL)
		End Sub

		Private Sub infoToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			If Me.mload Then
				Me.mload = False
				MessageBoxAdv.Office2007Theme = Office2007Theme.Blue
				MessageBoxAdv.Show("Press the Run Button and drag and drop a Symbol from the Symbol Palette", "Essential Diagram Scripting",MessageBoxButtons.OK, MessageBoxIcon.Information)
				Me.Activate()
			End If
		End Sub
		Private Sub scriptingMgr_CompileError(ByVal sender As Object, ByVal evtArgs As VsaErrorEventArgs)
			System.Diagnostics.Trace.WriteLine("Error compiling script: " & evtArgs.Error.Description)
		End Sub
		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			DiagramAppearance()
			Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Test Symbol.edp")
			GroupBarAppearance()
		End Sub

		#End Region

		#Region "private Methods"
		''' <summary>
		''' Change's the appearance of GroupBar
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
		''' Change's the appearance of Diagram control
		''' </summary>
		Private Sub DiagramAppearance()
			diagram1.Model.LineStyle.LineWidth = 0
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.SelectionList.Clear()

		End Sub
		#End Region

		#Region "Helper methods"
		''' <summary>
		''' Opens the diagram file
		''' </summary>
		Private Sub OpenFile()
			If Me.openFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Me.FileName = Me.openFileDialog1.FileName
				Dim fi As New FileInfo(Me.FileName)

				If fi.Extension = ".xml" Then
					Me.diagram1.LoadSoap(Me.FileName)
				ElseIf fi.Extension = ".edd" Then
					Me.diagram1.LoadBinary(Me.FileName)
				End If
				Me.promptOnSave = False
				Me.diagram1.Refresh()
			End If
		End Sub

		''' <summary>
		''' Saves the Diagram 
		''' </summary>
		Private Sub SaveFile()
			If Me.promptOnSave Then
				Me.saveFileDialog1.FileName = Me.m_strFileName

				If Me.saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					Me.FileName = Me.saveFileDialog1.FileName
					Me.diagram1.SaveSoap(Me.FileName)
				End If
				Me.promptOnSave = False
			Else
				Me.diagram1.SaveSoap(Me.m_strFileName)
			End If
		End Sub

		''' <summary>
		''' Saves the Daigram file
		''' </summary>
		Private Sub SaveFileAs()
			Me.saveFileDialog1.FileName = Me.m_strFileName

			If Me.saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Me.FileName = Me.saveFileDialog1.FileName
				Me.diagram1.SaveSoap(Me.FileName)
			End If
		End Sub

		''' <summary>
		''' Set up scripting support by creating and initializing the DiagramScriptSite and ScriptingManager
		''' </summary>
		Private Sub InitializeScriptingManager()
			Me.scriptingMgr = New ScriptingManager(New DiagramScriptSite(Me.diagram1), New DiagramScript())
			Dim exepath As String = Application.ExecutablePath.ToLower()
			Dim testscriptpath As String = exepath.Substring(0, exepath.IndexOf("scripting\cs")) & "scripting\cs\_TESTSCRIPT\testscript.cs"
			Me.scriptingMgr.Script.Language = ScriptLanguages.CSharp
			Me.scriptingMgr.LoadScript(testscriptpath)
			AddHandler scriptingMgr.CompileError, AddressOf scriptingMgr_CompileError
		End Sub

		''' <summary>
		''' Gets the Assembly path
		''' </summary>
		''' <returns>returns the path of the assembly</returns>
		Private Shared Function GetAssembliesPath() As String
			Dim assembliesfolder As String = GetNETVersion()
			Dim exepath As String = Application.ExecutablePath.ToLower()
			Dim subpath As String = exepath.Substring(0, exepath.IndexOf("scripting.exe"))
			Dim assembliespath As String = subpath
			'subpath + "\\precompiledassemblies\\" + subpath.Substring(subpath.LastIndexOf('\\')+1) + "\\" + assembliesfolder;
			Return assembliespath
		End Function

		''' <summary>
		''' Gets the .NET Framework version
		''' </summary>
		''' <returns>returns the .NET Framework version</returns>
		Private Shared Function GetNETVersion() As String
			Dim assemblies() As System.Reflection.Assembly = AppDomain.CurrentDomain.GetAssemblies()
			For Each assmbly As System.Reflection.Assembly In assemblies
				Dim location As String = assmbly.Location
				If location.IndexOf("mscorlib.dll") >= 0 Then
					If location.IndexOf("v1.0") >= 0 Then
						Return "1.0"
					ElseIf location.IndexOf("v1.1") >= 0 Then
						Return "1.1"
					Else
						Return "2.0"
					End If
				End If
			Next assmbly
			Return "1.1"
		End Function

		#End Region        

	End Class
End Namespace
