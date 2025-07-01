Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Threading
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace LocalizationDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
#If SyncfusionFramework2_0 Then
        Inherits Office2007Form
#Else
		Inherits Form
#End If
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private menuList As System.Windows.Forms.ImageList
		Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private textBox1 As System.Windows.Forms.TextBox
		Private tabbedMDIManager As TabbedMDIManager
		Private ribbon As RibbonControlAdv
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'

			Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("de-DE")

			InitializeComponent()

			Me.tabbedMDIManager = New TabbedMDIManager()
			Me.tabbedMDIManager.AttachToMdiContainer(Me)
			Me.tabbedMDIManager.TabStyle = GetType(TabRendererOffice2007)
			Me.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007



            Me.mainFrameBarManager1.InternalDocking = False

            Dim targetPath As String = Application.StartupPath & "\" & "de-DE"
            Dim sourceFile As String = System.IO.Path.GetFullPath("..\..\de-DE\Syncfusion.Tools.Windows.resources.dll")
            If Not System.IO.Directory.Exists(targetPath) Then
                System.IO.Directory.CreateDirectory(targetPath)
                System.IO.File.Copy(sourceFile, targetPath & "\Syncfusion.Tools.Windows.resources.dll")
                sourceFile = System.IO.Path.GetFullPath("..\..\de-DE\Syncfusion.Shared.Base.resources.dll")
                System.IO.File.Copy(sourceFile, targetPath & "\Syncfusion.Shared.Base.resources.dll")
            End If


			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
		Friend WithEvents ParentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Friend WithEvents MdiListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
		Friend WithEvents DropDownBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Friend WithEvents PopupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Friend WithEvents ColorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ccbtextBox1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Hauptmenu")
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.DropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.PopupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.ColorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.MdiListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Standard")
            Me.menuList = New System.Windows.Forms.ImageList(Me.components)
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar
            Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupControlContainer1.SuspendLayout()
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockingManager1
            '
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dockingManager1.SetDockLabel(Me.textBox1, "Localization")
            ccbtextBox1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.textBox1, ccbtextBox1)
            '
            'textBox1
            '
            Me.dockingManager1.SetEnableDocking(Me.textBox1, True)
            Me.textBox1.Location = New System.Drawing.Point(3, 23)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(326, 426)
            Me.textBox1.TabIndex = 5
            Me.textBox1.Text = "This Sample shows the Localization of Syncfusion Menus, Docking Manager, GroupBar" & _
                " and ColorUIPicker."
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("Edit")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Me.menuList
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem3, Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem10, Me.parentBarItem4, Me.barItem4, Me.barItem5, Me.barItem6, Me.barItem7, Me.barItem8, Me.parentBarItem5, Me.barItem9, Me.ParentBarItem6, Me.MdiListBarItem1, Me.DropDownBarItem1})
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "Hauptmenu"
            Me.bar1.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "Hauptmenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem3, Me.parentBarItem4, Me.parentBarItem5, Me.ParentBarItem6})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 0
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "&File"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem10, Me.barItem4})
            Me.parentBarItem3.SeparatorIndices.AddRange(New Integer() {2, 4})
            Me.parentBarItem3.Text = "&Akte"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "&New"
            Me.barItem1.ImageIndex = 0
            Me.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.barItem1.Text = "&Neu"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "&Open"
            Me.barItem2.ImageIndex = 1
            Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.barItem2.Text = "Geoffnet"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "&Save"
            Me.barItem3.ImageIndex = 2
            Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.barItem3.Text = "Auber"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 0
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.ID = "Save &As.."
            Me.barItem10.Text = "Auber wie.."
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "E&xit"
            Me.barItem4.ImageIndex = 3
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.AltF4
            Me.barItem4.Text = "Ausgang"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 1
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "&Edit"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem5, Me.barItem6, Me.barItem7, Me.DropDownBarItem1, Me.barItem8})
            Me.parentBarItem4.SeparatorIndices.AddRange(New Integer() {4})
            Me.parentBarItem4.Text = "&Redigieren Sie"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 1
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Cu&t"
            Me.barItem5.ImageIndex = 4
            Me.barItem5.Text = "Redigieren"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 1
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "&Copy"
            Me.barItem6.ImageIndex = 5
            Me.barItem6.Text = "&Copy"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 1
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "&Paste"
            Me.barItem7.ImageIndex = 6
            Me.barItem7.Text = "&Paste"
            '
            'DropDownBarItem1
            '
            Me.DropDownBarItem1.CategoryIndex = 1
            Me.DropDownBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DropDownBarItem1.ID = "ColorPick"
            Me.DropDownBarItem1.PopupControlContainer = Me.PopupControlContainer1
            Me.DropDownBarItem1.Text = "Farbe wahlen"
            '
            'PopupControlContainer1
            '
            Me.PopupControlContainer1.Controls.Add(Me.ColorUIControl1)
            Me.PopupControlContainer1.Location = New System.Drawing.Point(240, 72)
            Me.PopupControlContainer1.Name = "PopupControlContainer1"
            Me.PopupControlContainer1.Size = New System.Drawing.Size(168, 176)
            Me.PopupControlContainer1.TabIndex = 8
            Me.PopupControlContainer1.Visible = False
            '
            'ColorUIControl1
            '
            Me.ColorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ColorUIControl1.Location = New System.Drawing.Point(0, 0)
            Me.ColorUIControl1.Name = "ColorUIControl1"
            Me.ColorUIControl1.Size = New System.Drawing.Size(168, 176)
            Me.ColorUIControl1.TabIndex = 0
            Me.ColorUIControl1.Text = "ColorUIControl1"
            Me.ColorUIControl1.UserTabName = "User Colors"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 1
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "Select &All"
            Me.barItem8.Text = "Alle vorwahlen"
            '
            'parentBarItem5
            '
            Me.parentBarItem5.CategoryIndex = 2
            Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem5.ID = "&Help"
            Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem9})
            Me.parentBarItem5.Text = "&Hilfe"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 2
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "A&bout..."
            Me.barItem9.Text = "Uber..."
            '
            'ParentBarItem6
            '
            Me.ParentBarItem6.CategoryIndex = 2
            Me.ParentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem6.ID = "Fenster"
            Me.ParentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.MdiListBarItem1})
            Me.ParentBarItem6.Text = "Fenster"
            '
            'MdiListBarItem1
            '
            Me.MdiListBarItem1.CategoryIndex = 2
            Me.MdiListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MdiListBarItem1.ID = "Window List"
            '
            'bar2
            '
            Me.bar2.BarName = "Standard"
            Me.bar2.Caption = "Standard"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3})
            Me.bar2.Manager = Me.mainFrameBarManager1
            Me.bar2.SeparatorIndices.AddRange(New Integer() {2})
            '
            'menuList
            '
            Me.menuList.ImageStream = CType(resources.GetObject("menuList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.menuList.TransparentColor = System.Drawing.Color.Transparent
            Me.menuList.Images.SetKeyName(0, "")
            Me.menuList.Images.SetKeyName(1, "")
            Me.menuList.Images.SetKeyName(2, "")
            Me.menuList.Images.SetKeyName(3, "")
            Me.menuList.Images.SetKeyName(4, "")
            Me.menuList.Images.SetKeyName(5, "")
            Me.menuList.Images.SetKeyName(6, "")
            '
            'parentBarItem1
            '
            Me.parentBarItem1.ID = "Item"
            Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.parentBarItem1.Text = "Item"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.ID = "ParentBarItem"
            Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.parentBarItem2.Text = "ParentBarItem"
            '
            'groupBar1
            '
            Me.groupBar1.AllowDrop = True
            Me.groupBar1.AnimatedSelection = False
            Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand
            Me.groupBar1.GroupBarItemHeight = 30
            Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() {Me.groupBarItem1, Me.groupBarItem2, Me.groupBarItem3})
            Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBar1.Location = New System.Drawing.Point(0, 51)
            Me.groupBar1.Name = "groupBar1"
            Me.groupBar1.SelectedItem = 2
            Me.groupBar1.Size = New System.Drawing.Size(192, 427)
            Me.groupBar1.StackedMode = True
            Me.groupBar1.TabIndex = 4
            Me.groupBar1.Text = "groupBar1"
            Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'groupBarItem1
            '
            Me.groupBarItem1.Client = Nothing
            Me.groupBarItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBarItem1.Image = CType(resources.GetObject("groupBarItem1.Image"), System.Drawing.Image)
            Me.groupBarItem1.LargeImageMode = True
            Me.groupBarItem1.Text = "Journal"
            '
            'groupBarItem2
            '
            Me.groupBarItem2.Client = Nothing
            Me.groupBarItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBarItem2.Image = CType(resources.GetObject("groupBarItem2.Image"), System.Drawing.Image)
            Me.groupBarItem2.LargeImageMode = True
            Me.groupBarItem2.Text = "Kalendar"
            '
            'groupBarItem3
            '
            Me.groupBarItem3.Client = Nothing
            Me.groupBarItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBarItem3.Image = CType(resources.GetObject("groupBarItem3.Image"), System.Drawing.Image)
            Me.groupBarItem3.LargeImageMode = True
            Me.groupBarItem3.Text = "Kontakte"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(688, 478)
            Me.Controls.Add(Me.PopupControlContainer1)
            Me.Controls.Add(Me.groupBar1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Lokalisation-Demo (Syncfusion Inc.)"
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupControlContainer1.ResumeLayout(False)
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread()> _
		Public Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
			Dim frm As Child = New Child()
			frm.MdiParent = Me
			frm.Text = "Dokument " & count.ToString()
			frm.Show()
			count += 1
		End Sub

		Private Shared count As Integer = 1
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim frm As Child = New Child()
			frm.MdiParent = Me
			frm.Text = "Dokument " & count.ToString()
			frm.Show()
			count += 1
		End Sub

        Private Sub barItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barItem4.Click
            Application.Exit()
        End Sub
    End Class
End Namespace
