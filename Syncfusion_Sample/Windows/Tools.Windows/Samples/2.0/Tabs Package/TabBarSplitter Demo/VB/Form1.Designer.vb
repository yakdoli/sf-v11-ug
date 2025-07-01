Imports Microsoft.VisualBasic
Imports System
Namespace TabBarSplitterDemo
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
			Dim toolTipInfo1 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo2 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo3 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo4 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo5 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo6 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo7 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo8 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo9 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo10 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo11 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo12 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo13 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
			Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.clipboardToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.stylesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripCheckBox1 = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
			Me.toolStripCheckBox2 = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
			Me.paragraphToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton84 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton85 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton86 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton81 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton82 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton83 = New System.Windows.Forms.ToolStripButton()
			Me.officeSplitButton11 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton101 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton102 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton106 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton103 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton104 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton105 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
			Me.officeSplitButton12 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton107 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton108 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton109 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton18 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton110 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton111 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton115 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton112 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton113 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton114 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton116 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton19 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton117 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton118 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton20 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton119 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton120 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton121 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton89 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSplitButtonEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx()
			Me.mergeCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergeAcrossToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergeCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.unmergeCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem8 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.deindentToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.inindentToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton73 = New System.Windows.Forms.ToolStripButton()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.SapleBarIte = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton18 = New System.Windows.Forms.ToolStripButton()
			Me.officeSplitButton1 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton1 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton2 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton3 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton4 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton5 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeSplitButton2 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton6 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton7 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton8 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton1 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton9 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton10 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton11 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton12 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton13 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton14 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton15 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton3 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton16 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton17 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton4 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton18 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton19 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton20 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.officeSplitButton3 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton21 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton22 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton23 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton24 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton25 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			Me.officeSplitButton4 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton26 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton27 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton28 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton2 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton29 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton30 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton31 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton32 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton33 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton34 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton35 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton5 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton36 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton37 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton6 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton38 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton39 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton40 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton64 = New System.Windows.Forms.ToolStripButton()
			Me.superAccelerator1 = New Syncfusion.Windows.Forms.Tools.SuperAccelerator(Me)
			Me.toolStripButton69 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton70 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton65 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton66 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton67 = New System.Windows.Forms.ToolStripButton()
			Me.officeSplitButton5 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton44 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton45 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton46 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton47 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton48 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
			Me.officeSplitButton6 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton49 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton50 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton51 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton8 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton52 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton53 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton54 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton55 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton56 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton57 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton58 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton9 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton59 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton60 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton7 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton41 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton42 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton43 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton62 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
			Me.officeDropDownButton10 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton61 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton62 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton63 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton11 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton64 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton65 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripButton80 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton90 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton91 = New System.Windows.Forms.ToolStripButton()
			Me.officeDropDownButton12 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton66 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton67 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton68 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton69 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton70 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton71 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton72 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripButton92 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton93 = New System.Windows.Forms.ToolStripButton()
			Me.officeSplitButton7 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton73 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton74 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton75 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeSplitButton8 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton76 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton77 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton78 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton79 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton80 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton13 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton81 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton82 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton83 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeDropDownButton14 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton84 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton85 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripButton94 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton95 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton96 = New System.Windows.Forms.ToolStripButton()
			Me.officeDropDownButton15 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton()
			Me.officeButton86 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton87 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton88 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton89 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton90 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton91 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton92 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.toolStripButton97 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton98 = New System.Windows.Forms.ToolStripButton()
			Me.officeSplitButton9 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton93 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton94 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton95 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeSplitButton10 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton()
			Me.officeButton96 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton97 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton98 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton99 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.officeButton100 = New Syncfusion.Windows.Forms.Tools.OfficeButton()
			Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
			Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.toolStripStatusLabel2 = New Syncfusion.Windows.Forms.Tools.StatusStripButton()
			Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.trackBarItem2 = New Syncfusion.Windows.Forms.Tools.TrackBarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
			Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl()
			Me.toolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControlAdv1.SuspendLayout()
			Me.toolStripTabItem1.Panel.SuspendLayout()
			Me.clipboardToolStripExt.SuspendLayout()
			Me.stylesToolStripExt.SuspendLayout()
			Me.paragraphToolStripExt.SuspendLayout()
			Me.statusStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ribbonControlAdv1
			' 
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
			Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
			Me.ribbonControlAdv1.MenuButtonImage = (CType(resources.GetObject("ribbonControlAdv1.MenuButtonImage"), System.Drawing.Image))
			toolTipInfo1.BackColor = System.Drawing.SystemColors.ButtonFace
			toolTipInfo1.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Body.Text = "This will list all the common" & Constants.vbCrLf & "items used."
			toolTipInfo1.Body.TextMargin = New System.Windows.Forms.Padding(5)
			toolTipInfo1.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			toolTipInfo1.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Header.Text = "Office Menu"
			Me.superToolTip1.SetMenuButtonToolTip(Me.ribbonControlAdv1, toolTipInfo1)
			Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
			' 
			' ribbonControlAdv1.OfficeMenu
			' 
			Me.ribbonControlAdv1.OfficeMenu.AutoSize = False
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton84, Me.toolStripButton85, Me.toolStripButton86})
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.SeparatorIndent = 16
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Text = "Recent Documents"
			Me.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton81, Me.toolStripButton82, Me.toolStripButton83, Me.officeSplitButton11, Me.toolStripSeparator8, Me.officeSplitButton12, Me.officeDropDownButton18, Me.officeDropDownButton19, Me.officeDropDownButton20, Me.toolStripSeparator9, Me.toolStripButton89})
			Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
			Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(400, 420)
			Me.ribbonControlAdv1.OfficeMenu.SystemPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton6, Me.toolStripButton4})
			Me.ribbonControlAdv1.Size = New System.Drawing.Size(865, 174)
			Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
			Me.ribbonControlAdv1.TabIndex = 0
			Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
			Me.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
			Me.ribbonControlAdv1.UpdateUIOnAppIdle = True
			' 
			' toolStripTabItem1
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem1, "H")
			Me.toolStripTabItem1.Name = "toolStripTabItem1"
			Me.toolStripTabItem1.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' ribbonControlAdv1.ribbonPanel1
			' 
			Me.toolStripTabItem1.Panel.Controls.Add(Me.clipboardToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.stylesToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.paragraphToolStripExt)
			Me.toolStripTabItem1.Panel.Name = "ribbonPanel1"
			Me.toolStripTabItem1.Panel.ScrollPosition = 0
			Me.toolStripTabItem1.Panel.TabIndex = 2
			Me.toolStripTabItem1.Panel.Text = "Home"
			Me.toolStripTabItem1.Position = 0
			Me.toolStripTabItem1.Size = New System.Drawing.Size(49, 24)
			Me.toolStripTabItem1.Text = "Home"
			' 
			' clipboardToolStripExt
			' 
			Me.superAccelerator1.SetCollapsedDropDownAccelerator(Me.clipboardToolStripExt, Nothing)
			Me.clipboardToolStripExt.CollapsedDropDownButtonText = "Work Sheet"
			Me.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.clipboardToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.clipboardToolStripExt.Image = (CType(resources.GetObject("clipboardToolStripExt.Image"), System.Drawing.Image))
			Me.clipboardToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton10, Me.toolStripButton11, Me.toolStripButton5, Me.toolStripPanelItem15})
			Me.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.clipboardToolStripExt.Location = New System.Drawing.Point(0, 1)
			Me.clipboardToolStripExt.Name = "clipboardToolStripExt"
			Me.clipboardToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.clipboardToolStripExt.Size = New System.Drawing.Size(162, 109)
			Me.clipboardToolStripExt.TabIndex = 5
			Me.clipboardToolStripExt.Text = "Sheets"
			' 
			' toolStripButton10
			' 
			Me.toolStripButton10.Image = (CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image))
			Me.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.White
			Me.toolStripButton10.Name = "toolStripButton10"
			Me.toolStripButton10.Size = New System.Drawing.Size(35, 78)
			Me.toolStripButton10.Text = "New"
			Me.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton10.Click += New System.EventHandler(Me.toolStripButton10_Click)
			' 
			' toolStripButton11
			' 
			Me.toolStripButton11.Image = (CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image))
			Me.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.White
			Me.toolStripButton11.Name = "toolStripButton11"
			Me.toolStripButton11.Size = New System.Drawing.Size(35, 78)
			Me.toolStripButton11.Text = "Hide"
			Me.toolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton11.Click += New System.EventHandler(Me.toolStripButton11_Click)
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.White
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(51, 78)
			Me.toolStripButton5.Text = "Remove"
			Me.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton5.Click += New System.EventHandler(Me.toolStripButton5_Click)
			' 
			' toolStripPanelItem15
			' 
			Me.toolStripPanelItem15.CausesValidation = False
			Me.toolStripPanelItem15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
			Me.toolStripPanelItem15.Size = New System.Drawing.Size(23, 81)
			Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
			Me.toolStripPanelItem15.Transparent = True
			' 
			' stylesToolStripExt
			' 
			Me.stylesToolStripExt.AutoSize = False
			Me.superAccelerator1.SetCollapsedDropDownAccelerator(Me.stylesToolStripExt, Nothing)
			Me.stylesToolStripExt.CollapsedDropDownButtonText = "Font"
			Me.stylesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.stylesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.stylesToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.stylesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.stylesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.stylesToolStripExt.GroupedButtons = True
			Me.stylesToolStripExt.Image = (CType(resources.GetObject("stylesToolStripExt.Image"), System.Drawing.Image))
			Me.stylesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripComboBox1, Me.toolStripCheckBox1, Me.toolStripCheckBox2})
			Me.stylesToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.stylesToolStripExt.Location = New System.Drawing.Point(164, 1)
			Me.stylesToolStripExt.Name = "stylesToolStripExt"
			Me.stylesToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.stylesToolStripExt.Size = New System.Drawing.Size(147, 109)
			Me.stylesToolStripExt.TabIndex = 6
			Me.stylesToolStripExt.Text = "Scollers"
			' 
			' toolStripComboBox1
			' 
			Me.toolStripComboBox1.Items.AddRange(New Object() { "Blue", "Black", "Silver"})
			Me.toolStripComboBox1.Name = "toolStripComboBox1"
			Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 23)
			Me.toolStripComboBox1.Text = "Blue"
'			Me.toolStripComboBox1.SelectedIndexChanged += New System.EventHandler(Me.toolStripComboBox1_SelectedIndexChanged)
			' 
			' toolStripCheckBox1
			' 
			Me.toolStripCheckBox1.Name = "toolStripCheckBox1"
			Me.toolStripCheckBox1.Size = New System.Drawing.Size(85, 17)
			Me.toolStripCheckBox1.Text = "Hide HScroll"
'			Me.toolStripCheckBox1.CheckedChanged += New System.EventHandler(Me.toolStripCheckBox1_CheckedChanged)
			' 
			' toolStripCheckBox2
			' 
			Me.toolStripCheckBox2.Name = "toolStripCheckBox2"
			Me.toolStripCheckBox2.Size = New System.Drawing.Size(84, 17)
			Me.toolStripCheckBox2.Text = "Hide VScroll"
