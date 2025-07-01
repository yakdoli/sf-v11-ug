Imports Microsoft.VisualBasic
Imports System
Namespace SkinManagerDemo_2008
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim ccbgroupBar1 As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
			Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.calculatorControl1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl()
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem4 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.xpTaskPane1 = New Syncfusion.Windows.Forms.Tools.XPTaskPane()
			Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer()
			Me.xpTaskPage1 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
			Me.gradientPanelExt1 = New Syncfusion.Windows.Forms.Tools.GradientPanelExt()
			Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBar1.SuspendLayout()
			CType(Me.xpTaskPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpTaskPane1.Header, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskPane1.SuspendLayout()
			Me.wizardContainer1.SuspendLayout()
			CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskPage1.SuspendLayout()
			CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanelExt1.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dockingManager1
			' 
			Me.dockingManager1.ActiveCaptionFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.dockingManager1.DockLayoutStream = (CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream))
			Me.dockingManager1.HostControl = Me
			Me.dockingManager1.InActiveCaptionFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.dockingManager1.ReduceFlickeringInRtl = False
			Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"))
			Me.dockingManager1.SetDockLabel(Me.groupBar1, "groupBar1")
			Me.dockingManager1.SetEnableDocking(Me.groupBar1, True)
			ccbgroupBar1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.groupBar1, ccbgroupBar1)
			' 
			' groupBar1
			' 
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.AnimatedSelection = False
			Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar1.Controls.Add(Me.calculatorControl1)
			Me.groupBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem1, Me.groupBarItem2, Me.groupBarItem3, Me.groupBarItem4})
			Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.IndexOnVisibleItems = True
			Me.groupBar1.Location = New System.Drawing.Point(3, 23)
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.groupBar1.SelectedItem = 3
			Me.groupBar1.Size = New System.Drawing.Size(202, 402)
			Me.groupBar1.StackedMode = True
			Me.groupBar1.TabIndex = 1
			Me.groupBar1.Text = "groupBar1"
			Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' calculatorControl1
			' 
			Me.calculatorControl1.AccessibleDescription = "Calculator control"
			Me.calculatorControl1.AccessibleName = "Calculator Control"
			Me.calculatorControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.calculatorControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255)))))))
			Me.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.calculatorControl1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.calculatorControl1.DoubleValue = 0
			Me.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.calculatorControl1.Location = New System.Drawing.Point(1, 27)
			Me.calculatorControl1.Name = "calculatorControl1"
			Me.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.calculatorControl1.Size = New System.Drawing.Size(200, 248)
			Me.calculatorControl1.TabIndex = 0
			Me.calculatorControl1.Text = "calculatorControl1"
			Me.calculatorControl1.UseVisualStyle = True
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.Client = Nothing
			Me.groupBarItem1.Text = "GroupBarItem0"
			' 
			' groupBarItem2
			' 
			Me.groupBarItem2.Client = Nothing
			Me.groupBarItem2.Text = "GroupBarItem1"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.Client = Nothing
			Me.groupBarItem3.Text = "GroupBarItem2"
			' 
			' groupBarItem4
			' 
			Me.groupBarItem4.Client = Me.calculatorControl1
			Me.groupBarItem4.Text = "GroupBarItem3"
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Form", "DockingManager", "GroupBar", "Calculator"})
			Me.comboBox1.Location = New System.Drawing.Point(140, 30)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(149, 21)
			Me.comboBox1.TabIndex = 3
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged)
'			Me.comboBox1.TextChanged += New System.EventHandler(Me.comboBox1_TextChanged)
			' 
			' comboBox2
			' 
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Items.AddRange(New Object() { "Office 2007 Blue", "Office 2007 Black", "Office 2007 Silver", "Managed"})
			Me.comboBox2.Location = New System.Drawing.Point(141, 68)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(147, 21)
			Me.comboBox2.TabIndex = 4
