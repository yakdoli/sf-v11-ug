Imports Microsoft.VisualBasic
Imports System
Namespace ExcelLikeUI_2005
	Public Partial Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim toolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo11 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo12 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo13 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo14 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo15 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo16 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo17 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo18 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo19 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo20 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo21 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo22 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo23 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo24 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo25 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo26 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo27 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo28 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo29 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo30 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo31 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo32 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo33 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo34 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo5 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo6 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo7 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo8 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo9 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Dim toolTipInfo10 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
			Me.excelRibbon = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
			Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.clipboardToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripBtnPaste = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownBtnPaste = New System.Windows.Forms.ToolStripDropDownButton()
			Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteAsHyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripBtnCut = New System.Windows.Forms.ToolStripButton()
			Me.toolStripBtnCopy = New System.Windows.Forms.ToolStripButton()
			Me.toolStripBtnPaint = New System.Windows.Forms.ToolStripButton()
			Me.fontToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripFontfaceComboBox = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripFontSizeComboBox = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.boldToolstripBtn = New System.Windows.Forms.ToolStripButton()
			Me.italicToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.underlineToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.moreUnderlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.underlineColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.automaticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.moreColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton71 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton74 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton50 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
			Me.noBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton78 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton79 = New System.Windows.Forms.ToolStripButton()
			Me.paragraphToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem54 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton59 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton60 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton61 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripLabel19 = New System.Windows.Forms.ToolStripButton()
			Me.centerToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.lAlignToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.rAlignToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSplitButtonEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx()
			Me.mergeCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergeAcrossToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergeCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.unmergeCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem8 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.deindentToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.inindentToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton73 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.General_toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripPanelItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem9 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton63 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton68 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripPanelItem10 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem52 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem11 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton5 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem12 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem13 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton6 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem46 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem47 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton8 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem48 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem49 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem50 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem51 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem17 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton9 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem18 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton10 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem53 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem54 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem55 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem56 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx28 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton51 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton72 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem19 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton75 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton11 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.recentlyUsedShapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.linesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.rectanglesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.basicShapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton76 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton77 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx6 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton12 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.coneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cylinderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pyramidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem20 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton13 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dLineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton14 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dPieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton15 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dBarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton16 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.dAreaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton17 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.otherScatterTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton18 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.stockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.surfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.doughnutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.bubbleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx8 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem21 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton19 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.horizontalTextBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.verticalTextBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton20 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripDropDownButton21 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.microsoftSignatureLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.stampSignatureLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
			Me.tablesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.tableToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.insertTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.drawTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.convertTextToTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.excelSpreadsheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.quickTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveSelectionToQuickTablToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.themesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.themesToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.resetToThemeFromTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.searchOfficeOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.browseForThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveCurrentThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem22 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.themeColorToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.createNewThemeColorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.themeFontToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.createNewThemeFontsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.themeEffectsToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.officeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.apexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pageSetupToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.marginToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.customMarginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.wideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.narrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.customMarginsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem44 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.orientationToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.portraitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.landscapeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.sizeToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.morePaperSizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.columnsToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.moreColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem23 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.breaksToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.inToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.removePageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.lnumbersToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.noneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.continuousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.restartEachPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.restartEachSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.suppressForCurrentSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
			Me.moreLineNumberingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.hyphenationToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.noneToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.automaticToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.manualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
			Me.hyphenationOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem24 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem14 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripLabel20 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripPanelItem16 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripLabel21 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripPanelItem25 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripEx9 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem26 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripPanelItem27 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripEx10 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton24 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem57 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem58 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem59 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripTabItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
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
			Me.toolStripEx13 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem32 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton36 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.traceDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.traceDependentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.removeArrowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton37 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.calculateNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.calculateSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripTabItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx14 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem33 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton38 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.fromAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.fromWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.fromTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.fromOtherSourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx15 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem34 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton39 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.refreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.refreshAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.refreshStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cancelRefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem35 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton16 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton17 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx16 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem36 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem55 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem56 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton87 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton88 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem57 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton99 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton22 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem37 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton23 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton24 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton25 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx17 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem38 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton26 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem39 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton27 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem40 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton40 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.dataValidationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.circleInvalidDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.clearValidationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton28 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton41 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.scenarioManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.goalSeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem61 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx18 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem41 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripDropDownButton42 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.groupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.autoOutlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripDropDownButton43 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.ungroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.clearOutlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton29 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripLabel26 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripTabItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx19 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton30 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem42 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton31 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton32 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton33 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx20 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem43 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton34 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem45 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton35 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton36 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton37 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton38 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton39 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton40 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx21 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem46 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton41 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton44 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.restrictEditingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.restrictPermissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton42 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton43 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton44 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton45 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.highlightChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripTabItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx22 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem47 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton45 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem48 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton46 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem49 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton47 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton48 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton49 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx23 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton46 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem60 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem62 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem63 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem64 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx24 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton50 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton51 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem50 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton52 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx25 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem51 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton53 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton54 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton48 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.freezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.freezeTopRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.freezeFirstColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripButton19 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton20 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton21 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripPanelItem52 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton55 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton56 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton57 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripPanelItem53 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton58 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownButton49 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.book1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripEx26 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton47 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.viewMacrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.recordMacrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
			Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
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
			Me.scrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
			Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.toolStripStatusLabel2 = New Syncfusion.Windows.Forms.Tools.StatusStripButton()
			Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.trackBarItem2 = New Syncfusion.Windows.Forms.Tools.TrackBarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
			Me.gridAwareTextBoxItem1 = New ExcelLikeUI_2005.GridAwareTextBoxBarItem()
			Me.gridAwareTextBoxItem2 = New ExcelLikeUI_2005.GridAwareTextBoxBarItem()
			CType(Me.excelRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.excelRibbon.SuspendLayout()
			Me.toolStripTabItem1.Panel.SuspendLayout()
			Me.clipboardToolStripExt.SuspendLayout()
			Me.fontToolStripExt.SuspendLayout()
			Me.paragraphToolStripExt.SuspendLayout()
			Me.toolStripEx3.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.toolStripEx2.SuspendLayout()
			Me.toolStripTabItem2.Panel.SuspendLayout()
			Me.toolStripEx28.SuspendLayout()
			Me.toolStripEx5.SuspendLayout()
			Me.toolStripEx7.SuspendLayout()
			Me.toolStripEx6.SuspendLayout()
			Me.toolStripEx8.SuspendLayout()
			Me.tablesToolStripExt.SuspendLayout()
			Me.toolStripTabItem3.Panel.SuspendLayout()
			Me.themesToolStripExt.SuspendLayout()
			Me.pageSetupToolStripExt.SuspendLayout()
			Me.toolStripEx4.SuspendLayout()
			Me.toolStripEx9.SuspendLayout()
			Me.toolStripEx10.SuspendLayout()
			Me.toolStripTabItem4.Panel.SuspendLayout()
			Me.toolStripEx11.SuspendLayout()
			Me.toolStripEx12.SuspendLayout()
			Me.toolStripEx13.SuspendLayout()
			Me.toolStripTabItem5.Panel.SuspendLayout()
			Me.toolStripEx14.SuspendLayout()
			Me.toolStripEx15.SuspendLayout()
			Me.toolStripEx16.SuspendLayout()
			Me.toolStripEx17.SuspendLayout()
			Me.toolStripEx18.SuspendLayout()
			Me.toolStripTabItem6.Panel.SuspendLayout()
			Me.toolStripEx19.SuspendLayout()
			Me.toolStripEx20.SuspendLayout()
			Me.toolStripEx21.SuspendLayout()
			Me.toolStripTabItem7.Panel.SuspendLayout()
			Me.toolStripEx22.SuspendLayout()
			Me.toolStripEx23.SuspendLayout()
			Me.toolStripEx24.SuspendLayout()
			Me.toolStripEx25.SuspendLayout()
			Me.toolStripEx26.SuspendLayout()
			Me.statusStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' excelRibbon
			' 
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem1)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem2)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem3)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem4)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem5)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem6)
			Me.excelRibbon.Header.AddMainItem(toolStripTabItem7)
			Me.excelRibbon.Location = New System.Drawing.Point(1, 0)
			Me.excelRibbon.MenuButtonImage = (CType(resources.GetObject("excelRibbon.MenuButtonImage"), System.Drawing.Image))
			toolTipInfo1.BackColor = System.Drawing.SystemColors.ButtonFace
			toolTipInfo1.Body.Text = "This will list all the common" & Constants.vbCrLf & "items used."
			toolTipInfo1.Body.TextMargin = New System.Windows.Forms.Padding(5)
			toolTipInfo1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			toolTipInfo1.Header.Text = "Office Menu"
			Me.superToolTip1.SetMenuButtonToolTip(Me.excelRibbon, toolTipInfo1)
			Me.excelRibbon.Name = "excelRibbon"
			' 
			' excelRibbon.OfficeMenu
			' 
			Me.excelRibbon.OfficeMenu.AutoSize = False
			Me.excelRibbon.OfficeMenu.AuxPanel.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.excelRibbon.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton84, Me.toolStripButton85, Me.toolStripButton86})
			Me.excelRibbon.OfficeMenu.AuxPanel.SeparatorIndent = 16
			Me.excelRibbon.OfficeMenu.AuxPanel.Text = "Recent Documents"
			Me.excelRibbon.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton81, Me.toolStripButton82, Me.toolStripButton83, Me.officeSplitButton11, Me.toolStripSeparator8, Me.officeSplitButton12, Me.officeDropDownButton18, Me.officeDropDownButton19, Me.officeDropDownButton20, Me.toolStripSeparator9, Me.toolStripButton89})
			Me.excelRibbon.OfficeMenu.Name = "OfficeMenu"
			Me.excelRibbon.OfficeMenu.Size = New System.Drawing.Size(400, 420)
			Me.excelRibbon.OfficeMenu.SystemPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton6, Me.toolStripButton4})
			Me.excelRibbon.Size = New System.Drawing.Size(865, 169)
			Me.excelRibbon.TabIndex = 0
			Me.excelRibbon.Text = "ribbonControlAdv1"
			Me.excelRibbon.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
			Me.excelRibbon.UpdateUIOnAppIdle = True
