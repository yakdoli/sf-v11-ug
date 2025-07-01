Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports System.Resources
Imports Syncfusion.Windows.Forms
Imports System.Diagnostics
Imports Syncfusion.Windows.Forms.Tools.Design

Namespace xptabs
	Public Class TabControlAdvFrame
		Inherits Office2007Form
		#Region "Declaration"
		Private imageList As System.Windows.Forms.ImageList
		Private label1 As Label
		Private WithEvents FormTabControl As TabControlAdv
		Private tab3 As TabPageAdv
		Private tab4 As TabPageAdv
		Private tab6 As TabPageAdv
		Private label40 As Label
		Private WithEvents PrimitivesTabControl As TabControlAdv
		Private gradientPanel1 As GradientPanel
		Private label2 As Label
		Private WithEvents BehaviorTabControl As TabControlAdv
		Private tabPageAdv3 As TabPageAdv
		Private tabPageAdv4 As TabPageAdv
		Private tabPageAdv5 As TabPageAdv
		Private tabPageAdv6 As TabPageAdv
		Private tabPageAdv7 As TabPageAdv
		Private tabPageAdv8 As TabPageAdv
		Private label6 As Label
		Private label7 As Label
		Private label9 As Label
		Private WithEvents checkBox6 As CheckBox
		Private WithEvents checkBox5 As CheckBox
		Private WithEvents checkBox4 As CheckBox
		Private WithEvents checkBox3 As CheckBox
		Private WithEvents checkBox2 As CheckBox
		Private WithEvents checkBox1 As CheckBox
		Private toolTip1 As ToolTip
		Private label11 As Label
		Private WithEvents checkBox7 As CheckBox
		Private label13 As Label
		Private WithEvents checkBox9 As CheckBox
		Private WithEvents checkBox8 As CheckBox
		Private WithEvents checkBox14 As CheckBox
		Private WithEvents checkBox13 As CheckBox
		Private WithEvents checkBox12 As CheckBox
		Private WithEvents checkBox11 As CheckBox
		Private WithEvents checkBox10 As CheckBox
		Private WithEvents checkBox17 As CheckBox
		Private label5 As Label
		Private label14 As Label
		Private label17 As Label
		Private label16 As Label
		Private label15 As Label
		Private label18 As Label
		Private colorDialog1 As ColorDialog
		Private WithEvents activeTabColorEdit As ButtonEdit
		Private buttonEditChildButton1 As ButtonEditChildButton
		Private textBoxExt1 As TextBoxExt
		Private WithEvents panelColorEdit As ButtonEdit
		Private buttonEditChildButton4 As ButtonEditChildButton
		Private WithEvents borderColorEdit As ButtonEdit
		Private buttonEditChildButton3 As ButtonEditChildButton
		Private WithEvents inactiveTabColorEdit As ButtonEdit
		Private buttonEditChildButton2 As ButtonEditChildButton
		Private label19 As Label
		Private label20 As Label
		Private label23 As Label
		Private label22 As Label
		Private label21 As Label
		Private label24 As Label
		Private WithEvents checkBox24 As CheckBox
		Private WithEvents checkBox23 As CheckBox
		Private WithEvents checkBox22 As CheckBox
		Private WithEvents checkBox21 As CheckBox
		Private WithEvents checkBox20 As CheckBox
		Private WithEvents checkBox19 As CheckBox
		Private WithEvents checkBox18 As CheckBox
		Private WithEvents comboBox3 As ComboBox
		Private WithEvents comboBox2 As ComboBox
		Private label25 As Label
		Private WithEvents comboBox1 As ComboBox
		Private label30 As Label
		Private label29 As Label
		Private label28 As Label
		Private WithEvents numericUpDown1 As NumericUpDown
		Private label3 As Label
		Private tabPageAdv1 As TabPageAdv
		Private tabPageAdv2 As TabPageAdv
		Private tabPageAdv9 As TabPageAdv
		Private tabPageAdv10 As TabPageAdv
		Private tabPageAdv11 As TabPageAdv
		Private WithEvents contextMenuStripEx1 As ContextMenuStripEx
		Private WithEvents addTabToolStripMenuItem As ToolStripMenuItem
		Private WithEvents contextMenuCheck As CheckBox
		Private label4 As Label
		Private tabPoint As Point
		Private WithEvents checkBox16 As CheckBox
		Private label31 As Label
		Private tabPageAdv12 As TabPageAdv
		Private tabPageAdv13 As TabPageAdv
		Private label32 As Label
		Private label33 As Label
		Private label35 As Label
		Private label34 As Label
		Private label26 As Label
		Private label8 As Label
		Private label10 As Label
		Private listBox1 As ListBox
		Private label12 As Label
		Private label27 As Label
		Private label37 As Label
		Private WithEvents checkBox15 As CheckBox
		Private WithEvents checkBox25 As CheckBox
		Private components As System.ComponentModel.IContainer

		Private Appearance, Behavior, Tab_Primitives, tabPage1 As TabPageAdv
		Private label36 As Label
		Private label38 As Label
		Private WithEvents checkBox26 As CheckBox
		Private superToolTip1 As SuperToolTip

#End Region '-

		#Region "Form constructor, Main & Dispose"
		Public Sub New()
			InitializeComponent()

			PopulateTabStyles()
			InitializeItems()



			For Each tp As TabPageAdv In BehaviorTabControl.TabPages
				AddHandler tp.Closing, AddressOf tp_Closing
				AddHandler tp.Closed, AddressOf tp_Closed
			Next tp

            AddHandler Load, AddressOf TabControlAdvFrame_Load
        End Sub

        Private Sub TabControlAdvFrame_Load(ByVal sender As Object, ByVal e As EventArgs)
            tab6.Image = Image.FromFile("../../../Data/appearance.gif")
            tab3.Image = Image.FromFile("../../../Data/behaviour.gif")
            tab4.Image = Image.FromFile("../../../Data/primitives.gif")
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
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New TabControlAdvFrame())
		End Sub
