Imports Microsoft.VisualBasic
Imports System
Namespace EssentialBlocks
	Public Partial Class BlocksForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridBaseStyle5 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle6 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle7 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle8 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlocksForm))
            Me._mainFrameBarManager = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.mainBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me._mainFrameBarManager, "Main Menu")
            Me.fileParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.newGameBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.showNextPieceItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pauseBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.exitBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.helpParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.howToPlayBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.aboutBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.gridBoard = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.statusBarAdv1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdv
            Me.progressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.nextPiecePanel = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label2 = New System.Windows.Forms.Label
            Me.progressBarWaiting = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv
            CType(Me._mainFrameBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridBoard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.statusBarAdv1.SuspendLayout()
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nextPiecePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_mainFrameBarManager
            '
            Me._mainFrameBarManager.BarPositionInfo = CType(resources.GetObject("_mainFrameBarManager.BarPositionInfo"), System.IO.MemoryStream)
            Me._mainFrameBarManager.Bars.Add(Me.mainBar)
            Me._mainFrameBarManager.Categories.Add("File")
            Me._mainFrameBarManager.Categories.Add("Game Control")
            Me._mainFrameBarManager.Categories.Add("Help")
            Me._mainFrameBarManager.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me._mainFrameBarManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._mainFrameBarManager.Form = Me
            Me._mainFrameBarManager.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.fileParentBarItem, Me.exitBarItem, Me.newGameBarItem, Me.pauseBarItem, Me.helpParentBarItem, Me.aboutBarItem, Me.howToPlayBarItem, Me.showNextPieceItem})
            Me._mainFrameBarManager.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me._mainFrameBarManager.ResetCustomization = False
            Me._mainFrameBarManager.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            '
            'mainBar
            '
            Me.mainBar.BarName = "Main Menu"
            Me.mainBar.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.mainBar.Caption = "Main Menu"
            Me.mainBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.fileParentBarItem, Me.helpParentBarItem})
            Me.mainBar.Manager = Me._mainFrameBarManager
            '
            'fileParentBarItem
            '
            Me.fileParentBarItem.CategoryIndex = 0
            Me.fileParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fileParentBarItem.ID = "&File"
            Me.fileParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.newGameBarItem, Me.showNextPieceItem, Me.pauseBarItem, Me.exitBarItem})
            Me.fileParentBarItem.SeparatorIndices.AddRange(New Integer() {3})
            Me.fileParentBarItem.Text = "&File"
            '
            'newGameBarItem
            '
            Me.newGameBarItem.CategoryIndex = 0
            Me.newGameBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.newGameBarItem.ID = "&New Game"
            Me.newGameBarItem.Text = "&New Game"
            '
            'showNextPieceItem
            '
            Me.showNextPieceItem.CategoryIndex = 0
            Me.showNextPieceItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.showNextPieceItem.ID = "Show Next Piece"
            Me.showNextPieceItem.Text = "Show Next Piece"
            '
            'pauseBarItem
            '
            Me.pauseBarItem.CategoryIndex = 1
            Me.pauseBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pauseBarItem.ID = "&Pause Game"
            Me.pauseBarItem.Text = "&Pause Game"
            '
            'exitBarItem
            '
            Me.exitBarItem.CategoryIndex = 0
            Me.exitBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exitBarItem.ID = "E&xit"
            Me.exitBarItem.Text = "E&xit"
            '
            'helpParentBarItem
            '
            Me.helpParentBarItem.CategoryIndex = 2
            Me.helpParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.helpParentBarItem.ID = "&Help"
            Me.helpParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.howToPlayBarItem, Me.aboutBarItem})
            Me.helpParentBarItem.Text = "&Help"
            '
            'howToPlayBarItem
            '
            Me.howToPlayBarItem.CategoryIndex = 2
            Me.howToPlayBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.howToPlayBarItem.ID = "How to &Play"
            Me.howToPlayBarItem.Shortcut = System.Windows.Forms.Shortcut.F1
            Me.howToPlayBarItem.Text = "How to &Play"
            '
            'aboutBarItem
            '
            Me.aboutBarItem.CategoryIndex = 2
            Me.aboutBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.aboutBarItem.ID = "&About"
            Me.aboutBarItem.Text = "&About"
            '
            'gridBoard
            '
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.CellType = "Static"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.CellType = "Static"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle4.Name = "Header"
            GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.CellType = "Static"
            GridBaseStyle4.StyleInfo.Font.Bold = True
            GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridBoard.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridBoard.ColCount = 8
            Me.gridBoard.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 32), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 31), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 31), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 31), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 30), New Syncfusion.Windows.Forms.Grid.GridColWidth(6, 31), New Syncfusion.Windows.Forms.Grid.GridColWidth(7, 28), New Syncfusion.Windows.Forms.Grid.GridColWidth(8, 31)})
            Me.gridBoard.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridBoard.ForeColor = System.Drawing.SystemColors.ControlText
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            Me.gridBoard.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
            Me.gridBoard.Location = New System.Drawing.Point(15, 34)
            Me.gridBoard.Name = "gridBoard"
            Me.gridBoard.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.gridBoard.Properties.ColHeaders = False
            Me.gridBoard.Properties.GridLineColor = System.Drawing.SystemColors.Control
            Me.gridBoard.Properties.RowHeaders = False
            Me.gridBoard.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridBoard.RowCount = 20
            Me.gridBoard.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21), New Syncfusion.Windows.Forms.Grid.GridRowHeight(18, 19)})
            Me.gridBoard.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
            Me.gridBoard.Size = New System.Drawing.Size(282, 365)
            Me.gridBoard.SmartSizeBox = False
            Me.gridBoard.TabIndex = 4
            '
            'gameTimer
            '
            Me.gameTimer.Interval = 500
            '
            'gridControl1
            '
            GridBaseStyle5.Name = "Row Header"
            GridBaseStyle5.StyleInfo.BaseStyle = "Header"
            GridBaseStyle5.StyleInfo.CellType = "Static"
            GridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle6.Name = "Column Header"
            GridBaseStyle6.StyleInfo.BaseStyle = "Header"
            GridBaseStyle6.StyleInfo.CellType = "Static"
            GridBaseStyle6.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle7.Name = "Standard"
            GridBaseStyle7.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle8.Name = "Header"
            GridBaseStyle8.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.CellType = "Static"
            GridBaseStyle8.StyleInfo.Font.Bold = True
            GridBaseStyle8.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle8.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle5, GridBaseStyle6, GridBaseStyle7, GridBaseStyle8})
            Me.gridControl1.ColCount = 5
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 31), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 28), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 28), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 28), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 28)})
            Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
            GridCellInfo2.Col = -1
            GridCellInfo2.Row = -1
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo2})
            Me.gridControl1.Location = New System.Drawing.Point(250, 249)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowCount = 5
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.Size = New System.Drawing.Size(180, 146)
            Me.gridControl1.SmartSizeBox = False
            '
            'statusBarAdv1
            '
            Me.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.statusBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.statusBarAdv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.statusBarAdv1.Controls.Add(Me.progressBarAdv1)
            Me.statusBarAdv1.Controls.Add(Me.label1)
            Me.statusBarAdv1.CustomLayoutBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.statusBarAdv1.Location = New System.Drawing.Point(0, 398)
            Me.statusBarAdv1.Name = "statusBarAdv1"
            Me.statusBarAdv1.Padding = New System.Windows.Forms.Padding(3)
            Me.statusBarAdv1.Size = New System.Drawing.Size(277, 22)
            Me.statusBarAdv1.SizingGrip = False
            Me.statusBarAdv1.Spacing = New System.Drawing.Size(2, 2)
            Me.statusBarAdv1.TabIndex = 5
            '
            'progressBarAdv1
            '
            Me.progressBarAdv1.BackColor = System.Drawing.Color.White
            Me.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv1.BackMultipleColors = New System.Drawing.Color(-1) {}
            Me.progressBarAdv1.BackSegments = False
            Me.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner
            Me.progressBarAdv1.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.progressBarAdv1.CustomWaitingRender = False
            Me.progressBarAdv1.FontColor = System.Drawing.Color.White
            Me.progressBarAdv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.progressBarAdv1.ForegroundImage = Nothing
            Me.progressBarAdv1.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.progressBarAdv1.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(7, Byte), Integer))
            Me.progressBarAdv1.Location = New System.Drawing.Point(0, 2)
            Me.progressBarAdv1.Maximum = 13
            Me.progressBarAdv1.MultipleColors = New System.Drawing.Color(-1) {}
            Me.progressBarAdv1.Name = "progressBarAdv1"
            Me.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv1.SegmentWidth = 13
            Me.progressBarAdv1.Size = New System.Drawing.Size(195, 16)
            Me.progressBarAdv1.TabIndex = 1
            Me.progressBarAdv1.Text = "progressBarAdv1"
            Me.progressBarAdv1.TextVisible = False
            Me.progressBarAdv1.ThemesEnabled = False
            Me.progressBarAdv1.TubeEndColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.progressBarAdv1.TubeStartColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(7, Byte), Integer))
            Me.progressBarAdv1.Value = 1
            Me.progressBarAdv1.WaitingGradientWidth = 400
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.SystemColors.Window
            Me.label1.Location = New System.Drawing.Point(197, 2)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(65, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Score: 0000"
            '
            'nextPiecePanel
            '
            Me.nextPiecePanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.nextPiecePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nextPiecePanel.Location = New System.Drawing.Point(277, 64)
            Me.nextPiecePanel.Name = "nextPiecePanel"
            Me.nextPiecePanel.Size = New System.Drawing.Size(128, 87)
            Me.nextPiecePanel.TabIndex = 6
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.White
            Me.label2.Location = New System.Drawing.Point(275, 39)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(64, 14)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Next Piece"
            '
            'progressBarWaiting
            '
            Me.progressBarWaiting.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.progressBarWaiting.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.progressBarWaiting.BackGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.progressBarWaiting.BackMultipleColors = New System.Drawing.Color(-1) {}
            Me.progressBarWaiting.BackSegments = False
            Me.progressBarWaiting.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarWaiting.BackTubeStartColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.progressBarWaiting.BorderColor = System.Drawing.Color.Black
            Me.progressBarWaiting.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.progressBarWaiting.CustomWaitingRender = False
            Me.progressBarWaiting.FontColor = System.Drawing.Color.White
            Me.progressBarWaiting.ForegroundImage = Nothing
            Me.progressBarWaiting.ForeSegments = False
            Me.progressBarWaiting.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(7, Byte), Integer))
            Me.progressBarWaiting.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.progressBarWaiting.Location = New System.Drawing.Point(277, 52)
            Me.progressBarWaiting.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Thistle, System.Drawing.Color.Blue}
            Me.progressBarWaiting.Name = "progressBarWaiting"
            Me.progressBarWaiting.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient
            Me.progressBarWaiting.SegmentWidth = 12
            Me.progressBarWaiting.Size = New System.Drawing.Size(130, 3)
            Me.progressBarWaiting.TabIndex = 8
            Me.progressBarWaiting.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom
            Me.progressBarWaiting.ThemesEnabled = False
            Me.progressBarWaiting.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarWaiting.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarWaiting.Value = 100
            Me.progressBarWaiting.WaitingGradientEnabled = True
            Me.progressBarWaiting.WaitingGradientInterval = 25
            Me.progressBarWaiting.WaitingGradientWidth = 600
            '
            'BlocksForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(277, 420)
            Me.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me.Controls.Add(Me.progressBarWaiting)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.nextPiecePanel)
            Me.Controls.Add(Me.gridBoard)
            Me.Controls.Add(Me.statusBarAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "BlocksForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Essential Blocks Demo"
            CType(Me._mainFrameBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridBoard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.statusBarAdv1.ResumeLayout(False)
            Me.statusBarAdv1.PerformLayout()
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nextPiecePanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarWaiting, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private _mainFrameBarManager As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private mainBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private fileParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents exitBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents newGameBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents pauseBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents gridBoard As Syncfusion.Windows.Forms.Grid.GridControl
		Private WithEvents gameTimer As System.Windows.Forms.Timer
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private statusBarAdv1 As Syncfusion.Windows.Forms.Tools.StatusBarAdv
		Private label1 As System.Windows.Forms.Label
		Private progressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
		Private helpParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents aboutBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents howToPlayBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private nextPiecePanel As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label2 As System.Windows.Forms.Label
		Private progressBarWaiting As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
		Private WithEvents showNextPieceItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
	End Class
End Namespace