'			Me.excelRibbon.MenuButtonDoubleClick += New System.EventHandler(Me.excelRibbon_MenuButtonDoubleClick);
			' 
			' toolStripTabItem1
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem1, "H")
			Me.toolStripTabItem1.Name = "toolStripTabItem1"
			Me.toolStripTabItem1.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' excelRibbon.ribbonPanel1
			' 
			Me.toolStripTabItem1.Panel.Controls.Add(Me.clipboardToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.fontToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.paragraphToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx3)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx1)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx2)
			Me.toolStripTabItem1.Panel.Name = "ribbonPanel1"
			Me.toolStripTabItem1.Panel.ScrollPosition = 0
			Me.toolStripTabItem1.Panel.TabIndex = 2
			Me.toolStripTabItem1.Panel.TabItem = Me.toolStripTabItem1
			Me.toolStripTabItem1.Panel.Text = "Home"
			Me.toolStripTabItem1.Size = New System.Drawing.Size(48, 24)
			Me.toolStripTabItem1.Text = "Home"
			' 
			' clipboardToolStripExt
			' 
			Me.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard"
			Me.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.clipboardToolStripExt.Image = (CType(resources.GetObject("clipboardToolStripExt.Image"), System.Drawing.Image))
			Me.clipboardToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem15, Me.toolStripPanelItem1})
			Me.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.clipboardToolStripExt.Location = New System.Drawing.Point(0, 1)
			Me.clipboardToolStripExt.Name = "clipboardToolStripExt"
			Me.clipboardToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.clipboardToolStripExt.ShowItemToolTips = False
			Me.clipboardToolStripExt.Size = New System.Drawing.Size(93, 106)
			Me.clipboardToolStripExt.TabIndex = 5
			Me.clipboardToolStripExt.Text = "Clipboard"
			' 
			' toolStripPanelItem15
			' 
			Me.toolStripPanelItem15.CausesValidation = False
			Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem15.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripBtnPaste, Me.toolStripDropDownBtnPaste})
			Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
			Me.toolStripPanelItem15.ShowItemToolTips = False
			Me.toolStripPanelItem15.Size = New System.Drawing.Size(42, 78)
			Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
			Me.toolStripPanelItem15.Transparent = True
			' 
			' toolStripBtnPaste
			' 
			Me.toolStripBtnPaste.AutoToolTip = False
			Me.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnPaste.Image = (CType(resources.GetObject("toolStripBtnPaste.Image"), System.Drawing.Image))
			Me.toolStripBtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnPaste.Name = "toolStripBtnPaste"
			Me.toolStripBtnPaste.Size = New System.Drawing.Size(36, 36)
			Me.toolStripBtnPaste.Text = "Paste"
			toolTipInfo11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo11.Header.Text = "Paste"
			Me.superToolTip1.SetToolTip(Me.toolStripBtnPaste, toolTipInfo11)
			Me.toolStripBtnPaste.ToolTipText = "Paste"
			' 
			' toolStripDropDownBtnPaste
			' 
			Me.toolStripDropDownBtnPaste.AutoToolTip = False
			Me.toolStripDropDownBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripDropDownBtnPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem, Me.pasteAsHyperlinkToolStripMenuItem})
			Me.toolStripDropDownBtnPaste.Image = (CType(resources.GetObject("toolStripDropDownBtnPaste.Image"), System.Drawing.Image))
			Me.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste"
			Me.SetShortcut(Me.toolStripDropDownBtnPaste, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)))
			Me.toolStripDropDownBtnPaste.ShowDropDownArrow = False
			Me.toolStripDropDownBtnPaste.Size = New System.Drawing.Size(38, 17)
			Me.toolStripDropDownBtnPaste.Text = "Paste"
			toolTipInfo12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo12.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			toolTipInfo12.Header.Text = "Paste (Ctrl+V)"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownBtnPaste, toolTipInfo12)
			' 
			' pasteToolStripMenuItem
			' 
			Me.pasteToolStripMenuItem.Image = (CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
			Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.pasteToolStripMenuItem.Text = "&Paste"
			' 
			' pasteSpecialToolStripMenuItem
			' 
			Me.pasteSpecialToolStripMenuItem.Image = (CType(resources.GetObject("pasteSpecialToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
			Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.pasteSpecialToolStripMenuItem.Text = "Paste &Special..."
			' 
			' pasteAsHyperlinkToolStripMenuItem
			' 
			Me.pasteAsHyperlinkToolStripMenuItem.Enabled = False
			Me.pasteAsHyperlinkToolStripMenuItem.Image = (CType(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem"
			Me.pasteAsHyperlinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.pasteAsHyperlinkToolStripMenuItem.Text = "Paste as &Hyperlink"
			' 
			' toolStripPanelItem1
			' 
			Me.toolStripPanelItem1.CausesValidation = False
			Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripBtnCut, Me.toolStripBtnCopy, Me.toolStripBtnPaint})
			Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
			Me.toolStripPanelItem1.ShowItemToolTips = False
			Me.toolStripPanelItem1.Size = New System.Drawing.Size(27, 78)
			Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Transparent = True
			' 
			' toolStripBtnCut
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripBtnCut, "X")
			Me.toolStripBtnCut.AutoToolTip = False
			Me.toolStripBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnCut.Image = (CType(resources.GetObject("toolStripBtnCut.Image"), System.Drawing.Image))
			Me.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnCut.Name = "toolStripBtnCut"
			Me.SetShortcut(Me.toolStripBtnCut, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)))
			Me.toolStripBtnCut.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnCut.Text = "Cut"
			toolTipInfo13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo13.Header.Text = "Cut"
			Me.superToolTip1.SetToolTip(Me.toolStripBtnCut, toolTipInfo13)
			Me.toolStripBtnCut.ToolTipText = "Cut"
			' 
			' toolStripBtnCopy
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripBtnCopy, "C")
			Me.toolStripBtnCopy.AutoToolTip = False
			Me.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnCopy.Image = (CType(resources.GetObject("toolStripBtnCopy.Image"), System.Drawing.Image))
			Me.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnCopy.Name = "toolStripBtnCopy"
			Me.SetShortcut(Me.toolStripBtnCopy, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)))
			Me.toolStripBtnCopy.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnCopy.Text = "Copy"
			toolTipInfo14.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo14.Header.Text = "Copy"
			Me.superToolTip1.SetToolTip(Me.toolStripBtnCopy, toolTipInfo14)
			Me.toolStripBtnCopy.ToolTipText = "Copy"
			' 
			' toolStripBtnPaint
			' 
            Me.superAccelerator1.SetAccelerator(Me.toolStripBtnPaint, "FQ")
			Me.toolStripBtnPaint.AutoToolTip = False
			Me.toolStripBtnPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnPaint.Image = (CType(resources.GetObject("toolStripBtnPaint.Image"), System.Drawing.Image))
			Me.toolStripBtnPaint.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnPaint.Name = "toolStripBtnPaint"
			Me.SetShortcut(Me.toolStripBtnPaint, (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)))
			Me.toolStripBtnPaint.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnPaint.Text = "Format Painter"
			toolTipInfo15.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo15.Body.Text = "This will clear all the" & Constants.vbCrLf & "formatting."
			toolTipInfo15.Body.TextMargin = New System.Windows.Forms.Padding(4)
			toolTipInfo15.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			toolTipInfo15.Header.Text = "Format Painter"
			Me.superToolTip1.SetToolTip(Me.toolStripBtnPaint, toolTipInfo15)
			Me.toolStripBtnPaint.ToolTipText = "Format Painter"
			' 
			' fontToolStripExt
			' 
			Me.fontToolStripExt.CollapsedDropDownButtonText = "Font"
			Me.fontToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.fontToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.fontToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.fontToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.fontToolStripExt.GroupedButtons = True
			Me.fontToolStripExt.Image = (CType(resources.GetObject("fontToolStripExt.Image"), System.Drawing.Image))
			Me.fontToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem2, Me.toolStripPanelItem4, Me.toolStripButton71, Me.toolStripButton74, Me.toolStripDropDownButton50, Me.toolStripPanelItem3})
			Me.fontToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.fontToolStripExt.Location = New System.Drawing.Point(93, 1)
			Me.fontToolStripExt.Name = "fontToolStripExt"
			Me.fontToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.fontToolStripExt.ShowItemToolTips = False
			Me.fontToolStripExt.Size = New System.Drawing.Size(150, 106)
			Me.fontToolStripExt.TabIndex = 6
			Me.fontToolStripExt.Text = "Font"
			' 
			' toolStripPanelItem2
			' 
			Me.toolStripPanelItem2.CausesValidation = False
			Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem2.GroupedButtons = True
			Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripFontfaceComboBox, Me.toolStripFontSizeComboBox})
			Me.toolStripPanelItem2.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
			Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
			Me.toolStripPanelItem2.RowCount = 1
			Me.toolStripPanelItem2.ShowItemToolTips = False
			Me.toolStripPanelItem2.Size = New System.Drawing.Size(129, 25)
			Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
			Me.toolStripPanelItem2.Transparent = True
			' 
			' toolStripFontfaceComboBox
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripFontfaceComboBox, "FF")
			Me.toolStripFontfaceComboBox.AutoCompleteCustomSource.AddRange(New String() { "Callibri"})
			Me.toolStripFontfaceComboBox.DropDownHeight = 120
			Me.toolStripFontfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripFontfaceComboBox.IntegralHeight = False
			Me.toolStripFontfaceComboBox.Items.AddRange(New Object() { "Callibri"})
			Me.toolStripFontfaceComboBox.Name = "toolStripFontfaceComboBox"
			Me.toolStripFontfaceComboBox.Size = New System.Drawing.Size(80, 21)
			Me.toolStripFontfaceComboBox.ToolTipText = "Font"
			' 
			' toolStripFontSizeComboBox
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripFontSizeComboBox, "FS")
			Me.toolStripFontSizeComboBox.AutoSize = False
			Me.toolStripFontSizeComboBox.DropDownHeight = 120
			Me.toolStripFontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripFontSizeComboBox.IntegralHeight = False
			Me.toolStripFontSizeComboBox.Items.AddRange(New Object() { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
			Me.toolStripFontSizeComboBox.Name = "toolStripFontSizeComboBox"
			Me.toolStripFontSizeComboBox.Size = New System.Drawing.Size(41, 21)
			Me.toolStripFontSizeComboBox.ToolTipText = "Font Size"
			' 
			' toolStripPanelItem4
			' 
			Me.toolStripPanelItem4.CausesValidation = False
			Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem4.GroupedButtons = True
			Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.boldToolstripBtn, Me.italicToolStripBtn, Me.underlineToolStripSplitBtn})
			Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
			Me.toolStripPanelItem4.RowCount = 1
			Me.toolStripPanelItem4.ShowItemToolTips = False
			Me.toolStripPanelItem4.Size = New System.Drawing.Size(82, 27)
			Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
			Me.toolStripPanelItem4.Transparent = True
			' 
			' boldToolstripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.boldToolstripBtn, "1")
			Me.boldToolstripBtn.AutoToolTip = False
			Me.boldToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.boldToolstripBtn.Image = (CType(resources.GetObject("boldToolstripBtn.Image"), System.Drawing.Image))
			Me.boldToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.boldToolstripBtn.Name = "boldToolstripBtn"
			Me.boldToolstripBtn.Size = New System.Drawing.Size(23, 20)
			Me.boldToolstripBtn.Text = "boldToolstripBtn"
			toolTipInfo16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo16.Header.Text = "Bold"
			Me.superToolTip1.SetToolTip(Me.boldToolstripBtn, toolTipInfo16)
			Me.boldToolstripBtn.ToolTipText = "Bold"
			' 
			' italicToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.italicToolStripBtn, "2")
			Me.italicToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.italicToolStripBtn.Image = (CType(resources.GetObject("italicToolStripBtn.Image"), System.Drawing.Image))
			Me.italicToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.italicToolStripBtn.Name = "italicToolStripBtn"
			Me.italicToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.italicToolStripBtn.Text = "italicToolStripBtn"
			toolTipInfo17.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo17.Header.Text = "Italic"
			Me.superToolTip1.SetToolTip(Me.italicToolStripBtn, toolTipInfo17)
			Me.italicToolStripBtn.ToolTipText = "Italic"
			' 
			' underlineToolStripSplitBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.underlineToolStripSplitBtn, "3")
			Me.underlineToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.underlineToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.moreUnderlinesToolStripMenuItem, Me.underlineColorToolStripMenuItem})
			Me.underlineToolStripSplitBtn.Image = (CType(resources.GetObject("underlineToolStripSplitBtn.Image"), System.Drawing.Image))
			Me.underlineToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.underlineToolStripSplitBtn.Name = "underlineToolStripSplitBtn"
			Me.underlineToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.underlineToolStripSplitBtn.Text = "underlineToolStripSplitBtn"
			toolTipInfo18.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo18.Header.Text = "Underline"
			Me.superToolTip1.SetToolTip(Me.underlineToolStripSplitBtn, toolTipInfo18)
			Me.underlineToolStripSplitBtn.ToolTipText = "Underline"
			' 
			' moreUnderlinesToolStripMenuItem
			' 
			Me.moreUnderlinesToolStripMenuItem.Name = "moreUnderlinesToolStripMenuItem"
			Me.moreUnderlinesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
			Me.moreUnderlinesToolStripMenuItem.Text = "&More Underlines..."
			' 
			' underlineColorToolStripMenuItem
			' 
			Me.underlineColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.automaticToolStripMenuItem, Me.moreColorsToolStripMenuItem})
			Me.underlineColorToolStripMenuItem.Image = (CType(resources.GetObject("underlineColorToolStripMenuItem.Image"), System.Drawing.Image))
			Me.underlineColorToolStripMenuItem.Name = "underlineColorToolStripMenuItem"
			Me.underlineColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
			Me.underlineColorToolStripMenuItem.Text = "&Underline Color"
			' 
			' automaticToolStripMenuItem
			' 
			Me.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem"
			Me.automaticToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.automaticToolStripMenuItem.Text = "&Automatic"
			' 
			' moreColorsToolStripMenuItem
			' 
			Me.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem"
			Me.moreColorsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.moreColorsToolStripMenuItem.Text = "&More Colors..."
			' 
			' toolStripButton71
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton71, "FG")
			Me.toolStripButton71.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton71.Image = (CType(resources.GetObject("toolStripButton71.Image"), System.Drawing.Image))
			Me.toolStripButton71.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton71.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton71.Margin = New System.Windows.Forms.Padding(0, 3, 0, 2)
			Me.toolStripButton71.Name = "toolStripButton71"
			Me.toolStripButton71.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton71.Text = "growfontToolStripBtn"
			' 
			' toolStripButton74
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton74, "FK")
			Me.toolStripButton74.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton74.Image = (CType(resources.GetObject("toolStripButton74.Image"), System.Drawing.Image))
			Me.toolStripButton74.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton74.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton74.Margin = New System.Windows.Forms.Padding(0, 3, 0, 2)
			Me.toolStripButton74.Name = "toolStripButton74"
			Me.toolStripButton74.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton74.Text = "shrinkfontToolStripBtn"
			' 
			' toolStripDropDownButton50
			' 
			Me.toolStripDropDownButton50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton50.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem2, Me.toolStripMenuItem3, Me.toolStripMenuItem4, Me.toolStripMenuItem5, Me.toolStripSeparator16, Me.noBorderToolStripMenuItem})
			Me.toolStripDropDownButton50.Image = (CType(resources.GetObject("toolStripDropDownButton50.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton50.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton50.Margin = New System.Windows.Forms.Padding(3, 3, 0, 2)
			Me.toolStripDropDownButton50.Name = "toolStripDropDownButton50"
			Me.toolStripDropDownButton50.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton50.Text = "Borders"
			toolTipInfo19.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo19.Header.Text = "Borders"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton50, toolTipInfo19)
			' 
			' toolStripMenuItem2
			' 
			Me.toolStripMenuItem2.Image = (CType(resources.GetObject("toolStripMenuItem2.Image"), System.Drawing.Image))
			Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
			Me.toolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
			Me.toolStripMenuItem2.Text = "Bottom Border"
			' 
			' toolStripMenuItem3
			' 
			Me.toolStripMenuItem3.Image = (CType(resources.GetObject("toolStripMenuItem3.Image"), System.Drawing.Image))
			Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
			Me.toolStripMenuItem3.Size = New System.Drawing.Size(154, 22)
			Me.toolStripMenuItem3.Text = "Top Border"
			' 
			' toolStripMenuItem4
			' 
			Me.toolStripMenuItem4.Image = (CType(resources.GetObject("toolStripMenuItem4.Image"), System.Drawing.Image))
			Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
			Me.toolStripMenuItem4.Size = New System.Drawing.Size(154, 22)
			Me.toolStripMenuItem4.Text = "Left Border"
			' 
			' toolStripMenuItem5
			' 
			Me.toolStripMenuItem5.Image = (CType(resources.GetObject("toolStripMenuItem5.Image"), System.Drawing.Image))
			Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
			Me.toolStripMenuItem5.Size = New System.Drawing.Size(154, 22)
			Me.toolStripMenuItem5.Text = "Right Border"
			' 
			' toolStripSeparator16
			' 
			Me.toolStripSeparator16.Name = "toolStripSeparator16"
			Me.toolStripSeparator16.Size = New System.Drawing.Size(151, 6)
			' 
			' noBorderToolStripMenuItem
			' 
			Me.noBorderToolStripMenuItem.Image = (CType(resources.GetObject("noBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem"
			Me.noBorderToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.noBorderToolStripMenuItem.Text = "No Border"
			' 
			' toolStripPanelItem3
			' 
			Me.toolStripPanelItem3.CausesValidation = False
			Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem3.GroupedButtons = True
			Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton78, Me.toolStripButton79})
			Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
			Me.toolStripPanelItem3.RowCount = 1
			Me.toolStripPanelItem3.ShowItemToolTips = False
			Me.toolStripPanelItem3.Size = New System.Drawing.Size(50, 27)
			Me.toolStripPanelItem3.Text = "toolStripPanelItem3"
			Me.toolStripPanelItem3.Transparent = True
			' 
			' toolStripButton78
			' 
			Me.toolStripButton78.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton78.Image = (CType(resources.GetObject("toolStripButton78.Image"), System.Drawing.Image))
			Me.toolStripButton78.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton78.Name = "toolStripButton78"
			Me.toolStripButton78.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton78.Text = "toolStripButton78"
			toolTipInfo20.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo20.Header.Text = "Shading"
			Me.superToolTip1.SetToolTip(Me.toolStripButton78, toolTipInfo20)
			Me.toolStripButton78.ToolTipText = "Fill color"
			' 
			' toolStripButton79
			' 
			Me.toolStripButton79.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton79.Image = (CType(resources.GetObject("toolStripButton79.Image"), System.Drawing.Image))
			Me.toolStripButton79.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton79.Name = "toolStripButton79"
			Me.toolStripButton79.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton79.Text = "toolStripButton79"
			toolTipInfo21.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo21.Header.Text = "Font Color"
			Me.superToolTip1.SetToolTip(Me.toolStripButton79, toolTipInfo21)
			Me.toolStripButton79.ToolTipText = "Font color"
			' 
			' paragraphToolStripExt
			' 
			Me.paragraphToolStripExt.CollapsedDropDownButtonText = "Paragraph"
			Me.paragraphToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.paragraphToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.paragraphToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.paragraphToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.paragraphToolStripExt.GroupedButtons = True
			Me.paragraphToolStripExt.Image = (CType(resources.GetObject("paragraphToolStripExt.Image"), System.Drawing.Image))
			Me.paragraphToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem54, Me.toolStripLabel19, Me.centerToolStripBtn, Me.lAlignToolStripBtn, Me.rAlignToolStripBtn, Me.toolStripSplitButtonEx2, Me.toolStripPanelItem8, Me.toolStripButton73})
			Me.paragraphToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.paragraphToolStripExt.Location = New System.Drawing.Point(243, 1)
			Me.paragraphToolStripExt.Name = "paragraphToolStripExt"
			Me.paragraphToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.paragraphToolStripExt.ShowItemToolTips = False
			Me.paragraphToolStripExt.Size = New System.Drawing.Size(118, 106)
			Me.paragraphToolStripExt.TabIndex = 7
			Me.paragraphToolStripExt.Text = "Alignment"
			' 
			' toolStripPanelItem54
			' 
			Me.toolStripPanelItem54.CausesValidation = False
			Me.toolStripPanelItem54.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem54.GroupedButtons = True
			Me.toolStripPanelItem54.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton59, Me.toolStripButton60, Me.toolStripButton61})
			Me.toolStripPanelItem54.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
			Me.toolStripPanelItem54.Name = "toolStripPanelItem54"
			Me.toolStripPanelItem54.RowCount = 1
			Me.toolStripPanelItem54.ShowItemToolTips = False
			Me.toolStripPanelItem54.Size = New System.Drawing.Size(73, 27)
			Me.toolStripPanelItem54.Text = "toolStripPanelItem54"
			Me.toolStripPanelItem54.Transparent = True
			' 
			' toolStripButton59
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton59, "AT")
			Me.toolStripButton59.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton59.Image = (CType(resources.GetObject("toolStripButton59.Image"), System.Drawing.Image))
			Me.toolStripButton59.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton59.Name = "toolStripButton59"
			Me.toolStripButton59.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton59.Text = "toolStripButton59"
			toolTipInfo22.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo22.Header.Text = "Top Align"
			Me.superToolTip1.SetToolTip(Me.toolStripButton59, toolTipInfo22)
			Me.toolStripButton59.ToolTipText = "Top Align"
			' 
			' toolStripButton60
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton60, "AM")
			Me.toolStripButton60.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton60.Image = (CType(resources.GetObject("toolStripButton60.Image"), System.Drawing.Image))
			Me.toolStripButton60.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton60.Name = "toolStripButton60"
			Me.toolStripButton60.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton60.Text = "toolStripButton60"
			toolTipInfo23.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo23.Header.Text = "Middle Align"
			Me.superToolTip1.SetToolTip(Me.toolStripButton60, toolTipInfo23)
			Me.toolStripButton60.ToolTipText = "Middle Align"
			' 
			' toolStripButton61
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton61, "AB")
			Me.toolStripButton61.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton61.Image = (CType(resources.GetObject("toolStripButton61.Image"), System.Drawing.Image))
			Me.toolStripButton61.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton61.Name = "toolStripButton61"
			Me.toolStripButton61.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton61.Text = "toolStripButton61"
			toolTipInfo24.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo24.Header.Text = "Bottom Align"
			Me.superToolTip1.SetToolTip(Me.toolStripButton61, toolTipInfo24)
			Me.toolStripButton61.ToolTipText = "Bottom Align"
			' 
			' toolStripLabel19
			' 
			Me.toolStripLabel19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripLabel19.Image = (CType(resources.GetObject("toolStripLabel19.Image"), System.Drawing.Image))
			Me.toolStripLabel19.Margin = New System.Windows.Forms.Padding(0, 5, 0, 2)
			Me.toolStripLabel19.Name = "toolStripLabel19"
			Me.toolStripLabel19.Size = New System.Drawing.Size(23, 20)
			Me.toolStripLabel19.ToolTipText = "Wrap Text"
			' 
			' centerToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.centerToolStripBtn, "AC")
			Me.centerToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.centerToolStripBtn.Image = (CType(resources.GetObject("centerToolStripBtn.Image"), System.Drawing.Image))
			Me.centerToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.centerToolStripBtn.Margin = New System.Windows.Forms.Padding(2, 1, 0, 2)
			Me.centerToolStripBtn.Name = "centerToolStripBtn"
			Me.centerToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.centerToolStripBtn.Text = "centerToolStripBtn"
			toolTipInfo25.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo25.Header.Text = "Center"
			Me.superToolTip1.SetToolTip(Me.centerToolStripBtn, toolTipInfo25)
			Me.centerToolStripBtn.ToolTipText = "Center"
			' 
			' lAlignToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.lAlignToolStripBtn, "AL")
			Me.lAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.lAlignToolStripBtn.Image = (CType(resources.GetObject("lAlignToolStripBtn.Image"), System.Drawing.Image))
			Me.lAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.lAlignToolStripBtn.Name = "lAlignToolStripBtn"
			Me.lAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.lAlignToolStripBtn.Text = "lAlignToolStripBtn"
			toolTipInfo26.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo26.Header.Text = "Left"
			Me.superToolTip1.SetToolTip(Me.lAlignToolStripBtn, toolTipInfo26)
			Me.lAlignToolStripBtn.ToolTipText = "Left"
			' 
			' rAlignToolStripBtn
			' 
			Me.superAccelerator1.SetAccelerator(Me.rAlignToolStripBtn, "AR")
			Me.rAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.rAlignToolStripBtn.Image = (CType(resources.GetObject("rAlignToolStripBtn.Image"), System.Drawing.Image))
			Me.rAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.rAlignToolStripBtn.Name = "rAlignToolStripBtn"
			Me.rAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.rAlignToolStripBtn.Text = "rAlignToolStripBtn"
			toolTipInfo27.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo27.Header.Text = "Right"
			Me.superToolTip1.SetToolTip(Me.rAlignToolStripBtn, toolTipInfo27)
			Me.rAlignToolStripBtn.ToolTipText = "Right"
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
			Me.mergeCenterToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.mergeCenterToolStripMenuItem.Text = "Merge & Center"
			' 
			' mergeAcrossToolStripMenuItem
			' 
			Me.mergeAcrossToolStripMenuItem.Name = "mergeAcrossToolStripMenuItem"
			Me.mergeAcrossToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.mergeAcrossToolStripMenuItem.Text = "Merge Across"
			' 
			' mergeCellsToolStripMenuItem
			' 
			Me.mergeCellsToolStripMenuItem.Name = "mergeCellsToolStripMenuItem"
			Me.mergeCellsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.mergeCellsToolStripMenuItem.Text = "Merge cells"
			' 
			' unmergeCellsToolStripMenuItem
			' 
			Me.unmergeCellsToolStripMenuItem.Name = "unmergeCellsToolStripMenuItem"
			Me.unmergeCellsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.unmergeCellsToolStripMenuItem.Text = "Unmerge cells"
			' 
			' toolStripPanelItem8
			' 
			Me.toolStripPanelItem8.CausesValidation = False
			Me.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem8.GroupedButtons = True
			Me.toolStripPanelItem8.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.deindentToolStripBtn, Me.inindentToolStripBtn})
			Me.toolStripPanelItem8.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
			Me.toolStripPanelItem8.Name = "toolStripPanelItem8"
			Me.toolStripPanelItem8.RowCount = 1
			Me.toolStripPanelItem8.ShowItemToolTips = False
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
			toolTipInfo28.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo28.Header.Text = "Decrease indent"
			Me.superToolTip1.SetToolTip(Me.deindentToolStripBtn, toolTipInfo28)
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
			toolTipInfo29.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo29.Header.Text = "Increase indent"
			Me.superToolTip1.SetToolTip(Me.inindentToolStripBtn, toolTipInfo29)
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
			toolTipInfo30.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo30.Header.Text = "Orientation"
			Me.superToolTip1.SetToolTip(Me.toolStripButton73, toolTipInfo30)
			Me.toolStripButton73.ToolTipText = "Orientation"
			' 
			' toolStripEx3
			' 
			Me.toolStripEx3.AutoSize = False
			Me.toolStripEx3.CollapsedDropDownButtonText = "General"
			Me.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx3.Image = (CType(resources.GetObject("toolStripEx3.Image"), System.Drawing.Image))
			Me.toolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem5, Me.toolStripSeparator7, Me.toolStripPanelItem10})
			Me.toolStripEx3.Location = New System.Drawing.Point(361, 1)
			Me.toolStripEx3.Name = "toolStripEx3"
			Me.toolStripEx3.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx3.ShowItemToolTips = False
			Me.toolStripEx3.Size = New System.Drawing.Size(176, 106)
			Me.toolStripEx3.TabIndex = 12
			Me.toolStripEx3.Text = "General"
			' 
			' toolStripPanelItem5
			' 
			Me.toolStripPanelItem5.CausesValidation = False
			Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem6, Me.toolStripPanelItem7, Me.toolStripPanelItem9})
			Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
			Me.toolStripPanelItem5.ShowItemToolTips = False
			Me.toolStripPanelItem5.Size = New System.Drawing.Size(91, 78)
			Me.toolStripPanelItem5.Text = "toolStripPanelItem5"
			Me.toolStripPanelItem5.Transparent = True
			' 
			' toolStripPanelItem6
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripPanelItem6, "N")
			Me.toolStripPanelItem6.CausesValidation = False
			Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem6.GroupedButtons = True
			Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.General_toolStripComboBox1})
			Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
			Me.toolStripPanelItem6.ShowItemToolTips = False
			Me.toolStripPanelItem6.Size = New System.Drawing.Size(85, 25)
			Me.toolStripPanelItem6.Text = "toolStripPanelItem6"
			Me.toolStripPanelItem6.Transparent = True
			' 
			' General_toolStripComboBox1
			' 
			Me.General_toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.General_toolStripComboBox1.Items.AddRange(New Object() { "General", "Number", "Currency", "Accounting"})
			Me.General_toolStripComboBox1.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
			Me.General_toolStripComboBox1.Name = "General_toolStripComboBox1"
			Me.General_toolStripComboBox1.Size = New System.Drawing.Size(80, 21)
			Me.General_toolStripComboBox1.ToolTipText = "General"
			' 
			' toolStripPanelItem7
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripPanelItem7, "AN")
			Me.toolStripPanelItem7.CausesValidation = False
			Me.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem7.GroupedButtons = True
			Me.toolStripPanelItem7.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton1, Me.toolStripButton7, Me.toolStripButton9})
			Me.toolStripPanelItem7.Name = "toolStripPanelItem7"
			Me.toolStripPanelItem7.RowCount = 1
			Me.toolStripPanelItem7.ShowItemToolTips = False
			Me.toolStripPanelItem7.Size = New System.Drawing.Size(79, 27)
			Me.toolStripPanelItem7.Text = "toolStripPanelItem7"
			Me.toolStripPanelItem7.Transparent = True
			' 
			' toolStripDropDownButton1
			' 
			Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem6, Me.toolStripMenuItem7, Me.toolStripMenuItem8, Me.toolStripMenuItem9, Me.toolStripMenuItem10})
			Me.toolStripDropDownButton1.Image = (CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
			Me.toolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton1.Text = "S"
			' 
			' toolStripMenuItem6
			' 
			Me.toolStripMenuItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
			Me.toolStripMenuItem6.Size = New System.Drawing.Size(184, 22)
			Me.toolStripMenuItem6.Text = "$ English (U.S)"
			' 
			' toolStripMenuItem7
			' 
			Me.toolStripMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
			Me.toolStripMenuItem7.Size = New System.Drawing.Size(184, 22)
			Me.toolStripMenuItem7.Text = " English (U.K)"
			' 
			' toolStripMenuItem8
			' 
			Me.toolStripMenuItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripMenuItem8.Name = "toolStripMenuItem8"
			Me.toolStripMenuItem8.Size = New System.Drawing.Size(184, 22)
			Me.toolStripMenuItem8.Text = "Euro"
			' 
			' toolStripMenuItem9
			' 
			Me.toolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
			Me.toolStripMenuItem9.Size = New System.Drawing.Size(184, 22)
			Me.toolStripMenuItem9.Text = "Chinese"
			' 
			' toolStripMenuItem10
			' 
			Me.toolStripMenuItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripMenuItem10.Name = "toolStripMenuItem10"
			Me.toolStripMenuItem10.Size = New System.Drawing.Size(184, 22)
			Me.toolStripMenuItem10.Text = "French (Switzerland)"
			' 
			' toolStripButton7
			' 
            Me.superAccelerator1.SetAccelerator(Me.toolStripButton7, "PS")
			Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton7.Image = (CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image))
			Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton7.Name = "toolStripButton7"
			Me.toolStripButton7.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton7.Text = "toolStripButton7"
			Me.toolStripButton7.ToolTipText = "Percent Style"
			' 
			' toolStripButton9
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton9, "K")
			Me.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton9.Image = (CType(resources.GetObject("toolStripButton9.Image"), System.Drawing.Image))
			Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton9.Name = "toolStripButton9"
			Me.toolStripButton9.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton9.Text = "toolStripButton9"
			Me.toolStripButton9.ToolTipText = "Comma Style"
			' 
			' toolStripPanelItem9
			' 
			Me.toolStripPanelItem9.CausesValidation = False
			Me.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem9.GroupedButtons = True
			Me.toolStripPanelItem9.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton63, Me.toolStripButton68})
			Me.toolStripPanelItem9.Name = "toolStripPanelItem9"
			Me.toolStripPanelItem9.RowCount = 1
			Me.toolStripPanelItem9.ShowItemToolTips = False
			Me.toolStripPanelItem9.Size = New System.Drawing.Size(50, 27)
			Me.toolStripPanelItem9.Text = "toolStripPanelItem9"
			Me.toolStripPanelItem9.Transparent = True
			' 
			' toolStripButton63
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton63, "0")
			Me.toolStripButton63.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton63.Image = (CType(resources.GetObject("toolStripButton63.Image"), System.Drawing.Image))
			Me.toolStripButton63.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton63.Name = "toolStripButton63"
			Me.toolStripButton63.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton63.Text = "toolStripButton63"
			Me.toolStripButton63.ToolTipText = "Increase Decimal"
			' 
			' toolStripButton68
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripButton68, "9")
			Me.toolStripButton68.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton68.Image = (CType(resources.GetObject("toolStripButton68.Image"), System.Drawing.Image))
			Me.toolStripButton68.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton68.Name = "toolStripButton68"
			Me.toolStripButton68.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton68.Text = "toolStripButton68"
			Me.toolStripButton68.ToolTipText = "Decrease Decimal"
			' 
			' toolStripSeparator7
			' 
			Me.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlDark
			Me.toolStripSeparator7.ForeColor = System.Drawing.SystemColors.Control
			Me.toolStripSeparator7.Name = "toolStripSeparator7"
			Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 78)
			' 
			' toolStripPanelItem10
			' 
			Me.toolStripPanelItem10.CausesValidation = False
			Me.toolStripPanelItem10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem10.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton2})
			Me.toolStripPanelItem10.Name = "toolStripPanelItem10"
			Me.toolStripPanelItem10.RowCount = 1
			Me.toolStripPanelItem10.ShowItemToolTips = False
			Me.toolStripPanelItem10.Size = New System.Drawing.Size(53, 78)
			Me.toolStripPanelItem10.Text = "toolStripPanelItem10"
			Me.toolStripPanelItem10.ToolTipText = "Styles"
			Me.toolStripPanelItem10.Transparent = True
			' 
			' toolStripDropDownButton2
			' 
            Me.superAccelerator1.SetAccelerator(Me.toolStripDropDownButton2, "P1")
			Me.toolStripDropDownButton2.AutoSize = False
			Me.toolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1, Me.toolStripMenuItem52})
			Me.toolStripDropDownButton2.Image = (CType(resources.GetObject("toolStripDropDownButton2.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton2.Name = "toolStripDropDownButton2"
			Me.toolStripDropDownButton2.Size = New System.Drawing.Size(49, 70)
			Me.toolStripDropDownButton2.Text = "Styles"
			Me.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			toolTipInfo31.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo31.Header.Text = "Styles"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton2, toolTipInfo31)
			' 
			' toolStripMenuItem1
			' 
			Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
			Me.toolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
			Me.toolStripMenuItem1.Text = "Conditional Formatting"
			' 
			' toolStripMenuItem52
			' 
			Me.toolStripMenuItem52.Name = "toolStripMenuItem52"
			Me.toolStripMenuItem52.Size = New System.Drawing.Size(193, 22)
			Me.toolStripMenuItem52.Text = "Format As Table"
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.AutoSize = False
			Me.toolStripEx1.CollapsedDropDownButtonText = "Cells"
			Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = (CType(resources.GetObject("toolStripEx1.Image"), System.Drawing.Image))
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem11})
			Me.toolStripEx1.Location = New System.Drawing.Point(537, 1)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx1.ShowItemToolTips = False
			Me.toolStripEx1.Size = New System.Drawing.Size(112, 106)
			Me.toolStripEx1.TabIndex = 13
			Me.toolStripEx1.Text = "Cells"
			' 
			' toolStripPanelItem11
			' 
			Me.toolStripPanelItem11.CausesValidation = False
			Me.toolStripPanelItem11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem11.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton3, Me.toolStripDropDownButton4, Me.toolStripDropDownButton5})
			Me.toolStripPanelItem11.Name = "toolStripPanelItem11"
			Me.toolStripPanelItem11.ShowItemToolTips = False
			Me.toolStripPanelItem11.Size = New System.Drawing.Size(74, 78)
			Me.toolStripPanelItem11.Text = "toolStripPanelItem11"
			Me.toolStripPanelItem11.Transparent = True
			' 
			' toolStripDropDownButton3
			' 
            Me.superAccelerator1.SetAccelerator(Me.toolStripDropDownButton3, "II")
			Me.toolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem27, Me.toolStripSeparator10, Me.toolStripMenuItem28, Me.toolStripMenuItem29, Me.toolStripSeparator13, Me.toolStripMenuItem30})
			Me.toolStripDropDownButton3.Image = (CType(resources.GetObject("toolStripDropDownButton3.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton3.Name = "toolStripDropDownButton3"
			Me.toolStripDropDownButton3.Size = New System.Drawing.Size(65, 20)
			Me.toolStripDropDownButton3.Text = "Insert"
			toolTipInfo32.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo32.Header.Text = "Insert"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton3, toolTipInfo32)
			' 
			' toolStripMenuItem27
			' 
			Me.toolStripMenuItem27.Name = "toolStripMenuItem27"
			Me.toolStripMenuItem27.Size = New System.Drawing.Size(188, 22)
			Me.toolStripMenuItem27.Text = "Insert Cells"
			' 
			' toolStripSeparator10
			' 
			Me.toolStripSeparator10.Name = "toolStripSeparator10"
			Me.toolStripSeparator10.Size = New System.Drawing.Size(185, 6)
			' 
			' toolStripMenuItem28
			' 
			Me.toolStripMenuItem28.Name = "toolStripMenuItem28"
			Me.toolStripMenuItem28.Size = New System.Drawing.Size(188, 22)
			Me.toolStripMenuItem28.Text = "Insert Sheet Rows"
			' 
			' toolStripMenuItem29
			' 
			Me.toolStripMenuItem29.Name = "toolStripMenuItem29"
			Me.toolStripMenuItem29.Size = New System.Drawing.Size(188, 22)
			Me.toolStripMenuItem29.Text = "Insert Sheet Columns"
			' 
			' toolStripSeparator13
			' 
			Me.toolStripSeparator13.Name = "toolStripSeparator13"
			Me.toolStripSeparator13.Size = New System.Drawing.Size(185, 6)
			' 
			' toolStripMenuItem30
			' 
			Me.toolStripMenuItem30.Name = "toolStripMenuItem30"
			Me.toolStripMenuItem30.Size = New System.Drawing.Size(188, 22)
			Me.toolStripMenuItem30.Text = "Insert Sheets"
			' 
			' toolStripDropDownButton4
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripDropDownButton4, "D")
			Me.toolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem31, Me.toolStripSeparator14, Me.toolStripMenuItem32, Me.toolStripMenuItem33, Me.toolStripSeparator15, Me.toolStripMenuItem34})
			Me.toolStripDropDownButton4.Image = (CType(resources.GetObject("toolStripDropDownButton4.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton4.Name = "toolStripDropDownButton4"
			Me.toolStripDropDownButton4.Size = New System.Drawing.Size(67, 20)
			Me.toolStripDropDownButton4.Text = "Delete"
			toolTipInfo33.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo33.Header.Text = "Delete"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton4, toolTipInfo33)
			' 
			' toolStripMenuItem31
			' 
			Me.toolStripMenuItem31.Name = "toolStripMenuItem31"
			Me.toolStripMenuItem31.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem31.Text = "Delete Cells"
			' 
			' toolStripSeparator14
			' 
			Me.toolStripSeparator14.Name = "toolStripSeparator14"
			Me.toolStripSeparator14.Size = New System.Drawing.Size(187, 6)
			' 
			' toolStripMenuItem32
			' 
			Me.toolStripMenuItem32.Name = "toolStripMenuItem32"
			Me.toolStripMenuItem32.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem32.Text = "Delete Sheet Rows"
			' 
			' toolStripMenuItem33
			' 
			Me.toolStripMenuItem33.Name = "toolStripMenuItem33"
			Me.toolStripMenuItem33.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem33.Text = "Delete Sheet Columns"
			' 
			' toolStripSeparator15
			' 
			Me.toolStripSeparator15.Name = "toolStripSeparator15"
			Me.toolStripSeparator15.Size = New System.Drawing.Size(187, 6)
			' 
			' toolStripMenuItem34
			' 
			Me.toolStripMenuItem34.Name = "toolStripMenuItem34"
			Me.toolStripMenuItem34.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem34.Text = "Delete Sheets"
			' 
			' toolStripDropDownButton5
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripDropDownButton5, "O")
			Me.toolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem35, Me.toolStripMenuItem36, Me.toolStripMenuItem37, Me.toolStripMenuItem38})
			Me.toolStripDropDownButton5.Image = (CType(resources.GetObject("toolStripDropDownButton5.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton5.Name = "toolStripDropDownButton5"
			Me.toolStripDropDownButton5.Size = New System.Drawing.Size(70, 20)
			Me.toolStripDropDownButton5.Text = "Format"
			toolTipInfo34.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			toolTipInfo34.Header.Text = "Format"
			Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton5, toolTipInfo34)
			' 
			' toolStripMenuItem35
			' 
			Me.toolStripMenuItem35.Name = "toolStripMenuItem35"
			Me.toolStripMenuItem35.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem35.Text = "Row Height"
			' 
			' toolStripMenuItem36
			' 
			Me.toolStripMenuItem36.Name = "toolStripMenuItem36"
			Me.toolStripMenuItem36.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem36.Text = "Autofit Row Height"
			' 
			' toolStripMenuItem37
			' 
			Me.toolStripMenuItem37.Name = "toolStripMenuItem37"
			Me.toolStripMenuItem37.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem37.Text = "Column Height"
			' 
			' toolStripMenuItem38
			' 
			Me.toolStripMenuItem38.Name = "toolStripMenuItem38"
			Me.toolStripMenuItem38.Size = New System.Drawing.Size(190, 22)
			Me.toolStripMenuItem38.Text = "Autofit Column Height"
			' 
			' toolStripEx2
			' 
			Me.toolStripEx2.AutoSize = False
			Me.toolStripEx2.CollapsedDropDownButtonText = "Editing"
			Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx2.Image = (CType(resources.GetObject("toolStripEx2.Image"), System.Drawing.Image))
			Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem12})
			Me.toolStripEx2.Location = New System.Drawing.Point(628, 1)
			Me.toolStripEx2.Name = "toolStripEx2"
			Me.toolStripEx2.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx2.ShowItemToolTips = False
			Me.toolStripEx2.Size = New System.Drawing.Size(210, 106)
			Me.toolStripEx2.TabIndex = 14
			Me.toolStripEx2.Text = "Editing"
			' 
			' toolStripPanelItem12
			' 
			Me.toolStripPanelItem12.CausesValidation = False
			Me.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem12.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem13, Me.toolStripPanelItem17, Me.toolStripPanelItem18})
			Me.toolStripPanelItem12.Name = "toolStripPanelItem12"
			Me.toolStripPanelItem12.RowCount = 1
			Me.toolStripPanelItem12.ShowItemToolTips = False
			Me.toolStripPanelItem12.Size = New System.Drawing.Size(173, 78)
			Me.toolStripPanelItem12.Text = "toolStripPanelItem12"
			Me.toolStripPanelItem12.Transparent = True
			' 
			' toolStripPanelItem13
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripPanelItem13, "U")
			Me.toolStripPanelItem13.CausesValidation = False
			Me.toolStripPanelItem13.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem13.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton6, Me.toolStripDropDownButton7, Me.toolStripDropDownButton8})
			Me.toolStripPanelItem13.Name = "toolStripPanelItem13"
			Me.toolStripPanelItem13.Size = New System.Drawing.Size(33, 73)
			Me.toolStripPanelItem13.Text = "toolStripPanelItem13"
			Me.toolStripPanelItem13.Transparent = True
			' 
			' toolStripDropDownButton6
			' 
			Me.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem39, Me.toolStripMenuItem40, Me.toolStripMenuItem41, Me.toolStripMenuItem42, Me.toolStripMenuItem43})
			Me.toolStripDropDownButton6.Image = (CType(resources.GetObject("toolStripDropDownButton6.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton6.Name = "toolStripDropDownButton6"
			Me.toolStripDropDownButton6.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton6.Text = "Sum"
			' 
			' toolStripMenuItem39
			' 
			Me.toolStripMenuItem39.Name = "toolStripMenuItem39"
			Me.toolStripMenuItem39.Size = New System.Drawing.Size(158, 22)
			Me.toolStripMenuItem39.Text = "Sum"
			' 
			' toolStripMenuItem40
			' 
			Me.toolStripMenuItem40.Name = "toolStripMenuItem40"
			Me.toolStripMenuItem40.Size = New System.Drawing.Size(158, 22)
			Me.toolStripMenuItem40.Text = "Average"
			' 
			' toolStripMenuItem41
			' 
			Me.toolStripMenuItem41.Name = "toolStripMenuItem41"
			Me.toolStripMenuItem41.Size = New System.Drawing.Size(158, 22)
			Me.toolStripMenuItem41.Text = "Count numbers"
			' 
			' toolStripMenuItem42
			' 
			Me.toolStripMenuItem42.Name = "toolStripMenuItem42"
			Me.toolStripMenuItem42.Size = New System.Drawing.Size(158, 22)
			Me.toolStripMenuItem42.Text = "Min"
			' 
			' toolStripMenuItem43
			' 
			Me.toolStripMenuItem43.Name = "toolStripMenuItem43"
			Me.toolStripMenuItem43.Size = New System.Drawing.Size(158, 22)
			Me.toolStripMenuItem43.Text = "Max"
			' 
			' toolStripDropDownButton7
			' 
			Me.toolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem44, Me.toolStripMenuItem45, Me.toolStripMenuItem46, Me.toolStripMenuItem47})
			Me.toolStripDropDownButton7.Image = (CType(resources.GetObject("toolStripDropDownButton7.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton7.Name = "toolStripDropDownButton7"
			Me.toolStripDropDownButton7.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton7.Text = "Fill"
			' 
			' toolStripMenuItem44
			' 
			Me.toolStripMenuItem44.Name = "toolStripMenuItem44"
			Me.toolStripMenuItem44.Size = New System.Drawing.Size(112, 22)
			Me.toolStripMenuItem44.Text = "Down"
			' 
			' toolStripMenuItem45
			' 
			Me.toolStripMenuItem45.Name = "toolStripMenuItem45"
			Me.toolStripMenuItem45.Size = New System.Drawing.Size(112, 22)
			Me.toolStripMenuItem45.Text = "Up"
			' 
			' toolStripMenuItem46
			' 
			Me.toolStripMenuItem46.Name = "toolStripMenuItem46"
			Me.toolStripMenuItem46.Size = New System.Drawing.Size(112, 22)
			Me.toolStripMenuItem46.Text = "Right"
			' 
			' toolStripMenuItem47
			' 
			Me.toolStripMenuItem47.Name = "toolStripMenuItem47"
			Me.toolStripMenuItem47.Size = New System.Drawing.Size(112, 22)
			Me.toolStripMenuItem47.Text = "Left"
			' 
			' toolStripDropDownButton8
			' 
			Me.toolStripDropDownButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem48, Me.toolStripMenuItem49, Me.toolStripMenuItem50, Me.toolStripMenuItem51})
			Me.toolStripDropDownButton8.Image = (CType(resources.GetObject("toolStripDropDownButton8.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton8.Name = "toolStripDropDownButton8"
			Me.toolStripDropDownButton8.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton8.Text = "Clear"
			' 
			' toolStripMenuItem48
			' 
			Me.toolStripMenuItem48.Name = "toolStripMenuItem48"
			Me.toolStripMenuItem48.Size = New System.Drawing.Size(163, 22)
			Me.toolStripMenuItem48.Text = "Clear All"
			' 
			' toolStripMenuItem49
			' 
			Me.toolStripMenuItem49.Name = "toolStripMenuItem49"
			Me.toolStripMenuItem49.Size = New System.Drawing.Size(163, 22)
			Me.toolStripMenuItem49.Text = "Clear Formats"
			' 
			' toolStripMenuItem50
			' 
			Me.toolStripMenuItem50.Name = "toolStripMenuItem50"
			Me.toolStripMenuItem50.Size = New System.Drawing.Size(163, 22)
			Me.toolStripMenuItem50.Text = "Clear Contents"
			' 
			' toolStripMenuItem51
			' 
			Me.toolStripMenuItem51.Name = "toolStripMenuItem51"
			Me.toolStripMenuItem51.Size = New System.Drawing.Size(163, 22)
			Me.toolStripMenuItem51.Text = "Clear Comments"
			' 
			' toolStripPanelItem17
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripPanelItem17, "S")
			Me.toolStripPanelItem17.AutoSize = False
			Me.toolStripPanelItem17.CausesValidation = False
			Me.toolStripPanelItem17.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem17.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton9})
			Me.toolStripPanelItem17.Name = "toolStripPanelItem17"
			Me.toolStripPanelItem17.Size = New System.Drawing.Size(65, 75)
			Me.toolStripPanelItem17.Text = "Sort & " & Constants.vbCrLf & "Filter"
			Me.toolStripPanelItem17.Transparent = True
			' 
			' toolStripDropDownButton9
			' 
			Me.toolStripDropDownButton9.AutoSize = False
			Me.toolStripDropDownButton9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem23, Me.toolStripMenuItem24, Me.toolStripMenuItem25, Me.toolStripMenuItem26})
			Me.toolStripDropDownButton9.Image = (CType(resources.GetObject("toolStripDropDownButton9.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton9.Name = "toolStripDropDownButton9"
			Me.toolStripDropDownButton9.Size = New System.Drawing.Size(60, 75)
			Me.toolStripDropDownButton9.Text = "Sort && " & Constants.vbCrLf & "Filter"
			Me.toolStripDropDownButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripMenuItem23
			' 
			Me.toolStripMenuItem23.Image = (CType(resources.GetObject("toolStripMenuItem23.Image"), System.Drawing.Image))
			Me.toolStripMenuItem23.Name = "toolStripMenuItem23"
			Me.toolStripMenuItem23.Size = New System.Drawing.Size(148, 22)
			Me.toolStripMenuItem23.Text = "Sort A-Z"
			' 
			' toolStripMenuItem24
			' 
			Me.toolStripMenuItem24.Image = (CType(resources.GetObject("toolStripMenuItem24.Image"), System.Drawing.Image))
			Me.toolStripMenuItem24.Name = "toolStripMenuItem24"
			Me.toolStripMenuItem24.Size = New System.Drawing.Size(148, 22)
			Me.toolStripMenuItem24.Text = "Sort Z-A"
			' 
			' toolStripMenuItem25
			' 
			Me.toolStripMenuItem25.Image = (CType(resources.GetObject("toolStripMenuItem25.Image"), System.Drawing.Image))
			Me.toolStripMenuItem25.Name = "toolStripMenuItem25"
			Me.toolStripMenuItem25.Size = New System.Drawing.Size(148, 22)
			Me.toolStripMenuItem25.Text = "Custom sorts"
			' 
			' toolStripMenuItem26
			' 
			Me.toolStripMenuItem26.Image = (CType(resources.GetObject("toolStripMenuItem26.Image"), System.Drawing.Image))
			Me.toolStripMenuItem26.Name = "toolStripMenuItem26"
			Me.toolStripMenuItem26.Size = New System.Drawing.Size(148, 22)
			Me.toolStripMenuItem26.Text = "Filter"
			' 
			' toolStripPanelItem18
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripPanelItem18, "FD")
			Me.toolStripPanelItem18.AutoSize = False
			Me.toolStripPanelItem18.CausesValidation = False
			Me.toolStripPanelItem18.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem18.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton10})
			Me.toolStripPanelItem18.Name = "toolStripPanelItem18"
			Me.toolStripPanelItem18.Size = New System.Drawing.Size(65, 75)
			Me.toolStripPanelItem18.Text = "Find &" & Constants.vbCrLf & "Select"
			Me.toolStripPanelItem18.ToolTipText = "Find & Select"
			Me.toolStripPanelItem18.Transparent = True
			' 
			' toolStripDropDownButton10
			' 
			Me.toolStripDropDownButton10.AutoSize = False
			Me.toolStripDropDownButton10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem53, Me.toolStripMenuItem54, Me.toolStripMenuItem55, Me.toolStripMenuItem56})
			Me.toolStripDropDownButton10.Image = (CType(resources.GetObject("toolStripDropDownButton10.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton10.Name = "toolStripDropDownButton10"
			Me.toolStripDropDownButton10.Size = New System.Drawing.Size(60, 75)
			Me.toolStripDropDownButton10.Text = "Find && " & Constants.vbCrLf & "Select"
			Me.toolStripDropDownButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.toolStripDropDownButton10.ToolTipText = "Find & Select"
			' 
			' toolStripMenuItem53
			' 
			Me.toolStripMenuItem53.Name = "toolStripMenuItem53"
			Me.toolStripMenuItem53.Size = New System.Drawing.Size(147, 22)
			Me.toolStripMenuItem53.Text = "&Find..."
			' 
			' toolStripMenuItem54
			' 
			Me.toolStripMenuItem54.Name = "toolStripMenuItem54"
			Me.toolStripMenuItem54.Size = New System.Drawing.Size(147, 22)
			Me.toolStripMenuItem54.Text = "&Replace..."
			' 
			' toolStripMenuItem55
			' 
			Me.toolStripMenuItem55.Name = "toolStripMenuItem55"
			Me.toolStripMenuItem55.Size = New System.Drawing.Size(147, 22)
			Me.toolStripMenuItem55.Text = "&Go to"
			' 
			' toolStripMenuItem56
			' 
			Me.toolStripMenuItem56.Name = "toolStripMenuItem56"
			Me.toolStripMenuItem56.Size = New System.Drawing.Size(147, 22)
			Me.toolStripMenuItem56.Text = "Go to &Special"
			' 
			' toolStripTabItem2
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem2, "I")
			Me.toolStripTabItem2.Name = "toolStripTabItem2"
			Me.toolStripTabItem2.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' excelRibbon.ribbonPanel2
			' 
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx28)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx5)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx7)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx6)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx8)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.tablesToolStripExt)
			Me.toolStripTabItem2.Panel.Name = "ribbonPanel2"
			Me.toolStripTabItem2.Panel.ScrollPosition = 0
			Me.toolStripTabItem2.Panel.TabIndex = 3
			Me.toolStripTabItem2.Panel.TabItem = Me.toolStripTabItem2
			Me.toolStripTabItem2.Panel.Text = "Insert"
			Me.toolStripTabItem2.Size = New System.Drawing.Size(50, 24)
			Me.toolStripTabItem2.Text = "Insert"
			' 
			' toolStripEx28
			' 
			Me.toolStripEx28.CollapsedDropDownButtonText = "Table"
			Me.toolStripEx28.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.toolStripEx28.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx28.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx28.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx28.Image = (CType(resources.GetObject("toolStripEx28.Image"), System.Drawing.Image))
			Me.toolStripEx28.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton51, Me.toolStripButton72})
			Me.toolStripEx28.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx28.Name = "toolStripEx28"
			Me.toolStripEx28.ShowItemToolTips = False
			Me.toolStripEx28.ShowLauncher = False
			Me.toolStripEx28.Size = New System.Drawing.Size(121, 106)
			Me.toolStripEx28.TabIndex = 10
			Me.toolStripEx28.Text = "Tables"
			' 
			' toolStripDropDownButton51
			' 
			Me.toolStripDropDownButton51.AutoSize = False
			Me.toolStripDropDownButton51.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem17, Me.toolStripMenuItem18})
			Me.toolStripDropDownButton51.Image = (CType(resources.GetObject("toolStripDropDownButton51.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton51.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.toolStripDropDownButton51.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton51.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton51.Name = "toolStripDropDownButton51"
			Me.toolStripDropDownButton51.Size = New System.Drawing.Size(65, 86)
			Me.toolStripDropDownButton51.Text = "Pivot" & Constants.vbCrLf & "Table"
			Me.toolStripDropDownButton51.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripMenuItem17
			' 
			Me.toolStripMenuItem17.Name = "toolStripMenuItem17"
			Me.toolStripMenuItem17.Size = New System.Drawing.Size(136, 22)
			Me.toolStripMenuItem17.Text = "Pivot&Table"
			' 
			' toolStripMenuItem18
			' 
			Me.toolStripMenuItem18.Name = "toolStripMenuItem18"
			Me.toolStripMenuItem18.Size = New System.Drawing.Size(136, 22)
			Me.toolStripMenuItem18.Text = "Pivot&Chart"
			' 
			' toolStripButton72
			' 
			Me.toolStripButton72.AutoSize = False
			Me.toolStripButton72.Image = (CType(resources.GetObject("toolStripButton72.Image"), System.Drawing.Image))
			Me.toolStripButton72.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton72.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton72.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
			Me.toolStripButton72.Name = "toolStripButton72"
			Me.toolStripButton72.Padding = New System.Windows.Forms.Padding(1)
			Me.toolStripButton72.Size = New System.Drawing.Size(50, 86)
			Me.toolStripButton72.Text = "Table"
			Me.toolStripButton72.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripEx5
			' 
			Me.toolStripEx5.AutoSize = False
			Me.toolStripEx5.CollapsedDropDownButtonText = "Illustrations"
			Me.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx5.Image = (CType(resources.GetObject("toolStripEx5.Image"), System.Drawing.Image))
			Me.toolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton5, Me.toolStripPanelItem19})
			Me.toolStripEx5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
			Me.toolStripEx5.Location = New System.Drawing.Point(121, 1)
			Me.toolStripEx5.Name = "toolStripEx5"
			Me.toolStripEx5.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx5.ShowItemToolTips = False
			Me.toolStripEx5.ShowLauncher = False
			Me.toolStripEx5.Size = New System.Drawing.Size(160, 106)
			Me.toolStripEx5.TabIndex = 6
			Me.toolStripEx5.Text = "Illustrations"
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(44, 76)
			Me.toolStripButton5.Text = "Picture"
			Me.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem19
			' 
			Me.toolStripPanelItem19.CausesValidation = False
			Me.toolStripPanelItem19.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem19.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton75, Me.toolStripDropDownButton11, Me.toolStripButton76})
			Me.toolStripPanelItem19.Name = "toolStripPanelItem19"
			Me.toolStripPanelItem19.ShowItemToolTips = False
			Me.toolStripPanelItem19.Size = New System.Drawing.Size(75, 79)
			Me.toolStripPanelItem19.Text = "toolStripPanelItem19"
			Me.toolStripPanelItem19.Transparent = True
			' 
			' toolStripButton75
			' 
			Me.toolStripButton75.Image = (CType(resources.GetObject("toolStripButton75.Image"), System.Drawing.Image))
			Me.toolStripButton75.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton75.Name = "toolStripButton75"
			Me.toolStripButton75.Size = New System.Drawing.Size(59, 20)
			Me.toolStripButton75.Text = "ClipArt"
			' 
			' toolStripDropDownButton11
			' 
			Me.toolStripDropDownButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.recentlyUsedShapesToolStripMenuItem, Me.linesToolStripMenuItem, Me.rectanglesToolStripMenuItem, Me.basicShapesToolStripMenuItem})
			Me.toolStripDropDownButton11.Image = (CType(resources.GetObject("toolStripDropDownButton11.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton11.Name = "toolStripDropDownButton11"
			Me.toolStripDropDownButton11.Size = New System.Drawing.Size(71, 20)
			Me.toolStripDropDownButton11.Text = "Shapes"
			' 
			' recentlyUsedShapesToolStripMenuItem
			' 
			Me.recentlyUsedShapesToolStripMenuItem.Name = "recentlyUsedShapesToolStripMenuItem"
			Me.recentlyUsedShapesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
			Me.recentlyUsedShapesToolStripMenuItem.Text = "Recently used shapes"
			' 
			' linesToolStripMenuItem
			' 
			Me.linesToolStripMenuItem.Name = "linesToolStripMenuItem"
			Me.linesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
			Me.linesToolStripMenuItem.Text = "Lines"
			' 
			' rectanglesToolStripMenuItem
			' 
			Me.rectanglesToolStripMenuItem.Name = "rectanglesToolStripMenuItem"
			Me.rectanglesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
			Me.rectanglesToolStripMenuItem.Text = "Rectangles"
			' 
			' basicShapesToolStripMenuItem
			' 
			Me.basicShapesToolStripMenuItem.Name = "basicShapesToolStripMenuItem"
			Me.basicShapesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
			Me.basicShapesToolStripMenuItem.Text = "Basic Shapes"
			' 
			' toolStripButton76
			' 
			Me.toolStripButton76.Image = (CType(resources.GetObject("toolStripButton76.Image"), System.Drawing.Image))
			Me.toolStripButton76.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton76.Name = "toolStripButton76"
			Me.toolStripButton76.Size = New System.Drawing.Size(70, 20)
			Me.toolStripButton76.Text = "SmartArt"
			' 
			' toolStripEx7
			' 
			Me.toolStripEx7.AutoSize = False
			Me.toolStripEx7.CollapsedDropDownButtonText = "Links"
			Me.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx7.Image = (CType(resources.GetObject("toolStripEx7.Image"), System.Drawing.Image))
			Me.toolStripEx7.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton77})
			Me.toolStripEx7.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.toolStripEx7.Location = New System.Drawing.Point(256, 1)
			Me.toolStripEx7.Name = "toolStripEx7"
			Me.toolStripEx7.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx7.ShowItemToolTips = False
			Me.toolStripEx7.Size = New System.Drawing.Size(100, 106)
			Me.toolStripEx7.TabIndex = 8
			Me.toolStripEx7.Text = "Links"
			' 
			' toolStripButton77
			' 
			Me.toolStripButton77.Image = (CType(resources.GetObject("toolStripButton77.Image"), System.Drawing.Image))
			Me.toolStripButton77.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton77.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton77.Name = "toolStripButton77"
			Me.toolStripButton77.Size = New System.Drawing.Size(60, 75)
			Me.toolStripButton77.Text = "Hyperlinks"
			Me.toolStripButton77.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.toolStripButton77.ToolTipText = "HyperLinks"
			' 
			' toolStripEx6
			' 
			Me.toolStripEx6.AutoSize = False
			Me.toolStripEx6.CollapsedDropDownButtonText = "Charts"
			Me.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx6.Image = (CType(resources.GetObject("toolStripEx6.Image"), System.Drawing.Image))
			Me.toolStripEx6.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton12, Me.toolStripPanelItem20})
			Me.toolStripEx6.Location = New System.Drawing.Point(331, 1)
			Me.toolStripEx6.Name = "toolStripEx6"
			Me.toolStripEx6.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx6.ShowItemToolTips = False
			Me.toolStripEx6.Size = New System.Drawing.Size(265, 106)
			Me.toolStripEx6.TabIndex = 7
			Me.toolStripEx6.Text = "Charts"
			' 
			' toolStripDropDownButton12
			' 
			Me.toolStripDropDownButton12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dToolStripMenuItem, Me.dColumnToolStripMenuItem, Me.coneToolStripMenuItem, Me.cylinderToolStripMenuItem, Me.pyramidToolStripMenuItem})
			Me.toolStripDropDownButton12.Image = (CType(resources.GetObject("toolStripDropDownButton12.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton12.Name = "toolStripDropDownButton12"
			Me.toolStripDropDownButton12.Size = New System.Drawing.Size(55, 75)
			Me.toolStripDropDownButton12.Text = "Column"
			Me.toolStripDropDownButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' dToolStripMenuItem
			' 
			Me.dToolStripMenuItem.Name = "dToolStripMenuItem"
			Me.dToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
			Me.dToolStripMenuItem.Text = "2-D Column"
			' 
			' dColumnToolStripMenuItem
			' 
			Me.dColumnToolStripMenuItem.Name = "dColumnToolStripMenuItem"
			Me.dColumnToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
			Me.dColumnToolStripMenuItem.Text = "3-D Column"
			' 
			' coneToolStripMenuItem
			' 
			Me.coneToolStripMenuItem.Name = "coneToolStripMenuItem"
			Me.coneToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
			Me.coneToolStripMenuItem.Text = "Cone"
			' 
			' cylinderToolStripMenuItem
			' 
			Me.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem"
			Me.cylinderToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
			Me.cylinderToolStripMenuItem.Text = "Cylinder"
			' 
			' pyramidToolStripMenuItem
			' 
			Me.pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem"
			Me.pyramidToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
			Me.pyramidToolStripMenuItem.Text = "Pyramid"
			' 
			' toolStripPanelItem20
			' 
			Me.toolStripPanelItem20.CausesValidation = False
			Me.toolStripPanelItem20.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem20.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton13, Me.toolStripDropDownButton14, Me.toolStripDropDownButton15, Me.toolStripDropDownButton16, Me.toolStripDropDownButton17, Me.toolStripDropDownButton18})
			Me.toolStripPanelItem20.Name = "toolStripPanelItem20"
			Me.toolStripPanelItem20.ShowItemToolTips = False
			Me.toolStripPanelItem20.Size = New System.Drawing.Size(158, 78)
			Me.toolStripPanelItem20.Text = "toolStripPanelItem20"
			Me.toolStripPanelItem20.Transparent = True
			' 
			' toolStripDropDownButton13
			' 
			Me.toolStripDropDownButton13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dLineToolStripMenuItem, Me.dLineToolStripMenuItem1})
			Me.toolStripDropDownButton13.Image = (CType(resources.GetObject("toolStripDropDownButton13.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton13.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton13.Name = "toolStripDropDownButton13"
			Me.toolStripDropDownButton13.Size = New System.Drawing.Size(55, 20)
			Me.toolStripDropDownButton13.Text = "Line"
			' 
			' dLineToolStripMenuItem
			' 
			Me.dLineToolStripMenuItem.Name = "dLineToolStripMenuItem"
			Me.dLineToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
			Me.dLineToolStripMenuItem.Text = "2-D Line"
			' 
			' dLineToolStripMenuItem1
			' 
			Me.dLineToolStripMenuItem1.Name = "dLineToolStripMenuItem1"
			Me.dLineToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
			Me.dLineToolStripMenuItem1.Text = "3-D Line"
			' 
			' toolStripDropDownButton14
			' 
			Me.toolStripDropDownButton14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dPieToolStripMenuItem, Me.dToolStripMenuItem1})
			Me.toolStripDropDownButton14.Image = (CType(resources.GetObject("toolStripDropDownButton14.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton14.Name = "toolStripDropDownButton14"
			Me.toolStripDropDownButton14.Size = New System.Drawing.Size(50, 20)
			Me.toolStripDropDownButton14.Text = "Pie"
			' 
			' dPieToolStripMenuItem
			' 
			Me.dPieToolStripMenuItem.Name = "dPieToolStripMenuItem"
			Me.dPieToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
			Me.dPieToolStripMenuItem.Text = "2-D Pie"
			' 
			' dToolStripMenuItem1
			' 
			Me.dToolStripMenuItem1.Name = "dToolStripMenuItem1"
			Me.dToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
			Me.dToolStripMenuItem1.Text = "3-D Pie"
			' 
			' toolStripDropDownButton15
			' 
			Me.toolStripDropDownButton15.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dBarToolStripMenuItem, Me.dBarToolStripMenuItem1})
			Me.toolStripDropDownButton15.Image = (CType(resources.GetObject("toolStripDropDownButton15.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton15.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton15.Name = "toolStripDropDownButton15"
			Me.toolStripDropDownButton15.Size = New System.Drawing.Size(52, 20)
			Me.toolStripDropDownButton15.Text = "Bar"
			' 
			' dBarToolStripMenuItem
			' 
			Me.dBarToolStripMenuItem.Name = "dBarToolStripMenuItem"
			Me.dBarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
			Me.dBarToolStripMenuItem.Text = "2-D Bar"
			' 
			' dBarToolStripMenuItem1
			' 
			Me.dBarToolStripMenuItem1.Name = "dBarToolStripMenuItem1"
			Me.dBarToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
			Me.dBarToolStripMenuItem1.Text = "3-D Bar"
			' 
			' toolStripDropDownButton16
			' 
			Me.toolStripDropDownButton16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dAreaToolStripMenuItem, Me.dAreaToolStripMenuItem1})
			Me.toolStripDropDownButton16.Image = (CType(resources.GetObject("toolStripDropDownButton16.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton16.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton16.Name = "toolStripDropDownButton16"
			Me.toolStripDropDownButton16.Size = New System.Drawing.Size(59, 20)
			Me.toolStripDropDownButton16.Text = "Area"
			' 
			' dAreaToolStripMenuItem
			' 
			Me.dAreaToolStripMenuItem.Name = "dAreaToolStripMenuItem"
			Me.dAreaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
			Me.dAreaToolStripMenuItem.Text = "2-D Area"
			' 
			' dAreaToolStripMenuItem1
			' 
			Me.dAreaToolStripMenuItem1.Name = "dAreaToolStripMenuItem1"
			Me.dAreaToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
			Me.dAreaToolStripMenuItem1.Text = "3-D Area"
			' 
			' toolStripDropDownButton17
			' 
			Me.toolStripDropDownButton17.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.otherScatterTypesToolStripMenuItem})
			Me.toolStripDropDownButton17.Image = (CType(resources.GetObject("toolStripDropDownButton17.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton17.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton17.Name = "toolStripDropDownButton17"
			Me.toolStripDropDownButton17.Size = New System.Drawing.Size(71, 20)
			Me.toolStripDropDownButton17.Text = "Scatter"
			' 
			' otherScatterTypesToolStripMenuItem
			' 
			Me.otherScatterTypesToolStripMenuItem.Name = "otherScatterTypesToolStripMenuItem"
			Me.otherScatterTypesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
			Me.otherScatterTypesToolStripMenuItem.Text = "Other Scatter Types.."
			' 
			' toolStripDropDownButton18
			' 
			Me.toolStripDropDownButton18.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.stockToolStripMenuItem, Me.surfaceToolStripMenuItem, Me.doughnutToolStripMenuItem, Me.bubbleToolStripMenuItem})
			Me.toolStripDropDownButton18.Image = (CType(resources.GetObject("toolStripDropDownButton18.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton18.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton18.Name = "toolStripDropDownButton18"
			Me.toolStripDropDownButton18.Size = New System.Drawing.Size(99, 20)
			Me.toolStripDropDownButton18.Text = "Other Charts"
			' 
			' stockToolStripMenuItem
			' 
			Me.stockToolStripMenuItem.Name = "stockToolStripMenuItem"
			Me.stockToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
			Me.stockToolStripMenuItem.Text = "Stock"
			' 
			' surfaceToolStripMenuItem
			' 
			Me.surfaceToolStripMenuItem.Name = "surfaceToolStripMenuItem"
			Me.surfaceToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
			Me.surfaceToolStripMenuItem.Text = "Surface"
			' 
			' doughnutToolStripMenuItem
			' 
			Me.doughnutToolStripMenuItem.Name = "doughnutToolStripMenuItem"
			Me.doughnutToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
			Me.doughnutToolStripMenuItem.Text = "Doughnut"
			' 
			' bubbleToolStripMenuItem
			' 
			Me.bubbleToolStripMenuItem.Name = "bubbleToolStripMenuItem"
			Me.bubbleToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
			Me.bubbleToolStripMenuItem.Text = "Bubble"
			' 
			' toolStripEx8
			' 
			Me.toolStripEx8.AutoSize = False
			Me.toolStripEx8.CollapsedDropDownButtonText = "Text"
			Me.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx8.Image = (CType(resources.GetObject("toolStripEx8.Image"), System.Drawing.Image))
			Me.toolStripEx8.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem21})
			Me.toolStripEx8.Location = New System.Drawing.Point(563, 1)
			Me.toolStripEx8.Name = "toolStripEx8"
			Me.toolStripEx8.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx8.ShowItemToolTips = False
			Me.toolStripEx8.Size = New System.Drawing.Size(255, 106)
			Me.toolStripEx8.TabIndex = 9
			Me.toolStripEx8.Text = "Text"
			' 
			' toolStripPanelItem21
			' 
			Me.toolStripPanelItem21.CausesValidation = False
			Me.toolStripPanelItem21.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem21.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton19, Me.toolStripButton10, Me.toolStripDropDownButton20, Me.toolStripDropDownButton21, Me.toolStripButton11, Me.toolStripButton12})
			Me.toolStripPanelItem21.Name = "toolStripPanelItem21"
			Me.toolStripPanelItem21.ShowItemToolTips = False
			Me.toolStripPanelItem21.Size = New System.Drawing.Size(208, 78)
			Me.toolStripPanelItem21.Text = "toolStripPanelItem21"
			Me.toolStripPanelItem21.Transparent = True
			' 
			' toolStripDropDownButton19
			' 
			Me.toolStripDropDownButton19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.horizontalTextBoxToolStripMenuItem, Me.verticalTextBoxToolStripMenuItem})
			Me.toolStripDropDownButton19.Image = (CType(resources.GetObject("toolStripDropDownButton19.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton19.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton19.Name = "toolStripDropDownButton19"
			Me.toolStripDropDownButton19.Size = New System.Drawing.Size(76, 20)
			Me.toolStripDropDownButton19.Text = "TextBox"
			' 
			' horizontalTextBoxToolStripMenuItem
			' 
			Me.horizontalTextBoxToolStripMenuItem.Name = "horizontalTextBoxToolStripMenuItem"
			Me.horizontalTextBoxToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.horizontalTextBoxToolStripMenuItem.Text = "&Horizontal TextBox"
			' 
			' verticalTextBoxToolStripMenuItem
			' 
			Me.verticalTextBoxToolStripMenuItem.Name = "verticalTextBoxToolStripMenuItem"
			Me.verticalTextBoxToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.verticalTextBoxToolStripMenuItem.Text = "&Vertical TextBox"
			' 
			' toolStripButton10
			' 
			Me.toolStripButton10.Image = (CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image))
			Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton10.Name = "toolStripButton10"
			Me.toolStripButton10.Size = New System.Drawing.Size(100, 20)
			Me.toolStripButton10.Text = "Header & Footer"
			' 
			' toolStripDropDownButton20
			' 
			Me.toolStripDropDownButton20.Image = (CType(resources.GetObject("toolStripDropDownButton20.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton20.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton20.Name = "toolStripDropDownButton20"
			Me.toolStripDropDownButton20.Size = New System.Drawing.Size(77, 20)
			Me.toolStripDropDownButton20.Text = "WordArt"
			' 
			' toolStripDropDownButton21
			' 
			Me.toolStripDropDownButton21.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.microsoftSignatureLinesToolStripMenuItem, Me.stampSignatureLineToolStripMenuItem})
			Me.toolStripDropDownButton21.Image = (CType(resources.GetObject("toolStripDropDownButton21.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton21.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton21.Name = "toolStripDropDownButton21"
			Me.toolStripDropDownButton21.Size = New System.Drawing.Size(104, 20)
			Me.toolStripDropDownButton21.Text = "Signature Line"
			' 
			' microsoftSignatureLinesToolStripMenuItem
			' 
			Me.microsoftSignatureLinesToolStripMenuItem.Name = "microsoftSignatureLinesToolStripMenuItem"
			Me.microsoftSignatureLinesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
			Me.microsoftSignatureLinesToolStripMenuItem.Text = "Microsoft Signature Lines.."
			' 
			' stampSignatureLineToolStripMenuItem
			' 
			Me.stampSignatureLineToolStripMenuItem.Name = "stampSignatureLineToolStripMenuItem"
			Me.stampSignatureLineToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
			Me.stampSignatureLineToolStripMenuItem.Text = "Stamp Signature Line"
			' 
			' toolStripButton11
			' 
			Me.toolStripButton11.Image = (CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image))
			Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton11.Name = "toolStripButton11"
			Me.toolStripButton11.Size = New System.Drawing.Size(59, 20)
			Me.toolStripButton11.Text = "Object"
			' 
			' toolStripButton12
			' 
			Me.toolStripButton12.Image = (CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image))
			Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton12.Name = "toolStripButton12"
			Me.toolStripButton12.Size = New System.Drawing.Size(66, 20)
			Me.toolStripButton12.Text = "Symbols"
			' 
			' tablesToolStripExt
			' 
			Me.tablesToolStripExt.CollapsedDropDownButtonText = "Table"
			Me.tablesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.tablesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.tablesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.tablesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.tablesToolStripExt.Image = (CType(resources.GetObject("tablesToolStripExt.Image"), System.Drawing.Image))
			Me.tablesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.tableToolStripDropDwnBtn})
			Me.tablesToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
			Me.tablesToolStripExt.Location = New System.Drawing.Point(794, 1)
			Me.tablesToolStripExt.Name = "tablesToolStripExt"
			Me.tablesToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.tablesToolStripExt.ShowLauncher = False
			Me.tablesToolStripExt.Size = New System.Drawing.Size(133, 106)
			Me.tablesToolStripExt.TabIndex = 5
			Me.tablesToolStripExt.Text = "Tables"
			Me.tablesToolStripExt.Visible = False
			' 
			' tableToolStripDropDwnBtn
			' 
			Me.tableToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.insertTableToolStripMenuItem, Me.drawTableToolStripMenuItem, Me.convertTextToTableToolStripMenuItem, Me.excelSpreadsheetToolStripMenuItem, Me.quickTablesToolStripMenuItem})
			Me.tableToolStripDropDwnBtn.Image = (CType(resources.GetObject("tableToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.tableToolStripDropDwnBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.tableToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.tableToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tableToolStripDropDwnBtn.Name = "tableToolStripDropDwnBtn"
			Me.tableToolStripDropDwnBtn.Size = New System.Drawing.Size(71, 76)
			Me.tableToolStripDropDwnBtn.Text = "Pivot table"
			Me.tableToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' insertTableToolStripMenuItem
			' 
			Me.insertTableToolStripMenuItem.Name = "insertTableToolStripMenuItem"
			Me.insertTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
			Me.insertTableToolStripMenuItem.Text = "&Insert Table..."
			' 
			' drawTableToolStripMenuItem
			' 
			Me.drawTableToolStripMenuItem.Name = "drawTableToolStripMenuItem"
			Me.drawTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
			Me.drawTableToolStripMenuItem.Text = "&Draw Table"
			' 
			' convertTextToTableToolStripMenuItem
			' 
			Me.convertTextToTableToolStripMenuItem.Name = "convertTextToTableToolStripMenuItem"
			Me.convertTextToTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
			Me.convertTextToTableToolStripMenuItem.Text = "Conv&ert Text to Table..."
			' 
			' excelSpreadsheetToolStripMenuItem
			' 
			Me.excelSpreadsheetToolStripMenuItem.Name = "excelSpreadsheetToolStripMenuItem"
			Me.excelSpreadsheetToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
			Me.excelSpreadsheetToolStripMenuItem.Text = "E&xcel Spreadsheet"
			' 
			' quickTablesToolStripMenuItem
			' 
			Me.quickTablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.saveSelectionToQuickTablToolStripMenuItem})
			Me.quickTablesToolStripMenuItem.Name = "quickTablesToolStripMenuItem"
			Me.quickTablesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
			Me.quickTablesToolStripMenuItem.Text = "Quick &Tables"
			' 
			' saveSelectionToQuickTablToolStripMenuItem
			' 
			Me.saveSelectionToQuickTablToolStripMenuItem.Enabled = False
			Me.saveSelectionToQuickTablToolStripMenuItem.Name = "saveSelectionToQuickTablToolStripMenuItem"
			Me.saveSelectionToQuickTablToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
			Me.saveSelectionToQuickTablToolStripMenuItem.Text = "&Save Selection to Quick Tables Gallery..."
			' 
			' toolStripTabItem3
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem3, "P")
			Me.toolStripTabItem3.Name = "toolStripTabItem3"
			Me.toolStripTabItem3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' excelRibbon.ribbonPanel3
			' 
			Me.toolStripTabItem3.Panel.Controls.Add(Me.themesToolStripExt)
			Me.toolStripTabItem3.Panel.Controls.Add(Me.pageSetupToolStripExt)
			Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx4)
			Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx9)
			Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx10)
			Me.toolStripTabItem3.Panel.Name = "ribbonPanel3"
			Me.toolStripTabItem3.Panel.ScrollPosition = 0
			Me.toolStripTabItem3.Panel.TabIndex = 4
			Me.toolStripTabItem3.Panel.TabItem = Me.toolStripTabItem3
			Me.toolStripTabItem3.Panel.Text = "Page Layout"
			Me.toolStripTabItem3.Size = New System.Drawing.Size(81, 24)
			Me.toolStripTabItem3.Text = "Page Layout"
			' 
			' themesToolStripExt
			' 
			Me.themesToolStripExt.CollapsedDropDownButtonText = "Themes"
			Me.themesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.themesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.themesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.themesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.themesToolStripExt.Image = (CType(resources.GetObject("themesToolStripExt.Image"), System.Drawing.Image))
			Me.themesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.themesToolStripDropDwnBtn, Me.toolStripPanelItem22})
			Me.themesToolStripExt.Location = New System.Drawing.Point(0, 1)
			Me.themesToolStripExt.Name = "themesToolStripExt"
			Me.themesToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.themesToolStripExt.ShowItemToolTips = False
			Me.themesToolStripExt.ShowLauncher = False
			Me.themesToolStripExt.Size = New System.Drawing.Size(110, 106)
			Me.themesToolStripExt.TabIndex = 3
			Me.themesToolStripExt.Text = "Themes"
			' 
			' themesToolStripDropDwnBtn
			' 
			Me.themesToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.resetToThemeFromTemplateToolStripMenuItem, Me.searchOfficeOnlineToolStripMenuItem, Me.browseForThemesToolStripMenuItem, Me.saveCurrentThemeToolStripMenuItem})
			Me.themesToolStripDropDwnBtn.Image = (CType(resources.GetObject("themesToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.themesToolStripDropDwnBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.themesToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.themesToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.themesToolStripDropDwnBtn.Name = "themesToolStripDropDwnBtn"
			Me.themesToolStripDropDwnBtn.Size = New System.Drawing.Size(57, 76)
			Me.themesToolStripDropDwnBtn.Text = "Themes"
			Me.themesToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' resetToThemeFromTemplateToolStripMenuItem
			' 
			Me.resetToThemeFromTemplateToolStripMenuItem.Name = "resetToThemeFromTemplateToolStripMenuItem"
			Me.resetToThemeFromTemplateToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
			Me.resetToThemeFromTemplateToolStripMenuItem.Text = "&Reset to Theme from Template"
			' 
			' searchOfficeOnlineToolStripMenuItem
			' 
			Me.searchOfficeOnlineToolStripMenuItem.Name = "searchOfficeOnlineToolStripMenuItem"
			Me.searchOfficeOnlineToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
			Me.searchOfficeOnlineToolStripMenuItem.Text = "Search &Office Online..."
			' 
			' browseForThemesToolStripMenuItem
			' 
			Me.browseForThemesToolStripMenuItem.Name = "browseForThemesToolStripMenuItem"
			Me.browseForThemesToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
			Me.browseForThemesToolStripMenuItem.Text = "&Browse for Themes..."
			' 
			' saveCurrentThemeToolStripMenuItem
			' 
			Me.saveCurrentThemeToolStripMenuItem.Name = "saveCurrentThemeToolStripMenuItem"
			Me.saveCurrentThemeToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
			Me.saveCurrentThemeToolStripMenuItem.Text = "S&ave Current Theme..."
			' 
			' toolStripPanelItem22
			' 
			Me.toolStripPanelItem22.AutoSize = False
			Me.toolStripPanelItem22.CausesValidation = False
			Me.toolStripPanelItem22.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem22.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.themeColorToolStripDropDwnBtn, Me.themeFontToolStripDropDwnBtn, Me.themeEffectsToolStripDropDwnBtn})
			Me.toolStripPanelItem22.Name = "toolStripPanelItem22"
			Me.toolStripPanelItem22.ShowItemToolTips = False
			Me.toolStripPanelItem22.Size = New System.Drawing.Size(29, 72)
			Me.toolStripPanelItem22.Text = "toolStripPanelItem13"
			Me.toolStripPanelItem22.Transparent = True
			' 
			' themeColorToolStripDropDwnBtn
			' 
			Me.themeColorToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.themeColorToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.createNewThemeColorsToolStripMenuItem1})
			Me.themeColorToolStripDropDwnBtn.Image = (CType(resources.GetObject("themeColorToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.themeColorToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.themeColorToolStripDropDwnBtn.Name = "themeColorToolStripDropDwnBtn"
			Me.themeColorToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
			Me.themeColorToolStripDropDwnBtn.Text = "themeColorToolStripDropDwnBtn"
			Me.themeColorToolStripDropDwnBtn.ToolTipText = "Color"
			' 
			' createNewThemeColorsToolStripMenuItem1
			' 
			Me.createNewThemeColorsToolStripMenuItem1.Name = "createNewThemeColorsToolStripMenuItem1"
			Me.createNewThemeColorsToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
			Me.createNewThemeColorsToolStripMenuItem1.Text = "&Create New Theme Colors..."
			' 
			' themeFontToolStripDropDwnBtn
			' 
			Me.themeFontToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.themeFontToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.createNewThemeFontsToolStripMenuItem1})
			Me.themeFontToolStripDropDwnBtn.Image = (CType(resources.GetObject("themeFontToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.themeFontToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.themeFontToolStripDropDwnBtn.Name = "themeFontToolStripDropDwnBtn"
			Me.themeFontToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
			Me.themeFontToolStripDropDwnBtn.Text = "themeFontToolStripDropDwnBtn"
			Me.themeFontToolStripDropDwnBtn.ToolTipText = "Font"
			' 
			' createNewThemeFontsToolStripMenuItem1
			' 
			Me.createNewThemeFontsToolStripMenuItem1.Name = "createNewThemeFontsToolStripMenuItem1"
			Me.createNewThemeFontsToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
			Me.createNewThemeFontsToolStripMenuItem1.Text = "&Create New Theme Fonts..."
			' 
			' themeEffectsToolStripDropDwnBtn
			' 
			Me.themeEffectsToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.themeEffectsToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.officeToolStripMenuItem, Me.apexToolStripMenuItem})
			Me.themeEffectsToolStripDropDwnBtn.Image = (CType(resources.GetObject("themeEffectsToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.themeEffectsToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.themeEffectsToolStripDropDwnBtn.Name = "themeEffectsToolStripDropDwnBtn"
			Me.themeEffectsToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
			Me.themeEffectsToolStripDropDwnBtn.Text = "themeEffectsToolStripDropDwnBtn"
			Me.themeEffectsToolStripDropDwnBtn.ToolTipText = "Themes effects"
			' 
			' officeToolStripMenuItem
			' 
			Me.officeToolStripMenuItem.Name = "officeToolStripMenuItem"
			Me.officeToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
			Me.officeToolStripMenuItem.Text = "Office"
			' 
			' apexToolStripMenuItem
			' 
			Me.apexToolStripMenuItem.Name = "apexToolStripMenuItem"
			Me.apexToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
			Me.apexToolStripMenuItem.Text = "Apex"
			' 
			' pageSetupToolStripExt
			' 
			Me.pageSetupToolStripExt.CollapsedDropDownButtonText = "Page Setup"
			Me.pageSetupToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.pageSetupToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.pageSetupToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.pageSetupToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.pageSetupToolStripExt.Image = (CType(resources.GetObject("pageSetupToolStripExt.Image"), System.Drawing.Image))
			Me.pageSetupToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.marginToolStripDropDwnBtn, Me.toolStripPanelItem44, Me.toolStripPanelItem23})
			Me.pageSetupToolStripExt.Location = New System.Drawing.Point(110, 1)
			Me.pageSetupToolStripExt.Name = "pageSetupToolStripExt"
			Me.pageSetupToolStripExt.Padding = New System.Windows.Forms.Padding(5)
			Me.pageSetupToolStripExt.ShowItemToolTips = False
			Me.pageSetupToolStripExt.Size = New System.Drawing.Size(312, 106)
			Me.pageSetupToolStripExt.TabIndex = 2
			Me.pageSetupToolStripExt.Text = "Page Setup"
			' 
			' marginToolStripDropDwnBtn
			' 
			Me.marginToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.customMarginsToolStripMenuItem, Me.wideToolStripMenuItem, Me.narrowToolStripMenuItem, Me.customMarginsToolStripMenuItem1})
			Me.marginToolStripDropDwnBtn.Image = (CType(resources.GetObject("marginToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.marginToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.marginToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.marginToolStripDropDwnBtn.Name = "marginToolStripDropDwnBtn"
			Me.marginToolStripDropDwnBtn.Size = New System.Drawing.Size(57, 75)
			Me.marginToolStripDropDwnBtn.Text = "Margins"
			Me.marginToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' customMarginsToolStripMenuItem
			' 
			Me.customMarginsToolStripMenuItem.Name = "customMarginsToolStripMenuItem"
			Me.customMarginsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.customMarginsToolStripMenuItem.Text = "Normal"
			' 
			' wideToolStripMenuItem
			' 
			Me.wideToolStripMenuItem.Name = "wideToolStripMenuItem"
			Me.wideToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.wideToolStripMenuItem.Text = "Wide"
			' 
			' narrowToolStripMenuItem
			' 
			Me.narrowToolStripMenuItem.Name = "narrowToolStripMenuItem"
			Me.narrowToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.narrowToolStripMenuItem.Text = "Narrow"
			' 
			' customMarginsToolStripMenuItem1
			' 
			Me.customMarginsToolStripMenuItem1.Name = "customMarginsToolStripMenuItem1"
			Me.customMarginsToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
			Me.customMarginsToolStripMenuItem1.Text = "Custom M&argins..."
			' 
			' toolStripPanelItem44
			' 
			Me.toolStripPanelItem44.CausesValidation = False
			Me.toolStripPanelItem44.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem44.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.orientationToolStripDropDwnBtn, Me.sizeToolStripDropDwnBtn, Me.columnsToolStripDropDwnBtn})
			Me.toolStripPanelItem44.Name = "toolStripPanelItem44"
			Me.toolStripPanelItem44.ShowItemToolTips = False
			Me.toolStripPanelItem44.Size = New System.Drawing.Size(94, 78)
			Me.toolStripPanelItem44.Text = "toolStripPanelItem44"
			Me.toolStripPanelItem44.Transparent = True
			' 
			' orientationToolStripDropDwnBtn
			' 
			Me.orientationToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.portraitToolStripMenuItem, Me.landscapeToolStripMenuItem})
			Me.orientationToolStripDropDwnBtn.Image = (CType(resources.GetObject("orientationToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.orientationToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.orientationToolStripDropDwnBtn.Name = "orientationToolStripDropDwnBtn"
			Me.orientationToolStripDropDwnBtn.Size = New System.Drawing.Size(90, 20)
			Me.orientationToolStripDropDwnBtn.Text = "Orientation"
			' 
			' portraitToolStripMenuItem
			' 
			Me.portraitToolStripMenuItem.Name = "portraitToolStripMenuItem"
			Me.portraitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
			Me.portraitToolStripMenuItem.Text = "Portrait"
			' 
			' landscapeToolStripMenuItem
			' 
			Me.landscapeToolStripMenuItem.Name = "landscapeToolStripMenuItem"
			Me.landscapeToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
			Me.landscapeToolStripMenuItem.Text = "Landscape"
			' 
			' sizeToolStripDropDwnBtn
			' 
			Me.sizeToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.morePaperSizesToolStripMenuItem})
			Me.sizeToolStripDropDwnBtn.Image = (CType(resources.GetObject("sizeToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.sizeToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.sizeToolStripDropDwnBtn.Name = "sizeToolStripDropDwnBtn"
			Me.sizeToolStripDropDwnBtn.Size = New System.Drawing.Size(55, 20)
			Me.sizeToolStripDropDwnBtn.Text = "Size"
			' 
			' morePaperSizesToolStripMenuItem
			' 
			Me.morePaperSizesToolStripMenuItem.Name = "morePaperSizesToolStripMenuItem"
			Me.morePaperSizesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
			Me.morePaperSizesToolStripMenuItem.Text = "More P&aper Sizes..."
			' 
			' columnsToolStripDropDwnBtn
			' 
			Me.columnsToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.moreColumnsToolStripMenuItem})
			Me.columnsToolStripDropDwnBtn.Image = (CType(resources.GetObject("columnsToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.columnsToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.columnsToolStripDropDwnBtn.Name = "columnsToolStripDropDwnBtn"
			Me.columnsToolStripDropDwnBtn.Size = New System.Drawing.Size(76, 20)
			Me.columnsToolStripDropDwnBtn.Text = "Columns"
			' 
			' moreColumnsToolStripMenuItem
			' 
			Me.moreColumnsToolStripMenuItem.Name = "moreColumnsToolStripMenuItem"
			Me.moreColumnsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
			Me.moreColumnsToolStripMenuItem.Text = "More &Columns..."
			' 
			' toolStripPanelItem23
			' 
			Me.toolStripPanelItem23.CausesValidation = False
			Me.toolStripPanelItem23.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem23.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.breaksToolStripDropDwnBtn, Me.lnumbersToolStripDropDwnBtn, Me.hyphenationToolStripDropDwnBtn})
			Me.toolStripPanelItem23.Name = "toolStripPanelItem23"
			Me.toolStripPanelItem23.ShowItemToolTips = False
			Me.toolStripPanelItem23.Size = New System.Drawing.Size(104, 78)
			Me.toolStripPanelItem23.Text = "toolStripPanelItem14"
			Me.toolStripPanelItem23.Transparent = True
			' 
			' breaksToolStripDropDwnBtn
			' 
			Me.breaksToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.inToolStripMenuItem, Me.removePageBreakToolStripMenuItem})
			Me.breaksToolStripDropDwnBtn.Image = (CType(resources.GetObject("breaksToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.breaksToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.breaksToolStripDropDwnBtn.Name = "breaksToolStripDropDwnBtn"
			Me.breaksToolStripDropDwnBtn.Size = New System.Drawing.Size(68, 20)
			Me.breaksToolStripDropDwnBtn.Text = "Breaks"
			' 
			' inToolStripMenuItem
			' 
			Me.inToolStripMenuItem.Name = "inToolStripMenuItem"
			Me.inToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.inToolStripMenuItem.Text = "&Insert Page Break"
			' 
			' removePageBreakToolStripMenuItem
			' 
			Me.removePageBreakToolStripMenuItem.Name = "removePageBreakToolStripMenuItem"
			Me.removePageBreakToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.removePageBreakToolStripMenuItem.Text = "&Remove Page Break"
			' 
			' lnumbersToolStripDropDwnBtn
			' 
			Me.lnumbersToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.noneToolStripMenuItem, Me.continuousToolStripMenuItem, Me.restartEachPageToolStripMenuItem, Me.restartEachSectionToolStripMenuItem, Me.suppressForCurrentSectionToolStripMenuItem, Me.toolStripSeparator11, Me.moreLineNumberingToolStripMenuItem})
			Me.lnumbersToolStripDropDwnBtn.Image = (CType(resources.GetObject("lnumbersToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.lnumbersToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.lnumbersToolStripDropDwnBtn.Name = "lnumbersToolStripDropDwnBtn"
			Me.lnumbersToolStripDropDwnBtn.Size = New System.Drawing.Size(100, 20)
			Me.lnumbersToolStripDropDwnBtn.Text = "Line Numbers"
			' 
			' noneToolStripMenuItem
			' 
			Me.noneToolStripMenuItem.Checked = True
			Me.noneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.noneToolStripMenuItem.Name = "noneToolStripMenuItem"
			Me.noneToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.noneToolStripMenuItem.Text = "&None"
			' 
			' continuousToolStripMenuItem
			' 
			Me.continuousToolStripMenuItem.Name = "continuousToolStripMenuItem"
			Me.continuousToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.continuousToolStripMenuItem.Text = "&Continuous"
			' 
			' restartEachPageToolStripMenuItem
			' 
			Me.restartEachPageToolStripMenuItem.Name = "restartEachPageToolStripMenuItem"
			Me.restartEachPageToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.restartEachPageToolStripMenuItem.Text = "&Restart Each Page"
			' 
			' restartEachSectionToolStripMenuItem
			' 
			Me.restartEachSectionToolStripMenuItem.Name = "restartEachSectionToolStripMenuItem"
			Me.restartEachSectionToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.restartEachSectionToolStripMenuItem.Text = "R&estart Each Section"
			' 
			' suppressForCurrentSectionToolStripMenuItem
			' 
			Me.suppressForCurrentSectionToolStripMenuItem.Name = "suppressForCurrentSectionToolStripMenuItem"
			Me.suppressForCurrentSectionToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.suppressForCurrentSectionToolStripMenuItem.Text = "&Suppress for Current Section"
			' 
			' toolStripSeparator11
			' 
			Me.toolStripSeparator11.Name = "toolStripSeparator11"
			Me.toolStripSeparator11.Size = New System.Drawing.Size(221, 6)
			' 
			' moreLineNumberingToolStripMenuItem
			' 
			Me.moreLineNumberingToolStripMenuItem.Name = "moreLineNumberingToolStripMenuItem"
			Me.moreLineNumberingToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
			Me.moreLineNumberingToolStripMenuItem.Text = "&More Line Numbering..."
			' 
			' hyphenationToolStripDropDwnBtn
			' 
			Me.hyphenationToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.noneToolStripMenuItem1, Me.automaticToolStripMenuItem2, Me.manualToolStripMenuItem, Me.toolStripSeparator12, Me.hyphenationOptionsToolStripMenuItem})
			Me.hyphenationToolStripDropDwnBtn.Image = (CType(resources.GetObject("hyphenationToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.hyphenationToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.hyphenationToolStripDropDwnBtn.Name = "hyphenationToolStripDropDwnBtn"
			Me.hyphenationToolStripDropDwnBtn.Size = New System.Drawing.Size(97, 20)
			Me.hyphenationToolStripDropDwnBtn.Text = "Hyphenation"
			' 
			' noneToolStripMenuItem1
			' 
			Me.noneToolStripMenuItem1.Checked = True
			Me.noneToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.noneToolStripMenuItem1.Name = "noneToolStripMenuItem1"
			Me.noneToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
			Me.noneToolStripMenuItem1.Text = "&None"
			' 
			' automaticToolStripMenuItem2
			' 
			Me.automaticToolStripMenuItem2.Name = "automaticToolStripMenuItem2"
			Me.automaticToolStripMenuItem2.Size = New System.Drawing.Size(198, 22)
			Me.automaticToolStripMenuItem2.Text = "A&utomatic"
			' 
			' manualToolStripMenuItem
			' 
			Me.manualToolStripMenuItem.Name = "manualToolStripMenuItem"
			Me.manualToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
			Me.manualToolStripMenuItem.Text = "&Manual"
			' 
			' toolStripSeparator12
			' 
			Me.toolStripSeparator12.Name = "toolStripSeparator12"
			Me.toolStripSeparator12.Size = New System.Drawing.Size(195, 6)
			' 
			' hyphenationOptionsToolStripMenuItem
			' 
			Me.hyphenationOptionsToolStripMenuItem.Name = "hyphenationOptionsToolStripMenuItem"
			Me.hyphenationOptionsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
			Me.hyphenationOptionsToolStripMenuItem.Text = "&Hyphenation Options..."
			' 
			' toolStripEx4
			' 
			Me.toolStripEx4.AutoSize = False
			Me.toolStripEx4.CollapsedDropDownButtonText = "Scaling"
			Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx4.Image = (CType(resources.GetObject("toolStripEx4.Image"), System.Drawing.Image))
			Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem24})
			Me.toolStripEx4.Location = New System.Drawing.Point(388, 1)
			Me.toolStripEx4.Name = "toolStripEx4"
			Me.toolStripEx4.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx4.ShowItemToolTips = False
			Me.toolStripEx4.Size = New System.Drawing.Size(185, 106)
			Me.toolStripEx4.TabIndex = 4
			Me.toolStripEx4.Text = "Scale To Fit"
			' 
			' toolStripPanelItem24
			' 
			Me.toolStripPanelItem24.CausesValidation = False
			Me.toolStripPanelItem24.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem24.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem14, Me.toolStripPanelItem16, Me.toolStripPanelItem25})
			Me.toolStripPanelItem24.Name = "toolStripPanelItem24"
			Me.toolStripPanelItem24.ShowItemToolTips = False
			Me.toolStripPanelItem24.Size = New System.Drawing.Size(146, 78)
			Me.toolStripPanelItem24.Text = "toolStripPanelItem24"
			Me.toolStripPanelItem24.Transparent = True
			' 
			' toolStripPanelItem14
			' 
			Me.toolStripPanelItem14.CausesValidation = False
			Me.toolStripPanelItem14.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem14.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel20, Me.toolStripComboBox3})
			Me.toolStripPanelItem14.Name = "toolStripPanelItem14"
			Me.toolStripPanelItem14.RowCount = 1
			Me.toolStripPanelItem14.Size = New System.Drawing.Size(140, 25)
			Me.toolStripPanelItem14.Text = "toolStripPanelItem14"
			Me.toolStripPanelItem14.Transparent = True
			' 
			' toolStripLabel20
			' 
			Me.toolStripLabel20.Image = (CType(resources.GetObject("toolStripLabel20.Image"), System.Drawing.Image))
			Me.toolStripLabel20.Name = "toolStripLabel20"
			Me.toolStripLabel20.Size = New System.Drawing.Size(51, 16)
			Me.toolStripLabel20.Text = "Width"
			Me.toolStripLabel20.ToolTipText = "Width"
			' 
			' toolStripComboBox3
			' 
			Me.toolStripComboBox3.DropDownWidth = 80
			Me.toolStripComboBox3.Margin = New System.Windows.Forms.Padding(4, 0, 1, 0)
			Me.toolStripComboBox3.Name = "toolStripComboBox3"
			Me.toolStripComboBox3.Size = New System.Drawing.Size(80, 21)
			' 
			' toolStripPanelItem16
			' 
			Me.toolStripPanelItem16.CausesValidation = False
			Me.toolStripPanelItem16.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem16.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel21, Me.toolStripComboBox2})
			Me.toolStripPanelItem16.Name = "toolStripPanelItem16"
			Me.toolStripPanelItem16.RowCount = 1
			Me.toolStripPanelItem16.Size = New System.Drawing.Size(140, 25)
			Me.toolStripPanelItem16.Text = "toolStripPanelItem16"
			Me.toolStripPanelItem16.Transparent = True
			' 
			' toolStripLabel21
			' 
			Me.toolStripLabel21.Image = (CType(resources.GetObject("toolStripLabel21.Image"), System.Drawing.Image))
			Me.toolStripLabel21.Name = "toolStripLabel21"
			Me.toolStripLabel21.Size = New System.Drawing.Size(54, 16)
			Me.toolStripLabel21.Text = "Height"
			' 
			' toolStripComboBox2
			' 
			Me.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripComboBox2.DropDownWidth = 120
			Me.toolStripComboBox2.Name = "toolStripComboBox2"
			Me.toolStripComboBox2.Size = New System.Drawing.Size(80, 21)
			' 
			' toolStripPanelItem25
			' 
			Me.toolStripPanelItem25.CausesValidation = False
			Me.toolStripPanelItem25.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem25.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel1, Me.toolStripComboBox1})
			Me.toolStripPanelItem25.Name = "toolStripPanelItem25"
			Me.toolStripPanelItem25.RowCount = 1
			Me.toolStripPanelItem25.Size = New System.Drawing.Size(140, 25)
			Me.toolStripPanelItem25.Text = "toolStripPanelItem25"
			Me.toolStripPanelItem25.Transparent = True
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Image = (CType(resources.GetObject("toolStripLabel1.Image"), System.Drawing.Image))
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(48, 16)
			Me.toolStripLabel1.Text = "Scale"
			' 
			' toolStripComboBox1
			' 
			Me.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripComboBox1.Margin = New System.Windows.Forms.Padding(7, 0, 1, 0)
			Me.toolStripComboBox1.Name = "toolStripComboBox1"
			Me.toolStripComboBox1.Size = New System.Drawing.Size(80, 21)
			Me.toolStripComboBox1.ToolTipText = "Scale"
			' 
			' toolStripEx9
			' 
			Me.toolStripEx9.AutoSize = False
			Me.toolStripEx9.CollapsedDropDownButtonText = "Sheet"
			Me.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx9.Image = (CType(resources.GetObject("toolStripEx9.Image"), System.Drawing.Image))
			Me.toolStripEx9.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem26, Me.toolStripPanelItem27})
			Me.toolStripEx9.Location = New System.Drawing.Point(553, 1)
			Me.toolStripEx9.Name = "toolStripEx9"
			Me.toolStripEx9.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx9.ShowItemToolTips = False
			Me.toolStripEx9.Size = New System.Drawing.Size(156, 106)
			Me.toolStripEx9.TabIndex = 5
			Me.toolStripEx9.Text = "Sheet Options"
			' 
			' toolStripPanelItem26
			' 
			Me.toolStripPanelItem26.CausesValidation = False
			Me.toolStripPanelItem26.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem26.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel2, Me.toolStripLabel3, Me.toolStripLabel4})
			Me.toolStripPanelItem26.Name = "toolStripPanelItem26"
			Me.toolStripPanelItem26.ShowItemToolTips = False
			Me.toolStripPanelItem26.Size = New System.Drawing.Size(54, 78)
			Me.toolStripPanelItem26.Text = "toolStripPanelItem26"
			Me.toolStripPanelItem26.Transparent = True
			' 
			' toolStripLabel2
			' 
			Me.toolStripLabel2.Name = "toolStripLabel2"
			Me.toolStripLabel2.Size = New System.Drawing.Size(50, 13)
			Me.toolStripLabel2.Text = "GridLines"
			Me.toolStripLabel2.ToolTipText = "Grilines"
			' 
			' toolStripLabel3
			' 
			Me.toolStripLabel3.Image = (CType(resources.GetObject("toolStripLabel3.Image"), System.Drawing.Image))
			Me.toolStripLabel3.Name = "toolStripLabel3"
			Me.toolStripLabel3.Size = New System.Drawing.Size(45, 16)
			Me.toolStripLabel3.Text = "View"
			Me.toolStripLabel3.ToolTipText = "View"
			' 
			' toolStripLabel4
			' 
			Me.toolStripLabel4.Image = (CType(resources.GetObject("toolStripLabel4.Image"), System.Drawing.Image))
			Me.toolStripLabel4.Name = "toolStripLabel4"
			Me.toolStripLabel4.Size = New System.Drawing.Size(45, 16)
			Me.toolStripLabel4.Text = "Print"
			Me.toolStripLabel4.ToolTipText = "Print"
			' 
			' toolStripPanelItem27
			' 
			Me.toolStripPanelItem27.CausesValidation = False
			Me.toolStripPanelItem27.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem27.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel5, Me.toolStripLabel6, Me.toolStripLabel7})
			Me.toolStripPanelItem27.Name = "toolStripPanelItem27"
			Me.toolStripPanelItem27.ShowItemToolTips = False
			Me.toolStripPanelItem27.Size = New System.Drawing.Size(55, 78)
			Me.toolStripPanelItem27.Text = "toolStripPanelItem27"
			Me.toolStripPanelItem27.Transparent = True
			' 
			' toolStripLabel5
			' 
			Me.toolStripLabel5.Name = "toolStripLabel5"
			Me.toolStripLabel5.Size = New System.Drawing.Size(51, 13)
			Me.toolStripLabel5.Text = "Headings"
			Me.toolStripLabel5.ToolTipText = "Headings"
			' 
			' toolStripLabel6
			' 
			Me.toolStripLabel6.Image = (CType(resources.GetObject("toolStripLabel6.Image"), System.Drawing.Image))
			Me.toolStripLabel6.Name = "toolStripLabel6"
			Me.toolStripLabel6.Size = New System.Drawing.Size(45, 16)
			Me.toolStripLabel6.Text = "View"
			Me.toolStripLabel6.ToolTipText = "View"
			' 
			' toolStripLabel7
			' 
			Me.toolStripLabel7.Image = (CType(resources.GetObject("toolStripLabel7.Image"), System.Drawing.Image))
			Me.toolStripLabel7.Name = "toolStripLabel7"
			Me.toolStripLabel7.Size = New System.Drawing.Size(45, 16)
			Me.toolStripLabel7.Text = "Print"
			Me.toolStripLabel7.ToolTipText = "Print"
			' 
			' toolStripEx10
			' 
			Me.toolStripEx10.AutoSize = False
			Me.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx10.Image = (CType(resources.GetObject("toolStripEx10.Image"), System.Drawing.Image))
			Me.toolStripEx10.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton24})
			Me.toolStripEx10.Location = New System.Drawing.Point(684, 1)
			Me.toolStripEx10.Name = "toolStripEx10"
			Me.toolStripEx10.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx10.ShowItemToolTips = False
			Me.toolStripEx10.Size = New System.Drawing.Size(94, 106)
			Me.toolStripEx10.TabIndex = 6
			' 
			' toolStripDropDownButton24
			' 
			Me.toolStripDropDownButton24.AutoSize = False
			Me.toolStripDropDownButton24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem57, Me.toolStripMenuItem58, Me.toolStripMenuItem59})
			Me.toolStripDropDownButton24.Image = (CType(resources.GetObject("toolStripDropDownButton24.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton24.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton24.Name = "toolStripDropDownButton24"
			Me.toolStripDropDownButton24.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripDropDownButton24.Size = New System.Drawing.Size(72, 80)
			Me.toolStripDropDownButton24.Text = "Arrange "
			Me.toolStripDropDownButton24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripMenuItem57
			' 
			Me.toolStripMenuItem57.Name = "toolStripMenuItem57"
			Me.toolStripMenuItem57.Size = New System.Drawing.Size(153, 22)
			Me.toolStripMenuItem57.Text = "Bring To Front"
			' 
			' toolStripMenuItem58
			' 
			Me.toolStripMenuItem58.Name = "toolStripMenuItem58"
			Me.toolStripMenuItem58.Size = New System.Drawing.Size(153, 22)
			Me.toolStripMenuItem58.Text = "Send to Back"
			' 
			' toolStripMenuItem59
			' 
			Me.toolStripMenuItem59.Name = "toolStripMenuItem59"
			Me.toolStripMenuItem59.Size = New System.Drawing.Size(153, 22)
			Me.toolStripMenuItem59.Text = "Group"
			' 
			' toolStripTabItem4
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem4, "F")
			Me.toolStripTabItem4.Name = "toolStripTabItem4"
			Me.toolStripTabItem4.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' excelRibbon.ribbonPanel4
			' 
			Me.toolStripTabItem4.Panel.Controls.Add(Me.toolStripEx11)
			Me.toolStripTabItem4.Panel.Controls.Add(Me.toolStripEx12)
			Me.toolStripTabItem4.Panel.Controls.Add(Me.toolStripEx13)
			Me.toolStripTabItem4.Panel.Name = "ribbonPanel4"
			Me.toolStripTabItem4.Panel.ScrollPosition = 0
			Me.toolStripTabItem4.Panel.TabIndex = 5
			Me.toolStripTabItem4.Panel.TabItem = Me.toolStripTabItem4
			Me.toolStripTabItem4.Panel.Text = "Formulas"
			Me.toolStripTabItem4.Size = New System.Drawing.Size(64, 24)
			Me.toolStripTabItem4.Text = "Formulas"
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
			Me.toolStripEx11.Size = New System.Drawing.Size(320, 106)
			Me.toolStripEx11.TabIndex = 0
			Me.toolStripEx11.Text = "Function Library"
			' 
			' toolStripPanelItem28
			' 
			Me.toolStripPanelItem28.CausesValidation = False
			Me.toolStripPanelItem28.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem28.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton13})
			Me.toolStripPanelItem28.Name = "toolStripPanelItem28"
			Me.toolStripPanelItem28.Size = New System.Drawing.Size(52, 78)
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
			Me.toolStripPanelItem29.ShowItemToolTips = False
			Me.toolStripPanelItem29.Size = New System.Drawing.Size(222, 78)
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
			Me.toolStripEx12.Size = New System.Drawing.Size(221, 106)
			Me.toolStripEx12.TabIndex = 1
			Me.toolStripEx12.Text = "Defined Names"
			' 
			' toolStripPanelItem30
			' 
			Me.toolStripPanelItem30.CausesValidation = False
			Me.toolStripPanelItem30.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem30.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton14})
			Me.toolStripPanelItem30.Name = "toolStripPanelItem30"
			Me.toolStripPanelItem30.ShowItemToolTips = False
			Me.toolStripPanelItem30.Size = New System.Drawing.Size(57, 88)
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
			Me.toolStripPanelItem31.Size = New System.Drawing.Size(135, 88)
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
			' toolStripEx13
			' 
			Me.toolStripEx13.AutoSize = False
			Me.toolStripEx13.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx13.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx13.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx13.Image = (CType(resources.GetObject("toolStripEx13.Image"), System.Drawing.Image))
			Me.toolStripEx13.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem32, Me.toolStripDropDownButton37})
			Me.toolStripEx13.Location = New System.Drawing.Point(514, 1)
			Me.toolStripEx13.Name = "toolStripEx13"
			Me.toolStripEx13.ShowCaption = False
			Me.toolStripEx13.ShowItemToolTips = False
			Me.toolStripEx13.Size = New System.Drawing.Size(165, 106)
			Me.toolStripEx13.TabIndex = 2
			' 
			' toolStripPanelItem32
			' 
			Me.toolStripPanelItem32.AutoSize = False
			Me.toolStripPanelItem32.CausesValidation = False
			Me.toolStripPanelItem32.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem32.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton36})
			Me.toolStripPanelItem32.Margin = New System.Windows.Forms.Padding(1, 10, 1, 0)
			Me.toolStripPanelItem32.Name = "toolStripPanelItem32"
			Me.toolStripPanelItem32.ShowItemToolTips = False
			Me.toolStripPanelItem32.Size = New System.Drawing.Size(65, 92)
			Me.toolStripPanelItem32.Text = "toolStripPanelItem32"
			Me.toolStripPanelItem32.Transparent = True
			' 
			' toolStripDropDownButton36
			' 
			Me.toolStripDropDownButton36.AutoSize = False
			Me.toolStripDropDownButton36.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.traceDeToolStripMenuItem, Me.traceDependentsToolStripMenuItem, Me.removeArrowsToolStripMenuItem})
			Me.toolStripDropDownButton36.Image = (CType(resources.GetObject("toolStripDropDownButton36.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton36.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton36.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton36.Name = "toolStripDropDownButton36"
			Me.toolStripDropDownButton36.Size = New System.Drawing.Size(61, 80)
			Me.toolStripDropDownButton36.Text = "Formula " & Constants.vbCrLf & "Auditing"
			Me.toolStripDropDownButton36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' traceDeToolStripMenuItem
			' 
			Me.traceDeToolStripMenuItem.Name = "traceDeToolStripMenuItem"
			Me.traceDeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.traceDeToolStripMenuItem.Text = "Trace Precedents"
			' 
			' traceDependentsToolStripMenuItem
			' 
			Me.traceDependentsToolStripMenuItem.Name = "traceDependentsToolStripMenuItem"
			Me.traceDependentsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.traceDependentsToolStripMenuItem.Text = "Trace Dependents"
			' 
			' removeArrowsToolStripMenuItem
			' 
			Me.removeArrowsToolStripMenuItem.Name = "removeArrowsToolStripMenuItem"
			Me.removeArrowsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.removeArrowsToolStripMenuItem.Text = "Remove Arrows"
			' 
			' toolStripDropDownButton37
			' 
			Me.toolStripDropDownButton37.AutoSize = False
			Me.toolStripDropDownButton37.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.calculateNowToolStripMenuItem, Me.calculateSheetToolStripMenuItem})
			Me.toolStripDropDownButton37.Image = (CType(resources.GetObject("toolStripDropDownButton37.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton37.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton37.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton37.Name = "toolStripDropDownButton37"
			Me.toolStripDropDownButton37.Size = New System.Drawing.Size(72, 80)
			Me.toolStripDropDownButton37.Text = "Calculation"
			Me.toolStripDropDownButton37.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' calculateNowToolStripMenuItem
			' 
			Me.calculateNowToolStripMenuItem.Name = "calculateNowToolStripMenuItem"
			Me.calculateNowToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
			Me.calculateNowToolStripMenuItem.Text = "Calculate Now"
			' 
			' calculateSheetToolStripMenuItem
			' 
			Me.calculateSheetToolStripMenuItem.Name = "calculateSheetToolStripMenuItem"
			Me.calculateSheetToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
			Me.calculateSheetToolStripMenuItem.Text = "Calculate Sheet"
			' 
			' toolStripTabItem5
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem5, "D")
			Me.toolStripTabItem5.Name = "toolStripTabItem5"
			Me.toolStripTabItem5.Padding = New System.Windows.Forms.Padding(8, 2, 8, 5)
			' 
			' excelRibbon.ribbonPanel5
			' 
			Me.toolStripTabItem5.Panel.Controls.Add(Me.toolStripEx14)
			Me.toolStripTabItem5.Panel.Controls.Add(Me.toolStripEx15)
			Me.toolStripTabItem5.Panel.Controls.Add(Me.toolStripEx16)
			Me.toolStripTabItem5.Panel.Controls.Add(Me.toolStripEx17)
			Me.toolStripTabItem5.Panel.Controls.Add(Me.toolStripEx18)
			Me.toolStripTabItem5.Panel.Name = "ribbonPanel5"
			Me.toolStripTabItem5.Panel.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripTabItem5.Panel.ScrollPosition = 0
			Me.toolStripTabItem5.Panel.TabIndex = 6
			Me.toolStripTabItem5.Panel.TabItem = Me.toolStripTabItem5
			Me.toolStripTabItem5.Panel.Text = "Data"
			Me.toolStripTabItem5.Size = New System.Drawing.Size(50, 24)
			Me.toolStripTabItem5.Text = "Data"
			' 
			' toolStripEx14
			' 
			Me.toolStripEx14.AutoSize = False
			Me.toolStripEx14.CollapsedDropDownButtonText = "Data"
			Me.toolStripEx14.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx14.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx14.Image = (CType(resources.GetObject("toolStripEx14.Image"), System.Drawing.Image))
			Me.toolStripEx14.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem33})
			Me.toolStripEx14.Location = New System.Drawing.Point(5, 5)
			Me.toolStripEx14.Name = "toolStripEx14"
			Me.toolStripEx14.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx14.ShowItemToolTips = False
			Me.toolStripEx14.Size = New System.Drawing.Size(120, 97)
			Me.toolStripEx14.TabIndex = 0
			Me.toolStripEx14.Text = "Data"
			' 
			' toolStripPanelItem33
			' 
			Me.toolStripPanelItem33.CausesValidation = False
			Me.toolStripPanelItem33.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem33.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton38})
			Me.toolStripPanelItem33.Name = "toolStripPanelItem33"
			Me.toolStripPanelItem33.ShowItemToolTips = False
			Me.toolStripPanelItem33.Size = New System.Drawing.Size(84, 69)
			Me.toolStripPanelItem33.Text = "toolStripPanelItem33"
			Me.toolStripPanelItem33.Transparent = True
			' 
			' toolStripDropDownButton38
			' 
			Me.toolStripDropDownButton38.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fromAccessToolStripMenuItem, Me.fromWebToolStripMenuItem, Me.fromTextToolStripMenuItem, Me.fromOtherSourcesToolStripMenuItem})
			Me.toolStripDropDownButton38.Image = (CType(resources.GetObject("toolStripDropDownButton38.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton38.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton38.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton38.Name = "toolStripDropDownButton38"
			Me.toolStripDropDownButton38.Size = New System.Drawing.Size(80, 62)
			Me.toolStripDropDownButton38.Text = "Get External" & Constants.vbCrLf & "Data"
			Me.toolStripDropDownButton38.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' fromAccessToolStripMenuItem
			' 
			Me.fromAccessToolStripMenuItem.Name = "fromAccessToolStripMenuItem"
			Me.fromAccessToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.fromAccessToolStripMenuItem.Text = "From Access"
			' 
			' fromWebToolStripMenuItem
			' 
			Me.fromWebToolStripMenuItem.Name = "fromWebToolStripMenuItem"
			Me.fromWebToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.fromWebToolStripMenuItem.Text = "From Web"
			' 
			' fromTextToolStripMenuItem
			' 
			Me.fromTextToolStripMenuItem.Name = "fromTextToolStripMenuItem"
			Me.fromTextToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.fromTextToolStripMenuItem.Text = "From Text"
			' 
			' fromOtherSourcesToolStripMenuItem
			' 
			Me.fromOtherSourcesToolStripMenuItem.Name = "fromOtherSourcesToolStripMenuItem"
			Me.fromOtherSourcesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.fromOtherSourcesToolStripMenuItem.Text = "From Other Sources"
			' 
			' toolStripEx15
			' 
			Me.toolStripEx15.AutoSize = False
			Me.toolStripEx15.CollapsedDropDownButtonText = "Connections"
			Me.toolStripEx15.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx15.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx15.Image = (CType(resources.GetObject("toolStripEx15.Image"), System.Drawing.Image))
			Me.toolStripEx15.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem34, Me.toolStripPanelItem35})
			Me.toolStripEx15.Location = New System.Drawing.Point(105, 5)
			Me.toolStripEx15.Name = "toolStripEx15"
			Me.toolStripEx15.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx15.ShowItemToolTips = False
			Me.toolStripEx15.Size = New System.Drawing.Size(196, 97)
			Me.toolStripEx15.TabIndex = 1
			Me.toolStripEx15.Text = "Connections"
			' 
			' toolStripPanelItem34
			' 
			Me.toolStripPanelItem34.CausesValidation = False
			Me.toolStripPanelItem34.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem34.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton39})
			Me.toolStripPanelItem34.Name = "toolStripPanelItem34"
			Me.toolStripPanelItem34.ShowItemToolTips = False
			Me.toolStripPanelItem34.Size = New System.Drawing.Size(62, 69)
			Me.toolStripPanelItem34.Text = "toolStripPanelItem34"
			Me.toolStripPanelItem34.Transparent = True
			' 
			' toolStripDropDownButton39
			' 
			Me.toolStripDropDownButton39.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.refreshToolStripMenuItem, Me.refreshAllToolStripMenuItem, Me.refreshStatusToolStripMenuItem, Me.cancelRefreshToolStripMenuItem})
			Me.toolStripDropDownButton39.Image = (CType(resources.GetObject("toolStripDropDownButton39.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton39.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton39.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton39.Name = "toolStripDropDownButton39"
			Me.toolStripDropDownButton39.Size = New System.Drawing.Size(58, 62)
			Me.toolStripDropDownButton39.Text = "Refresh" & Constants.vbCrLf & "All"
			Me.toolStripDropDownButton39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' refreshToolStripMenuItem
			' 
			Me.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem"
			Me.refreshToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
			Me.refreshToolStripMenuItem.Text = "Refresh"
			' 
			' refreshAllToolStripMenuItem
			' 
			Me.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem"
			Me.refreshAllToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
			Me.refreshAllToolStripMenuItem.Text = "Refresh All"
			' 
			' refreshStatusToolStripMenuItem
			' 
			Me.refreshStatusToolStripMenuItem.Name = "refreshStatusToolStripMenuItem"
			Me.refreshStatusToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
			Me.refreshStatusToolStripMenuItem.Text = "Refresh Status"
			' 
			' cancelRefreshToolStripMenuItem
			' 
			Me.cancelRefreshToolStripMenuItem.Name = "cancelRefreshToolStripMenuItem"
			Me.cancelRefreshToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
			Me.cancelRefreshToolStripMenuItem.Text = "Cancel Refresh"
			' 
			' toolStripPanelItem35
			' 
			Me.toolStripPanelItem35.CausesValidation = False
			Me.toolStripPanelItem35.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem35.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton16, Me.toolStripButton17})
			Me.toolStripPanelItem35.Name = "toolStripPanelItem35"
			Me.toolStripPanelItem35.ShowItemToolTips = False
			Me.toolStripPanelItem35.Size = New System.Drawing.Size(90, 69)
			Me.toolStripPanelItem35.Text = "toolStripPanelItem35"
			Me.toolStripPanelItem35.Transparent = True
			' 
			' toolStripButton16
			' 
			Me.toolStripButton16.Image = (CType(resources.GetObject("toolStripButton16.Image"), System.Drawing.Image))
			Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton16.Name = "toolStripButton16"
			Me.toolStripButton16.Size = New System.Drawing.Size(86, 20)
			Me.toolStripButton16.Text = "Connections"
			' 
			' toolStripButton17
			' 
			Me.toolStripButton17.Image = (CType(resources.GetObject("toolStripButton17.Image"), System.Drawing.Image))
			Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton17.Name = "toolStripButton17"
			Me.toolStripButton17.Size = New System.Drawing.Size(76, 20)
			Me.toolStripButton17.Text = "Properties"
			' 
			' toolStripEx16
			' 
			Me.toolStripEx16.AutoSize = False
			Me.toolStripEx16.CollapsedDropDownButtonText = "Sort"
			Me.toolStripEx16.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx16.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx16.Image = (CType(resources.GetObject("toolStripEx16.Image"), System.Drawing.Image))
			Me.toolStripEx16.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem36, Me.toolStripSeparator1, Me.toolStripButton22, Me.toolStripPanelItem37})
			Me.toolStripEx16.Location = New System.Drawing.Point(275, 5)
			Me.toolStripEx16.Name = "toolStripEx16"
			Me.toolStripEx16.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx16.ShowItemToolTips = False
			Me.toolStripEx16.Size = New System.Drawing.Size(236, 97)
			Me.toolStripEx16.TabIndex = 2
			Me.toolStripEx16.Text = "Sort & Filter"
			' 
			' toolStripPanelItem36
			' 
			Me.toolStripPanelItem36.CausesValidation = False
			Me.toolStripPanelItem36.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem36.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem55})
			Me.toolStripPanelItem36.Name = "toolStripPanelItem36"
			Me.toolStripPanelItem36.RowCount = 2
			Me.toolStripPanelItem36.Size = New System.Drawing.Size(78, 69)
			Me.toolStripPanelItem36.Text = "toolStripPanelItem36"
			Me.toolStripPanelItem36.Transparent = True
			' 
			' toolStripPanelItem55
			' 
			Me.toolStripPanelItem55.AutoSize = False
			Me.toolStripPanelItem55.CausesValidation = False
			Me.toolStripPanelItem55.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem55.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem56, Me.toolStripPanelItem57})
			Me.toolStripPanelItem55.Name = "toolStripPanelItem55"
			Me.toolStripPanelItem55.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
			Me.toolStripPanelItem55.RowCount = 1
			Me.toolStripPanelItem55.ShowItemToolTips = False
			Me.toolStripPanelItem55.Size = New System.Drawing.Size(72, 72)
			Me.toolStripPanelItem55.Text = "toolStripPanelItem55"
			Me.toolStripPanelItem55.Transparent = True
			' 
			' toolStripPanelItem56
			' 
			Me.toolStripPanelItem56.CausesValidation = False
			Me.toolStripPanelItem56.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem56.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton87, Me.toolStripButton88})
			Me.toolStripPanelItem56.Margin = New System.Windows.Forms.Padding(1, 4, 1, 0)
			Me.toolStripPanelItem56.Name = "toolStripPanelItem56"
			Me.toolStripPanelItem56.Size = New System.Drawing.Size(27, 50)
			Me.toolStripPanelItem56.Text = "toolStripPanelItem56"
			Me.toolStripPanelItem56.Transparent = True
			' 
			' toolStripButton87
			' 
			Me.toolStripButton87.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton87.Image = (CType(resources.GetObject("toolStripButton87.Image"), System.Drawing.Image))
			Me.toolStripButton87.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton87.Name = "toolStripButton87"
			Me.toolStripButton87.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton87.Text = "toolStripButton87"
			' 
			' toolStripButton88
			' 
			Me.toolStripButton88.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton88.Image = (CType(resources.GetObject("toolStripButton88.Image"), System.Drawing.Image))
			Me.toolStripButton88.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton88.Name = "toolStripButton88"
			Me.toolStripButton88.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton88.Text = "toolStripButton88"
			' 
			' toolStripPanelItem57
			' 
			Me.toolStripPanelItem57.CausesValidation = False
			Me.toolStripPanelItem57.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem57.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton99})
			Me.toolStripPanelItem57.Name = "toolStripPanelItem57"
			Me.toolStripPanelItem57.RowCount = 1
			Me.toolStripPanelItem57.Size = New System.Drawing.Size(40, 56)
			Me.toolStripPanelItem57.Text = "Sort"
			Me.toolStripPanelItem57.Transparent = True
			' 
			' toolStripButton99
			' 
			Me.toolStripButton99.Image = (CType(resources.GetObject("toolStripButton99.Image"), System.Drawing.Image))
			Me.toolStripButton99.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton99.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton99.Name = "toolStripButton99"
			Me.toolStripButton99.Size = New System.Drawing.Size(36, 49)
			Me.toolStripButton99.Text = "Sort"
			Me.toolStripButton99.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 69)
			' 
			' toolStripButton22
			' 
			Me.toolStripButton22.Image = (CType(resources.GetObject("toolStripButton22.Image"), System.Drawing.Image))
			Me.toolStripButton22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton22.Name = "toolStripButton22"
			Me.toolStripButton22.Size = New System.Drawing.Size(36, 66)
			Me.toolStripButton22.Text = "Filter"
			Me.toolStripButton22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem37
			' 
			Me.toolStripPanelItem37.CausesValidation = False
			Me.toolStripPanelItem37.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem37.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton23, Me.toolStripButton24, Me.toolStripButton25})
			Me.toolStripPanelItem37.Name = "toolStripPanelItem37"
			Me.toolStripPanelItem37.Size = New System.Drawing.Size(79, 69)
			Me.toolStripPanelItem37.Text = "toolStripPanelItem37"
			Me.toolStripPanelItem37.Transparent = True
			' 
			' toolStripButton23
			' 
			Me.toolStripButton23.Image = (CType(resources.GetObject("toolStripButton23.Image"), System.Drawing.Image))
			Me.toolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton23.Name = "toolStripButton23"
			Me.toolStripButton23.Size = New System.Drawing.Size(52, 20)
			Me.toolStripButton23.Text = "Clear"
			' 
			' toolStripButton24
			' 
			Me.toolStripButton24.Image = (CType(resources.GetObject("toolStripButton24.Image"), System.Drawing.Image))
			Me.toolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton24.Name = "toolStripButton24"
			Me.toolStripButton24.Size = New System.Drawing.Size(66, 20)
			Me.toolStripButton24.Text = "Reapply"
			' 
			' toolStripButton25
			' 
			Me.toolStripButton25.Image = (CType(resources.GetObject("toolStripButton25.Image"), System.Drawing.Image))
			Me.toolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton25.Name = "toolStripButton25"
			Me.toolStripButton25.Size = New System.Drawing.Size(75, 20)
			Me.toolStripButton25.Text = "Advanced"
			' 
			' toolStripEx17
			' 
			Me.toolStripEx17.AutoSize = False
			Me.toolStripEx17.CollapsedDropDownButtonText = "Tools"
			Me.toolStripEx17.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx17.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx17.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx17.Image = (CType(resources.GetObject("toolStripEx17.Image"), System.Drawing.Image))
			Me.toolStripEx17.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem38, Me.toolStripPanelItem39, Me.toolStripPanelItem40})
			Me.toolStripEx17.Location = New System.Drawing.Point(511, 5)
			Me.toolStripEx17.Name = "toolStripEx17"
			Me.toolStripEx17.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx17.ShowItemToolTips = False
			Me.toolStripEx17.Size = New System.Drawing.Size(168, 97)
			Me.toolStripEx17.TabIndex = 3
			Me.toolStripEx17.Text = "Data Tools"
			' 
			' toolStripPanelItem38
			' 
			Me.toolStripPanelItem38.CausesValidation = False
			Me.toolStripPanelItem38.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem38.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton26})
			Me.toolStripPanelItem38.Name = "toolStripPanelItem38"
			Me.toolStripPanelItem38.ShowItemToolTips = False
			Me.toolStripPanelItem38.Size = New System.Drawing.Size(52, 69)
			Me.toolStripPanelItem38.Text = "toolStripPanelItem38"
			Me.toolStripPanelItem38.Transparent = True
			' 
			' toolStripButton26
			' 
			Me.toolStripButton26.AutoSize = False
			Me.toolStripButton26.Image = (CType(resources.GetObject("toolStripButton26.Image"), System.Drawing.Image))
			Me.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton26.Name = "toolStripButton26"
			Me.toolStripButton26.Size = New System.Drawing.Size(48, 65)
			Me.toolStripButton26.Text = "Text To" & Constants.vbCrLf & "Columns"
			Me.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem39
			' 
			Me.toolStripPanelItem39.CausesValidation = False
			Me.toolStripPanelItem39.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem39.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton27})
			Me.toolStripPanelItem39.Name = "toolStripPanelItem39"
			Me.toolStripPanelItem39.Size = New System.Drawing.Size(54, 69)
			Me.toolStripPanelItem39.Text = "toolStripPanelItem39"
			Me.toolStripPanelItem39.Transparent = True
			' 
			' toolStripButton27
			' 
			Me.toolStripButton27.AutoSize = False
			Me.toolStripButton27.Image = (CType(resources.GetObject("toolStripButton27.Image"), System.Drawing.Image))
			Me.toolStripButton27.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton27.Name = "toolStripButton27"
			Me.toolStripButton27.Size = New System.Drawing.Size(50, 65)
			Me.toolStripButton27.Text = "Remove" & Constants.vbCrLf & "Columns"
			Me.toolStripButton27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem40
			' 
			Me.toolStripPanelItem40.CausesValidation = False
			Me.toolStripPanelItem40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem40.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton40, Me.toolStripButton28, Me.toolStripDropDownButton41})
			Me.toolStripPanelItem40.Name = "toolStripPanelItem40"
			Me.toolStripPanelItem40.ShowItemToolTips = False
			Me.toolStripPanelItem40.Size = New System.Drawing.Size(33, 69)
			Me.toolStripPanelItem40.Text = "toolStripPanelItem40"
			Me.toolStripPanelItem40.Transparent = True
			' 
			' toolStripDropDownButton40
			' 
			Me.toolStripDropDownButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton40.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.dataValidationToolStripMenuItem, Me.circleInvalidDataToolStripMenuItem, Me.clearValidationsToolStripMenuItem})
			Me.toolStripDropDownButton40.Image = (CType(resources.GetObject("toolStripDropDownButton40.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton40.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton40.Name = "toolStripDropDownButton40"
			Me.toolStripDropDownButton40.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton40.Text = "Dat&a Validation"
			Me.toolStripDropDownButton40.ToolTipText = "Data Validation"
			' 
			' dataValidationToolStripMenuItem
			' 
			Me.dataValidationToolStripMenuItem.Name = "dataValidationToolStripMenuItem"
			Me.dataValidationToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
			Me.dataValidationToolStripMenuItem.Text = "Dat&a validation"
			' 
			' circleInvalidDataToolStripMenuItem
			' 
			Me.circleInvalidDataToolStripMenuItem.Name = "circleInvalidDataToolStripMenuItem"
			Me.circleInvalidDataToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
			Me.circleInvalidDataToolStripMenuItem.Text = "C&ircle Invalid data"
			' 
			' clearValidationsToolStripMenuItem
			' 
			Me.clearValidationsToolStripMenuItem.Name = "clearValidationsToolStripMenuItem"
			Me.clearValidationsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
			Me.clearValidationsToolStripMenuItem.Text = "Clea&r Validations"
			' 
			' toolStripButton28
			' 
			Me.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton28.Image = (CType(resources.GetObject("toolStripButton28.Image"), System.Drawing.Image))
			Me.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton28.Name = "toolStripButton28"
			Me.toolStripButton28.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton28.Text = "toolStripButton28"
			Me.toolStripButton28.ToolTipText = "Consolidate"
			' 
			' toolStripDropDownButton41
			' 
			Me.toolStripDropDownButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripDropDownButton41.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.scenarioManagerToolStripMenuItem, Me.goalSeekToolStripMenuItem, Me.toolStripMenuItem61})
			Me.toolStripDropDownButton41.Image = (CType(resources.GetObject("toolStripDropDownButton41.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton41.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton41.Name = "toolStripDropDownButton41"
			Me.toolStripDropDownButton41.Size = New System.Drawing.Size(29, 20)
			Me.toolStripDropDownButton41.Text = "toolStripDropDownButton41"
			Me.toolStripDropDownButton41.ToolTipText = "What-If analysis"
			' 
			' scenarioManagerToolStripMenuItem
			' 
			Me.scenarioManagerToolStripMenuItem.Name = "scenarioManagerToolStripMenuItem"
			Me.scenarioManagerToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
			Me.scenarioManagerToolStripMenuItem.Text = "&Scenario manager.."
			' 
			' goalSeekToolStripMenuItem
			' 
			Me.goalSeekToolStripMenuItem.Name = "goalSeekToolStripMenuItem"
			Me.goalSeekToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
			Me.goalSeekToolStripMenuItem.Text = "&Goal Seek"
			' 
			' toolStripMenuItem61
			' 
			Me.toolStripMenuItem61.Name = "toolStripMenuItem61"
			Me.toolStripMenuItem61.Size = New System.Drawing.Size(179, 22)
			Me.toolStripMenuItem61.Text = "Data &Table.."
			' 
			' toolStripEx18
			' 
			Me.toolStripEx18.AutoSize = False
			Me.toolStripEx18.CollapsedDropDownButtonText = "Outline"
			Me.toolStripEx18.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx18.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx18.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx18.Image = (CType(resources.GetObject("toolStripEx18.Image"), System.Drawing.Image))
			Me.toolStripEx18.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem41})
			Me.toolStripEx18.Location = New System.Drawing.Point(679, 5)
			Me.toolStripEx18.Name = "toolStripEx18"
			Me.toolStripEx18.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripEx18.ShowItemToolTips = False
			Me.toolStripEx18.Size = New System.Drawing.Size(116, 97)
			Me.toolStripEx18.TabIndex = 4
			Me.toolStripEx18.Text = "Outline"
			' 
			' toolStripPanelItem41
			' 
			Me.toolStripPanelItem41.CausesValidation = False
			Me.toolStripPanelItem41.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem41.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton42, Me.toolStripDropDownButton43, Me.toolStripButton29, Me.toolStripLabel26})
			Me.toolStripPanelItem41.Name = "toolStripPanelItem41"
			Me.toolStripPanelItem41.Size = New System.Drawing.Size(82, 69)
			Me.toolStripPanelItem41.Text = "toolStripPanelItem41"
			Me.toolStripPanelItem41.Transparent = True
			' 
			' toolStripDropDownButton42
			' 
			Me.toolStripDropDownButton42.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.groupToolStripMenuItem, Me.autoOutlineToolStripMenuItem})
			Me.toolStripDropDownButton42.Image = (CType(resources.GetObject("toolStripDropDownButton42.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton42.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton42.Name = "toolStripDropDownButton42"
			Me.toolStripDropDownButton42.Size = New System.Drawing.Size(65, 20)
			Me.toolStripDropDownButton42.Text = "Group"
			' 
			' groupToolStripMenuItem
			' 
			Me.groupToolStripMenuItem.Name = "groupToolStripMenuItem"
			Me.groupToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
			Me.groupToolStripMenuItem.Text = "&Group "
			' 
			' autoOutlineToolStripMenuItem
			' 
			Me.autoOutlineToolStripMenuItem.Name = "autoOutlineToolStripMenuItem"
			Me.autoOutlineToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
			Me.autoOutlineToolStripMenuItem.Text = "&Auto Outline"
			' 
			' toolStripDropDownButton43
			' 
			Me.toolStripDropDownButton43.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.ungroupToolStripMenuItem, Me.clearOutlineToolStripMenuItem})
			Me.toolStripDropDownButton43.Image = (CType(resources.GetObject("toolStripDropDownButton43.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton43.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton43.Name = "toolStripDropDownButton43"
			Me.toolStripDropDownButton43.Size = New System.Drawing.Size(78, 20)
			Me.toolStripDropDownButton43.Text = "UnGroup"
			' 
			' ungroupToolStripMenuItem
			' 
			Me.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem"
			Me.ungroupToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
			Me.ungroupToolStripMenuItem.Text = "&Ungroup"
			' 
			' clearOutlineToolStripMenuItem
			' 
			Me.clearOutlineToolStripMenuItem.Name = "clearOutlineToolStripMenuItem"
			Me.clearOutlineToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
			Me.clearOutlineToolStripMenuItem.Text = "&Clear Outline"
			' 
			' toolStripButton29
			' 
			Me.toolStripButton29.Image = (CType(resources.GetObject("toolStripButton29.Image"), System.Drawing.Image))
			Me.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton29.Name = "toolStripButton29"
			Me.toolStripButton29.Size = New System.Drawing.Size(69, 20)
			Me.toolStripButton29.Text = "SubTotal"
			' 
			' toolStripLabel26
			' 
			Me.toolStripLabel26.Name = "toolStripLabel26"
			Me.toolStripLabel26.Size = New System.Drawing.Size(0, 0)
			Me.toolStripLabel26.ToolTipText = "Hide detail"
			' 
			' toolStripTabItem6
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem6, "R")
			Me.toolStripTabItem6.Name = "toolStripTabItem6"
			Me.toolStripTabItem6.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
			' 
			' excelRibbon.ribbonPanel6
			' 
			Me.toolStripTabItem6.Panel.Controls.Add(Me.toolStripEx19)
			Me.toolStripTabItem6.Panel.Controls.Add(Me.toolStripEx20)
			Me.toolStripTabItem6.Panel.Controls.Add(Me.toolStripEx21)
			Me.toolStripTabItem6.Panel.Name = "ribbonPanel6"
			Me.toolStripTabItem6.Panel.Padding = New System.Windows.Forms.Padding(5)
			Me.toolStripTabItem6.Panel.ScrollPosition = 0
			Me.toolStripTabItem6.Panel.TabIndex = 7
			Me.toolStripTabItem6.Panel.TabItem = Me.toolStripTabItem6
			Me.toolStripTabItem6.Panel.Text = "Review"
			Me.toolStripTabItem6.Size = New System.Drawing.Size(56, 24)
			Me.toolStripTabItem6.Text = "Review"
			' 
			' toolStripEx19
			' 
			Me.toolStripEx19.AutoSize = False
			Me.toolStripEx19.CollapsedDropDownButtonText = "Proof"
			Me.toolStripEx19.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx19.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx19.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx19.Image = (CType(resources.GetObject("toolStripEx19.Image"), System.Drawing.Image))
			Me.toolStripEx19.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton30, Me.toolStripPanelItem42})
			Me.toolStripEx19.Location = New System.Drawing.Point(5, 5)
			Me.toolStripEx19.Name = "toolStripEx19"
			Me.toolStripEx19.ShowItemToolTips = False
			Me.toolStripEx19.Size = New System.Drawing.Size(165, 97)
			Me.toolStripEx19.TabIndex = 0
			Me.toolStripEx19.Text = "Proofing"
			' 
			' toolStripButton30
			' 
			Me.toolStripButton30.Image = (CType(resources.GetObject("toolStripButton30.Image"), System.Drawing.Image))
			Me.toolStripButton30.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton30.Name = "toolStripButton30"
			Me.toolStripButton30.Size = New System.Drawing.Size(47, 76)
			Me.toolStripButton30.Text = "Spelling"
			Me.toolStripButton30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem42
			' 
			Me.toolStripPanelItem42.CausesValidation = False
			Me.toolStripPanelItem42.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem42.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton31, Me.toolStripButton32, Me.toolStripButton33})
			Me.toolStripPanelItem42.Name = "toolStripPanelItem42"
			Me.toolStripPanelItem42.ShowItemToolTips = False
			Me.toolStripPanelItem42.Size = New System.Drawing.Size(81, 79)
			Me.toolStripPanelItem42.Text = "toolStripPanelItem42"
			Me.toolStripPanelItem42.Transparent = True
			' 
			' toolStripButton31
			' 
			Me.toolStripButton31.Image = (CType(resources.GetObject("toolStripButton31.Image"), System.Drawing.Image))
			Me.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton31.Name = "toolStripButton31"
			Me.toolStripButton31.Size = New System.Drawing.Size(72, 20)
			Me.toolStripButton31.Text = "Research"
			' 
			' toolStripButton32
			' 
			Me.toolStripButton32.Image = (CType(resources.GetObject("toolStripButton32.Image"), System.Drawing.Image))
			Me.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton32.Name = "toolStripButton32"
			Me.toolStripButton32.Size = New System.Drawing.Size(77, 20)
			Me.toolStripButton32.Text = "Thesaurus"
			' 
			' toolStripButton33
			' 
			Me.toolStripButton33.Image = (CType(resources.GetObject("toolStripButton33.Image"), System.Drawing.Image))
			Me.toolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton33.Name = "toolStripButton33"
			Me.toolStripButton33.Size = New System.Drawing.Size(72, 20)
			Me.toolStripButton33.Text = "Translate"
			' 
			' toolStripEx20
			' 
			Me.toolStripEx20.AutoSize = False
			Me.toolStripEx20.CollapsedDropDownButtonText = "Comments"
			Me.toolStripEx20.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx20.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx20.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx20.Image = (CType(resources.GetObject("toolStripEx20.Image"), System.Drawing.Image))
			Me.toolStripEx20.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem43, Me.toolStripPanelItem45})
			Me.toolStripEx20.Location = New System.Drawing.Point(148, 5)
			Me.toolStripEx20.Name = "toolStripEx20"
			Me.toolStripEx20.ShowItemToolTips = False
			Me.toolStripEx20.Size = New System.Drawing.Size(320, 97)
			Me.toolStripEx20.TabIndex = 1
			Me.toolStripEx20.Text = "Comments"
			' 
			' toolStripPanelItem43
			' 
			Me.toolStripPanelItem43.CausesValidation = False
			Me.toolStripPanelItem43.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem43.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton34})
			Me.toolStripPanelItem43.Name = "toolStripPanelItem43"
			Me.toolStripPanelItem43.ShowItemToolTips = False
			Me.toolStripPanelItem43.Size = New System.Drawing.Size(60, 79)
			Me.toolStripPanelItem43.Text = "toolStripPanelItem43"
			Me.toolStripPanelItem43.Transparent = True
			' 
			' toolStripButton34
			' 
			Me.toolStripButton34.Image = (CType(resources.GetObject("toolStripButton34.Image"), System.Drawing.Image))
			Me.toolStripButton34.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton34.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton34.Name = "toolStripButton34"
			Me.toolStripButton34.Size = New System.Drawing.Size(56, 62)
			Me.toolStripButton34.Text = "New" & Constants.vbCrLf & "Comment"
			Me.toolStripButton34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem45
			' 
			Me.toolStripPanelItem45.CausesValidation = False
			Me.toolStripPanelItem45.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem45.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton35, Me.toolStripButton36, Me.toolStripButton37, Me.toolStripButton38, Me.toolStripButton39, Me.toolStripButton40})
			Me.toolStripPanelItem45.Name = "toolStripPanelItem45"
			Me.toolStripPanelItem45.ShowItemToolTips = False
			Me.toolStripPanelItem45.Size = New System.Drawing.Size(201, 79)
			Me.toolStripPanelItem45.Text = "toolStripPanelItem45"
			Me.toolStripPanelItem45.Transparent = True
			' 
			' toolStripButton35
			' 
			Me.toolStripButton35.Image = (CType(resources.GetObject("toolStripButton35.Image"), System.Drawing.Image))
			Me.toolStripButton35.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton35.Name = "toolStripButton35"
			Me.toolStripButton35.Size = New System.Drawing.Size(58, 20)
			Me.toolStripButton35.Text = "Delete"
			' 
			' toolStripButton36
			' 
			Me.toolStripButton36.Image = (CType(resources.GetObject("toolStripButton36.Image"), System.Drawing.Image))
			Me.toolStripButton36.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton36.Name = "toolStripButton36"
			Me.toolStripButton36.Size = New System.Drawing.Size(68, 20)
			Me.toolStripButton36.Text = "Previous"
			' 
			' toolStripButton37
			' 
			Me.toolStripButton37.Image = (CType(resources.GetObject("toolStripButton37.Image"), System.Drawing.Image))
			Me.toolStripButton37.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton37.Name = "toolStripButton37"
			Me.toolStripButton37.Size = New System.Drawing.Size(50, 20)
			Me.toolStripButton37.Text = "Next"
			' 
			' toolStripButton38
			' 
			Me.toolStripButton38.Image = (CType(resources.GetObject("toolStripButton38.Image"), System.Drawing.Image))
			Me.toolStripButton38.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton38.Name = "toolStripButton38"
			Me.toolStripButton38.Size = New System.Drawing.Size(129, 20)
			Me.toolStripButton38.Text = "Show\Hide comments"
			' 
			' toolStripButton39
			' 
			Me.toolStripButton39.Image = (CType(resources.GetObject("toolStripButton39.Image"), System.Drawing.Image))
			Me.toolStripButton39.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton39.Name = "toolStripButton39"
			Me.toolStripButton39.Size = New System.Drawing.Size(120, 20)
			Me.toolStripButton39.Text = "Show All Comments"
			' 
			' toolStripButton40
			' 
			Me.toolStripButton40.Image = (CType(resources.GetObject("toolStripButton40.Image"), System.Drawing.Image))
			Me.toolStripButton40.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton40.Name = "toolStripButton40"
			Me.toolStripButton40.Size = New System.Drawing.Size(71, 20)
			Me.toolStripButton40.Text = "Show Ink"
			' 
			' toolStripEx21
			' 
			Me.toolStripEx21.AutoSize = False
			Me.toolStripEx21.CollapsedDropDownButtonText = "Changes"
			Me.toolStripEx21.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx21.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx21.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx21.Image = (CType(resources.GetObject("toolStripEx21.Image"), System.Drawing.Image))
			Me.toolStripEx21.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem46})
			Me.toolStripEx21.Location = New System.Drawing.Point(422, 5)
			Me.toolStripEx21.Name = "toolStripEx21"
			Me.toolStripEx21.ShowItemToolTips = False
			Me.toolStripEx21.Size = New System.Drawing.Size(340, 97)
			Me.toolStripEx21.TabIndex = 2
			Me.toolStripEx21.Text = "Changes"
			' 
			' toolStripPanelItem46
			' 
			Me.toolStripPanelItem46.CausesValidation = False
			Me.toolStripPanelItem46.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem46.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton41, Me.toolStripDropDownButton44, Me.toolStripButton42, Me.toolStripButton43, Me.toolStripButton44, Me.toolStripDropDownButton45})
			Me.toolStripPanelItem46.Name = "toolStripPanelItem46"
			Me.toolStripPanelItem46.ShowItemToolTips = False
			Me.toolStripPanelItem46.Size = New System.Drawing.Size(292, 79)
			Me.toolStripPanelItem46.Text = "toolStripPanelItem46"
			Me.toolStripPanelItem46.Transparent = True
			' 
			' toolStripButton41
			' 
			Me.toolStripButton41.Image = (CType(resources.GetObject("toolStripButton41.Image"), System.Drawing.Image))
			Me.toolStripButton41.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton41.Name = "toolStripButton41"
			Me.toolStripButton41.Size = New System.Drawing.Size(93, 20)
			Me.toolStripButton41.Text = "Protect Sheet"
			' 
			' toolStripDropDownButton44
			' 
			Me.toolStripDropDownButton44.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.restrictEditingToolStripMenuItem, Me.restrictPermissionToolStripMenuItem})
			Me.toolStripDropDownButton44.Image = (CType(resources.GetObject("toolStripDropDownButton44.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton44.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton44.Name = "toolStripDropDownButton44"
			Me.toolStripDropDownButton44.Size = New System.Drawing.Size(122, 20)
			Me.toolStripDropDownButton44.Text = "Protect WorkBook"
			' 
			' restrictEditingToolStripMenuItem
			' 
			Me.restrictEditingToolStripMenuItem.Name = "restrictEditingToolStripMenuItem"
			Me.restrictEditingToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
			Me.restrictEditingToolStripMenuItem.Text = "&Restrict Editing"
			' 
			' restrictPermissionToolStripMenuItem
			' 
			Me.restrictPermissionToolStripMenuItem.Name = "restrictPermissionToolStripMenuItem"
			Me.restrictPermissionToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
			Me.restrictPermissionToolStripMenuItem.Text = "Restrict &Permission"
			' 
			' toolStripButton42
			' 
			Me.toolStripButton42.Image = (CType(resources.GetObject("toolStripButton42.Image"), System.Drawing.Image))
			Me.toolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton42.Name = "toolStripButton42"
			Me.toolStripButton42.Size = New System.Drawing.Size(106, 20)
			Me.toolStripButton42.Text = "Share WorkBook"
			' 
			' toolStripButton43
			' 
			Me.toolStripButton43.Image = (CType(resources.GetObject("toolStripButton43.Image"), System.Drawing.Image))
			Me.toolStripButton43.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton43.Name = "toolStripButton43"
			Me.toolStripButton43.Size = New System.Drawing.Size(166, 20)
			Me.toolStripButton43.Text = "Protect And Share WorkBook"
			' 
			' toolStripButton44
			' 
			Me.toolStripButton44.Image = (CType(resources.GetObject("toolStripButton44.Image"), System.Drawing.Image))
			Me.toolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton44.Name = "toolStripButton44"
			Me.toolStripButton44.Size = New System.Drawing.Size(154, 20)
			Me.toolStripButton44.Text = "Allow users to Edit Ranges"
			' 
			' toolStripDropDownButton45
			' 
			Me.toolStripDropDownButton45.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.highlightChangesToolStripMenuItem})
			Me.toolStripDropDownButton45.Image = (CType(resources.GetObject("toolStripDropDownButton45.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton45.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton45.Name = "toolStripDropDownButton45"
			Me.toolStripDropDownButton45.Size = New System.Drawing.Size(107, 20)
			Me.toolStripDropDownButton45.Text = "Track Changes"
			' 
			' highlightChangesToolStripMenuItem
			' 
			Me.highlightChangesToolStripMenuItem.Name = "highlightChangesToolStripMenuItem"
			Me.highlightChangesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
			Me.highlightChangesToolStripMenuItem.Text = "&Highlight Changes..."
			' 
			' toolStripTabItem7
			' 
			Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem7, "V")
			Me.toolStripTabItem7.Name = "toolStripTabItem7"
			Me.toolStripTabItem7.Padding = New System.Windows.Forms.Padding(8, 2, 8, 5)
			' 
			' excelRibbon.ribbonPanel7
			' 
			Me.toolStripTabItem7.Panel.Controls.Add(Me.toolStripEx22)
			Me.toolStripTabItem7.Panel.Controls.Add(Me.toolStripEx23)
			Me.toolStripTabItem7.Panel.Controls.Add(Me.toolStripEx24)
			Me.toolStripTabItem7.Panel.Controls.Add(Me.toolStripEx25)
			Me.toolStripTabItem7.Panel.Controls.Add(Me.toolStripEx26)
			Me.toolStripTabItem7.Panel.Name = "ribbonPanel7"
			Me.toolStripTabItem7.Panel.ScrollPosition = 0
			Me.toolStripTabItem7.Panel.TabIndex = 8
			Me.toolStripTabItem7.Panel.TabItem = Me.toolStripTabItem7
			Me.toolStripTabItem7.Panel.Text = "View"
			Me.toolStripTabItem7.Size = New System.Drawing.Size(49, 24)
			Me.toolStripTabItem7.Text = "View"
			' 
			' toolStripEx22
			' 
			Me.toolStripEx22.AutoSize = False
			Me.toolStripEx22.CollapsedDropDownButtonText = "View"
			Me.toolStripEx22.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx22.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx22.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx22.Image = (CType(resources.GetObject("toolStripEx22.Image"), System.Drawing.Image))
			Me.toolStripEx22.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem47, Me.toolStripPanelItem48, Me.toolStripPanelItem49})
			Me.toolStripEx22.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx22.Name = "toolStripEx22"
			Me.toolStripEx22.ShowItemToolTips = False
			Me.toolStripEx22.Size = New System.Drawing.Size(154, 106)
			Me.toolStripEx22.TabIndex = 0
			Me.toolStripEx22.Text = "WorkBook Views"
			' 
			' toolStripPanelItem47
			' 
			Me.toolStripPanelItem47.CausesValidation = False
			Me.toolStripPanelItem47.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem47.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton45})
			Me.toolStripPanelItem47.Name = "toolStripPanelItem47"
			Me.toolStripPanelItem47.Size = New System.Drawing.Size(48, 88)
			Me.toolStripPanelItem47.Text = "toolStripPanelItem47"
			Me.toolStripPanelItem47.Transparent = True
			' 
			' toolStripButton45
			' 
			Me.toolStripButton45.AutoSize = False
			Me.toolStripButton45.Image = (CType(resources.GetObject("toolStripButton45.Image"), System.Drawing.Image))
			Me.toolStripButton45.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton45.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton45.Name = "toolStripButton45"
			Me.toolStripButton45.Size = New System.Drawing.Size(44, 80)
			Me.toolStripButton45.Text = "Normal"
			Me.toolStripButton45.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem48
			' 
			Me.toolStripPanelItem48.CausesValidation = False
			Me.toolStripPanelItem48.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem48.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton46})
			Me.toolStripPanelItem48.Name = "toolStripPanelItem48"
			Me.toolStripPanelItem48.Size = New System.Drawing.Size(48, 88)
			Me.toolStripPanelItem48.Text = "toolStripPanelItem48"
			Me.toolStripPanelItem48.Transparent = True
			' 
			' toolStripButton46
			' 
			Me.toolStripButton46.AutoSize = False
			Me.toolStripButton46.Image = (CType(resources.GetObject("toolStripButton46.Image"), System.Drawing.Image))
			Me.toolStripButton46.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton46.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton46.Name = "toolStripButton46"
			Me.toolStripButton46.Size = New System.Drawing.Size(44, 80)
			Me.toolStripButton46.Text = "Page" & Constants.vbCrLf & "Layout"
			Me.toolStripButton46.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem49
			' 
			Me.toolStripPanelItem49.CausesValidation = False
			Me.toolStripPanelItem49.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem49.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton47, Me.toolStripButton48, Me.toolStripButton49})
			Me.toolStripPanelItem49.Name = "toolStripPanelItem49"
			Me.toolStripPanelItem49.ShowItemToolTips = False
			Me.toolStripPanelItem49.Size = New System.Drawing.Size(27, 88)
			Me.toolStripPanelItem49.Text = "toolStripPanelItem49"
			Me.toolStripPanelItem49.Transparent = True
			' 
			' toolStripButton47
			' 
			Me.toolStripButton47.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton47.Image = (CType(resources.GetObject("toolStripButton47.Image"), System.Drawing.Image))
			Me.toolStripButton47.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton47.Name = "toolStripButton47"
			Me.toolStripButton47.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton47.Text = "toolStripButton47"
			Me.toolStripButton47.ToolTipText = "Page Break Preview"
			' 
			' toolStripButton48
			' 
			Me.toolStripButton48.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton48.Image = (CType(resources.GetObject("toolStripButton48.Image"), System.Drawing.Image))
			Me.toolStripButton48.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton48.Name = "toolStripButton48"
			Me.toolStripButton48.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton48.Text = "toolStripButton48"
			Me.toolStripButton48.ToolTipText = "Custom Views"
			' 
			' toolStripButton49
			' 
			Me.toolStripButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton49.Image = (CType(resources.GetObject("toolStripButton49.Image"), System.Drawing.Image))
			Me.toolStripButton49.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton49.Name = "toolStripButton49"
			Me.toolStripButton49.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton49.Text = "toolStripButton49"
			Me.toolStripButton49.ToolTipText = "Toggle full Screen view"
			' 
			' toolStripEx23
			' 
			Me.toolStripEx23.AutoSize = False
			Me.toolStripEx23.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx23.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx23.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx23.Image = (CType(resources.GetObject("toolStripEx23.Image"), System.Drawing.Image))
			Me.toolStripEx23.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton46})
			Me.toolStripEx23.Location = New System.Drawing.Point(154, 1)
			Me.toolStripEx23.Name = "toolStripEx23"
			Me.toolStripEx23.ShowItemToolTips = False
			Me.toolStripEx23.Size = New System.Drawing.Size(77, 106)
			Me.toolStripEx23.TabIndex = 1
			' 
			' toolStripDropDownButton46
			' 
			Me.toolStripDropDownButton46.AutoSize = False
			Me.toolStripDropDownButton46.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem60, Me.toolStripMenuItem62, Me.toolStripMenuItem63, Me.toolStripMenuItem64})
			Me.toolStripDropDownButton46.Image = (CType(resources.GetObject("toolStripDropDownButton46.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton46.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton46.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton46.Name = "toolStripDropDownButton46"
			Me.toolStripDropDownButton46.Size = New System.Drawing.Size(71, 80)
			Me.toolStripDropDownButton46.Text = "Show \" & Constants.vbCrLf & "Hide"
			Me.toolStripDropDownButton46.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripMenuItem60
			' 
			Me.toolStripMenuItem60.Name = "toolStripMenuItem60"
			Me.toolStripMenuItem60.Size = New System.Drawing.Size(143, 22)
			Me.toolStripMenuItem60.Text = "Ruler"
			' 
			' toolStripMenuItem62
			' 
			Me.toolStripMenuItem62.Name = "toolStripMenuItem62"
			Me.toolStripMenuItem62.Size = New System.Drawing.Size(143, 22)
			Me.toolStripMenuItem62.Text = "GridLines"
			' 
			' toolStripMenuItem63
			' 
			Me.toolStripMenuItem63.Name = "toolStripMenuItem63"
			Me.toolStripMenuItem63.Size = New System.Drawing.Size(143, 22)
			Me.toolStripMenuItem63.Text = "FormulaBar"
			' 
			' toolStripMenuItem64
			' 
			Me.toolStripMenuItem64.Name = "toolStripMenuItem64"
			Me.toolStripMenuItem64.Size = New System.Drawing.Size(143, 22)
			Me.toolStripMenuItem64.Text = "Messagebar"
			' 
			' toolStripEx24
			' 
			Me.toolStripEx24.AutoSize = False
			Me.toolStripEx24.CollapsedDropDownButtonText = "Zoom"
			Me.toolStripEx24.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx24.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx24.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx24.Image = Nothing
			Me.toolStripEx24.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton50, Me.toolStripButton51, Me.toolStripPanelItem50})
			Me.toolStripEx24.Location = New System.Drawing.Point(231, 1)
			Me.toolStripEx24.Name = "toolStripEx24"
			Me.toolStripEx24.ShowItemToolTips = False
			Me.toolStripEx24.Size = New System.Drawing.Size(160, 106)
			Me.toolStripEx24.TabIndex = 2
			Me.toolStripEx24.Text = "Zoom"
			' 
			' toolStripButton50
			' 
			Me.toolStripButton50.Image = (CType(resources.GetObject("toolStripButton50.Image"), System.Drawing.Image))
			Me.toolStripButton50.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton50.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton50.Name = "toolStripButton50"
			Me.toolStripButton50.Size = New System.Drawing.Size(37, 85)
			Me.toolStripButton50.Text = "Zoom"
			Me.toolStripButton50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripButton51
			' 
			Me.toolStripButton51.Image = (CType(resources.GetObject("toolStripButton51.Image"), System.Drawing.Image))
			Me.toolStripButton51.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton51.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton51.Name = "toolStripButton51"
			Me.toolStripButton51.Size = New System.Drawing.Size(40, 85)
			Me.toolStripButton51.Text = "100%"
			Me.toolStripButton51.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem50
			' 
			Me.toolStripPanelItem50.CausesValidation = False
			Me.toolStripPanelItem50.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem50.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton52})
			Me.toolStripPanelItem50.Name = "toolStripPanelItem50"
			Me.toolStripPanelItem50.ShowItemToolTips = False
			Me.toolStripPanelItem50.Size = New System.Drawing.Size(56, 88)
			Me.toolStripPanelItem50.Text = "toolStripPanelItem50"
			Me.toolStripPanelItem50.Transparent = True
			' 
			' toolStripButton52
			' 
			Me.toolStripButton52.AutoSize = False
			Me.toolStripButton52.Image = (CType(resources.GetObject("toolStripButton52.Image"), System.Drawing.Image))
			Me.toolStripButton52.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton52.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton52.Name = "toolStripButton52"
			Me.toolStripButton52.Size = New System.Drawing.Size(52, 82)
			Me.toolStripButton52.Text = "Zoom To" & Constants.vbCrLf & "Selection"
			Me.toolStripButton52.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripEx25
			' 
			Me.toolStripEx25.AutoSize = False
			Me.toolStripEx25.CollapsedDropDownButtonText = "Window"
			Me.toolStripEx25.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx25.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx25.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx25.Image = (CType(resources.GetObject("toolStripEx25.Image"), System.Drawing.Image))
			Me.toolStripEx25.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem51, Me.toolStripSeparator2, Me.toolStripPanelItem52, Me.toolStripSeparator3, Me.toolStripPanelItem53})
			Me.toolStripEx25.Location = New System.Drawing.Point(373, 1)
			Me.toolStripEx25.Name = "toolStripEx25"
			Me.toolStripEx25.ShowItemToolTips = False
			Me.toolStripEx25.Size = New System.Drawing.Size(330, 106)
			Me.toolStripEx25.TabIndex = 3
			Me.toolStripEx25.Text = "Window"
			' 
			' toolStripPanelItem51
			' 
			Me.toolStripPanelItem51.CausesValidation = False
			Me.toolStripPanelItem51.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem51.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton53, Me.toolStripButton54, Me.toolStripDropDownButton48, Me.toolStripButton19, Me.toolStripButton20, Me.toolStripButton21})
			Me.toolStripPanelItem51.Name = "toolStripPanelItem51"
			Me.toolStripPanelItem51.ShowItemToolTips = False
			Me.toolStripPanelItem51.Size = New System.Drawing.Size(128, 88)
			Me.toolStripPanelItem51.Text = "toolStripPanelItem51"
			Me.toolStripPanelItem51.Transparent = True
			' 
			' toolStripButton53
			' 
			Me.toolStripButton53.Image = (CType(resources.GetObject("toolStripButton53.Image"), System.Drawing.Image))
			Me.toolStripButton53.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton53.Name = "toolStripButton53"
			Me.toolStripButton53.Size = New System.Drawing.Size(89, 20)
			Me.toolStripButton53.Text = "New Window"
			' 
			' toolStripButton54
			' 
			Me.toolStripButton54.Image = (CType(resources.GetObject("toolStripButton54.Image"), System.Drawing.Image))
			Me.toolStripButton54.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton54.Name = "toolStripButton54"
			Me.toolStripButton54.Size = New System.Drawing.Size(80, 20)
			Me.toolStripButton54.Text = "Arrange All"
			' 
			' toolStripDropDownButton48
			' 
			Me.toolStripDropDownButton48.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.freezeToolStripMenuItem, Me.freezeTopRowToolStripMenuItem, Me.freezeFirstColumnToolStripMenuItem})
			Me.toolStripDropDownButton48.Image = (CType(resources.GetObject("toolStripDropDownButton48.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton48.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton48.Name = "toolStripDropDownButton48"
			Me.toolStripDropDownButton48.Size = New System.Drawing.Size(101, 20)
			Me.toolStripDropDownButton48.Text = "Freeze Panes"
			' 
			' freezeToolStripMenuItem
			' 
			Me.freezeToolStripMenuItem.Name = "freezeToolStripMenuItem"
			Me.freezeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
			Me.freezeToolStripMenuItem.Text = "Freeze"
			' 
			' freezeTopRowToolStripMenuItem
			' 
			Me.freezeTopRowToolStripMenuItem.Name = "freezeTopRowToolStripMenuItem"
			Me.freezeTopRowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
			Me.freezeTopRowToolStripMenuItem.Text = "Freeze Top Row"
			' 
			' freezeFirstColumnToolStripMenuItem
			' 
			Me.freezeFirstColumnToolStripMenuItem.Name = "freezeFirstColumnToolStripMenuItem"
			Me.freezeFirstColumnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
			Me.freezeFirstColumnToolStripMenuItem.Text = "Freeze First Column"
			' 
			' toolStripButton19
			' 
			Me.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton19.Image = (CType(resources.GetObject("toolStripButton19.Image"), System.Drawing.Image))
			Me.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton19.Name = "toolStripButton19"
			Me.toolStripButton19.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton19.Text = "Split"
			' 
			' toolStripButton20
			' 
			Me.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton20.Image = (CType(resources.GetObject("toolStripButton20.Image"), System.Drawing.Image))
			Me.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton20.Name = "toolStripButton20"
			Me.toolStripButton20.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton20.Text = "Hide Window"
			' 
			' toolStripButton21
			' 
			Me.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton21.Image = (CType(resources.GetObject("toolStripButton21.Image"), System.Drawing.Image))
			Me.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton21.Name = "toolStripButton21"
			Me.toolStripButton21.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton21.Text = "Unhide Window"
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 88)
			' 
			' toolStripPanelItem52
			' 
			Me.toolStripPanelItem52.CausesValidation = False
			Me.toolStripPanelItem52.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem52.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton55, Me.toolStripButton56, Me.toolStripButton57})
			Me.toolStripPanelItem52.Name = "toolStripPanelItem52"
			Me.toolStripPanelItem52.ShowItemToolTips = False
			Me.toolStripPanelItem52.Size = New System.Drawing.Size(27, 88)
			Me.toolStripPanelItem52.Text = "toolStripPanelItem52"
			Me.toolStripPanelItem52.Transparent = True
			' 
			' toolStripButton55
			' 
			Me.toolStripButton55.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton55.Image = (CType(resources.GetObject("toolStripButton55.Image"), System.Drawing.Image))
			Me.toolStripButton55.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton55.Name = "toolStripButton55"
			Me.toolStripButton55.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton55.Text = "View side by side"
			Me.toolStripButton55.ToolTipText = "Split"
			' 
			' toolStripButton56
			' 
			Me.toolStripButton56.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton56.Image = (CType(resources.GetObject("toolStripButton56.Image"), System.Drawing.Image))
			Me.toolStripButton56.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton56.Name = "toolStripButton56"
			Me.toolStripButton56.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton56.Text = "Synchronous scrolling"
			Me.toolStripButton56.ToolTipText = "Hide Window"
			' 
			' toolStripButton57
			' 
			Me.toolStripButton57.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton57.Image = (CType(resources.GetObject("toolStripButton57.Image"), System.Drawing.Image))
			Me.toolStripButton57.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton57.Name = "toolStripButton57"
			Me.toolStripButton57.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton57.Text = "Reste Window Position"
			Me.toolStripButton57.ToolTipText = "Unhide Window"
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 88)
			' 
			' toolStripPanelItem53
			' 
			Me.toolStripPanelItem53.CausesValidation = False
			Me.toolStripPanelItem53.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem53.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton58, Me.toolStripDropDownButton49})
			Me.toolStripPanelItem53.Name = "toolStripPanelItem53"
			Me.toolStripPanelItem53.RowCount = 1
			Me.toolStripPanelItem53.ShowItemToolTips = False
			Me.toolStripPanelItem53.Size = New System.Drawing.Size(131, 88)
			Me.toolStripPanelItem53.Text = "toolStripPanelItem53"
			Me.toolStripPanelItem53.Transparent = True
			' 
			' toolStripButton58
			' 
			Me.toolStripButton58.AutoSize = False
			Me.toolStripButton58.Image = (CType(resources.GetObject("toolStripButton58.Image"), System.Drawing.Image))
			Me.toolStripButton58.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton58.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton58.Name = "toolStripButton58"
			Me.toolStripButton58.Size = New System.Drawing.Size(64, 80)
			Me.toolStripButton58.Text = "Save" & Constants.vbCrLf & "Workspace"
			Me.toolStripButton58.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripDropDownButton49
			' 
			Me.toolStripDropDownButton49.AutoSize = False
			Me.toolStripDropDownButton49.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.book1ToolStripMenuItem})
			Me.toolStripDropDownButton49.Image = (CType(resources.GetObject("toolStripDropDownButton49.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton49.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton49.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton49.Name = "toolStripDropDownButton49"
			Me.toolStripDropDownButton49.Size = New System.Drawing.Size(63, 80)
			Me.toolStripDropDownButton49.Text = "Switch" & Constants.vbCrLf & "Windows"
			Me.toolStripDropDownButton49.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' book1ToolStripMenuItem
			' 
			Me.book1ToolStripMenuItem.Name = "book1ToolStripMenuItem"
			Me.book1ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
			Me.book1ToolStripMenuItem.Text = "&1 Book1"
			' 
			' toolStripEx26
			' 
			Me.toolStripEx26.AutoSize = False
			Me.toolStripEx26.CollapsedDropDownButtonText = "Macros"
			Me.toolStripEx26.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx26.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx26.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx26.Image = (CType(resources.GetObject("toolStripEx26.Image"), System.Drawing.Image))
			Me.toolStripEx26.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton47})
			Me.toolStripEx26.Location = New System.Drawing.Point(703, 1)
			Me.toolStripEx26.Name = "toolStripEx26"
			Me.toolStripEx26.ShowItemToolTips = False
			Me.toolStripEx26.Size = New System.Drawing.Size(64, 106)
			Me.toolStripEx26.TabIndex = 4
			Me.toolStripEx26.Text = "Macros"
			' 
			' toolStripDropDownButton47
			' 
			Me.toolStripDropDownButton47.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.viewMacrosToolStripMenuItem, Me.recordMacrosToolStripMenuItem})
			Me.toolStripDropDownButton47.Image = (CType(resources.GetObject("toolStripDropDownButton47.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton47.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton47.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton47.Name = "toolStripDropDownButton47"
			Me.toolStripDropDownButton47.Size = New System.Drawing.Size(54, 85)
			Me.toolStripDropDownButton47.Text = "Macros"
			Me.toolStripDropDownButton47.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' viewMacrosToolStripMenuItem
			' 
			Me.viewMacrosToolStripMenuItem.Name = "viewMacrosToolStripMenuItem"
			Me.viewMacrosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
			Me.viewMacrosToolStripMenuItem.Text = "&View macros"
			' 
			' recordMacrosToolStripMenuItem
			' 
			Me.recordMacrosToolStripMenuItem.Name = "recordMacrosToolStripMenuItem"
			Me.recordMacrosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
			Me.recordMacrosToolStripMenuItem.Text = "&Record Macros"
			' 
			' toolStripButton84
			' 
			Me.toolStripButton84.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton84.Image = (CType(resources.GetObject("toolStripButton84.Image"), System.Drawing.Image))
			Me.toolStripButton84.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton84.Name = "toolStripButton84"
			Me.toolStripButton84.Size = New System.Drawing.Size(267, 17)
			Me.toolStripButton84.Text = "Datasheet 1"
			Me.toolStripButton84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton85
			' 
			Me.toolStripButton85.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton85.Image = (CType(resources.GetObject("toolStripButton85.Image"), System.Drawing.Image))
			Me.toolStripButton85.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton85.Name = "toolStripButton85"
			Me.toolStripButton85.Size = New System.Drawing.Size(267, 17)
			Me.toolStripButton85.Text = "Financial Datasheet"
			Me.toolStripButton85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton86
			' 
			Me.toolStripButton86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton86.Image = (CType(resources.GetObject("toolStripButton86.Image"), System.Drawing.Image))
			Me.toolStripButton86.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton86.Name = "toolStripButton86"
			Me.toolStripButton86.Size = New System.Drawing.Size(267, 17)
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
			toolTipInfo2.Header.Text = "New"
			Me.superToolTip1.SetToolTip(Me.toolStripButton81, toolTipInfo2)
'			Me.toolStripButton81.Click += New System.EventHandler(Me.toolStripButton81_Click);
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
			Me.officeButton101.Size = New System.Drawing.Size(265, 36)
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
			Me.officeButton102.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton106.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton103.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton104.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton105.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton107.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton108.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton109.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton110.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton111.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton115.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton112.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton113.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton114.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton116.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton117.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton118.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton119.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton120.Size = New System.Drawing.Size(265, 45)
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
			Me.officeButton121.Size = New System.Drawing.Size(265, 45)
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
			toolTipInfo10.Header.Text = "Close"
			Me.superToolTip1.SetToolTip(Me.toolStripButton89, toolTipInfo10)
'			Me.toolStripButton89.Click += New System.EventHandler(Me.toolStripButton89_Click);
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
'			Me.toolStripButton6.Click += New System.EventHandler(Me.toolStripButton6_Click);
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
			' xpToolBar1
			' 
			Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.xpToolBar1.Bar.BarName = ""
			Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.gridAwareTextBoxItem1, Me.barItem1, Me.barItem2, Me.gridAwareTextBoxItem2})
			Me.xpToolBar1.Bar.Manager = Nothing
			Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpToolBar1.Location = New System.Drawing.Point(7, 171)
			Me.xpToolBar1.Name = "xpToolBar1"
			Me.xpToolBar1.Size = New System.Drawing.Size(853, 25)
			Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.xpToolBar1.TabIndex = 7
			Me.xpToolBar1.Text = "xpToolBar1"
			' 
			' barItem1
			' 
			Me.barItem1.Image = (CType(resources.GetObject("barItem1.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt))
			Me.barItem1.Tooltip = "Cancel"
			' 
			' barItem2
			' 
			Me.barItem2.Image = (CType(resources.GetObject("barItem2.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt))
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
			Me.officeButton6.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton7.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton8.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton9.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton10.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton11.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton12.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton13.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton14.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton15.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton16.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton17.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton18.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton19.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton20.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton26.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton27.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton28.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton29.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton30.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton31.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton32.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton33.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton34.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton35.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton36.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton37.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton38.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton39.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton40.Size = New System.Drawing.Size(220, 45)
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
            Me.superAccelerator1.SetAccelerator(Me.toolStripButton69, "G")
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
            Me.superAccelerator1.SetAccelerator(Me.toolStripButton70, "SK")
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
			Me.officeButton41.HelpText = "Save for Excel services, specify what is shown in the browser and set options"
			Me.officeButton41.Image = (CType(resources.GetObject("officeButton41.Image"), System.Drawing.Image))
			Me.officeButton41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.officeButton41.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.officeButton41.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.officeButton41.Name = "officeButton41"
			Me.officeButton41.Size = New System.Drawing.Size(220, 36)
			Me.officeButton41.Text = "Excel Services"
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
			Me.officeButton61.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton62.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton63.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton64.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton65.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton66.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton67.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton68.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton69.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton70.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton71.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton72.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton73.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton74.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton75.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton81.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton82.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton83.Size = New System.Drawing.Size(220, 45)
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
			Me.officeButton84.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton85.Size = New System.Drawing.Size(114, 45)
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
			Me.officeButton86.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton87.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton88.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton89.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton90.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton91.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton92.Size = New System.Drawing.Size(192, 45)
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
			Me.officeButton93.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton94.Size = New System.Drawing.Size(118, 45)
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
			Me.officeButton95.Size = New System.Drawing.Size(118, 45)
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
			' scrollersFrame1
			' 
			Me.scrollersFrame1.AttachedTo = Me.excelRibbon
			Me.scrollersFrame1.HorizontalSmallChange = 7
			Me.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame1.VerticallSmallChange = 13
			Me.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
			' 
			' statusStripEx1
			' 
			Me.statusStripEx1.AllowItemReorder = True
			Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripStatusLabel3, Me.trackBarItem2})
			Me.statusStripEx1.Location = New System.Drawing.Point(1, 653)
			Me.statusStripEx1.Name = "statusStripEx1"
			Me.statusStripEx1.Size = New System.Drawing.Size(865, 24)
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
			' gridAwareTextBoxItem1
			' 
			Me.gridAwareTextBoxItem1.CategoryIndex = 12
			Me.gridAwareTextBoxItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridAwareTextBoxItem1.ID = "GridAwareTextBox1"
			Me.gridAwareTextBoxItem1.MinWidth = 200
			Me.gridAwareTextBoxItem1.Text = "GridAwareTextBox1"
			Me.gridAwareTextBoxItem1.TextBoxValue = Nothing
			Me.gridAwareTextBoxItem1.Value = Nothing
			' 
			' gridAwareTextBoxItem2
			' 
			Me.gridAwareTextBoxItem2.CategoryIndex = 12
			Me.gridAwareTextBoxItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridAwareTextBoxItem2.ID = "GridAwareTextBox2"
			Me.gridAwareTextBoxItem2.MinWidth = 592
			Me.gridAwareTextBoxItem2.Text = "GridAwareTextBox2"
			Me.gridAwareTextBoxItem2.TextBoxValue = Nothing
			Me.gridAwareTextBoxItem2.Value = Nothing
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Borders = New System.Windows.Forms.Padding(6, 1, 6, 2)
			Me.ClientSize = New System.Drawing.Size(867, 679)
			Me.Controls.Add(Me.statusStripEx1)
			Me.Controls.Add(Me.xpToolBar1)
			Me.Controls.Add(Me.excelRibbon)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(1)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Excel 2007"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.Resize += New System.EventHandler(Me.Form1_Resize);
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.excelRibbon, System.ComponentModel.ISupportInitialize).EndInit()
			Me.excelRibbon.ResumeLayout(False)
			Me.excelRibbon.PerformLayout()
			Me.toolStripTabItem1.Panel.ResumeLayout(False)
			Me.toolStripTabItem1.Panel.PerformLayout()
			Me.clipboardToolStripExt.ResumeLayout(False)
			Me.clipboardToolStripExt.PerformLayout()
			Me.fontToolStripExt.ResumeLayout(False)
			Me.fontToolStripExt.PerformLayout()
			Me.paragraphToolStripExt.ResumeLayout(False)
			Me.paragraphToolStripExt.PerformLayout()
			Me.toolStripEx3.ResumeLayout(False)
			Me.toolStripEx3.PerformLayout()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.toolStripEx2.ResumeLayout(False)
			Me.toolStripEx2.PerformLayout()
			Me.toolStripTabItem2.Panel.ResumeLayout(False)
			Me.toolStripTabItem2.Panel.PerformLayout()
			Me.toolStripEx28.ResumeLayout(False)
			Me.toolStripEx28.PerformLayout()
			Me.toolStripEx5.ResumeLayout(False)
			Me.toolStripEx5.PerformLayout()
			Me.toolStripEx7.ResumeLayout(False)
			Me.toolStripEx7.PerformLayout()
			Me.toolStripEx6.ResumeLayout(False)
			Me.toolStripEx6.PerformLayout()
			Me.toolStripEx8.ResumeLayout(False)
			Me.toolStripEx8.PerformLayout()
			Me.tablesToolStripExt.ResumeLayout(False)
			Me.tablesToolStripExt.PerformLayout()
			Me.toolStripTabItem3.Panel.ResumeLayout(False)
			Me.toolStripTabItem3.Panel.PerformLayout()
			Me.themesToolStripExt.ResumeLayout(False)
			Me.themesToolStripExt.PerformLayout()
			Me.pageSetupToolStripExt.ResumeLayout(False)
			Me.pageSetupToolStripExt.PerformLayout()
			Me.toolStripEx4.ResumeLayout(False)
			Me.toolStripEx4.PerformLayout()
			Me.toolStripEx9.ResumeLayout(False)
			Me.toolStripEx9.PerformLayout()
			Me.toolStripEx10.ResumeLayout(False)
			Me.toolStripEx10.PerformLayout()
			Me.toolStripTabItem4.Panel.ResumeLayout(False)
			Me.toolStripEx11.ResumeLayout(False)
			Me.toolStripEx11.PerformLayout()
			Me.toolStripEx12.ResumeLayout(False)
			Me.toolStripEx12.PerformLayout()
			Me.toolStripEx13.ResumeLayout(False)
			Me.toolStripEx13.PerformLayout()
			Me.toolStripTabItem5.Panel.ResumeLayout(False)
			Me.toolStripEx14.ResumeLayout(False)
			Me.toolStripEx14.PerformLayout()
			Me.toolStripEx15.ResumeLayout(False)
			Me.toolStripEx15.PerformLayout()
			Me.toolStripEx16.ResumeLayout(False)
			Me.toolStripEx16.PerformLayout()
			Me.toolStripEx17.ResumeLayout(False)
			Me.toolStripEx17.PerformLayout()
			Me.toolStripEx18.ResumeLayout(False)
			Me.toolStripEx18.PerformLayout()
			Me.toolStripTabItem6.Panel.ResumeLayout(False)
			Me.toolStripEx19.ResumeLayout(False)
			Me.toolStripEx19.PerformLayout()
			Me.toolStripEx20.ResumeLayout(False)
			Me.toolStripEx20.PerformLayout()
			Me.toolStripEx21.ResumeLayout(False)
			Me.toolStripEx21.PerformLayout()
			Me.toolStripTabItem7.Panel.ResumeLayout(False)
			Me.toolStripEx22.ResumeLayout(False)
			Me.toolStripEx22.PerformLayout()
			Me.toolStripEx23.ResumeLayout(False)
			Me.toolStripEx23.PerformLayout()
			Me.toolStripEx24.ResumeLayout(False)
			Me.toolStripEx24.PerformLayout()
			Me.toolStripEx25.ResumeLayout(False)
			Me.toolStripEx25.PerformLayout()
			Me.toolStripEx26.ResumeLayout(False)
			Me.toolStripEx26.PerformLayout()
			Me.statusStripEx1.ResumeLayout(False)
			Me.statusStripEx1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents excelRibbon As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private clipboardToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem15 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripBtnPaste As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownBtnPaste As System.Windows.Forms.ToolStripDropDownButton
		Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteSpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteAsHyperlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripBtnCut As System.Windows.Forms.ToolStripButton
		Private toolStripBtnCopy As System.Windows.Forms.ToolStripButton
		Private toolStripBtnPaint As System.Windows.Forms.ToolStripButton
		Private fontToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripFontfaceComboBox As System.Windows.Forms.ToolStripComboBox
		Private toolStripFontSizeComboBox As System.Windows.Forms.ToolStripComboBox
		Private paragraphToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private lAlignToolStripBtn As System.Windows.Forms.ToolStripButton
		Private centerToolStripBtn As System.Windows.Forms.ToolStripButton
		Private rAlignToolStripBtn As System.Windows.Forms.ToolStripButton
		Private toolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem3 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem4 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem5 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem6 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem7 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripSplitButtonEx1 As Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx
		Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private boldToolstripBtn As System.Windows.Forms.ToolStripButton
		Private italicToolStripBtn As System.Windows.Forms.ToolStripButton
		Private underlineToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private moreUnderlinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private underlineColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private automaticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx3 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private General_toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem7 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem9 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem10 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem11 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton4 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton5 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem12 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem13 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton6 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem17 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem18 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton10 As System.Windows.Forms.ToolStripDropDownButton
		Private tablesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private tableToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private insertTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private drawTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private convertTextToTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private excelSpreadsheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private quickTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private saveSelectionToQuickTablToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private themesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private themesToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private resetToThemeFromTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private searchOfficeOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private browseForThemesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private saveCurrentThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem22 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private themeColorToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private createNewThemeColorsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private themeFontToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private createNewThemeFontsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private themeEffectsToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private pageSetupToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private marginToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private customMarginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem44 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private orientationToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private sizeToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private morePaperSizesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private columnsToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private moreColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem23 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private breaksToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private lnumbersToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private noneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private continuousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private restartEachPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private restartEachSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private suppressForCurrentSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
		Private moreLineNumberingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private hyphenationToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private noneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private automaticToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private manualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
		Private hyphenationOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx4 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem24 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripEx9 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem26 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel2 As System.Windows.Forms.ToolStripLabel
		Private toolStripPanelItem27 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel3 As System.Windows.Forms.ToolStripLabel
		Private toolStripLabel4 As System.Windows.Forms.ToolStripLabel
		Private toolStripLabel5 As System.Windows.Forms.ToolStripLabel
		Private toolStripLabel6 As System.Windows.Forms.ToolStripLabel
		Private toolStripLabel7 As System.Windows.Forms.ToolStripLabel
		Private toolStripEx10 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton24 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx11 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem28 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton13 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem29 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton25 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton26 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton27 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton28 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton29 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton30 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton31 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton32 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton33 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx12 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem30 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem31 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton15 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton34 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton35 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx13 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem32 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton36 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton37 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx14 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem33 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton38 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx15 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem34 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton39 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem35 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton16 As System.Windows.Forms.ToolStripButton
		Private toolStripButton17 As System.Windows.Forms.ToolStripButton
		Private toolStripEx16 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem36 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton22 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem37 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton23 As System.Windows.Forms.ToolStripButton
		Private toolStripButton24 As System.Windows.Forms.ToolStripButton
		Private toolStripButton25 As System.Windows.Forms.ToolStripButton
		Private toolStripEx17 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem38 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton26 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem39 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton27 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem40 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton40 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton28 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton41 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx18 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem41 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton42 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton43 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton29 As System.Windows.Forms.ToolStripButton
		Private toolStripEx19 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton30 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem42 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton31 As System.Windows.Forms.ToolStripButton
		Private toolStripButton32 As System.Windows.Forms.ToolStripButton
		Private toolStripButton33 As System.Windows.Forms.ToolStripButton
		Private toolStripEx20 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem43 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton34 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem45 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton35 As System.Windows.Forms.ToolStripButton
		Private toolStripButton36 As System.Windows.Forms.ToolStripButton
		Private toolStripButton37 As System.Windows.Forms.ToolStripButton
		Private toolStripButton38 As System.Windows.Forms.ToolStripButton
		Private toolStripButton39 As System.Windows.Forms.ToolStripButton
		Private toolStripButton40 As System.Windows.Forms.ToolStripButton
		Private toolStripEx21 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem46 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton41 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton44 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton42 As System.Windows.Forms.ToolStripButton
		Private toolStripButton43 As System.Windows.Forms.ToolStripButton
		Private toolStripButton44 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton45 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx22 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem47 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton45 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem48 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton46 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem49 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton47 As System.Windows.Forms.ToolStripButton
		Private toolStripButton48 As System.Windows.Forms.ToolStripButton
		Private toolStripButton49 As System.Windows.Forms.ToolStripButton
		Private toolStripEx23 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton46 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx24 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton50 As System.Windows.Forms.ToolStripButton
		Private toolStripButton51 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem50 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton52 As System.Windows.Forms.ToolStripButton
		Private toolStripEx25 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem51 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton53 As System.Windows.Forms.ToolStripButton
		Private toolStripButton54 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton48 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private toolStripPanelItem52 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton55 As System.Windows.Forms.ToolStripButton
		Private toolStripButton56 As System.Windows.Forms.ToolStripButton
		Private toolStripButton57 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private toolStripPanelItem53 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripEx26 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton47 As System.Windows.Forms.ToolStripDropDownButton

		Friend gridAwareTextBoxItem1 As ExcelLikeUI_2005.GridAwareTextBoxBarItem
		Friend workBook As WorkBook = Nothing
		Private childWorkBookNumber As Integer = 1
		Private toolStripPanelItem54 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton59 As System.Windows.Forms.ToolStripButton
		Private toolStripButton60 As System.Windows.Forms.ToolStripButton
		Private toolStripButton61 As System.Windows.Forms.ToolStripButton
		Private toolStripEx5 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem19 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton11 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx7 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton12 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem20 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton13 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton14 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton15 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton16 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton17 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton18 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx8 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem21 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton19 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton20 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton21 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private toolStripButton12 As System.Windows.Forms.ToolStripButton
		Friend gridAwareTextBoxItem2 As GridAwareTextBoxBarItem
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
		Private toolStripButton7 As System.Windows.Forms.ToolStripButton
		Private toolStripButton9 As System.Windows.Forms.ToolStripButton
		Private toolStripButton63 As System.Windows.Forms.ToolStripButton
		Private toolStripButton68 As System.Windows.Forms.ToolStripButton
		Private toolStripButton71 As System.Windows.Forms.ToolStripButton
		Private toolStripButton74 As System.Windows.Forms.ToolStripButton
		Private toolStripButton69 As System.Windows.Forms.ToolStripButton
		Private toolStripButton70 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton50 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButtonEx2 As Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx
		Private toolStripButton73 As System.Windows.Forms.ToolStripButton
		Private toolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton8 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem8 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private deindentToolStripBtn As System.Windows.Forms.ToolStripButton
		Private inindentToolStripBtn As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
		Private toolStripEx28 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton51 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton72 As System.Windows.Forms.ToolStripButton
		Private toolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton75 As System.Windows.Forms.ToolStripButton
		Private toolStripButton76 As System.Windows.Forms.ToolStripButton
		Private toolStripButton77 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem16 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
		Private toolStripLabel21 As System.Windows.Forms.ToolStripLabel
		Private toolStripPanelItem14 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel20 As System.Windows.Forms.ToolStripLabel
		Private toolStripPanelItem25 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
		Private toolStripComboBox3 As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem55 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem56 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem57 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel26 As System.Windows.Forms.ToolStripLabel
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
		Private toolStripButton21 As System.Windows.Forms.ToolStripButton
		Private toolStripButton58 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton49 As System.Windows.Forms.ToolStripDropDownButton
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
		Private toolStripDropDownButton9 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton78 As System.Windows.Forms.ToolStripButton
		Private toolStripButton79 As System.Windows.Forms.ToolStripButton
		Private mergeCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergeAcrossToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergeCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private unmergeCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton82 As System.Windows.Forms.ToolStripButton
		Private toolStripButton83 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton89 As System.Windows.Forms.ToolStripButton
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
		Private WithEvents toolStripButton81 As System.Windows.Forms.ToolStripButton
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
		Private toolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
		Private toolStripMenuItem30 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem31 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
		Private toolStripMenuItem32 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem33 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
		Private toolStripMenuItem34 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem52 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem35 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem37 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem38 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem39 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem41 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem42 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem43 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem44 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem45 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem46 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem47 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem48 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem49 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem50 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem51 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem53 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem54 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem55 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem56 As System.Windows.Forms.ToolStripMenuItem
		Private recentlyUsedShapesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private linesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private rectanglesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private basicShapesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private coneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cylinderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pyramidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dLineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private dPieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private dBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dBarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private dAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dAreaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private otherScatterTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private stockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private surfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private doughnutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private bubbleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private horizontalTextBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private verticalTextBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private microsoftSignatureLinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private stampSignatureLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private officeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private apexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private wideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private narrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private customMarginsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private portraitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private landscapeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private inToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private removePageBreakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem57 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem58 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem59 As System.Windows.Forms.ToolStripMenuItem
		Private sumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private countNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private minToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private maxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private sUMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private mINToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private mAXToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private hYPERLINKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dISCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aNDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private oRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private nOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fALSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tRUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cHARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cLEANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cODEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cONCATENATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dATEVALUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private eDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aBSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aSINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aCOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aREASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aDDRESSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cHOOSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cOLUMNSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private statisticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private engineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private informationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private defineNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private applyNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private traceDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private traceDependentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private removeArrowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private calculateNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private calculateSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fromAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fromWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fromTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fromOtherSourcesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private refreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private refreshAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private refreshStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private cancelRefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private dataValidationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private circleInvalidDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clearValidationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private scenarioManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private goalSeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem61 As System.Windows.Forms.ToolStripMenuItem
		Private groupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private autoOutlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private ungroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clearOutlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private restrictEditingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private restrictPermissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private highlightChangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem60 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem62 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem63 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem64 As System.Windows.Forms.ToolStripMenuItem
		Private freezeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private freezeTopRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private freezeFirstColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private book1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private viewMacrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private recordMacrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private scrollersFrame1 As Syncfusion.Windows.Forms.ScrollersFrame
		Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
		Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
		Private toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
		Private trackBarItem2 As Syncfusion.Windows.Forms.Tools.TrackBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private toolStripButton84 As System.Windows.Forms.ToolStripButton
		Private toolStripButton85 As System.Windows.Forms.ToolStripButton
		Private toolStripButton86 As System.Windows.Forms.ToolStripButton
		Private toolStripButton87 As System.Windows.Forms.ToolStripButton
		Private toolStripButton88 As System.Windows.Forms.ToolStripButton
		Private toolStripButton99 As System.Windows.Forms.ToolStripButton
		Private toolStripStatusLabel2 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private noBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
		Private toolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
		Private toolStripLabel19 As System.Windows.Forms.ToolStripButton

	End Class
End Namespace