#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TabControlAdvFrame))
			Dim toolTipInfo1 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo2 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo3 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Me.imageList = New System.Windows.Forms.ImageList(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.FormTabControl = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.contextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
			Me.addTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tab6 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.checkBox26 = New System.Windows.Forms.CheckBox()
			Me.label38 = New System.Windows.Forms.Label()
			Me.label36 = New System.Windows.Forms.Label()
			Me.label32 = New System.Windows.Forms.Label()
			Me.checkBox16 = New System.Windows.Forms.CheckBox()
			Me.label31 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.contextMenuCheck = New System.Windows.Forms.CheckBox()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.label20 = New System.Windows.Forms.Label()
			Me.label25 = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label30 = New System.Windows.Forms.Label()
			Me.label29 = New System.Windows.Forms.Label()
			Me.label28 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.comboBox3 = New System.Windows.Forms.ComboBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.label24 = New System.Windows.Forms.Label()
			Me.label23 = New System.Windows.Forms.Label()
			Me.label22 = New System.Windows.Forms.Label()
			Me.label21 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.panelColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.borderColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.inactiveTabColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.activeTabColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.checkBox17 = New System.Windows.Forms.CheckBox()
			Me.checkBox14 = New System.Windows.Forms.CheckBox()
			Me.checkBox13 = New System.Windows.Forms.CheckBox()
			Me.checkBox12 = New System.Windows.Forms.CheckBox()
			Me.checkBox11 = New System.Windows.Forms.CheckBox()
			Me.checkBox10 = New System.Windows.Forms.CheckBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.tab3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label37 = New System.Windows.Forms.Label()
			Me.checkBox15 = New System.Windows.Forms.CheckBox()
			Me.checkBox25 = New System.Windows.Forms.CheckBox()
			Me.checkBox21 = New System.Windows.Forms.CheckBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label27 = New System.Windows.Forms.Label()
			Me.checkBox24 = New System.Windows.Forms.CheckBox()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.checkBox23 = New System.Windows.Forms.CheckBox()
			Me.BehaviorTabControl = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv5 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv12 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv13 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv11 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv9 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv10 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv6 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv8 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.checkBox22 = New System.Windows.Forms.CheckBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.checkBox20 = New System.Windows.Forms.CheckBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.checkBox19 = New System.Windows.Forms.CheckBox()
			Me.checkBox18 = New System.Windows.Forms.CheckBox()
			Me.tab4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label40 = New System.Windows.Forms.Label()
			Me.PrimitivesTabControl = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv7 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label35 = New System.Windows.Forms.Label()
			Me.label34 = New System.Windows.Forms.Label()
			Me.label26 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.checkBox9 = New System.Windows.Forms.CheckBox()
			Me.checkBox8 = New System.Windows.Forms.CheckBox()
			Me.checkBox7 = New System.Windows.Forms.CheckBox()
			Me.checkBox6 = New System.Windows.Forms.CheckBox()
			Me.checkBox5 = New System.Windows.Forms.CheckBox()
			Me.checkBox4 = New System.Windows.Forms.CheckBox()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label33 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
			CType(Me.FormTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.FormTabControl.SuspendLayout()
			Me.contextMenuStripEx1.SuspendLayout()
			Me.tab6.SuspendLayout()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelColorEdit.SuspendLayout()
			CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.borderColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.borderColorEdit.SuspendLayout()
			CType(Me.inactiveTabColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.inactiveTabColorEdit.SuspendLayout()
			CType(Me.activeTabColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.activeTabColorEdit.SuspendLayout()
			Me.tab3.SuspendLayout()
			CType(Me.BehaviorTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.BehaviorTabControl.SuspendLayout()
			Me.tab4.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			CType(Me.PrimitivesTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.PrimitivesTabControl.SuspendLayout()
			Me.tabPageAdv7.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList
			' 
			Me.imageList.ImageStream = (CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList.Images.SetKeyName(0, "user_24.png")
			Me.imageList.Images.SetKeyName(1, "clip_24.png")
			Me.imageList.Images.SetKeyName(2, "sphere_24.png")
			Me.imageList.Images.SetKeyName(3, "ellipse_24_hot.png")
			Me.imageList.Images.SetKeyName(4, "mergedfield_icon_16.png")
			Me.imageList.Images.SetKeyName(5, "group_icon_16.png")
			Me.imageList.Images.SetKeyName(6, "primitives.gif")
			Me.imageList.Images.SetKeyName(7, "apperance.gif")
			Me.imageList.Images.SetKeyName(8, "behaviour.gif")
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(192, 14)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "VS 2005 Style"
			' 
			' FormTabControl
			' 
			Me.FormTabControl.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.FormTabControl.AdjustTopGap = 10
			Me.FormTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.FormTabControl.ContextMenuStrip = Me.contextMenuStripEx1
			Me.FormTabControl.Controls.Add(Me.tab6)
			Me.FormTabControl.Controls.Add(Me.tab3)
			Me.FormTabControl.Controls.Add(Me.tab4)
			Me.FormTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.FormTabControl.FocusOnTabClick = False
			Me.FormTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormTabControl.HotTrack = True
			Me.FormTabControl.ImageList = Me.imageList
			Me.FormTabControl.ImageOffset = 10
			Me.FormTabControl.LevelTextAndImage = True
			Me.FormTabControl.Location = New System.Drawing.Point(12, 1)
			Me.FormTabControl.Name = "FormTabControl"
			Me.FormTabControl.ShowSuperToolTips = True
			Me.FormTabControl.ShowToolTips = True
			Me.FormTabControl.Size = New System.Drawing.Size(576, 448)
			Me.FormTabControl.TabGap = 10
			Me.FormTabControl.TabIndex = 14
			Me.FormTabControl.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.FormTabControl.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
			Me.FormTabControl.UserMoveTabs = True
'			Me.FormTabControl.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.FormTabControl_MouseDown)
			' 
			' contextMenuStripEx1
			' 
			Me.contextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.addTabToolStripMenuItem})
			Me.contextMenuStripEx1.Name = "contextMenuStripEx1"
			Me.contextMenuStripEx1.Size = New System.Drawing.Size(126, 51)
			Me.contextMenuStripEx1.Text = "Options"
'			Me.contextMenuStripEx1.Opening += New System.ComponentModel.CancelEventHandler(Me.contextMenuStripEx1_Opening)
			' 
			' addTabToolStripMenuItem
			' 
			Me.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem"
			Me.addTabToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
			Me.addTabToolStripMenuItem.Text = "Add Tab"
'			Me.addTabToolStripMenuItem.Click += New System.EventHandler(Me.addTabToolStripMenuItem_Click)
			' 
			' tab6
			' 
			Me.tab6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(250))))))
			Me.tab6.Controls.Add(Me.checkBox26)
			Me.tab6.Controls.Add(Me.label38)
			Me.tab6.Controls.Add(Me.label36)
			Me.tab6.Controls.Add(Me.label32)
			Me.tab6.Controls.Add(Me.checkBox16)
			Me.tab6.Controls.Add(Me.label31)
			Me.tab6.Controls.Add(Me.label4)
			Me.tab6.Controls.Add(Me.contextMenuCheck)
			Me.tab6.Controls.Add(Me.numericUpDown1)
			Me.tab6.Controls.Add(Me.label20)
			Me.tab6.Controls.Add(Me.label25)
			Me.tab6.Controls.Add(Me.comboBox1)
			Me.tab6.Controls.Add(Me.label30)
			Me.tab6.Controls.Add(Me.label29)
			Me.tab6.Controls.Add(Me.label28)
			Me.tab6.Controls.Add(Me.label14)
			Me.tab6.Controls.Add(Me.label7)
			Me.tab6.Controls.Add(Me.comboBox3)
			Me.tab6.Controls.Add(Me.comboBox2)
			Me.tab6.Controls.Add(Me.label24)
			Me.tab6.Controls.Add(Me.label23)
			Me.tab6.Controls.Add(Me.label22)
			Me.tab6.Controls.Add(Me.label21)
			Me.tab6.Controls.Add(Me.label19)
			Me.tab6.Controls.Add(Me.panelColorEdit)
			Me.tab6.Controls.Add(Me.borderColorEdit)
			Me.tab6.Controls.Add(Me.inactiveTabColorEdit)
			Me.tab6.Controls.Add(Me.activeTabColorEdit)
			Me.tab6.Controls.Add(Me.label17)
			Me.tab6.Controls.Add(Me.label16)
			Me.tab6.Controls.Add(Me.label18)
			Me.tab6.Controls.Add(Me.label15)
			Me.tab6.Controls.Add(Me.label5)
			Me.tab6.Controls.Add(Me.checkBox17)
			Me.tab6.Controls.Add(Me.checkBox14)
			Me.tab6.Controls.Add(Me.checkBox13)
			Me.tab6.Controls.Add(Me.checkBox12)
			Me.tab6.Controls.Add(Me.checkBox11)
			Me.tab6.Controls.Add(Me.checkBox10)
			Me.tab6.Controls.Add(Me.label6)
			Me.tab6.Image = Nothing
			Me.tab6.ImageIndex = 0
			Me.tab6.ImageSize = New System.Drawing.Size(16, 16)
			Me.tab6.Location = New System.Drawing.Point(1, 43)
			Me.tab6.Name = "tab6"
			Me.tab6.Size = New System.Drawing.Size(574, 404)
			toolTipInfo1.Header.Text = "Appearance"
			Me.tab6.SuperTooltip = toolTipInfo1
			Me.tab6.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tab6.TabIndex = 7
			Me.tab6.Text = "Appearance"
            Me.tab6.ThemesEnabled = False
			' 
			' checkBox26
			' 
			Me.checkBox26.AutoSize = True
			Me.checkBox26.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox26.Location = New System.Drawing.Point(374, 162)
			Me.checkBox26.Name = "checkBox26"
			Me.checkBox26.Size = New System.Drawing.Size(103, 32)
			Me.checkBox26.TabIndex = 44
			Me.checkBox26.Tag = "outsidebounds"
			Me.checkBox26.Text = "Show Animated" & Constants.vbCrLf & "Tab Image"
			Me.checkBox26.UseVisualStyleBackColor = True
'			Me.checkBox26.CheckedChanged += New System.EventHandler(Me.checkBox26_CheckedChanged)
			' 
			' label38
			' 
			Me.label38.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label38.Location = New System.Drawing.Point(87, 138)
			Me.label38.Name = "label38"
			Me.label38.Size = New System.Drawing.Size(470, 1)
			Me.label38.TabIndex = 43
			' 
			' label36
			' 
			Me.label36.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label36.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label36.Image = (CType(resources.GetObject("label36.Image"), System.Drawing.Image))
			Me.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label36.Location = New System.Drawing.Point(18, 124)
			Me.label36.Name = "label36"
			Me.label36.Size = New System.Drawing.Size(62, 24)
			Me.label36.TabIndex = 42
			Me.label36.Text = "Image"
			Me.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label32
			' 
			Me.label32.Image = (CType(resources.GetObject("label32.Image"), System.Drawing.Image))
			Me.label32.Location = New System.Drawing.Point(449, 49)
			Me.label32.Name = "label32"
			Me.label32.Size = New System.Drawing.Size(20, 20)
			Me.label32.TabIndex = 41
			Me.toolTip1.SetToolTip(Me.label32, "Will be shown if the no of tabs " & Constants.vbCrLf & "exceed control width. Add more " & Constants.vbCrLf & "tabs to see th" & "e scrolls.")
			' 
			' checkBox16
			' 
			Me.checkBox16.AutoSize = True
			Me.checkBox16.Location = New System.Drawing.Point(212, 80)
			Me.checkBox16.Name = "checkBox16"
			Me.checkBox16.Size = New System.Drawing.Size(107, 17)
			Me.checkBox16.TabIndex = 39
			Me.checkBox16.Tag = "persist"
			Me.checkBox16.Text = "Persist Tab State"
			Me.checkBox16.UseVisualStyleBackColor = True
'			Me.checkBox16.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' label31
			' 
			Me.label31.Image = (CType(resources.GetObject("label31.Image"), System.Drawing.Image))
			Me.label31.Location = New System.Drawing.Point(319, 80)
			Me.label31.Name = "label31"
			Me.label31.Size = New System.Drawing.Size(20, 20)
			Me.label31.TabIndex = 40
			Me.toolTip1.SetToolTip(Me.label31, "Persist the following:" & Constants.vbCrLf & Constants.vbCrLf & "Active Tab" & Constants.vbCrLf & "TabOrder" & Constants.vbCrLf & "Renamed tab text")
			' 
			' label4
			' 
			Me.label4.Image = (CType(resources.GetObject("label4.Image"), System.Drawing.Image))
			Me.label4.Location = New System.Drawing.Point(183, 47)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(20, 20)
			Me.label4.TabIndex = 38
			Me.toolTip1.SetToolTip(Me.label4, "Right on Tabs to see " & Constants.vbCrLf & "a context menu. It is " & Constants.vbCrLf & "set to show only  on " & Constants.vbCrLf & "tabs throug" & "h code.")
			' 
			' contextMenuCheck
			' 
			Me.contextMenuCheck.AutoSize = True
			Me.contextMenuCheck.Location = New System.Drawing.Point(25, 49)
			Me.contextMenuCheck.Name = "contextMenuCheck"
			Me.contextMenuCheck.Size = New System.Drawing.Size(160, 17)
			Me.contextMenuCheck.TabIndex = 37
			Me.contextMenuCheck.Tag = "contextmenu"
			Me.contextMenuCheck.Text = "Show Custom Context Menu"
			Me.contextMenuCheck.UseVisualStyleBackColor = True
'			Me.contextMenuCheck.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.Location = New System.Drawing.Point(418, 362)
			Me.numericUpDown1.Maximum = New Decimal(New Integer() { 35, 0, 0, 0})
			Me.numericUpDown1.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(131, 20)
			Me.numericUpDown1.TabIndex = 36
			Me.numericUpDown1.Value = New Decimal(New Integer() { 10, 0, 0, 0})