'			Me.toolStripCheckBox2.CheckedChanged += New System.EventHandler(Me.toolStripCheckBox2_CheckedChanged)
			' 
			' paragraphToolStripExt
			' 
			Me.paragraphToolStripExt.AutoSize = False
			Me.superAccelerator1.SetCollapsedDropDownAccelerator(Me.paragraphToolStripExt, Nothing)
			Me.paragraphToolStripExt.CollapsedDropDownButtonText = "Paragraph"
			Me.paragraphToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.paragraphToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.paragraphToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.paragraphToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.paragraphToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.paragraphToolStripExt.GroupedButtons = True
			Me.paragraphToolStripExt.Image = (CType(resources.GetObject("paragraphToolStripExt.Image"), System.Drawing.Image))
			Me.paragraphToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripComboBox2})
			Me.paragraphToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.paragraphToolStripExt.Location = New System.Drawing.Point(313, 1)
			Me.paragraphToolStripExt.Name = "paragraphToolStripExt"
			Me.paragraphToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.paragraphToolStripExt.Size = New System.Drawing.Size(154, 109)
			Me.paragraphToolStripExt.TabIndex = 7
			Me.paragraphToolStripExt.Text = "Scroll Behavior"
			' 
			' toolStripButton84
			' 
			Me.toolStripButton84.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton84.Image = (CType(resources.GetObject("toolStripButton84.Image"), System.Drawing.Image))
			Me.toolStripButton84.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton84.Name = "toolStripButton84"
			Me.toolStripButton84.Size = New System.Drawing.Size(267, 19)
			Me.toolStripButton84.Text = "Datasheet 1"
			Me.toolStripButton84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton85
			' 
			Me.toolStripButton85.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton85.Image = (CType(resources.GetObject("toolStripButton85.Image"), System.Drawing.Image))
			Me.toolStripButton85.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton85.Name = "toolStripButton85"
			Me.toolStripButton85.Size = New System.Drawing.Size(267, 19)
			Me.toolStripButton85.Text = "Financial Datasheet"
			Me.toolStripButton85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton86
			' 
			Me.toolStripButton86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton86.Image = (CType(resources.GetObject("toolStripButton86.Image"), System.Drawing.Image))
			Me.toolStripButton86.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton86.Name = "toolStripButton86"
			Me.toolStripButton86.Size = New System.Drawing.Size(267, 19)
			Me.toolStripButton86.Text = "Customer Details"
			Me.toolStripButton86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton81
			' 
			Me.toolStripButton81.Image = (CType(resources.GetObject("toolStripButton81.Image"), System.Drawing.Image))
			Me.toolStripButton81.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton81.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton81.Name = "toolStripButton81"
			Me.toolStripButton81.Size = New System.Drawing.Size(119, 36)
			Me.toolStripButton81.Text = "New"
			toolTipInfo2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo2.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Header.Text = "New"
			Me.superToolTip1.SetToolTip(Me.toolStripButton81, toolTipInfo2)
			' 
			' toolStripButton82
			' 
			Me.toolStripButton82.Image = (CType(resources.GetObject("toolStripButton82.Image"), System.Drawing.Image))
			Me.toolStripButton82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton82.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton82.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton82.Name = "toolStripButton82"
			Me.toolStripButton82.Size = New System.Drawing.Size(119, 36)
			Me.toolStripButton82.Text = "Open"
			toolTipInfo3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo3.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Header.Text = "Open"
			Me.superToolTip1.SetToolTip(Me.toolStripButton82, toolTipInfo3)
			' 
			' toolStripButton83
			' 
			Me.toolStripButton83.Image = (CType(resources.GetObject("toolStripButton83.Image"), System.Drawing.Image))
			Me.toolStripButton83.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton83.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton83.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton83.Name = "toolStripButton83"
			Me.toolStripButton83.Size = New System.Drawing.Size(119, 36)
			Me.toolStripButton83.Text = "Save"
			toolTipInfo4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo4.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo4.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo4.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo4.Header.Text = "Save"
			Me.superToolTip1.SetToolTip(Me.toolStripButton83, toolTipInfo4)
			' 
			' officeSplitButton11
			' 
			Me.officeSplitButton11.AutoSize = False
			Me.officeSplitButton11.DropDownButtonWidth = 18
			Me.officeSplitButton11.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.officeSplitButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton101, Me.officeButton102, Me.officeButton106, Me.officeButton103, Me.officeButton104, Me.officeButton105})
			Me.officeSplitButton11.Image = (CType(resources.GetObject("officeSplitButton11.Image"), System.Drawing.Image))
			Me.officeSplitButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton11.Name = "officeSplitButton11"
			Me.officeSplitButton11.Size = New System.Drawing.Size(119, 36)
			Me.officeSplitButton11.Text = "Save As..."
			toolTipInfo5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo5.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo5.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo5.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo5.Header.Text = "Save As..."
			Me.superToolTip1.SetToolTip(Me.officeSplitButton11, toolTipInfo5)
			' 
			' officeButton101
			' 
			Me.officeButton101.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton101.HelpText = "Save the workbook in default file format."
			Me.officeButton101.Image = (CType(resources.GetObject("officeButton101.Image"), System.Drawing.Image))
			Me.officeButton101.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton101.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton101.Name = "officeButton101"
			Me.officeButton101.Size = New System.Drawing.Size(274, 36)
			Me.officeButton101.Text = "E&xcel Workbook"
			' 
			' officeButton102
			' 
			Me.officeButton102.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton102.HelpText = "Save the workbook in XML based Macro - " & Constants.vbCrLf & "enabled file format."
			Me.officeButton102.Image = (CType(resources.GetObject("officeButton102.Image"), System.Drawing.Image))
			Me.officeButton102.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton102.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton102.Name = "officeButton102"
			Me.officeButton102.Size = New System.Drawing.Size(274, 51)
			Me.officeButton102.Text = "Excel Macro_Enabled Workbook"
			' 
			' officeButton106
			' 
			Me.officeButton106.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton106.HelpText = "Save the workbook in binary format for fast " & Constants.vbCrLf & "loading and optimizing."
			Me.officeButton106.Image = (CType(resources.GetObject("officeButton106.Image"), System.Drawing.Image))
			Me.officeButton106.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton106.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton106.Name = "officeButton106"
			Me.officeButton106.Size = New System.Drawing.Size(274, 51)
			Me.officeButton106.Text = "Excel &Binary Workbook"
			' 
			' officeButton103
			' 
			Me.officeButton103.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton103.HelpText = "Save a copy of the workbook that is fully " & Constants.vbCrLf & "compatible with Excel 97-2003."
			Me.officeButton103.Image = (CType(resources.GetObject("officeButton103.Image"), System.Drawing.Image))
			Me.officeButton103.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton103.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton103.Name = "officeButton103"
			Me.officeButton103.Size = New System.Drawing.Size(274, 51)
			Me.officeButton103.Text = "Excel _97-2003 Workbook"
			' 
			' officeButton104
			' 
			Me.officeButton104.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton104.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton104.Image = (CType(resources.GetObject("officeButton104.Image"), System.Drawing.Image))
			Me.officeButton104.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton104.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton104.Name = "officeButton104"
			Me.officeButton104.Size = New System.Drawing.Size(274, 51)
			Me.officeButton104.Text = "&Find add-ins for other file formats"
			' 
			' officeButton105
			' 
			Me.officeButton105.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton105.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton105.Image = (CType(resources.GetObject("officeButton105.Image"), System.Drawing.Image))
			Me.officeButton105.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton105.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton105.Name = "officeButton105"
			Me.officeButton105.Size = New System.Drawing.Size(274, 51)
			Me.officeButton105.Text = "&Other formats"
			' 
			' toolStripSeparator8
			' 
			Me.toolStripSeparator8.Name = "toolStripSeparator8"
			Me.toolStripSeparator8.Size = New System.Drawing.Size(103, 2)
			' 
			' officeSplitButton12
			' 
			Me.officeSplitButton12.DropDownButtonWidth = 18
			Me.officeSplitButton12.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.officeSplitButton12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton107, Me.officeButton108, Me.officeButton109})
			Me.officeSplitButton12.Image = (CType(resources.GetObject("officeSplitButton12.Image"), System.Drawing.Image))
			Me.officeSplitButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton12.Name = "officeSplitButton12"
			Me.officeSplitButton12.Size = New System.Drawing.Size(119, 36)
			Me.officeSplitButton12.Text = "&Print"
			toolTipInfo6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo6.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo6.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo6.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo6.Header.Text = "Print"
			Me.superToolTip1.SetToolTip(Me.officeSplitButton12, toolTipInfo6)
			' 
			' officeButton107
			' 
			Me.officeButton107.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton107.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton107.Image = (CType(resources.GetObject("officeButton107.Image"), System.Drawing.Image))
			Me.officeButton107.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton107.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton107.Name = "officeButton107"
			Me.officeButton107.Size = New System.Drawing.Size(274, 51)
			Me.officeButton107.Text = "&Print"
			' 
			' officeButton108
			' 
			Me.officeButton108.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton108.HelpText = "Send the workbook directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton108.Image = (CType(resources.GetObject("officeButton108.Image"), System.Drawing.Image))
			Me.officeButton108.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton108.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton108.Name = "officeButton108"
			Me.officeButton108.Size = New System.Drawing.Size(274, 51)
			Me.officeButton108.Text = "&Quick Print"
			' 
			' officeButton109
			' 
			Me.officeButton109.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton109.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton109.Image = (CType(resources.GetObject("officeButton109.Image"), System.Drawing.Image))
			Me.officeButton109.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton109.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton109.Name = "officeButton109"
			Me.officeButton109.Size = New System.Drawing.Size(274, 51)
			Me.officeButton109.Text = "Print Pre&view"
			' 
			' officeDropDownButton18
			' 
			Me.officeDropDownButton18.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.officeDropDownButton18.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton110, Me.officeButton111, Me.officeButton115, Me.officeButton112, Me.officeButton113, Me.officeButton114, Me.officeButton116})
			Me.officeDropDownButton18.Image = (CType(resources.GetObject("officeDropDownButton18.Image"), System.Drawing.Image))
			Me.officeDropDownButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton18.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton18.Name = "officeDropDownButton18"
			Me.officeDropDownButton18.Size = New System.Drawing.Size(119, 36)
			Me.officeDropDownButton18.Text = "Prepare"
			toolTipInfo7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo7.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo7.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo7.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo7.Header.Text = "Prepare"
			Me.superToolTip1.SetToolTip(Me.officeDropDownButton18, toolTipInfo7)
			' 
			' officeButton110
			' 
			Me.officeButton110.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton110.HelpText = "View and edit Excel properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton110.Image = (CType(resources.GetObject("officeButton110.Image"), System.Drawing.Image))
			Me.officeButton110.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton110.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton110.Name = "officeButton110"
			Me.officeButton110.Size = New System.Drawing.Size(271, 51)
			Me.officeButton110.Text = "Properties"
			' 
			' officeButton111
			' 
			Me.officeButton111.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton111.HelpText = "Increase the security of the Excel by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton111.Image = (CType(resources.GetObject("officeButton111.Image"), System.Drawing.Image))
			Me.officeButton111.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton111.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton111.Name = "officeButton111"
			Me.officeButton111.Size = New System.Drawing.Size(271, 51)
			Me.officeButton111.Text = "Encrypt Excel"
			' 
			' officeButton115
			' 
			Me.officeButton115.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton115.HelpText = "Check the Excel for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton115.Image = (CType(resources.GetObject("officeButton115.Image"), System.Drawing.Image))
			Me.officeButton115.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton115.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton115.Name = "officeButton115"
			Me.officeButton115.Size = New System.Drawing.Size(271, 51)
			Me.officeButton115.Text = "Inspect Excel"
			' 
			' officeButton112
			' 
			Me.officeButton112.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton112.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton112.Image = (CType(resources.GetObject("officeButton112.Image"), System.Drawing.Image))
			Me.officeButton112.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton112.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton112.Name = "officeButton112"
			Me.officeButton112.Size = New System.Drawing.Size(271, 51)
			Me.officeButton112.Text = "Restrict Permission"
			' 
			' officeButton113
			' 
			Me.officeButton113.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton113.HelpText = "Ensure the integrity of the Excel by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton113.Image = (CType(resources.GetObject("officeButton113.Image"), System.Drawing.Image))
			Me.officeButton113.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton113.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton113.Name = "officeButton113"
			Me.officeButton113.Size = New System.Drawing.Size(271, 51)
			Me.officeButton113.Text = "Add a Digital Signature"
			' 
			' officeButton114
			' 
			Me.officeButton114.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton114.HelpText = "Let readers know the Excel is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton114.Image = (CType(resources.GetObject("officeButton114.Image"), System.Drawing.Image))
			Me.officeButton114.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton114.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton114.Name = "officeButton114"
			Me.officeButton114.Size = New System.Drawing.Size(271, 51)
			Me.officeButton114.Text = "Mark as Final"
			' 
			' officeButton116
			' 
			Me.officeButton116.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton116.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Excel."
			Me.officeButton116.Image = (CType(resources.GetObject("officeButton116.Image"), System.Drawing.Image))
			Me.officeButton116.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton116.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton116.Name = "officeButton116"
			Me.officeButton116.Size = New System.Drawing.Size(271, 51)
			Me.officeButton116.Text = "Run Compatibility Checker"
			' 
			' officeDropDownButton19
			' 
			Me.officeDropDownButton19.AutoSize = False
			Me.officeDropDownButton19.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.officeDropDownButton19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton117, Me.officeButton118})
			Me.officeDropDownButton19.Image = (CType(resources.GetObject("officeDropDownButton19.Image"), System.Drawing.Image))
			Me.officeDropDownButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton19.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton19.Name = "officeDropDownButton19"
			Me.officeDropDownButton19.Size = New System.Drawing.Size(119, 36)
			Me.officeDropDownButton19.Text = "Send"
			toolTipInfo8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo8.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo8.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo8.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo8.Header.Text = "Send"
			Me.superToolTip1.SetToolTip(Me.officeDropDownButton19, toolTipInfo8)
			' 
			' officeButton117
			' 
			Me.officeButton117.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton117.HelpText = "Send a copy of the Excel in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton117.Image = (CType(resources.GetObject("officeButton117.Image"), System.Drawing.Image))
			Me.officeButton117.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton117.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton117.Name = "officeButton117"
			Me.officeButton117.Size = New System.Drawing.Size(239, 51)
			Me.officeButton117.Text = "E-mail"
			' 
			' officeButton118
			' 
			Me.officeButton118.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton118.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCrLf & "Excel."
			Me.officeButton118.Image = (CType(resources.GetObject("officeButton118.Image"), System.Drawing.Image))
			Me.officeButton118.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton118.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton118.Name = "officeButton118"
			Me.officeButton118.Size = New System.Drawing.Size(239, 51)
			Me.officeButton118.Text = "Internet Fax"
			' 
			' officeDropDownButton20
			' 
			Me.officeDropDownButton20.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.officeDropDownButton20.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton119, Me.officeButton120, Me.officeButton121})
			Me.officeDropDownButton20.Image = (CType(resources.GetObject("officeDropDownButton20.Image"), System.Drawing.Image))
			Me.officeDropDownButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton20.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton20.Name = "officeDropDownButton20"
			Me.officeDropDownButton20.Size = New System.Drawing.Size(119, 36)
			Me.officeDropDownButton20.Text = "Publish"
			toolTipInfo9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo9.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo9.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo9.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo9.Header.Text = "Publish"
			Me.superToolTip1.SetToolTip(Me.officeDropDownButton20, toolTipInfo9)
			' 
			' officeButton119
			' 
			Me.officeButton119.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton119.HelpText = "Create a new blog post with the contents of " & Constants.vbCrLf & "the Excel."
			Me.officeButton119.Image = (CType(resources.GetObject("officeButton119.Image"), System.Drawing.Image))
			Me.officeButton119.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton119.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton119.Name = "officeButton119"
			Me.officeButton119.Size = New System.Drawing.Size(276, 51)
			Me.officeButton119.Text = "Blog"
			' 
			' officeButton120
			' 
			Me.officeButton120.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton120.HelpText = "Share the Excel by saving it to a document " & Constants.vbCrLf & "management server."
			Me.officeButton120.Image = (CType(resources.GetObject("officeButton120.Image"), System.Drawing.Image))
			Me.officeButton120.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton120.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton120.Name = "officeButton120"
			Me.officeButton120.Size = New System.Drawing.Size(276, 51)
			Me.officeButton120.Text = "Document Management Server"
			' 
			' officeButton121
			' 
			Me.officeButton121.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton121.HelpText = "Create a new site for the Excel and keep " & Constants.vbCrLf & "the local copy synchronized."
			Me.officeButton121.Image = (CType(resources.GetObject("officeButton121.Image"), System.Drawing.Image))
			Me.officeButton121.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton121.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton121.Name = "officeButton121"
			Me.officeButton121.Size = New System.Drawing.Size(276, 51)
			Me.officeButton121.Text = "Create Document Workspace"
			' 
			' toolStripSeparator9
			' 
			Me.toolStripSeparator9.Name = "toolStripSeparator9"
			Me.toolStripSeparator9.Size = New System.Drawing.Size(103, 2)
			' 
			' toolStripButton89
			' 
			Me.toolStripButton89.AutoSize = False
			Me.toolStripButton89.Image = (CType(resources.GetObject("toolStripButton89.Image"), System.Drawing.Image))
			Me.toolStripButton89.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton89.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton89.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton89.Name = "toolStripButton89"
			Me.toolStripButton89.Size = New System.Drawing.Size(119, 36)
			Me.toolStripButton89.Text = "Close"
			toolTipInfo10.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo10.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo10.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo10.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo10.Header.Text = "Close"
			Me.superToolTip1.SetToolTip(Me.toolStripButton89, toolTipInfo10)
			' 
			' toolStripButton6
			' 
			Me.toolStripButton6.AutoSize = False
			Me.toolStripButton6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton6.Image = (CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image))
			Me.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton6.Name = "toolStripButton6"
			Me.toolStripButton6.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton6.Size = New System.Drawing.Size(81, 25)
			Me.toolStripButton6.Text = "Exit Excel"
