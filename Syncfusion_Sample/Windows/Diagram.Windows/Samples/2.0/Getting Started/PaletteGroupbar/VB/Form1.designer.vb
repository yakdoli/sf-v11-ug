Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System
Namespace PaletteGroupbar1
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
            Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel23 = New System.Windows.Forms.Panel
            Me.label20 = New System.Windows.Forms.Label
            Me.cbCollapse = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label15 = New System.Windows.Forms.Label
            Me.cbAutoClose = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbShowGripper = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.numericCollapsedWidth = New System.Windows.Forms.NumericUpDown
            Me.label18 = New System.Windows.Forms.Label
            Me.cmbPopupResize = New System.Windows.Forms.ComboBox
            Me.panel18 = New System.Windows.Forms.Panel
            Me.label28 = New System.Windows.Forms.Label
            Me.label29 = New System.Windows.Forms.Label
            Me.cbAllowCollapse = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.cbStackedMode = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbChevron = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbThemesEnabled = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cmbOffice2007Theme = New System.Windows.Forms.ComboBox
            Me.cmbVisualStyle = New System.Windows.Forms.ComboBox
            Me.panel17 = New System.Windows.Forms.Panel
            Me.label23 = New System.Windows.Forms.Label
            Me.label27 = New System.Windows.Forms.Label
            Me.label25 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.panel7 = New System.Windows.Forms.Panel
            Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
            Me.panel10 = New System.Windows.Forms.Panel
            Me.btnAddPalette = New System.Windows.Forms.Button
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model3 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gpVSAppearance = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel16 = New System.Windows.Forms.Panel
            Me.label6 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.cbflatLook = New System.Windows.Forms.CheckBox
            Me.cpBack = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label7 = New System.Windows.Forms.Label
            Me.cmbGBBorder = New System.Windows.Forms.ComboBox
            Me.cbDrawClientBorder = New System.Windows.Forms.CheckBox
            Me.gpVSBehavior = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.cbDragNode = New System.Windows.Forms.CheckBox
            Me.cbEditMode = New System.Windows.Forms.CheckBox
            Me.panel15 = New System.Windows.Forms.Panel
            Me.label34 = New System.Windows.Forms.Label
            Me.label35 = New System.Windows.Forms.Label
            Me.cbAnimatedSelection = New System.Windows.Forms.CheckBox
            Me.cbIntegratedScrolling = New System.Windows.Forms.CheckBox
            Me.label1 = New System.Windows.Forms.Label
            Me.cmbTextAlignment = New System.Windows.Forms.ComboBox
            Me.paletteGroupBar3 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.txtEvents = New System.Windows.Forms.TextBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.panel4 = New System.Windows.Forms.Panel
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label9 = New System.Windows.Forms.Label
            Me.cbSmallImageView = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbFlowViewText = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbFlowView = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cbButtonView = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel6 = New System.Windows.Forms.Panel
            Me.label4 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.panel5 = New System.Windows.Forms.Panel
            CType(Me.model2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            Me.panel23.SuspendLayout()
            CType(Me.cbCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbAutoClose, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbShowGripper, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericCollapsedWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel18.SuspendLayout()
            CType(Me.cbAllowCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.cbStackedMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbChevron, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbThemesEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel17.SuspendLayout()
            Me.panel7.SuspendLayout()
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel10.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.gpVSAppearance, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpVSAppearance.SuspendLayout()
            Me.panel16.SuspendLayout()
            CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpVSBehavior.SuspendLayout()
            Me.panel15.SuspendLayout()
            CType(Me.paletteGroupBar3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            Me.panel4.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbSmallImageView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFlowViewText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFlowView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbButtonView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel6.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            Me.panel5.SuspendLayout()
            Me.SuspendLayout()
            '
            'model2
            '
            Me.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model2.DocumentScale.DisplayName = "No Scale"
            Me.model2.DocumentScale.Height = 1.0!
            Me.model2.DocumentScale.Width = 1.0!
            Me.model2.DocumentSize.Height = 1169.0!
            Me.model2.DocumentSize.Width = 827.0!
            Me.model2.LineStyle.DashPattern = Nothing
            Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model2.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 538.0!
            Me.model1.DocumentSize.Width = 673.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LogicalSize = New System.Drawing.SizeF(673.0!, 538.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.gradientPanel3)
            Me.panel3.Controls.Add(Me.gradientPanel2)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel3.Location = New System.Drawing.Point(309, 44)
            Me.panel3.Name = "panel3"
            Me.panel3.Padding = New System.Windows.Forms.Padding(2)
            Me.panel3.Size = New System.Drawing.Size(378, 518)
            Me.panel3.TabIndex = 201
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.panel23)
            Me.gradientPanel3.Controls.Add(Me.panel18)
            Me.gradientPanel3.Controls.Add(Me.cbAllowCollapse)
            Me.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel3.Location = New System.Drawing.Point(2, 241)
            Me.gradientPanel3.Margin = New System.Windows.Forms.Padding(4)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(374, 264)
            Me.gradientPanel3.TabIndex = 199
            '
            'panel23
            '
            Me.panel23.BackColor = System.Drawing.Color.Transparent
            Me.panel23.Controls.Add(Me.label20)
            Me.panel23.Controls.Add(Me.cbCollapse)
            Me.panel23.Controls.Add(Me.label15)
            Me.panel23.Controls.Add(Me.cbAutoClose)
            Me.panel23.Controls.Add(Me.cbShowGripper)
            Me.panel23.Controls.Add(Me.numericCollapsedWidth)
            Me.panel23.Controls.Add(Me.label18)
            Me.panel23.Controls.Add(Me.cmbPopupResize)
            Me.panel23.Location = New System.Drawing.Point(34, 73)
            Me.panel23.Margin = New System.Windows.Forms.Padding(4)
            Me.panel23.Name = "panel23"
            Me.panel23.Size = New System.Drawing.Size(310, 181)
            Me.panel23.TabIndex = 201
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.Transparent
            Me.label20.Image = CType(resources.GetObject("label20.Image"), System.Drawing.Image)
            Me.label20.Location = New System.Drawing.Point(164, 79)
            Me.label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(27, 25)
            Me.label20.TabIndex = 201
            '
            'cbCollapse
            '
            Me.cbCollapse.AutoHeight = True
            Me.cbCollapse.BackColor = System.Drawing.Color.Transparent
            Me.cbCollapse.Enabled = False
            Me.cbCollapse.Location = New System.Drawing.Point(4, 5)
            Me.cbCollapse.Margin = New System.Windows.Forms.Padding(4)
            Me.cbCollapse.MetroColor = System.Drawing.Color.Empty
            Me.cbCollapse.Name = "cbCollapse"
            Me.cbCollapse.Size = New System.Drawing.Size(91, 20)
            Me.cbCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbCollapse.TabIndex = 0
            Me.cbCollapse.Text = "Collapse"
            Me.cbCollapse.ThemesEnabled = False
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.BackColor = System.Drawing.Color.Transparent
            Me.label15.Location = New System.Drawing.Point(4, 148)
            Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(135, 17)
            Me.label15.TabIndex = 5
            Me.label15.Text = "Popup Resize Mode"
            '
            'cbAutoClose
            '
            Me.cbAutoClose.AutoHeight = True
            Me.cbAutoClose.BackColor = System.Drawing.Color.Transparent
            Me.cbAutoClose.Location = New System.Drawing.Point(4, 79)
            Me.cbAutoClose.Margin = New System.Windows.Forms.Padding(4)
            Me.cbAutoClose.MetroColor = System.Drawing.Color.Empty
            Me.cbAutoClose.Name = "cbAutoClose"
            Me.cbAutoClose.Size = New System.Drawing.Size(152, 20)
            Me.cbAutoClose.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbAutoClose.TabIndex = 11
            Me.cbAutoClose.Text = "Popup Auto Close"
            Me.cbAutoClose.ThemesEnabled = False
            '
            'cbShowGripper
            '
            Me.cbShowGripper.AutoHeight = True
            Me.cbShowGripper.BackColor = System.Drawing.Color.Transparent
            Me.cbShowGripper.Location = New System.Drawing.Point(4, 42)
            Me.cbShowGripper.Margin = New System.Windows.Forms.Padding(4)
            Me.cbShowGripper.MetroColor = System.Drawing.Color.Empty
            Me.cbShowGripper.Name = "cbShowGripper"
            Me.cbShowGripper.Size = New System.Drawing.Size(148, 20)
            Me.cbShowGripper.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbShowGripper.TabIndex = 1
            Me.cbShowGripper.Text = "Show Popup Gripper"
            Me.cbShowGripper.ThemesEnabled = False
            '
            'numericCollapsedWidth
            '
            Me.numericCollapsedWidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericCollapsedWidth.Location = New System.Drawing.Point(149, 116)
            Me.numericCollapsedWidth.Margin = New System.Windows.Forms.Padding(4)
            Me.numericCollapsedWidth.Maximum = New Decimal(New Integer() {80, 0, 0, 0})
            Me.numericCollapsedWidth.Minimum = New Decimal(New Integer() {32, 0, 0, 0})
            Me.numericCollapsedWidth.Name = "numericCollapsedWidth"
            Me.numericCollapsedWidth.Size = New System.Drawing.Size(109, 22)
            Me.numericCollapsedWidth.TabIndex = 8
            Me.numericCollapsedWidth.Value = New Decimal(New Integer() {32, 0, 0, 0})
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.BackColor = System.Drawing.Color.Transparent
            Me.label18.Location = New System.Drawing.Point(4, 116)
            Me.label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(110, 17)
            Me.label18.TabIndex = 7
            Me.label18.Text = "Collapsed Width"
            '
            'cmbPopupResize
            '
            Me.cmbPopupResize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPopupResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbPopupResize.FormattingEnabled = True
            Me.cmbPopupResize.Items.AddRange(New Object() {"Both", "Horizontal", "None", "Vertical"})
            Me.cmbPopupResize.Location = New System.Drawing.Point(149, 148)
            Me.cmbPopupResize.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbPopupResize.Name = "cmbPopupResize"
            Me.cmbPopupResize.Size = New System.Drawing.Size(149, 24)
            Me.cmbPopupResize.TabIndex = 16
            '
            'panel18
            '
            Me.panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel18.Controls.Add(Me.label28)
            Me.panel18.Controls.Add(Me.label29)
            Me.panel18.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.panel18.Location = New System.Drawing.Point(0, 0)
            Me.panel18.Margin = New System.Windows.Forms.Padding(4)
            Me.panel18.Name = "panel18"
            Me.panel18.Size = New System.Drawing.Size(372, 33)
            Me.panel18.TabIndex = 157
            '
            'label28
            '
            Me.label28.BackColor = System.Drawing.Color.White
            Me.label28.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label28.Location = New System.Drawing.Point(0, 31)
            Me.label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(372, 2)
            Me.label28.TabIndex = 139
            '
            'label29
            '
            Me.label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label29.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label29.Image = CType(resources.GetObject("label29.Image"), System.Drawing.Image)
            Me.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label29.Location = New System.Drawing.Point(5, 5)
            Me.label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(202, 26)
            Me.label29.TabIndex = 170
            Me.label29.Text = "Collapse Mode Properties"
            Me.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cbAllowCollapse
            '
            Me.cbAllowCollapse.AutoHeight = True
            Me.cbAllowCollapse.BackColor = System.Drawing.Color.Transparent
            Me.cbAllowCollapse.Location = New System.Drawing.Point(38, 45)
            Me.cbAllowCollapse.Margin = New System.Windows.Forms.Padding(4)
            Me.cbAllowCollapse.MetroColor = System.Drawing.Color.Empty
            Me.cbAllowCollapse.Name = "cbAllowCollapse"
            Me.cbAllowCollapse.Size = New System.Drawing.Size(127, 20)
            Me.cbAllowCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbAllowCollapse.TabIndex = 22
            Me.cbAllowCollapse.Text = "AllowCollapse"
            Me.cbAllowCollapse.ThemesEnabled = False
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.cbStackedMode)
            Me.gradientPanel2.Controls.Add(Me.cbChevron)
            Me.gradientPanel2.Controls.Add(Me.cbThemesEnabled)
            Me.gradientPanel2.Controls.Add(Me.cmbOffice2007Theme)
            Me.gradientPanel2.Controls.Add(Me.cmbVisualStyle)
            Me.gradientPanel2.Controls.Add(Me.panel17)
            Me.gradientPanel2.Controls.Add(Me.label25)
            Me.gradientPanel2.Controls.Add(Me.label26)
            Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel2.Location = New System.Drawing.Point(2, 2)
            Me.gradientPanel2.Margin = New System.Windows.Forms.Padding(4)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(374, 239)
            Me.gradientPanel2.TabIndex = 198
            '
            'cbStackedMode
            '
            Me.cbStackedMode.AutoHeight = True
            Me.cbStackedMode.BackColor = System.Drawing.Color.Transparent
            Me.cbStackedMode.Location = New System.Drawing.Point(36, 57)
            Me.cbStackedMode.Margin = New System.Windows.Forms.Padding(4)
            Me.cbStackedMode.MetroColor = System.Drawing.Color.Empty
            Me.cbStackedMode.Name = "cbStackedMode"
            Me.cbStackedMode.Size = New System.Drawing.Size(160, 20)
            Me.cbStackedMode.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbStackedMode.TabIndex = 164
            Me.cbStackedMode.Text = "Enable Stacked Mode"
            Me.cbStackedMode.ThemesEnabled = False
            '
            'cbChevron
            '
            Me.cbChevron.AutoHeight = True
            Me.cbChevron.BackColor = System.Drawing.Color.Transparent
            Me.cbChevron.Location = New System.Drawing.Point(36, 94)
            Me.cbChevron.Margin = New System.Windows.Forms.Padding(4)
            Me.cbChevron.MetroColor = System.Drawing.Color.Empty
            Me.cbChevron.Name = "cbChevron"
            Me.cbChevron.Size = New System.Drawing.Size(127, 20)
            Me.cbChevron.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbChevron.TabIndex = 163
            Me.cbChevron.Text = "Show Chevron"
            Me.cbChevron.ThemesEnabled = False
            '
            'cbThemesEnabled
            '
            Me.cbThemesEnabled.AutoHeight = True
            Me.cbThemesEnabled.BackColor = System.Drawing.Color.Transparent
            Me.cbThemesEnabled.Location = New System.Drawing.Point(36, 131)
            Me.cbThemesEnabled.Margin = New System.Windows.Forms.Padding(4)
            Me.cbThemesEnabled.MetroColor = System.Drawing.Color.Empty
            Me.cbThemesEnabled.Name = "cbThemesEnabled"
            Me.cbThemesEnabled.Size = New System.Drawing.Size(127, 20)
            Me.cbThemesEnabled.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbThemesEnabled.TabIndex = 162
            Me.cbThemesEnabled.Text = "Themes Enabled"
            Me.cbThemesEnabled.ThemesEnabled = False
            '
            'cmbOffice2007Theme
            '
            Me.cmbOffice2007Theme.Enabled = False
            Me.cmbOffice2007Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbOffice2007Theme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbOffice2007Theme.FormattingEnabled = True
            Me.cmbOffice2007Theme.Items.AddRange(New Object() {"Managed", "Blue", "Silver", "Black"})
            Me.cmbOffice2007Theme.Location = New System.Drawing.Point(148, 204)
            Me.cmbOffice2007Theme.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbOffice2007Theme.Name = "cmbOffice2007Theme"
            Me.cmbOffice2007Theme.Size = New System.Drawing.Size(184, 27)
            Me.cmbOffice2007Theme.TabIndex = 159
            '
            'cmbVisualStyle
            '
            Me.cmbVisualStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbVisualStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbVisualStyle.FormattingEnabled = True
            Me.cmbVisualStyle.Items.AddRange(New Object() {"Default", "Office2003", "Office2007", "Metro"})
            Me.cmbVisualStyle.Location = New System.Drawing.Point(148, 169)
            Me.cmbVisualStyle.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbVisualStyle.Name = "cmbVisualStyle"
            Me.cmbVisualStyle.Size = New System.Drawing.Size(184, 27)
            Me.cmbVisualStyle.TabIndex = 158
            '
            'panel17
            '
            Me.panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel17.Controls.Add(Me.label23)
            Me.panel17.Controls.Add(Me.label27)
            Me.panel17.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel17.Location = New System.Drawing.Point(0, 0)
            Me.panel17.Margin = New System.Windows.Forms.Padding(4)
            Me.panel17.Name = "panel17"
            Me.panel17.Size = New System.Drawing.Size(372, 33)
            Me.panel17.TabIndex = 157
            '
            'label23
            '
            Me.label23.BackColor = System.Drawing.Color.White
            Me.label23.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label23.Location = New System.Drawing.Point(0, 31)
            Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(372, 2)
            Me.label23.TabIndex = 139
            '
            'label27
            '
            Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label27.Image = CType(resources.GetObject("label27.Image"), System.Drawing.Image)
            Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label27.Location = New System.Drawing.Point(13, 1)
            Me.label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(217, 26)
            Me.label27.TabIndex = 170
            Me.label27.Text = "PaletteGroupBar Properties"
            Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label25
            '
            Me.label25.BackColor = System.Drawing.Color.Transparent
            Me.label25.ForeColor = System.Drawing.Color.Black
            Me.label25.Location = New System.Drawing.Point(36, 174)
            Me.label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(88, 17)
            Me.label25.TabIndex = 141
            Me.label25.Text = "Visual Styles"
            '
            'label26
            '
            Me.label26.BackColor = System.Drawing.Color.Transparent
            Me.label26.ForeColor = System.Drawing.Color.Black
            Me.label26.Location = New System.Drawing.Point(36, 209)
            Me.label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(99, 17)
            Me.label26.TabIndex = 143
            Me.label26.Text = "ColorSchemes"
            '
            'panel7
            '
            Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel7.Controls.Add(Me.paletteGroupBar1)
            Me.panel7.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel7.Location = New System.Drawing.Point(0, 44)
            Me.panel7.Name = "panel7"
            Me.panel7.Size = New System.Drawing.Size(309, 518)
            Me.panel7.TabIndex = 5
            '
            'paletteGroupBar1
            '
            Me.paletteGroupBar1.AllowDrop = True
            Me.paletteGroupBar1.AnimatedSelection = False
            Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
            Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.paletteGroupBar1.Diagram = Nothing
            Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.paletteGroupBar1.EditMode = False
            Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
            Me.paletteGroupBar1.ExpandedWidth = 289
            Me.paletteGroupBar1.FlatLook = True
            Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
            Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
            Me.paletteGroupBar1.GroupBarItemHeight = 25
            Me.paletteGroupBar1.IndexOnVisibleItems = True
            Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 0)
            Me.paletteGroupBar1.Margin = New System.Windows.Forms.Padding(4)
            Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
            Me.paletteGroupBar1.Name = "paletteGroupBar1"
            Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
            Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.paletteGroupBar1.ShowChevron = False
            Me.paletteGroupBar1.Size = New System.Drawing.Size(309, 518)
            Me.paletteGroupBar1.TabIndex = 3
            Me.paletteGroupBar1.Text = "paletteGroupBar2"
            Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
            '
            'panel10
            '
            Me.panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel10.Controls.Add(Me.btnAddPalette)
            Me.panel10.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel10.Location = New System.Drawing.Point(0, 0)
            Me.panel10.Name = "panel10"
            Me.panel10.Size = New System.Drawing.Size(1034, 44)
            Me.panel10.TabIndex = 200
            '
            'btnAddPalette
            '
            Me.btnAddPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnAddPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnAddPalette.FlatAppearance.BorderColor = System.Drawing.Color.Silver
            Me.btnAddPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddPalette.ForeColor = System.Drawing.Color.Black
            Me.btnAddPalette.Image = CType(resources.GetObject("btnAddPalette.Image"), System.Drawing.Image)
            Me.btnAddPalette.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.btnAddPalette.Location = New System.Drawing.Point(5, 6)
            Me.btnAddPalette.Name = "btnAddPalette"
            Me.btnAddPalette.Size = New System.Drawing.Size(122, 31)
            Me.btnAddPalette.TabIndex = 11
            Me.btnAddPalette.Text = "Add Palette"
            Me.btnAddPalette.UseVisualStyleBackColor = False
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(235, 0)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model3
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(515, 562)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 199
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.VScroll = True
            '
            'model3
            '
            Me.model3.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model3.DocumentScale.DisplayName = "No Scale"
            Me.model3.DocumentScale.Height = 1.0!
            Me.model3.DocumentScale.Width = 1.0!
            Me.model3.DocumentSize.Height = 1169.0!
            Me.model3.DocumentSize.Width = 827.0!
            Me.model3.LineStyle.DashPattern = Nothing
            Me.model3.LineStyle.LineColor = System.Drawing.Color.White
            Me.model3.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model3.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model3.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.gpVSAppearance)
            Me.panel2.Controls.Add(Me.gpVSBehavior)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(750, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(284, 562)
            Me.panel2.TabIndex = 198
            '
            'gpVSAppearance
            '
            Me.gpVSAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gpVSAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gpVSAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gpVSAppearance.Controls.Add(Me.panel16)
            Me.gpVSAppearance.Controls.Add(Me.label5)
            Me.gpVSAppearance.Controls.Add(Me.cbflatLook)
            Me.gpVSAppearance.Controls.Add(Me.cpBack)
            Me.gpVSAppearance.Controls.Add(Me.label7)
            Me.gpVSAppearance.Controls.Add(Me.cmbGBBorder)
            Me.gpVSAppearance.Controls.Add(Me.cbDrawClientBorder)
            Me.gpVSAppearance.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gpVSAppearance.Location = New System.Drawing.Point(0, 293)
            Me.gpVSAppearance.Margin = New System.Windows.Forms.Padding(4)
            Me.gpVSAppearance.Name = "gpVSAppearance"
            Me.gpVSAppearance.Size = New System.Drawing.Size(284, 269)
            Me.gpVSAppearance.TabIndex = 197
            '
            'panel16
            '
            Me.panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel16.Controls.Add(Me.label6)
            Me.panel16.Controls.Add(Me.label17)
            Me.panel16.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel16.ForeColor = System.Drawing.Color.MidnightBlue
            Me.panel16.Location = New System.Drawing.Point(0, 0)
            Me.panel16.Margin = New System.Windows.Forms.Padding(4)
            Me.panel16.Name = "panel16"
            Me.panel16.Size = New System.Drawing.Size(282, 33)
            Me.panel16.TabIndex = 157
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.White
            Me.label6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label6.Location = New System.Drawing.Point(0, 31)
            Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(282, 2)
            Me.label6.TabIndex = 139
            '
            'label17
            '
            Me.label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Image = CType(resources.GetObject("label17.Image"), System.Drawing.Image)
            Me.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label17.Location = New System.Drawing.Point(13, 6)
            Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(110, 21)
            Me.label17.TabIndex = 170
            Me.label17.Text = "Appearance"
            Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.ForeColor = System.Drawing.Color.Black
            Me.label5.Location = New System.Drawing.Point(20, 72)
            Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(72, 17)
            Me.label5.TabIndex = 149
            Me.label5.Text = "BackColor"
            '
            'cbflatLook
            '
            Me.cbflatLook.AutoSize = True
            Me.cbflatLook.BackColor = System.Drawing.Color.Transparent
            Me.cbflatLook.Checked = True
            Me.cbflatLook.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbflatLook.Location = New System.Drawing.Point(20, 104)
            Me.cbflatLook.Margin = New System.Windows.Forms.Padding(4)
            Me.cbflatLook.Name = "cbflatLook"
            Me.cbflatLook.Size = New System.Drawing.Size(88, 21)
            Me.cbflatLook.TabIndex = 133
            Me.cbflatLook.Text = "Flat Look"
            Me.cbflatLook.UseVisualStyleBackColor = False
            '
            'cpBack
            '
            Me.cpBack.BackColor = System.Drawing.SystemColors.Control
            Me.cpBack.ColorUISize = New System.Drawing.Size(208, 230)
            Me.cpBack.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cpBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cpBack.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cpBack.Location = New System.Drawing.Point(115, 72)
            Me.cpBack.Margin = New System.Windows.Forms.Padding(4)
            Me.cpBack.Name = "cpBack"
            Me.cpBack.SelectedAsBackcolor = True
            Me.cpBack.SelectedColor = System.Drawing.SystemColors.Control
            Me.cpBack.Size = New System.Drawing.Size(27, 25)
            Me.cpBack.TabIndex = 148
            Me.cpBack.UseVisualStyleBackColor = False
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.ForeColor = System.Drawing.Color.Black
            Me.label7.Location = New System.Drawing.Point(20, 177)
            Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(148, 17)
            Me.label7.TabIndex = 136
            Me.label7.Text = "GroupBar BorderStyle"
            '
            'cmbGBBorder
            '
            Me.cmbGBBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbGBBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbGBBorder.FormattingEnabled = True
            Me.cmbGBBorder.Items.AddRange(New Object() {"None", "FixedSingle", "Fixed3D"})
            Me.cmbGBBorder.Location = New System.Drawing.Point(170, 177)
            Me.cmbGBBorder.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbGBBorder.Name = "cmbGBBorder"
            Me.cmbGBBorder.Size = New System.Drawing.Size(108, 24)
            Me.cmbGBBorder.TabIndex = 137
            '
            'cbDrawClientBorder
            '
            Me.cbDrawClientBorder.AutoSize = True
            Me.cbDrawClientBorder.BackColor = System.Drawing.Color.Transparent
            Me.cbDrawClientBorder.Location = New System.Drawing.Point(20, 140)
            Me.cbDrawClientBorder.Margin = New System.Windows.Forms.Padding(4)
            Me.cbDrawClientBorder.Name = "cbDrawClientBorder"
            Me.cbDrawClientBorder.Size = New System.Drawing.Size(140, 21)
            Me.cbDrawClientBorder.TabIndex = 138
            Me.cbDrawClientBorder.Text = "DrawClientBorder"
            Me.cbDrawClientBorder.UseVisualStyleBackColor = False
            '
            'gpVSBehavior
            '
            Me.gpVSBehavior.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gpVSBehavior.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gpVSBehavior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gpVSBehavior.Controls.Add(Me.cbDragNode)
            Me.gpVSBehavior.Controls.Add(Me.cbEditMode)
            Me.gpVSBehavior.Controls.Add(Me.panel15)
            Me.gpVSBehavior.Controls.Add(Me.cbAnimatedSelection)
            Me.gpVSBehavior.Controls.Add(Me.cbIntegratedScrolling)
            Me.gpVSBehavior.Controls.Add(Me.label1)
            Me.gpVSBehavior.Controls.Add(Me.cmbTextAlignment)
            Me.gpVSBehavior.Dock = System.Windows.Forms.DockStyle.Top
            Me.gpVSBehavior.Location = New System.Drawing.Point(0, 0)
            Me.gpVSBehavior.Margin = New System.Windows.Forms.Padding(4)
            Me.gpVSBehavior.Name = "gpVSBehavior"
            Me.gpVSBehavior.Size = New System.Drawing.Size(284, 229)
            Me.gpVSBehavior.TabIndex = 196
            '
            'cbDragNode
            '
            Me.cbDragNode.AutoSize = True
            Me.cbDragNode.BackColor = System.Drawing.Color.Transparent
            Me.cbDragNode.Checked = True
            Me.cbDragNode.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbDragNode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDragNode.Location = New System.Drawing.Point(17, 147)
            Me.cbDragNode.Margin = New System.Windows.Forms.Padding(4)
            Me.cbDragNode.Name = "cbDragNode"
            Me.cbDragNode.Size = New System.Drawing.Size(158, 21)
            Me.cbDragNode.TabIndex = 161
            Me.cbDragNode.Text = "Show DragNodeCue"
            Me.cbDragNode.UseVisualStyleBackColor = False
            '
            'cbEditMode
            '
            Me.cbEditMode.AutoSize = True
            Me.cbEditMode.BackColor = System.Drawing.Color.Transparent
            Me.cbEditMode.Location = New System.Drawing.Point(17, 88)
            Me.cbEditMode.Margin = New System.Windows.Forms.Padding(4)
            Me.cbEditMode.Name = "cbEditMode"
            Me.cbEditMode.Size = New System.Drawing.Size(93, 21)
            Me.cbEditMode.TabIndex = 158
            Me.cbEditMode.Text = "Edit Mode"
            Me.cbEditMode.UseVisualStyleBackColor = False
            '
            'panel15
            '
            Me.panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel15.Controls.Add(Me.label34)
            Me.panel15.Controls.Add(Me.label35)
            Me.panel15.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel15.Location = New System.Drawing.Point(0, 0)
            Me.panel15.Margin = New System.Windows.Forms.Padding(4)
            Me.panel15.Name = "panel15"
            Me.panel15.Size = New System.Drawing.Size(282, 33)
            Me.panel15.TabIndex = 157
            '
            'label34
            '
            Me.label34.BackColor = System.Drawing.Color.White
            Me.label34.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label34.Location = New System.Drawing.Point(0, 31)
            Me.label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(282, 2)
            Me.label34.TabIndex = 139
            '
            'label35
            '
            Me.label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label35.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label35.Image = CType(resources.GetObject("label35.Image"), System.Drawing.Image)
            Me.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label35.Location = New System.Drawing.Point(13, 2)
            Me.label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(90, 23)
            Me.label35.TabIndex = 170
            Me.label35.Text = "Behavior"
            Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cbAnimatedSelection
            '
            Me.cbAnimatedSelection.AutoSize = True
            Me.cbAnimatedSelection.BackColor = System.Drawing.Color.Transparent
            Me.cbAnimatedSelection.Checked = True
            Me.cbAnimatedSelection.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbAnimatedSelection.Location = New System.Drawing.Point(17, 59)
            Me.cbAnimatedSelection.Margin = New System.Windows.Forms.Padding(4)
            Me.cbAnimatedSelection.Name = "cbAnimatedSelection"
            Me.cbAnimatedSelection.Size = New System.Drawing.Size(151, 21)
            Me.cbAnimatedSelection.TabIndex = 132
            Me.cbAnimatedSelection.Text = "Animated Selection"
            Me.cbAnimatedSelection.UseVisualStyleBackColor = False
            '
            'cbIntegratedScrolling
            '
            Me.cbIntegratedScrolling.AutoSize = True
            Me.cbIntegratedScrolling.BackColor = System.Drawing.Color.Transparent
            Me.cbIntegratedScrolling.Location = New System.Drawing.Point(17, 118)
            Me.cbIntegratedScrolling.Margin = New System.Windows.Forms.Padding(4)
            Me.cbIntegratedScrolling.Name = "cbIntegratedScrolling"
            Me.cbIntegratedScrolling.Size = New System.Drawing.Size(148, 21)
            Me.cbIntegratedScrolling.TabIndex = 143
            Me.cbIntegratedScrolling.Text = "IntegratedScrolling"
            Me.cbIntegratedScrolling.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(17, 188)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(101, 17)
            Me.label1.TabIndex = 141
            Me.label1.Text = "Text Alignment"
            '
            'cmbTextAlignment
            '
            Me.cmbTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTextAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbTextAlignment.FormattingEnabled = True
            Me.cmbTextAlignment.Items.AddRange(New Object() {"Left", "Center", "Right"})
            Me.cmbTextAlignment.Location = New System.Drawing.Point(126, 184)
            Me.cmbTextAlignment.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbTextAlignment.Name = "cmbTextAlignment"
            Me.cmbTextAlignment.Size = New System.Drawing.Size(105, 24)
            Me.cmbTextAlignment.TabIndex = 142
            '
            'paletteGroupBar3
            '
            Me.paletteGroupBar3.AllowDrop = True
            Me.paletteGroupBar3.AnimatedSelection = False
            Me.paletteGroupBar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.paletteGroupBar3.BorderColor = System.Drawing.Color.White
            Me.paletteGroupBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.paletteGroupBar3.Diagram = Nothing
            Me.paletteGroupBar3.Dock = System.Windows.Forms.DockStyle.Left
            Me.paletteGroupBar3.EditMode = False
            Me.paletteGroupBar3.ExpandButtonToolTip = Nothing
            Me.paletteGroupBar3.ExpandedWidth = 289
            Me.paletteGroupBar3.FlatLook = True
            Me.paletteGroupBar3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.paletteGroupBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.paletteGroupBar3.GroupBarDropDownToolTip = Nothing
            Me.paletteGroupBar3.GroupBarItemHeight = 25
            Me.paletteGroupBar3.IndexOnVisibleItems = True
            Me.paletteGroupBar3.Location = New System.Drawing.Point(0, 0)
            Me.paletteGroupBar3.Margin = New System.Windows.Forms.Padding(4)
            Me.paletteGroupBar3.MinimizeButtonToolTip = Nothing
            Me.paletteGroupBar3.Name = "paletteGroupBar3"
            Me.paletteGroupBar3.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.paletteGroupBar3.ShowChevron = False
            Me.paletteGroupBar3.Size = New System.Drawing.Size(235, 562)
            Me.paletteGroupBar3.TabIndex = 4
            Me.paletteGroupBar3.Text = "paletteGroupBar3"
            Me.paletteGroupBar3.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.txtEvents)
            Me.gradientPanel1.Controls.Add(Me.panel1)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gradientPanel1.Location = New System.Drawing.Point(687, 304)
            Me.gradientPanel1.Margin = New System.Windows.Forms.Padding(4)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Padding = New System.Windows.Forms.Padding(2)
            Me.gradientPanel1.Size = New System.Drawing.Size(347, 258)
            Me.gradientPanel1.TabIndex = 202
            '
            'txtEvents
            '
            Me.txtEvents.AcceptsReturn = True
            Me.txtEvents.AcceptsTab = True
            Me.txtEvents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtEvents.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEvents.Location = New System.Drawing.Point(2, 35)
            Me.txtEvents.Multiline = True
            Me.txtEvents.Name = "txtEvents"
            Me.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtEvents.Size = New System.Drawing.Size(341, 219)
            Me.txtEvents.TabIndex = 158
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.panel1.Location = New System.Drawing.Point(2, 2)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(341, 33)
            Me.panel1.TabIndex = 157
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.White
            Me.label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label2.Location = New System.Drawing.Point(0, 31)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(341, 2)
            Me.label2.TabIndex = 139
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(13, 1)
            Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(98, 26)
            Me.label3.TabIndex = 170
            Me.label3.Text = "Events"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(1037, 589)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 5
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.Controls.Add(Me.panel4)
            Me.tabPageAdv1.Image = Nothing
            Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.ShowCloseButton = True
            Me.tabPageAdv1.Size = New System.Drawing.Size(1034, 562)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Outlook PaletteGroupbar"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'panel4
            '
            Me.panel4.Controls.Add(Me.gradientPanel4)
            Me.panel4.Controls.Add(Me.gradientPanel1)
            Me.panel4.Controls.Add(Me.panel3)
            Me.panel4.Controls.Add(Me.panel7)
            Me.panel4.Controls.Add(Me.panel10)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel4.Location = New System.Drawing.Point(0, 0)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(1034, 562)
            Me.panel4.TabIndex = 0
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.numericUpDown1)
            Me.gradientPanel4.Controls.Add(Me.label9)
            Me.gradientPanel4.Controls.Add(Me.cbSmallImageView)
            Me.gradientPanel4.Controls.Add(Me.cbFlowViewText)
            Me.gradientPanel4.Controls.Add(Me.cbFlowView)
            Me.gradientPanel4.Controls.Add(Me.cbButtonView)
            Me.gradientPanel4.Controls.Add(Me.panel6)
            Me.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel4.Location = New System.Drawing.Point(687, 44)
            Me.gradientPanel4.Margin = New System.Windows.Forms.Padding(4)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Padding = New System.Windows.Forms.Padding(2)
            Me.gradientPanel4.Size = New System.Drawing.Size(347, 260)
            Me.gradientPanel4.TabIndex = 203
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDown1.Location = New System.Drawing.Point(202, 155)
            Me.numericUpDown1.Margin = New System.Windows.Forms.Padding(4)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {160, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(109, 22)
            Me.numericUpDown1.TabIndex = 170
            Me.numericUpDown1.Value = New Decimal(New Integer() {80, 0, 0, 0})
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Location = New System.Drawing.Point(24, 158)
            Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(170, 17)
            Me.label9.TabIndex = 169
            Me.label9.Text = "FlowView Item TextLength"
            '
            'cbSmallImageView
            '
            Me.cbSmallImageView.AutoHeight = True
            Me.cbSmallImageView.BackColor = System.Drawing.Color.Transparent
            Me.cbSmallImageView.Location = New System.Drawing.Point(18, 127)
            Me.cbSmallImageView.Margin = New System.Windows.Forms.Padding(4)
            Me.cbSmallImageView.MetroColor = System.Drawing.Color.Empty
            Me.cbSmallImageView.Name = "cbSmallImageView"
            Me.cbSmallImageView.Size = New System.Drawing.Size(204, 20)
            Me.cbSmallImageView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbSmallImageView.TabIndex = 168
            Me.cbSmallImageView.Text = "Small Image View"
            Me.cbSmallImageView.ThemesEnabled = False
            '
            'cbFlowViewText
            '
            Me.cbFlowViewText.AutoHeight = True
            Me.cbFlowViewText.BackColor = System.Drawing.Color.Transparent
            Me.cbFlowViewText.Checked = True
            Me.cbFlowViewText.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbFlowViewText.Location = New System.Drawing.Point(18, 99)
            Me.cbFlowViewText.Margin = New System.Windows.Forms.Padding(4)
            Me.cbFlowViewText.MetroColor = System.Drawing.Color.Empty
            Me.cbFlowViewText.Name = "cbFlowViewText"
            Me.cbFlowViewText.Size = New System.Drawing.Size(204, 20)
            Me.cbFlowViewText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbFlowViewText.TabIndex = 167
            Me.cbFlowViewText.Text = "Show FlowView ItemText"
            Me.cbFlowViewText.ThemesEnabled = False
            '
            'cbFlowView
            '
            Me.cbFlowView.AutoHeight = True
            Me.cbFlowView.BackColor = System.Drawing.Color.Transparent
            Me.cbFlowView.Checked = True
            Me.cbFlowView.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbFlowView.Location = New System.Drawing.Point(18, 71)
            Me.cbFlowView.Margin = New System.Windows.Forms.Padding(4)
            Me.cbFlowView.MetroColor = System.Drawing.Color.Empty
            Me.cbFlowView.Name = "cbFlowView"
            Me.cbFlowView.Size = New System.Drawing.Size(160, 20)
            Me.cbFlowView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbFlowView.TabIndex = 166
            Me.cbFlowView.Text = "Flow View"
            Me.cbFlowView.ThemesEnabled = False
            '
            'cbButtonView
            '
            Me.cbButtonView.AutoHeight = True
            Me.cbButtonView.BackColor = System.Drawing.Color.Transparent
            Me.cbButtonView.Location = New System.Drawing.Point(18, 43)
            Me.cbButtonView.Margin = New System.Windows.Forms.Padding(4)
            Me.cbButtonView.MetroColor = System.Drawing.Color.Empty
            Me.cbButtonView.Name = "cbButtonView"
            Me.cbButtonView.Size = New System.Drawing.Size(160, 20)
            Me.cbButtonView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.cbButtonView.TabIndex = 165
            Me.cbButtonView.Text = "Button View"
            Me.cbButtonView.ThemesEnabled = False
            '
            'panel6
            '
            Me.panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel6.Controls.Add(Me.label4)
            Me.panel6.Controls.Add(Me.label8)
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.panel6.Location = New System.Drawing.Point(2, 2)
            Me.panel6.Margin = New System.Windows.Forms.Padding(4)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(341, 33)
            Me.panel6.TabIndex = 157
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label4.Location = New System.Drawing.Point(0, 31)
            Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(341, 2)
            Me.label4.TabIndex = 139
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(13, 1)
            Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(253, 26)
            Me.label8.TabIndex = 170
            Me.label8.Text = "PaletteGroupView Properties"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.Controls.Add(Me.panel5)
            Me.tabPageAdv2.Image = Nothing
            Me.tabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.ShowCloseButton = True
            Me.tabPageAdv2.Size = New System.Drawing.Size(1034, 562)
            Me.tabPageAdv2.TabIndex = 2
            Me.tabPageAdv2.Text = "VS Like PaletteGroupbar"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'panel5
            '
            Me.panel5.Controls.Add(Me.diagram1)
            Me.panel5.Controls.Add(Me.paletteGroupBar3)
            Me.panel5.Controls.Add(Me.panel2)
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(1034, 562)
            Me.panel5.TabIndex = 200
            '
            'Form1
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.BorderThickness = 0
            Me.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.CaptionButtonColor = System.Drawing.Color.Black
            Me.CaptionFont = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CaptionForeColor = System.Drawing.Color.MidnightBlue
            Me.ClientSize = New System.Drawing.Size(1037, 589)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.Name = "Form1"
            Me.Text = "PaletteGroupbar"
            CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.panel23.ResumeLayout(False)
            Me.panel23.PerformLayout()
            CType(Me.cbCollapse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbAutoClose, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbShowGripper, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericCollapsedWidth, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel18.ResumeLayout(False)
            CType(Me.cbAllowCollapse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            CType(Me.cbStackedMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbChevron, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbThemesEnabled, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel17.ResumeLayout(False)
            Me.panel7.ResumeLayout(False)
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel10.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.gpVSAppearance, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpVSAppearance.ResumeLayout(False)
            Me.gpVSAppearance.PerformLayout()
            Me.panel16.ResumeLayout(False)
            CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpVSBehavior.ResumeLayout(False)
            Me.gpVSBehavior.PerformLayout()
            Me.panel15.ResumeLayout(False)
            CType(Me.paletteGroupBar3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            Me.panel1.ResumeLayout(False)
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.gradientPanel4.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbSmallImageView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFlowViewText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFlowView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbButtonView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel6.ResumeLayout(False)
            Me.tabPageAdv2.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private model1 As Model
        Private model2 As Model
        Private gradientPanel3 As GradientPanel
        Private panel23 As System.Windows.Forms.Panel
        Private label20 As System.Windows.Forms.Label
        Private WithEvents cbCollapse As CheckBoxAdv
        Private label15 As System.Windows.Forms.Label
        Private WithEvents cbAutoClose As CheckBoxAdv
        Private WithEvents cbShowGripper As CheckBoxAdv
        Private WithEvents numericCollapsedWidth As System.Windows.Forms.NumericUpDown
        Private label18 As System.Windows.Forms.Label
        Private WithEvents cmbPopupResize As System.Windows.Forms.ComboBox
        Private panel18 As System.Windows.Forms.Panel
        Private label28 As System.Windows.Forms.Label
        Private label29 As System.Windows.Forms.Label
        Private WithEvents cbAllowCollapse As CheckBoxAdv
        Private gradientPanel2 As GradientPanel
        Private panel17 As System.Windows.Forms.Panel
        Private label23 As System.Windows.Forms.Label
        Private label27 As System.Windows.Forms.Label
        Private label25 As System.Windows.Forms.Label
        Private label26 As System.Windows.Forms.Label
        Private paletteGroupBar3 As PaletteGroupbar
        Private WithEvents cmbOffice2007Theme As System.Windows.Forms.ComboBox
        Private WithEvents cmbVisualStyle As System.Windows.Forms.ComboBox
        Private gpVSAppearance As GradientPanel
        Private panel16 As System.Windows.Forms.Panel
        Private label6 As System.Windows.Forms.Label
        Private label17 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private WithEvents cbflatLook As System.Windows.Forms.CheckBox
        Private WithEvents cpBack As Syncfusion.Windows.Forms.ColorPickerButton
        Private label7 As System.Windows.Forms.Label
        Private WithEvents cmbGBBorder As System.Windows.Forms.ComboBox
        Private WithEvents cbDrawClientBorder As System.Windows.Forms.CheckBox
        Private gpVSBehavior As GradientPanel
        Private panel15 As System.Windows.Forms.Panel
        Private label34 As System.Windows.Forms.Label
        Private label35 As System.Windows.Forms.Label
        Private WithEvents cbAnimatedSelection As System.Windows.Forms.CheckBox
        Private WithEvents cbIntegratedScrolling As System.Windows.Forms.CheckBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents cmbTextAlignment As System.Windows.Forms.ComboBox
        Private panel10 As System.Windows.Forms.Panel
        Private panel3 As System.Windows.Forms.Panel
        Private panel7 As System.Windows.Forms.Panel
        Private paletteGroupBar1 As PaletteGroupbar
        Private WithEvents btnAddPalette As System.Windows.Forms.Button
        Private panel2 As System.Windows.Forms.Panel
        Private diagram1 As Diagram
        Private model3 As Model
        Private WithEvents cbEditMode As System.Windows.Forms.CheckBox
        Private WithEvents cbDragNode As System.Windows.Forms.CheckBox
        Private gradientPanel1 As GradientPanel
        Private txtEvents As System.Windows.Forms.TextBox
        Private panel1 As System.Windows.Forms.Panel
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private WithEvents cbThemesEnabled As CheckBoxAdv
        Private WithEvents cbChevron As CheckBoxAdv
        Private WithEvents cbStackedMode As CheckBoxAdv
        Private tabControlAdv1 As TabControlAdv
        Private tabPageAdv1 As TabPageAdv
        Private tabPageAdv2 As TabPageAdv
        Private panel4 As System.Windows.Forms.Panel
        Private panel5 As System.Windows.Forms.Panel
        Private gradientPanel4 As GradientPanel
        Private WithEvents cbFlowView As CheckBoxAdv
        Private WithEvents cbButtonView As CheckBoxAdv
        Private panel6 As System.Windows.Forms.Panel
        Private label4 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private WithEvents cbFlowViewText As CheckBoxAdv
        Private WithEvents cbSmallImageView As CheckBoxAdv
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private label9 As System.Windows.Forms.Label
    End Class
End Namespace