'			Me.numericUpDown1.ValueChanged += New System.EventHandler(Me.numericUpDown1_ValueChanged)
			' 
			' label20
			' 
			Me.label20.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label20.Location = New System.Drawing.Point(371, 219)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(170, 1)
			Me.label20.TabIndex = 22
			' 
			' label25
			' 
			Me.label25.AutoSize = True
			Me.label25.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label25.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label25.Location = New System.Drawing.Point(304, 252)
			Me.label25.Name = "label25"
			Me.label25.Size = New System.Drawing.Size(52, 14)
			Me.label25.TabIndex = 35
			Me.label25.Text = "Tab Style"
			' 
			' comboBox1
			' 
			Me.comboBox1.DropDownHeight = 200
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboBox1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.IntegralHeight = False
			Me.comboBox1.ItemHeight = 14
			Me.comboBox1.Location = New System.Drawing.Point(418, 249)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(131, 22)
			Me.comboBox1.TabIndex = 34
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged)
			' 
			' label30
			' 
			Me.label30.AutoSize = True
			Me.label30.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label30.Location = New System.Drawing.Point(304, 364)
			Me.label30.Name = "label30"
			Me.label30.Size = New System.Drawing.Size(48, 14)
			Me.label30.TabIndex = 33
			Me.label30.Text = "Tab Gap"
			' 
			' label29
			' 
			Me.label29.AutoSize = True
			Me.label29.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label29.Location = New System.Drawing.Point(304, 326)
			Me.label29.Name = "label29"
			Me.label29.Size = New System.Drawing.Size(67, 14)
			Me.label29.TabIndex = 32
			Me.label29.Text = "Border Style"
			' 
			' label28
			' 
			Me.label28.AutoSize = True
			Me.label28.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label28.Location = New System.Drawing.Point(304, 287)
			Me.label28.Name = "label28"
			Me.label28.Size = New System.Drawing.Size(75, 14)
			Me.label28.TabIndex = 31
			Me.label28.Text = "Tab Alignment"
			' 
			' label14
			' 
			Me.label14.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label14.Location = New System.Drawing.Point(116, 220)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(155, 1)
			Me.label14.TabIndex = 13
			' 
			' label7
			' 
			Me.label7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label7.Location = New System.Drawing.Point(100, 22)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(460, 1)
			Me.label7.TabIndex = 3
			' 
			' comboBox3
			' 
			Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboBox3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox3.FormattingEnabled = True
			Me.comboBox3.Location = New System.Drawing.Point(418, 323)
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(131, 22)
			Me.comboBox3.TabIndex = 29
'			Me.comboBox3.SelectedIndexChanged += New System.EventHandler(Me.comboBox3_SelectedIndexChanged)
			' 
			' comboBox2
			' 
			Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboBox2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Items.AddRange(New Object() { "Top", "Left", "Bottom", "Right"})
			Me.comboBox2.Location = New System.Drawing.Point(418, 283)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(131, 22)
			Me.comboBox2.TabIndex = 28
'			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox2_SelectedIndexChanged)
			' 
			' label24
			' 
			Me.label24.Image = (CType(resources.GetObject("label24.Image"), System.Drawing.Image))
			Me.label24.Location = New System.Drawing.Point(317, 49)
			Me.label24.Name = "label24"
			Me.label24.Size = New System.Drawing.Size(20, 20)
			Me.label24.TabIndex = 27
			Me.toolTip1.SetToolTip(Me.label24, "Work only when 3D " & Constants.vbCrLf & "TabStyle is enabled.")
			' 
			' label23
			' 
			Me.label23.Image = (CType(resources.GetObject("label23.Image"), System.Drawing.Image))
			Me.label23.Location = New System.Drawing.Point(245, 330)
			Me.label23.Name = "label23"
			Me.label23.Size = New System.Drawing.Size(20, 20)
			Me.label23.TabIndex = 26
			Me.toolTip1.SetToolTip(Me.label23, "BorderStyle should be set " & Constants.vbCrLf & "to Fixed Single")
			' 
			' label22
			' 
			Me.label22.Image = (CType(resources.GetObject("label22.Image"), System.Drawing.Image))
			Me.label22.Location = New System.Drawing.Point(245, 287)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(20, 20)
			Me.label22.TabIndex = 25
			Me.toolTip1.SetToolTip(Me.label22, "Work for 2D, 3D, WorkBook," & Constants.vbCrLf & "OneNoteStyle, FlatTabs styles")
			' 
			' label21
			' 
			Me.label21.Image = (CType(resources.GetObject("label21.Image"), System.Drawing.Image))
			Me.label21.Location = New System.Drawing.Point(245, 252)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(20, 20)
			Me.label21.TabIndex = 24
			Me.toolTip1.SetToolTip(Me.label21, "Work for 2D, 3D, WorkBook," & Constants.vbCrLf & "OneNoteStyle, FlatTabs styles")
			' 
			' label19
			' 
			Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label19.Image = (CType(resources.GetObject("label19.Image"), System.Drawing.Image))
			Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label19.Location = New System.Drawing.Point(304, 206)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(63, 23)
			Me.label19.TabIndex = 23
			Me.label19.Text = "Styles"
			Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' panelColorEdit
			' 
			Me.panelColorEdit.Buttons.Add(Me.buttonEditChildButton4)
			Me.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.panelColorEdit.Controls.Add(Me.buttonEditChildButton4)
			Me.panelColorEdit.Controls.Add(Me.textBoxExt1)
			Me.panelColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.panelColorEdit.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panelColorEdit.Location = New System.Drawing.Point(123, 362)
			Me.panelColorEdit.Name = "panelColorEdit"
			Me.panelColorEdit.ShowTextBox = False
			Me.panelColorEdit.Size = New System.Drawing.Size(121, 26)
			Me.panelColorEdit.TabIndex = 21
			Me.panelColorEdit.TextBox = Me.textBoxExt1
'			Me.panelColorEdit.ButtonClicked += New Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(Me.panelColorEdit_ButtonClicked)
			' 
			' buttonEditChildButton4
			' 
			Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.buttonEditChildButton4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonEditChildButton4.Image = Nothing
			Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
			Me.buttonEditChildButton4.PreferredWidth = 20
			Me.buttonEditChildButton4.TabIndex = 1
			Me.buttonEditChildButton4.Text = "..."
			Me.buttonEditChildButton4.UseVisualStyleBackColor = True
			' 
			' textBoxExt1
			' 
			Me.textBoxExt1.Location = New System.Drawing.Point(3, 3)
			Me.textBoxExt1.Name = "textBoxExt1"
			Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt1.Size = New System.Drawing.Size(95, 20)
			Me.textBoxExt1.TabIndex = 0
			' 
			' borderColorEdit
			' 
			Me.borderColorEdit.Buttons.Add(Me.buttonEditChildButton3)
			Me.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.borderColorEdit.Controls.Add(Me.buttonEditChildButton3)
			Me.borderColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.borderColorEdit.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.borderColorEdit.Location = New System.Drawing.Point(123, 324)
			Me.borderColorEdit.Name = "borderColorEdit"
			Me.borderColorEdit.ShowTextBox = False
			Me.borderColorEdit.Size = New System.Drawing.Size(121, 26)
			Me.borderColorEdit.TabIndex = 20
'			Me.borderColorEdit.ButtonClicked += New Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(Me.borderColorEdit_ButtonClicked)
			' 
			' buttonEditChildButton3
			' 
			Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.buttonEditChildButton3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonEditChildButton3.Image = Nothing
			Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
			Me.buttonEditChildButton3.PreferredWidth = 20
			Me.buttonEditChildButton3.TabIndex = 1
			Me.buttonEditChildButton3.Text = "..."
			Me.buttonEditChildButton3.UseVisualStyleBackColor = True
			' 
			' inactiveTabColorEdit
			' 
			Me.inactiveTabColorEdit.Buttons.Add(Me.buttonEditChildButton2)
			Me.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.inactiveTabColorEdit.Controls.Add(Me.buttonEditChildButton2)
			Me.inactiveTabColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.inactiveTabColorEdit.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.inactiveTabColorEdit.Location = New System.Drawing.Point(123, 285)
			Me.inactiveTabColorEdit.Name = "inactiveTabColorEdit"
			Me.inactiveTabColorEdit.ShowTextBox = False
			Me.inactiveTabColorEdit.Size = New System.Drawing.Size(121, 26)
			Me.inactiveTabColorEdit.TabIndex = 19
'			Me.inactiveTabColorEdit.ButtonClicked += New Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(Me.inactiveTabColorEdit_ButtonClicked)
			' 
			' buttonEditChildButton2
			' 
			Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.buttonEditChildButton2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonEditChildButton2.Image = Nothing
			Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
			Me.buttonEditChildButton2.PreferredWidth = 20
			Me.buttonEditChildButton2.TabIndex = 1
			Me.buttonEditChildButton2.Text = "..."
			Me.buttonEditChildButton2.UseVisualStyleBackColor = True
			' 
			' activeTabColorEdit
			' 
			Me.activeTabColorEdit.Buttons.Add(Me.buttonEditChildButton1)
			Me.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.activeTabColorEdit.Controls.Add(Me.buttonEditChildButton1)
			Me.activeTabColorEdit.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.activeTabColorEdit.Location = New System.Drawing.Point(123, 248)
			Me.activeTabColorEdit.Name = "activeTabColorEdit"
			Me.activeTabColorEdit.ShowTextBox = False
			Me.activeTabColorEdit.Size = New System.Drawing.Size(121, 26)
			Me.activeTabColorEdit.TabIndex = 18
'			Me.activeTabColorEdit.ButtonClicked += New Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(Me.buttonEdit1_ButtonClicked)
			' 
			' buttonEditChildButton1
			' 
			Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonEditChildButton1.Image = Nothing
			Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
			Me.buttonEditChildButton1.PreferredWidth = 20
			Me.buttonEditChildButton1.TabIndex = 1
			Me.buttonEditChildButton1.Text = "..."
			Me.buttonEditChildButton1.UseVisualStyleBackColor = True
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label17.Location = New System.Drawing.Point(8, 363)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(109, 14)
			Me.label17.TabIndex = 17
			Me.label17.Text = "Tab Panel Back Color"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label16.Location = New System.Drawing.Point(8, 324)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(68, 14)
			Me.label16.TabIndex = 16
			Me.label16.Text = "Border Color"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label18.Location = New System.Drawing.Point(8, 287)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(93, 14)
			Me.label18.TabIndex = 15
			Me.label18.Text = "Inactive Tab Color"
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label15.Location = New System.Drawing.Point(8, 248)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(87, 14)
			Me.label15.TabIndex = 15
			Me.label15.Text = "Active Tab Color"
			' 
			' label5
			' 
			Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label5.Image = (CType(resources.GetObject("label5.Image"), System.Drawing.Image))
			Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label5.Location = New System.Drawing.Point(8, 206)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(102, 24)
			Me.label5.TabIndex = 14
			Me.label5.Text = "Color Options"
			Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' checkBox17
			' 
			Me.checkBox17.AutoSize = True
			Me.checkBox17.Checked = True
			Me.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox17.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox17.Location = New System.Drawing.Point(25, 162)
			Me.checkBox17.Name = "checkBox17"
			Me.checkBox17.Size = New System.Drawing.Size(94, 32)
			Me.checkBox17.TabIndex = 12
			Me.checkBox17.Tag = "outsidebounds"
			Me.checkBox17.Text = "Image Outside" & Constants.vbCrLf & "Tab Bounds"
			Me.checkBox17.UseVisualStyleBackColor = True
