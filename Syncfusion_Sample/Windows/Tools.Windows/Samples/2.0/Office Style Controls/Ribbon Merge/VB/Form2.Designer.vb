#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace RibbonControlMerging
	Partial Public Class Form2
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
			Me.ribbonPanelMergeContainer1 = New Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.ribbonPanelMergeContainer2 = New Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer()
			Me.toolStripEx11 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem28 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem29 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton25 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.sumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.countNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.minToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.maxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton26 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.sUMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.mINToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.mAXToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.hYPERLINKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton27 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dISCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton28 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.aNDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.oRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.nOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.fALSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tRUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton29 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.cHARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cLEANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cONCATENATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton30 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dATEVALUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.eDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton31 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.aREASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aDDRESSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cHOOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cOLUMNSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton32 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.aBSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aSINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aCOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton33 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.statisticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.engineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.informationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx12 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem30 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem31 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton34 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.defineNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.applyNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton35 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.ribbonPanelMergeContainer1.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.ribbonPanelMergeContainer2.SuspendLayout()
			Me.toolStripEx11.SuspendLayout()
			Me.toolStripEx12.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonPanelMergeContainer1
			' 
			Me.ribbonPanelMergeContainer1.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center
			Me.ribbonPanelMergeContainer1.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain
			Me.ribbonPanelMergeContainer1.Controls.Add(Me.toolStripEx1)
			Me.ribbonPanelMergeContainer1.Location = New System.Drawing.Point(5, 118)
			Me.ribbonPanelMergeContainer1.Name = "ribbonPanelMergeContainer1"
			Me.ribbonPanelMergeContainer1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
			Me.ribbonPanelMergeContainer1.ScrollPosition = 0
			Me.ribbonPanelMergeContainer1.Size = New System.Drawing.Size(186, 103)
			Me.ribbonPanelMergeContainer1.TabIndex = 0
            Me.ribbonPanelMergeContainer1.Text = "Format"
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.AutoSize = False
			Me.toolStripEx1.CollapsedDropDownButtonText = "Cells"
			Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = (CType(resources.GetObject("toolStripEx1.Image"), System.Drawing.Image))
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripButton2, Me.toolStripButton3})
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx1.ShowItemToolTips = False
			Me.toolStripEx1.Size = New System.Drawing.Size(178, 98)
			Me.toolStripEx1.TabIndex = 16
			Me.toolStripEx1.Text = "Styles"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.Font = New System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(66, 67)
			Me.toolStripButton1.Text = "Conditional" & Constants.vbCrLf & "Formatting"
			Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.Font = New System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(50, 67)
			Me.toolStripButton2.Text = "Format" & Constants.vbCrLf & "as Table"
			Me.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Font = New System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(39, 67)
			Me.toolStripButton3.Text = "Cell" & Constants.vbCrLf & "Styles"
			Me.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' ribbonPanelMergeContainer2
			' 
			Me.ribbonPanelMergeContainer2.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center
			Me.ribbonPanelMergeContainer2.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain
			Me.ribbonPanelMergeContainer2.Controls.Add(Me.toolStripEx11)
			Me.ribbonPanelMergeContainer2.Controls.Add(Me.toolStripEx12)
			Me.ribbonPanelMergeContainer2.Location = New System.Drawing.Point(7, 9)
			Me.ribbonPanelMergeContainer2.Name = "ribbonPanelMergeContainer2"
			Me.ribbonPanelMergeContainer2.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
			Me.ribbonPanelMergeContainer2.ScrollPosition = 0
			Me.ribbonPanelMergeContainer2.Size = New System.Drawing.Size(519, 103)
			Me.ribbonPanelMergeContainer2.TabIndex = 1
			Me.ribbonPanelMergeContainer2.Text = "Formulas"
			' 
			' toolStripEx11
			' 
			Me.toolStripEx11.AutoSize = False
			Me.toolStripEx11.CollapsedDropDownButtonText = "Functions"
			Me.toolStripEx11.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx11.Image = (CType(resources.GetObject("toolStripEx11.Image"), System.Drawing.Image))
			Me.toolStripEx11.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem28, Me.toolStripPanelItem29})
			Me.toolStripEx11.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx11.Name = "toolStripEx11"
			Me.toolStripEx11.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx11.ShowItemToolTips = False
			Me.toolStripEx11.Size = New System.Drawing.Size(323, 98)
			Me.toolStripEx11.TabIndex = 1
			Me.toolStripEx11.Text = "Function Library"
			' 
			' toolStripPanelItem28
			' 
			Me.toolStripPanelItem28.CausesValidation = False
			Me.toolStripPanelItem28.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem28.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton13})
			Me.toolStripPanelItem28.Name = "toolStripPanelItem28"
			Me.toolStripPanelItem28.Size = New System.Drawing.Size(52, 70)
			Me.toolStripPanelItem28.Text = "toolStripPanelItem28"
			Me.toolStripPanelItem28.Transparent = True
			' 
			' toolStripButton13
			' 
			Me.toolStripButton13.AutoSize = False
			Me.toolStripButton13.Image = (CType(resources.GetObject("toolStripButton13.Image"), System.Drawing.Image))
			Me.toolStripButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton13.Name = "toolStripButton13"
			Me.toolStripButton13.Size = New System.Drawing.Size(48, 75)
			Me.toolStripButton13.Text = "Insert" & Constants.vbCrLf & "Function"
			Me.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem29
			' 
			Me.toolStripPanelItem29.CausesValidation = False
			Me.toolStripPanelItem29.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem29.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton25, Me.toolStripDropDownButton26, Me.toolStripDropDownButton27, Me.toolStripDropDownButton28, Me.toolStripDropDownButton29, Me.toolStripDropDownButton30, Me.toolStripDropDownButton31, Me.toolStripDropDownButton32, Me.toolStripDropDownButton33})
			Me.toolStripPanelItem29.Name = "toolStripPanelItem29"
			Me.toolStripPanelItem29.Padding = New System.Windows.Forms.Padding(0)
			Me.toolStripPanelItem29.ShowItemToolTips = False
			Me.toolStripPanelItem29.Size = New System.Drawing.Size(218, 70)
			Me.toolStripPanelItem29.Text = "toolStripPanelItem29"
			Me.toolStripPanelItem29.Transparent = True
			' 
			' toolStripDropDownButton25
			' 
			Me.toolStripDropDownButton25.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.sumToolStripMenuItem, Me.countNumbersToolStripMenuItem, Me.minToolStripMenuItem, Me.maxToolStripMenuItem})
			Me.toolStripDropDownButton25.Image = (CType(resources.GetObject("toolStripDropDownButton25.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton25.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton25.Name = "toolStripDropDownButton25"
			Me.toolStripDropDownButton25.Size = New System.Drawing.Size(79, 20)
			Me.toolStripDropDownButton25.Text = "AutoSum"
			' 
			' sumToolStripMenuItem
			' 
			Me.sumToolStripMenuItem.Name = "sumToolStripMenuItem"
			Me.sumToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
			Me.sumToolStripMenuItem.Text = "Sum"
			' 
			' countNumbersToolStripMenuItem
			' 
			Me.countNumbersToolStripMenuItem.Name = "countNumbersToolStripMenuItem"
			Me.countNumbersToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
			Me.countNumbersToolStripMenuItem.Text = "Count Numbers.."
			' 
			' minToolStripMenuItem
			' 
			Me.minToolStripMenuItem.Name = "minToolStripMenuItem"
			Me.minToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
			Me.minToolStripMenuItem.Text = "Min"
			' 
			' maxToolStripMenuItem
			' 
			Me.maxToolStripMenuItem.Name = "maxToolStripMenuItem"
			Me.maxToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
			Me.maxToolStripMenuItem.Text = "Max"
			' 
			' toolStripDropDownButton26
			' 
			Me.toolStripDropDownButton26.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.sUMToolStripMenuItem1, Me.mINToolStripMenuItem1, Me.mAXToolStripMenuItem1, Me.hYPERLINKToolStripMenuItem})
			Me.toolStripDropDownButton26.Image = (CType(resources.GetObject("toolStripDropDownButton26.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton26.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton26.Name = "toolStripDropDownButton26"
			Me.toolStripDropDownButton26.Size = New System.Drawing.Size(105, 20)
			Me.toolStripDropDownButton26.Text = "Recently Used"
			' 
			' sUMToolStripMenuItem1
			' 
			Me.sUMToolStripMenuItem1.Name = "sUMToolStripMenuItem1"
			Me.sUMToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
			Me.sUMToolStripMenuItem1.Text = "SUM"
			' 
			' mINToolStripMenuItem1
			' 
			Me.mINToolStripMenuItem1.Name = "mINToolStripMenuItem1"
			Me.mINToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
			Me.mINToolStripMenuItem1.Text = "MIN"
			' 
			' mAXToolStripMenuItem1
			' 
			Me.mAXToolStripMenuItem1.Name = "mAXToolStripMenuItem1"
			Me.mAXToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
			Me.mAXToolStripMenuItem1.Text = "MAX"
			' 
			' hYPERLINKToolStripMenuItem
			' 
			Me.hYPERLINKToolStripMenuItem.Name = "hYPERLINKToolStripMenuItem"
			Me.hYPERLINKToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
			Me.hYPERLINKToolStripMenuItem.Text = "HYPERLINK"
			' 
			' toolStripDropDownButton27
			' 
			Me.toolStripDropDownButton27.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dBToolStripMenuItem, Me.dDBToolStripMenuItem, Me.dISCToolStripMenuItem})
			Me.toolStripDropDownButton27.Image = (CType(resources.GetObject("toolStripDropDownButton27.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton27.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton27.Name = "toolStripDropDownButton27"
			Me.toolStripDropDownButton27.Size = New System.Drawing.Size(77, 20)
			Me.toolStripDropDownButton27.Text = "Financial"
			' 
			' dBToolStripMenuItem
			' 
			Me.dBToolStripMenuItem.Name = "dBToolStripMenuItem"
			Me.dBToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
			Me.dBToolStripMenuItem.Text = "DB"
			' 
			' dDBToolStripMenuItem
			' 
			Me.dDBToolStripMenuItem.Name = "dDBToolStripMenuItem"
			Me.dDBToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
			Me.dDBToolStripMenuItem.Text = "DDB"
			' 
			' dISCToolStripMenuItem
			' 
			Me.dISCToolStripMenuItem.Name = "dISCToolStripMenuItem"
			Me.dISCToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
			Me.dISCToolStripMenuItem.Text = "DISC"
			' 
			' toolStripDropDownButton28
			' 
			Me.toolStripDropDownButton28.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.aNDToolStripMenuItem, Me.oRToolStripMenuItem, Me.nOTToolStripMenuItem, Me.fALSEToolStripMenuItem, Me.tRUEToolStripMenuItem})
			Me.toolStripDropDownButton28.Image = (CType(resources.GetObject("toolStripDropDownButton28.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton28.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton28.Name = "toolStripDropDownButton28"
			Me.toolStripDropDownButton28.Size = New System.Drawing.Size(68, 20)
			Me.toolStripDropDownButton28.Text = "Logical"
			' 
			' aNDToolStripMenuItem
			' 
			Me.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem"
			Me.aNDToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.aNDToolStripMenuItem.Text = "AND"
			' 
			' oRToolStripMenuItem
			' 
			Me.oRToolStripMenuItem.Name = "oRToolStripMenuItem"
			Me.oRToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.oRToolStripMenuItem.Text = "OR"
			' 
			' nOTToolStripMenuItem
			' 
			Me.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem"
			Me.nOTToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.nOTToolStripMenuItem.Text = "NOT"
			' 
			' fALSEToolStripMenuItem
			' 
			Me.fALSEToolStripMenuItem.Name = "fALSEToolStripMenuItem"
			Me.fALSEToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.fALSEToolStripMenuItem.Text = "FALSE"
			' 
			' tRUEToolStripMenuItem
			' 
			Me.tRUEToolStripMenuItem.Name = "tRUEToolStripMenuItem"
			Me.tRUEToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.tRUEToolStripMenuItem.Text = "TRUE"
			' 
			' toolStripDropDownButton29
			' 
			Me.toolStripDropDownButton29.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.cHARToolStripMenuItem, Me.cLEANToolStripMenuItem, Me.cODEToolStripMenuItem, Me.cONCATENATEToolStripMenuItem})
			Me.toolStripDropDownButton29.Image = (CType(resources.GetObject("toolStripDropDownButton29.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton29.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton29.Name = "toolStripDropDownButton29"
			Me.toolStripDropDownButton29.Size = New System.Drawing.Size(58, 20)
			Me.toolStripDropDownButton29.Text = "Text"
			' 
			' cHARToolStripMenuItem
			' 
			Me.cHARToolStripMenuItem.Name = "cHARToolStripMenuItem"
			Me.cHARToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
			Me.cHARToolStripMenuItem.Text = "CHAR"
			' 
			' cLEANToolStripMenuItem
			' 
			Me.cLEANToolStripMenuItem.Name = "cLEANToolStripMenuItem"
			Me.cLEANToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
			Me.cLEANToolStripMenuItem.Text = "CLEAN"
			' 
			' cODEToolStripMenuItem
			' 
			Me.cODEToolStripMenuItem.Name = "cODEToolStripMenuItem"
			Me.cODEToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
			Me.cODEToolStripMenuItem.Text = "CODE"
			' 
			' cONCATENATEToolStripMenuItem
			' 
			Me.cONCATENATEToolStripMenuItem.Name = "cONCATENATEToolStripMenuItem"
			Me.cONCATENATEToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
			Me.cONCATENATEToolStripMenuItem.Text = "CONCATENATE"
			' 
			' toolStripDropDownButton30
			' 
			Me.toolStripDropDownButton30.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dATEToolStripMenuItem, Me.dATEVALUEToolStripMenuItem, Me.eDATEToolStripMenuItem, Me.dAYToolStripMenuItem})
			Me.toolStripDropDownButton30.Image = (CType(resources.GetObject("toolStripDropDownButton30.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton30.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton30.Name = "toolStripDropDownButton30"
			Me.toolStripDropDownButton30.Size = New System.Drawing.Size(84, 20)
			Me.toolStripDropDownButton30.Text = "Date Time"
			' 
			' dATEToolStripMenuItem
			' 
			Me.dATEToolStripMenuItem.Name = "dATEToolStripMenuItem"
			Me.dATEToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
			Me.dATEToolStripMenuItem.Text = "DATE"
			' 
			' dATEVALUEToolStripMenuItem
			' 
			Me.dATEVALUEToolStripMenuItem.Name = "dATEVALUEToolStripMenuItem"
			Me.dATEVALUEToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
			Me.dATEVALUEToolStripMenuItem.Text = "DATEVALUE"
			' 
			' eDATEToolStripMenuItem
			' 
			Me.eDATEToolStripMenuItem.Name = "eDATEToolStripMenuItem"
			Me.eDATEToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
			Me.eDATEToolStripMenuItem.Text = "EDATE"
			' 
			' dAYToolStripMenuItem
			' 
			Me.dAYToolStripMenuItem.Name = "dAYToolStripMenuItem"
			Me.dAYToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
			Me.dAYToolStripMenuItem.Text = "DAY"
			' 
			' toolStripDropDownButton31
			' 
			Me.toolStripDropDownButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton31.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.aREASToolStripMenuItem, Me.aDDRESSToolStripMenuItem, Me.cHOOSEToolStripMenuItem, Me.cOLUMNSToolStripMenuItem})
			Me.toolStripDropDownButton31.Image = (CType(resources.GetObject("toolStripDropDownButton31.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton31.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton31.Name = "toolStripDropDownButton31"
			Me.toolStripDropDownButton31.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton31.Text = "AREAS"
			Me.toolStripDropDownButton31.ToolTipText = "Lookup Functions"
			' 
			' aREASToolStripMenuItem
			' 
			Me.aREASToolStripMenuItem.Name = "aREASToolStripMenuItem"
			Me.aREASToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
			Me.aREASToolStripMenuItem.Text = "AREAS"
			' 
			' aDDRESSToolStripMenuItem
			' 
			Me.aDDRESSToolStripMenuItem.Name = "aDDRESSToolStripMenuItem"
			Me.aDDRESSToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
			Me.aDDRESSToolStripMenuItem.Text = "ADDRESS"
			' 
			' cHOOSEToolStripMenuItem
			' 
			Me.cHOOSEToolStripMenuItem.Name = "cHOOSEToolStripMenuItem"
			Me.cHOOSEToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
			Me.cHOOSEToolStripMenuItem.Text = "CHOOSE"
			' 
			' cOLUMNSToolStripMenuItem
			' 
			Me.cOLUMNSToolStripMenuItem.Name = "cOLUMNSToolStripMenuItem"
			Me.cOLUMNSToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
			Me.cOLUMNSToolStripMenuItem.Text = "COLUMNS"
			' 
			' toolStripDropDownButton32
			' 
			Me.toolStripDropDownButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton32.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.aBSToolStripMenuItem, Me.aSINToolStripMenuItem, Me.aCOSToolStripMenuItem, Me.tANToolStripMenuItem})
			Me.toolStripDropDownButton32.Image = (CType(resources.GetObject("toolStripDropDownButton32.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton32.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton32.Name = "toolStripDropDownButton32"
			Me.toolStripDropDownButton32.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton32.Text = "ABS"
			Me.toolStripDropDownButton32.ToolTipText = "Math & trig"
			' 
			' aBSToolStripMenuItem
			' 
			Me.aBSToolStripMenuItem.Name = "aBSToolStripMenuItem"
			Me.aBSToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
			Me.aBSToolStripMenuItem.Text = "ABS"
			' 
			' aSINToolStripMenuItem
			' 
			Me.aSINToolStripMenuItem.Name = "aSINToolStripMenuItem"
			Me.aSINToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
			Me.aSINToolStripMenuItem.Text = "ASIN"
			' 
			' aCOSToolStripMenuItem
			' 
			Me.aCOSToolStripMenuItem.Name = "aCOSToolStripMenuItem"
			Me.aCOSToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
			Me.aCOSToolStripMenuItem.Text = "ACOS"
			' 
			' tANToolStripMenuItem
			' 
			Me.tANToolStripMenuItem.Name = "tANToolStripMenuItem"
			Me.tANToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
			Me.tANToolStripMenuItem.Text = "TAN"
			' 
			' toolStripDropDownButton33
			' 
			Me.toolStripDropDownButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton33.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.statisticalToolStripMenuItem, Me.engineeringToolStripMenuItem, Me.cubeToolStripMenuItem, Me.informationToolStripMenuItem})
			Me.toolStripDropDownButton33.Image = (CType(resources.GetObject("toolStripDropDownButton33.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton33.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton33.Name = "toolStripDropDownButton33"
			Me.toolStripDropDownButton33.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton33.Text = "toolStripDropDownButton33"
			Me.toolStripDropDownButton33.ToolTipText = "More Functions"
			' 
			' statisticalToolStripMenuItem
			' 
			Me.statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem"
			Me.statisticalToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.statisticalToolStripMenuItem.Text = "Statistical"
			' 
			' engineeringToolStripMenuItem
			' 
			Me.engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem"
			Me.engineeringToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.engineeringToolStripMenuItem.Text = "Engineering"
			' 
			' cubeToolStripMenuItem
			' 
			Me.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem"
			Me.cubeToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.cubeToolStripMenuItem.Text = "Cube"
			' 
			' informationToolStripMenuItem
			' 
			Me.informationToolStripMenuItem.Name = "informationToolStripMenuItem"
			Me.informationToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.informationToolStripMenuItem.Text = "Information"
			' 
			' toolStripEx12
			' 
			Me.toolStripEx12.AutoSize = False
			Me.toolStripEx12.CollapsedDropDownButtonText = "Names"
			Me.toolStripEx12.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx12.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx12.Image = (CType(resources.GetObject("toolStripEx12.Image"), System.Drawing.Image))
			Me.toolStripEx12.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem30, Me.toolStripPanelItem31})
			Me.toolStripEx12.Location = New System.Drawing.Point(293, 1)
			Me.toolStripEx12.Name = "toolStripEx12"
			Me.toolStripEx12.ShowItemToolTips = False
			Me.toolStripEx12.Size = New System.Drawing.Size(221, 98)
			Me.toolStripEx12.TabIndex = 2
			Me.toolStripEx12.Text = "Defined Names"
			' 
			' toolStripPanelItem30
			' 
			Me.toolStripPanelItem30.CausesValidation = False
			Me.toolStripPanelItem30.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem30.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton14})
			Me.toolStripPanelItem30.Name = "toolStripPanelItem30"
			Me.toolStripPanelItem30.ShowItemToolTips = False
			Me.toolStripPanelItem30.Size = New System.Drawing.Size(57, 80)
			Me.toolStripPanelItem30.Text = "toolStripPanelItem30"
			Me.toolStripPanelItem30.Transparent = True
			' 
			' toolStripButton14
			' 
			Me.toolStripButton14.AutoSize = False
			Me.toolStripButton14.Image = (CType(resources.GetObject("toolStripButton14.Image"), System.Drawing.Image))
			Me.toolStripButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton14.Name = "toolStripButton14"
			Me.toolStripButton14.Size = New System.Drawing.Size(53, 72)
			Me.toolStripButton14.Text = "Name" & Constants.vbCrLf & "Manager"
			Me.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem31
			' 
			Me.toolStripPanelItem31.CausesValidation = False
			Me.toolStripPanelItem31.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem31.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton34, Me.toolStripDropDownButton35, Me.toolStripButton15})
			Me.toolStripPanelItem31.Name = "toolStripPanelItem31"
			Me.toolStripPanelItem31.ShowItemToolTips = False
			Me.toolStripPanelItem31.Size = New System.Drawing.Size(135, 80)
			Me.toolStripPanelItem31.Text = "toolStripPanelItem31"
			Me.toolStripPanelItem31.Transparent = True
			' 
			' toolStripDropDownButton34
			' 
			Me.toolStripDropDownButton34.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.defineNamesToolStripMenuItem, Me.applyNamesToolStripMenuItem})
			Me.toolStripDropDownButton34.Image = (CType(resources.GetObject("toolStripDropDownButton34.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton34.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton34.Name = "toolStripDropDownButton34"
			Me.toolStripDropDownButton34.Size = New System.Drawing.Size(97, 20)
			Me.toolStripDropDownButton34.Text = "Define Name"
			' 
			' defineNamesToolStripMenuItem
			' 
			Me.defineNamesToolStripMenuItem.Name = "defineNamesToolStripMenuItem"
			Me.defineNamesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
			Me.defineNamesToolStripMenuItem.Text = "&Define Names"
			' 
			' applyNamesToolStripMenuItem
			' 
			Me.applyNamesToolStripMenuItem.Name = "applyNamesToolStripMenuItem"
			Me.applyNamesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
			Me.applyNamesToolStripMenuItem.Text = "&Apply Names"
			' 
			' toolStripDropDownButton35
			' 
			Me.toolStripDropDownButton35.Enabled = False
			Me.toolStripDropDownButton35.Image = (CType(resources.GetObject("toolStripDropDownButton35.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton35.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton35.Name = "toolStripDropDownButton35"
			Me.toolStripDropDownButton35.Size = New System.Drawing.Size(106, 20)
			Me.toolStripDropDownButton35.Text = "Use in Formula"
			' 
			' toolStripButton15
			' 
			Me.toolStripButton15.Image = (CType(resources.GetObject("toolStripButton15.Image"), System.Drawing.Image))
			Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton15.Name = "toolStripButton15"
			Me.toolStripButton15.Size = New System.Drawing.Size(131, 20)
			Me.toolStripButton15.Text = "Create from Selection"
			' 
			' gridControl1
			' 
			Me.gridControl1.ColCount = 25
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridControl1.Location = New System.Drawing.Point(189, 136)
			Me.gridControl1.Name = "gridControl1"
			'Me.gridControl1.Office2007ScrollBars = True
			Me.gridControl1.RowCount = 25
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(321, 189)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(495, 337)
			Me.Controls.Add(Me.ribbonPanelMergeContainer1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.ribbonPanelMergeContainer2)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form2"
			Me.Text = "Book 1"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			Me.ribbonPanelMergeContainer1.ResumeLayout(False)
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.ribbonPanelMergeContainer2.ResumeLayout(False)
			Me.toolStripEx11.ResumeLayout(False)
			Me.toolStripEx11.PerformLayout()
			Me.toolStripEx12.ResumeLayout(False)
			Me.toolStripEx12.PerformLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonPanelMergeContainer1 As Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer
		Private ribbonPanelMergeContainer2 As Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripEx11 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem28 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton13 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem29 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton25 As System.Windows.Forms.ToolStripDropDownButton
		Private sumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private countNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private minToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private maxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton26 As System.Windows.Forms.ToolStripDropDownButton
		Private sUMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private mINToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private mAXToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private hYPERLINKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton27 As System.Windows.Forms.ToolStripDropDownButton
		Private dBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dISCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton28 As System.Windows.Forms.ToolStripDropDownButton
		Private aNDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private oRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private nOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fALSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tRUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton29 As System.Windows.Forms.ToolStripDropDownButton
		Private cHARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cLEANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cODEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cONCATENATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton30 As System.Windows.Forms.ToolStripDropDownButton
		Private dATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dATEVALUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private eDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton31 As System.Windows.Forms.ToolStripDropDownButton
		Private aREASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aDDRESSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cHOOSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cOLUMNSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton32 As System.Windows.Forms.ToolStripDropDownButton
		Private aBSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aSINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aCOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton33 As System.Windows.Forms.ToolStripDropDownButton
		Private statisticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private engineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private informationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private toolStripEx12 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem30 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem31 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton34 As System.Windows.Forms.ToolStripDropDownButton
		Private defineNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private applyNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton35 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton15 As System.Windows.Forms.ToolStripButton
	End Class
End Namespace