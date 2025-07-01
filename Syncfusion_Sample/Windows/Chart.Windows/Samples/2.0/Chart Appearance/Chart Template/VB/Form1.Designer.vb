Imports Microsoft.VisualBasic
Imports System
Namespace ChartTemplate_2005
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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.buttonAdv10 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.buttonAdv7 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Templatebutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Piebutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Loadbutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Areabutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Columnbutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel2 = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.buttonAdv9 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Savebutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.buttonAdv8 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel3 = New System.Windows.Forms.Panel
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.statusStrip1 = New System.Windows.Forms.StatusStrip
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.contextMenuStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.statusStrip1.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.buttonAdv10)
            Me.panel1.Controls.Add(Me.buttonAdv7)
            Me.panel1.Controls.Add(Me.buttonAdv6)
            Me.panel1.Controls.Add(Me.Templatebutton)
            Me.panel1.Controls.Add(Me.buttonAdv5)
            Me.panel1.Controls.Add(Me.Piebutton)
            Me.panel1.Controls.Add(Me.Loadbutton)
            Me.panel1.Controls.Add(Me.Areabutton)
            Me.panel1.Controls.Add(Me.buttonAdv4)
            Me.panel1.Controls.Add(Me.buttonAdv3)
            Me.panel1.Controls.Add(Me.Columnbutton)
            Me.panel1.Controls.Add(Me.buttonAdv2)
            Me.panel1.Controls.Add(Me.buttonAdv1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(171, 392)
            Me.panel1.TabIndex = 1
            '
            'buttonAdv10
            '
            Me.buttonAdv10.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv10.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv10.KeepFocusRectangle = False
            Me.buttonAdv10.Location = New System.Drawing.Point(95, 325)
            Me.buttonAdv10.Name = "buttonAdv10"
            Me.buttonAdv10.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv10.TabIndex = 11
            Me.buttonAdv10.Text = "My Template" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2"
            Me.toolTip1.SetToolTip(Me.buttonAdv10, "Loads User Template2")
            Me.buttonAdv10.UseVisualStyle = True
            Me.buttonAdv10.Visible = False
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(214, 26)
            '
            'copyToolStripMenuItem
            '
            Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
            Me.copyToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
            Me.copyToolStripMenuItem.Text = "Copy File Path to clipboard"
            '
            'buttonAdv7
            '
            Me.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv7.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv7.KeepFocusRectangle = False
            Me.buttonAdv7.Location = New System.Drawing.Point(16, 325)
            Me.buttonAdv7.Name = "buttonAdv7"
            Me.buttonAdv7.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv7.TabIndex = 10
            Me.buttonAdv7.Text = "My Template" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
            Me.toolTip1.SetToolTip(Me.buttonAdv7, "Loads User Template2")
            Me.buttonAdv7.UseVisualStyle = True
            Me.buttonAdv7.Visible = False
            '
            'buttonAdv6
            '
            Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv6.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv6.Image = CType(resources.GetObject("buttonAdv6.Image"), System.Drawing.Image)
            Me.buttonAdv6.KeepFocusRectangle = False
            Me.buttonAdv6.Location = New System.Drawing.Point(95, 232)
            Me.buttonAdv6.Name = "buttonAdv6"
            Me.buttonAdv6.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv6.TabIndex = 9
            Me.toolTip1.SetToolTip(Me.buttonAdv6, "Loads 3D Line Chart")
            Me.buttonAdv6.UseVisualStyle = True
            '
            'Templatebutton
            '
            Me.Templatebutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.Templatebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.Templatebutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Templatebutton.Enabled = False
            Me.Templatebutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Templatebutton.Location = New System.Drawing.Point(0, 298)
            Me.Templatebutton.Name = "Templatebutton"
            Me.Templatebutton.Size = New System.Drawing.Size(169, 21)
            Me.Templatebutton.TabIndex = 2
            Me.Templatebutton.Text = "My Template"
            Me.Templatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Templatebutton.UseVisualStyle = True
            '
            'buttonAdv5
            '
            Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv5.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv5.Image = CType(resources.GetObject("buttonAdv5.Image"), System.Drawing.Image)
            Me.buttonAdv5.KeepFocusRectangle = False
            Me.buttonAdv5.Location = New System.Drawing.Point(16, 232)
            Me.buttonAdv5.Name = "buttonAdv5"
            Me.buttonAdv5.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv5.TabIndex = 8
            Me.toolTip1.SetToolTip(Me.buttonAdv5, "Loads Line Chart")
            Me.buttonAdv5.UseVisualStyle = True
            '
            'Piebutton
            '
            Me.Piebutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.Piebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.Piebutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Piebutton.Enabled = False
            Me.Piebutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Piebutton.Location = New System.Drawing.Point(0, 205)
            Me.Piebutton.Name = "Piebutton"
            Me.Piebutton.Size = New System.Drawing.Size(169, 21)
            Me.Piebutton.TabIndex = 7
            Me.Piebutton.Text = "Pie"
            Me.Piebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Piebutton.UseVisualStyle = True
            '
            'Loadbutton
            '
            Me.Loadbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.Loadbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.Loadbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Loadbutton.Dock = System.Windows.Forms.DockStyle.Top
            Me.Loadbutton.Enabled = False
            Me.Loadbutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Loadbutton.Location = New System.Drawing.Point(0, 0)
            Me.Loadbutton.Name = "Loadbutton"
            Me.Loadbutton.Size = New System.Drawing.Size(169, 21)
            Me.Loadbutton.TabIndex = 6
            Me.Loadbutton.Text = "Load Template"
            Me.Loadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Loadbutton.UseVisualStyle = True
            '
            'Areabutton
            '
            Me.Areabutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.Areabutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.Areabutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Areabutton.Enabled = False
            Me.Areabutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Areabutton.Location = New System.Drawing.Point(0, 112)
            Me.Areabutton.Name = "Areabutton"
            Me.Areabutton.Size = New System.Drawing.Size(169, 21)
            Me.Areabutton.TabIndex = 5
            Me.Areabutton.Text = "Area"
            Me.Areabutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Areabutton.UseVisualStyle = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv4.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv4.Image = CType(resources.GetObject("buttonAdv4.Image"), System.Drawing.Image)
            Me.buttonAdv4.KeepFocusRectangle = False
            Me.buttonAdv4.Location = New System.Drawing.Point(95, 139)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv4.TabIndex = 4
            Me.toolTip1.SetToolTip(Me.buttonAdv4, "Loads 3D Area Chart")
            Me.buttonAdv4.UseVisualStyle = True
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv3.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv3.Image = CType(resources.GetObject("buttonAdv3.Image"), System.Drawing.Image)
            Me.buttonAdv3.KeepFocusRectangle = False
            Me.buttonAdv3.Location = New System.Drawing.Point(16, 139)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv3.TabIndex = 3
            Me.toolTip1.SetToolTip(Me.buttonAdv3, "Loads Area Chart")
            Me.buttonAdv3.UseVisualStyle = True
            '
            'Columnbutton
            '
            Me.Columnbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.Columnbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.Columnbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Columnbutton.Enabled = False
            Me.Columnbutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Columnbutton.Location = New System.Drawing.Point(0, 21)
            Me.Columnbutton.Name = "Columnbutton"
            Me.Columnbutton.Size = New System.Drawing.Size(169, 21)
            Me.Columnbutton.TabIndex = 2
            Me.Columnbutton.Text = "Column"
            Me.Columnbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Columnbutton.UseVisualStyle = True
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv2.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.buttonAdv2.Image = CType(resources.GetObject("buttonAdv2.Image"), System.Drawing.Image)
            Me.buttonAdv2.KeepFocusRectangle = False
            Me.buttonAdv2.Location = New System.Drawing.Point(95, 46)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv2.TabIndex = 1
            Me.toolTip1.SetToolTip(Me.buttonAdv2, "Loads 3D Column Chart")
            Me.buttonAdv2.UseVisualStyle = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.ContextMenuStrip = Me.contextMenuStrip1
            Me.buttonAdv1.Image = CType(resources.GetObject("buttonAdv1.Image"), System.Drawing.Image)
            Me.buttonAdv1.KeepFocusRectangle = False
            Me.buttonAdv1.Location = New System.Drawing.Point(16, 46)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(60, 60)
            Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Tag = "Check"
            Me.toolTip1.SetToolTip(Me.buttonAdv1, "Loads Column Chart")
            Me.buttonAdv1.UseVisualStyle = True
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.buttonAdv9)
            Me.panel2.Controls.Add(Me.Savebutton)
            Me.panel2.Controls.Add(Me.propertyGrid1)
            Me.panel2.Controls.Add(Me.buttonAdv8)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(631, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(175, 392)
            Me.panel2.TabIndex = 2
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(0, 311)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(159, 28)
            Me.label1.TabIndex = 11
            Me.label1.Text = "Make changes to the chart and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "save your template"
            '
            'buttonAdv9
            '
            Me.buttonAdv9.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.buttonAdv9.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.buttonAdv9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.buttonAdv9.Dock = System.Windows.Forms.DockStyle.Top
            Me.buttonAdv9.Enabled = False
            Me.buttonAdv9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv9.Location = New System.Drawing.Point(0, 290)
            Me.buttonAdv9.Name = "buttonAdv9"
            Me.buttonAdv9.Size = New System.Drawing.Size(173, 21)
            Me.buttonAdv9.TabIndex = 10
            Me.buttonAdv9.Text = "Save Template"
            Me.buttonAdv9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv9.UseVisualStyle = True
            '
            'Savebutton
            '
            Me.Savebutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.Savebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Savebutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.Savebutton.Location = New System.Drawing.Point(56, 346)
            Me.Savebutton.Name = "Savebutton"
            Me.Savebutton.Size = New System.Drawing.Size(41, 19)
            Me.Savebutton.TabIndex = 6
            Me.Savebutton.Text = "Save"
            Me.Savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Savebutton.UseVisualStyle = True
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Top
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 21)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(173, 269)
            Me.propertyGrid1.TabIndex = 7
            '
            'buttonAdv8
            '
            Me.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
            Me.buttonAdv8.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.buttonAdv8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Etched
            Me.buttonAdv8.Dock = System.Windows.Forms.DockStyle.Top
            Me.buttonAdv8.Enabled = False
            Me.buttonAdv8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv8.Location = New System.Drawing.Point(0, 0)
            Me.buttonAdv8.Name = "buttonAdv8"
            Me.buttonAdv8.Size = New System.Drawing.Size(173, 21)
            Me.buttonAdv8.TabIndex = 9
            Me.buttonAdv8.Text = "Edit Template"
            Me.buttonAdv8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv8.UseVisualStyle = True
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.White
            Me.panel3.Controls.Add(Me.chartControl1)
            Me.panel3.Location = New System.Drawing.Point(6, 3)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(451, 389)
            Me.panel3.TabIndex = 3
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.White)
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(330, 70)
            Me.chartControl1.Location = New System.Drawing.Point(3, 3)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Size = New System.Drawing.Size(445, 383)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            '
            'splitter1
            '
            Me.splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(806, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 414)
            Me.splitter1.TabIndex = 4
            Me.splitter1.TabStop = False
            '
            'statusStrip1
            '
            Me.statusStrip1.BackColor = System.Drawing.Color.Transparent
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 392)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Size = New System.Drawing.Size(806, 22)
            Me.statusStrip1.TabIndex = 5
            Me.statusStrip1.Text = "statusStrip1"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.Transparent
            Me.panel4.Controls.Add(Me.panel3)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel4.Location = New System.Drawing.Point(171, 0)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(460, 392)
            Me.panel4.TabIndex = 6
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(809, 414)
            Me.Controls.Add(Me.panel4)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.statusStrip1)
            Me.Controls.Add(Me.splitter1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Template"
            Me.panel1.ResumeLayout(False)
            Me.contextMenuStrip1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.statusStrip1.ResumeLayout(False)
            Me.statusStrip1.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private Columnbutton As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
		Private Piebutton As Syncfusion.Windows.Forms.ButtonAdv
		Private Loadbutton As Syncfusion.Windows.Forms.ButtonAdv
		Private Areabutton As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents Savebutton As Syncfusion.Windows.Forms.ButtonAdv
		Private Templatebutton As Syncfusion.Windows.Forms.ButtonAdv
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private panel3 As System.Windows.Forms.Panel
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private buttonAdv8 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv9 As Syncfusion.Windows.Forms.ButtonAdv
		Private splitter1 As System.Windows.Forms.Splitter
		Private label1 As System.Windows.Forms.Label
		Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
		Private WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private statusStrip1 As System.Windows.Forms.StatusStrip
		Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
		Private WithEvents buttonAdv7 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv10 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel4 As System.Windows.Forms.Panel
	End Class
End Namespace