'			Me.checkBox17.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' checkBox14
			' 
			Me.checkBox14.AutoSize = True
			Me.checkBox14.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox14.Location = New System.Drawing.Point(212, 50)
			Me.checkBox14.Name = "checkBox14"
			Me.checkBox14.Size = New System.Drawing.Size(99, 18)
			Me.checkBox14.TabIndex = 9
			Me.checkBox14.Tag = "themes"
			Me.checkBox14.Text = "Enable Themes"
			Me.checkBox14.UseVisualStyleBackColor = True
'			Me.checkBox14.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' checkBox13
			' 
			Me.checkBox13.Checked = True
			Me.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox13.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox13.Location = New System.Drawing.Point(364, 43)
			Me.checkBox13.Name = "checkBox13"
			Me.checkBox13.Size = New System.Drawing.Size(87, 32)
			Me.checkBox13.TabIndex = 8
			Me.checkBox13.Tag = "scrolls"
			Me.checkBox13.Text = "Show Scroll"
			Me.checkBox13.UseVisualStyleBackColor = True
'			Me.checkBox13.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' checkBox12
			' 
			Me.checkBox12.AutoSize = True
			Me.checkBox12.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox12.Location = New System.Drawing.Point(25, 84)
			Me.checkBox12.Name = "checkBox12"
			Me.checkBox12.Size = New System.Drawing.Size(152, 18)
			Me.checkBox12.TabIndex = 7
			Me.checkBox12.Tag = "rotatetext"
			Me.checkBox12.Text = "Rotate Text When Vertical"
			Me.checkBox12.UseVisualStyleBackColor = True
'			Me.checkBox12.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' checkBox11
			' 
			Me.checkBox11.AutoSize = True
			Me.checkBox11.Checked = True
			Me.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox11.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox11.Location = New System.Drawing.Point(284, 162)
			Me.checkBox11.Name = "checkBox11"
			Me.checkBox11.Size = New System.Drawing.Size(72, 32)
			Me.checkBox11.TabIndex = 6
			Me.checkBox11.Tag = "imagealign"
			Me.checkBox11.Text = "Image " & Constants.vbCrLf & "Left Align"
			Me.checkBox11.UseVisualStyleBackColor = True
'			Me.checkBox11.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' checkBox10
			' 
			Me.checkBox10.AutoSize = True
			Me.checkBox10.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox10.Location = New System.Drawing.Point(141, 162)
			Me.checkBox10.Name = "checkBox10"
			Me.checkBox10.Size = New System.Drawing.Size(101, 32)
			Me.checkBox10.TabIndex = 5
			Me.checkBox10.Tag = "inactiveimage"
			Me.checkBox10.Text = "Disable Inactive" & Constants.vbCrLf & "Page Image"
			Me.checkBox10.UseVisualStyleBackColor = True
'			Me.checkBox10.CheckedChanged += New System.EventHandler(Me.Properties_CheckChanged)
			' 
			' label6
			' 
			Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
			Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.Location = New System.Drawing.Point(12, 9)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(84, 24)
			Me.label6.TabIndex = 4
			Me.label6.Text = "Properties"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' tab3
			' 
			Me.tab3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(250))))))
			Me.tab3.Controls.Add(Me.label3)
			Me.tab3.Controls.Add(Me.label37)
			Me.tab3.Controls.Add(Me.checkBox15)
			Me.tab3.Controls.Add(Me.checkBox25)
			Me.tab3.Controls.Add(Me.checkBox21)
			Me.tab3.Controls.Add(Me.label12)
			Me.tab3.Controls.Add(Me.label27)
			Me.tab3.Controls.Add(Me.checkBox24)
			Me.tab3.Controls.Add(Me.listBox1)
			Me.tab3.Controls.Add(Me.checkBox23)
			Me.tab3.Controls.Add(Me.BehaviorTabControl)
			Me.tab3.Controls.Add(Me.checkBox22)
			Me.tab3.Controls.Add(Me.label8)
			Me.tab3.Controls.Add(Me.checkBox20)
			Me.tab3.Controls.Add(Me.label10)
			Me.tab3.Controls.Add(Me.checkBox19)
			Me.tab3.Controls.Add(Me.checkBox18)
			Me.tab3.Image = Nothing
			Me.tab3.ImageIndex = 1
			Me.tab3.ImageSize = New System.Drawing.Size(16, 16)
			Me.tab3.Location = New System.Drawing.Point(1, 43)
			Me.tab3.Name = "tab3"
			Me.tab3.Size = New System.Drawing.Size(574, 404)
			toolTipInfo2.Header.Text = "Behavior Tab"
			Me.tab3.SuperTooltip = toolTipInfo2
			Me.tab3.TabIndex = 4
			Me.tab3.Text = "Behavior"
            Me.tab3.ThemesEnabled = False
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Image = (CType(resources.GetObject("label3.Image"), System.Drawing.Image))
			Me.label3.Location = New System.Drawing.Point(348, 152)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(20, 20)
			Me.label3.TabIndex = 28
			Me.toolTip1.SetToolTip(Me.label3, "Multiline should be true.")
			' 
			' label37
			' 
			Me.label37.Image = (CType(resources.GetObject("label37.Image"), System.Drawing.Image))
			Me.label37.Location = New System.Drawing.Point(473, 154)
			Me.label37.Name = "label37"
			Me.label37.Size = New System.Drawing.Size(20, 20)
			Me.label37.TabIndex = 47
			Me.toolTip1.SetToolTip(Me.label37, "Applicable when the TabCloseButton is shown")
			' 
			' checkBox15
			' 
			Me.checkBox15.AutoSize = True
			Me.checkBox15.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox15.Location = New System.Drawing.Point(373, 148)
			Me.checkBox15.Name = "checkBox15"
			Me.checkBox15.Size = New System.Drawing.Size(105, 32)
			Me.checkBox15.TabIndex = 46
			Me.checkBox15.Tag = "outsidebounds"
			Me.checkBox15.Text = "TabCloseButton " & Constants.vbCrLf & "for Active Tab"
			Me.checkBox15.UseVisualStyleBackColor = True
'			Me.checkBox15.CheckedChanged += New System.EventHandler(Me.checkBox15_CheckedChanged)
			' 
			' checkBox25
			' 
			Me.checkBox25.AutoSize = True
			Me.checkBox25.Checked = True
			Me.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox25.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox25.Location = New System.Drawing.Point(373, 118)
			Me.checkBox25.Name = "checkBox25"
			Me.checkBox25.Size = New System.Drawing.Size(140, 18)
			Me.checkBox25.TabIndex = 48
			Me.checkBox25.Tag = "themes"
			Me.checkBox25.Text = "Show Tab Close Button"
			Me.checkBox25.UseVisualStyleBackColor = True
'			Me.checkBox25.CheckedChanged += New System.EventHandler(Me.checkBox25_CheckedChanged)
			' 
			' checkBox21
			' 
			Me.checkBox21.AutoSize = True
			Me.checkBox21.Checked = True
			Me.checkBox21.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox21.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox21.Location = New System.Drawing.Point(242, 148)
			Me.checkBox21.Name = "checkBox21"
			Me.checkBox21.Size = New System.Drawing.Size(109, 32)
			Me.checkBox21.TabIndex = 13
			Me.checkBox21.Tag = "frontrow"
			Me.checkBox21.Text = "Keep Selected " & Constants.vbCrLf & "Tab In Front Row"
			Me.checkBox21.UseVisualStyleBackColor = True
'			Me.checkBox21.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' label12
			' 
			Me.label12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.label12.Location = New System.Drawing.Point(98, 24)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(450, 1)
			Me.label12.TabIndex = 33
			' 
			' label27
			' 
			Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label27.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(82))))), (CInt(Fix((CByte(81))))), (CInt(Fix((CByte(82))))))
			Me.label27.Image = (CType(resources.GetObject("label27.Image"), System.Drawing.Image))
			Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label27.Location = New System.Drawing.Point(18, 11)
			Me.label27.Name = "label27"
			Me.label27.Size = New System.Drawing.Size(76, 24)
			Me.label27.TabIndex = 34
			Me.label27.Text = "Behavior"
			Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' checkBox24
			' 
			Me.checkBox24.AutoSize = True
			Me.checkBox24.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox24.Location = New System.Drawing.Point(499, 155)
			Me.checkBox24.Name = "checkBox24"
			Me.checkBox24.Size = New System.Drawing.Size(72, 18)
			Me.checkBox24.TabIndex = 16
			Me.checkBox24.Tag = "labeledit"
			Me.checkBox24.Text = "Label Edit"
			Me.checkBox24.UseVisualStyleBackColor = True
'			Me.checkBox24.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New System.Drawing.Point(21, 206)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(522, 108)
			Me.listBox1.TabIndex = 32
			' 
			' checkBox23
			' 
			Me.checkBox23.AutoSize = True
			Me.checkBox23.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox23.Location = New System.Drawing.Point(149, 155)
			Me.checkBox23.Name = "checkBox23"
			Me.checkBox23.Size = New System.Drawing.Size(79, 18)
			Me.checkBox23.TabIndex = 15
			Me.checkBox23.Tag = "movetabs"
			Me.checkBox23.Text = "Move Tabs"
			Me.checkBox23.UseVisualStyleBackColor = True
