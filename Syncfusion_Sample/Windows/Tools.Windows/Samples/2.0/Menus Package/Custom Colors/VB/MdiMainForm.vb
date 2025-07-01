#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace Tutorial
	''' <summary>
	''' Summary description for MdiMainForm.
	''' </summary>
	Public Class MdiMainForm : Inherits System.Windows.Forms.Form
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private imageList As System.Windows.Forms.ImageList
		Private largeImageList As System.Windows.Forms.ImageList
		Private WithEvents newItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents cascadeItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents tileHorz As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents tileVert As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private mdiListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
        Private WithEvents closeItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private mainMenuBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private standardBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private StylebarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			SetGradientColors()
			DrawBackground()

            AddHandler mainFrameBarManager1.DrawDockBarBackground, AddressOf mainFrameBarManager1_DrawDockBarBackground
            mainFrameBarManager1.RegisterMdiChildTypes(New Type() {GetType(MdiChildForm)})

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiMainForm))
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.mainMenuBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.newItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.closeItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.cascadeItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.tileHorz = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.tileVert = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.mdiListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
            Me.standardBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Standard")
            Me.imageList = New System.Windows.Forms.ImageList(Me.components)
            Me.StylebarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.mainMenuBar)
            Me.mainFrameBarManager1.Bars.Add(Me.standardBar)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("Window")
            Me.mainFrameBarManager1.Categories.Add("Popups")
            Me.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Me.imageList
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.newItem, Me.cascadeItem, Me.tileHorz, Me.tileVert, Me.parentBarItem1, Me.parentBarItem2, Me.mdiListBarItem1, Me.closeItem, Me.StylebarItem})
            Me.mainFrameBarManager1.LargeImageList = Me.largeImageList
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.[Default]
            '
            'mainMenuBar
            '
            Me.mainMenuBar.BarName = "MainMenu"
            Me.mainMenuBar.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.mainMenuBar.Caption = "MainMenu"
            Me.mainMenuBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2})
            Me.mainMenuBar.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 2
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.newItem, Me.closeItem})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {1})
            Me.parentBarItem1.Text = "&File"
            '
            'newItem
            '
            Me.newItem.CategoryIndex = 0
            Me.newItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.newItem.ID = "New"
            Me.newItem.ImageIndex = 1
            Me.newItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.newItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.newItem.Text = "New"
            '
            'closeItem
            '
            Me.closeItem.CategoryIndex = 0
            Me.closeItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.closeItem.ID = "Close"
            Me.closeItem.MergeOrder = 4
            Me.closeItem.Text = "Close"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 2
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Window"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.cascadeItem, Me.tileHorz, Me.tileVert, Me.mdiListBarItem1})
            Me.parentBarItem2.MergeOrder = 20
            Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItem2.Text = "&Window"
            '
            'cascadeItem
            '
            Me.cascadeItem.CategoryIndex = 1
            Me.cascadeItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cascadeItem.ID = "Cascade"
            Me.cascadeItem.ImageIndex = 3
            Me.cascadeItem.Text = "Cascade"
            '
            'tileHorz
            '
            Me.tileHorz.CategoryIndex = 1
            Me.tileHorz.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tileHorz.ID = "Tile"
            Me.tileHorz.ImageIndex = 4
            Me.tileHorz.Text = "Tile Horizontal"
            '
            'tileVert
            '
            Me.tileVert.CategoryIndex = 1
            Me.tileVert.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tileVert.ID = "Tile Vertical"
            Me.tileVert.ImageIndex = 5
            Me.tileVert.Text = "Tile Vertical"
            '
            'mdiListBarItem1
            '
            Me.mdiListBarItem1.CategoryIndex = 1
            Me.mdiListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mdiListBarItem1.ID = "Window List"
            '
            'standardBar
            '
            Me.standardBar.BarName = "Standard"
            Me.standardBar.BarStyle = CType((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.standardBar.Caption = "Standard"
            Me.standardBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.newItem})
            Me.standardBar.Manager = Me.mainFrameBarManager1
            '
            'imageList
            '
            Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList.Images.SetKeyName(0, "")
            Me.imageList.Images.SetKeyName(1, "")
            Me.imageList.Images.SetKeyName(2, "")
            Me.imageList.Images.SetKeyName(3, "")
            Me.imageList.Images.SetKeyName(4, "")
            Me.imageList.Images.SetKeyName(5, "")
            '
            'StylebarItem
            '
            Me.StylebarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StylebarItem.ID = "_1"
            '
            'largeImageList
            '
            Me.largeImageList.ImageStream = CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.largeImageList.Images.SetKeyName(0, "")
            Me.largeImageList.Images.SetKeyName(1, "")
            Me.largeImageList.Images.SetKeyName(2, "")
            '
            'MdiMainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.ClientSize = New System.Drawing.Size(624, 446)
            Me.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "MdiMainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Custom Colors"
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New MdiMainForm())
		End Sub

		#Region "Click events"
		Private count As Integer = 1
		Private Sub newItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles newItem.Click
			Dim childForm1 As MdiChildForm = New MdiChildForm()
			childForm1.Text = "Child " & count.ToString()
			childForm1.MdiParent = Me
			AddHandler childForm1.Closed, AddressOf child_closing
			childForm1.Show()
			count += 1

			DrawBackground()
		End Sub

		Private Sub child_closing(ByVal sender As Object, ByVal e As System.EventArgs)
			DrawBackground()
		End Sub

		Private Sub tileHorz_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileHorz.Click
			Me.LayoutMdi(MdiLayout.TileHorizontal)
		End Sub

		Private Sub tileVert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileVert.Click
			Me.LayoutMdi(MdiLayout.TileVertical)
		End Sub

		Private Sub cascadeItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cascadeItem.Click
			Me.LayoutMdi(MdiLayout.Cascade)
		End Sub
		#End Region

		#Region "Colors"
		Private Sub SetGradientColors()
            MenuColors.SelColor = Color.FromArgb(179, 71, 59)
            MenuColors.SelTextColor = Color.White
			MenuColors.SelBorderColor = Color.FromArgb(183, 214, 242)
			MenuColors.MenuBGColor = Color.White
			MenuColors.MenuLeftStripColor = Color.White
			MenuColors.DropDownBorderColor = Color.FromArgb(166, 205, 226)
			MenuColors.PressedSelColor = Color.FromArgb(166, 201, 232)
			MenuColors.CheckedSelColor = Color.FromArgb(215, 236, 255)
            MenuColors.FloatingCommandBarCaptionColor = Color.FromArgb(183, 214, 242)
        End Sub

        Private Sub DrawBackground()
            Dim bar As bar
            For Each bar In mainFrameBarManager1.Bars
                AddHandler bar.DrawBackground, AddressOf bar_DrawBackground
            Next bar
        End Sub

#End Region

		#Region "DrawEvents"
		Private Sub bar_DrawBackground(ByVal sender As Object, ByVal e As PaintEventArgs)
			Dim bar As Bar = CType(sender, Bar)
			Dim rect As Rectangle = e.ClipRectangle

            Dim commandBarExt As commandBarExt = CType(mainFrameBarManager1.GetBarControl(bar), commandBarExt)
            If (bar.BarName = "Standard") Then
                commandBarExt.BackColor = Color.FromArgb(169, 192, 236)
            Else
                commandBarExt.BackColor = SystemColors.ControlLight
            End If

            '  Paint with 'image' brush

            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), rect)
        End Sub

        Private Sub mainFrameBarManager1_DrawDockBarBackground(ByVal sender As Object, ByVal args As DockBarPaintEventArgs)
            '			Image image = new Bitmap(@"..\\..\\Menu_Connector.png");
            '			TextureBrush texture = new TextureBrush(image);
            '			args.PaintEventArgs.Graphics.FillRectangle(texture,args.PaintEventArgs.ClipRectangle);
            args.PaintEventArgs.Graphics.FillRectangle(New SolidBrush(Color.White), args.PaintEventArgs.ClipRectangle)
        End Sub
#End Region

        Private Sub MdiMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim form As New MdiChildForm()
            form.MdiParent = Me
            form.Show()
            DrawBackground()
        End Sub

        Private Sub closeItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeItem.Click
            Application.Exit()
        End Sub
    End Class
End Namespace
