Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Namespace PivotGridLibrary
	Public Partial Class PivotGridControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PivotGridControl))
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle5 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle6 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle7 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle8 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle9 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle10 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle11 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle12 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle13 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle14 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle15 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle16 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle17 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle18 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle19 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle20 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle6 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle7 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle8 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle9 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle10 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridBaseStyle21 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle22 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle23 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle24 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridRangeStyle11 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle12 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle13 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle14 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle15 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle16 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle17 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle18 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle19 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle20 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridBaseStyle25 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle26 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle27 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle28 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridRangeStyle21 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle22 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle23 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle24 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle25 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle26 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle27 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle28 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle29 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle30 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridBaseStyle29 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle30 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle31 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle32 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridRangeStyle31 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle32 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle33 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle34 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle35 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle36 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle37 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle38 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle39 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle40 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridBaseStyle33 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle34 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle35 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridBaseStyle36 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim GridRangeStyle41 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle42 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle43 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle44 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle45 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle46 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle47 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle48 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle49 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Dim GridRangeStyle50 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Me.panelLeft = New System.Windows.Forms.Panel()
            Me.panelColumns = New System.Windows.Forms.Panel()
            Me.pictureBoxCollapsed = New System.Windows.Forms.PictureBox()
            Me.pictureBoxExpanded = New System.Windows.Forms.PictureBox()
            Me.labelColumns = New System.Windows.Forms.Label()
            Me.gridMainColumns = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.panelGrid = New System.Windows.Forms.Panel()
            Me.labelGrid = New System.Windows.Forms.Label()
            Me.gridMainDisplay = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.panelRows = New System.Windows.Forms.Panel()
            Me.labelRows = New System.Windows.Forms.Label()
            Me.gridMainRows = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.panelFilter = New System.Windows.Forms.Panel()
            Me.labelFilter = New System.Windows.Forms.Label()
            Me.gridMainFilters = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.panelRight = New System.Windows.Forms.Panel()
            Me.panelRB = New System.Windows.Forms.Panel()
            Me.pictureBox4 = New System.Windows.Forms.PictureBox()
            Me.pictureBox3 = New System.Windows.Forms.PictureBox()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.buttonUpdate = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.checkBoxDeferLayout = New System.Windows.Forms.CheckBox()
            Me.labelValues = New System.Windows.Forms.Label()
            Me.labelRowLabel = New System.Windows.Forms.Label()
            Me.labelColumnLabel = New System.Windows.Forms.Label()
            Me.labelReportFilter = New System.Windows.Forms.Label()
            Me.labelDragFields = New System.Windows.Forms.Label()
            Me.splitter2 = New System.Windows.Forms.Splitter()
            Me.panelRT = New System.Windows.Forms.Panel()
            Me.labelChooseFields = New System.Windows.Forms.Label()
            Me.labelPivotTableFieldList = New System.Windows.Forms.Label()
            Me.gridValues = New PivotGridLibrary.GridList()
            Me.gridRows = New PivotGridLibrary.GridList()
            Me.gridColumns = New PivotGridLibrary.GridList()
            Me.gridFilter = New PivotGridLibrary.GridList()
            Me.gridFields = New PivotGridLibrary.GridList()
            Me.panelLeft.SuspendLayout()
            Me.panelColumns.SuspendLayout()
            CType(Me.pictureBoxCollapsed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBoxExpanded, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridMainColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelGrid.SuspendLayout()
            CType(Me.gridMainDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelRows.SuspendLayout()
            CType(Me.gridMainRows, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelFilter.SuspendLayout()
            CType(Me.gridMainFilters, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelRight.SuspendLayout()
            Me.panelRB.SuspendLayout()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelRT.SuspendLayout()
            CType(Me.gridValues, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridRows, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridFilter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridFields, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelLeft
            '
            Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panelLeft.Controls.Add(Me.panelColumns)
            Me.panelLeft.Controls.Add(Me.panelGrid)
            Me.panelLeft.Controls.Add(Me.panelRows)
            Me.panelLeft.Controls.Add(Me.panelFilter)
            Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelLeft.Location = New System.Drawing.Point(0, 0)
            Me.panelLeft.Name = "panelLeft"
            Me.panelLeft.Size = New System.Drawing.Size(475, 566)
            Me.panelLeft.TabIndex = 0
            '
            'panelColumns
            '
            Me.panelColumns.Controls.Add(Me.pictureBoxCollapsed)
            Me.panelColumns.Controls.Add(Me.pictureBoxExpanded)
            Me.panelColumns.Controls.Add(Me.labelColumns)
            Me.panelColumns.Controls.Add(Me.gridMainColumns)
            Me.panelColumns.Location = New System.Drawing.Point(100, 0)
            Me.panelColumns.Name = "panelColumns"
            Me.panelColumns.Size = New System.Drawing.Size(371, 86)
            Me.panelColumns.TabIndex = 2
            '
            'pictureBoxCollapsed
            '
            Me.pictureBoxCollapsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBoxCollapsed.BackColor = System.Drawing.Color.Transparent
            Me.pictureBoxCollapsed.Enabled = False
            Me.pictureBoxCollapsed.Image = CType(resources.GetObject("pictureBoxCollapsed.Image"), System.Drawing.Image)
            Me.pictureBoxCollapsed.Location = New System.Drawing.Point(352, 2)
            Me.pictureBoxCollapsed.Name = "pictureBoxCollapsed"
            Me.pictureBoxCollapsed.Size = New System.Drawing.Size(18, 18)
            Me.pictureBoxCollapsed.TabIndex = 4
            Me.pictureBoxCollapsed.TabStop = False
            Me.pictureBoxCollapsed.Visible = False
            '
            'pictureBoxExpanded
            '
            Me.pictureBoxExpanded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBoxExpanded.Image = CType(resources.GetObject("pictureBoxExpanded.Image"), System.Drawing.Image)
            Me.pictureBoxExpanded.Location = New System.Drawing.Point(352, 2)
            Me.pictureBoxExpanded.Name = "pictureBoxExpanded"
            Me.pictureBoxExpanded.Size = New System.Drawing.Size(18, 18)
            Me.pictureBoxExpanded.TabIndex = 3
            Me.pictureBoxExpanded.TabStop = False
            '
            'labelColumns
            '
            Me.labelColumns.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.labelColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelColumns.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelColumns.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelColumns.ForeColor = System.Drawing.Color.MidnightBlue
            Me.labelColumns.Location = New System.Drawing.Point(0, 0)
            Me.labelColumns.Name = "labelColumns"
            Me.labelColumns.Size = New System.Drawing.Size(371, 86)
            Me.labelColumns.TabIndex = 1
            Me.labelColumns.Text = "Drop Column Labels Here"
            Me.labelColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gridMainColumns
            '
            GridBaseStyle1.Name = "Header"
            GridBaseStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle1.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle1.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle1.StyleInfo.CellType = "Header"
            GridBaseStyle1.StyleInfo.Font.Bold = True
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle2.Name = "Standard"
            GridBaseStyle2.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle3.Name = "Row Header"
            GridBaseStyle3.StyleInfo.BaseStyle = "Header"
            GridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle4.Name = "Column Header"
            GridBaseStyle4.StyleInfo.BaseStyle = "Header"
            GridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridMainColumns.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridMainColumns.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridMainColumns.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridMainColumns.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridMainColumns.Location = New System.Drawing.Point(0, 0)
            Me.gridMainColumns.Name = "gridMainColumns"
            Me.gridMainColumns.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridMainColumns.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridMainColumns.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridMainColumns.Size = New System.Drawing.Size(371, 86)
            Me.gridMainColumns.SmartSizeBox = False
            Me.gridMainColumns.TabIndex = 2
            Me.gridMainColumns.Text = "gridControl1"
            Me.gridMainColumns.UseRightToLeftCompatibleTextBox = True
            '
            'panelGrid
            '
            Me.panelGrid.Controls.Add(Me.labelGrid)
            Me.panelGrid.Controls.Add(Me.gridMainDisplay)
            Me.panelGrid.Location = New System.Drawing.Point(100, 92)
            Me.panelGrid.Name = "panelGrid"
            Me.panelGrid.Size = New System.Drawing.Size(368, 473)
            Me.panelGrid.TabIndex = 4
            '
            'labelGrid
            '
            Me.labelGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.labelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelGrid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelGrid.ForeColor = System.Drawing.Color.MidnightBlue
            Me.labelGrid.Location = New System.Drawing.Point(0, 0)
            Me.labelGrid.Name = "labelGrid"
            Me.labelGrid.Size = New System.Drawing.Size(368, 473)
            Me.labelGrid.TabIndex = 1
            Me.labelGrid.Text = "Drag Values Here"
            Me.labelGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gridMainDisplay
            '
            GridBaseStyle5.Name = "Header"
            GridBaseStyle5.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle5.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle5.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle5.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle5.StyleInfo.CellType = "Header"
            GridBaseStyle5.StyleInfo.Font.Bold = True
            GridBaseStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle6.Name = "Standard"
            GridBaseStyle6.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle7.Name = "Row Header"
            GridBaseStyle7.StyleInfo.BaseStyle = "Header"
            GridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle8.Name = "Column Header"
            GridBaseStyle8.StyleInfo.BaseStyle = "Header"
            GridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridMainDisplay.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle5, GridBaseStyle6, GridBaseStyle7, GridBaseStyle8})
            Me.gridMainDisplay.ColCount = 1
            Me.gridMainDisplay.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridMainDisplay.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridMainDisplay.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridMainDisplay.Location = New System.Drawing.Point(0, 0)
            Me.gridMainDisplay.Name = "gridMainDisplay"
            Me.gridMainDisplay.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridMainDisplay.RowCount = 1
            Me.gridMainDisplay.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridMainDisplay.Size = New System.Drawing.Size(368, 473)
            Me.gridMainDisplay.SmartSizeBox = False
            Me.gridMainDisplay.TabIndex = 0
            Me.gridMainDisplay.Text = "gridDisplay"
            Me.gridMainDisplay.Visible = False
            '
            'panelRows
            '
            Me.panelRows.Controls.Add(Me.labelRows)
            Me.panelRows.Controls.Add(Me.gridMainRows)
            Me.panelRows.Location = New System.Drawing.Point(0, 92)
            Me.panelRows.Name = "panelRows"
            Me.panelRows.Size = New System.Drawing.Size(94, 473)
            Me.panelRows.TabIndex = 3
            '
            'labelRows
            '
            Me.labelRows.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.labelRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelRows.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelRows.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelRows.ForeColor = System.Drawing.Color.MidnightBlue
            Me.labelRows.Location = New System.Drawing.Point(0, 0)
            Me.labelRows.Name = "labelRows"
            Me.labelRows.Size = New System.Drawing.Size(94, 473)
            Me.labelRows.TabIndex = 2
            Me.labelRows.Text = "Drop Row Labels Here"
            Me.labelRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gridMainRows
            '
            GridBaseStyle9.Name = "Header"
            GridBaseStyle9.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle9.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle9.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle9.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle9.StyleInfo.CellType = "Header"
            GridBaseStyle9.StyleInfo.Font.Bold = True
            GridBaseStyle9.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle9.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle10.Name = "Standard"
            GridBaseStyle10.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle10.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle11.Name = "Row Header"
            GridBaseStyle11.StyleInfo.BaseStyle = "Header"
            GridBaseStyle11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle11.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle12.Name = "Column Header"
            GridBaseStyle12.StyleInfo.BaseStyle = "Header"
            GridBaseStyle12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridMainRows.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle9, GridBaseStyle10, GridBaseStyle11, GridBaseStyle12})
            Me.gridMainRows.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridMainRows.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridMainRows.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridMainRows.Location = New System.Drawing.Point(0, 0)
            Me.gridMainRows.Name = "gridMainRows"
            Me.gridMainRows.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridMainRows.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridMainRows.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridMainRows.Size = New System.Drawing.Size(94, 473)
            Me.gridMainRows.SmartSizeBox = False
            Me.gridMainRows.TabIndex = 2
            Me.gridMainRows.Text = "gridControl1"
            Me.gridMainRows.UseRightToLeftCompatibleTextBox = True
            '
            'panelFilter
            '
            Me.panelFilter.Controls.Add(Me.labelFilter)
            Me.panelFilter.Controls.Add(Me.gridMainFilters)
            Me.panelFilter.Location = New System.Drawing.Point(0, 0)
            Me.panelFilter.Name = "panelFilter"
            Me.panelFilter.Size = New System.Drawing.Size(94, 86)
            Me.panelFilter.TabIndex = 1
            '
            'labelFilter
            '
            Me.labelFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.labelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelFilter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelFilter.ForeColor = System.Drawing.Color.MidnightBlue
            Me.labelFilter.Location = New System.Drawing.Point(0, 0)
            Me.labelFilter.Name = "labelFilter"
            Me.labelFilter.Size = New System.Drawing.Size(94, 86)
            Me.labelFilter.TabIndex = 0
            Me.labelFilter.Text = "Drop Record Filters Here"
            Me.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gridMainFilters
            '
            GridBaseStyle13.Name = "Header"
            GridBaseStyle13.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle13.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle13.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle13.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle13.StyleInfo.CellType = "Header"
            GridBaseStyle13.StyleInfo.Font.Bold = True
            GridBaseStyle13.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle13.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle14.Name = "Standard"
            GridBaseStyle14.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle14.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle15.Name = "Row Header"
            GridBaseStyle15.StyleInfo.BaseStyle = "Header"
            GridBaseStyle15.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle15.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle16.Name = "Column Header"
            GridBaseStyle16.StyleInfo.BaseStyle = "Header"
            GridBaseStyle16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridMainFilters.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle13, GridBaseStyle14, GridBaseStyle15, GridBaseStyle16})
            Me.gridMainFilters.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridMainFilters.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridMainFilters.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridMainFilters.Location = New System.Drawing.Point(0, 0)
            Me.gridMainFilters.Name = "gridMainFilters"
            Me.gridMainFilters.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridMainFilters.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridMainFilters.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridMainFilters.Size = New System.Drawing.Size(94, 86)
            Me.gridMainFilters.SmartSizeBox = False
            Me.gridMainFilters.TabIndex = 2
            Me.gridMainFilters.Text = "gridControl1"
            Me.gridMainFilters.UseRightToLeftCompatibleTextBox = True
            '
            'splitter1
            '
            Me.splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(475, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 566)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'panelRight
            '
            Me.panelRight.Controls.Add(Me.panelRB)
            Me.panelRight.Controls.Add(Me.splitter2)
            Me.panelRight.Controls.Add(Me.panelRT)
            Me.panelRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelRight.Location = New System.Drawing.Point(478, 0)
            Me.panelRight.Name = "panelRight"
            Me.panelRight.Size = New System.Drawing.Size(306, 566)
            Me.panelRight.TabIndex = 2
            '
            'panelRB
            '
            Me.panelRB.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panelRB.Controls.Add(Me.pictureBox4)
            Me.panelRB.Controls.Add(Me.pictureBox3)
            Me.panelRB.Controls.Add(Me.pictureBox2)
            Me.panelRB.Controls.Add(Me.pictureBox1)
            Me.panelRB.Controls.Add(Me.buttonUpdate)
            Me.panelRB.Controls.Add(Me.checkBoxDeferLayout)
            Me.panelRB.Controls.Add(Me.labelValues)
            Me.panelRB.Controls.Add(Me.labelRowLabel)
            Me.panelRB.Controls.Add(Me.gridValues)
            Me.panelRB.Controls.Add(Me.gridRows)
            Me.panelRB.Controls.Add(Me.gridColumns)
            Me.panelRB.Controls.Add(Me.gridFilter)
            Me.panelRB.Controls.Add(Me.labelColumnLabel)
            Me.panelRB.Controls.Add(Me.labelReportFilter)
            Me.panelRB.Controls.Add(Me.labelDragFields)
            Me.panelRB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelRB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelRB.Location = New System.Drawing.Point(0, 256)
            Me.panelRB.Name = "panelRB"
            Me.panelRB.Size = New System.Drawing.Size(306, 310)
            Me.panelRB.TabIndex = 2
            '
            'pictureBox4
            '
            Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
            Me.pictureBox4.Location = New System.Drawing.Point(165, 155)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(18, 18)
            Me.pictureBox4.TabIndex = 16
            Me.pictureBox4.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.ErrorImage = CType(resources.GetObject("pictureBox3.ErrorImage"), System.Drawing.Image)
            Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(10, 156)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(18, 18)
            Me.pictureBox3.TabIndex = 15
            Me.pictureBox3.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(165, 28)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(18, 18)
            Me.pictureBox2.TabIndex = 14
            Me.pictureBox2.TabStop = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(10, 27)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(18, 18)
            Me.pictureBox1.TabIndex = 13
            Me.pictureBox1.TabStop = False
            '
            'buttonUpdate
            '
            Me.buttonUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonUpdate.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonUpdate.Enabled = False
            Me.buttonUpdate.Location = New System.Drawing.Point(224, 283)
            Me.buttonUpdate.Name = "buttonUpdate"
            Me.buttonUpdate.Size = New System.Drawing.Size(75, 23)
            Me.buttonUpdate.TabIndex = 12
            Me.buttonUpdate.Text = "Update"
            Me.buttonUpdate.UseVisualStyle = True
            Me.buttonUpdate.UseVisualStyleBackColor = True
            '
            'checkBoxDeferLayout
            '
            Me.checkBoxDeferLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.checkBoxDeferLayout.AutoSize = True
            Me.checkBoxDeferLayout.Location = New System.Drawing.Point(10, 285)
            Me.checkBoxDeferLayout.Name = "checkBoxDeferLayout"
            Me.checkBoxDeferLayout.Size = New System.Drawing.Size(144, 17)
            Me.checkBoxDeferLayout.TabIndex = 11
            Me.checkBoxDeferLayout.Text = "Defer Layout Update"
            Me.checkBoxDeferLayout.UseVisualStyleBackColor = True
            '
            'labelValues
            '
            Me.labelValues.AutoSize = True
            Me.labelValues.Location = New System.Drawing.Point(193, 163)
            Me.labelValues.Name = "labelValues"
            Me.labelValues.Size = New System.Drawing.Size(45, 13)
            Me.labelValues.TabIndex = 10
            Me.labelValues.Text = "Values"
            '
            'labelRowLabel
            '
            Me.labelRowLabel.AutoSize = True
            Me.labelRowLabel.Location = New System.Drawing.Point(38, 163)
            Me.labelRowLabel.Name = "labelRowLabel"
            Me.labelRowLabel.Size = New System.Drawing.Size(71, 13)
            Me.labelRowLabel.TabIndex = 9
            Me.labelRowLabel.Text = "Row Labels"
            '
            'labelColumnLabel
            '
            Me.labelColumnLabel.AutoSize = True
            Me.labelColumnLabel.Location = New System.Drawing.Point(189, 33)
            Me.labelColumnLabel.Name = "labelColumnLabel"
            Me.labelColumnLabel.Size = New System.Drawing.Size(85, 13)
            Me.labelColumnLabel.TabIndex = 5
            Me.labelColumnLabel.Text = "Column Label"
            '
            'labelReportFilter
            '
            Me.labelReportFilter.AutoSize = True
            Me.labelReportFilter.Location = New System.Drawing.Point(34, 33)
            Me.labelReportFilter.Name = "labelReportFilter"
            Me.labelReportFilter.Size = New System.Drawing.Size(77, 13)
            Me.labelReportFilter.TabIndex = 4
            Me.labelReportFilter.Text = "Report Filter"
            '
            'labelDragFields
            '
            Me.labelDragFields.AutoSize = True
            Me.labelDragFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.labelDragFields.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelDragFields.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelDragFields.Location = New System.Drawing.Point(0, 0)
            Me.labelDragFields.MinimumSize = New System.Drawing.Size(306, 18)
            Me.labelDragFields.Name = "labelDragFields"
            Me.labelDragFields.Size = New System.Drawing.Size(306, 18)
            Me.labelDragFields.TabIndex = 3
            Me.labelDragFields.Text = "Drag fields between areas below:"
            '
            'splitter2
            '
            Me.splitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitter2.Location = New System.Drawing.Point(0, 253)
            Me.splitter2.Name = "splitter2"
            Me.splitter2.Size = New System.Drawing.Size(306, 3)
            Me.splitter2.TabIndex = 1
            Me.splitter2.TabStop = False
            '
            'panelRT
            '
            Me.panelRT.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panelRT.Controls.Add(Me.labelChooseFields)
            Me.panelRT.Controls.Add(Me.labelPivotTableFieldList)
            Me.panelRT.Controls.Add(Me.gridFields)
            Me.panelRT.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelRT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelRT.Location = New System.Drawing.Point(0, 0)
            Me.panelRT.Name = "panelRT"
            Me.panelRT.Size = New System.Drawing.Size(306, 253)
            Me.panelRT.TabIndex = 0
            '
            'labelChooseFields
            '
            Me.labelChooseFields.AutoSize = True
            Me.labelChooseFields.Location = New System.Drawing.Point(7, 26)
            Me.labelChooseFields.Name = "labelChooseFields"
            Me.labelChooseFields.Size = New System.Drawing.Size(183, 13)
            Me.labelChooseFields.TabIndex = 2
            Me.labelChooseFields.Text = "Choose fields to add to report:"
            '
            'labelPivotTableFieldList
            '
            Me.labelPivotTableFieldList.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.labelPivotTableFieldList.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelPivotTableFieldList.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelPivotTableFieldList.Location = New System.Drawing.Point(0, 0)
            Me.labelPivotTableFieldList.Name = "labelPivotTableFieldList"
            Me.labelPivotTableFieldList.Size = New System.Drawing.Size(306, 18)
            Me.labelPivotTableFieldList.TabIndex = 1
            Me.labelPivotTableFieldList.Text = "PivotTable Field List"
            Me.labelPivotTableFieldList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gridValues
            '
            Me.gridValues.AllowDragSelectedRows = True
            Me.gridValues.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            GridBaseStyle17.Name = "Header"
            GridBaseStyle17.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle17.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle17.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle17.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle17.StyleInfo.CellType = "Header"
            GridBaseStyle17.StyleInfo.Font.Bold = True
            GridBaseStyle17.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle17.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle18.Name = "Standard"
            GridBaseStyle18.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle18.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle19.Name = "Row Header"
            GridBaseStyle19.StyleInfo.BaseStyle = "Header"
            GridBaseStyle19.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle19.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle20.Name = "Column Header"
            GridBaseStyle20.StyleInfo.BaseStyle = "Header"
            GridBaseStyle20.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridValues.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle17, GridBaseStyle18, GridBaseStyle19, GridBaseStyle20})
            Me.gridValues.ColCount = 1
            Me.gridValues.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridValues.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridValues.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridValues.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridValues.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.gridValues.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridValues.HasCheckBox = False
            Me.gridValues.HasPaddedRow = True
            Me.gridValues.Location = New System.Drawing.Point(165, 179)
            Me.gridValues.Name = "gridValues"
            Me.gridValues.Office2007ScrollBars = True
            Me.gridValues.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.25!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle1.StyleInfo.Themed = True
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle2.StyleInfo.Font.Bold = False
            GridRangeStyle2.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 8.25!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.StyleInfo.Themed = True
            GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle3.StyleInfo.Font.Bold = False
            GridRangeStyle3.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle3.StyleInfo.Font.Italic = False
            GridRangeStyle3.StyleInfo.Font.Size = 8.25!
            GridRangeStyle3.StyleInfo.Font.Strikeout = False
            GridRangeStyle3.StyleInfo.Font.Underline = False
            GridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle3.StyleInfo.Themed = True
            GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle4.StyleInfo.Font.Bold = False
            GridRangeStyle4.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle4.StyleInfo.Font.Italic = False
            GridRangeStyle4.StyleInfo.Font.Size = 8.25!
            GridRangeStyle4.StyleInfo.Font.Strikeout = False
            GridRangeStyle4.StyleInfo.Font.Underline = False
            GridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle4.StyleInfo.Themed = True
            GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle5.StyleInfo.Font.Bold = False
            GridRangeStyle5.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle5.StyleInfo.Font.Italic = False
            GridRangeStyle5.StyleInfo.Font.Size = 8.25!
            GridRangeStyle5.StyleInfo.Font.Strikeout = False
            GridRangeStyle5.StyleInfo.Font.Underline = False
            GridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle5.StyleInfo.Themed = True
            GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle6.StyleInfo.Font.Bold = False
            GridRangeStyle6.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle6.StyleInfo.Font.Italic = False
            GridRangeStyle6.StyleInfo.Font.Size = 8.25!
            GridRangeStyle6.StyleInfo.Font.Strikeout = False
            GridRangeStyle6.StyleInfo.Font.Underline = False
            GridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle6.StyleInfo.Themed = True
            GridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle7.StyleInfo.Font.Bold = False
            GridRangeStyle7.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle7.StyleInfo.Font.Italic = False
            GridRangeStyle7.StyleInfo.Font.Size = 8.25!
            GridRangeStyle7.StyleInfo.Font.Strikeout = False
            GridRangeStyle7.StyleInfo.Font.Underline = False
            GridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle7.StyleInfo.Themed = True
            GridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle8.StyleInfo.Font.Bold = False
            GridRangeStyle8.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle8.StyleInfo.Font.Italic = False
            GridRangeStyle8.StyleInfo.Font.Size = 8.25!
            GridRangeStyle8.StyleInfo.Font.Strikeout = False
            GridRangeStyle8.StyleInfo.Font.Underline = False
            GridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle8.StyleInfo.Themed = True
            GridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle9.StyleInfo.Font.Bold = False
            GridRangeStyle9.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle9.StyleInfo.Font.Italic = False
            GridRangeStyle9.StyleInfo.Font.Size = 8.25!
            GridRangeStyle9.StyleInfo.Font.Strikeout = False
            GridRangeStyle9.StyleInfo.Font.Underline = False
            GridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle9.StyleInfo.Themed = True
            GridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle10.StyleInfo.Font.Bold = False
            GridRangeStyle10.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle10.StyleInfo.Font.Italic = False
            GridRangeStyle10.StyleInfo.Font.Size = 8.25!
            GridRangeStyle10.StyleInfo.Font.Strikeout = False
            GridRangeStyle10.StyleInfo.Font.Underline = False
            GridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle10.StyleInfo.Themed = True
            Me.gridValues.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6, GridRangeStyle7, GridRangeStyle8, GridRangeStyle9, GridRangeStyle10})
            Me.gridValues.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None
            Me.gridValues.RowCount = 1
            Me.gridValues.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridValues.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridValues.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridValues.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridValues.Size = New System.Drawing.Size(134, 99)
            Me.gridValues.SmartSizeBox = False
            Me.gridValues.TabIndex = 8
            Me.gridValues.ThemesEnabled = True
            Me.gridValues.UseRightToLeftCompatibleTextBox = True
            '
            'gridRows
            '
            Me.gridRows.AllowDragSelectedRows = True
            Me.gridRows.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            GridBaseStyle21.Name = "Header"
            GridBaseStyle21.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle21.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle21.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle21.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle21.StyleInfo.CellType = "Header"
            GridBaseStyle21.StyleInfo.Font.Bold = True
            GridBaseStyle21.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle21.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle22.Name = "Standard"
            GridBaseStyle22.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle22.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle23.Name = "Row Header"
            GridBaseStyle23.StyleInfo.BaseStyle = "Header"
            GridBaseStyle23.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle23.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle24.Name = "Column Header"
            GridBaseStyle24.StyleInfo.BaseStyle = "Header"
            GridBaseStyle24.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridRows.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle21, GridBaseStyle22, GridBaseStyle23, GridBaseStyle24})
            Me.gridRows.ColCount = 1
            Me.gridRows.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridRows.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridRows.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridRows.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridRows.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.gridRows.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridRows.HasCheckBox = False
            Me.gridRows.HasPaddedRow = True
            Me.gridRows.Location = New System.Drawing.Point(10, 179)
            Me.gridRows.Name = "gridRows"
            Me.gridRows.Office2007ScrollBars = True
            Me.gridRows.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            GridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle11.StyleInfo.Font.Bold = False
            GridRangeStyle11.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle11.StyleInfo.Font.Italic = False
            GridRangeStyle11.StyleInfo.Font.Size = 8.25!
            GridRangeStyle11.StyleInfo.Font.Strikeout = False
            GridRangeStyle11.StyleInfo.Font.Underline = False
            GridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle11.StyleInfo.Themed = True
            GridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle12.StyleInfo.Font.Bold = False
            GridRangeStyle12.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle12.StyleInfo.Font.Italic = False
            GridRangeStyle12.StyleInfo.Font.Size = 8.25!
            GridRangeStyle12.StyleInfo.Font.Strikeout = False
            GridRangeStyle12.StyleInfo.Font.Underline = False
            GridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle12.StyleInfo.Themed = True
            GridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle13.StyleInfo.Font.Bold = False
            GridRangeStyle13.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle13.StyleInfo.Font.Italic = False
            GridRangeStyle13.StyleInfo.Font.Size = 8.25!
            GridRangeStyle13.StyleInfo.Font.Strikeout = False
            GridRangeStyle13.StyleInfo.Font.Underline = False
            GridRangeStyle13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle13.StyleInfo.Themed = True
            GridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle14.StyleInfo.Font.Bold = False
            GridRangeStyle14.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle14.StyleInfo.Font.Italic = False
            GridRangeStyle14.StyleInfo.Font.Size = 8.25!
            GridRangeStyle14.StyleInfo.Font.Strikeout = False
            GridRangeStyle14.StyleInfo.Font.Underline = False
            GridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle14.StyleInfo.Themed = True
            GridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle15.StyleInfo.Font.Bold = False
            GridRangeStyle15.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle15.StyleInfo.Font.Italic = False
            GridRangeStyle15.StyleInfo.Font.Size = 8.25!
            GridRangeStyle15.StyleInfo.Font.Strikeout = False
            GridRangeStyle15.StyleInfo.Font.Underline = False
            GridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle15.StyleInfo.Themed = True
            GridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle16.StyleInfo.Font.Bold = False
            GridRangeStyle16.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle16.StyleInfo.Font.Italic = False
            GridRangeStyle16.StyleInfo.Font.Size = 8.25!
            GridRangeStyle16.StyleInfo.Font.Strikeout = False
            GridRangeStyle16.StyleInfo.Font.Underline = False
            GridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle16.StyleInfo.Themed = True
            GridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle17.StyleInfo.Font.Bold = False
            GridRangeStyle17.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle17.StyleInfo.Font.Italic = False
            GridRangeStyle17.StyleInfo.Font.Size = 8.25!
            GridRangeStyle17.StyleInfo.Font.Strikeout = False
            GridRangeStyle17.StyleInfo.Font.Underline = False
            GridRangeStyle17.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle17.StyleInfo.Themed = True
            GridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle18.StyleInfo.Font.Bold = False
            GridRangeStyle18.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle18.StyleInfo.Font.Italic = False
            GridRangeStyle18.StyleInfo.Font.Size = 8.25!
            GridRangeStyle18.StyleInfo.Font.Strikeout = False
            GridRangeStyle18.StyleInfo.Font.Underline = False
            GridRangeStyle18.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle18.StyleInfo.Themed = True
            GridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle19.StyleInfo.Font.Bold = False
            GridRangeStyle19.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle19.StyleInfo.Font.Italic = False
            GridRangeStyle19.StyleInfo.Font.Size = 8.25!
            GridRangeStyle19.StyleInfo.Font.Strikeout = False
            GridRangeStyle19.StyleInfo.Font.Underline = False
            GridRangeStyle19.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle19.StyleInfo.Themed = True
            GridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle20.StyleInfo.Font.Bold = False
            GridRangeStyle20.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle20.StyleInfo.Font.Italic = False
            GridRangeStyle20.StyleInfo.Font.Size = 8.25!
            GridRangeStyle20.StyleInfo.Font.Strikeout = False
            GridRangeStyle20.StyleInfo.Font.Underline = False
            GridRangeStyle20.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle20.StyleInfo.Themed = True
            Me.gridRows.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle11, GridRangeStyle12, GridRangeStyle13, GridRangeStyle14, GridRangeStyle15, GridRangeStyle16, GridRangeStyle17, GridRangeStyle18, GridRangeStyle19, GridRangeStyle20})
            Me.gridRows.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None
            Me.gridRows.RowCount = 1
            Me.gridRows.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridRows.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridRows.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridRows.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridRows.Size = New System.Drawing.Size(134, 99)
            Me.gridRows.SmartSizeBox = False
            Me.gridRows.TabIndex = 7
            Me.gridRows.ThemesEnabled = True
            Me.gridRows.UseRightToLeftCompatibleTextBox = True
            '
            'gridColumns
            '
            Me.gridColumns.AllowDragSelectedRows = True
            Me.gridColumns.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            GridBaseStyle25.Name = "Header"
            GridBaseStyle25.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle25.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle25.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle25.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle25.StyleInfo.CellType = "Header"
            GridBaseStyle25.StyleInfo.Font.Bold = True
            GridBaseStyle25.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle25.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle26.Name = "Standard"
            GridBaseStyle26.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle26.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle27.Name = "Row Header"
            GridBaseStyle27.StyleInfo.BaseStyle = "Header"
            GridBaseStyle27.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle27.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle28.Name = "Column Header"
            GridBaseStyle28.StyleInfo.BaseStyle = "Header"
            GridBaseStyle28.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridColumns.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle25, GridBaseStyle26, GridBaseStyle27, GridBaseStyle28})
            Me.gridColumns.ColCount = 1
            Me.gridColumns.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridColumns.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridColumns.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridColumns.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridColumns.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.gridColumns.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridColumns.HasCheckBox = False
            Me.gridColumns.HasPaddedRow = True
            Me.gridColumns.Location = New System.Drawing.Point(165, 51)
            Me.gridColumns.Name = "gridColumns"
            Me.gridColumns.Office2007ScrollBars = True
            Me.gridColumns.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            GridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle21.StyleInfo.Font.Bold = False
            GridRangeStyle21.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle21.StyleInfo.Font.Italic = False
            GridRangeStyle21.StyleInfo.Font.Size = 8.25!
            GridRangeStyle21.StyleInfo.Font.Strikeout = False
            GridRangeStyle21.StyleInfo.Font.Underline = False
            GridRangeStyle21.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle21.StyleInfo.Themed = True
            GridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle22.StyleInfo.Font.Bold = False
            GridRangeStyle22.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle22.StyleInfo.Font.Italic = False
            GridRangeStyle22.StyleInfo.Font.Size = 8.25!
            GridRangeStyle22.StyleInfo.Font.Strikeout = False
            GridRangeStyle22.StyleInfo.Font.Underline = False
            GridRangeStyle22.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle22.StyleInfo.Themed = True
            GridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle23.StyleInfo.Font.Bold = False
            GridRangeStyle23.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle23.StyleInfo.Font.Italic = False
            GridRangeStyle23.StyleInfo.Font.Size = 8.25!
            GridRangeStyle23.StyleInfo.Font.Strikeout = False
            GridRangeStyle23.StyleInfo.Font.Underline = False
            GridRangeStyle23.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle23.StyleInfo.Themed = True
            GridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle24.StyleInfo.Font.Bold = False
            GridRangeStyle24.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle24.StyleInfo.Font.Italic = False
            GridRangeStyle24.StyleInfo.Font.Size = 8.25!
            GridRangeStyle24.StyleInfo.Font.Strikeout = False
            GridRangeStyle24.StyleInfo.Font.Underline = False
            GridRangeStyle24.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle24.StyleInfo.Themed = True
            GridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle25.StyleInfo.Font.Bold = False
            GridRangeStyle25.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle25.StyleInfo.Font.Italic = False
            GridRangeStyle25.StyleInfo.Font.Size = 8.25!
            GridRangeStyle25.StyleInfo.Font.Strikeout = False
            GridRangeStyle25.StyleInfo.Font.Underline = False
            GridRangeStyle25.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle25.StyleInfo.Themed = True
            GridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle26.StyleInfo.Font.Bold = False
            GridRangeStyle26.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle26.StyleInfo.Font.Italic = False
            GridRangeStyle26.StyleInfo.Font.Size = 8.25!
            GridRangeStyle26.StyleInfo.Font.Strikeout = False
            GridRangeStyle26.StyleInfo.Font.Underline = False
            GridRangeStyle26.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle26.StyleInfo.Themed = True
            GridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle27.StyleInfo.Font.Bold = False
            GridRangeStyle27.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle27.StyleInfo.Font.Italic = False
            GridRangeStyle27.StyleInfo.Font.Size = 8.25!
            GridRangeStyle27.StyleInfo.Font.Strikeout = False
            GridRangeStyle27.StyleInfo.Font.Underline = False
            GridRangeStyle27.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle27.StyleInfo.Themed = True
            GridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle28.StyleInfo.Font.Bold = False
            GridRangeStyle28.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle28.StyleInfo.Font.Italic = False
            GridRangeStyle28.StyleInfo.Font.Size = 8.25!
            GridRangeStyle28.StyleInfo.Font.Strikeout = False
            GridRangeStyle28.StyleInfo.Font.Underline = False
            GridRangeStyle28.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle28.StyleInfo.Themed = True
            GridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle29.StyleInfo.Font.Bold = False
            GridRangeStyle29.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle29.StyleInfo.Font.Italic = False
            GridRangeStyle29.StyleInfo.Font.Size = 8.25!
            GridRangeStyle29.StyleInfo.Font.Strikeout = False
            GridRangeStyle29.StyleInfo.Font.Underline = False
            GridRangeStyle29.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle29.StyleInfo.Themed = True
            GridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle30.StyleInfo.Font.Bold = False
            GridRangeStyle30.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle30.StyleInfo.Font.Italic = False
            GridRangeStyle30.StyleInfo.Font.Size = 8.25!
            GridRangeStyle30.StyleInfo.Font.Strikeout = False
            GridRangeStyle30.StyleInfo.Font.Underline = False
            GridRangeStyle30.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle30.StyleInfo.Themed = True
            Me.gridColumns.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle21, GridRangeStyle22, GridRangeStyle23, GridRangeStyle24, GridRangeStyle25, GridRangeStyle26, GridRangeStyle27, GridRangeStyle28, GridRangeStyle29, GridRangeStyle30})
            Me.gridColumns.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None
            Me.gridColumns.RowCount = 1
            Me.gridColumns.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridColumns.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridColumns.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridColumns.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridColumns.Size = New System.Drawing.Size(134, 99)
            Me.gridColumns.SmartSizeBox = False
            Me.gridColumns.TabIndex = 6
            Me.gridColumns.ThemesEnabled = True
            Me.gridColumns.UseRightToLeftCompatibleTextBox = True
            '
            'gridFilter
            '
            Me.gridFilter.AllowDragSelectedRows = True
            Me.gridFilter.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            GridBaseStyle29.Name = "Header"
            GridBaseStyle29.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle29.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle29.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle29.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle29.StyleInfo.CellType = "Header"
            GridBaseStyle29.StyleInfo.Font.Bold = True
            GridBaseStyle29.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle29.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle30.Name = "Standard"
            GridBaseStyle30.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle30.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle31.Name = "Row Header"
            GridBaseStyle31.StyleInfo.BaseStyle = "Header"
            GridBaseStyle31.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle31.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle32.Name = "Column Header"
            GridBaseStyle32.StyleInfo.BaseStyle = "Header"
            GridBaseStyle32.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridFilter.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle29, GridBaseStyle30, GridBaseStyle31, GridBaseStyle32})
            Me.gridFilter.ColCount = 1
            Me.gridFilter.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridFilter.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridFilter.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridFilter.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridFilter.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.gridFilter.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridFilter.HasCheckBox = False
            Me.gridFilter.HasPaddedRow = True
            Me.gridFilter.Location = New System.Drawing.Point(10, 51)
            Me.gridFilter.Name = "gridFilter"
            Me.gridFilter.Office2007ScrollBars = True
            Me.gridFilter.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            GridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle31.StyleInfo.Font.Bold = False
            GridRangeStyle31.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle31.StyleInfo.Font.Italic = False
            GridRangeStyle31.StyleInfo.Font.Size = 8.25!
            GridRangeStyle31.StyleInfo.Font.Strikeout = False
            GridRangeStyle31.StyleInfo.Font.Underline = False
            GridRangeStyle31.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle31.StyleInfo.Themed = True
            GridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle32.StyleInfo.Font.Bold = False
            GridRangeStyle32.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle32.StyleInfo.Font.Italic = False
            GridRangeStyle32.StyleInfo.Font.Size = 8.25!
            GridRangeStyle32.StyleInfo.Font.Strikeout = False
            GridRangeStyle32.StyleInfo.Font.Underline = False
            GridRangeStyle32.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle32.StyleInfo.Themed = True
            GridRangeStyle33.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle33.StyleInfo.Font.Bold = False
            GridRangeStyle33.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle33.StyleInfo.Font.Italic = False
            GridRangeStyle33.StyleInfo.Font.Size = 8.25!
            GridRangeStyle33.StyleInfo.Font.Strikeout = False
            GridRangeStyle33.StyleInfo.Font.Underline = False
            GridRangeStyle33.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle33.StyleInfo.Themed = True
            GridRangeStyle34.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle34.StyleInfo.Font.Bold = False
            GridRangeStyle34.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle34.StyleInfo.Font.Italic = False
            GridRangeStyle34.StyleInfo.Font.Size = 8.25!
            GridRangeStyle34.StyleInfo.Font.Strikeout = False
            GridRangeStyle34.StyleInfo.Font.Underline = False
            GridRangeStyle34.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle34.StyleInfo.Themed = True
            GridRangeStyle35.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle35.StyleInfo.Font.Bold = False
            GridRangeStyle35.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle35.StyleInfo.Font.Italic = False
            GridRangeStyle35.StyleInfo.Font.Size = 8.25!
            GridRangeStyle35.StyleInfo.Font.Strikeout = False
            GridRangeStyle35.StyleInfo.Font.Underline = False
            GridRangeStyle35.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle35.StyleInfo.Themed = True
            GridRangeStyle36.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle36.StyleInfo.Font.Bold = False
            GridRangeStyle36.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle36.StyleInfo.Font.Italic = False
            GridRangeStyle36.StyleInfo.Font.Size = 8.25!
            GridRangeStyle36.StyleInfo.Font.Strikeout = False
            GridRangeStyle36.StyleInfo.Font.Underline = False
            GridRangeStyle36.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle36.StyleInfo.Themed = True
            GridRangeStyle37.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle37.StyleInfo.Font.Bold = False
            GridRangeStyle37.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle37.StyleInfo.Font.Italic = False
            GridRangeStyle37.StyleInfo.Font.Size = 8.25!
            GridRangeStyle37.StyleInfo.Font.Strikeout = False
            GridRangeStyle37.StyleInfo.Font.Underline = False
            GridRangeStyle37.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle37.StyleInfo.Themed = True
            GridRangeStyle38.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle38.StyleInfo.Font.Bold = False
            GridRangeStyle38.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle38.StyleInfo.Font.Italic = False
            GridRangeStyle38.StyleInfo.Font.Size = 8.25!
            GridRangeStyle38.StyleInfo.Font.Strikeout = False
            GridRangeStyle38.StyleInfo.Font.Underline = False
            GridRangeStyle38.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle38.StyleInfo.Themed = True
            GridRangeStyle39.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle39.StyleInfo.Font.Bold = False
            GridRangeStyle39.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle39.StyleInfo.Font.Italic = False
            GridRangeStyle39.StyleInfo.Font.Size = 8.25!
            GridRangeStyle39.StyleInfo.Font.Strikeout = False
            GridRangeStyle39.StyleInfo.Font.Underline = False
            GridRangeStyle39.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle39.StyleInfo.Themed = True
            GridRangeStyle40.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle40.StyleInfo.Font.Bold = False
            GridRangeStyle40.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle40.StyleInfo.Font.Italic = False
            GridRangeStyle40.StyleInfo.Font.Size = 8.25!
            GridRangeStyle40.StyleInfo.Font.Strikeout = False
            GridRangeStyle40.StyleInfo.Font.Underline = False
            GridRangeStyle40.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle40.StyleInfo.Themed = True
            Me.gridFilter.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle31, GridRangeStyle32, GridRangeStyle33, GridRangeStyle34, GridRangeStyle35, GridRangeStyle36, GridRangeStyle37, GridRangeStyle38, GridRangeStyle39, GridRangeStyle40})
            Me.gridFilter.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None
            Me.gridFilter.RowCount = 1
            Me.gridFilter.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridFilter.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridFilter.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridFilter.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridFilter.Size = New System.Drawing.Size(134, 99)
            Me.gridFilter.SmartSizeBox = False
            Me.gridFilter.TabIndex = 3
            Me.gridFilter.ThemesEnabled = True
            Me.gridFilter.UseRightToLeftCompatibleTextBox = True
            '
            'gridFields
            '
            Me.gridFields.AllowDragSelectedRows = True
            Me.gridFields.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.gridFields.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            GridBaseStyle33.Name = "Header"
            GridBaseStyle33.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle33.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle33.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle33.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle33.StyleInfo.CellType = "Header"
            GridBaseStyle33.StyleInfo.Font.Bold = True
            GridBaseStyle33.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle33.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridBaseStyle34.Name = "Standard"
            GridBaseStyle34.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle34.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle35.Name = "Row Header"
            GridBaseStyle35.StyleInfo.BaseStyle = "Header"
            GridBaseStyle35.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle35.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle36.Name = "Column Header"
            GridBaseStyle36.StyleInfo.BaseStyle = "Header"
            GridBaseStyle36.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            Me.gridFields.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle33, GridBaseStyle34, GridBaseStyle35, GridBaseStyle36})
            Me.gridFields.ColCount = 1
            Me.gridFields.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 0)})
            Me.gridFields.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.gridFields.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridFields.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridFields.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.gridFields.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridFields.HasCheckBox = False
            Me.gridFields.HasPaddedRow = True
            Me.gridFields.Location = New System.Drawing.Point(20, 45)
            Me.gridFields.Name = "gridFields"
            Me.gridFields.Office2007ScrollBars = True
            Me.gridFields.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            GridRangeStyle41.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle41.StyleInfo.Font.Bold = False
            GridRangeStyle41.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle41.StyleInfo.Font.Italic = False
            GridRangeStyle41.StyleInfo.Font.Size = 8.25!
            GridRangeStyle41.StyleInfo.Font.Strikeout = False
            GridRangeStyle41.StyleInfo.Font.Underline = False
            GridRangeStyle41.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle41.StyleInfo.Themed = True
            GridRangeStyle42.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle42.StyleInfo.Font.Bold = False
            GridRangeStyle42.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle42.StyleInfo.Font.Italic = False
            GridRangeStyle42.StyleInfo.Font.Size = 8.25!
            GridRangeStyle42.StyleInfo.Font.Strikeout = False
            GridRangeStyle42.StyleInfo.Font.Underline = False
            GridRangeStyle42.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle42.StyleInfo.Themed = True
            GridRangeStyle43.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle43.StyleInfo.Font.Bold = False
            GridRangeStyle43.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle43.StyleInfo.Font.Italic = False
            GridRangeStyle43.StyleInfo.Font.Size = 8.25!
            GridRangeStyle43.StyleInfo.Font.Strikeout = False
            GridRangeStyle43.StyleInfo.Font.Underline = False
            GridRangeStyle43.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle43.StyleInfo.Themed = True
            GridRangeStyle44.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle44.StyleInfo.Font.Bold = False
            GridRangeStyle44.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle44.StyleInfo.Font.Italic = False
            GridRangeStyle44.StyleInfo.Font.Size = 8.25!
            GridRangeStyle44.StyleInfo.Font.Strikeout = False
            GridRangeStyle44.StyleInfo.Font.Underline = False
            GridRangeStyle44.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle44.StyleInfo.Themed = True
            GridRangeStyle45.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle45.StyleInfo.Font.Bold = False
            GridRangeStyle45.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle45.StyleInfo.Font.Italic = False
            GridRangeStyle45.StyleInfo.Font.Size = 8.25!
            GridRangeStyle45.StyleInfo.Font.Strikeout = False
            GridRangeStyle45.StyleInfo.Font.Underline = False
            GridRangeStyle45.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle45.StyleInfo.Themed = True
            GridRangeStyle46.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle46.StyleInfo.Font.Bold = False
            GridRangeStyle46.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle46.StyleInfo.Font.Italic = False
            GridRangeStyle46.StyleInfo.Font.Size = 8.25!
            GridRangeStyle46.StyleInfo.Font.Strikeout = False
            GridRangeStyle46.StyleInfo.Font.Underline = False
            GridRangeStyle46.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle46.StyleInfo.Themed = True
            GridRangeStyle47.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle47.StyleInfo.Font.Bold = False
            GridRangeStyle47.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle47.StyleInfo.Font.Italic = False
            GridRangeStyle47.StyleInfo.Font.Size = 8.25!
            GridRangeStyle47.StyleInfo.Font.Strikeout = False
            GridRangeStyle47.StyleInfo.Font.Underline = False
            GridRangeStyle47.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle47.StyleInfo.Themed = True
            GridRangeStyle48.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle48.StyleInfo.Font.Bold = False
            GridRangeStyle48.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle48.StyleInfo.Font.Italic = False
            GridRangeStyle48.StyleInfo.Font.Size = 8.25!
            GridRangeStyle48.StyleInfo.Font.Strikeout = False
            GridRangeStyle48.StyleInfo.Font.Underline = False
            GridRangeStyle48.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle48.StyleInfo.Themed = True
            GridRangeStyle49.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle49.StyleInfo.Font.Bold = False
            GridRangeStyle49.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle49.StyleInfo.Font.Italic = False
            GridRangeStyle49.StyleInfo.Font.Size = 8.25!
            GridRangeStyle49.StyleInfo.Font.Strikeout = False
            GridRangeStyle49.StyleInfo.Font.Underline = False
            GridRangeStyle49.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle49.StyleInfo.Themed = True
            GridRangeStyle50.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle50.StyleInfo.Font.Bold = False
            GridRangeStyle50.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle50.StyleInfo.Font.Italic = False
            GridRangeStyle50.StyleInfo.Font.Size = 8.25!
            GridRangeStyle50.StyleInfo.Font.Strikeout = False
            GridRangeStyle50.StyleInfo.Font.Underline = False
            GridRangeStyle50.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle50.StyleInfo.Themed = True
            Me.gridFields.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle41, GridRangeStyle42, GridRangeStyle43, GridRangeStyle44, GridRangeStyle45, GridRangeStyle46, GridRangeStyle47, GridRangeStyle48, GridRangeStyle49, GridRangeStyle50})
            Me.gridFields.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None
            Me.gridFields.RowCount = 1
            Me.gridFields.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 0)})
            Me.gridFields.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridFields.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridFields.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridFields.Size = New System.Drawing.Size(267, 188)
            Me.gridFields.SmartSizeBox = False
            Me.gridFields.TabIndex = 0
            Me.gridFields.Text = "gridFields"
            Me.gridFields.ThemesEnabled = True
            Me.gridFields.UseRightToLeftCompatibleTextBox = True
            '
            'PivotGridControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.panelLeft)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.panelRight)
            Me.Name = "PivotGridControl"
            Me.Size = New System.Drawing.Size(784, 566)
            Me.panelLeft.ResumeLayout(False)
            Me.panelColumns.ResumeLayout(False)
            CType(Me.pictureBoxCollapsed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBoxExpanded, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridMainColumns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelGrid.ResumeLayout(False)
            CType(Me.gridMainDisplay, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelRows.ResumeLayout(False)
            CType(Me.gridMainRows, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelFilter.ResumeLayout(False)
            CType(Me.gridMainFilters, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelRight.ResumeLayout(False)
            Me.panelRB.ResumeLayout(False)
            Me.panelRB.PerformLayout()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelRT.ResumeLayout(False)
            Me.panelRT.PerformLayout()
            CType(Me.gridValues, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridRows, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridColumns, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridFilter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridFields, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panelLeft As System.Windows.Forms.Panel
		Private splitter1 As System.Windows.Forms.Splitter
		Private panelRight As System.Windows.Forms.Panel
		Private panelRB As System.Windows.Forms.Panel
		Private splitter2 As System.Windows.Forms.Splitter
		Private panelRT As System.Windows.Forms.Panel
		Private labelPivotTableFieldList As System.Windows.Forms.Label
		Private gridFields As GridList
		Private labelChooseFields As System.Windows.Forms.Label
		Private labelDragFields As System.Windows.Forms.Label
		Private gridColumns As GridList
		Private gridFilter As GridList
		Private labelColumnLabel As System.Windows.Forms.Label
		Private labelReportFilter As System.Windows.Forms.Label
		Private gridValues As GridList
		Private gridRows As GridList
		Private labelValues As System.Windows.Forms.Label
		Private labelRowLabel As System.Windows.Forms.Label
		Private gridMainDisplay As Syncfusion.Windows.Forms.Grid.GridControl
		Private buttonUpdate As Syncfusion.Windows.Forms.ButtonAdv
		Private checkBoxDeferLayout As CheckBox
		Private panelFilter As Panel
		Private panelGrid As Panel
		Private panelRows As Panel
		Private panelColumns As Panel
		Private labelColumns As Label
		Private labelFilter As Label
		Private labelRows As Label
		Private labelGrid As Label
		Private gridMainColumns As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridMainRows As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridMainFilters As Syncfusion.Windows.Forms.Grid.GridControl
		Private pictureBox4 As PictureBox
		Private pictureBox3 As PictureBox
		Private pictureBox2 As PictureBox
		Private pictureBox1 As PictureBox
		Private pictureBoxExpanded As PictureBox
		Private pictureBoxCollapsed As PictureBox
	End Class
End Namespace