'			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox2_SelectedIndexChanged)
'			Me.comboBox2.TextChanged += New System.EventHandler(Me.comboBox2_TextChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(48, 34)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(74, 13)
			Me.label1.TabIndex = 5
			Me.label1.Text = "Parent Control"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(49, 71)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(71, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Visual Theme"
			' 
			' xpTaskPane1
			' 
			Me.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(255))))))
			Me.xpTaskPane1.Controls.Add(Me.wizardContainer1)
			' 
			' 
			' 
			Me.xpTaskPane1.Header.BackColor = System.Drawing.Color.Transparent
			Me.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPane1.Header.Controls.Add(Me.xpTaskPane1.HeaderLabel)
			Me.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskPane1.Header.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPane1.Header.Name = "header"
			Me.xpTaskPane1.Header.Size = New System.Drawing.Size(347, 22)
			Me.xpTaskPane1.Header.TabIndex = 2
			' 
			' 
			' 
			Me.xpTaskPane1.HeaderMenuItem.ImageIndex = 2
			Me.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.xpTaskPane1.Location = New System.Drawing.Point(218, 227)
			Me.xpTaskPane1.Name = "xpTaskPane1"
			Me.xpTaskPane1.SelectedPage = Me.xpTaskPage1
			Me.xpTaskPane1.Size = New System.Drawing.Size(351, 238)
			Me.xpTaskPane1.TabIndex = 7
			Me.xpTaskPane1.TaskPages = New Syncfusion.Windows.Forms.Tools.XPTaskPage() { Me.xpTaskPage1}
			Me.xpTaskPane1.TaskPanePageContainer = Me.wizardContainer1
			Me.xpTaskPane1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' wizardContainer1
			' 
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage1)
			Me.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.wizardContainer1.Location = New System.Drawing.Point(0, 22)
			Me.wizardContainer1.Name = "wizardContainer1"
			Me.wizardContainer1.Size = New System.Drawing.Size(347, 212)
			Me.wizardContainer1.TabIndex = 6
			' 
			' xpTaskPage1
			' 
			Me.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage1.Controls.Add(Me.colorPickerUIAdv1)
			Me.xpTaskPage1.LayoutName = "Card1"
			Me.xpTaskPage1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPage1.Name = "xpTaskPage1"
			Me.xpTaskPage1.NextPage = Nothing
			Me.xpTaskPage1.PreviousPage = Nothing
			Me.xpTaskPage1.Size = New System.Drawing.Size(347, 212)
			Me.xpTaskPage1.TabIndex = 0
			Me.xpTaskPage1.Title = "Page Title"
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
			Me.colorPickerUIAdv1.HorizontalItemsSpacing = 20
			Me.colorPickerUIAdv1.Location = New System.Drawing.Point(15, 3)
			Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
			Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(247))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(140))))))
			Me.colorPickerUIAdv1.Size = New System.Drawing.Size(316, 199)
			Me.colorPickerUIAdv1.TabIndex = 0
			Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.VerticalItemsSpacing = 1
'			Me.colorPickerUIAdv1.Picked += New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(Me.colorPickerUIAdv1_Picked)
			' 
			' gradientPanelExt1
			' 
			Me.gradientPanelExt1.BackColor = System.Drawing.Color.Transparent
			Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.SystemColors.GradientInactiveCaption, System.Drawing.SystemColors.GradientInactiveCaption)
			Me.gradientPanelExt1.Border = New System.Windows.Forms.Padding(12)
			Me.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanelExt1.Controls.Add(Me.autoLabel1)
			Me.gradientPanelExt1.Controls.Add(Me.label2)
			Me.gradientPanelExt1.Controls.Add(Me.label1)
			Me.gradientPanelExt1.Controls.Add(Me.comboBox2)
			Me.gradientPanelExt1.Controls.Add(Me.comboBox1)
			Me.gradientPanelExt1.Location = New System.Drawing.Point(218, 45)
			Me.gradientPanelExt1.Name = "gradientPanelExt1"
			Me.gradientPanelExt1.Size = New System.Drawing.Size(349, 178)
			Me.gradientPanelExt1.TabIndex = 12
			' 
			' autoLabel1
			' 
			Me.autoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.autoLabel1.Location = New System.Drawing.Point(57, 116)
			Me.autoLabel1.Name = "autoLabel1"
			Me.autoLabel1.Size = New System.Drawing.Size(244, 15)
			Me.autoLabel1.TabIndex = 10
			Me.autoLabel1.Text = "Use Color Picker for Managed Colors"
			Me.autoLabel1.Visible = False
'			Me.autoLabel1.Click += New System.EventHandler(Me.autoLabel1_Click)
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel1, Me.toolStripLabel2})
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 0)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.Size = New System.Drawing.Size(573, 40)
			Me.toolStripEx1.TabIndex = 0
			Me.toolStripEx1.Text = "Syncfusion"
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(25, 22)
			Me.toolStripLabel1.Text = "File"
			' 
			' toolStripLabel2
			' 
			Me.toolStripLabel2.Name = "toolStripLabel2"
			Me.toolStripLabel2.Size = New System.Drawing.Size(27, 22)
			Me.toolStripLabel2.Text = "Edit"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(573, 468)
			Me.Controls.Add(Me.xpTaskPane1)
			Me.Controls.Add(Me.toolStripEx1)
			Me.Controls.Add(Me.gradientPanelExt1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "SkinManager Demo"
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBar1.ResumeLayout(False)
			CType(Me.xpTaskPane1.Header, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpTaskPane1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskPane1.ResumeLayout(False)
			Me.wizardContainer1.ResumeLayout(False)
			CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskPage1.ResumeLayout(False)
			CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanelExt1.ResumeLayout(False)
			Me.gradientPanelExt1.PerformLayout()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private calculatorControl1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem4 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private xpTaskPane1 As Syncfusion.Windows.Forms.Tools.XPTaskPane
		Private wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
		Private xpTaskPage1 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private WithEvents colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private gradientPanelExt1 As Syncfusion.Windows.Forms.Tools.GradientPanelExt
		Private WithEvents autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripLabel2 As System.Windows.Forms.ToolStripLabel
	End Class
End Namespace