'			Me.checkBox23.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' BehaviorTabControl
			' 
			Me.BehaviorTabControl.ActiveTabColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.BehaviorTabControl.BackColor = System.Drawing.SystemColors.Control
			Me.BehaviorTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.BehaviorTabControl.BorderVisible = True
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv5)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv12)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv13)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv1)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv11)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv2)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv9)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv10)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv6)
			Me.BehaviorTabControl.Controls.Add(Me.tabPageAdv8)
			Me.BehaviorTabControl.FocusOnTabClick = False
			Me.BehaviorTabControl.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.BehaviorTabControl.HotTrack = True
			Me.BehaviorTabControl.InactiveTabColor = System.Drawing.Color.White
			Me.BehaviorTabControl.Location = New System.Drawing.Point(21, 40)
			Me.BehaviorTabControl.Name = "BehaviorTabControl"
			Me.BehaviorTabControl.ShowTabCloseButton = True
			Me.BehaviorTabControl.ShowToolTips = True
			Me.BehaviorTabControl.Size = New System.Drawing.Size(522, 69)
			Me.BehaviorTabControl.TabIndex = 3
			Me.BehaviorTabControl.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2008)
			Me.BehaviorTabControl.VSLikeScrollButton = True
'			Me.BehaviorTabControl.SelectedIndexChanged += New System.EventHandler(Me.BehaviorTabControl_SelectedIndexChanged)
'			Me.BehaviorTabControl.LabelEditChanged += New System.EventHandler(Me.BehaviorTabControl_LabelEditChanged)
'			Me.BehaviorTabControl.BeforeEdit += New Syncfusion.Windows.Forms.Tools.EditEventHandler(Me.BehaviorTabControl_BeforeEdit)
'			Me.BehaviorTabControl.LabelEditTextChanged += New System.EventHandler(Me.BehaviorTabControl_LabelEditTextChanged)
'			Me.BehaviorTabControl.AfterEdit += New Syncfusion.Windows.Forms.Tools.EditEventHandler(Me.BehaviorTabControl_AfterEdit)
'			Me.BehaviorTabControl.SelectedIndexChanging += New Syncfusion.Windows.Forms.Tools.SelectedIndexChangingEventHandler(Me.BehaviorTabControl_SelectedIndexChanging)
			' 
			' tabPageAdv5
			' 
			Me.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv5.Image = Nothing
			Me.tabPageAdv5.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv5.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv5.Name = "tabPageAdv5"
			Me.tabPageAdv5.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv5.TabIndex = 1
			Me.tabPageAdv5.Text = "Home Page"
			Me.tabPageAdv5.ThemesEnabled = False
			Me.tabPageAdv5.ToolTipText = "Home Page"
			' 
			' tabPageAdv12
			' 
			Me.tabPageAdv12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv12.Image = Nothing
			Me.tabPageAdv12.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv12.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv12.Name = "tabPageAdv12"
			Me.tabPageAdv12.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv12.TabIndex = 8
			Me.tabPageAdv12.Text = "Remote"
			Me.tabPageAdv12.ThemesEnabled = False
			Me.tabPageAdv12.ToolTipText = "Remote"
			' 
			' tabPageAdv13
			' 
			Me.tabPageAdv13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv13.Image = Nothing
			Me.tabPageAdv13.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv13.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv13.Name = "tabPageAdv13"
			Me.tabPageAdv13.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv13.TabIndex = 9
			Me.tabPageAdv13.Text = "Updates"
			Me.tabPageAdv13.ThemesEnabled = False
			Me.tabPageAdv13.ToolTipText = "Updates"
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv1.Image = Nothing
			Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv1.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv1.TabIndex = 3
			Me.tabPageAdv1.Text = "Options"
			Me.tabPageAdv1.ThemesEnabled = False
			Me.tabPageAdv1.ToolTipText = "Options"
			' 
			' tabPageAdv11
			' 
			Me.tabPageAdv11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv11.Image = Nothing
			Me.tabPageAdv11.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv11.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv11.Name = "tabPageAdv11"
			Me.tabPageAdv11.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv11.TabIndex = 7
			Me.tabPageAdv11.Text = "More Options.."
			Me.tabPageAdv11.ThemesEnabled = False
			Me.tabPageAdv11.ToolTipText = "More Options.."
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv2.Image = Nothing
			Me.tabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv2.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv2.TabIndex = 4
			Me.tabPageAdv2.Text = "Format Text"
			Me.tabPageAdv2.ThemesEnabled = False
			Me.tabPageAdv2.ToolTipText = "Format Text"
			' 
			' tabPageAdv9
			' 
			Me.tabPageAdv9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv9.Image = Nothing
			Me.tabPageAdv9.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv9.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv9.Name = "tabPageAdv9"
			Me.tabPageAdv9.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv9.TabIndex = 5
			Me.tabPageAdv9.Text = "Message"
			Me.tabPageAdv9.ThemesEnabled = False
			Me.tabPageAdv9.ToolTipText = "Message"
			' 
			' tabPageAdv10
			' 
			Me.tabPageAdv10.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv10.Image = Nothing
			Me.tabPageAdv10.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv10.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv10.Name = "tabPageAdv10"
			Me.tabPageAdv10.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv10.TabIndex = 6
			Me.tabPageAdv10.Text = "Find and Replace"
			Me.tabPageAdv10.ThemesEnabled = False
			Me.tabPageAdv10.ToolTipText = "Find and Replace"
			' 
			' tabPageAdv6
			' 
			Me.tabPageAdv6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv6.Image = Nothing
			Me.tabPageAdv6.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv6.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv6.Name = "tabPageAdv6"
			Me.tabPageAdv6.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv6.TabIndex = 1
			Me.tabPageAdv6.Text = "Insert Item"
			Me.tabPageAdv6.ThemesEnabled = False
			Me.tabPageAdv6.ToolTipText = "Insert Item"
			' 
			' tabPageAdv8
			' 
			Me.tabPageAdv8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabPageAdv8.Image = Nothing
			Me.tabPageAdv8.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv8.Location = New System.Drawing.Point(5, 32)
			Me.tabPageAdv8.Name = "tabPageAdv8"
			Me.tabPageAdv8.Size = New System.Drawing.Size(512, 32)
			Me.tabPageAdv8.TabIndex = 2
			Me.tabPageAdv8.Text = "View Tabs"
			Me.tabPageAdv8.ThemesEnabled = False
			Me.tabPageAdv8.ToolTipText = "View Tabs"
			' 
			' checkBox22
			' 
			Me.checkBox22.AutoSize = True
			Me.checkBox22.Checked = True
			Me.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox22.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox22.Location = New System.Drawing.Point(29, 155)
			Me.checkBox22.Name = "checkBox22"
			Me.checkBox22.Size = New System.Drawing.Size(98, 18)
			Me.checkBox22.TabIndex = 14
			Me.checkBox22.Tag = "tooltips"
			Me.checkBox22.Text = "Show ToolTips"
			Me.checkBox22.UseVisualStyleBackColor = True
'			Me.checkBox22.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' label8
			' 
			Me.label8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.label8.Location = New System.Drawing.Point(93, 193)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(450, 1)
			Me.label8.TabIndex = 30
			' 
			' checkBox20
			' 
			Me.checkBox20.AutoSize = True
			Me.checkBox20.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox20.Location = New System.Drawing.Point(242, 118)
			Me.checkBox20.Name = "checkBox20"
			Me.checkBox20.Size = New System.Drawing.Size(63, 18)
			Me.checkBox20.TabIndex = 12
			Me.checkBox20.Tag = "multiline"
			Me.checkBox20.Text = "Multiline"
			Me.checkBox20.UseVisualStyleBackColor = True
'			Me.checkBox20.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' label10
			' 
			Me.label10.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(82))))), (CInt(Fix((CByte(81))))), (CInt(Fix((CByte(82))))))
			Me.label10.Image = (CType(resources.GetObject("label10.Image"), System.Drawing.Image))
			Me.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label10.Location = New System.Drawing.Point(19, 179)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(67, 24)
			Me.label10.TabIndex = 31
			Me.label10.Text = "Events"
			Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' checkBox19
			' 
			Me.checkBox19.AutoSize = True
			Me.checkBox19.Checked = True
			Me.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox19.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox19.Location = New System.Drawing.Point(149, 118)
			Me.checkBox19.Name = "checkBox19"
			Me.checkBox19.Size = New System.Drawing.Size(72, 18)
			Me.checkBox19.TabIndex = 11
			Me.checkBox19.Tag = "hottrack"
			Me.checkBox19.Text = "Hot Track"
			Me.checkBox19.UseVisualStyleBackColor = True
'			Me.checkBox19.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' checkBox18
			' 
			Me.checkBox18.AutoSize = True
			Me.checkBox18.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox18.Location = New System.Drawing.Point(29, 118)
			Me.checkBox18.Name = "checkBox18"
			Me.checkBox18.Size = New System.Drawing.Size(92, 18)
			Me.checkBox18.TabIndex = 10
			Me.checkBox18.Tag = "focus"
			Me.checkBox18.Text = "Focus on Tab"
			Me.checkBox18.UseVisualStyleBackColor = True