'			Me.toolStripButton6.Click += New System.EventHandler(Me.toolStripButton6_Click)
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.AutoSize = False
			Me.toolStripButton4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton4.Size = New System.Drawing.Size(98, 25)
			Me.toolStripButton4.Text = "Excel options"
			' 
			' toolStripSplitButtonEx2
			' 
			Me.toolStripSplitButtonEx2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripSplitButtonEx2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.mergeCenterToolStripMenuItem, Me.mergeAcrossToolStripMenuItem, Me.mergeCellsToolStripMenuItem, Me.unmergeCellsToolStripMenuItem})
			Me.toolStripSplitButtonEx2.Image = (CType(resources.GetObject("toolStripSplitButtonEx2.Image"), System.Drawing.Image))
			Me.toolStripSplitButtonEx2.Name = "toolStripSplitButtonEx2"
			Me.toolStripSplitButtonEx2.Size = New System.Drawing.Size(33, 20)
			Me.toolStripSplitButtonEx2.Text = "toolStripSplitButtonEx2"
			Me.toolStripSplitButtonEx2.ToolTipText = "Merge & Center"
			' 
			' mergeCenterToolStripMenuItem
			' 
			Me.mergeCenterToolStripMenuItem.Name = "mergeCenterToolStripMenuItem"
			Me.mergeCenterToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
			Me.mergeCenterToolStripMenuItem.Text = "Merge & Center"
			' 
			' mergeAcrossToolStripMenuItem
			' 
			Me.mergeAcrossToolStripMenuItem.Name = "mergeAcrossToolStripMenuItem"
			Me.mergeAcrossToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
			Me.mergeAcrossToolStripMenuItem.Text = "Merge Across"
			' 
			' mergeCellsToolStripMenuItem
			' 
			Me.mergeCellsToolStripMenuItem.Name = "mergeCellsToolStripMenuItem"
			Me.mergeCellsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
			Me.mergeCellsToolStripMenuItem.Text = "Merge cells"
			' 
			' unmergeCellsToolStripMenuItem
			' 
			Me.unmergeCellsToolStripMenuItem.Name = "unmergeCellsToolStripMenuItem"
			Me.unmergeCellsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
			Me.unmergeCellsToolStripMenuItem.Text = "Unmerge cells"
			' 
			' toolStripPanelItem8
			' 
			Me.toolStripPanelItem8.CausesValidation = False
			Me.toolStripPanelItem8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem8.GroupedButtons = True
			Me.toolStripPanelItem8.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.deindentToolStripBtn, Me.inindentToolStripBtn})
			Me.toolStripPanelItem8.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
			Me.toolStripPanelItem8.Name = "toolStripPanelItem8"
			Me.toolStripPanelItem8.RowCount = 1
			Me.toolStripPanelItem8.Size = New System.Drawing.Size(50, 27)
			Me.toolStripPanelItem8.Text = "toolStripPanelItem8"
			Me.toolStripPanelItem8.Transparent = True
			' 
			' deindentToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.deindentToolStripBtn, "5")
			Me.deindentToolStripBtn.AutoToolTip = False
			Me.deindentToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.deindentToolStripBtn.Image = (CType(resources.GetObject("deindentToolStripBtn.Image"), System.Drawing.Image))
			Me.deindentToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.deindentToolStripBtn.Name = "deindentToolStripBtn"
			Me.deindentToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.deindentToolStripBtn.Text = "deindentToolStripBtn"
			toolTipInfo11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo11.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo11.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo11.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo11.Header.Text = "Decrease indent"
			Me.superToolTip1.SetToolTip(Me.deindentToolStripBtn, toolTipInfo11)
			Me.deindentToolStripBtn.ToolTipText = "Decrease indent"
			' 
			' inindentToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.inindentToolStripBtn, "6")
			Me.inindentToolStripBtn.AutoToolTip = False
			Me.inindentToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.inindentToolStripBtn.Image = (CType(resources.GetObject("inindentToolStripBtn.Image"), System.Drawing.Image))
			Me.inindentToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.inindentToolStripBtn.Name = "inindentToolStripBtn"
			Me.inindentToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.inindentToolStripBtn.Text = "inindentToolStripBtn"
			toolTipInfo12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo12.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo12.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo12.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo12.Header.Text = "Increase indent"
			Me.superToolTip1.SetToolTip(Me.inindentToolStripBtn, toolTipInfo12)
			Me.inindentToolStripBtn.ToolTipText = "Increase indent"
			' 
			' toolStripButton73
			' 
			Me.toolStripButton73.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton73.Image = (CType(resources.GetObject("toolStripButton73.Image"), System.Drawing.Image))
			Me.toolStripButton73.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton73.Margin = New System.Windows.Forms.Padding(0, 3, 0, 2)
			Me.toolStripButton73.Name = "toolStripButton73"
			Me.toolStripButton73.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton73.Text = "toolStripButton73"
			toolTipInfo13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo13.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo13.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo13.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo13.Header.Text = "Orientation"
			Me.superToolTip1.SetToolTip(Me.toolStripButton73, toolTipInfo13)
			Me.toolStripButton73.ToolTipText = "Orientation"
			' 
			' barItem1
			' 
			Me.barItem1.Tooltip = "Cancel"
			' 
			' barItem2
			' 
			Me.barItem2.Tooltip = "Enter"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton1.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton1.Text = "&New"
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton2.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton2.Text = "&Open"
			' 
			' toolStripButton18
			' 
			Me.toolStripButton18.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton18.Name = "toolStripButton18"
			Me.toolStripButton18.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton18.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton18.Text = "&Save"
			' 
			' officeSplitButton1
			' 
			Me.officeSplitButton1.AutoSize = False
			Me.officeSplitButton1.DropDownButtonWidth = 18
			Me.officeSplitButton1.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton1, Me.officeButton2, Me.officeButton3, Me.officeButton4, Me.officeButton5})
			Me.officeSplitButton1.DropDownText = "Save a copy of the document"
			Me.officeSplitButton1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton1.Image = (CType(resources.GetObject("officeSplitButton1.Image"), System.Drawing.Image))
			Me.officeSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton1.Name = "officeSplitButton1"
			Me.officeSplitButton1.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton1.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton1.Text = "Save &As..."
			Me.officeSplitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton1
			' 
			Me.officeButton1.AutoSize = False
			Me.officeButton1.AutoToolTip = False
			Me.officeButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton1.HelpText = "Save the document in default file format."
			Me.officeButton1.Image = (CType(resources.GetObject("officeButton1.Image"), System.Drawing.Image))
			Me.officeButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton1.Name = "officeButton1"
			Me.officeButton1.Size = New System.Drawing.Size(263, 36)
			Me.officeButton1.Text = "&Word Document"
			Me.officeButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton2
			' 
			Me.officeButton2.AutoSize = False
			Me.officeButton2.AutoToolTip = False
			Me.officeButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton2.HelpText = "Save the document as a template that can " & Constants.vbCrLf & "be used to format future documents."
			Me.officeButton2.Image = (CType(resources.GetObject("officeButton2.Image"), System.Drawing.Image))
			Me.officeButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton2.Name = "officeButton2"
			Me.officeButton2.Size = New System.Drawing.Size(263, 45)
			Me.officeButton2.Text = "Word &Template"
			Me.officeButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton3
			' 
			Me.officeButton3.AutoSize = False
			Me.officeButton3.AutoToolTip = False
			Me.officeButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton3.HelpText = "Save a copy of the document that is fully " & Constants.vbCrLf & "compatible with Word 97-2003."
			Me.officeButton3.Image = (CType(resources.GetObject("officeButton3.Image"), System.Drawing.Image))
			Me.officeButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton3.Name = "officeButton3"
			Me.officeButton3.Size = New System.Drawing.Size(263, 45)
			Me.officeButton3.Text = "Word &97-2003 Document"
			Me.officeButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton4
			' 
			Me.officeButton4.AutoSize = False
			Me.officeButton4.AutoToolTip = False
			Me.officeButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton4.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton4.Image = (CType(resources.GetObject("officeButton4.Image"), System.Drawing.Image))
			Me.officeButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton4.Name = "officeButton4"
			Me.officeButton4.Size = New System.Drawing.Size(263, 45)
			Me.officeButton4.Text = "&Find add-ins for other file formats"
			Me.officeButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton5
			' 
			Me.officeButton5.AutoSize = False
			Me.officeButton5.AutoToolTip = False
			Me.officeButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton5.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton5.Image = (CType(resources.GetObject("officeButton5.Image"), System.Drawing.Image))
			Me.officeButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton5.Name = "officeButton5"
			Me.officeButton5.Size = New System.Drawing.Size(263, 45)
			Me.officeButton5.Text = "&Other Formats"
			Me.officeButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeSplitButton2
			' 
			Me.officeSplitButton2.DropDownButtonWidth = 18
			Me.officeSplitButton2.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton6, Me.officeButton7, Me.officeButton8})
			Me.officeSplitButton2.DropDownText = "Preview and print the document"
			Me.officeSplitButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton2.Name = "officeSplitButton2"
			Me.officeSplitButton2.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton2.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton2.Text = "&Print"
			Me.officeSplitButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton6
			' 
			Me.officeButton6.AutoToolTip = False
			Me.officeButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton6.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton6.Image = (CType(resources.GetObject("officeButton6.Image"), System.Drawing.Image))
			Me.officeButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton6.Name = "officeButton6"
			Me.officeButton6.Size = New System.Drawing.Size(274, 51)
			Me.officeButton6.Text = "&Print"
			Me.officeButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton7
			' 
			Me.officeButton7.AutoToolTip = False
			Me.officeButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton7.HelpText = "Send the document directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton7.Image = (CType(resources.GetObject("officeButton7.Image"), System.Drawing.Image))
			Me.officeButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton7.Name = "officeButton7"
			Me.officeButton7.Size = New System.Drawing.Size(274, 51)
			Me.officeButton7.Text = "&Quick Print"
			Me.officeButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton8
			' 
			Me.officeButton8.AutoToolTip = False
			Me.officeButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton8.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton8.Image = (CType(resources.GetObject("officeButton8.Image"), System.Drawing.Image))
			Me.officeButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton8.Name = "officeButton8"
			Me.officeButton8.Size = New System.Drawing.Size(274, 51)
			Me.officeButton8.Text = "Print Pre&view"
			Me.officeButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton1
			' 
			Me.officeDropDownButton1.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton9, Me.officeButton10, Me.officeButton11, Me.officeButton12, Me.officeButton13, Me.officeButton14, Me.officeButton15})
			Me.officeDropDownButton1.DropDownText = "Prepare the document for distribution"
			Me.officeDropDownButton1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton1.Name = "officeDropDownButton1"
			Me.officeDropDownButton1.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton1.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton1.Text = "Pr&epare"
			Me.officeDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton9
			' 
			Me.officeButton9.AutoToolTip = False
			Me.officeButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton9.HelpText = "View and edit document properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton9.Image = (CType(resources.GetObject("officeButton9.Image"), System.Drawing.Image))
			Me.officeButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton9.Name = "officeButton9"
			Me.officeButton9.Size = New System.Drawing.Size(273, 51)
			Me.officeButton9.Text = "Properties"
			Me.officeButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton10
			' 
			Me.officeButton10.AutoToolTip = False
			Me.officeButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton10.HelpText = "Check the document for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton10.Image = (CType(resources.GetObject("officeButton10.Image"), System.Drawing.Image))
			Me.officeButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton10.Name = "officeButton10"
			Me.officeButton10.Size = New System.Drawing.Size(273, 51)
			Me.officeButton10.Text = "Inspect document"
			Me.officeButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton11
			' 
			Me.officeButton11.AutoToolTip = False
			Me.officeButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton11.HelpText = "Increase the security of the document by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton11.Image = (CType(resources.GetObject("officeButton11.Image"), System.Drawing.Image))
			Me.officeButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton11.Name = "officeButton11"
			Me.officeButton11.Size = New System.Drawing.Size(273, 51)
			Me.officeButton11.Text = "Encrypt Document"
			Me.officeButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton12
			' 
			Me.officeButton12.AutoToolTip = False
			Me.officeButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton12.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton12.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton12.Image = (CType(resources.GetObject("officeButton12.Image"), System.Drawing.Image))
			Me.officeButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton12.Name = "officeButton12"
			Me.officeButton12.Size = New System.Drawing.Size(273, 51)
			Me.officeButton12.Text = "Restrict Permission"
			Me.officeButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton13
			' 
			Me.officeButton13.AutoToolTip = False
			Me.officeButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton13.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton13.HelpText = "Ensure the integrity of the document by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton13.Image = (CType(resources.GetObject("officeButton13.Image"), System.Drawing.Image))
			Me.officeButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton13.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton13.Name = "officeButton13"
			Me.officeButton13.Size = New System.Drawing.Size(273, 51)
			Me.officeButton13.Text = "Add a Digital Signature"
			Me.officeButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton14
			' 
			Me.officeButton14.AutoToolTip = False
			Me.officeButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton14.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton14.HelpText = "Let readers know the document is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton14.Image = (CType(resources.GetObject("officeButton14.Image"), System.Drawing.Image))
			Me.officeButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton14.Name = "officeButton14"
			Me.officeButton14.Size = New System.Drawing.Size(273, 51)
			Me.officeButton14.Text = "Mark as Final"
			Me.officeButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton15
			' 
			Me.officeButton15.AutoToolTip = False
			Me.officeButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton15.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Word."
			Me.officeButton15.Image = (CType(resources.GetObject("officeButton15.Image"), System.Drawing.Image))
			Me.officeButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton15.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton15.Name = "officeButton15"
			Me.officeButton15.Size = New System.Drawing.Size(273, 51)
			Me.officeButton15.Text = "Run Compatibility Checker"
			Me.officeButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton3
			' 
			Me.officeDropDownButton3.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton16, Me.officeButton17})
			Me.officeDropDownButton3.DropDownText = "Send a copy to other people"
			Me.officeDropDownButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton3.Image = (CType(resources.GetObject("officeDropDownButton3.Image"), System.Drawing.Image))
			Me.officeDropDownButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton3.Name = "officeDropDownButton3"
			Me.officeDropDownButton3.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton3.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton3.Text = "Sen&d"
			Me.officeDropDownButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton16
			' 
			Me.officeButton16.AutoToolTip = False
			Me.officeButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton16.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton16.HelpText = "Send a copy of the document in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton16.Image = (CType(resources.GetObject("officeButton16.Image"), System.Drawing.Image))
			Me.officeButton16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton16.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton16.Name = "officeButton16"
			Me.officeButton16.Size = New System.Drawing.Size(268, 51)
			Me.officeButton16.Text = "E-mail"
			Me.officeButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton17
			' 
			Me.officeButton17.AutoToolTip = False
			Me.officeButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton17.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton17.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCrLf & "document."
			Me.officeButton17.Image = (CType(resources.GetObject("officeButton17.Image"), System.Drawing.Image))
			Me.officeButton17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton17.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton17.Name = "officeButton17"
			Me.officeButton17.Size = New System.Drawing.Size(268, 51)
			Me.officeButton17.Text = "Internet Fax"
			Me.officeButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton4
			' 
			Me.officeDropDownButton4.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton18, Me.officeButton19, Me.officeButton20})
			Me.officeDropDownButton4.DropDownText = "Distribute the document to other people"
			Me.officeDropDownButton4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton4.Name = "officeDropDownButton4"
			Me.officeDropDownButton4.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton4.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton4.Text = "P&ublish"
			Me.officeDropDownButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton18
			' 
			Me.officeButton18.AutoToolTip = False
			Me.officeButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton18.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton18.HelpText = "Create a new blog post with the contents of " & Constants.vbCrLf & "the document."
			Me.officeButton18.Image = (CType(resources.GetObject("officeButton18.Image"), System.Drawing.Image))
			Me.officeButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton18.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton18.Name = "officeButton18"
			Me.officeButton18.Size = New System.Drawing.Size(276, 51)
			Me.officeButton18.Text = "Blog"
			Me.officeButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton19
			' 
			Me.officeButton19.AutoToolTip = False
			Me.officeButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton19.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton19.HelpText = "Share the document by saving it to a " & Constants.vbCrLf & "document management server."
			Me.officeButton19.Image = (CType(resources.GetObject("officeButton19.Image"), System.Drawing.Image))
			Me.officeButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton19.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton19.Name = "officeButton19"
			Me.officeButton19.Size = New System.Drawing.Size(276, 51)
			Me.officeButton19.Text = "Document Management Server"
			Me.officeButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton20
			' 
			Me.officeButton20.AutoToolTip = False
			Me.officeButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton20.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton20.HelpText = "Create a new site for the document and" & Constants.vbCrLf & "keep the local copy synchronized."
			Me.officeButton20.Image = (CType(resources.GetObject("officeButton20.Image"), System.Drawing.Image))
			Me.officeButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton20.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton20.Name = "officeButton20"
			Me.officeButton20.Size = New System.Drawing.Size(276, 51)
			Me.officeButton20.Text = "Create Document Workspace"
			Me.officeButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton3.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton3.Text = "&New"
			' 
			' toolStripSeparator4
			' 
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New System.Drawing.Size(105, 2)
			' 
			' officeSplitButton3
			' 
			Me.officeSplitButton3.AutoSize = False
			Me.officeSplitButton3.DropDownButtonWidth = 18
			Me.officeSplitButton3.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton21, Me.officeButton22, Me.officeButton23, Me.officeButton24, Me.officeButton25})
			Me.officeSplitButton3.DropDownText = "Save a copy of the document"
			Me.officeSplitButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton3.Image = (CType(resources.GetObject("officeSplitButton3.Image"), System.Drawing.Image))
			Me.officeSplitButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton3.Name = "officeSplitButton3"
			Me.officeSplitButton3.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton3.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton3.Text = "Save &As..."
			Me.officeSplitButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton21
			' 
			Me.officeButton21.AutoSize = False
			Me.officeButton21.AutoToolTip = False
			Me.officeButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton21.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton21.HelpText = "Save the document in default file format."
			Me.officeButton21.Image = (CType(resources.GetObject("officeButton21.Image"), System.Drawing.Image))
			Me.officeButton21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton21.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton21.Name = "officeButton21"
			Me.officeButton21.Size = New System.Drawing.Size(263, 36)
			Me.officeButton21.Text = "&Word Document"
			Me.officeButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton22
			' 
			Me.officeButton22.AutoSize = False
			Me.officeButton22.AutoToolTip = False
			Me.officeButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton22.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton22.HelpText = "Save the document as a template that can " & Constants.vbCrLf & "be used to format future documents."
			Me.officeButton22.Image = (CType(resources.GetObject("officeButton22.Image"), System.Drawing.Image))
			Me.officeButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton22.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton22.Name = "officeButton22"
			Me.officeButton22.Size = New System.Drawing.Size(263, 45)
			Me.officeButton22.Text = "Word &Template"
			Me.officeButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton23
			' 
			Me.officeButton23.AutoSize = False
			Me.officeButton23.AutoToolTip = False
			Me.officeButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton23.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton23.HelpText = "Save a copy of the document that is fully " & Constants.vbCrLf & "compatible with Word 97-2003."
			Me.officeButton23.Image = (CType(resources.GetObject("officeButton23.Image"), System.Drawing.Image))
			Me.officeButton23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton23.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton23.Name = "officeButton23"
			Me.officeButton23.Size = New System.Drawing.Size(263, 45)
			Me.officeButton23.Text = "Word &97-2003 Document"
			Me.officeButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton24
			' 
			Me.officeButton24.AutoSize = False
			Me.officeButton24.AutoToolTip = False
			Me.officeButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton24.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton24.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton24.Image = (CType(resources.GetObject("officeButton24.Image"), System.Drawing.Image))
			Me.officeButton24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton24.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton24.Name = "officeButton24"
			Me.officeButton24.Size = New System.Drawing.Size(263, 45)
			Me.officeButton24.Text = "&Find add-ins for other file formats"
			Me.officeButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton25
			' 
			Me.officeButton25.AutoSize = False
			Me.officeButton25.AutoToolTip = False
			Me.officeButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton25.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton25.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton25.Image = (CType(resources.GetObject("officeButton25.Image"), System.Drawing.Image))
			Me.officeButton25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton25.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton25.Name = "officeButton25"
			Me.officeButton25.Size = New System.Drawing.Size(263, 45)
			Me.officeButton25.Text = "&Other Formats"
			Me.officeButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New System.Drawing.Size(105, 2)
			' 
			' officeSplitButton4
			' 
			Me.officeSplitButton4.DropDownButtonWidth = 18
			Me.officeSplitButton4.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton26, Me.officeButton27, Me.officeButton28})
			Me.officeSplitButton4.DropDownText = "Preview and print the document"
			Me.officeSplitButton4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton4.Name = "officeSplitButton4"
			Me.officeSplitButton4.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton4.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton4.Text = "&Print"
			Me.officeSplitButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton26
			' 
			Me.officeButton26.AutoToolTip = False
			Me.officeButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton26.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton26.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton26.Image = (CType(resources.GetObject("officeButton26.Image"), System.Drawing.Image))
			Me.officeButton26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton26.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton26.Name = "officeButton26"
			Me.officeButton26.Size = New System.Drawing.Size(274, 51)
			Me.officeButton26.Text = "&Print"
			Me.officeButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton27
			' 
			Me.officeButton27.AutoToolTip = False
			Me.officeButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton27.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton27.HelpText = "Send the document directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton27.Image = (CType(resources.GetObject("officeButton27.Image"), System.Drawing.Image))
			Me.officeButton27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton27.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton27.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton27.Name = "officeButton27"
			Me.officeButton27.Size = New System.Drawing.Size(274, 51)
			Me.officeButton27.Text = "&Quick Print"
			Me.officeButton27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton28
			' 
			Me.officeButton28.AutoToolTip = False
			Me.officeButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton28.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton28.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton28.Image = (CType(resources.GetObject("officeButton28.Image"), System.Drawing.Image))
			Me.officeButton28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton28.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton28.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton28.Name = "officeButton28"
			Me.officeButton28.Size = New System.Drawing.Size(274, 51)
			Me.officeButton28.Text = "Print Pre&view"
			Me.officeButton28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton2
			' 
			Me.officeDropDownButton2.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton29, Me.officeButton30, Me.officeButton31, Me.officeButton32, Me.officeButton33, Me.officeButton34, Me.officeButton35})
			Me.officeDropDownButton2.DropDownText = "Prepare the document for distribution"
			Me.officeDropDownButton2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton2.Name = "officeDropDownButton2"
			Me.officeDropDownButton2.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton2.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton2.Text = "Pr&epare"
			Me.officeDropDownButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton29
			' 
			Me.officeButton29.AutoToolTip = False
			Me.officeButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton29.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton29.HelpText = "View and edit document properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton29.Image = (CType(resources.GetObject("officeButton29.Image"), System.Drawing.Image))
			Me.officeButton29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton29.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton29.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton29.Name = "officeButton29"
			Me.officeButton29.Size = New System.Drawing.Size(273, 51)
			Me.officeButton29.Text = "Properties"
			Me.officeButton29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton30
			' 
			Me.officeButton30.AutoToolTip = False
			Me.officeButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton30.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton30.HelpText = "Check the document for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton30.Image = (CType(resources.GetObject("officeButton30.Image"), System.Drawing.Image))
			Me.officeButton30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton30.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton30.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton30.Name = "officeButton30"
			Me.officeButton30.Size = New System.Drawing.Size(273, 51)
			Me.officeButton30.Text = "Inspect document"
			Me.officeButton30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton31
			' 
			Me.officeButton31.AutoToolTip = False
			Me.officeButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton31.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton31.HelpText = "Increase the security of the document by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton31.Image = (CType(resources.GetObject("officeButton31.Image"), System.Drawing.Image))
			Me.officeButton31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton31.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton31.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton31.Name = "officeButton31"
			Me.officeButton31.Size = New System.Drawing.Size(273, 51)
			Me.officeButton31.Text = "Encrypt Document"
			Me.officeButton31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton32
			' 
			Me.officeButton32.AutoToolTip = False
			Me.officeButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton32.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton32.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton32.Image = (CType(resources.GetObject("officeButton32.Image"), System.Drawing.Image))
			Me.officeButton32.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton32.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton32.Name = "officeButton32"
			Me.officeButton32.Size = New System.Drawing.Size(273, 51)
			Me.officeButton32.Text = "Restrict Permission"
			Me.officeButton32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton33
			' 
			Me.officeButton33.AutoToolTip = False
			Me.officeButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton33.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton33.HelpText = "Ensure the integrity of the document by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton33.Image = (CType(resources.GetObject("officeButton33.Image"), System.Drawing.Image))
			Me.officeButton33.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton33.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton33.Name = "officeButton33"
			Me.officeButton33.Size = New System.Drawing.Size(273, 51)
			Me.officeButton33.Text = "Add a Digital Signature"
			Me.officeButton33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton34
			' 
			Me.officeButton34.AutoToolTip = False
			Me.officeButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton34.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton34.HelpText = "Let readers know the document is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton34.Image = (CType(resources.GetObject("officeButton34.Image"), System.Drawing.Image))
			Me.officeButton34.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton34.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton34.Name = "officeButton34"
			Me.officeButton34.Size = New System.Drawing.Size(273, 51)
			Me.officeButton34.Text = "Mark as Final"
			Me.officeButton34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton35
			' 
			Me.officeButton35.AutoToolTip = False
			Me.officeButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton35.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton35.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Word."
			Me.officeButton35.Image = (CType(resources.GetObject("officeButton35.Image"), System.Drawing.Image))
			Me.officeButton35.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton35.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton35.Name = "officeButton35"
			Me.officeButton35.Size = New System.Drawing.Size(273, 51)
			Me.officeButton35.Text = "Run Compatibility Checker"
			Me.officeButton35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton5
			' 
			Me.officeDropDownButton5.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton36, Me.officeButton37})
			Me.officeDropDownButton5.DropDownText = "Send a copy to other people"
			Me.officeDropDownButton5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton5.Image = (CType(resources.GetObject("officeDropDownButton5.Image"), System.Drawing.Image))
			Me.officeDropDownButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton5.Name = "officeDropDownButton5"
			Me.officeDropDownButton5.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton5.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton5.Text = "Sen&d"
			Me.officeDropDownButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton36
			' 
			Me.officeButton36.AutoToolTip = False
			Me.officeButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton36.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton36.HelpText = "Send a copy of the document in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton36.Image = (CType(resources.GetObject("officeButton36.Image"), System.Drawing.Image))
			Me.officeButton36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton36.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton36.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton36.Name = "officeButton36"
			Me.officeButton36.Size = New System.Drawing.Size(268, 51)
			Me.officeButton36.Text = "E-mail"
			Me.officeButton36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton37
			' 
			Me.officeButton37.AutoToolTip = False
			Me.officeButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton37.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton37.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCrLf & "document."
			Me.officeButton37.Image = (CType(resources.GetObject("officeButton37.Image"), System.Drawing.Image))
			Me.officeButton37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton37.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton37.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton37.Name = "officeButton37"
			Me.officeButton37.Size = New System.Drawing.Size(268, 51)
			Me.officeButton37.Text = "Internet Fax"
			Me.officeButton37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton6
			' 
			Me.officeDropDownButton6.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton38, Me.officeButton39, Me.officeButton40})
			Me.officeDropDownButton6.DropDownText = "Distribute the document to other people"
			Me.officeDropDownButton6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton6.Name = "officeDropDownButton6"
			Me.officeDropDownButton6.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton6.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton6.Text = "P&ublish"
			Me.officeDropDownButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton38
			' 
			Me.officeButton38.AutoToolTip = False
			Me.officeButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton38.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton38.HelpText = "Create a new blog post with the contents of " & Constants.vbCrLf & "the document."
			Me.officeButton38.Image = (CType(resources.GetObject("officeButton38.Image"), System.Drawing.Image))
			Me.officeButton38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton38.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton38.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton38.Name = "officeButton38"
			Me.officeButton38.Size = New System.Drawing.Size(276, 51)
			Me.officeButton38.Text = "Blog"
			Me.officeButton38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton39
			' 
			Me.officeButton39.AutoToolTip = False
			Me.officeButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton39.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton39.HelpText = "Share the document by saving it to a " & Constants.vbCrLf & "document management server."
			Me.officeButton39.Image = (CType(resources.GetObject("officeButton39.Image"), System.Drawing.Image))
			Me.officeButton39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton39.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton39.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton39.Name = "officeButton39"
			Me.officeButton39.Size = New System.Drawing.Size(276, 51)
			Me.officeButton39.Text = "Document Management Server"
			Me.officeButton39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton40
			' 
			Me.officeButton40.AutoToolTip = False
			Me.officeButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton40.HelpText = "Create a new site for the document and" & Constants.vbCrLf & "keep the local copy synchronized."
			Me.officeButton40.Image = (CType(resources.GetObject("officeButton40.Image"), System.Drawing.Image))
			Me.officeButton40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton40.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton40.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton40.Name = "officeButton40"
			Me.officeButton40.Size = New System.Drawing.Size(276, 51)
			Me.officeButton40.Text = "Create Document Workspace"
			Me.officeButton40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripSeparator6
			' 
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New System.Drawing.Size(105, 2)
			' 
			' toolStripButton8
			' 
			Me.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton8.Image = (CType(resources.GetObject("toolStripButton8.Image"), System.Drawing.Image))
			Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton8.Name = "toolStripButton8"
			Me.toolStripButton8.Size = New System.Drawing.Size(363, 20)
			Me.toolStripButton8.Text = "toolStripButton8"
			' 
			' toolStripButton64
			' 
			Me.toolStripButton64.AutoSize = False
			Me.toolStripButton64.AutoToolTip = False
			Me.toolStripButton64.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton64.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton64.Name = "toolStripButton64"
			Me.toolStripButton64.Size = New System.Drawing.Size(265, 22)
			Me.toolStripButton64.Text = "&3 Report.doc"
			Me.toolStripButton64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton69
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton69, "FG")
			Me.toolStripButton69.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton69.Image = (CType(resources.GetObject("toolStripButton69.Image"), System.Drawing.Image))
			Me.toolStripButton69.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton69.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton69.Name = "toolStripButton69"
			Me.toolStripButton69.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton69.Text = "growfontToolStripBtn"
			' 
			' toolStripButton70
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton70, "FK")
			Me.toolStripButton70.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton70.Image = (CType(resources.GetObject("toolStripButton70.Image"), System.Drawing.Image))
			Me.toolStripButton70.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton70.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton70.Name = "toolStripButton70"
			Me.toolStripButton70.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton70.Text = "shrinkfontToolStripBtn"
			' 
			' toolStripMenuItem11
			' 
			Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
			Me.toolStripMenuItem11.Size = New System.Drawing.Size(192, 22)
			Me.toolStripMenuItem11.Text = "&Insert Table..."
			' 
			' toolStripMenuItem12
			' 
			Me.toolStripMenuItem12.Name = "toolStripMenuItem12"
			Me.toolStripMenuItem12.Size = New System.Drawing.Size(192, 22)
			Me.toolStripMenuItem12.Text = "&Draw Table"
			' 
			' toolStripMenuItem13
			' 
			Me.toolStripMenuItem13.Name = "toolStripMenuItem13"
			Me.toolStripMenuItem13.Size = New System.Drawing.Size(192, 22)
			Me.toolStripMenuItem13.Text = "Conv&ert Text to Table..."
			' 
			' toolStripMenuItem14
			' 
			Me.toolStripMenuItem14.Name = "toolStripMenuItem14"
			Me.toolStripMenuItem14.Size = New System.Drawing.Size(192, 22)
			Me.toolStripMenuItem14.Text = "E&xcel Spreadsheet"
			' 
			' toolStripMenuItem15
			' 
			Me.toolStripMenuItem15.Name = "toolStripMenuItem15"
			Me.toolStripMenuItem15.Size = New System.Drawing.Size(192, 22)
			Me.toolStripMenuItem15.Text = "Quick &Tables"
			' 
			' toolStripMenuItem16
			' 
			Me.toolStripMenuItem16.Enabled = False
			Me.toolStripMenuItem16.Name = "toolStripMenuItem16"
			Me.toolStripMenuItem16.Size = New System.Drawing.Size(268, 22)
			Me.toolStripMenuItem16.Text = "&Save Selection to Quick Tables Gallery..."
			' 
			' toolStripButton65
			' 
			Me.toolStripButton65.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton65.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton65.Image = (CType(resources.GetObject("toolStripButton65.Image"), System.Drawing.Image))
			Me.toolStripButton65.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton65.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton65.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton65.Name = "toolStripButton65"
			Me.toolStripButton65.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton65.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton65.Text = "&New"
			' 
			' toolStripButton66
			' 
			Me.toolStripButton66.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton66.Image = (CType(resources.GetObject("toolStripButton66.Image"), System.Drawing.Image))
			Me.toolStripButton66.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton66.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton66.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton66.Name = "toolStripButton66"
			Me.toolStripButton66.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton66.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton66.Text = "&Open"
			' 
			' toolStripSeparator27
			' 
			Me.toolStripSeparator27.Name = "toolStripSeparator27"
			Me.toolStripSeparator27.Size = New System.Drawing.Size(105, 2)
			' 
			' toolStripButton67
			' 
			Me.toolStripButton67.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton67.Image = (CType(resources.GetObject("toolStripButton67.Image"), System.Drawing.Image))
			Me.toolStripButton67.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton67.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton67.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton67.Name = "toolStripButton67"
			Me.toolStripButton67.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton67.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton67.Text = "&Save"
			' 
			' officeSplitButton5
			' 
			Me.officeSplitButton5.AutoSize = False
			Me.officeSplitButton5.DropDownButtonWidth = 18
			Me.officeSplitButton5.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton5.DropDownText = "Save a copy of the document"
			Me.officeSplitButton5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton5.Image = (CType(resources.GetObject("officeSplitButton5.Image"), System.Drawing.Image))
			Me.officeSplitButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton5.Name = "officeSplitButton5"
			Me.officeSplitButton5.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton5.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton5.Text = "Save &As..."
			Me.officeSplitButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton44
			' 
			Me.officeButton44.AutoSize = False
			Me.officeButton44.AutoToolTip = False
			Me.officeButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton44.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton44.HelpText = "Save the workbook in default file format."
			Me.officeButton44.Image = (CType(resources.GetObject("officeButton44.Image"), System.Drawing.Image))
			Me.officeButton44.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton44.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton44.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton44.Name = "officeButton44"
			Me.officeButton44.Size = New System.Drawing.Size(263, 36)
			Me.officeButton44.Text = "E&xcel Workbook"
			Me.officeButton44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton45
			' 
			Me.officeButton45.AutoSize = False
			Me.officeButton45.AutoToolTip = False
			Me.officeButton45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton45.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton45.HelpText = "Save the document as a template that can " & Constants.vbCrLf & "be used to format future documents."
			Me.officeButton45.Image = (CType(resources.GetObject("officeButton45.Image"), System.Drawing.Image))
			Me.officeButton45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton45.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton45.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton45.Name = "officeButton45"
			Me.officeButton45.Size = New System.Drawing.Size(263, 45)
			Me.officeButton45.Text = "Excel &Macro-Enabled Workbook"
			Me.officeButton45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton46
			' 
			Me.officeButton46.AutoSize = False
			Me.officeButton46.AutoToolTip = False
			Me.officeButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton46.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton46.HelpText = "Save a copy of the document that is fully " & Constants.vbCrLf & "compatible with Word 97-2003."
			Me.officeButton46.Image = (CType(resources.GetObject("officeButton46.Image"), System.Drawing.Image))
			Me.officeButton46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton46.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton46.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton46.Name = "officeButton46"
			Me.officeButton46.Size = New System.Drawing.Size(263, 45)
			Me.officeButton46.Text = "Excel &97-2003 Workbook"
			Me.officeButton46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton47
			' 
			Me.officeButton47.AutoSize = False
			Me.officeButton47.AutoToolTip = False
			Me.officeButton47.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton47.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton47.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton47.Image = (CType(resources.GetObject("officeButton47.Image"), System.Drawing.Image))
			Me.officeButton47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton47.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton47.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton47.Name = "officeButton47"
			Me.officeButton47.Size = New System.Drawing.Size(263, 45)
			Me.officeButton47.Text = "&Find add-ins for other file formats"
			Me.officeButton47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton48
			' 
			Me.officeButton48.AutoSize = False
			Me.officeButton48.AutoToolTip = False
			Me.officeButton48.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton48.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton48.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton48.Image = (CType(resources.GetObject("officeButton48.Image"), System.Drawing.Image))
			Me.officeButton48.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton48.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton48.Name = "officeButton48"
			Me.officeButton48.Size = New System.Drawing.Size(263, 45)
			Me.officeButton48.Text = "&Other Formats"
			Me.officeButton48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripSeparator28
			' 
			Me.toolStripSeparator28.Name = "toolStripSeparator28"
			Me.toolStripSeparator28.Size = New System.Drawing.Size(105, 2)
			' 
			' officeSplitButton6
			' 
			Me.officeSplitButton6.DropDownButtonWidth = 18
			Me.officeSplitButton6.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton6.DropDownText = "Preview and print the document"
			Me.officeSplitButton6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton6.Image = (CType(resources.GetObject("officeSplitButton6.Image"), System.Drawing.Image))
			Me.officeSplitButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton6.Name = "officeSplitButton6"
			Me.officeSplitButton6.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton6.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton6.Text = "&Print"
			Me.officeSplitButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton49
			' 
			Me.officeButton49.AutoToolTip = False
			Me.officeButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton49.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton49.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton49.Image = (CType(resources.GetObject("officeButton49.Image"), System.Drawing.Image))
			Me.officeButton49.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton49.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton49.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton49.Name = "officeButton49"
			Me.officeButton49.Size = New System.Drawing.Size(118, 45)
			Me.officeButton49.Text = "&Print"
			Me.officeButton49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton50
			' 
			Me.officeButton50.AutoToolTip = False
			Me.officeButton50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton50.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton50.HelpText = "Send the document directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton50.Image = (CType(resources.GetObject("officeButton50.Image"), System.Drawing.Image))
			Me.officeButton50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton50.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton50.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton50.Name = "officeButton50"
			Me.officeButton50.Size = New System.Drawing.Size(118, 45)
			Me.officeButton50.Text = "&Quick Print"
			Me.officeButton50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton51
			' 
			Me.officeButton51.AutoToolTip = False
			Me.officeButton51.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton51.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton51.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton51.Image = (CType(resources.GetObject("officeButton51.Image"), System.Drawing.Image))
			Me.officeButton51.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton51.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton51.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton51.Name = "officeButton51"
			Me.officeButton51.Size = New System.Drawing.Size(118, 45)
			Me.officeButton51.Text = "Print Pre&view"
			Me.officeButton51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton8
			' 
			Me.officeDropDownButton8.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton8.DropDownText = "Prepare the document for distribution"
			Me.officeDropDownButton8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton8.Image = (CType(resources.GetObject("officeDropDownButton8.Image"), System.Drawing.Image))
			Me.officeDropDownButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton8.Name = "officeDropDownButton8"
			Me.officeDropDownButton8.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton8.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton8.Text = "Pr&epare"
			Me.officeDropDownButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton52
			' 
			Me.officeButton52.AutoToolTip = False
			Me.officeButton52.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton52.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton52.HelpText = "View and edit workbook properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton52.Image = (CType(resources.GetObject("officeButton52.Image"), System.Drawing.Image))
			Me.officeButton52.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton52.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton52.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton52.Name = "officeButton52"
			Me.officeButton52.Size = New System.Drawing.Size(192, 45)
			Me.officeButton52.Text = "Properties"
			Me.officeButton52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton53
			' 
			Me.officeButton53.AutoToolTip = False
			Me.officeButton53.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton53.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton53.HelpText = "Check the workbook for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton53.Image = (CType(resources.GetObject("officeButton53.Image"), System.Drawing.Image))
			Me.officeButton53.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton53.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton53.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton53.Name = "officeButton53"
			Me.officeButton53.Size = New System.Drawing.Size(192, 45)
			Me.officeButton53.Text = "Inspect document"
			Me.officeButton53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton54
			' 
			Me.officeButton54.AutoToolTip = False
			Me.officeButton54.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton54.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton54.HelpText = "Increase the security of the workbook by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton54.Image = (CType(resources.GetObject("officeButton54.Image"), System.Drawing.Image))
			Me.officeButton54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton54.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton54.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton54.Name = "officeButton54"
			Me.officeButton54.Size = New System.Drawing.Size(192, 45)
			Me.officeButton54.Text = "Encrypt Document"
			Me.officeButton54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton55
			' 
			Me.officeButton55.AutoToolTip = False
			Me.officeButton55.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton55.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton55.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton55.Image = (CType(resources.GetObject("officeButton55.Image"), System.Drawing.Image))
			Me.officeButton55.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton55.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton55.Name = "officeButton55"
			Me.officeButton55.Size = New System.Drawing.Size(192, 45)
			Me.officeButton55.Text = "Restrict Permission"
			Me.officeButton55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton56
			' 
			Me.officeButton56.AutoToolTip = False
			Me.officeButton56.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton56.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton56.HelpText = "Ensure the integrity of the workbook by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton56.Image = (CType(resources.GetObject("officeButton56.Image"), System.Drawing.Image))
			Me.officeButton56.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton56.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton56.Name = "officeButton56"
			Me.officeButton56.Size = New System.Drawing.Size(192, 45)
			Me.officeButton56.Text = "Add a Digital Signature"
			Me.officeButton56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton57
			' 
			Me.officeButton57.AutoToolTip = False
			Me.officeButton57.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton57.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton57.HelpText = "Let readers know the workbook is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton57.Image = (CType(resources.GetObject("officeButton57.Image"), System.Drawing.Image))
			Me.officeButton57.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton57.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton57.Name = "officeButton57"
			Me.officeButton57.Size = New System.Drawing.Size(192, 45)
			Me.officeButton57.Text = "Mark as Final"
			Me.officeButton57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton58
			' 
			Me.officeButton58.AutoToolTip = False
			Me.officeButton58.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton58.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton58.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Excel."
			Me.officeButton58.Image = (CType(resources.GetObject("officeButton58.Image"), System.Drawing.Image))
			Me.officeButton58.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton58.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton58.Name = "officeButton58"
			Me.officeButton58.Size = New System.Drawing.Size(192, 45)
			Me.officeButton58.Text = "Run Compatibility Checker"
			Me.officeButton58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton9
			' 
			Me.officeDropDownButton9.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton9.DropDownText = "Send a copy to other people"
			Me.officeDropDownButton9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton9.Image = (CType(resources.GetObject("officeDropDownButton9.Image"), System.Drawing.Image))
			Me.officeDropDownButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton9.Name = "officeDropDownButton9"
			Me.officeDropDownButton9.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton9.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton9.Text = "Sen&d"
			Me.officeDropDownButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton59
			' 
			Me.officeButton59.AutoToolTip = False
			Me.officeButton59.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton59.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton59.HelpText = "Send a copy of the workbook in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton59.Image = (CType(resources.GetObject("officeButton59.Image"), System.Drawing.Image))
			Me.officeButton59.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton59.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton59.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton59.Name = "officeButton59"
			Me.officeButton59.Size = New System.Drawing.Size(114, 45)
			Me.officeButton59.Text = "E-mail"
			Me.officeButton59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton60
			' 
			Me.officeButton60.AutoToolTip = False
			Me.officeButton60.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton60.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton60.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCr & "workbook."
			Me.officeButton60.Image = (CType(resources.GetObject("officeButton60.Image"), System.Drawing.Image))
			Me.officeButton60.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton60.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton60.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton60.Name = "officeButton60"
			Me.officeButton60.Size = New System.Drawing.Size(114, 45)
			Me.officeButton60.Text = "Internet Fax"
			Me.officeButton60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton7
			' 
			Me.officeDropDownButton7.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton7.DropDownText = "Distribute the document to other people"
			Me.officeDropDownButton7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton7.Image = (CType(resources.GetObject("officeDropDownButton7.Image"), System.Drawing.Image))
			Me.officeDropDownButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton7.Name = "officeDropDownButton7"
			Me.officeDropDownButton7.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton7.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton7.Text = "P&ublish"
			Me.officeDropDownButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton41
			' 
			Me.officeButton41.AutoToolTip = False
			Me.officeButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton41.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton41.HelpText = "Save for services, specify what is shown in the browser and set options"
			Me.officeButton41.Image = (CType(resources.GetObject("officeButton41.Image"), System.Drawing.Image))
			Me.officeButton41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton41.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton41.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton41.Name = "officeButton41"
			Me.officeButton41.Size = New System.Drawing.Size(220, 36)
			Me.officeButton41.Text = "Services"
			Me.officeButton41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton42
			' 
			Me.officeButton42.AutoToolTip = False
			Me.officeButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton42.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton42.HelpText = "Share the document by saving it to a " & Constants.vbCrLf & "document management server."
			Me.officeButton42.Image = (CType(resources.GetObject("officeButton42.Image"), System.Drawing.Image))
			Me.officeButton42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton42.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton42.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton42.Name = "officeButton42"
			Me.officeButton42.Size = New System.Drawing.Size(220, 45)
			Me.officeButton42.Text = "Document Management Server"
			Me.officeButton42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton43
			' 
			Me.officeButton43.AutoToolTip = False
			Me.officeButton43.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton43.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton43.HelpText = "Create a new site for the workbook and" & Constants.vbCrLf & "keep the local copy synchronized."
			Me.officeButton43.Image = (CType(resources.GetObject("officeButton43.Image"), System.Drawing.Image))
			Me.officeButton43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton43.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton43.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton43.Name = "officeButton43"
			Me.officeButton43.Size = New System.Drawing.Size(220, 45)
			Me.officeButton43.Text = "Create Document Workspace"
			Me.officeButton43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripSeparator29
			' 
			Me.toolStripSeparator29.Name = "toolStripSeparator29"
			Me.toolStripSeparator29.Size = New System.Drawing.Size(105, 2)
			' 
			' toolStripButton62
			' 
			Me.toolStripButton62.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton62.Image = (CType(resources.GetObject("toolStripButton62.Image"), System.Drawing.Image))
			Me.toolStripButton62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton62.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton62.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton62.Name = "toolStripButton62"
			Me.toolStripButton62.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton62.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton62.Text = "&Close"
			' 
			' toolStripMenuItem19
			' 
			Me.toolStripMenuItem19.Image = (CType(resources.GetObject("toolStripMenuItem19.Image"), System.Drawing.Image))
			Me.toolStripMenuItem19.Name = "toolStripMenuItem19"
			Me.toolStripMenuItem19.Size = New System.Drawing.Size(137, 22)
			Me.toolStripMenuItem19.Text = "Sort A-Z"
			' 
			' toolStripMenuItem20
			' 
			Me.toolStripMenuItem20.Image = (CType(resources.GetObject("toolStripMenuItem20.Image"), System.Drawing.Image))
			Me.toolStripMenuItem20.Name = "toolStripMenuItem20"
			Me.toolStripMenuItem20.Size = New System.Drawing.Size(137, 22)
			Me.toolStripMenuItem20.Text = "Sort Z-A"
			' 
			' toolStripMenuItem21
			' 
			Me.toolStripMenuItem21.Image = (CType(resources.GetObject("toolStripMenuItem21.Image"), System.Drawing.Image))
			Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
			Me.toolStripMenuItem21.Size = New System.Drawing.Size(137, 22)
			Me.toolStripMenuItem21.Text = "Custom sorts"
			' 
			' toolStripMenuItem22
			' 
			Me.toolStripMenuItem22.Image = (CType(resources.GetObject("toolStripMenuItem22.Image"), System.Drawing.Image))
			Me.toolStripMenuItem22.Name = "toolStripMenuItem22"
			Me.toolStripMenuItem22.Size = New System.Drawing.Size(137, 22)
			Me.toolStripMenuItem22.Text = "Filter"
			' 
			' officeDropDownButton10
			' 
			Me.officeDropDownButton10.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton61, Me.officeButton62, Me.officeButton63})
			Me.officeDropDownButton10.DropDownText = "Distribute the document to other people"
			Me.officeDropDownButton10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton10.Name = "officeDropDownButton10"
			Me.officeDropDownButton10.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton10.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton10.Text = "P&ublish"
			Me.officeDropDownButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton61
			' 
			Me.officeButton61.AutoToolTip = False
			Me.officeButton61.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton61.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton61.HelpText = "Create a new blog post with the contents of " & Constants.vbCrLf & "the document."
			Me.officeButton61.Image = (CType(resources.GetObject("officeButton61.Image"), System.Drawing.Image))
			Me.officeButton61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton61.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton61.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton61.Name = "officeButton61"
			Me.officeButton61.Size = New System.Drawing.Size(276, 51)
			Me.officeButton61.Text = "Blog"
			Me.officeButton61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton62
			' 
			Me.officeButton62.AutoToolTip = False
			Me.officeButton62.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton62.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton62.HelpText = "Share the document by saving it to a " & Constants.vbCrLf & "document management server."
			Me.officeButton62.Image = (CType(resources.GetObject("officeButton62.Image"), System.Drawing.Image))
			Me.officeButton62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton62.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton62.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton62.Name = "officeButton62"
			Me.officeButton62.Size = New System.Drawing.Size(276, 51)
			Me.officeButton62.Text = "Document Management Server"
			Me.officeButton62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton63
			' 
			Me.officeButton63.AutoToolTip = False
			Me.officeButton63.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton63.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton63.HelpText = "Create a new site for the document and" & Constants.vbCrLf & "keep the local copy synchronized."
			Me.officeButton63.Image = (CType(resources.GetObject("officeButton63.Image"), System.Drawing.Image))
			Me.officeButton63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton63.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton63.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton63.Name = "officeButton63"
			Me.officeButton63.Size = New System.Drawing.Size(276, 51)
			Me.officeButton63.Text = "Create Document Workspace"
			Me.officeButton63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton11
			' 
			Me.officeDropDownButton11.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton64, Me.officeButton65})
			Me.officeDropDownButton11.DropDownText = "Send a copy to other people"
			Me.officeDropDownButton11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton11.Image = (CType(resources.GetObject("officeDropDownButton11.Image"), System.Drawing.Image))
			Me.officeDropDownButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton11.Name = "officeDropDownButton11"
			Me.officeDropDownButton11.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton11.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton11.Text = "Sen&d"
			Me.officeDropDownButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton64
			' 
			Me.officeButton64.AutoToolTip = False
			Me.officeButton64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton64.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton64.HelpText = "Send a copy of the document in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton64.Image = (CType(resources.GetObject("officeButton64.Image"), System.Drawing.Image))
			Me.officeButton64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton64.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton64.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton64.Name = "officeButton64"
			Me.officeButton64.Size = New System.Drawing.Size(268, 51)
			Me.officeButton64.Text = "E-mail"
			Me.officeButton64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton65
			' 
			Me.officeButton65.AutoToolTip = False
			Me.officeButton65.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton65.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton65.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCrLf & "document."
			Me.officeButton65.Image = (CType(resources.GetObject("officeButton65.Image"), System.Drawing.Image))
			Me.officeButton65.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton65.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton65.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton65.Name = "officeButton65"
			Me.officeButton65.Size = New System.Drawing.Size(268, 51)
			Me.officeButton65.Text = "Internet Fax"
			Me.officeButton65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton80
			' 
			Me.toolStripButton80.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton80.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton80.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton80.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton80.Name = "toolStripButton80"
			Me.toolStripButton80.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton80.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton80.Text = "&Close"
			' 
			' toolStripButton90
			' 
			Me.toolStripButton90.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton90.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton90.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton90.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton90.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton90.Name = "toolStripButton90"
			Me.toolStripButton90.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton90.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton90.Text = "&New"
			' 
			' toolStripButton91
			' 
			Me.toolStripButton91.AutoSize = False
			Me.toolStripButton91.AutoToolTip = False
			Me.toolStripButton91.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton91.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton91.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton91.Name = "toolStripButton91"
			Me.toolStripButton91.Size = New System.Drawing.Size(265, 22)
			Me.toolStripButton91.Text = "&1 Document.doc"
			Me.toolStripButton91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton12
			' 
			Me.officeDropDownButton12.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton66, Me.officeButton67, Me.officeButton68, Me.officeButton69, Me.officeButton70, Me.officeButton71, Me.officeButton72})
			Me.officeDropDownButton12.DropDownText = "Prepare the document for distribution"
			Me.officeDropDownButton12.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton12.Name = "officeDropDownButton12"
			Me.officeDropDownButton12.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton12.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton12.Text = "Pr&epare"
			Me.officeDropDownButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton66
			' 
			Me.officeButton66.AutoToolTip = False
			Me.officeButton66.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton66.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton66.HelpText = "View and edit document properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton66.Image = (CType(resources.GetObject("officeButton66.Image"), System.Drawing.Image))
			Me.officeButton66.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton66.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton66.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton66.Name = "officeButton66"
			Me.officeButton66.Size = New System.Drawing.Size(273, 51)
			Me.officeButton66.Text = "Properties"
			Me.officeButton66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton67
			' 
			Me.officeButton67.AutoToolTip = False
			Me.officeButton67.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton67.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton67.HelpText = "Check the document for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton67.Image = (CType(resources.GetObject("officeButton67.Image"), System.Drawing.Image))
			Me.officeButton67.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton67.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton67.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton67.Name = "officeButton67"
			Me.officeButton67.Size = New System.Drawing.Size(273, 51)
			Me.officeButton67.Text = "Inspect document"
			Me.officeButton67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton68
			' 
			Me.officeButton68.AutoToolTip = False
			Me.officeButton68.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton68.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton68.HelpText = "Increase the security of the document by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton68.Image = (CType(resources.GetObject("officeButton68.Image"), System.Drawing.Image))
			Me.officeButton68.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton68.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton68.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton68.Name = "officeButton68"
			Me.officeButton68.Size = New System.Drawing.Size(273, 51)
			Me.officeButton68.Text = "Encrypt Document"
			Me.officeButton68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton69
			' 
			Me.officeButton69.AutoToolTip = False
			Me.officeButton69.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton69.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton69.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton69.Image = (CType(resources.GetObject("officeButton69.Image"), System.Drawing.Image))
			Me.officeButton69.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton69.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton69.Name = "officeButton69"
			Me.officeButton69.Size = New System.Drawing.Size(273, 51)
			Me.officeButton69.Text = "Restrict Permission"
			Me.officeButton69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton70
			' 
			Me.officeButton70.AutoToolTip = False
			Me.officeButton70.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton70.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton70.HelpText = "Ensure the integrity of the document by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton70.Image = (CType(resources.GetObject("officeButton70.Image"), System.Drawing.Image))
			Me.officeButton70.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton70.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton70.Name = "officeButton70"
			Me.officeButton70.Size = New System.Drawing.Size(273, 51)
			Me.officeButton70.Text = "Add a Digital Signature"
			Me.officeButton70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton71
			' 
			Me.officeButton71.AutoToolTip = False
			Me.officeButton71.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton71.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton71.HelpText = "Let readers know the document is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton71.Image = (CType(resources.GetObject("officeButton71.Image"), System.Drawing.Image))
			Me.officeButton71.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton71.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton71.Name = "officeButton71"
			Me.officeButton71.Size = New System.Drawing.Size(273, 51)
			Me.officeButton71.Text = "Mark as Final"
			Me.officeButton71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton72
			' 
			Me.officeButton72.AutoToolTip = False
			Me.officeButton72.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton72.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton72.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Word."
			Me.officeButton72.Image = (CType(resources.GetObject("officeButton72.Image"), System.Drawing.Image))
			Me.officeButton72.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton72.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton72.Name = "officeButton72"
			Me.officeButton72.Size = New System.Drawing.Size(273, 51)
			Me.officeButton72.Text = "Run Compatibility Checker"
			Me.officeButton72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton92
			' 
			Me.toolStripButton92.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton92.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton92.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton92.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton92.Name = "toolStripButton92"
			Me.toolStripButton92.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton92.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton92.Text = "&Open"
			' 
			' toolStripButton93
			' 
			Me.toolStripButton93.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton93.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton93.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton93.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton93.Name = "toolStripButton93"
			Me.toolStripButton93.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton93.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton93.Text = "&Save"
			' 
			' officeSplitButton7
			' 
			Me.officeSplitButton7.DropDownButtonWidth = 18
			Me.officeSplitButton7.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton73, Me.officeButton74, Me.officeButton75})
			Me.officeSplitButton7.DropDownText = "Preview and print the document"
			Me.officeSplitButton7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton7.Name = "officeSplitButton7"
			Me.officeSplitButton7.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton7.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton7.Text = "&Print"
			Me.officeSplitButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton73
			' 
			Me.officeButton73.AutoToolTip = False
			Me.officeButton73.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton73.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton73.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton73.Image = (CType(resources.GetObject("officeButton73.Image"), System.Drawing.Image))
			Me.officeButton73.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton73.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton73.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton73.Name = "officeButton73"
			Me.officeButton73.Size = New System.Drawing.Size(274, 51)
			Me.officeButton73.Text = "&Print"
			Me.officeButton73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton74
			' 
			Me.officeButton74.AutoToolTip = False
			Me.officeButton74.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton74.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton74.HelpText = "Send the document directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton74.Image = (CType(resources.GetObject("officeButton74.Image"), System.Drawing.Image))
			Me.officeButton74.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton74.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton74.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton74.Name = "officeButton74"
			Me.officeButton74.Size = New System.Drawing.Size(274, 51)
			Me.officeButton74.Text = "&Quick Print"
			Me.officeButton74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton75
			' 
			Me.officeButton75.AutoToolTip = False
			Me.officeButton75.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton75.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton75.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton75.Image = (CType(resources.GetObject("officeButton75.Image"), System.Drawing.Image))
			Me.officeButton75.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton75.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton75.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton75.Name = "officeButton75"
			Me.officeButton75.Size = New System.Drawing.Size(274, 51)
			Me.officeButton75.Text = "Print Pre&view"
			Me.officeButton75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeSplitButton8
			' 
			Me.officeSplitButton8.AutoSize = False
			Me.officeSplitButton8.DropDownButtonWidth = 18
			Me.officeSplitButton8.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton76, Me.officeButton77, Me.officeButton78, Me.officeButton79, Me.officeButton80})
			Me.officeSplitButton8.DropDownText = "Save a copy of the document"
			Me.officeSplitButton8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton8.Image = (CType(resources.GetObject("officeSplitButton8.Image"), System.Drawing.Image))
			Me.officeSplitButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton8.Name = "officeSplitButton8"
			Me.officeSplitButton8.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton8.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton8.Text = "Save &As..."
			Me.officeSplitButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton76
			' 
			Me.officeButton76.AutoSize = False
			Me.officeButton76.AutoToolTip = False
			Me.officeButton76.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton76.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton76.HelpText = "Save the document in default file format."
			Me.officeButton76.Image = (CType(resources.GetObject("officeButton76.Image"), System.Drawing.Image))
			Me.officeButton76.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton76.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton76.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton76.Name = "officeButton76"
			Me.officeButton76.Size = New System.Drawing.Size(263, 36)
			Me.officeButton76.Text = "&Word Document"
			Me.officeButton76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton77
			' 
			Me.officeButton77.AutoSize = False
			Me.officeButton77.AutoToolTip = False
			Me.officeButton77.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton77.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton77.HelpText = "Save the document as a template that can " & Constants.vbCrLf & "be used to format future documents."
			Me.officeButton77.Image = (CType(resources.GetObject("officeButton77.Image"), System.Drawing.Image))
			Me.officeButton77.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton77.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton77.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton77.Name = "officeButton77"
			Me.officeButton77.Size = New System.Drawing.Size(263, 45)
			Me.officeButton77.Text = "Word &Template"
			Me.officeButton77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton78
			' 
			Me.officeButton78.AutoSize = False
			Me.officeButton78.AutoToolTip = False
			Me.officeButton78.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton78.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton78.HelpText = "Save a copy of the document that is fully " & Constants.vbCrLf & "compatible with Word 97-2003."
			Me.officeButton78.Image = (CType(resources.GetObject("officeButton78.Image"), System.Drawing.Image))
			Me.officeButton78.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton78.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton78.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton78.Name = "officeButton78"
			Me.officeButton78.Size = New System.Drawing.Size(263, 45)
			Me.officeButton78.Text = "Word &97-2003 Document"
			Me.officeButton78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton79
			' 
			Me.officeButton79.AutoSize = False
			Me.officeButton79.AutoToolTip = False
			Me.officeButton79.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton79.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton79.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton79.Image = (CType(resources.GetObject("officeButton79.Image"), System.Drawing.Image))
			Me.officeButton79.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton79.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton79.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton79.Name = "officeButton79"
			Me.officeButton79.Size = New System.Drawing.Size(263, 45)
			Me.officeButton79.Text = "&Find add-ins for other file formats"
			Me.officeButton79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton80
			' 
			Me.officeButton80.AutoSize = False
			Me.officeButton80.AutoToolTip = False
			Me.officeButton80.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton80.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton80.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton80.Image = (CType(resources.GetObject("officeButton80.Image"), System.Drawing.Image))
			Me.officeButton80.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton80.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton80.Name = "officeButton80"
			Me.officeButton80.Size = New System.Drawing.Size(263, 45)
			Me.officeButton80.Text = "&Other Formats"
			Me.officeButton80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton13
			' 
			Me.officeDropDownButton13.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton81, Me.officeButton82, Me.officeButton83})
			Me.officeDropDownButton13.DropDownText = "Distribute the document to other people"
			Me.officeDropDownButton13.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton13.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton13.Name = "officeDropDownButton13"
			Me.officeDropDownButton13.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton13.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton13.Text = "P&ublish"
			Me.officeDropDownButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton81
			' 
			Me.officeButton81.AutoToolTip = False
			Me.officeButton81.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton81.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton81.HelpText = "Create a new blog post with the contents of " & Constants.vbCrLf & "the document."
			Me.officeButton81.Image = (CType(resources.GetObject("officeButton81.Image"), System.Drawing.Image))
			Me.officeButton81.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton81.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton81.Name = "officeButton81"
			Me.officeButton81.Size = New System.Drawing.Size(276, 51)
			Me.officeButton81.Text = "Blog"
			Me.officeButton81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton82
			' 
			Me.officeButton82.AutoToolTip = False
			Me.officeButton82.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton82.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton82.HelpText = "Share the document by saving it to a " & Constants.vbCrLf & "document management server."
			Me.officeButton82.Image = (CType(resources.GetObject("officeButton82.Image"), System.Drawing.Image))
			Me.officeButton82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton82.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton82.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton82.Name = "officeButton82"
			Me.officeButton82.Size = New System.Drawing.Size(276, 51)
			Me.officeButton82.Text = "Document Management Server"
			Me.officeButton82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton83
			' 
			Me.officeButton83.AutoToolTip = False
			Me.officeButton83.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton83.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton83.HelpText = "Create a new site for the document and" & Constants.vbCrLf & "keep the local copy synchronized."
			Me.officeButton83.Image = (CType(resources.GetObject("officeButton83.Image"), System.Drawing.Image))
			Me.officeButton83.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton83.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton83.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton83.Name = "officeButton83"
			Me.officeButton83.Size = New System.Drawing.Size(276, 51)
			Me.officeButton83.Text = "Create Document Workspace"
			Me.officeButton83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton14
			' 
			Me.officeDropDownButton14.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton84, Me.officeButton85})
			Me.officeDropDownButton14.DropDownText = "Send a copy to other people"
			Me.officeDropDownButton14.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton14.Image = (CType(resources.GetObject("officeDropDownButton14.Image"), System.Drawing.Image))
			Me.officeDropDownButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton14.Name = "officeDropDownButton14"
			Me.officeDropDownButton14.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton14.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton14.Text = "Sen&d"
			Me.officeDropDownButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton84
			' 
			Me.officeButton84.AutoToolTip = False
			Me.officeButton84.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton84.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton84.HelpText = "Send a copy of the document in an e-mail " & Constants.vbCrLf & "message as an attachment."
			Me.officeButton84.Image = (CType(resources.GetObject("officeButton84.Image"), System.Drawing.Image))
			Me.officeButton84.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton84.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton84.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton84.Name = "officeButton84"
			Me.officeButton84.Size = New System.Drawing.Size(268, 51)
			Me.officeButton84.Text = "E-mail"
			Me.officeButton84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton85
			' 
			Me.officeButton85.AutoToolTip = False
			Me.officeButton85.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton85.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton85.HelpText = "Use an Internet Fax service to fax the " & Constants.vbCrLf & "document."
			Me.officeButton85.Image = (CType(resources.GetObject("officeButton85.Image"), System.Drawing.Image))
			Me.officeButton85.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton85.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton85.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton85.Name = "officeButton85"
			Me.officeButton85.Size = New System.Drawing.Size(268, 51)
			Me.officeButton85.Text = "Internet Fax"
			Me.officeButton85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton94
			' 
			Me.toolStripButton94.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton94.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton94.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton94.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton94.Name = "toolStripButton94"
			Me.toolStripButton94.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton94.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton94.Text = "&Close"
			' 
			' toolStripButton95
			' 
			Me.toolStripButton95.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton95.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton95.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton95.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton95.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton95.Name = "toolStripButton95"
			Me.toolStripButton95.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton95.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton95.Text = "&New"
			' 
			' toolStripButton96
			' 
			Me.toolStripButton96.AutoSize = False
			Me.toolStripButton96.AutoToolTip = False
			Me.toolStripButton96.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton96.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton96.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton96.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton96.Name = "toolStripButton96"
			Me.toolStripButton96.Size = New System.Drawing.Size(265, 22)
			Me.toolStripButton96.Text = "&1 Document.doc"
			Me.toolStripButton96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeDropDownButton15
			' 
			Me.officeDropDownButton15.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeDropDownButton15.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton86, Me.officeButton87, Me.officeButton88, Me.officeButton89, Me.officeButton90, Me.officeButton91, Me.officeButton92})
			Me.officeDropDownButton15.DropDownText = "Prepare the document for distribution"
			Me.officeDropDownButton15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeDropDownButton15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeDropDownButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeDropDownButton15.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeDropDownButton15.Name = "officeDropDownButton15"
			Me.officeDropDownButton15.Padding = New System.Windows.Forms.Padding(4)
			Me.officeDropDownButton15.Size = New System.Drawing.Size(121, 44)
			Me.officeDropDownButton15.Text = "Pr&epare"
			Me.officeDropDownButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton86
			' 
			Me.officeButton86.AutoToolTip = False
			Me.officeButton86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton86.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton86.HelpText = "View and edit document properties, such " & Constants.vbCrLf & "as Title Author and keywords."
			Me.officeButton86.Image = (CType(resources.GetObject("officeButton86.Image"), System.Drawing.Image))
			Me.officeButton86.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton86.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton86.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton86.Name = "officeButton86"
			Me.officeButton86.Size = New System.Drawing.Size(273, 51)
			Me.officeButton86.Text = "Properties"
			Me.officeButton86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton87
			' 
			Me.officeButton87.AutoToolTip = False
			Me.officeButton87.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton87.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton87.HelpText = "Check the document for hidden metadate " & Constants.vbCrLf & "or personal information."
			Me.officeButton87.Image = (CType(resources.GetObject("officeButton87.Image"), System.Drawing.Image))
			Me.officeButton87.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton87.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton87.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton87.Name = "officeButton87"
			Me.officeButton87.Size = New System.Drawing.Size(273, 51)
			Me.officeButton87.Text = "Inspect document"
			Me.officeButton87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton88
			' 
			Me.officeButton88.AutoToolTip = False
			Me.officeButton88.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton88.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton88.HelpText = "Increase the security of the document by " & Constants.vbCrLf & "adding encryption."
			Me.officeButton88.Image = (CType(resources.GetObject("officeButton88.Image"), System.Drawing.Image))
			Me.officeButton88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton88.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton88.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton88.Name = "officeButton88"
			Me.officeButton88.Size = New System.Drawing.Size(273, 51)
			Me.officeButton88.Text = "Encrypt Document"
			Me.officeButton88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton89
			' 
			Me.officeButton89.AutoToolTip = False
			Me.officeButton89.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton89.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton89.HelpText = "Grant people access while restricting their" & Constants.vbCrLf & "adbility to edit, copy and print."
			Me.officeButton89.Image = (CType(resources.GetObject("officeButton89.Image"), System.Drawing.Image))
			Me.officeButton89.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton89.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton89.Name = "officeButton89"
			Me.officeButton89.Size = New System.Drawing.Size(273, 51)
			Me.officeButton89.Text = "Restrict Permission"
			Me.officeButton89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton90
			' 
			Me.officeButton90.AutoToolTip = False
			Me.officeButton90.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton90.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton90.HelpText = "Ensure the integrity of the document by " & Constants.vbCrLf & "adding an invisible digital signature."
			Me.officeButton90.Image = (CType(resources.GetObject("officeButton90.Image"), System.Drawing.Image))
			Me.officeButton90.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton90.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton90.Name = "officeButton90"
			Me.officeButton90.Size = New System.Drawing.Size(273, 51)
			Me.officeButton90.Text = "Add a Digital Signature"
			Me.officeButton90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton91
			' 
			Me.officeButton91.AutoToolTip = False
			Me.officeButton91.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton91.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton91.HelpText = "Let readers know the document is final and " & Constants.vbCrLf & "make it read-only."
			Me.officeButton91.Image = (CType(resources.GetObject("officeButton91.Image"), System.Drawing.Image))
			Me.officeButton91.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton91.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton91.Name = "officeButton91"
			Me.officeButton91.Size = New System.Drawing.Size(273, 51)
			Me.officeButton91.Text = "Mark as Final"
			Me.officeButton91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton92
			' 
			Me.officeButton92.AutoToolTip = False
			Me.officeButton92.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton92.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton92.HelpText = "Check for features not supported by earlier " & Constants.vbCrLf & "versions of Word."
			Me.officeButton92.Image = (CType(resources.GetObject("officeButton92.Image"), System.Drawing.Image))
			Me.officeButton92.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton92.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton92.Name = "officeButton92"
			Me.officeButton92.Size = New System.Drawing.Size(273, 51)
			Me.officeButton92.Text = "Run Compatibility Checker"
			Me.officeButton92.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton97
			' 
			Me.toolStripButton97.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton97.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton97.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton97.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton97.Name = "toolStripButton97"
			Me.toolStripButton97.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton97.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton97.Text = "&Open"
			' 
			' toolStripButton98
			' 
			Me.toolStripButton98.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripButton98.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.toolStripButton98.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton98.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton98.Name = "toolStripButton98"
			Me.toolStripButton98.Padding = New System.Windows.Forms.Padding(4)
			Me.toolStripButton98.Size = New System.Drawing.Size(121, 44)
			Me.toolStripButton98.Text = "&Save"
			' 
			' officeSplitButton9
			' 
			Me.officeSplitButton9.DropDownButtonWidth = 18
			Me.officeSplitButton9.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton93, Me.officeButton94, Me.officeButton95})
			Me.officeSplitButton9.DropDownText = "Preview and print the document"
			Me.officeSplitButton9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton9.Name = "officeSplitButton9"
			Me.officeSplitButton9.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton9.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton9.Text = "&Print"
			Me.officeSplitButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton93
			' 
			Me.officeButton93.AutoToolTip = False
			Me.officeButton93.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton93.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton93.HelpText = "Select a printer, number of copies and " & Constants.vbCrLf & "other printing options before printing."
			Me.officeButton93.Image = (CType(resources.GetObject("officeButton93.Image"), System.Drawing.Image))
			Me.officeButton93.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton93.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton93.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton93.Name = "officeButton93"
			Me.officeButton93.Size = New System.Drawing.Size(274, 51)
			Me.officeButton93.Text = "&Print"
			Me.officeButton93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton94
			' 
			Me.officeButton94.AutoToolTip = False
			Me.officeButton94.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton94.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton94.HelpText = "Send the document directly to the default " & Constants.vbCrLf & "printer without making changes"
			Me.officeButton94.Image = (CType(resources.GetObject("officeButton94.Image"), System.Drawing.Image))
			Me.officeButton94.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton94.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton94.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton94.Name = "officeButton94"
			Me.officeButton94.Size = New System.Drawing.Size(274, 51)
			Me.officeButton94.Text = "&Quick Print"
			Me.officeButton94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton95
			' 
			Me.officeButton95.AutoToolTip = False
			Me.officeButton95.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton95.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton95.HelpText = "Preview and make changes to pages before " & Constants.vbCrLf & "printing."
			Me.officeButton95.Image = (CType(resources.GetObject("officeButton95.Image"), System.Drawing.Image))
			Me.officeButton95.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton95.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton95.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton95.Name = "officeButton95"
			Me.officeButton95.Size = New System.Drawing.Size(274, 51)
			Me.officeButton95.Text = "Print Pre&view"
			Me.officeButton95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeSplitButton10
			' 
			Me.officeSplitButton10.AutoSize = False
			Me.officeSplitButton10.DropDownButtonWidth = 18
			Me.officeSplitButton10.DropDownFont = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.officeSplitButton10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeButton96, Me.officeButton97, Me.officeButton98, Me.officeButton99, Me.officeButton100})
			Me.officeSplitButton10.DropDownText = "Save a copy of the document"
			Me.officeSplitButton10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeSplitButton10.Image = (CType(resources.GetObject("officeSplitButton10.Image"), System.Drawing.Image))
			Me.officeSplitButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeSplitButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeSplitButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeSplitButton10.Name = "officeSplitButton10"
			Me.officeSplitButton10.Padding = New System.Windows.Forms.Padding(4)
			Me.officeSplitButton10.Size = New System.Drawing.Size(121, 36)
			Me.officeSplitButton10.Text = "Save &As..."
			Me.officeSplitButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton96
			' 
			Me.officeButton96.AutoSize = False
			Me.officeButton96.AutoToolTip = False
			Me.officeButton96.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton96.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton96.HelpText = "Save the document in default file format."
			Me.officeButton96.Image = (CType(resources.GetObject("officeButton96.Image"), System.Drawing.Image))
			Me.officeButton96.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton96.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton96.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton96.Name = "officeButton96"
			Me.officeButton96.Size = New System.Drawing.Size(263, 36)
			Me.officeButton96.Text = "&Word Document"
			Me.officeButton96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton97
			' 
			Me.officeButton97.AutoSize = False
			Me.officeButton97.AutoToolTip = False
			Me.officeButton97.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton97.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton97.HelpText = "Save the document as a template that can " & Constants.vbCrLf & "be used to format future documents."
			Me.officeButton97.Image = (CType(resources.GetObject("officeButton97.Image"), System.Drawing.Image))
			Me.officeButton97.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton97.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton97.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton97.Name = "officeButton97"
			Me.officeButton97.Size = New System.Drawing.Size(263, 45)
			Me.officeButton97.Text = "Word &Template"
			Me.officeButton97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton98
			' 
			Me.officeButton98.AutoSize = False
			Me.officeButton98.AutoToolTip = False
			Me.officeButton98.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton98.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton98.HelpText = "Save a copy of the document that is fully " & Constants.vbCrLf & "compatible with Word 97-2003."
			Me.officeButton98.Image = (CType(resources.GetObject("officeButton98.Image"), System.Drawing.Image))
			Me.officeButton98.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton98.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton98.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton98.Name = "officeButton98"
			Me.officeButton98.Size = New System.Drawing.Size(263, 45)
			Me.officeButton98.Text = "Word &97-2003 Document"
			Me.officeButton98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton99
			' 
			Me.officeButton99.AutoSize = False
			Me.officeButton99.AutoToolTip = False
			Me.officeButton99.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton99.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton99.HelpText = "Learn about add-ins to save to other " & Constants.vbCrLf & "formats such as PDF or XPS."
			Me.officeButton99.Image = (CType(resources.GetObject("officeButton99.Image"), System.Drawing.Image))
			Me.officeButton99.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton99.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton99.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton99.Name = "officeButton99"
			Me.officeButton99.Size = New System.Drawing.Size(263, 45)
			Me.officeButton99.Text = "&Find add-ins for other file formats"
			Me.officeButton99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' officeButton100
			' 
			Me.officeButton100.AutoSize = False
			Me.officeButton100.AutoToolTip = False
			Me.officeButton100.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
			Me.officeButton100.ForeColor = System.Drawing.Color.MidnightBlue
			Me.officeButton100.HelpText = "Open the Save as dialog box to select from " & Constants.vbCrLf & "all possible file types."
			Me.officeButton100.Image = (CType(resources.GetObject("officeButton100.Image"), System.Drawing.Image))
			Me.officeButton100.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton100.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton100.Name = "officeButton100"
			Me.officeButton100.Size = New System.Drawing.Size(263, 45)
			Me.officeButton100.Text = "&Other Formats"
			Me.officeButton100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' statusStripEx1
			' 
			Me.statusStripEx1.AllowItemReorder = True
			Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripStatusLabel3, Me.trackBarItem2})
			Me.statusStripEx1.Location = New System.Drawing.Point(6, 651)
			Me.statusStripEx1.Name = "statusStripEx1"
			Me.statusStripEx1.Size = New System.Drawing.Size(853, 26)
			Me.statusStripEx1.TabIndex = 10
			Me.statusStripEx1.Text = "statusStripEx1"
			' 
			' toolStripStatusLabel1
			' 
			Me.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripStatusLabel1.Image = (CType(resources.GetObject("toolStripStatusLabel1.Image"), System.Drawing.Image))
			Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
			Me.toolStripStatusLabel1.Size = New System.Drawing.Size(16, 16)
			Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
			Me.toolStripStatusLabel1.ToolTipText = "Normal"
			' 
			' toolStripStatusLabel2
			' 
			Me.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripStatusLabel2.Image = (CType(resources.GetObject("toolStripStatusLabel2.Image"), System.Drawing.Image))
			Me.toolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
			Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
			Me.toolStripStatusLabel2.Size = New System.Drawing.Size(23, 20)
			Me.toolStripStatusLabel2.Text = "toolStripStatusLabel2"
			Me.toolStripStatusLabel2.ToolTipText = "Page Layout"
			' 
			' toolStripStatusLabel3
			' 
			Me.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripStatusLabel3.Image = (CType(resources.GetObject("toolStripStatusLabel3.Image"), System.Drawing.Image))
			Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
			Me.toolStripStatusLabel3.Size = New System.Drawing.Size(16, 16)
			Me.toolStripStatusLabel3.Text = "toolStripStatusLabel3"
			Me.toolStripStatusLabel3.ToolTipText = "Page Break preview"
			' 
			' trackBarItem2
			' 
			Me.trackBarItem2.Maximum = 10
			Me.trackBarItem2.Name = "trackBarItem2"
			Me.trackBarItem2.Size = New System.Drawing.Size(250, 20)
			Me.trackBarItem2.Text = "trackBarItem2"
			Me.trackBarItem2.Value = 5
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "saveHS.png")
			Me.imageList1.Images.SetKeyName(1, "Edit_UndoHS.png")
			Me.imageList1.Images.SetKeyName(2, "Edit_RedoHS.png")
			' 
			' tabBarSplitterControl1
			' 
			Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.tabBarSplitterControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
			Me.tabBarSplitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
			Me.tabBarSplitterControl1.Location = New System.Drawing.Point(7, 176)
			Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.Office2007ScrollBars = True
			Me.tabBarSplitterControl1.Size = New System.Drawing.Size(853, 474)
			Me.tabBarSplitterControl1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007
			Me.tabBarSplitterControl1.TabFolderDelta = 11
			Me.tabBarSplitterControl1.TabIndex = 11
			Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
			' 
			' toolStripComboBox2
			' 
			Me.toolStripComboBox2.Items.AddRange(New Object() { "Pixel Scroll", "Scroll Tabs"})
			Me.toolStripComboBox2.Name = "toolStripComboBox2"
			Me.toolStripComboBox2.Size = New System.Drawing.Size(121, 23)
			Me.toolStripComboBox2.Text = "Pixel Scroll"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Borders = New System.Windows.Forms.Padding(6, 1, 6, 2)
			Me.ClientSize = New System.Drawing.Size(867, 679)
			Me.Controls.Add(Me.tabBarSplitterControl1)
			Me.Controls.Add(Me.statusStripEx1)
			Me.Controls.Add(Me.ribbonControlAdv1)
			Me.HelpButtonImage = (CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image))
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(1)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TabBarSplitter Demo"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ribbonControlAdv1.ResumeLayout(False)
			Me.ribbonControlAdv1.PerformLayout()
			Me.toolStripTabItem1.Panel.ResumeLayout(False)
			Me.toolStripTabItem1.Panel.PerformLayout()
			Me.clipboardToolStripExt.ResumeLayout(False)
			Me.clipboardToolStripExt.PerformLayout()
			Me.stylesToolStripExt.ResumeLayout(False)
			Me.stylesToolStripExt.PerformLayout()
			Me.paragraphToolStripExt.ResumeLayout(False)
			Me.paragraphToolStripExt.PerformLayout()
			Me.statusStripEx1.ResumeLayout(False)
			Me.statusStripEx1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private clipboardToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem15 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private stylesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private paragraphToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		'private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx toolStripSplitButtonEx1;
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private SapleBarIte As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripButton18 As System.Windows.Forms.ToolStripButton
		Private officeSplitButton1 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton1 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton2 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton3 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton4 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton5 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeSplitButton2 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton6 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton7 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton8 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton1 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton9 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton10 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton11 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton12 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton13 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton14 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton15 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton3 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton16 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton17 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton4 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton18 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton19 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton20 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private officeSplitButton3 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton21 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton22 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton23 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton24 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton25 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private officeSplitButton4 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton26 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton27 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton28 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton2 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton29 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton30 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton31 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton32 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton33 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton34 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton35 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton5 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton36 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton37 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton6 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton38 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton39 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton40 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton8 As System.Windows.Forms.ToolStripButton
		Private toolStripButton64 As System.Windows.Forms.ToolStripButton
		Private superAccelerator1 As Syncfusion.Windows.Forms.Tools.SuperAccelerator
		Private toolStripButton69 As System.Windows.Forms.ToolStripButton
		Private toolStripButton70 As System.Windows.Forms.ToolStripButton
		Private toolStripSplitButtonEx2 As Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx
		Private toolStripButton73 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem8 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private deindentToolStripBtn As System.Windows.Forms.ToolStripButton
		Private inindentToolStripBtn As System.Windows.Forms.ToolStripButton
		Private toolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton65 As System.Windows.Forms.ToolStripButton
		Private toolStripButton66 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton67 As System.Windows.Forms.ToolStripButton
		Private officeSplitButton5 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton44 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton45 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton46 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton47 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton48 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
		Private officeSplitButton6 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton49 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton50 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton51 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton8 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton52 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton53 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton54 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton55 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton56 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton57 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton58 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton9 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton59 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton60 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton7 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton41 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton42 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton43 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton62 As System.Windows.Forms.ToolStripButton
		Private mergeCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergeAcrossToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergeCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private unmergeCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton82 As System.Windows.Forms.ToolStripButton
		Private toolStripButton83 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton89 As System.Windows.Forms.ToolStripButton
		Private officeDropDownButton10 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton61 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton62 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton63 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton11 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton64 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton65 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton80 As System.Windows.Forms.ToolStripButton
		Private toolStripButton90 As System.Windows.Forms.ToolStripButton
		Private toolStripButton91 As System.Windows.Forms.ToolStripButton
		Private officeDropDownButton12 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton66 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton67 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton68 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton69 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton70 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton71 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton72 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton92 As System.Windows.Forms.ToolStripButton
		Private toolStripButton93 As System.Windows.Forms.ToolStripButton
		Private officeSplitButton7 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton73 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton74 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton75 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeSplitButton8 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton76 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton77 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton78 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton79 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton80 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton13 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton81 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton82 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton83 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeDropDownButton14 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton84 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton85 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton94 As System.Windows.Forms.ToolStripButton
		Private toolStripButton95 As System.Windows.Forms.ToolStripButton
		Private toolStripButton96 As System.Windows.Forms.ToolStripButton
		Private officeDropDownButton15 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton86 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton87 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton88 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton89 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton90 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton91 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton92 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton97 As System.Windows.Forms.ToolStripButton
		Private toolStripButton98 As System.Windows.Forms.ToolStripButton
		Private officeSplitButton9 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton93 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton94 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton95 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeSplitButton10 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeButton96 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton97 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton98 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton99 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton100 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private toolStripButton81 As System.Windows.Forms.ToolStripButton
		Private officeDropDownButton18 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeDropDownButton19 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeSplitButton11 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeSplitButton12 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeDropDownButton20 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeButton101 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton102 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton103 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton104 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton105 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton106 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton107 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton108 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton109 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton110 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton111 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton112 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton113 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton114 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton115 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton116 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton117 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton118 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton119 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton120 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private officeButton121 As Syncfusion.Windows.Forms.Tools.OfficeButton
		Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
		Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
		Private toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
		Private trackBarItem2 As Syncfusion.Windows.Forms.Tools.TrackBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private toolStripButton84 As System.Windows.Forms.ToolStripButton
		Private toolStripButton85 As System.Windows.Forms.ToolStripButton
		Private toolStripButton86 As System.Windows.Forms.ToolStripButton
		Private toolStripStatusLabel2 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
		Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
		Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
		Private WithEvents toolStripCheckBox1 As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
		Private WithEvents toolStripCheckBox2 As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
		Private toolStripComboBox2 As System.Windows.Forms.ToolStripComboBox


	End Class
End Namespace

