Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace BackStageDemo
	Partial Public Class Form1
		Inherits RibbonForm
		Private toolStripTabGroup1 As New Syncfusion.Windows.Forms.Tools.ToolStripTabGroup()
		Private colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Public Sub New()
			InitializeComponent()


		End Sub

		Private Sub colorPickerUIAdv1_ItemSelection(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)

		End Sub

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			Me.ribbonControlAdv1.MenuColor = Me.colorPickerUIAdv1.SelectedColor
			toolStripTabGroup1.Color = Me.ribbonControlAdv1.MenuColor
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub backStageButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton1.Click


		End Sub

		Private Sub backStageButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton2.Click

		End Sub

		Private Sub backStageButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton3.Click

		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.backStageButton1.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton1.Enabled = False
            Me.backStageButton1.Image = My.Resources.Save16
            Me.backStageButton1.Location = New System.Drawing.Point(10, 0)
            Me.backStageButton1.Name = "backStageButton1"
            Me.backStageButton1.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton1.TabIndex = 2
            Me.backStageButton1.Text = "Save"
            '			Me.backStageButton1.Click += New System.EventHandler(Me.backStageButton1_Click)
            ' 
            ' backStageButton2
            ' 
            Me.backStageButton2.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton2.Image = My.Resources.SaveAs32
            Me.backStageButton2.Location = New System.Drawing.Point(10, 25)
            Me.backStageButton2.Name = "backStageButton2"
            Me.backStageButton2.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton2.TabIndex = 3
            Me.backStageButton2.Text = "Save As"
            '			Me.backStageButton2.Click += New System.EventHandler(Me.backStageButton2_Click)
            ' 
            ' backStageButton3
            ' 
            Me.backStageButton3.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton3.Image = My.Resources.Open32
            Me.backStageButton3.Location = New System.Drawing.Point(10, 50)
            Me.backStageButton3.Name = "backStageButton3"
            Me.backStageButton3.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton3.TabIndex = 4
            Me.backStageButton3.Text = "Open"
            '			Me.backStageButton3.Click += New System.EventHandler(Me.backStageButton3_Click)
            ' 
            ' backStageButton4
            ' 
            Me.backStageButton4.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton4.Image = My.Resources.Close32
            Me.backStageButton4.Location = New System.Drawing.Point(10, 75)
            Me.backStageButton4.Name = "backStageButton4"
            Me.backStageButton4.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton4.TabIndex = 5
            Me.backStageButton4.Text = "Close"
            Me.backStageButton5.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton5.Image = My.Resources.Options
            Me.backStageButton5.Location = New System.Drawing.Point(10, 322)
            Me.backStageButton5.Name = "backStageButton5"
            Me.backStageButton5.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton5.TabIndex = 12
            Me.backStageButton5.Text = "Option"
            ' 
            ' backStageButton6
            ' 
            Me.backStageButton6.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton6.Image = My.Resources.Exit
            Me.backStageButton6.Location = New System.Drawing.Point(10, 347)
            Me.backStageButton6.Name = "backStageButton6"
            Me.backStageButton6.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton6.TabIndex = 13
            Me.backStageButton6.Text = "Exit"
            Me.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton11.Image = My.Resources.GrowFont16
            Me.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton11.Text = "toolStripButton11"
            ' 
            ' toolStripButton16
            ' 
            Me.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton16.Image = My.Resources.ShrinkFont16
            Me.toolStripButton16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton16.Name = "toolStripButton16"
            Me.toolStripButton16.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton16.Text = "toolStripButton16"
            ' 
            ' toolStripPanelItem4
            ' 
            Me.toolStripPanelItem4.AutoSize = False
            Me.toolStripPanelItem4.CausesValidation = False
            Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton5, Me.toolStripButton6, Me.toolStripButton7, Me.toolStripButton8, Me.toolStripButton9, Me.toolStripButton10, Me.toolStripSeparator1, Me.toolStripSplitButtonEx1, Me.toolStripSplitButtonEx3, Me.toolStripButton17, Me.toolStripButton18})
            Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
            Me.toolStripPanelItem4.RowCount = 1
            Me.toolStripPanelItem4.Size = New System.Drawing.Size(210, 30)
            Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Transparent = True
            ' 
            ' toolStripButton5
            ' 
            Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton5.Image = My.Resources.Bold16
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton5.Text = "toolStripButton5"
            Me.ribbonControlAdv1.SetUseInQuickAccessMenu(Me.toolStripButton5, True)
            ' 
            ' toolStripButton6
            ' 
            Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton6.Image = My.Resources.Italic16
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton6.Text = "toolStripButton6"
            ' 
            ' toolStripButton7
            ' 
            Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton7.Image = My.Resources.Underline16
            Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton7.Name = "toolStripButton7"
            Me.toolStripButton7.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton7.Text = "toolStripButton7"
            ' 
            ' toolStripButton8
            ' 
            Me.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton8.Image = My.Resources.Strikethrough16
            Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton8.Name = "toolStripButton8"
            Me.toolStripButton8.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton8.Text = "toolStripButton8"
            ' 
            ' toolStripButton9
            ' 
            Me.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton9.Image = My.Resources.Subscript16
            Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton9.Name = "toolStripButton9"
            Me.toolStripButton9.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton9.Text = "toolStripButton9"
            ' 
            ' toolStripButton10
            ' 
            Me.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton10.Image = My.Resources.Superscript16
            Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton10.Name = "toolStripButton10"
            Me.toolStripButton10.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton10.Text = "toolStripButton10"
            Me.toolStripButton12.Image = My.Resources.CoverPage32
            Me.toolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton12.Name = "toolStripButton12"
            Me.toolStripButton12.Size = New System.Drawing.Size(68, 0)
            Me.toolStripButton12.Text = "CoverPage"
            Me.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton13
            ' 
            Me.toolStripButton13.Image = My.Resources.BlankPage32
            Me.toolStripButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton13.Name = "toolStripButton13"
            Me.toolStripButton13.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton13.Text = "Blankpage"
            Me.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton14
            ' 
            Me.toolStripButton14.Image = My.Resources.PageBreak32
            Me.toolStripButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton14.Name = "toolStripButton14"
            Me.toolStripButton14.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton14.Text = "PageBreak"
            Me.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.toolStripButton15.Image = My.Resources.Picture32
            Me.toolStripButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton15.Name = "toolStripButton15"
            Me.toolStripButton15.Size = New System.Drawing.Size(48, 0)
            Me.toolStripButton15.Text = "Picture"
            Me.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText

            Me.toolStripButton24.Image = My.Resources.BlankPage32
            Me.toolStripButton24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton24.Name = "toolStripButton24"
            Me.toolStripButton24.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton24.Text = "Blankpage"
            Me.toolStripButton24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton25
            ' 
            Me.toolStripButton25.Image = My.Resources.IssueTracking_32x32
            Me.toolStripButton25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton25.Name = "toolStripButton25"
            Me.toolStripButton25.Size = New System.Drawing.Size(62, 0)
            Me.toolStripButton25.Text = "CheckList"
            Me.toolStripButton25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText

            Me.toolStripButton22.Image = My.Resources.Picture32
            Me.toolStripButton22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton22.Name = "toolStripButton22"
            Me.toolStripButton22.Size = New System.Drawing.Size(48, 89)
            Me.toolStripButton22.Text = "Picture"
            Me.toolStripButton22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripSeparator1
            ' 
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 23)
            ' 
            ' toolStripSplitButtonEx1
            ' 
            Me.toolStripSplitButtonEx1.Image = My.Resources.TextHighlightColor16
            Me.toolStripSplitButtonEx1.Name = "toolStripSplitButtonEx1"
            Me.toolStripSplitButtonEx1.Size = New System.Drawing.Size(33, 20)
            ' 
            ' toolStripSplitButtonEx3
            ' 
            Me.toolStripSplitButtonEx3.Image = My.Resources.FontColor16
            Me.toolStripSplitButtonEx3.Name = "toolStripSplitButtonEx3"
            Me.toolStripSplitButtonEx3.Size = New System.Drawing.Size(33, 20)
            ' 
            ' toolStripButton17
            ' 
            Me.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            'Me.toolStripButton17.Image = (CType(Resources.GetObject("toolStripButton17.Image"), System.Drawing.Image))
            Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton17.Name = "toolStripButton17"
            Me.toolStripButton17.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton17.Text = "toolStripButton17"
            ' 
            ' toolStripButton18
            ' 
            Me.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton18.Image = My.Resources.Save16
            Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton18.Name = "toolStripButton18"
            Me.toolStripButton18.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton18.Text = "toolStripButton18"
            ' 
            ' toolStripEx5
            ' 
            Me.toolStripEx5.AutoSize = False
            Me.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
            Me.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx5.Image = Nothing
            Me.toolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton20, Me.toolStripButton21, Me.toolStripButton29})
            Me.toolStripEx5.Location = New System.Drawing.Point(342, 1)
            Me.toolStripEx5.Name = "toolStripEx5"
            Me.toolStripEx5.Office12Mode = False
            Me.toolStripEx5.Size = New System.Drawing.Size(134, 92)
            Me.toolStripEx5.TabIndex = 4
            Me.toolStripEx5.Text = "Web"
            ' 
            ' toolStripButton20
            ' 
            Me.toolStripButton20.AutoSize = False
            Me.toolStripButton20.Image = My.Resources.base_business_contacts
            Me.toolStripButton20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton20.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton20.Name = "toolStripButton20"
            Me.toolStripButton20.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton20.Text = "Mail"
            Me.toolStripButton20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton21
            ' 
            Me.toolStripButton21.AutoSize = False
            Me.toolStripButton21.Image = My.Resources._0205_WebInsertHyperlink_32
            Me.toolStripButton21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton21.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton21.Name = "toolStripButton21"
            Me.toolStripButton21.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton21.Text = "Link"
            Me.toolStripButton21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton29
            ' 
            Me.toolStripButton29.AutoSize = False
            Me.toolStripButton29.Image = My.Resources.base_paperclip_32
            Me.toolStripButton29.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton29.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton29.Name = "toolStripButton29"
            Me.toolStripButton29.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton29.Text = "Attach"
            Me.toolStripButton29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripEx9
            ' 
            Me.toolStripEx9.AutoSize = False
            Me.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
            Me.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx9.Image = Nothing
            Me.toolStripEx9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton27, Me.toolStripButton23, Me.toolStripButton19})
            Me.toolStripEx9.Location = New System.Drawing.Point(478, 1)
            Me.toolStripEx9.Name = "toolStripEx9"
            Me.toolStripEx9.Office12Mode = False
            Me.toolStripEx9.Size = New System.Drawing.Size(146, 92)
            Me.toolStripEx9.TabIndex = 5
            Me.toolStripEx9.Text = "Picture"
            ' 
            ' toolStripButton27
            ' 
            Me.toolStripButton27.AutoSize = False
            Me.toolStripButton27.Image = My.Resources.base_map
            Me.toolStripButton27.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton27.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton27.Name = "toolStripButton27"
            Me.toolStripButton27.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton27.Text = "Map"
            Me.toolStripButton27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton23
            ' 
            Me.toolStripButton23.AutoSize = False
            Me.toolStripButton23.Image = My.Resources.base_charts
            Me.toolStripButton23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton23.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton23.Name = "toolStripButton23"
            Me.toolStripButton23.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton23.Text = "Chart"
            Me.toolStripButton23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton19
            ' 
            Me.toolStripButton19.AutoSize = False
            Me.toolStripButton19.Image = My.Resources._0202_InsertShape_32
            Me.toolStripButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton19.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton19.Name = "toolStripButton19"
            Me.toolStripButton19.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton19.Text = "Shape"
            Me.toolStripButton19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.toolStripButton26.Image = My.Resources.Table_32
            Me.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton26.Name = "toolStripButton26"
            Me.toolStripButton26.Size = New System.Drawing.Size(40, 0)
            Me.toolStripButton26.Text = "Table"
            Me.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.transparentPanel16.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel16.Image = My.Resources.Floweral
            Me.transparentPanel16.IsActive = False
            Me.transparentPanel16.Location = New System.Drawing.Point(23, 5)
            Me.transparentPanel16.Name = "transparentPanel16"
            Me.transparentPanel16.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel16.TabIndex = 5
            Me.transparentPanel16.Text = "transparentPanel16"
            ''			Me.transparentPanel16.Click += New System.EventHandler(Me.transparentPanel16_Click)
            '			' 
            '			' transparentPanel15
            '			' 
            Me.transparentPanel15.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel15.Image = My.Resources.Circles2
            Me.transparentPanel15.IsActive = False
            Me.transparentPanel15.Location = New System.Drawing.Point(147, 3)
            Me.transparentPanel15.Name = "transparentPanel15"
            Me.transparentPanel15.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel15.TabIndex = 6
            Me.transparentPanel15.Text = "transparentPanel15"
            ''			Me.transparentPanel15.Click += New System.EventHandler(Me.transparentPanel15_Click)
            '			' 
            '			' transparentPanel12
            '			' 
            Me.transparentPanel12.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel12.Image = My.Resources.Circles
            Me.transparentPanel12.IsActive = False
            Me.transparentPanel12.Location = New System.Drawing.Point(271, 5)
            Me.transparentPanel12.Name = "transparentPanel12"
            Me.transparentPanel12.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel12.TabIndex = 9
            Me.transparentPanel12.Text = "transparentPanel12"
            ''			Me.transparentPanel12.Click += New System.EventHandler(Me.transparentPanel12_Click)
            '			' 
            '			' transparentPanel14
            '			' 
            Me.transparentPanel14.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel14.Image = My.Resources.DottedArrows
            Me.transparentPanel14.IsActive = False
            Me.transparentPanel14.Location = New System.Drawing.Point(395, 5)
            Me.transparentPanel14.Name = "transparentPanel14"
            Me.transparentPanel14.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel14.TabIndex = 7
            Me.transparentPanel14.Text = "transparentPanel14"
            ''			Me.transparentPanel14.Click += New System.EventHandler(Me.transparentPanel14_Click)
            '			' 
            '			' transparentPanel13
            '			' 
            Me.transparentPanel13.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel13.Image = My.Resources.Lines
            Me.transparentPanel13.IsActive = False
            Me.transparentPanel13.Location = New System.Drawing.Point(519, 5)
            Me.transparentPanel13.Name = "transparentPanel13"
            Me.transparentPanel13.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel13.TabIndex = 8
            Me.transparentPanel13.Text = "transparentPanel13"
            '			Me.transparentPanel13.Click += New System.EventHandler(Me.transparentPanel13_Click)


            Me.transparentPanel7.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel7.Image = My.Resources.Nodes
            Me.transparentPanel7.IsActive = False
            Me.transparentPanel7.Location = New System.Drawing.Point(23, 0)
            Me.transparentPanel7.Name = "transparentPanel7"
            Me.transparentPanel7.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel7.TabIndex = 0
            Me.transparentPanel7.Text = "transparentPanel7"
            ''			Me.transparentPanel7.Click += New System.EventHandler(Me.transparentPanel7_Click)
            '			' 
            '			' transparentPanel8
            '			' 
            Me.transparentPanel8.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel8.Image = My.Resources.Birds
            Me.transparentPanel8.IsActive = False
            Me.transparentPanel8.Location = New System.Drawing.Point(147, 0)
            Me.transparentPanel8.Name = "transparentPanel8"
            Me.transparentPanel8.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel8.TabIndex = 1
            Me.transparentPanel8.Text = "transparentPanel8"
            '			Me.transparentPanel8.Click += New System.EventHandler(Me.transparentPanel8_Click)
            ' 
            ' transparentPanel9
            ' 
            Me.transparentPanel9.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel9.Image = My.Resources.Boxes3D
            Me.transparentPanel9.IsActive = False
            Me.transparentPanel9.Location = New System.Drawing.Point(271, 3)
            Me.transparentPanel9.Name = "transparentPanel9"
            Me.transparentPanel9.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel9.TabIndex = 2
            Me.transparentPanel9.Text = "transparentPanel9"
            ''			Me.transparentPanel9.Click += New System.EventHandler(Me.transparentPanel9_Click)
            '			' 
            '			' transparentPanel10
            '			' 
            Me.transparentPanel10.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel10.Image = My.Resources.Bubbles
            Me.transparentPanel10.IsActive = False
            Me.transparentPanel10.Location = New System.Drawing.Point(395, 3)
            Me.transparentPanel10.Name = "transparentPanel10"
            Me.transparentPanel10.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel10.TabIndex = 3
            Me.transparentPanel10.Text = "transparentPanel10"
            '			Me.transparentPanel10.Click += New System.EventHandler(Me.transparentPanel10_Click)
            ' 
            ' transparentPanel11
            ' 
            Me.transparentPanel11.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel11.Image = My.Resources.Butterflies
            Me.transparentPanel11.IsActive = False
            Me.transparentPanel11.Location = New System.Drawing.Point(519, 3)
            Me.transparentPanel11.Name = "transparentPanel11"
            Me.transparentPanel11.Size = New System.Drawing.Size(104, 45)
            Me.transparentPanel11.TabIndex = 4
            Me.transparentPanel11.Text = "transparentPanel11"
            Me.transparentPanel4.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel4.Image = My.Resources._2007blue
            Me.transparentPanel4.IsActive = False
            Me.transparentPanel4.Location = New System.Drawing.Point(35, 24)
            Me.transparentPanel4.Name = "transparentPanel4"
            Me.transparentPanel4.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel4.TabIndex = 3
            Me.transparentPanel4.Text = "transparentPanel4"
            ''			Me.transparentPanel4.Click += New System.EventHandler(Me.transparentPanel4_Click)
            '' 
            '' transparentPanel5
            '' 
            Me.transparentPanel5.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel5.Image = My.Resources._2007silver
            Me.transparentPanel5.IsActive = True
            Me.transparentPanel5.Location = New System.Drawing.Point(244, 24)
            Me.transparentPanel5.Name = "transparentPanel5"
            Me.transparentPanel5.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel5.TabIndex = 4
            Me.transparentPanel5.Text = "transparentPanel5"
            Me.transparentPanel6.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel6.Image = My.Resources._2007black
            Me.transparentPanel6.IsActive = False
            Me.transparentPanel6.Location = New System.Drawing.Point(453, 24)
            Me.transparentPanel6.Name = "transparentPanel6"
            Me.transparentPanel6.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel6.TabIndex = 5
            Me.transparentPanel6.Text = "transparentPanel6"
            Me.transparentPanel3.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel3.Image = My.Resources._2013
            Me.transparentPanel3.IsActive = True
            Me.transparentPanel3.Location = New System.Drawing.Point(35, 12)
            Me.transparentPanel3.Name = "transparentPanel3"
            Me.transparentPanel3.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel3.TabIndex = 2
            Me.transparentPanel3.Text = "transparentPanel3"
            '			Me.transparentPanel3.Click += New System.EventHandler(Me.transparentPanel3_Click)
            ' 
            ' transparentPanel2
            ' 
            Me.transparentPanel2.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel2.Image = My.Resources._2010blue
            Me.transparentPanel2.IsActive = False
            Me.transparentPanel2.Location = New System.Drawing.Point(244, 12)
            Me.transparentPanel2.Name = "transparentPanel2"
            Me.transparentPanel2.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel2.TabIndex = 1
            Me.transparentPanel2.Text = "transparentPanel2"
            '			Me.transparentPanel2.Click += New System.EventHandler(Me.transparentPanel2_Click)
            ' 
            ' transparentPanel1
            ' 
            Me.transparentPanel1.BackColor = System.Drawing.Color.Transparent
            Me.transparentPanel1.Image = My.Resources._2007blue
            Me.transparentPanel1.IsActive = False
            Me.transparentPanel1.Location = New System.Drawing.Point(453, 12)
            Me.transparentPanel1.Name = "transparentPanel1"
            Me.transparentPanel1.Size = New System.Drawing.Size(189, 159)
            Me.transparentPanel1.TabIndex = 0
            Me.transparentPanel1.Text = "transparentPanel1"
            '			Me.transparentPanel1.Click += New System.EventHandler(Me.transparentPanel1_Click)
            '			Me.transparentPanel6.Click += New System.EventHandler(Me.transparentPanel6_Click)
            ''			Me.transparentPanel5.Click += New System.EventHandler(Me.transparentPanel5_Click)
            '			Me.transparentPanel11.Click += New System.EventHandler(Me.transparentPanel11_Click)
            ' 
            ' toolStripEx10
            ' 
            Me.toolStripEx10.AutoSize = False
            Me.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
            Me.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx10.Image = Nothing
            Me.toolStripEx10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton28, Me.toolStripButton30})
            Me.toolStripEx10.Location = New System.Drawing.Point(626, 1)
            Me.toolStripEx10.Name = "toolStripEx10"
            Me.toolStripEx10.Office12Mode = False
            Me.toolStripEx10.Size = New System.Drawing.Size(94, 92)
            Me.toolStripEx10.TabIndex = 6
            Me.toolStripEx10.Text = "Others"
            ' 
            ' toolStripButton28
            ' 
            Me.toolStripButton28.AutoSize = False
            Me.toolStripButton28.Image = My.Resources.PrintArea
            Me.toolStripButton28.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton28.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton28.Name = "toolStripButton28"
            Me.toolStripButton28.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton28.Text = "Print"
            Me.toolStripButton28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' toolStripButton30
            ' 
            Me.toolStripButton30.AutoSize = False
            Me.toolStripButton30.Image = My.Resources._0356_NewComment_32
            Me.toolStripButton30.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton30.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton30.Name = "toolStripButton30"
            Me.toolStripButton30.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton30.Text = "Chart"
            Me.toolStripButton30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton18))
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton5))
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3))
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
            toolStripTabGroup1.Name = "Layout"
            toolStripTabGroup1.Visible = True
            ' this.ribbonControlAdv1.TabGroups.Add(toolStripTabGroup1);
            '   this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3 , toolStripTabGroup1);


            Me.toolStripButton18.Enabled = False
            Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
            Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
            ' 
            ' colorPickerUIAdv1.RecentGroup
            ' 
            Me.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
            Me.colorPickerUIAdv1.RecentGroup.Visible = False
            ' 
            ' colorPickerUIAdv1.StandardGroup
            ' 
            Me.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
            ' 
            ' colorPickerUIAdv1.ThemeGroup
            ' 
            Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
            ' 
            ' colorPickerUIAdv1
            ' 
            Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.colorPickerUIAdv1.HorizontalItemsSpacing = 5
            Me.colorPickerUIAdv1.Location = New System.Drawing.Point(25, 52)
            Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 149)
            Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
            Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
            Me.colorPickerUIAdv1.Size = New System.Drawing.Size(181, 195)
            Me.colorPickerUIAdv1.TabIndex = 0
            Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
            AddHandler colorPickerUIAdv1.ItemSelection, AddressOf colorPickerUIAdv1_ItemSelection
            AddHandler colorPickerUIAdv1.Picked, AddressOf colorPickerUIAdv1_Picked
            Me.backStageTab1.Controls.Add(Me.colorPickerUIAdv1)
            Me.colorPickerUIAdv1.Visible = False
            Me.colorPickerUIAdv1.MetroColor = Color.Blue
            getIcon(False)
            panel2.drawBorder = True
            panel3.drawline = True
            panel4.drawBorder = True

            Dim point(1) As Point
            point(0) = New Point(Me.transparentPanel3.Left + 2, Me.transparentPanel3.Top + Me.transparentPanel3.Height - 2)
            point(1) = New Point(Me.transparentPanel3.Left + Me.transparentPanel3.Width - 2, Me.transparentPanel3.Top + Me.transparentPanel3.Height - 2)
            Me.panel3.point = point
            Me.panel3.Invalidate()
            getMenu()
            Me.toolStripComboBox1.Items.Add("TimeNewRoman")
            Me.toolStripComboBox1.Items.Add("Arial")
            Me.toolStripComboBox1.Items.Add("Caibri")
            Me.toolStripComboBox1.Items.Add("Segoe UI")
            Me.toolStripComboBox2.Items.Add("1")
            Me.toolStripComboBox2.Items.Add("2")
            Me.toolStripComboBox2.Items.Add("3")
            Me.toolStripComboBox2.Items.Add("4")
            Me.toolStripComboBox2.Items.Add("5")
            Me.toolStripComboBox2.Items.Add("6")
            Me.toolStripComboBox2.Items.Add("7")
            Me.toolStripComboBox2.Items.Add("8")
            Me.toolStripComboBox2.Items.Add("9")
            Me.toolStripComboBox2.Items.Add("10")
            Me.toolStripComboBox2.Items.Add("11")
            Me.toolStripComboBox2.Items.Add("12")
            Me.toolStripComboBox2.Items.Add("13")
            Me.toolStripComboBox2.Items.Add("14")
            Me.toolStripComboBox2.Items.Add("15")
            Me.toolStripComboBox2.Items.Add("16")
            Me.toolStripComboBox2.Items.Add("17")
            Me.toolStripComboBox2.Items.Add("18")
            Me.toolStripComboBox2.Items.Add("19")
            Me.toolStripComboBox2.Items.Add("20")
            'this.transparentPanel1.drawborder = false;
            'this.transparentPanel2.drawborder = false;
            'this.transparentPanel3.drawborder = false;
            '     panel2.Size = panel3.Size;
            panel2.Location = New Point(0, 0)
        End Sub

		Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013
			ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
		End Sub




		Private Sub transparentPanel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel1.Click
			Me.panel3.drawline = True
			getDisabled()
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007
		  '  this.transparentPanel4.IsActive = true;
			Me.panel2.Visible = False
			Me.transparentPanel4.Image = My.Resources._2007blue
			Me.transparentPanel5.Image = My.Resources._2007silver
			Me.transparentPanel6.Image = My.Resources._2007black
			getIcon(True)
			Dim point(1) As Point
			point(0) = New Point (Me.transparentPanel1.Left+2, Me.transparentPanel1.Top +Me.transparentPanel1.Height-2)
			point(1) = New Point(Me.transparentPanel1.Left + Me.transparentPanel1.Width-2, Me.transparentPanel1.Top + Me.transparentPanel1.Height-2)
			Me.panel3.point = point
			Me.panel3.Invalidate()
			Me.ribbonControlAdv1.MenuButtonText = ""
			Me.ribbonControlAdv1.MenuButtonImage = My.Resources.icon


		End Sub

		Private Sub getMenu()

			Dim toolStripButton231 As New ToolStripButton()
			Dim toolStripButton81 As New ToolStripButton()
			Dim toolStripButton91 As New ToolStripButton()
			Dim toolStripButton101 As New ToolStripButton()

			Dim toolStripLabel13 As New ToolStripLabel()
			Dim toolStripLabel17 As New ToolStripLabel()
			Dim toolStripLabel18 As New ToolStripLabel()

			Dim toolStripSeparator1 As New ToolStripSeparator()

			toolStripButton231.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			toolStripButton231.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
		   ' this.toolStripButton231.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
			toolStripButton231.ImageTransparentColor = System.Drawing.Color.Magenta
			toolStripButton231.Name = "toolStripButton23"
			toolStripButton231.Padding = New System.Windows.Forms.Padding(5)
			toolStripButton231.Size = New System.Drawing.Size(128, 27)
			toolStripButton231.Text = "Recent Documents"


			' 
			' toolStripButton8
			' 
			toolStripButton81.Image = My.Resources.BlankPage32

			toolStripButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			toolStripButton81.ImageTransparentColor = System.Drawing.Color.Magenta
			toolStripButton81.Name = "toolStripButton8"
			toolStripButton81.Size = New System.Drawing.Size(69, 36)
			toolStripButton81.Text = "New"

			' 
			' toolStripButton9
			' 
		  toolStripButton91.Image = My.Resources.Open32
			toolStripButton91.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			toolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta
			toolStripButton91.Name = "toolStripButton9"
			toolStripButton91.Size = New System.Drawing.Size(69, 36)
			toolStripButton91.Text = "Open"
			' 
			' toolStripButton10
			' 
			toolStripButton101.Image = My.Resources.Save32
			  toolStripButton101.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			toolStripButton101.ImageTransparentColor = System.Drawing.Color.Magenta
			toolStripButton101.Name = "toolStripButton10"
			toolStripButton101.Size = New System.Drawing.Size(69, 36)
			toolStripButton101.Text = "Save"

			' 
			' toolStripLabel13
			' 
			toolStripLabel13.Name = "toolStripLabel13"
			toolStripLabel13.Padding = New System.Windows.Forms.Padding(5)
			toolStripLabel13.Size = New System.Drawing.Size(128, 23)
			toolStripLabel13.Text = "1. Document.doc"
			toolStripLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripLabel17
			' 
			toolStripLabel17.Name = "toolStripLabel17"
			toolStripLabel17.Padding = New System.Windows.Forms.Padding(5)
			toolStripLabel17.Size = New System.Drawing.Size(128, 23)
			toolStripLabel17.Text = "2. New Features.doc"
			toolStripLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripLabel18
			' 
			toolStripLabel18.Name = "toolStripLabel18"
			toolStripLabel18.Padding = New System.Windows.Forms.Padding(5)
			toolStripLabel18.Size = New System.Drawing.Size(128, 23)
			toolStripLabel18.Text = "3. Report.doc"
			toolStripLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

			toolStripSeparator1.Name = "toolStripSeparator1"
			toolStripSeparator1.Padding = New System.Windows.Forms.Padding(5)
			toolStripSeparator1.Size = New System.Drawing.Size(112, 2)

			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { toolStripButton231, toolStripSeparator1, toolStripLabel13, toolStripLabel17, toolStripLabel18})
			ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { toolStripButton81, toolStripButton91, toolStripButton101})
		End Sub

		Private Sub transparentPanel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel2.Click
			getDisabled()
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010
			Me.panel2.Visible = False
			Me.transparentPanel4.Image = My.Resources._2010blue
			Me.transparentPanel5.Image = My.Resources._2010
			Me.transparentPanel6.Image = My.Resources._2010black
			getIcon(True)
			Me.panel3.drawline = True
			Dim point(1) As Point
			point(0) = New Point(Me.transparentPanel2.Left+2, Me.transparentPanel2.Top + Me.transparentPanel2.Height-2)
			point(1) = New Point(Me.transparentPanel2.Left + Me.transparentPanel2.Width-2, Me.transparentPanel2.Top + Me.transparentPanel2.Height-2)
			Me.panel3.point = point
			Me.panel3.Invalidate()
			Me.ribbonControlAdv1.MenuButtonText = "File"
			Me.ribbonControlAdv1.MenuButtonImage = Nothing

		End Sub

		Private Sub transparentPanel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel3.Click
			Me.panel3.drawline = True
			getDisabled()
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013
			Me.panel2.Visible = True
			getIcon(False)
			Dim point(1) As Point
			point(0) = New Point(Me.transparentPanel3.Left+2, Me.transparentPanel3.Top + Me.transparentPanel3.Height-2)
			point(1) = New Point(Me.transparentPanel3.Left + Me.transparentPanel3.Width-2, Me.transparentPanel3.Top + Me.transparentPanel3.Height-2)
			Me.panel3.point = point
			Me.panel3.Invalidate()
			Me.ribbonControlAdv1.MenuButtonText = "File"
			Me.ribbonControlAdv1.MenuButtonImage = Nothing


		End Sub
		Private Sub getIcon(ByVal value As Boolean)
			If value Then
				Me.backStageButton6.Image = My.Resources.Exit
				Me.backStageButton5.Image = My.Resources.Options
				Me.backStageButton4.Image = My.Resources.Close32
				Me.backStageButton3.Image = My.Resources.Open32
				Me.backStageButton2.Image = My.Resources.SaveAs32
				Me.backStageButton1.Image = My.Resources.Save16
			Else
				Me.backStageButton6.Image = Nothing
				Me.backStageButton5.Image = Nothing
				Me.backStageButton4.Image = Nothing
				Me.backStageButton3.Image = Nothing
				Me.backStageButton2.Image = Nothing
				Me.backStageButton1.Image = Nothing
			End If
		End Sub

		Private Sub getDisabled()
			getDisabled(False)
		End Sub
		Private Sub getDisabled(ByVal value As Boolean)

			If Not value Then
				Me.transparentPanel1.IsActive = False
				Me.transparentPanel2.IsActive = False
				Me.transparentPanel3.IsActive = False
			Else
				Me.transparentPanel4.IsActive = False
				Me.transparentPanel5.IsActive = False
				Me.transparentPanel6.IsActive = False
			End If
		End Sub

		Private Sub transparentPanel4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel4.Click
			getDisabled(True)
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
			If transparentPanel1.IsActive Then
				Me.transparentPanel1.Image = My.Resources._2007blue

			Else
				Me.transparentPanel2.Image = My.Resources._2010blue
			End If

		End Sub

		Private Sub transparentPanel5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel5.Click
			getDisabled(True)
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
			If transparentPanel1.IsActive Then
				Me.transparentPanel1.Image = My.Resources._2007silver

			Else
				Me.transparentPanel2.Image = My.Resources._2010
			End If
		End Sub

		Private Sub transparentPanel6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel6.Click
			getDisabled(True)
			TryCast(sender, TransparentPanel).IsActive = True
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
			If transparentPanel1.IsActive Then
				Me.transparentPanel1.Image = My.Resources._2007black

			Else
				Me.transparentPanel2.Image = My.Resources._2010black
			End If
		End Sub

		Private Sub transparentPanel12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel12.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles
		End Sub

		Private Sub transparentPanel8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel8.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds
		End Sub

		Private Sub transparentPanel9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel9.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D
		End Sub

		Private Sub transparentPanel10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel10.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles
		End Sub

		Private Sub transparentPanel11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel11.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies
		End Sub

		Private Sub transparentPanel16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel16.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral
		End Sub

		Private Sub transparentPanel15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel15.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2
		End Sub

		Private Sub transparentPanel14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel14.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows
		End Sub

		Private Sub transparentPanel13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel13.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines
		End Sub

		Private Sub transparentPanel7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles transparentPanel7.Click
			getPanel()
			Dim panel As TransparentPanel = TryCast(sender, TransparentPanel)
			panel.IsActive = True
			Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes

		End Sub

		Private Sub getPanel()
			Me.transparentPanel7.IsActive = False
			Me.transparentPanel8.IsActive = False
			Me.transparentPanel9.IsActive = False
			Me.transparentPanel10.IsActive = False
			Me.transparentPanel11.IsActive = False
			Me.transparentPanel12.IsActive = False
			Me.transparentPanel13.IsActive = False
			Me.transparentPanel14.IsActive = False
			Me.transparentPanel15.IsActive = False
			Me.transparentPanel16.IsActive = False
		End Sub
	End Class


	Public Class PanelExt
		Inherits Panel
		Public drawBorder As Boolean = False

		Public drawline As Boolean = False
		Public point(1) As Point
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)

		  '  e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Dim pen As New Pen(Color.Gray, 1)
			If drawBorder Then
				e.Graphics.DrawRectangle(pen, New Rectangle(1, 1, Me.Width-3, Me.Height-4))
			End If
			If drawline Then
				'e.Graphics.DrawLine(pen, new Point(0, this.Height-1), point[0]);
				'e.Graphics.DrawLine(pen, new Point(this.Width-3 , this.Height-1), point[1]);
			End If
			pen.Dispose()
		End Sub
	End Class

	Public Class TransparentPanel
		Inherits Control
		Public drawborder As Boolean = True

		Public Sub New()
			 Me.SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
			 Me.BackColor = Color.Transparent
		End Sub