'			Me.checkBox18.CheckedChanged += New System.EventHandler(Me.Behavior_CheckChanged)
			' 
			' tab4
			' 
			Me.tab4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(250))))))
			Me.tab4.Controls.Add(Me.gradientPanel1)
			Me.tab4.Controls.Add(Me.PrimitivesTabControl)
			Me.tab4.Image = Nothing
			Me.tab4.ImageIndex = 2
			Me.tab4.ImageSize = New System.Drawing.Size(16, 16)
			Me.tab4.Location = New System.Drawing.Point(1, 43)
			Me.tab4.Name = "tab4"
			Me.tab4.Size = New System.Drawing.Size(574, 404)
			toolTipInfo3.Header.Text = "Tab Primitives"
			Me.tab4.SuperTooltip = toolTipInfo3
			Me.tab4.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tab4.TabIndex = 6
			Me.tab4.Text = "Tab Primitives"
            Me.tab4.ThemesEnabled = False
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.label40)
			Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientPanel1.Location = New System.Drawing.Point(17, 17)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(540, 49)
			Me.gradientPanel1.TabIndex = 2
			' 
			' label40
			' 
			Me.label40.BackColor = System.Drawing.Color.Transparent
			Me.label40.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label40.Image = (CType(resources.GetObject("label40.Image"), System.Drawing.Image))
			Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label40.Location = New System.Drawing.Point(0, 0)
			Me.label40.Name = "label40"
			Me.label40.Size = New System.Drawing.Size(538, 47)
			Me.label40.TabIndex = 1
			Me.label40.Text = resources.GetString("label40.Text")
			' 
			' PrimitivesTabControl
			' 
			Me.PrimitivesTabControl.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.PrimitivesTabControl.BackColor = System.Drawing.SystemColors.Control
			Me.PrimitivesTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.PrimitivesTabControl.Controls.Add(Me.tabPageAdv7)
			Me.PrimitivesTabControl.Controls.Add(Me.tabPageAdv3)
			Me.PrimitivesTabControl.Controls.Add(Me.tabPageAdv4)
			Me.PrimitivesTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(161))))))
			Me.PrimitivesTabControl.FocusOnTabClick = False
			Me.PrimitivesTabControl.Location = New System.Drawing.Point(15, 92)
			Me.PrimitivesTabControl.Name = "PrimitivesTabControl"
			Me.PrimitivesTabControl.ShowScroll = False
			Me.PrimitivesTabControl.ShowToolTips = True
			Me.PrimitivesTabControl.Size = New System.Drawing.Size(542, 213)
			Me.PrimitivesTabControl.TabIndex = 0
			Me.PrimitivesTabControl.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(250))))))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Custom, (CType(resources.GetObject("PrimitivesTabControl.TabPrimitivesHost.TabPrimitives"), System.Drawing.Image)), System.Drawing.Color.Empty, False, 1, "AddTab", "AddTab"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.FirstTab, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive0", "FirstTab"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousPage, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive1", "PreviousPage"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousTab, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive2", "PreviousTab"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextTab, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive3", "NextTab"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextPage, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive4", "NextPage"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.LastTab, Nothing, System.Drawing.Color.Empty, True, 1, "TabPrimitive5", "LastTab"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.DropDown, Nothing, System.Drawing.Color.Empty, False, 1, "TabPrimitive6", "DropDown"))
			Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(New Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Close, Nothing, System.Drawing.Color.Empty, False, 1, "TabPrimitive7", "Close"))
			Me.PrimitivesTabControl.TabPrimitivesHost.Visible = True
			Me.PrimitivesTabControl.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererIE7)
'			Me.PrimitivesTabControl.TabPrimitiveClick += New Syncfusion.Windows.Forms.Tools.TabPrimitiveClick(Me.PrimitivesTabControl_TabPrimitiveClick)
			' 
			' tabPageAdv7
			' 
			Me.tabPageAdv7.Controls.Add(Me.label35)
			Me.tabPageAdv7.Controls.Add(Me.label34)
			Me.tabPageAdv7.Controls.Add(Me.label26)
			Me.tabPageAdv7.Controls.Add(Me.label11)
			Me.tabPageAdv7.Controls.Add(Me.label13)
			Me.tabPageAdv7.Controls.Add(Me.label9)
			Me.tabPageAdv7.Controls.Add(Me.checkBox9)
			Me.tabPageAdv7.Controls.Add(Me.checkBox8)
			Me.tabPageAdv7.Controls.Add(Me.checkBox7)
			Me.tabPageAdv7.Controls.Add(Me.checkBox6)
			Me.tabPageAdv7.Controls.Add(Me.checkBox5)
			Me.tabPageAdv7.Controls.Add(Me.checkBox4)
			Me.tabPageAdv7.Controls.Add(Me.checkBox3)
			Me.tabPageAdv7.Controls.Add(Me.checkBox2)
			Me.tabPageAdv7.Controls.Add(Me.checkBox1)
			Me.tabPageAdv7.Image = Nothing
			Me.tabPageAdv7.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv7.Location = New System.Drawing.Point(1, 33)
			Me.tabPageAdv7.Name = "tabPageAdv7"
			Me.tabPageAdv7.Size = New System.Drawing.Size(540, 179)
			Me.tabPageAdv7.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabPageAdv7.TabIndex = 1
			Me.tabPageAdv7.Text = "Primitives Options"
			Me.tabPageAdv7.ThemesEnabled = False
			' 
			' label35
			' 
			Me.label35.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label35.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label35.Image = (CType(resources.GetObject("label35.Image"), System.Drawing.Image))
			Me.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label35.Location = New System.Drawing.Point(291, 98)
			Me.label35.Name = "label35"
			Me.label35.Size = New System.Drawing.Size(133, 24)
			Me.label35.TabIndex = 17
			Me.label35.Text = "Custom Primitives"
			Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label34
			' 
			Me.label34.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label34.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label34.Image = (CType(resources.GetObject("label34.Image"), System.Drawing.Image))
			Me.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label34.Location = New System.Drawing.Point(13, 98)
			Me.label34.Name = "label34"
			Me.label34.Size = New System.Drawing.Size(100, 24)
			Me.label34.TabIndex = 16
			Me.label34.Text = "More Options"
			Me.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label26
			' 
			Me.label26.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label26.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label26.Image = (CType(resources.GetObject("label26.Image"), System.Drawing.Image))
			Me.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label26.Location = New System.Drawing.Point(13, 11)
			Me.label26.Name = "label26"
			Me.label26.Size = New System.Drawing.Size(75, 24)
			Me.label26.TabIndex = 15
			Me.label26.Text = "Visibility"
			Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label11
			' 
			Me.label11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label11.Location = New System.Drawing.Point(428, 112)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(100, 1)
			Me.label11.TabIndex = 10
			' 
			' label13
			' 
			Me.label13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label13.Location = New System.Drawing.Point(115, 112)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(150, 1)
			Me.label13.TabIndex = 13
			' 
			' label9
			' 
			Me.label9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label9.Location = New System.Drawing.Point(92, 25)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(430, 1)
			Me.label9.TabIndex = 7
			' 
			' checkBox9
			' 
			Me.checkBox9.AutoSize = True
			Me.checkBox9.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox9.Location = New System.Drawing.Point(142, 139)
			Me.checkBox9.Name = "checkBox9"
			Me.checkBox9.Size = New System.Drawing.Size(118, 18)
			Me.checkBox9.TabIndex = 12
			Me.checkBox9.Text = "Show Close button"
			Me.checkBox9.UseVisualStyleBackColor = True
'			Me.checkBox9.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox8
			' 
			Me.checkBox8.AutoSize = True
			Me.checkBox8.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox8.Location = New System.Drawing.Point(26, 139)
			Me.checkBox8.Name = "checkBox8"
			Me.checkBox8.Size = New System.Drawing.Size(110, 18)
			Me.checkBox8.TabIndex = 12
			Me.checkBox8.Text = "Show DropDown"
			Me.checkBox8.UseVisualStyleBackColor = True
'			Me.checkBox8.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox7
			' 
			Me.checkBox7.AutoSize = True
			Me.checkBox7.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox7.Location = New System.Drawing.Point(304, 139)
			Me.checkBox7.Name = "checkBox7"
			Me.checkBox7.Size = New System.Drawing.Size(136, 18)
			Me.checkBox7.TabIndex = 9
			Me.checkBox7.Text = "Show Custom Primitive"
			Me.checkBox7.UseVisualStyleBackColor = True
'			Me.checkBox7.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox6
			' 
			Me.checkBox6.AutoSize = True
			Me.checkBox6.Checked = True
			Me.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox6.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox6.Location = New System.Drawing.Point(294, 55)
			Me.checkBox6.Name = "checkBox6"
			Me.checkBox6.Size = New System.Drawing.Size(69, 18)
			Me.checkBox6.TabIndex = 4
			Me.checkBox6.Text = "Next Tab"
			Me.checkBox6.UseVisualStyleBackColor = True
'			Me.checkBox6.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox5
			' 
			Me.checkBox5.AutoSize = True
			Me.checkBox5.Checked = True
			Me.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox5.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox5.Location = New System.Drawing.Point(26, 55)
			Me.checkBox5.Name = "checkBox5"
			Me.checkBox5.Size = New System.Drawing.Size(68, 18)
			Me.checkBox5.TabIndex = 5
			Me.checkBox5.Text = "First Tab"
			Me.checkBox5.UseVisualStyleBackColor = True
'			Me.checkBox5.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox4
			' 
			Me.checkBox4.AutoSize = True
			Me.checkBox4.Checked = True
			Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox4.Location = New System.Drawing.Point(369, 55)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(75, 18)
			Me.checkBox4.TabIndex = 6
			Me.checkBox4.Text = "Next Page"
			Me.checkBox4.UseVisualStyleBackColor = True
'			Me.checkBox4.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox3
			' 
			Me.checkBox3.AutoSize = True
			Me.checkBox3.Checked = True
			Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox3.Location = New System.Drawing.Point(100, 55)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(95, 18)
			Me.checkBox3.TabIndex = 1
			Me.checkBox3.Text = "Previous Page"
			Me.checkBox3.UseVisualStyleBackColor = True
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox2
			' 
			Me.checkBox2.AutoSize = True
			Me.checkBox2.Checked = True
			Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox2.Location = New System.Drawing.Point(449, 55)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(68, 18)
			Me.checkBox2.TabIndex = 2
			Me.checkBox2.Text = "Last Tab"
			Me.checkBox2.UseVisualStyleBackColor = True
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(202, 55)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(89, 18)
			Me.checkBox1.TabIndex = 3
			Me.checkBox1.Text = "Previous Tab"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' tabPageAdv3
			' 
			Me.tabPageAdv3.Image = Nothing
			Me.tabPageAdv3.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv3.Location = New System.Drawing.Point(1, 33)
			Me.tabPageAdv3.Name = "tabPageAdv3"
			Me.tabPageAdv3.Size = New System.Drawing.Size(540, 179)
			Me.tabPageAdv3.TabIndex = 2
			Me.tabPageAdv3.Text = "TabPage 1"
			Me.tabPageAdv3.ThemesEnabled = False
			' 
			' tabPageAdv4
			' 
			Me.tabPageAdv4.Image = Nothing
			Me.tabPageAdv4.ImageSize = New System.Drawing.Size(16, 16)
			Me.tabPageAdv4.Location = New System.Drawing.Point(1, 33)
			Me.tabPageAdv4.Name = "tabPageAdv4"
			Me.tabPageAdv4.Size = New System.Drawing.Size(540, 179)
			Me.tabPageAdv4.TabIndex = 3
			Me.tabPageAdv4.Text = "Tab Page 2"
			Me.tabPageAdv4.ThemesEnabled = False
			' 
			' label33
			' 
			Me.label33.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label33.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(82))))), (CInt(Fix((CByte(81))))), (CInt(Fix((CByte(82))))))
			Me.label33.Image = (CType(resources.GetObject("label33.Image"), System.Drawing.Image))
			Me.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label33.Location = New System.Drawing.Point(12, 54)
			Me.label33.Name = "label33"
			Me.label33.Size = New System.Drawing.Size(81, 24)
			Me.label33.TabIndex = 29
			Me.label33.Text = "Behavior"
			Me.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label2
			' 
			Me.label2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label2.Location = New System.Drawing.Point(126, 124)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(400, 1)
			Me.label2.TabIndex = 0
			' 
			' colorDialog1
			' 
			Me.colorDialog1.Color = System.Drawing.SystemColors.Window
			' 
			' TabControlAdvFrame
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.ClientSize = New System.Drawing.Size(598, 461)
			Me.Controls.Add(Me.FormTabControl)
			Me.Controls.Add(Me.label33)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimumSize = New System.Drawing.Size(400, 200)
			Me.Name = "TabControlAdvFrame"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TabControlAdv "
			Me.UseOffice2007SchemeBackColor = True
			CType(Me.FormTabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.FormTabControl.ResumeLayout(False)
			Me.contextMenuStripEx1.ResumeLayout(False)
			Me.tab6.ResumeLayout(False)
			Me.tab6.PerformLayout()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelColorEdit.ResumeLayout(False)
			Me.panelColorEdit.PerformLayout()
			CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.borderColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.borderColorEdit.ResumeLayout(False)
			Me.borderColorEdit.PerformLayout()
			CType(Me.inactiveTabColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.inactiveTabColorEdit.ResumeLayout(False)
			Me.inactiveTabColorEdit.PerformLayout()
			CType(Me.activeTabColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.activeTabColorEdit.ResumeLayout(False)
			Me.activeTabColorEdit.PerformLayout()
			Me.tab3.ResumeLayout(False)
			Me.tab3.PerformLayout()
			CType(Me.BehaviorTabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.BehaviorTabControl.ResumeLayout(False)
			Me.tab4.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			CType(Me.PrimitivesTabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.PrimitivesTabControl.ResumeLayout(False)
			Me.tabPageAdv7.ResumeLayout(False)
			Me.tabPageAdv7.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "TabControl Events"
		Private Sub tp_Closing(ByVal sender As Object, ByVal args As TabPageAdvClosingEventArgs)
			If MessageBox.Show("Are you sure want to close the " & args.TabPageAdv.Text & " tab?", "Closing tab...", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
				tabPage1 = args.TabPageAdv
				args.Cancel = False
				EventsList("TabPage Closing: " & tabPage1.Text)
			Else
				args.Cancel = True
			End If
		End Sub

		Private Sub tp_Closed(ByVal sender As Object, ByVal e As EventArgs)
			EventsList("TabPage Closed: " & tabPage1.Text)
		End Sub

		#End Region

		#Region "Helper Methods"
		Private Sub InitializeItems()
			Me.comboBox1.SelectedIndex = 9
			Me.comboBox2.SelectedIndex = 0

			For Each str As String In System.Enum.GetNames(GetType(System.Windows.Forms.BorderStyle))
				Me.comboBox3.Items.Add(str)
			Next str
			Me.comboBox3.SelectedIndex = 1

			For tabcount As Integer = 3 To 9
				Dim tabPage As New TabPageAdv("Tab Page " & tabcount.ToString())
				PrimitivesTabControl.TabPages.Add(tabPage)
			Next tabcount

			Appearance = FormTabControl.TabPages(0)
			Behavior = FormTabControl.TabPages(1)
			Tab_Primitives = FormTabControl.TabPages(2)
		End Sub

		Private Sub PopulateTabStyles()
			Me.comboBox1.Items.Add("TabRenderer3D")
			Me.comboBox1.Items.Add("TabRenderer2D")
			Me.comboBox1.Items.Add("Workbook")
			Me.comboBox1.Items.Add("OneNoteStyle")
			Me.comboBox1.Items.Add("OneNoteStyleFlatTabs")
			Me.comboBox1.Items.Add("Office2003")
			Me.comboBox1.Items.Add("Whidbey")
			Me.comboBox1.Items.Add("DockingWhidbey")
			Me.comboBox1.Items.Add("DockingWhidbeyBeta")
			Me.comboBox1.Items.Add("Office2007Blue")
			Me.comboBox1.Items.Add("Office2007Black")
			Me.comboBox1.Items.Add("Office2007Silver")
			Me.comboBox1.Items.Add("Office2007Managed")
			Me.comboBox1.Items.Add("InternetExplorer7")
			Me.comboBox1.Items.Add("TabRendererVS2008")
			Me.comboBox1.Items.Add("TabRendererBlendDark")
            Me.comboBox1.Items.Add("TabRendererBlendLight")
            Me.comboBox1.Items.Add("TabRendererVS2010")
		End Sub
		#End Region

		#Region "Color Options"
		Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles activeTabColorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				activeTabColorEdit.BackColor = colorDialog1.Color
				FormTabControl.ActiveTabColor = colorDialog1.Color
			End If
		End Sub

		Private Sub inactiveTabColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles inactiveTabColorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				inactiveTabColorEdit.BackColor = colorDialog1.Color
				FormTabControl.InactiveTabColor = colorDialog1.Color
			End If
		End Sub

		Private Sub borderColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles borderColorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				borderColorEdit.BackColor = colorDialog1.Color
				FormTabControl.FixedSingleBorderColor = colorDialog1.Color
			End If
		End Sub

		Private Sub panelColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles panelColorEdit.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				panelColorEdit.BackColor = colorDialog1.Color
				FormTabControl.TabPanelBackColor = colorDialog1.Color
			End If
		End Sub

		#End Region

		#Region "Primitives"
		Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox9.CheckedChanged, checkBox8.CheckedChanged, checkBox7.CheckedChanged, checkBox6.CheckedChanged, checkBox5.CheckedChanged, checkBox4.CheckedChanged, checkBox3.CheckedChanged, checkBox2.CheckedChanged, checkBox1.CheckedChanged
			Dim checkBox As CheckBox = CType(sender, CheckBox)

			Select Case checkBox.Text
				Case "First Tab"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(1).Visible = Me.checkBox5.Checked
				Case "Previous Page"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(2).Visible = Me.checkBox3.Checked
				Case "Previous Tab"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(3).Visible = Me.checkBox1.Checked
				Case "Next Tab"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(4).Visible = Me.checkBox6.Checked
				Case "Next Page"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(5).Visible = Me.checkBox4.Checked
				Case "Last Tab"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(6).Visible = Me.checkBox2.Checked
				Case "Show DropDown"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(7).Visible = Me.checkBox8.Checked
				Case "Show Close button"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(8).Visible = Me.checkBox9.Checked
				Case "Show Custom Primitive"
					Me.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives(0).Visible = Me.checkBox7.Checked
			End Select
		End Sub

		Private Sub PrimitivesTabControl_TabPrimitiveClick(ByVal sender As Object, ByVal e As TabPrimitiveClickEventArgs) Handles PrimitivesTabControl.TabPrimitiveClick
			If e.TabPrimitive.Name = "AddTab" Then
				Dim tabPage As New TabPageAdv("New Tab")
				PrimitivesTabControl.TabPages.Add(tabPage)
			End If
		End Sub
		#End Region

		#Region "Styles"
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Select Case TryCast(Me.comboBox1.SelectedItem, String)
				Case "TabRenderer3D"
					Me.FormTabControl.TabStyle = GetType(TabRenderer3D)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "TabRenderer2D"
					Me.FormTabControl.TabStyle = GetType(TabRenderer2D)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Workbook"
					Me.FormTabControl.TabStyle = GetType(TabRendererWorkbookMode)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "OneNoteStyle"
					Me.FormTabControl.TabStyle = GetType(OneNoteStyleRenderer)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "OneNoteStyleFlatTabs"
					Me.FormTabControl.TabStyle = GetType(OneNoteStyleFlatTabsRenderer)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Office2003"
					Me.FormTabControl.TabStyle = GetType(TabRendererOffice2003)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Whidbey"
					Me.FormTabControl.TabStyle = GetType(TabRendererWhidbey)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "DockingWhidbey"
					Me.FormTabControl.TabStyle = GetType(TabRendererDockingWhidbey)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "DockingWhidbeyBeta"
					Me.FormTabControl.TabStyle = GetType(TabRendererDockingWhidbeyBeta)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Office2007Blue"
					Me.FormTabControl.TabStyle = GetType(TabRendererOffice2007)
					Me.FormTabControl.Office2007ColorScheme = Office2007Theme.Blue
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Office2007Black"
					Me.FormTabControl.TabStyle = GetType(TabRendererOffice2007)
					Me.FormTabControl.Office2007ColorScheme = Office2007Theme.Black
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Black)
				Case "Office2007Silver"
					Me.FormTabControl.TabStyle = GetType(TabRendererOffice2007)
					Me.FormTabControl.Office2007ColorScheme = Office2007Theme.Silver
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Silver)
				Case "Office2007Managed"
					Me.FormTabControl.TabStyle = GetType(TabRendererOffice2007)
					Me.FormTabControl.Office2007ColorScheme = Office2007Theme.Managed
					Office2007Colors.ApplyManagedColors(Me, Color.Green)

				Case "InternetExplorer7"
					Me.FormTabControl.TabStyle = GetType(TabRendererIE7)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "TabRendererVS2008"
					Me.FormTabControl.TabStyle = GetType(TabRendererVS2008)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "TabRendererBlendDark"
					Me.FormTabControl.TabStyle = GetType(TabRendererBlendDark)
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "TabRendererBlendLight"
					Me.FormTabControl.TabStyle = GetType(TabRendererBlendLight)
                    Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
                Case "TabRendererVS2010"
                    Me.FormTabControl.TabStyle = GetType(TabRendererVS2010)
                    Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Silver)
            End Select
		End Sub

		Private Sub Properties_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox16.CheckedChanged, contextMenuCheck.CheckedChanged, checkBox17.CheckedChanged, checkBox14.CheckedChanged, checkBox13.CheckedChanged, checkBox12.CheckedChanged, checkBox11.CheckedChanged, checkBox10.CheckedChanged
			Dim checkBox As CheckBox = CType(sender, CheckBox)

			Select Case TryCast(checkBox.Tag, String)
				Case "themes"
					FormTabControl.ThemesEnabled = checkBox14.Checked
				Case "imagealign"
					If checkBox11.Checked Then
						FormTabControl.ImageAlignmentR = RelativeImageAlignment.LeftOfText
					Else
						FormTabControl.ImageAlignmentR = RelativeImageAlignment.RightOfText
					End If
				Case "scrolls"
					FormTabControl.ShowScroll = checkBox13.Checked
				Case "outsidebounds"
					If checkBox17.Checked Then
						FormTabControl.ImageOffset = 10
						FormTabControl.ItemSize = New Size(102, 25)
					Else
						FormTabControl.ImageOffset = 0
						FormTabControl.ItemSize = New Size(102, 33)
					End If
                    If FormTabControl.Alignment = TabAlignment.Left Or FormTabControl.Alignment = TabAlignment.Right Then
                        FormTabControl.LevelTextAndImage = False
                    Else
                        FormTabControl.LevelTextAndImage = checkBox17.Checked
                    End If
				Case "inactiveimage"
					FormTabControl.DisableInactivePageImage = checkBox10.Checked
				Case "rotatetext"
					FormTabControl.RotateTextWhenVertical = checkBox12.Checked
				Case "persist"
					FormTabControl.PersistTabState = checkBox16.Checked
			End Select
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
			FormTabControl.TabGap = CInt(Fix(numericUpDown1.Value))
		End Sub

		' Tab Alignment
		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			Select Case comboBox2.SelectedIndex
				Case 0
                    FormTabControl.Alignment = TabAlignment.Top
                    FormTabControl.LevelTextAndImage = True
				Case 1
                    FormTabControl.Alignment = TabAlignment.Left
                    FormTabControl.LevelTextAndImage = False
				Case 2
                    FormTabControl.Alignment = TabAlignment.Bottom
                    FormTabControl.LevelTextAndImage = True
				Case 3
                    FormTabControl.Alignment = TabAlignment.Right
                    FormTabControl.LevelTextAndImage = False
			End Select
		End Sub


		Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
			Select Case comboBox3.SelectedIndex
				Case 0
					FormTabControl.BorderStyle = BorderStyle.None
				Case 1
					FormTabControl.BorderStyle = BorderStyle.FixedSingle
				Case 2
					FormTabControl.BorderStyle = BorderStyle.Fixed3D
			End Select
		End Sub
		#End Region

		#Region "Custom ContextMenu"
		Private Sub contextMenuStripEx1_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles contextMenuStripEx1.Opening
			If FormTabControl.GetTabRect(FormTabControl.SelectedIndex).Contains(tabPoint) AndAlso contextMenuCheck.Checked Then
				contextMenuStripEx1.Show()
				tabPoint = Point.Empty
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub FormTabControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles FormTabControl.MouseDown
			If contextMenuCheck.Checked Then
				tabPoint = New Point(e.X, e.Y)
			End If
		End Sub

		Private Sub addTabToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addTabToolStripMenuItem.Click
			Dim tabPage As New TabPageAdv("New Tab")
			tabPage.ImageIndex = 3
			FormTabControl.TabPages.Add(tabPage)
		End Sub
		#End Region

		#Region "Behavior Tab"
		Private Sub Behavior_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox21.CheckedChanged, checkBox24.CheckedChanged, checkBox23.CheckedChanged, checkBox22.CheckedChanged, checkBox20.CheckedChanged, checkBox19.CheckedChanged, checkBox18.CheckedChanged
			Dim checkBox As CheckBox = CType(sender, CheckBox)
			Select Case TryCast(checkBox.Tag, String)
				Case "focus"
					BehaviorTabControl.FocusOnTabClick = checkBox18.Checked
				Case "hottrack"
					BehaviorTabControl.HotTrack = checkBox19.Checked
				Case "multiline"
					BehaviorTabControl.Multiline = checkBox20.Checked
				Case "labeledit"
					BehaviorTabControl.LabelEdit = checkBox24.Checked
				Case "tooltips"
					BehaviorTabControl.ShowToolTips = checkBox22.Checked
				Case "movetabs"
					BehaviorTabControl.UserMoveTabs = checkBox23.Checked
				Case "frontrow"
					BehaviorTabControl.KeepSelectedTabInFrontRow = checkBox21.Checked
			End Select
		End Sub
		#End Region

		#Region "Events"
		Private Sub BehaviorTabControl_SelectedIndexChanging(ByVal sender As Object, ByVal args As SelectedIndexChangingEventArgs) Handles BehaviorTabControl.SelectedIndexChanging
			If args.NewSelectedIndex >= 0 Then
			EventsList("Selected Index Changing: " & BehaviorTabControl.TabPages(args.NewSelectedIndex).Text)
			End If

		End Sub

		Private Sub BehaviorTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BehaviorTabControl.SelectedIndexChanged
			If BehaviorTabControl.SelectedIndex >= 0 Then
			EventsList("Selected Index Changed: " & BehaviorTabControl.SelectedTab.Text)
			End If
		End Sub

		Private Sub BehaviorTabControl_BeforeEdit(ByVal sender As Object, ByVal e As EditEventArgs) Handles BehaviorTabControl.BeforeEdit
			EventsList("Before Edit: " & e.EditText)
		End Sub

		Private Sub BehaviorTabControl_AfterEdit(ByVal sender As Object, ByVal e As EditEventArgs) Handles BehaviorTabControl.AfterEdit
			EventsList("After Edit: " & e.EditText)
		End Sub

		Private Sub BehaviorTabControl_LabelEditChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BehaviorTabControl.LabelEditChanged
			EventsList("Label Edit changed")
		End Sub

		Private Sub BehaviorTabControl_LabelEditTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BehaviorTabControl.LabelEditTextChanged
			EventsList("Label Edit Text changed")
		End Sub

		Private Sub EventsList(ByVal item As Object)
			listBox1.Items.Add(item)
			listBox1.SetSelected(listBox1.Items.Count - 1, True)
			listBox1.SetSelected(listBox1.Items.Count - 1, False)
		End Sub
		Private Sub buttonEdit1_ButtonClicked_1(ByVal sender As Object, ByVal args As ButtonClickedEventArgs)
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				activeTabColorEdit.BackColor = colorDialog1.Color

			End If
		End Sub
		#End Region

		#Region "Close Button"
		Private Sub checkBox25_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox25.CheckedChanged
			BehaviorTabControl.ShowTabCloseButton = checkBox25.Checked
		End Sub

		Private Sub checkBox15_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox15.CheckedChanged
		   'Shows close button for Active tab only
			BehaviorTabControl.ShowCloseButtonForActiveTabOnly = checkBox15.Checked
		End Sub
		#End Region

		Private Sub checkBox26_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox26.CheckedChanged
			If checkBox26.Checked Then
                tab3.ImageIndex = -1
				tab4.ImageIndex = -1
                tab6.ImageIndex = -1

                checkBox10.Enabled = False
                checkBox17.Checked = False
            Else
                tab3.ImageIndex = 1
                tab4.ImageIndex = 2
                tab6.ImageIndex = 0
            End If


		End Sub


		#Region "Creating TabControlAdv dynamically"
		'		private void InitMyTabs()
'		{
'			this.tabControl1 = new TabControlAdv();
'			this.tabPage1 = new TabPageAdv();
'			this.tabPage2 = new TabPageAdv();
'			this.tabPage3 = new TabPageAdv();
' 
'			// Positions tabs on the left side of tabControl1.
'			// this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
'       
'			// Sets the tabs to appear in 2D mode.
'			tabControl1.TabStyle = typeof(TabRenderer2D);
'
'			// Highlights TabPage.Text when the mouse passes over tabs.
'			this.tabControl1.HotTrack = true;
'
'			// Set the relative alignment between the images and text in a tab
'			this.tabControl1.ImageAlignmentR = RelativeImageAlignment.BelowText;
'
'			// Allows more than one row of tabs.
'			// this.tabControl1.Multiline = true;
'
'			// Creates a cushion of 22 pixels around TabPage.Text strings.
'			this.tabControl1.Padding = new System.Drawing.Point(22, 22);
'
'			// Makes the tab width definable. 
'			this.tabControl1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Fixed;
'
'			// Sizes the tabs of tabControl1.
'			this.tabControl1.ItemSize = new Size(90, 64); // Make sure to take into account the padding values.
'
'			// To rotate text when aligned vertically.
'			this.tabControl1.RotateTextWhenVertical = true;
'
'			// Allows the user to move the tabs by simply dragging and dropping
'			this.tabControl1.UserMoveTabs = true;
'
'			// Draws the scroll buttons Visual Studio MDI Tabs like.
'			this.tabControl1.VSLikeScrollButton = true;
'
'			this.tabControl1.Controls.AddRange(new Control[] { this.tabPage1, this.tabPage2, this.tabPage3});
'			this.tabControl1.Location = new Point(16, 24);
'			this.tabControl1.SelectedIndex = 0;
'			this.tabControl1.Size = new Size(248, 232);
' 
'			this.tabPage1.Text = "Tab1";
'			this.tabPage2.Text = "Tab2";
'			this.tabPage3.Text = "Tab3";
'			this.Size = new Size(300,300);
'			this.Controls.AddRange(new Control[] { this.tabControl1});
'
'			// Selects tabPage1 using SelectedIndex.
'			this.tabControl1.SelectedIndex = 1;
'
'			// Shows ToolTipText when the mouse passes over tabs.
'			this.tabControl1.ShowToolTips = true;
'		}
#End Region
	End Class
End Namespace