'INSTANT VB NOTE: The variable isActive was renamed since Visual Basic does not allow class members with the same name:
		Private isActive_Renamed As Boolean = False
		Public Property IsActive() As Boolean
			Get
				Return isActive_Renamed
			End Get
			Set(ByVal value As Boolean)
				isActive_Renamed = value
				Me.Invalidate()

			End Set
		End Property

'INSTANT VB NOTE: The variable image was renamed since Visual Basic does not allow class members with the same name:
		Private image_Renamed As Image = Nothing

		Public Property Image() As Image
			Get
				Return image_Renamed
			End Get
			Set(ByVal value As Image)
				image_Renamed = value
				Me.Invalidate()
			End Set
		End Property

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim brush As New SolidBrush(Color.FromArgb(100, Color.Gray))
			e.Graphics.FillRectangle(brush, New Rectangle(0, 0, Me.Width, Me.Height))
			brush.Dispose()
			If IsActive Then
				If Image IsNot Nothing Then
					e.Graphics.DrawImage(Image, New Point(0, 0))
				End If
				If drawborder Then
					Dim pen As New Pen(Color.RoyalBlue, 4)
					e.Graphics.DrawRectangle(pen, New Rectangle(1, 1, Me.Width - 2, Me.Height - 2))
					pen.Dispose()
				Else
					Dim pen As New Pen(Color.RoyalBlue, 4)
					e.Graphics.DrawRectangle(pen, New Rectangle(1, 1, Me.Width - 2, Me.Height +5))
					pen.Dispose()
				End If
			Else

					If Image IsNot Nothing Then
						ControlPaint.DrawImageDisabled(e.Graphics, Image, 0, 0, Color.Red)
					End If
					Dim pen As New Pen(Color.Gray)
					e.Graphics.DrawRectangle(pen, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
					pen.Dispose()

			End If
		End Sub
	End Class
End Namespace
