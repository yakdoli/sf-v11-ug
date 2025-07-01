Imports Microsoft.VisualBasic
Imports System
Namespace OutlookDemo
	Friend partial Class NewMailForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMailForm))
            Dim ToolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo5 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo6 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo7 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo8 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo9 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo10 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo11 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo12 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo13 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo14 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo15 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo16 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo17 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
            Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton18 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton19 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton20 = New System.Windows.Forms.ToolStripButton
            Me.newMailMessageToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.sendtoolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
            Me.savetoolStripButton = New System.Windows.Forms.ToolStripButton
            Me.saveasToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.deleteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.officeSplitButton1 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
            Me.propertiesToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton
            Me.messageTabStripItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.toolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messagePasteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messageCutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageCopyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.formatPaintertoolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messageFontListComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.messageFontSizeComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton16 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripSplitButton4 = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewBulletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSplitButton5 = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewNumberFormatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.setNumberingValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton17 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messageBoldToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageItalicToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageUnderlineToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem8 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripSplitButton6 = New System.Windows.Forms.ToolStripSplitButton
            Me.noColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.moreColorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSplitButton7 = New System.Windows.Forms.ToolStripSplitButton
            Me.moreColorsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem21 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messageLeftAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageCenterAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageRightToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem22 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.messageIndentToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.messageOutdentToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx10 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton35 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton36 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx11 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton37 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton38 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton8 = New System.Windows.Forms.ToolStripDropDownButton
            Me.otherBusinessCardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripButton39 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton9 = New System.Windows.Forms.ToolStripDropDownButton
            Me.signToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.signaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripEx12 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripDropDownButton25 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSplitButton12 = New System.Windows.Forms.ToolStripSplitButton
            Me.blueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.blackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.silverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.toolStripEx13 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton43 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton44 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton12 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripButton45 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton13 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripEx14 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton46 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx15 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton47 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton48 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton14 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripButton49 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton50 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx16 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton51 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton52 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx17 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem32 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripDropDownButton26 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton27 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton28 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem33 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripDropDownButton29 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripButton58 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton59 = New System.Windows.Forms.ToolStripButton
            Me.toolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.toolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.themesToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem23 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripSplitButton8 = New System.Windows.Forms.ToolStripSplitButton
            Me.toolStripSplitButton9 = New System.Windows.Forms.ToolStripSplitButton
            Me.toolStripSplitButton10 = New System.Windows.Forms.ToolStripSplitButton
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripDropDownButton6 = New System.Windows.Forms.ToolStripDropDownButton
            Me.noColorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.moreColorsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
            Me.fillEffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripEx6 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton26 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton27 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton28 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton29 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton30 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx8 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem24 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton31 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton32 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx9 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripSplitButton11 = New System.Windows.Forms.ToolStripSplitButton
            Me.otherFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.useDefaultFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.donotSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripButton33 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton34 = New System.Windows.Forms.ToolStripButton
            Me.toolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.formatClipboardToolStripEx = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem9 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.formattextPasteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton5 = New System.Windows.Forms.ToolStripDropDownButton
            Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem10 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.formattextCutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.formattextCopyAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton
            Me.fontToolStripEx = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem11 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.fontToolStripComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.fontSizeComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripPanelItem12 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.growtoolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.shrinktoolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem13 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.boldtoolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.italictoolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.underlinetoolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.strikethroughtoolStripButton6 = New System.Windows.Forms.ToolStripButton
            Me.subscripttoolStripButton7 = New System.Windows.Forms.ToolStripButton
            Me.superscripttoolStripButton8 = New System.Windows.Forms.ToolStripButton
            Me.changecaseToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
            Me.sentenceCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.lowerCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.upperCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.capitalizeEachWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.tOGGLECASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem14 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.textHighlightColorToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
            Me.formatColorToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton
            Me.paragraphToolStripEx = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.bulletToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewBulletToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.numericBulletToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewNumberFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.setNumericValueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.numberBulletToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewMultiLevelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewListStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem16 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.leftindenttoolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.rightindenttoolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem17 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem18 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.formattextLeftAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.formattextCenterAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.formattextRightAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.formattextJustifyAlignToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem19 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
            Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem20 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton
            Me.noColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.moreColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSplitButton3 = New System.Windows.Forms.ToolStripSplitButton
            Me.bottomBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.rightBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.leftBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.topBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.noBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.allBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insideBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.outsideBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.insideHorizontalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insideVerticalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.diagonalDownBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.diagonalUpBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.horizontalLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.drawTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.viewGridLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.borderAndShadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.stylesToolStripEx = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton
            Me.saveSelectionAsNewStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.clearFormattingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.applyStylesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.findToolStripDropDownButton = New System.Windows.Forms.ToolStripSplitButton
            Me.findToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.gotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton4 = New System.Windows.Forms.ToolStripSplitButton
            Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.selectObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.selectTextWithSimilarFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.quickButtonReflectable2 = New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
            Me.quickButtonReflectable3 = New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
            Me.quickButtonReflectable1 = New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
            Me.toolStripDropDownButton23 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripPanelItem30 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton54 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton55 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem31 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton56 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton24 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem27 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripDropDownButton15 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton16 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton17 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem28 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripDropDownButton18 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton19 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton20 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem29 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripDropDownButton21 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripDropDownButton22 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripButton53 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton10 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripPanelItem25 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton40 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton41 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem26 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton42 = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownButton11 = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
            Me.subjectTextBox = New System.Windows.Forms.TextBox
            Me.ccTextBoxExt = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.toTextBoxExt = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.ccbuttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.toButtonAdv = New Syncfusion.Windows.Forms.ButtonAdv
            Me.sendButtonAdv = New Syncfusion.Windows.Forms.ButtonAdv
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ribbonControlAdv1.SuspendLayout()
            Me.messageTabStripItem.Panel.SuspendLayout()
            Me.toolStripEx3.SuspendLayout()
            Me.toolStripEx4.SuspendLayout()
            Me.toolStripEx10.SuspendLayout()
            Me.toolStripEx11.SuspendLayout()
            Me.toolStripEx12.SuspendLayout()
            Me.toolStripTabItem1.Panel.SuspendLayout()
            Me.toolStripEx13.SuspendLayout()
            Me.toolStripEx14.SuspendLayout()
            Me.toolStripEx15.SuspendLayout()
            Me.toolStripEx16.SuspendLayout()
            Me.toolStripEx17.SuspendLayout()
            Me.toolStripTabItem2.Panel.SuspendLayout()
            Me.toolStripEx5.SuspendLayout()
            Me.toolStripEx6.SuspendLayout()
            Me.toolStripEx7.SuspendLayout()
            Me.toolStripEx8.SuspendLayout()
            Me.toolStripEx9.SuspendLayout()
            Me.toolStripTabItem3.Panel.SuspendLayout()
            Me.formatClipboardToolStripEx.SuspendLayout()
            Me.fontToolStripEx.SuspendLayout()
            Me.paragraphToolStripEx.SuspendLayout()
            Me.stylesToolStripEx.SuspendLayout()
            Me.toolStripEx2.SuspendLayout()
            Me.toolStripEx1.SuspendLayout()
            CType(Me.ccTextBoxExt, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toTextBoxExt, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ribbonControlAdv1
            '
            Me.ribbonControlAdv1.CanReduceCaptionLength = False
            Me.ribbonControlAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ribbonControlAdv1.Header.AddMainItem(messageTabStripItem)
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2)
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem3)
            Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
            Me.ribbonControlAdv1.MaximizeToolTip = "Maximize Ribbon"
            Me.ribbonControlAdv1.MenuButtonText = ""
            Me.ribbonControlAdv1.MenuColor = System.Drawing.Color.Red
            Me.ribbonControlAdv1.MinimizeToolTip = "Minimize Ribbon"
            Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
            '
            'ribbonControlAdv1.OfficeMenu
            '
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.toolStripSeparator9, Me.toolStripButton8, Me.toolStripButton11, Me.toolStripButton12, Me.toolStripButton13, Me.toolStripButton18, Me.toolStripButton19, Me.toolStripButton20})
            Me.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newMailMessageToolStripButton1, Me.sendtoolStripButton, Me.toolStripSeparator7, Me.savetoolStripButton, Me.saveasToolStripButton, Me.deleteToolStripButton, Me.officeSplitButton1, Me.toolStripSeparator8, Me.propertiesToolStripButton1, Me.closeToolStripButton})
            Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
            Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(280, 361)
            Me.ribbonControlAdv1.OfficeMenu.SystemPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton7})
            Me.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
            Me.ribbonControlAdv1.SelectedTab = Me.messageTabStripItem
            Me.ribbonControlAdv1.Size = New System.Drawing.Size(1022, 154)
            Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
            Me.ribbonControlAdv1.TabIndex = 0
            Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
            Me.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
            Me.ribbonControlAdv1.TitleFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(131, 13)
            Me.toolStripLabel1.Text = "Create New Outlook Item"
            '
            'toolStripSeparator9
            '
            Me.toolStripSeparator9.Name = "toolStripSeparator9"
            Me.toolStripSeparator9.Size = New System.Drawing.Size(115, 2)
            '
            'toolStripButton8
            '
            Me.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton8.Name = "toolStripButton8"
            Me.toolStripButton8.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton8.Text = "&1. Mail Message"
            '
            'toolStripButton11
            '
            Me.toolStripButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton11.Text = "&2. Appointment"
            '
            'toolStripButton12
            '
            Me.toolStripButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton12.Name = "toolStripButton12"
            Me.toolStripButton12.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton12.Text = "&3. Meeting Request"
            '
            'toolStripButton13
            '
            Me.toolStripButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton13.Name = "toolStripButton13"
            Me.toolStripButton13.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton13.Text = "&4. Contact"
            '
            'toolStripButton18
            '
            Me.toolStripButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton18.Name = "toolStripButton18"
            Me.toolStripButton18.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton18.Text = "&5. Distribution List"
            '
            'toolStripButton19
            '
            Me.toolStripButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton19.Name = "toolStripButton19"
            Me.toolStripButton19.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton19.Text = "&6. Task"
            '
            'toolStripButton20
            '
            Me.toolStripButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton20.Name = "toolStripButton20"
            Me.toolStripButton20.Size = New System.Drawing.Size(131, 20)
            Me.toolStripButton20.Text = "&7. Notes"
            '
            'newMailMessageToolStripButton1
            '
            Me.newMailMessageToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.newMailMessageToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.newMailMessageToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.newMailMessageToolStripButton1.Name = "newMailMessageToolStripButton1"
            Me.newMailMessageToolStripButton1.Size = New System.Drawing.Size(135, 38)
            Me.newMailMessageToolStripButton1.Text = "New Mail Message"
            '
            'sendtoolStripButton
            '
            Me.sendtoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.sendtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sendtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sendtoolStripButton.Name = "sendtoolStripButton"
            Me.sendtoolStripButton.Size = New System.Drawing.Size(135, 26)
            Me.sendtoolStripButton.Text = "Send"
            '
            'toolStripSeparator7
            '
            Me.toolStripSeparator7.Name = "toolStripSeparator7"
            Me.toolStripSeparator7.Size = New System.Drawing.Size(119, 2)
            '
            'savetoolStripButton
            '
            Me.savetoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.savetoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.savetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.savetoolStripButton.Name = "savetoolStripButton"
            Me.savetoolStripButton.Size = New System.Drawing.Size(135, 32)
            Me.savetoolStripButton.Text = "Save"
            '
            'saveasToolStripButton
            '
            Me.saveasToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.saveasToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.saveasToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.saveasToolStripButton.Name = "saveasToolStripButton"
            Me.saveasToolStripButton.Size = New System.Drawing.Size(135, 38)
            Me.saveasToolStripButton.Text = "Save As"
            '
            'deleteToolStripButton
            '
            Me.deleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.deleteToolStripButton.Name = "deleteToolStripButton"
            Me.deleteToolStripButton.Size = New System.Drawing.Size(135, 38)
            Me.deleteToolStripButton.Text = "Delete"
            '
            'officeSplitButton1
            '
            Me.officeSplitButton1.DropDownButtonWidth = 19
            Me.officeSplitButton1.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.officeSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripButton5, Me.toolStripButton6})
            Me.officeSplitButton1.DropDownText = Nothing
            Me.officeSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeSplitButton1.Name = "officeSplitButton1"
            Me.officeSplitButton1.Size = New System.Drawing.Size(135, 39)
            Me.officeSplitButton1.Text = "Move"
            Me.officeSplitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'toolStripButton1
            '
            Me.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(66, 19)
            Me.toolStripButton1.Text = "Inbox"
            '
            'toolStripButton5
            '
            Me.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(66, 19)
            Me.toolStripButton5.Text = "Sent Items"
            '
            'toolStripButton6
            '
            Me.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(66, 19)
            Me.toolStripButton6.Text = "Personals"
            '
            'toolStripSeparator8
            '
            Me.toolStripSeparator8.Name = "toolStripSeparator8"
            Me.toolStripSeparator8.Size = New System.Drawing.Size(119, 2)
            '
            'propertiesToolStripButton1
            '
            Me.propertiesToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.propertiesToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.propertiesToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.propertiesToolStripButton1.Name = "propertiesToolStripButton1"
            Me.propertiesToolStripButton1.Size = New System.Drawing.Size(135, 38)
            Me.propertiesToolStripButton1.Text = "Properties"
            '
            'closeToolStripButton
            '
            Me.closeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.closeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.closeToolStripButton.Name = "closeToolStripButton"
            Me.closeToolStripButton.Size = New System.Drawing.Size(135, 34)
            Me.closeToolStripButton.Text = "Close"
            '
            'toolStripButton7
            '
            Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton7.Image = CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image)
            Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton7.Name = "toolStripButton7"
            Me.toolStripButton7.Size = New System.Drawing.Size(79, 17)
            Me.toolStripButton7.Text = "Editor Options"
            '
            'messageTabStripItem
            '
            Me.messageTabStripItem.Font = New System.Drawing.Font("Calibri", 9.0!)
            Me.messageTabStripItem.Name = "messageTabStripItem"
            '
            'ribbonControlAdv1.RibbonPanel1
            '
            Me.messageTabStripItem.Panel.Controls.Add(Me.toolStripEx3)
            Me.messageTabStripItem.Panel.Controls.Add(Me.toolStripEx4)
            Me.messageTabStripItem.Panel.Controls.Add(Me.toolStripEx10)
            Me.messageTabStripItem.Panel.Controls.Add(Me.toolStripEx11)
            Me.messageTabStripItem.Panel.Controls.Add(Me.toolStripEx12)
            Me.messageTabStripItem.Panel.Name = "RibbonPanel1"
            Me.messageTabStripItem.Panel.ScrollPosition = 0
            Me.messageTabStripItem.Panel.TabIndex = 1
            Me.messageTabStripItem.Panel.Text = "Message"
            Me.messageTabStripItem.Position = 0
            Me.messageTabStripItem.Size = New System.Drawing.Size(62, 20)
            Me.messageTabStripItem.Text = "Message"
            '
            'toolStripEx3
            '
            Me.toolStripEx3.AutoSize = False
            Me.toolStripEx3.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx3.Image = Nothing
            Me.toolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem1, Me.toolStripPanelItem2})
            Me.toolStripEx3.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx3.Name = "toolStripEx3"
            Me.toolStripEx3.Size = New System.Drawing.Size(108, 92)
            Me.toolStripEx3.TabIndex = 1
            Me.toolStripEx3.Text = "Clipboard"
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messagePasteToolStripButton, Me.toolStripDropDownButton1})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(54, 74)
            Me.toolStripPanelItem1.Transparent = True
            '
            'messagePasteToolStripButton
            '
            Me.messagePasteToolStripButton.AutoSize = False
            Me.messagePasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messagePasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.messagePasteToolStripButton.ImageTransparentColor = System.Drawing.SystemColors.ButtonHighlight
            Me.messagePasteToolStripButton.Name = "messagePasteToolStripButton"
            Me.messagePasteToolStripButton.Size = New System.Drawing.Size(50, 50)
            Me.messagePasteToolStripButton.Text = "Paste"
            ToolTipInfo1.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Body.Text = "Paste from Clipboard"
            ToolTipInfo1.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messagePasteToolStripButton, ToolTipInfo1)
            '
            'toolStripDropDownButton1
            '
            Me.toolStripDropDownButton1.AutoSize = False
            Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem2})
            Me.toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
            Me.toolStripDropDownButton1.Size = New System.Drawing.Size(50, 20)
            Me.toolStripDropDownButton1.Text = "Paste"
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
            Me.toolStripMenuItem1.Text = "Paste"
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
            Me.toolStripMenuItem2.Text = "Paste Special"
            '
            'toolStripPanelItem2
            '
            Me.toolStripPanelItem2.CausesValidation = False
            Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messageCutToolStripButton, Me.messageCopyToolStripButton, Me.formatPaintertoolStripButton4})
            Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
            Me.toolStripPanelItem2.Size = New System.Drawing.Size(27, 74)
            Me.toolStripPanelItem2.Text = "toolStripPanelItem10"
            Me.toolStripPanelItem2.Transparent = True
            '
            'messageCutToolStripButton
            '
            Me.messageCutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageCutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageCutToolStripButton.Name = "messageCutToolStripButton"
            Me.messageCutToolStripButton.Size = New System.Drawing.Size(23, 4)
            Me.messageCutToolStripButton.Text = "Cut"
            ToolTipInfo2.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Body.Text = "Cut"
            ToolTipInfo2.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messageCutToolStripButton, ToolTipInfo2)
            '
            'messageCopyToolStripButton
            '
            Me.messageCopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageCopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageCopyToolStripButton.Name = "messageCopyToolStripButton"
            Me.messageCopyToolStripButton.Size = New System.Drawing.Size(23, 4)
            Me.messageCopyToolStripButton.Text = "Copy"
            ToolTipInfo3.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Body.Text = "Copy"
            ToolTipInfo3.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messageCopyToolStripButton, ToolTipInfo3)
            '
            'formatPaintertoolStripButton4
            '
            Me.formatPaintertoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formatPaintertoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formatPaintertoolStripButton4.Name = "formatPaintertoolStripButton4"
            Me.formatPaintertoolStripButton4.Size = New System.Drawing.Size(23, 4)
            Me.formatPaintertoolStripButton4.Text = "Format Painter"
            ToolTipInfo4.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Footer.Text = "Format Painter"
            ToolTipInfo4.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.formatPaintertoolStripButton4, ToolTipInfo4)
            '
            'toolStripEx4
            '
            Me.toolStripEx4.AutoSize = False
            Me.toolStripEx4.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx4.Font = New System.Drawing.Font("Calibri", 9.0!)
            Me.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx4.Image = Nothing
            Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem3, Me.toolStripPanelItem4, Me.toolStripPanelItem5, Me.toolStripPanelItem6, Me.toolStripPanelItem7, Me.toolStripPanelItem8, Me.toolStripPanelItem21, Me.toolStripPanelItem22})
            Me.toolStripEx4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.toolStripEx4.Location = New System.Drawing.Point(110, 1)
            Me.toolStripEx4.Name = "toolStripEx4"
            Me.toolStripEx4.Size = New System.Drawing.Size(333, 92)
            Me.toolStripEx4.TabIndex = 2
            Me.toolStripEx4.Text = "Basic Text"
            '
            'toolStripPanelItem3
            '
            Me.toolStripPanelItem3.AutoSize = False
            Me.toolStripPanelItem3.CausesValidation = False
            Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem3.GroupedButtons = True
            Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messageFontListComboBox, Me.messageFontSizeComboBox})
            Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
            Me.toolStripPanelItem3.Size = New System.Drawing.Size(166, 30)
            Me.toolStripPanelItem3.Text = "toolStripPanelItem3"
            Me.toolStripPanelItem3.Transparent = True
            Me.toolStripPanelItem3.UseStandardLayout = True
            '
            'messageFontListComboBox
            '
            Me.messageFontListComboBox.Name = "messageFontListComboBox"
            Me.messageFontListComboBox.Size = New System.Drawing.Size(121, 26)
            Me.messageFontListComboBox.ToolTipText = "Font List"
            '
            'messageFontSizeComboBox
            '
            Me.messageFontSizeComboBox.AutoSize = False
            Me.messageFontSizeComboBox.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
            Me.messageFontSizeComboBox.Name = "messageFontSizeComboBox"
            Me.messageFontSizeComboBox.Size = New System.Drawing.Size(35, 23)
            Me.messageFontSizeComboBox.ToolTipText = "Font Size"
            '
            'toolStripPanelItem4
            '
            Me.toolStripPanelItem4.AutoSize = False
            Me.toolStripPanelItem4.CausesValidation = False
            Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem4.GroupedButtons = True
            Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton15, Me.toolStripButton16})
            Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Size = New System.Drawing.Size(52, 30)
            Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Transparent = True
            Me.toolStripPanelItem4.UseStandardLayout = True
            '
            'toolStripButton15
            '
            Me.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton15.Name = "toolStripButton15"
            Me.toolStripButton15.Size = New System.Drawing.Size(23, 23)
            Me.toolStripButton15.Text = "toolStripButton15"
            '
            'toolStripButton16
            '
            Me.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton16.Name = "toolStripButton16"
            Me.toolStripButton16.Size = New System.Drawing.Size(23, 23)
            Me.toolStripButton16.Text = "toolStripButton16"
            '
            'toolStripPanelItem5
            '
            Me.toolStripPanelItem5.AutoSize = False
            Me.toolStripPanelItem5.CausesValidation = False
            Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem5.GroupedButtons = True
            Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton4, Me.toolStripSplitButton5})
            Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
            Me.toolStripPanelItem5.Size = New System.Drawing.Size(70, 30)
            Me.toolStripPanelItem5.Text = "toolStripPanelItem5"
            Me.toolStripPanelItem5.Transparent = True
            Me.toolStripPanelItem5.UseStandardLayout = True
            '
            'toolStripSplitButton4
            '
            Me.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem, Me.defineNewBulletToolStripMenuItem})
            Me.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton4.Name = "toolStripSplitButton4"
            Me.toolStripSplitButton4.Size = New System.Drawing.Size(16, 23)
            Me.toolStripSplitButton4.Text = "toolStripSplitButton4"
            ToolTipInfo5.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Body.Text = "Bullets"
            ToolTipInfo5.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripSplitButton4, ToolTipInfo5)
            '
            'changeListLevelToolStripMenuItem
            '
            Me.changeListLevelToolStripMenuItem.Enabled = False
            Me.changeListLevelToolStripMenuItem.Name = "changeListLevelToolStripMenuItem"
            Me.changeListLevelToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.changeListLevelToolStripMenuItem.Text = "Change List Level"
            '
            'defineNewBulletToolStripMenuItem
            '
            Me.defineNewBulletToolStripMenuItem.Name = "defineNewBulletToolStripMenuItem"
            Me.defineNewBulletToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.defineNewBulletToolStripMenuItem.Text = "Define New Bullet"
            '
            'toolStripSplitButton5
            '
            Me.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem1, Me.defineNewNumberFormatToolStripMenuItem1, Me.setNumberingValueToolStripMenuItem})
            Me.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton5.Name = "toolStripSplitButton5"
            Me.toolStripSplitButton5.Size = New System.Drawing.Size(16, 23)
            Me.toolStripSplitButton5.Text = "toolStripSplitButton5"
            ToolTipInfo6.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Body.Text = "Numeric Bullets"
            ToolTipInfo6.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripSplitButton5, ToolTipInfo6)
            '
            'changeListLevelToolStripMenuItem1
            '
            Me.changeListLevelToolStripMenuItem1.Enabled = False
            Me.changeListLevelToolStripMenuItem1.Name = "changeListLevelToolStripMenuItem1"
            Me.changeListLevelToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
            Me.changeListLevelToolStripMenuItem1.Text = "Change List Level"
            '
            'defineNewNumberFormatToolStripMenuItem1
            '
            Me.defineNewNumberFormatToolStripMenuItem1.Name = "defineNewNumberFormatToolStripMenuItem1"
            Me.defineNewNumberFormatToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
            Me.defineNewNumberFormatToolStripMenuItem1.Text = "Define New Number Format"
            '
            'setNumberingValueToolStripMenuItem
            '
            Me.setNumberingValueToolStripMenuItem.Name = "setNumberingValueToolStripMenuItem"
            Me.setNumberingValueToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
            Me.setNumberingValueToolStripMenuItem.Text = "Set Numbering Value"
            '
            'toolStripPanelItem6
            '
            Me.toolStripPanelItem6.CausesValidation = False
            Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem6.GroupedButtons = True
            Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton17})
            Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
            Me.toolStripPanelItem6.Size = New System.Drawing.Size(27, 11)
            Me.toolStripPanelItem6.Text = "toolStripPanelItem6"
            Me.toolStripPanelItem6.Transparent = True
            '
            'toolStripButton17
            '
            Me.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton17.Name = "toolStripButton17"
            Me.toolStripButton17.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton17.Text = "toolStripButton17"
            '
            'toolStripPanelItem7
            '
            Me.toolStripPanelItem7.AutoSize = False
            Me.toolStripPanelItem7.CausesValidation = False
            Me.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem7.GroupedButtons = True
            Me.toolStripPanelItem7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messageBoldToolStripButton, Me.messageItalicToolStripButton, Me.messageUnderlineToolStripButton})
            Me.toolStripPanelItem7.Name = "toolStripPanelItem7"
            Me.toolStripPanelItem7.Size = New System.Drawing.Size(75, 30)
            Me.toolStripPanelItem7.Text = "toolStripPanelItem7"
            Me.toolStripPanelItem7.Transparent = True
            Me.toolStripPanelItem7.UseStandardLayout = True
            '
            'messageBoldToolStripButton
            '
            Me.messageBoldToolStripButton.CheckOnClick = True
            Me.messageBoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageBoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageBoldToolStripButton.Name = "messageBoldToolStripButton"
            Me.messageBoldToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageBoldToolStripButton.Text = "toolStripButton18"
            ToolTipInfo7.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Body.Text = "      Bold"
            ToolTipInfo7.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messageBoldToolStripButton, ToolTipInfo7)
            '
            'messageItalicToolStripButton
            '
            Me.messageItalicToolStripButton.CheckOnClick = True
            Me.messageItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageItalicToolStripButton.Name = "messageItalicToolStripButton"
            Me.messageItalicToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageItalicToolStripButton.Text = "toolStripButton19"
            ToolTipInfo8.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Body.Text = "Italic"
            ToolTipInfo8.Body.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo8.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messageItalicToolStripButton, ToolTipInfo8)
            '
            'messageUnderlineToolStripButton
            '
            Me.messageUnderlineToolStripButton.CheckOnClick = True
            Me.messageUnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageUnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageUnderlineToolStripButton.Name = "messageUnderlineToolStripButton"
            Me.messageUnderlineToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageUnderlineToolStripButton.Text = "toolStripButton20"
            ToolTipInfo9.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Body.Text = "Underline"
            ToolTipInfo9.Body.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo9.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.messageUnderlineToolStripButton, ToolTipInfo9)
            '
            'toolStripPanelItem8
            '
            Me.toolStripPanelItem8.AutoSize = False
            Me.toolStripPanelItem8.CausesValidation = False
            Me.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem8.GroupedButtons = True
            Me.toolStripPanelItem8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton6, Me.toolStripSplitButton7})
            Me.toolStripPanelItem8.Name = "toolStripPanelItem8"
            Me.toolStripPanelItem8.Size = New System.Drawing.Size(70, 30)
            Me.toolStripPanelItem8.Text = "toolStripPanelItem8"
            Me.toolStripPanelItem8.Transparent = True
            Me.toolStripPanelItem8.UseStandardLayout = True
            '
            'toolStripSplitButton6
            '
            Me.toolStripSplitButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem1, Me.moreColorsToolStripMenuItem1})
            Me.toolStripSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton6.Name = "toolStripSplitButton6"
            Me.toolStripSplitButton6.Size = New System.Drawing.Size(16, 23)
            Me.toolStripSplitButton6.Text = "toolStripSplitButton6"
            '
            'noColorToolStripMenuItem1
            '
            Me.noColorToolStripMenuItem1.Name = "noColorToolStripMenuItem1"
            Me.noColorToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
            Me.noColorToolStripMenuItem1.Text = "No Color"
            '
            'moreColorsToolStripMenuItem1
            '
            Me.moreColorsToolStripMenuItem1.Name = "moreColorsToolStripMenuItem1"
            Me.moreColorsToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
            Me.moreColorsToolStripMenuItem1.Text = "More Colors"
            '
            'toolStripSplitButton7
            '
            Me.toolStripSplitButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moreColorsToolStripMenuItem2})
            Me.toolStripSplitButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton7.Name = "toolStripSplitButton7"
            Me.toolStripSplitButton7.Size = New System.Drawing.Size(16, 23)
            Me.toolStripSplitButton7.Text = "toolStripSplitButton7"
            '
            'moreColorsToolStripMenuItem2
            '
            Me.moreColorsToolStripMenuItem2.Name = "moreColorsToolStripMenuItem2"
            Me.moreColorsToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
            Me.moreColorsToolStripMenuItem2.Text = "More Colors"
            '
            'toolStripPanelItem21
            '
            Me.toolStripPanelItem21.AutoSize = False
            Me.toolStripPanelItem21.CausesValidation = False
            Me.toolStripPanelItem21.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem21.GroupedButtons = True
            Me.toolStripPanelItem21.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messageLeftAlignToolStripButton, Me.messageCenterAlignToolStripButton, Me.messageRightToolStripButton})
            Me.toolStripPanelItem21.Name = "toolStripPanelItem21"
            Me.toolStripPanelItem21.Size = New System.Drawing.Size(75, 30)
            Me.toolStripPanelItem21.Text = "toolStripPanelItem21"
            Me.toolStripPanelItem21.Transparent = True
            Me.toolStripPanelItem21.UseStandardLayout = True
            '
            'messageLeftAlignToolStripButton
            '
            Me.messageLeftAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageLeftAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageLeftAlignToolStripButton.Name = "messageLeftAlignToolStripButton"
            Me.messageLeftAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageLeftAlignToolStripButton.Text = "left"
            '
            'messageCenterAlignToolStripButton
            '
            Me.messageCenterAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageCenterAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageCenterAlignToolStripButton.Name = "messageCenterAlignToolStripButton"
            Me.messageCenterAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageCenterAlignToolStripButton.Text = "center"
            '
            'messageRightToolStripButton
            '
            Me.messageRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageRightToolStripButton.Name = "messageRightToolStripButton"
            Me.messageRightToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageRightToolStripButton.Text = "right"
            '
            'toolStripPanelItem22
            '
            Me.toolStripPanelItem22.AutoSize = False
            Me.toolStripPanelItem22.CausesValidation = False
            Me.toolStripPanelItem22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem22.GroupedButtons = True
            Me.toolStripPanelItem22.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.messageIndentToolStripButton, Me.messageOutdentToolStripButton})
            Me.toolStripPanelItem22.Name = "toolStripPanelItem22"
            Me.toolStripPanelItem22.Size = New System.Drawing.Size(52, 30)
            Me.toolStripPanelItem22.Text = "toolStripPanelItem22"
            Me.toolStripPanelItem22.Transparent = True
            Me.toolStripPanelItem22.UseStandardLayout = True
            '
            'messageIndentToolStripButton
            '
            Me.messageIndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageIndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageIndentToolStripButton.Name = "messageIndentToolStripButton"
            Me.messageIndentToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageIndentToolStripButton.Text = "indent"
            '
            'messageOutdentToolStripButton
            '
            Me.messageOutdentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.messageOutdentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.messageOutdentToolStripButton.Name = "messageOutdentToolStripButton"
            Me.messageOutdentToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.messageOutdentToolStripButton.Text = "outdent"
            '
            'toolStripEx10
            '
            Me.toolStripEx10.AutoSize = False
            Me.toolStripEx10.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx10.Image = Nothing
            Me.toolStripEx10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton35, Me.toolStripButton36})
            Me.toolStripEx10.Location = New System.Drawing.Point(445, 1)
            Me.toolStripEx10.Name = "toolStripEx10"
            Me.toolStripEx10.Size = New System.Drawing.Size(119, 92)
            Me.toolStripEx10.TabIndex = 3
            Me.toolStripEx10.Text = "Names"
            '
            'toolStripButton35
            '
            Me.toolStripButton35.AutoToolTip = False
            Me.toolStripButton35.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton35.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton35.Name = "toolStripButton35"
            Me.toolStripButton35.Size = New System.Drawing.Size(56, 71)
            Me.toolStripButton35.Text = "Address " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book"
            Me.toolStripButton35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo10.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Body.Text = "Address Book"
            ToolTipInfo10.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripButton35, ToolTipInfo10)
            '
            'toolStripButton36
            '
            Me.toolStripButton36.AutoToolTip = False
            Me.toolStripButton36.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton36.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton36.Name = "toolStripButton36"
            Me.toolStripButton36.Size = New System.Drawing.Size(48, 71)
            Me.toolStripButton36.Text = "Names"
            Me.toolStripButton36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo11.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Body.Text = "Names List"
            ToolTipInfo11.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripButton36, ToolTipInfo11)
            '
            'toolStripEx11
            '
            Me.toolStripEx11.AutoSize = False
            Me.toolStripEx11.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx11.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx11.Image = Nothing
            Me.toolStripEx11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton37, Me.toolStripButton38, Me.toolStripDropDownButton8, Me.toolStripButton39, Me.toolStripDropDownButton9})
            Me.toolStripEx11.Location = New System.Drawing.Point(566, 1)
            Me.toolStripEx11.Name = "toolStripEx11"
            Me.toolStripEx11.Size = New System.Drawing.Size(292, 92)
            Me.toolStripEx11.TabIndex = 4
            Me.toolStripEx11.Text = "Include"
            '
            'toolStripButton37
            '
            Me.toolStripButton37.AutoToolTip = False
            Me.toolStripButton37.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton37.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton37.Name = "toolStripButton37"
            Me.toolStripButton37.Size = New System.Drawing.Size(46, 71)
            Me.toolStripButton37.Text = "Attach" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
            Me.toolStripButton37.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo12.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Body.Text = "Attach File"
            ToolTipInfo12.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripButton37, ToolTipInfo12)
            Me.toolStripButton37.ToolTipText = "Attach" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
            '
            'toolStripButton38
            '
            Me.toolStripButton38.AutoToolTip = False
            Me.toolStripButton38.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton38.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton38.Name = "toolStripButton38"
            Me.toolStripButton38.Size = New System.Drawing.Size(46, 71)
            Me.toolStripButton38.Text = "Attach" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
            Me.toolStripButton38.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo13.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Body.Text = "Attach Item"
            ToolTipInfo13.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripButton38, ToolTipInfo13)
            '
            'toolStripDropDownButton8
            '
            Me.toolStripDropDownButton8.AutoToolTip = False
            Me.toolStripDropDownButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.otherBusinessCardsToolStripMenuItem})
            Me.toolStripDropDownButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton8.Name = "toolStripDropDownButton8"
            Me.toolStripDropDownButton8.Size = New System.Drawing.Size(68, 71)
            Me.toolStripDropDownButton8.Text = "Business " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Card"
            Me.toolStripDropDownButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo14.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Body.Text = "Show Business Card"
            ToolTipInfo14.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton8, ToolTipInfo14)
            '
            'otherBusinessCardsToolStripMenuItem
            '
            Me.otherBusinessCardsToolStripMenuItem.Name = "otherBusinessCardsToolStripMenuItem"
            Me.otherBusinessCardsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.otherBusinessCardsToolStripMenuItem.Text = "Other Business Cards"
            '
            'toolStripButton39
            '
            Me.toolStripButton39.AutoToolTip = False
            Me.toolStripButton39.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton39.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton39.Name = "toolStripButton39"
            Me.toolStripButton39.Size = New System.Drawing.Size(58, 71)
            Me.toolStripButton39.Text = "Calendar"
            Me.toolStripButton39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo15.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo15.Body.Text = "Show Calendar"
            ToolTipInfo15.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo15.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripButton39, ToolTipInfo15)
            '
            'toolStripDropDownButton9
            '
            Me.toolStripDropDownButton9.AutoToolTip = False
            Me.toolStripDropDownButton9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.signToolStripMenuItem, Me.signaturesToolStripMenuItem})
            Me.toolStripDropDownButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton9.Name = "toolStripDropDownButton9"
            Me.toolStripDropDownButton9.Size = New System.Drawing.Size(70, 89)
            Me.toolStripDropDownButton9.Text = "Signature"
            Me.toolStripDropDownButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo16.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo16.Body.Text = "Add Signature"
            ToolTipInfo16.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo16.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripDropDownButton9, ToolTipInfo16)
            '
            'signToolStripMenuItem
            '
            Me.signToolStripMenuItem.Name = "signToolStripMenuItem"
            Me.signToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.signToolStripMenuItem.Text = "Sign"
            '
            'signaturesToolStripMenuItem
            '
            Me.signaturesToolStripMenuItem.Name = "signaturesToolStripMenuItem"
            Me.signaturesToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.signaturesToolStripMenuItem.Text = "Signatures"
            '
            'toolStripEx12
            '
            Me.toolStripEx12.AutoSize = False
            Me.toolStripEx12.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.toolStripEx12.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx12.Image = Nothing
            Me.toolStripEx12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton25, Me.toolStripSplitButton12})
            Me.toolStripEx12.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.toolStripEx12.Location = New System.Drawing.Point(860, 1)
            Me.toolStripEx12.Name = "toolStripEx12"
            Me.toolStripEx12.Size = New System.Drawing.Size(147, 92)
            Me.toolStripEx12.TabIndex = 5
            Me.toolStripEx12.Text = "Spelling"
            '
            'toolStripDropDownButton25
            '
            Me.toolStripDropDownButton25.AutoSize = False
            Me.toolStripDropDownButton25.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem21, Me.toolStripMenuItem22, Me.toolStripMenuItem23, Me.toolStripMenuItem24, Me.toolStripMenuItem25, Me.toolStripMenuItem26, Me.toolStripMenuItem27})
            Me.toolStripDropDownButton25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton25.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton25.Name = "toolStripDropDownButton25"
            Me.toolStripDropDownButton25.Size = New System.Drawing.Size(141, 35)
            Me.toolStripDropDownButton25.Text = "Spelling"
            '
            'toolStripMenuItem21
            '
            Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
            Me.toolStripMenuItem21.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem21.Text = "Spelling & Grammar"
            '
            'toolStripMenuItem22
            '
            Me.toolStripMenuItem22.Name = "toolStripMenuItem22"
            Me.toolStripMenuItem22.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem22.Text = "Research"
            '
            'toolStripMenuItem23
            '
            Me.toolStripMenuItem23.Name = "toolStripMenuItem23"
            Me.toolStripMenuItem23.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem23.Text = "Thesaurus"
            '
            'toolStripMenuItem24
            '
            Me.toolStripMenuItem24.Name = "toolStripMenuItem24"
            Me.toolStripMenuItem24.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem24.Text = "Translate"
            '
            'toolStripMenuItem25
            '
            Me.toolStripMenuItem25.Name = "toolStripMenuItem25"
            Me.toolStripMenuItem25.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem25.Text = "Translation ScreenTip"
            '
            'toolStripMenuItem26
            '
            Me.toolStripMenuItem26.Name = "toolStripMenuItem26"
            Me.toolStripMenuItem26.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem26.Text = "Set Language"
            '
            'toolStripMenuItem27
            '
            Me.toolStripMenuItem27.Name = "toolStripMenuItem27"
            Me.toolStripMenuItem27.Size = New System.Drawing.Size(188, 22)
            Me.toolStripMenuItem27.Text = "Word Count"
            '
            'toolStripSplitButton12
            '
            Me.toolStripSplitButton12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.blueToolStripMenuItem, Me.blackToolStripMenuItem, Me.silverToolStripMenuItem})
            Me.toolStripSplitButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton12.Name = "toolStripSplitButton12"
            Me.toolStripSplitButton12.Size = New System.Drawing.Size(141, 19)
            Me.toolStripSplitButton12.Text = "Styles"
            ToolTipInfo17.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo17.Body.Text = "Office2007 Styles"
            ToolTipInfo17.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo17.Header.Size = New System.Drawing.Size(20, 20)
            Me.superToolTip1.SetToolTip(Me.toolStripSplitButton12, ToolTipInfo17)
            '
            'blueToolStripMenuItem
            '
            Me.blueToolStripMenuItem.Checked = True
            Me.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.blueToolStripMenuItem.Name = "blueToolStripMenuItem"
            Me.blueToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
            Me.blueToolStripMenuItem.Text = "Blue"
            '
            'blackToolStripMenuItem
            '
            Me.blackToolStripMenuItem.Name = "blackToolStripMenuItem"
            Me.blackToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
            Me.blackToolStripMenuItem.Text = "Black"
            '
            'silverToolStripMenuItem
            '
            Me.silverToolStripMenuItem.Name = "silverToolStripMenuItem"
            Me.silverToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
            Me.silverToolStripMenuItem.Text = "Silver"
            '
            'toolStripTabItem1
            '
            Me.toolStripTabItem1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripTabItem1.Name = "toolStripTabItem1"
            '
            'ribbonControlAdv1.RibbonPanel2
            '
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx13)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx14)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx15)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx16)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx17)
            Me.toolStripTabItem1.Panel.Name = "RibbonPanel2"
            Me.toolStripTabItem1.Panel.ScrollPosition = 0
            Me.toolStripTabItem1.Panel.TabIndex = 6
            Me.toolStripTabItem1.Panel.Text = "Insert"
            Me.toolStripTabItem1.Position = 1
            Me.toolStripTabItem1.Size = New System.Drawing.Size(45, 20)
            Me.toolStripTabItem1.Text = "Insert"
            '
            'toolStripEx13
            '
            Me.toolStripEx13.AutoSize = False
            Me.toolStripEx13.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx13.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx13.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx13.Image = Nothing
            Me.toolStripEx13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton43, Me.toolStripButton44, Me.toolStripDropDownButton12, Me.toolStripButton45, Me.toolStripDropDownButton13})
            Me.toolStripEx13.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx13.Name = "toolStripEx13"
            Me.toolStripEx13.Size = New System.Drawing.Size(324, 0)
            Me.toolStripEx13.TabIndex = 0
            Me.toolStripEx13.Text = "Include"
            '
            'toolStripButton43
            '
            Me.toolStripButton43.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton43.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton43.Name = "toolStripButton43"
            Me.toolStripButton43.Size = New System.Drawing.Size(49, 0)
            Me.toolStripButton43.Text = "Attach " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
            Me.toolStripButton43.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton44
            '
            Me.toolStripButton44.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton44.Name = "toolStripButton44"
            Me.toolStripButton44.Size = New System.Drawing.Size(49, 0)
            Me.toolStripButton44.Text = "Attach " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
            Me.toolStripButton44.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripDropDownButton12
            '
            Me.toolStripDropDownButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton12.Name = "toolStripDropDownButton12"
            Me.toolStripDropDownButton12.Size = New System.Drawing.Size(93, 0)
            Me.toolStripDropDownButton12.Text = "Business Card"
            Me.toolStripDropDownButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton45
            '
            Me.toolStripButton45.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton45.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton45.Name = "toolStripButton45"
            Me.toolStripButton45.Size = New System.Drawing.Size(58, 0)
            Me.toolStripButton45.Text = "Calendar"
            Me.toolStripButton45.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripDropDownButton13
            '
            Me.toolStripDropDownButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton13.Name = "toolStripDropDownButton13"
            Me.toolStripDropDownButton13.Size = New System.Drawing.Size(70, 0)
            Me.toolStripDropDownButton13.Text = "Signature"
            Me.toolStripDropDownButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx14
            '
            Me.toolStripEx14.AutoSize = False
            Me.toolStripEx14.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx14.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx14.Enabled = False
            Me.toolStripEx14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx14.Image = Nothing
            Me.toolStripEx14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton46})
            Me.toolStripEx14.Location = New System.Drawing.Point(326, 1)
            Me.toolStripEx14.Name = "toolStripEx14"
            Me.toolStripEx14.Size = New System.Drawing.Size(66, 0)
            Me.toolStripEx14.TabIndex = 1
            Me.toolStripEx14.Text = "Table"
            '
            'toolStripButton46
            '
            Me.toolStripButton46.Enabled = False
            Me.toolStripButton46.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton46.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton46.Name = "toolStripButton46"
            Me.toolStripButton46.Size = New System.Drawing.Size(45, 0)
            Me.toolStripButton46.Text = "Tables"
            Me.toolStripButton46.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx15
            '
            Me.toolStripEx15.AutoSize = False
            Me.toolStripEx15.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx15.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx15.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx15.Image = Nothing
            Me.toolStripEx15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton47, Me.toolStripButton48, Me.toolStripDropDownButton14, Me.toolStripButton49, Me.toolStripButton50})
            Me.toolStripEx15.Location = New System.Drawing.Point(394, 1)
            Me.toolStripEx15.Name = "toolStripEx15"
            Me.toolStripEx15.Size = New System.Drawing.Size(259, 0)
            Me.toolStripEx15.TabIndex = 2
            Me.toolStripEx15.Text = "Illustrations"
            '
            'toolStripButton47
            '
            Me.toolStripButton47.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton47.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton47.Name = "toolStripButton47"
            Me.toolStripButton47.Size = New System.Drawing.Size(48, 0)
            Me.toolStripButton47.Text = "Picture"
            Me.toolStripButton47.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton48
            '
            Me.toolStripButton48.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton48.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton48.Name = "toolStripButton48"
            Me.toolStripButton48.Size = New System.Drawing.Size(46, 0)
            Me.toolStripButton48.Text = "Clipart"
            Me.toolStripButton48.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripDropDownButton14
            '
            Me.toolStripDropDownButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton14.Name = "toolStripDropDownButton14"
            Me.toolStripDropDownButton14.Size = New System.Drawing.Size(57, 0)
            Me.toolStripDropDownButton14.Text = "Smart " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shapes"
            Me.toolStripDropDownButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton49
            '
            Me.toolStripButton49.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton49.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton49.Name = "toolStripButton49"
            Me.toolStripButton49.Size = New System.Drawing.Size(58, 0)
            Me.toolStripButton49.Text = "SmartArt"
            Me.toolStripButton49.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton50
            '
            Me.toolStripButton50.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton50.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton50.Name = "toolStripButton50"
            Me.toolStripButton50.Size = New System.Drawing.Size(40, 0)
            Me.toolStripButton50.Text = "Chart"
            Me.toolStripButton50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx16
            '
            Me.toolStripEx16.AutoSize = False
            Me.toolStripEx16.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.toolStripEx16.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx16.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx16.Image = Nothing
            Me.toolStripEx16.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton51, Me.toolStripButton52})
            Me.toolStripEx16.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.toolStripEx16.Location = New System.Drawing.Point(655, 1)
            Me.toolStripEx16.Name = "toolStripEx16"
            Me.toolStripEx16.Size = New System.Drawing.Size(100, 0)
            Me.toolStripEx16.TabIndex = 3
            Me.toolStripEx16.Text = "Links"
            '
            'toolStripButton51
            '
            Me.toolStripButton51.AutoSize = False
            Me.toolStripButton51.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton51.Name = "toolStripButton51"
            Me.toolStripButton51.Size = New System.Drawing.Size(94, 25)
            Me.toolStripButton51.Text = "Hyperlink"
            '
            'toolStripButton52
            '
            Me.toolStripButton52.AutoSize = False
            Me.toolStripButton52.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton52.Name = "toolStripButton52"
            Me.toolStripButton52.Size = New System.Drawing.Size(94, 25)
            Me.toolStripButton52.Text = "Bookmark"
            '
            'toolStripEx17
            '
            Me.toolStripEx17.AutoSize = False
            Me.toolStripEx17.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx17.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx17.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx17.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx17.Image = Nothing
            Me.toolStripEx17.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem32, Me.toolStripPanelItem33})
            Me.toolStripEx17.Location = New System.Drawing.Point(757, 1)
            Me.toolStripEx17.Name = "toolStripEx17"
            Me.toolStripEx17.Size = New System.Drawing.Size(206, 0)
            Me.toolStripEx17.TabIndex = 4
            Me.toolStripEx17.Text = "Texts"
            '
            'toolStripPanelItem32
            '
            Me.toolStripPanelItem32.CausesValidation = False
            Me.toolStripPanelItem32.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem32.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton26, Me.toolStripDropDownButton27, Me.toolStripDropDownButton28})
            Me.toolStripPanelItem32.Name = "toolStripPanelItem32"
            Me.toolStripPanelItem32.Size = New System.Drawing.Size(84, 0)
            Me.toolStripPanelItem32.Text = "toolStripPanelItem32"
            Me.toolStripPanelItem32.Transparent = True
            '
            'toolStripDropDownButton26
            '
            Me.toolStripDropDownButton26.Enabled = False
            Me.toolStripDropDownButton26.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton26.Name = "toolStripDropDownButton26"
            Me.toolStripDropDownButton26.Size = New System.Drawing.Size(64, 19)
            Me.toolStripDropDownButton26.Text = "Text Box"
            '
            'toolStripDropDownButton27
            '
            Me.toolStripDropDownButton27.Enabled = False
            Me.toolStripDropDownButton27.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton27.Name = "toolStripDropDownButton27"
            Me.toolStripDropDownButton27.Size = New System.Drawing.Size(80, 19)
            Me.toolStripDropDownButton27.Text = "Quick Parts"
            '
            'toolStripDropDownButton28
            '
            Me.toolStripDropDownButton28.Enabled = False
            Me.toolStripDropDownButton28.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton28.Name = "toolStripDropDownButton28"
            Me.toolStripDropDownButton28.Size = New System.Drawing.Size(68, 19)
            Me.toolStripDropDownButton28.Text = "Word Art"
            '
            'toolStripPanelItem33
            '
            Me.toolStripPanelItem33.CausesValidation = False
            Me.toolStripPanelItem33.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem33.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton29, Me.toolStripButton58, Me.toolStripButton59})
            Me.toolStripPanelItem33.Name = "toolStripPanelItem33"
            Me.toolStripPanelItem33.Size = New System.Drawing.Size(90, 0)
            Me.toolStripPanelItem33.Text = "toolStripPanelItem33"
            Me.toolStripPanelItem33.Transparent = True
            '
            'toolStripDropDownButton29
            '
            Me.toolStripDropDownButton29.Enabled = False
            Me.toolStripDropDownButton29.Image = CType(resources.GetObject("toolStripDropDownButton29.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton29.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton29.Name = "toolStripDropDownButton29"
            Me.toolStripDropDownButton29.Size = New System.Drawing.Size(86, 20)
            Me.toolStripDropDownButton29.Text = "Drop Cap"
            '
            'toolStripButton58
            '
            Me.toolStripButton58.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton58.Name = "toolStripButton58"
            Me.toolStripButton58.Size = New System.Drawing.Size(62, 19)
            Me.toolStripButton58.Text = "DateTime"
            '
            'toolStripButton59
            '
            Me.toolStripButton59.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton59.Name = "toolStripButton59"
            Me.toolStripButton59.Size = New System.Drawing.Size(46, 19)
            Me.toolStripButton59.Text = "Object"
            '
            'toolStripTabItem2
            '
            Me.toolStripTabItem2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripTabItem2.Name = "toolStripTabItem2"
            '
            'ribbonControlAdv1.RibbonPanel3
            '
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx5)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx6)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx7)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx8)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx9)
            Me.toolStripTabItem2.Panel.Name = "RibbonPanel3"
            Me.toolStripTabItem2.Panel.ScrollPosition = 0
            Me.toolStripTabItem2.Panel.TabIndex = 5
            Me.toolStripTabItem2.Panel.Text = "Options"
            Me.toolStripTabItem2.Position = 2
            Me.toolStripTabItem2.Size = New System.Drawing.Size(55, 20)
            Me.toolStripTabItem2.Text = "Options"
            '
            'toolStripEx5
            '
            Me.toolStripEx5.AutoSize = False
            Me.toolStripEx5.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx5.Image = Nothing
            Me.toolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.themesToolStripDropDownButton, Me.toolStripPanelItem23, Me.toolStripSeparator4, Me.toolStripDropDownButton6})
            Me.toolStripEx5.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx5.Name = "toolStripEx5"
            Me.toolStripEx5.Size = New System.Drawing.Size(240, 0)
            Me.toolStripEx5.TabIndex = 0
            Me.toolStripEx5.Text = "Themes"
            '
            'themesToolStripDropDownButton
            '
            Me.themesToolStripDropDownButton.Enabled = False
            Me.themesToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.themesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.themesToolStripDropDownButton.Name = "themesToolStripDropDownButton"
            Me.themesToolStripDropDownButton.Size = New System.Drawing.Size(62, 0)
            Me.themesToolStripDropDownButton.Text = "Themes"
            Me.themesToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripPanelItem23
            '
            Me.toolStripPanelItem23.CausesValidation = False
            Me.toolStripPanelItem23.Enabled = False
            Me.toolStripPanelItem23.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem23.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton8, Me.toolStripSplitButton9, Me.toolStripSplitButton10})
            Me.toolStripPanelItem23.Name = "toolStripPanelItem23"
            Me.toolStripPanelItem23.Size = New System.Drawing.Size(79, 0)
            Me.toolStripPanelItem23.Text = "toolStripPanelItem23"
            Me.toolStripPanelItem23.Transparent = True
            '
            'toolStripSplitButton8
            '
            Me.toolStripSplitButton8.AutoSize = False
            Me.toolStripSplitButton8.Enabled = False
            Me.toolStripSplitButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton8.Name = "toolStripSplitButton8"
            Me.toolStripSplitButton8.Size = New System.Drawing.Size(75, 20)
            Me.toolStripSplitButton8.Text = "Colors"
            '
            'toolStripSplitButton9
            '
            Me.toolStripSplitButton9.AutoSize = False
            Me.toolStripSplitButton9.Enabled = False
            Me.toolStripSplitButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton9.Name = "toolStripSplitButton9"
            Me.toolStripSplitButton9.Size = New System.Drawing.Size(75, 20)
            Me.toolStripSplitButton9.Text = "Fonts"
            '
            'toolStripSplitButton10
            '
            Me.toolStripSplitButton10.AutoSize = False
            Me.toolStripSplitButton10.Enabled = False
            Me.toolStripSplitButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton10.Name = "toolStripSplitButton10"
            Me.toolStripSplitButton10.Size = New System.Drawing.Size(75, 20)
            Me.toolStripSplitButton10.Text = "Effects"
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 0)
            '
            'toolStripDropDownButton6
            '
            Me.toolStripDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem2, Me.moreColorsToolStripMenuItem3, Me.fillEffectsToolStripMenuItem})
            Me.toolStripDropDownButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.LightCyan
            Me.toolStripDropDownButton6.Name = "toolStripDropDownButton6"
            Me.toolStripDropDownButton6.Size = New System.Drawing.Size(78, 0)
            Me.toolStripDropDownButton6.Text = "Page Color"
            Me.toolStripDropDownButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'noColorToolStripMenuItem2
            '
            Me.noColorToolStripMenuItem2.Name = "noColorToolStripMenuItem2"
            Me.noColorToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
            Me.noColorToolStripMenuItem2.Text = "No Color"
            '
            'moreColorsToolStripMenuItem3
            '
            Me.moreColorsToolStripMenuItem3.Name = "moreColorsToolStripMenuItem3"
            Me.moreColorsToolStripMenuItem3.Size = New System.Drawing.Size(139, 22)
            Me.moreColorsToolStripMenuItem3.Text = "More Colors"
            '
            'fillEffectsToolStripMenuItem
            '
            Me.fillEffectsToolStripMenuItem.Name = "fillEffectsToolStripMenuItem"
            Me.fillEffectsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
            Me.fillEffectsToolStripMenuItem.Text = "Fill Effects"
            '
            'toolStripEx6
            '
            Me.toolStripEx6.AutoSize = False
            Me.toolStripEx6.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx6.Image = Nothing
            Me.toolStripEx6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton26, Me.toolStripButton27})
            Me.toolStripEx6.Location = New System.Drawing.Point(242, 1)
            Me.toolStripEx6.Name = "toolStripEx6"
            Me.toolStripEx6.Size = New System.Drawing.Size(103, 0)
            Me.toolStripEx6.TabIndex = 1
            Me.toolStripEx6.Text = "Fields"
            '
            'toolStripButton26
            '
            Me.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton26.Name = "toolStripButton26"
            Me.toolStripButton26.Size = New System.Drawing.Size(43, 0)
            Me.toolStripButton26.Text = "Show " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bcc"
            Me.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton27
            '
            Me.toolStripButton27.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton27.Name = "toolStripButton27"
            Me.toolStripButton27.Size = New System.Drawing.Size(43, 0)
            Me.toolStripButton27.Text = "Show " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form"
            Me.toolStripButton27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx7
            '
            Me.toolStripEx7.AutoSize = False
            Me.toolStripEx7.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx7.Image = Nothing
            Me.toolStripEx7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton28, Me.toolStripButton29, Me.toolStripButton30})
            Me.toolStripEx7.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.toolStripEx7.Location = New System.Drawing.Point(347, 1)
            Me.toolStripEx7.Name = "toolStripEx7"
            Me.toolStripEx7.Size = New System.Drawing.Size(128, 0)
            Me.toolStripEx7.TabIndex = 2
            Me.toolStripEx7.Text = "Format"
            '
            'toolStripButton28
            '
            Me.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton28.Image = CType(resources.GetObject("toolStripButton28.Image"), System.Drawing.Image)
            Me.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton28.Name = "toolStripButton28"
            Me.toolStripButton28.Size = New System.Drawing.Size(62, 19)
            Me.toolStripButton28.Text = "Plain Text"
            '
            'toolStripButton29
            '
            Me.toolStripButton29.Checked = True
            Me.toolStripButton29.CheckState = System.Windows.Forms.CheckState.Checked
            Me.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton29.Image = CType(resources.GetObject("toolStripButton29.Image"), System.Drawing.Image)
            Me.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton29.Name = "toolStripButton29"
            Me.toolStripButton29.Size = New System.Drawing.Size(44, 19)
            Me.toolStripButton29.Text = "HTML"
            '
            'toolStripButton30
            '
            Me.toolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton30.Image = CType(resources.GetObject("toolStripButton30.Image"), System.Drawing.Image)
            Me.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton30.Name = "toolStripButton30"
            Me.toolStripButton30.Size = New System.Drawing.Size(59, 19)
            Me.toolStripButton30.Text = "Rich Text"
            '
            'toolStripEx8
            '
            Me.toolStripEx8.AutoSize = False
            Me.toolStripEx8.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx8.Image = Nothing
            Me.toolStripEx8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton7, Me.toolStripPanelItem24})
            Me.toolStripEx8.Location = New System.Drawing.Point(477, 1)
            Me.toolStripEx8.Name = "toolStripEx8"
            Me.toolStripEx8.Size = New System.Drawing.Size(246, 0)
            Me.toolStripEx8.TabIndex = 3
            Me.toolStripEx8.Text = "Tracking"
            '
            'toolStripDropDownButton7
            '
            Me.toolStripDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton7.Name = "toolStripDropDownButton7"
            Me.toolStripDropDownButton7.Size = New System.Drawing.Size(80, 0)
            Me.toolStripDropDownButton7.Text = "Use Voting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buttons"
            Me.toolStripDropDownButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripPanelItem24
            '
            Me.toolStripPanelItem24.CausesValidation = False
            Me.toolStripPanelItem24.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem24.GroupedButtons = True
            Me.toolStripPanelItem24.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton31, Me.toolStripButton32})
            Me.toolStripPanelItem24.Name = "toolStripPanelItem24"
            Me.toolStripPanelItem24.Size = New System.Drawing.Size(145, 0)
            Me.toolStripPanelItem24.Text = "toolStripPanelItem24"
            Me.toolStripPanelItem24.Transparent = True
            '
            'toolStripButton31
            '
            Me.toolStripButton31.AutoSize = False
            Me.toolStripButton31.CheckOnClick = True
            Me.toolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton31.Image = CType(resources.GetObject("toolStripButton31.Image"), System.Drawing.Image)
            Me.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton31.Name = "toolStripButton31"
            Me.toolStripButton31.Size = New System.Drawing.Size(141, 35)
            Me.toolStripButton31.Text = "Request a Delivery Reciept"
            '
            'toolStripButton32
            '
            Me.toolStripButton32.AutoSize = False
            Me.toolStripButton32.CheckOnClick = True
            Me.toolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton32.Image = CType(resources.GetObject("toolStripButton32.Image"), System.Drawing.Image)
            Me.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton32.Name = "toolStripButton32"
            Me.toolStripButton32.Size = New System.Drawing.Size(141, 35)
            Me.toolStripButton32.Text = "Request a Read Reciept"
            '
            'toolStripEx9
            '
            Me.toolStripEx9.AutoSize = False
            Me.toolStripEx9.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx9.Image = Nothing
            Me.toolStripEx9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton11, Me.toolStripButton33, Me.toolStripButton34})
            Me.toolStripEx9.Location = New System.Drawing.Point(725, 1)
            Me.toolStripEx9.Name = "toolStripEx9"
            Me.toolStripEx9.Size = New System.Drawing.Size(228, 0)
            Me.toolStripEx9.TabIndex = 4
            Me.toolStripEx9.Text = "More Options"
            '
            'toolStripSplitButton11
            '
            Me.toolStripSplitButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.otherFolderToolStripMenuItem, Me.useDefaultFolderToolStripMenuItem, Me.donotSaveToolStripMenuItem})
            Me.toolStripSplitButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripSplitButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton11.Name = "toolStripSplitButton11"
            Me.toolStripSplitButton11.Size = New System.Drawing.Size(73, 0)
            Me.toolStripSplitButton11.Text = "Save " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sent Item"
            Me.toolStripSplitButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'otherFolderToolStripMenuItem
            '
            Me.otherFolderToolStripMenuItem.Name = "otherFolderToolStripMenuItem"
            Me.otherFolderToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
            Me.otherFolderToolStripMenuItem.Text = "Other Folder"
            '
            'useDefaultFolderToolStripMenuItem
            '
            Me.useDefaultFolderToolStripMenuItem.Checked = True
            Me.useDefaultFolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.useDefaultFolderToolStripMenuItem.Name = "useDefaultFolderToolStripMenuItem"
            Me.useDefaultFolderToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
            Me.useDefaultFolderToolStripMenuItem.Text = "&Use Default Folder"
            '
            'donotSaveToolStripMenuItem
            '
            Me.donotSaveToolStripMenuItem.Name = "donotSaveToolStripMenuItem"
            Me.donotSaveToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
            Me.donotSaveToolStripMenuItem.Text = "Donot Save"
            '
            'toolStripButton33
            '
            Me.toolStripButton33.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton33.Name = "toolStripButton33"
            Me.toolStripButton33.Size = New System.Drawing.Size(53, 0)
            Me.toolStripButton33.Text = "Delay " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Delivery"
            Me.toolStripButton33.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton34
            '
            Me.toolStripButton34.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton34.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton34.Name = "toolStripButton34"
            Me.toolStripButton34.Size = New System.Drawing.Size(65, 0)
            Me.toolStripButton34.Text = "Direct " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Replies To"
            Me.toolStripButton34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripTabItem3
            '
            Me.toolStripTabItem3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripTabItem3.Name = "toolStripTabItem3"
            '
            'ribbonControlAdv1.RibbonPanel4
            '
            Me.toolStripTabItem3.Panel.Controls.Add(Me.formatClipboardToolStripEx)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.fontToolStripEx)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.paragraphToolStripEx)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.stylesToolStripEx)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx2)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx1)
            Me.toolStripTabItem3.Panel.Name = "RibbonPanel4"
            Me.toolStripTabItem3.Panel.ScrollPosition = 0
            Me.toolStripTabItem3.Panel.TabIndex = 7
            Me.toolStripTabItem3.Panel.Text = "Fomat Text"
            Me.toolStripTabItem3.Position = 3
            Me.toolStripTabItem3.Size = New System.Drawing.Size(71, 20)
            Me.toolStripTabItem3.Text = "Fomat Text"
            '
            'formatClipboardToolStripEx
            '
            Me.formatClipboardToolStripEx.AutoSize = False
            Me.formatClipboardToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.formatClipboardToolStripEx.Dock = System.Windows.Forms.DockStyle.None
            Me.formatClipboardToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue
            Me.formatClipboardToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.formatClipboardToolStripEx.Image = Nothing
            Me.formatClipboardToolStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem9, Me.toolStripPanelItem10})
            Me.formatClipboardToolStripEx.Location = New System.Drawing.Point(0, 1)
            Me.formatClipboardToolStripEx.Name = "formatClipboardToolStripEx"
            Me.formatClipboardToolStripEx.Size = New System.Drawing.Size(116, 0)
            Me.formatClipboardToolStripEx.TabIndex = 0
            Me.formatClipboardToolStripEx.Text = "Clipboard"
            '
            'toolStripPanelItem9
            '
            Me.toolStripPanelItem9.CausesValidation = False
            Me.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formattextPasteToolStripButton, Me.toolStripDropDownButton5})
            Me.toolStripPanelItem9.Name = "toolStripPanelItem9"
            Me.toolStripPanelItem9.Size = New System.Drawing.Size(54, 0)
            Me.toolStripPanelItem9.Transparent = True
            '
            'formattextPasteToolStripButton
            '
            Me.formattextPasteToolStripButton.AutoSize = False
            Me.formattextPasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextPasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.formattextPasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextPasteToolStripButton.Name = "formattextPasteToolStripButton"
            Me.formattextPasteToolStripButton.Size = New System.Drawing.Size(50, 50)
            Me.formattextPasteToolStripButton.Text = "toolStripButton11"
            '
            'toolStripDropDownButton5
            '
            Me.toolStripDropDownButton5.AutoSize = False
            Me.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem})
            Me.toolStripDropDownButton5.Image = CType(resources.GetObject("toolStripDropDownButton5.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton5.Name = "toolStripDropDownButton5"
            Me.toolStripDropDownButton5.Size = New System.Drawing.Size(50, 20)
            Me.toolStripDropDownButton5.Text = "Paste"
            '
            'pasteToolStripMenuItem
            '
            Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
            Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.pasteToolStripMenuItem.Text = "Paste"
            Me.pasteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            '
            'pasteSpecialToolStripMenuItem
            '
            Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
            Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.pasteSpecialToolStripMenuItem.Text = "Paste Special"
            '
            'toolStripPanelItem10
            '
            Me.toolStripPanelItem10.CausesValidation = False
            Me.toolStripPanelItem10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formattextCutToolStripButton, Me.formattextCopyAlignToolStripButton, Me.toolStripButton14})
            Me.toolStripPanelItem10.Name = "toolStripPanelItem10"
            Me.toolStripPanelItem10.Size = New System.Drawing.Size(27, 0)
            Me.toolStripPanelItem10.Text = "toolStripPanelItem10"
            Me.toolStripPanelItem10.Transparent = True
            '
            'formattextCutToolStripButton
            '
            Me.formattextCutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextCutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextCutToolStripButton.Name = "formattextCutToolStripButton"
            Me.formattextCutToolStripButton.Size = New System.Drawing.Size(23, 4)
            Me.formattextCutToolStripButton.Text = "toolStripButton12"
            '
            'formattextCopyAlignToolStripButton
            '
            Me.formattextCopyAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextCopyAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextCopyAlignToolStripButton.Name = "formattextCopyAlignToolStripButton"
            Me.formattextCopyAlignToolStripButton.Size = New System.Drawing.Size(23, 4)
            Me.formattextCopyAlignToolStripButton.Text = "toolStripButton13"
            '
            'toolStripButton14
            '
            Me.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton14.Name = "toolStripButton14"
            Me.toolStripButton14.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton14.Text = "toolStripButton14"
            '
            'fontToolStripEx
            '
            Me.fontToolStripEx.AutoSize = False
            Me.fontToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.fontToolStripEx.Dock = System.Windows.Forms.DockStyle.None
            Me.fontToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue
            Me.fontToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.fontToolStripEx.Image = Nothing
            Me.fontToolStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem11, Me.toolStripPanelItem12, Me.toolStripButton2, Me.toolStripPanelItem13, Me.toolStripPanelItem14})
            Me.fontToolStripEx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.fontToolStripEx.Location = New System.Drawing.Point(118, 1)
            Me.fontToolStripEx.Name = "fontToolStripEx"
            Me.fontToolStripEx.Size = New System.Drawing.Size(254, 0)
            Me.fontToolStripEx.TabIndex = 1
            Me.fontToolStripEx.Text = "Font"
            '
            'toolStripPanelItem11
            '
            Me.toolStripPanelItem11.AutoSize = False
            Me.toolStripPanelItem11.CausesValidation = False
            Me.toolStripPanelItem11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fontToolStripComboBox, Me.fontSizeComboBox})
            Me.toolStripPanelItem11.Name = "toolStripPanelItem11"
            Me.toolStripPanelItem11.Size = New System.Drawing.Size(168, 35)
            Me.toolStripPanelItem11.Text = "toolStripPanelItem11"
            Me.toolStripPanelItem11.Transparent = True
            Me.toolStripPanelItem11.UseStandardLayout = True
            '
            'fontToolStripComboBox
            '
            Me.fontToolStripComboBox.Name = "fontToolStripComboBox"
            Me.fontToolStripComboBox.Size = New System.Drawing.Size(121, 31)
            '
            'fontSizeComboBox
            '
            Me.fontSizeComboBox.AutoSize = False
            Me.fontSizeComboBox.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
            Me.fontSizeComboBox.Name = "fontSizeComboBox"
            Me.fontSizeComboBox.Size = New System.Drawing.Size(35, 23)
            '
            'toolStripPanelItem12
            '
            Me.toolStripPanelItem12.AutoSize = False
            Me.toolStripPanelItem12.CausesValidation = False
            Me.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem12.GroupedButtons = True
            Me.toolStripPanelItem12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.growtoolStripButton2, Me.shrinktoolStripButton3})
            Me.toolStripPanelItem12.Name = "toolStripPanelItem12"
            Me.toolStripPanelItem12.Size = New System.Drawing.Size(52, 33)
            Me.toolStripPanelItem12.Text = "toolStripPanelItem12"
            Me.toolStripPanelItem12.Transparent = True
            Me.toolStripPanelItem12.UseStandardLayout = True
            '
            'growtoolStripButton2
            '
            Me.growtoolStripButton2.AutoSize = False
            Me.growtoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.growtoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.growtoolStripButton2.Name = "growtoolStripButton2"
            Me.growtoolStripButton2.Size = New System.Drawing.Size(23, 20)
            Me.growtoolStripButton2.Text = "toolStripButton2"
            '
            'shrinktoolStripButton3
            '
            Me.shrinktoolStripButton3.AutoSize = False
            Me.shrinktoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.shrinktoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shrinktoolStripButton3.Name = "shrinktoolStripButton3"
            Me.shrinktoolStripButton3.Size = New System.Drawing.Size(23, 20)
            Me.shrinktoolStripButton3.Text = "toolStripButton3"
            '
            'toolStripButton2
            '
            Me.toolStripButton2.AutoSize = False
            Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(23, 26)
            Me.toolStripButton2.Text = "toolStripButton2"
            '
            'toolStripPanelItem13
            '
            Me.toolStripPanelItem13.AutoSize = False
            Me.toolStripPanelItem13.CausesValidation = False
            Me.toolStripPanelItem13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem13.GroupedButtons = True
            Me.toolStripPanelItem13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boldtoolStripButton3, Me.italictoolStripButton4, Me.underlinetoolStripButton5, Me.strikethroughtoolStripButton6, Me.subscripttoolStripButton7, Me.superscripttoolStripButton8, Me.changecaseToolStripDropDownButton2})
            Me.toolStripPanelItem13.Name = "toolStripPanelItem13"
            Me.toolStripPanelItem13.Size = New System.Drawing.Size(173, 30)
            Me.toolStripPanelItem13.Text = "toolStripPanelItem13"
            Me.toolStripPanelItem13.Transparent = True
            Me.toolStripPanelItem13.UseStandardLayout = True
            '
            'boldtoolStripButton3
            '
            Me.boldtoolStripButton3.CheckOnClick = True
            Me.boldtoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.boldtoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.boldtoolStripButton3.Name = "boldtoolStripButton3"
            Me.boldtoolStripButton3.Size = New System.Drawing.Size(23, 23)
            Me.boldtoolStripButton3.Text = "toolStripButton3"
            '
            'italictoolStripButton4
            '
            Me.italictoolStripButton4.CheckOnClick = True
            Me.italictoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.italictoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.italictoolStripButton4.Name = "italictoolStripButton4"
            Me.italictoolStripButton4.Size = New System.Drawing.Size(23, 23)
            Me.italictoolStripButton4.Text = "toolStripButton4"
            '
            'underlinetoolStripButton5
            '
            Me.underlinetoolStripButton5.CheckOnClick = True
            Me.underlinetoolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.underlinetoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.underlinetoolStripButton5.Name = "underlinetoolStripButton5"
            Me.underlinetoolStripButton5.Size = New System.Drawing.Size(23, 23)
            Me.underlinetoolStripButton5.Text = "toolStripButton5"
            '
            'strikethroughtoolStripButton6
            '
            Me.strikethroughtoolStripButton6.CheckOnClick = True
            Me.strikethroughtoolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.strikethroughtoolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.strikethroughtoolStripButton6.Name = "strikethroughtoolStripButton6"
            Me.strikethroughtoolStripButton6.Size = New System.Drawing.Size(23, 23)
            Me.strikethroughtoolStripButton6.Text = "toolStripButton6"
            '
            'subscripttoolStripButton7
            '
            Me.subscripttoolStripButton7.CheckOnClick = True
            Me.subscripttoolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.subscripttoolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.subscripttoolStripButton7.Name = "subscripttoolStripButton7"
            Me.subscripttoolStripButton7.Size = New System.Drawing.Size(23, 23)
            Me.subscripttoolStripButton7.Text = "toolStripButton7"
            '
            'superscripttoolStripButton8
            '
            Me.superscripttoolStripButton8.CheckOnClick = True
            Me.superscripttoolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.superscripttoolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.superscripttoolStripButton8.Name = "superscripttoolStripButton8"
            Me.superscripttoolStripButton8.Size = New System.Drawing.Size(23, 23)
            Me.superscripttoolStripButton8.Text = "toolStripButton8"
            '
            'changecaseToolStripDropDownButton2
            '
            Me.changecaseToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.changecaseToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sentenceCaseToolStripMenuItem, Me.lowerCaseToolStripMenuItem, Me.upperCaseToolStripMenuItem, Me.capitalizeEachWordToolStripMenuItem, Me.tOGGLECASEToolStripMenuItem})
            Me.changecaseToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.changecaseToolStripDropDownButton2.Name = "changecaseToolStripDropDownButton2"
            Me.changecaseToolStripDropDownButton2.Size = New System.Drawing.Size(13, 23)
            Me.changecaseToolStripDropDownButton2.Text = "toolStripDropDownButton2"
            '
            'sentenceCaseToolStripMenuItem
            '
            Me.sentenceCaseToolStripMenuItem.Name = "sentenceCaseToolStripMenuItem"
            Me.sentenceCaseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.sentenceCaseToolStripMenuItem.Text = "Sentence Case"
            '
            'lowerCaseToolStripMenuItem
            '
            Me.lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem"
            Me.lowerCaseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.lowerCaseToolStripMenuItem.Text = "Lower Case"
            '
            'upperCaseToolStripMenuItem
            '
            Me.upperCaseToolStripMenuItem.Name = "upperCaseToolStripMenuItem"
            Me.upperCaseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.upperCaseToolStripMenuItem.Text = "&UPPER CASE"
            '
            'capitalizeEachWordToolStripMenuItem
            '
            Me.capitalizeEachWordToolStripMenuItem.Name = "capitalizeEachWordToolStripMenuItem"
            Me.capitalizeEachWordToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.capitalizeEachWordToolStripMenuItem.Text = "&Capitalize Each Word"
            '
            'tOGGLECASEToolStripMenuItem
            '
            Me.tOGGLECASEToolStripMenuItem.Name = "tOGGLECASEToolStripMenuItem"
            Me.tOGGLECASEToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
            Me.tOGGLECASEToolStripMenuItem.Text = "&tOGGLE CASE"
            '
            'toolStripPanelItem14
            '
            Me.toolStripPanelItem14.AutoSize = False
            Me.toolStripPanelItem14.CausesValidation = False
            Me.toolStripPanelItem14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem14.GroupedButtons = True
            Me.toolStripPanelItem14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.textHighlightColorToolStripDropDownButton2, Me.formatColorToolStripDropDownButton3})
            Me.toolStripPanelItem14.Name = "toolStripPanelItem14"
            Me.toolStripPanelItem14.Size = New System.Drawing.Size(64, 30)
            Me.toolStripPanelItem14.Text = "toolStripPanelItem14"
            Me.toolStripPanelItem14.Transparent = True
            Me.toolStripPanelItem14.UseStandardLayout = True
            '
            'textHighlightColorToolStripDropDownButton2
            '
            Me.textHighlightColorToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.textHighlightColorToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.textHighlightColorToolStripDropDownButton2.Name = "textHighlightColorToolStripDropDownButton2"
            Me.textHighlightColorToolStripDropDownButton2.Size = New System.Drawing.Size(13, 23)
            Me.textHighlightColorToolStripDropDownButton2.Text = "toolStripDropDownButton2"
            '
            'formatColorToolStripDropDownButton3
            '
            Me.formatColorToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formatColorToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formatColorToolStripDropDownButton3.Name = "formatColorToolStripDropDownButton3"
            Me.formatColorToolStripDropDownButton3.Size = New System.Drawing.Size(13, 23)
            Me.formatColorToolStripDropDownButton3.Text = "toolStripDropDownButton3"
            '
            'paragraphToolStripEx
            '
            Me.paragraphToolStripEx.AutoSize = False
            Me.paragraphToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.paragraphToolStripEx.Dock = System.Windows.Forms.DockStyle.None
            Me.paragraphToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue
            Me.paragraphToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.paragraphToolStripEx.Image = Nothing
            Me.paragraphToolStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem15, Me.toolStripPanelItem16, Me.toolStripPanelItem17, Me.toolStripPanelItem18, Me.toolStripPanelItem19, Me.toolStripPanelItem20})
            Me.paragraphToolStripEx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.paragraphToolStripEx.Location = New System.Drawing.Point(374, 1)
            Me.paragraphToolStripEx.Name = "paragraphToolStripEx"
            Me.paragraphToolStripEx.Size = New System.Drawing.Size(217, 0)
            Me.paragraphToolStripEx.TabIndex = 2
            Me.paragraphToolStripEx.Text = "Paragraph"
            '
            'toolStripPanelItem15
            '
            Me.toolStripPanelItem15.AutoSize = False
            Me.toolStripPanelItem15.CausesValidation = False
            Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem15.GroupedButtons = True
            Me.toolStripPanelItem15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bulletToolStripSplitButton2, Me.numericBulletToolStripSplitButton, Me.numberBulletToolStripSplitButton})
            Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Size = New System.Drawing.Size(102, 30)
            Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Transparent = True
            Me.toolStripPanelItem15.UseStandardLayout = True
            '
            'bulletToolStripSplitButton2
            '
            Me.bulletToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bulletToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem2, Me.defineNewBulletToolStripMenuItem2})
            Me.bulletToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bulletToolStripSplitButton2.Name = "bulletToolStripSplitButton2"
            Me.bulletToolStripSplitButton2.Size = New System.Drawing.Size(16, 23)
            Me.bulletToolStripSplitButton2.Text = "toolStripSplitButton1"
            '
            'changeListLevelToolStripMenuItem2
            '
            Me.changeListLevelToolStripMenuItem2.Enabled = False
            Me.changeListLevelToolStripMenuItem2.Name = "changeListLevelToolStripMenuItem2"
            Me.changeListLevelToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
            Me.changeListLevelToolStripMenuItem2.Text = "Change List Level"
            '
            'defineNewBulletToolStripMenuItem2
            '
            Me.defineNewBulletToolStripMenuItem2.Name = "defineNewBulletToolStripMenuItem2"
            Me.defineNewBulletToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
            Me.defineNewBulletToolStripMenuItem2.Text = "Define New Bullet"
            '
            'numericBulletToolStripSplitButton
            '
            Me.numericBulletToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.numericBulletToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem3, Me.defineNewNumberFormatToolStripMenuItem, Me.setNumericValueToolStripMenuItem1})
            Me.numericBulletToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.numericBulletToolStripSplitButton.Name = "numericBulletToolStripSplitButton"
            Me.numericBulletToolStripSplitButton.Size = New System.Drawing.Size(16, 23)
            Me.numericBulletToolStripSplitButton.Text = "toolStripSplitButton2"
            '
            'changeListLevelToolStripMenuItem3
            '
            Me.changeListLevelToolStripMenuItem3.Enabled = False
            Me.changeListLevelToolStripMenuItem3.Name = "changeListLevelToolStripMenuItem3"
            Me.changeListLevelToolStripMenuItem3.Size = New System.Drawing.Size(223, 22)
            Me.changeListLevelToolStripMenuItem3.Text = "Change List Level"
            '
            'defineNewNumberFormatToolStripMenuItem
            '
            Me.defineNewNumberFormatToolStripMenuItem.Name = "defineNewNumberFormatToolStripMenuItem"
            Me.defineNewNumberFormatToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
            Me.defineNewNumberFormatToolStripMenuItem.Text = "Define New Number Format"
            '
            'setNumericValueToolStripMenuItem1
            '
            Me.setNumericValueToolStripMenuItem1.Name = "setNumericValueToolStripMenuItem1"
            Me.setNumericValueToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
            Me.setNumericValueToolStripMenuItem1.Text = "Set Numeric Value"
            '
            'numberBulletToolStripSplitButton
            '
            Me.numberBulletToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.numberBulletToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem4, Me.defineNewMultiLevelListToolStripMenuItem, Me.defineNewListStyleToolStripMenuItem})
            Me.numberBulletToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.numberBulletToolStripSplitButton.Name = "numberBulletToolStripSplitButton"
            Me.numberBulletToolStripSplitButton.Size = New System.Drawing.Size(16, 23)
            Me.numberBulletToolStripSplitButton.Text = "toolStripSplitButton3"
            '
            'changeListLevelToolStripMenuItem4
            '
            Me.changeListLevelToolStripMenuItem4.Enabled = False
            Me.changeListLevelToolStripMenuItem4.Name = "changeListLevelToolStripMenuItem4"
            Me.changeListLevelToolStripMenuItem4.Size = New System.Drawing.Size(217, 22)
            Me.changeListLevelToolStripMenuItem4.Text = "Change List Level"
            '
            'defineNewMultiLevelListToolStripMenuItem
            '
            Me.defineNewMultiLevelListToolStripMenuItem.Name = "defineNewMultiLevelListToolStripMenuItem"
            Me.defineNewMultiLevelListToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
            Me.defineNewMultiLevelListToolStripMenuItem.Text = "Define New Multi Level List"
            '
            'defineNewListStyleToolStripMenuItem
            '
            Me.defineNewListStyleToolStripMenuItem.Name = "defineNewListStyleToolStripMenuItem"
            Me.defineNewListStyleToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
            Me.defineNewListStyleToolStripMenuItem.Text = "Define New List Style"
            '
            'toolStripPanelItem16
            '
            Me.toolStripPanelItem16.AutoSize = False
            Me.toolStripPanelItem16.CausesValidation = False
            Me.toolStripPanelItem16.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem16.GroupedButtons = True
            Me.toolStripPanelItem16.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.leftindenttoolStripButton3, Me.rightindenttoolStripButton4})
            Me.toolStripPanelItem16.Name = "toolStripPanelItem16"
            Me.toolStripPanelItem16.Size = New System.Drawing.Size(52, 30)
            Me.toolStripPanelItem16.Text = "toolStripPanelItem16"
            Me.toolStripPanelItem16.Transparent = True
            Me.toolStripPanelItem16.UseStandardLayout = True
            '
            'leftindenttoolStripButton3
            '
            Me.leftindenttoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.leftindenttoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.leftindenttoolStripButton3.Name = "leftindenttoolStripButton3"
            Me.leftindenttoolStripButton3.Size = New System.Drawing.Size(23, 23)
            Me.leftindenttoolStripButton3.Text = "toolStripButton3"
            '
            'rightindenttoolStripButton4
            '
            Me.rightindenttoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.rightindenttoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rightindenttoolStripButton4.Name = "rightindenttoolStripButton4"
            Me.rightindenttoolStripButton4.Size = New System.Drawing.Size(23, 23)
            Me.rightindenttoolStripButton4.Text = "toolStripButton4"
            '
            'toolStripPanelItem17
            '
            Me.toolStripPanelItem17.AutoSize = False
            Me.toolStripPanelItem17.CausesValidation = False
            Me.toolStripPanelItem17.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem17.GroupedButtons = True
            Me.toolStripPanelItem17.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton3, Me.toolStripButton4})
            Me.toolStripPanelItem17.Name = "toolStripPanelItem17"
            Me.toolStripPanelItem17.Size = New System.Drawing.Size(52, 30)
            Me.toolStripPanelItem17.Text = "toolStripPanelItem17"
            Me.toolStripPanelItem17.Transparent = True
            Me.toolStripPanelItem17.UseStandardLayout = True
            '
            'toolStripButton3
            '
            Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(23, 23)
            Me.toolStripButton3.Text = "toolStripButton3"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(23, 23)
            Me.toolStripButton4.Text = "toolStripButton4"
            '
            'toolStripPanelItem18
            '
            Me.toolStripPanelItem18.AutoSize = False
            Me.toolStripPanelItem18.CausesValidation = False
            Me.toolStripPanelItem18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem18.GroupedButtons = True
            Me.toolStripPanelItem18.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formattextLeftAlignToolStripButton, Me.formattextCenterAlignToolStripButton, Me.formattextRightAlignToolStripButton, Me.formattextJustifyAlignToolStripButton})
            Me.toolStripPanelItem18.Name = "toolStripPanelItem18"
            Me.toolStripPanelItem18.Size = New System.Drawing.Size(98, 30)
            Me.toolStripPanelItem18.Text = "toolStripPanelItem18"
            Me.toolStripPanelItem18.Transparent = True
            Me.toolStripPanelItem18.UseStandardLayout = True
            '
            'formattextLeftAlignToolStripButton
            '
            Me.formattextLeftAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextLeftAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextLeftAlignToolStripButton.Name = "formattextLeftAlignToolStripButton"
            Me.formattextLeftAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.formattextLeftAlignToolStripButton.Text = "toolStripButton5"
            '
            'formattextCenterAlignToolStripButton
            '
            Me.formattextCenterAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextCenterAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextCenterAlignToolStripButton.Name = "formattextCenterAlignToolStripButton"
            Me.formattextCenterAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.formattextCenterAlignToolStripButton.Text = "toolStripButton6"
            '
            'formattextRightAlignToolStripButton
            '
            Me.formattextRightAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextRightAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextRightAlignToolStripButton.Name = "formattextRightAlignToolStripButton"
            Me.formattextRightAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.formattextRightAlignToolStripButton.Text = "toolStripButton7"
            '
            'formattextJustifyAlignToolStripButton
            '
            Me.formattextJustifyAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.formattextJustifyAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.formattextJustifyAlignToolStripButton.Name = "formattextJustifyAlignToolStripButton"
            Me.formattextJustifyAlignToolStripButton.Size = New System.Drawing.Size(23, 23)
            Me.formattextJustifyAlignToolStripButton.Text = "toolStripButton8"
            '
            'toolStripPanelItem19
            '
            Me.toolStripPanelItem19.AutoSize = False
            Me.toolStripPanelItem19.CausesValidation = False
            Me.toolStripPanelItem19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem19.GroupedButtons = True
            Me.toolStripPanelItem19.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton1})
            Me.toolStripPanelItem19.Name = "toolStripPanelItem19"
            Me.toolStripPanelItem19.Size = New System.Drawing.Size(38, 30)
            Me.toolStripPanelItem19.Text = "toolStripPanelItem19"
            Me.toolStripPanelItem19.Transparent = True
            Me.toolStripPanelItem19.UseStandardLayout = True
            '
            'toolStripSplitButton1
            '
            Me.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem3, Me.toolStripMenuItem4, Me.toolStripMenuItem5, Me.toolStripMenuItem6})
            Me.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
            Me.toolStripSplitButton1.Size = New System.Drawing.Size(16, 23)
            Me.toolStripSplitButton1.Text = "toolStripSplitButton1"
            '
            'toolStripMenuItem3
            '
            Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
            Me.toolStripMenuItem3.Size = New System.Drawing.Size(182, 22)
            Me.toolStripMenuItem3.Text = "Single Line Spacing"
            '
            'toolStripMenuItem4
            '
            Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
            Me.toolStripMenuItem4.Size = New System.Drawing.Size(182, 22)
            Me.toolStripMenuItem4.Text = "1.5 Spacing"
            '
            'toolStripMenuItem5
            '
            Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
            Me.toolStripMenuItem5.Size = New System.Drawing.Size(182, 22)
            Me.toolStripMenuItem5.Text = "Double Line Spacing"
            '
            'toolStripMenuItem6
            '
            Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
            Me.toolStripMenuItem6.Size = New System.Drawing.Size(182, 22)
            Me.toolStripMenuItem6.Text = "Paragraph"
            '
            'toolStripPanelItem20
            '
            Me.toolStripPanelItem20.CausesValidation = False
            Me.toolStripPanelItem20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem20.GroupedButtons = True
            Me.toolStripPanelItem20.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSplitButton2, Me.toolStripSplitButton3})
            Me.toolStripPanelItem20.Name = "toolStripPanelItem20"
            Me.toolStripPanelItem20.Size = New System.Drawing.Size(38, 25)
            Me.toolStripPanelItem20.Text = "toolStripPanelItem20"
            Me.toolStripPanelItem20.Transparent = True
            Me.toolStripPanelItem20.UseStandardLayout = True
            '
            'toolStripSplitButton2
            '
            Me.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem, Me.moreColorsToolStripMenuItem})
            Me.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton2.Name = "toolStripSplitButton2"
            Me.toolStripSplitButton2.Size = New System.Drawing.Size(16, 18)
            Me.toolStripSplitButton2.Text = "toolStripSplitButton2"
            '
            'noColorToolStripMenuItem
            '
            Me.noColorToolStripMenuItem.Name = "noColorToolStripMenuItem"
            Me.noColorToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
            Me.noColorToolStripMenuItem.Text = "No Color"
            '
            'moreColorsToolStripMenuItem
            '
            Me.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem"
            Me.moreColorsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
            Me.moreColorsToolStripMenuItem.Text = "More Colors"
            '
            'toolStripSplitButton3
            '
            Me.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bottomBorderToolStripMenuItem, Me.rightBorderToolStripMenuItem, Me.leftBorderToolStripMenuItem, Me.topBorderToolStripMenuItem, Me.toolStripSeparator1, Me.noBorderToolStripMenuItem, Me.allBordersToolStripMenuItem, Me.insideBorderToolStripMenuItem, Me.outsideBorderToolStripMenuItem, Me.toolStripSeparator2, Me.insideHorizontalBorderToolStripMenuItem, Me.insideVerticalBorderToolStripMenuItem, Me.diagonalDownBorderToolStripMenuItem, Me.diagonalUpBorderToolStripMenuItem, Me.toolStripSeparator3, Me.horizontalLineToolStripMenuItem, Me.drawTableToolStripMenuItem, Me.viewGridLinesToolStripMenuItem, Me.borderAndShadingToolStripMenuItem})
            Me.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton3.Name = "toolStripSplitButton3"
            Me.toolStripSplitButton3.Size = New System.Drawing.Size(16, 18)
            Me.toolStripSplitButton3.Text = "toolStripSplitButton3"
            '
            'bottomBorderToolStripMenuItem
            '
            Me.bottomBorderToolStripMenuItem.Name = "bottomBorderToolStripMenuItem"
            Me.bottomBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.bottomBorderToolStripMenuItem.Text = "Bottom Border"
            '
            'rightBorderToolStripMenuItem
            '
            Me.rightBorderToolStripMenuItem.Name = "rightBorderToolStripMenuItem"
            Me.rightBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.rightBorderToolStripMenuItem.Text = "Right Border"
            '
            'leftBorderToolStripMenuItem
            '
            Me.leftBorderToolStripMenuItem.Name = "leftBorderToolStripMenuItem"
            Me.leftBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.leftBorderToolStripMenuItem.Text = "Left Border"
            '
            'topBorderToolStripMenuItem
            '
            Me.topBorderToolStripMenuItem.Name = "topBorderToolStripMenuItem"
            Me.topBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.topBorderToolStripMenuItem.Text = "Top Border"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(198, 6)
            '
            'noBorderToolStripMenuItem
            '
            Me.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem"
            Me.noBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.noBorderToolStripMenuItem.Text = "No Border"
            '
            'allBordersToolStripMenuItem
            '
            Me.allBordersToolStripMenuItem.Name = "allBordersToolStripMenuItem"
            Me.allBordersToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.allBordersToolStripMenuItem.Text = "All Borders"
            '
            'insideBorderToolStripMenuItem
            '
            Me.insideBorderToolStripMenuItem.Name = "insideBorderToolStripMenuItem"
            Me.insideBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.insideBorderToolStripMenuItem.Text = "Inside Border"
            '
            'outsideBorderToolStripMenuItem
            '
            Me.outsideBorderToolStripMenuItem.Name = "outsideBorderToolStripMenuItem"
            Me.outsideBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.outsideBorderToolStripMenuItem.Text = "Outside Border"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(198, 6)
            '
            'insideHorizontalBorderToolStripMenuItem
            '
            Me.insideHorizontalBorderToolStripMenuItem.Name = "insideHorizontalBorderToolStripMenuItem"
            Me.insideHorizontalBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.insideHorizontalBorderToolStripMenuItem.Text = "Inside Horizontal Border"
            '
            'insideVerticalBorderToolStripMenuItem
            '
            Me.insideVerticalBorderToolStripMenuItem.Name = "insideVerticalBorderToolStripMenuItem"
            Me.insideVerticalBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.insideVerticalBorderToolStripMenuItem.Text = "Inside Vertical Border"
            '
            'diagonalDownBorderToolStripMenuItem
            '
            Me.diagonalDownBorderToolStripMenuItem.Enabled = False
            Me.diagonalDownBorderToolStripMenuItem.Name = "diagonalDownBorderToolStripMenuItem"
            Me.diagonalDownBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.diagonalDownBorderToolStripMenuItem.Text = "Diagonal Down Border"
            '
            'diagonalUpBorderToolStripMenuItem
            '
            Me.diagonalUpBorderToolStripMenuItem.Enabled = False
            Me.diagonalUpBorderToolStripMenuItem.Name = "diagonalUpBorderToolStripMenuItem"
            Me.diagonalUpBorderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.diagonalUpBorderToolStripMenuItem.Text = "Diagonal Up Border"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(198, 6)
            '
            'horizontalLineToolStripMenuItem
            '
            Me.horizontalLineToolStripMenuItem.Name = "horizontalLineToolStripMenuItem"
            Me.horizontalLineToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.horizontalLineToolStripMenuItem.Text = "Horizontal Line"
            '
            'drawTableToolStripMenuItem
            '
            Me.drawTableToolStripMenuItem.Name = "drawTableToolStripMenuItem"
            Me.drawTableToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.drawTableToolStripMenuItem.Text = "Draw Table"
            '
            'viewGridLinesToolStripMenuItem
            '
            Me.viewGridLinesToolStripMenuItem.Name = "viewGridLinesToolStripMenuItem"
            Me.viewGridLinesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.viewGridLinesToolStripMenuItem.Text = "View Gridlines"
            '
            'borderAndShadingToolStripMenuItem
            '
            Me.borderAndShadingToolStripMenuItem.Name = "borderAndShadingToolStripMenuItem"
            Me.borderAndShadingToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.borderAndShadingToolStripMenuItem.Text = "Border and Shading"
            '
            'stylesToolStripEx
            '
            Me.stylesToolStripEx.AutoSize = False
            Me.stylesToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.stylesToolStripEx.Dock = System.Windows.Forms.DockStyle.None
            Me.stylesToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue
            Me.stylesToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.stylesToolStripEx.Image = Nothing
            Me.stylesToolStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton3, Me.toolStripDropDownButton2})
            Me.stylesToolStripEx.Location = New System.Drawing.Point(593, 1)
            Me.stylesToolStripEx.Name = "stylesToolStripEx"
            Me.stylesToolStripEx.Size = New System.Drawing.Size(140, 0)
            Me.stylesToolStripEx.TabIndex = 3
            Me.stylesToolStripEx.Text = "Styles"
            '
            'toolStripDropDownButton3
            '
            Me.toolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveSelectionAsNewStyleToolStripMenuItem, Me.clearFormattingToolStripMenuItem, Me.applyStylesToolStripMenuItem})
            Me.toolStripDropDownButton3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton3.Name = "toolStripDropDownButton3"
            Me.toolStripDropDownButton3.Size = New System.Drawing.Size(53, 0)
            Me.toolStripDropDownButton3.Text = "Quick " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Styles"
            Me.toolStripDropDownButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripDropDownButton3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
            Me.toolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'saveSelectionAsNewStyleToolStripMenuItem
            '
            Me.saveSelectionAsNewStyleToolStripMenuItem.Name = "saveSelectionAsNewStyleToolStripMenuItem"
            Me.saveSelectionAsNewStyleToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.saveSelectionAsNewStyleToolStripMenuItem.Text = "Save Selection as New Style"
            '
            'clearFormattingToolStripMenuItem
            '
            Me.clearFormattingToolStripMenuItem.Name = "clearFormattingToolStripMenuItem"
            Me.clearFormattingToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.clearFormattingToolStripMenuItem.Text = "Clear Formatting"
            '
            'applyStylesToolStripMenuItem
            '
            Me.applyStylesToolStripMenuItem.Enabled = False
            Me.applyStylesToolStripMenuItem.Name = "applyStylesToolStripMenuItem"
            Me.applyStylesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.applyStylesToolStripMenuItem.Text = "Apply Styles"
            '
            'toolStripDropDownButton2
            '
            Me.toolStripDropDownButton2.Enabled = False
            Me.toolStripDropDownButton2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton2.Name = "toolStripDropDownButton2"
            Me.toolStripDropDownButton2.Size = New System.Drawing.Size(63, 0)
            Me.toolStripDropDownButton2.Text = "Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Styles"
            Me.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx2
            '
            Me.toolStripEx2.AutoSize = False
            Me.toolStripEx2.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx2.Image = Nothing
            Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton9})
            Me.toolStripEx2.Location = New System.Drawing.Point(735, 1)
            Me.toolStripEx2.Name = "toolStripEx2"
            Me.toolStripEx2.Size = New System.Drawing.Size(64, 0)
            Me.toolStripEx2.TabIndex = 5
            Me.toolStripEx2.Text = "Zoom"
            '
            'toolStripButton9
            '
            Me.toolStripButton9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton9.Name = "toolStripButton9"
            Me.toolStripButton9.Size = New System.Drawing.Size(41, 0)
            Me.toolStripButton9.Text = "Zoom"
            Me.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx1
            '
            Me.toolStripEx1.AutoSize = False
            Me.toolStripEx1.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx1.Image = Nothing
            Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripDropDownButton, Me.toolStripButton10, Me.toolStripDropDownButton4})
            Me.toolStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.toolStripEx1.Location = New System.Drawing.Point(801, 1)
            Me.toolStripEx1.Name = "toolStripEx1"
            Me.toolStripEx1.Size = New System.Drawing.Size(100, 0)
            Me.toolStripEx1.TabIndex = 6
            Me.toolStripEx1.Text = "Find"
            '
            'findToolStripDropDownButton
            '
            Me.findToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripMenuItem, Me.gotoToolStripMenuItem})
            Me.findToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.findToolStripDropDownButton.Name = "findToolStripDropDownButton"
            Me.findToolStripDropDownButton.Size = New System.Drawing.Size(46, 19)
            Me.findToolStripDropDownButton.Text = "Find"
            '
            'findToolStripMenuItem
            '
            Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
            Me.findToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
            Me.findToolStripMenuItem.Text = "Find"
            '
            'gotoToolStripMenuItem
            '
            Me.gotoToolStripMenuItem.Enabled = False
            Me.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem"
            Me.gotoToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
            Me.gotoToolStripMenuItem.Text = "Goto"
            '
            'toolStripButton10
            '
            Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton10.Name = "toolStripButton10"
            Me.toolStripButton10.Size = New System.Drawing.Size(52, 19)
            Me.toolStripButton10.Text = "Replace"
            '
            'toolStripDropDownButton4
            '
            Me.toolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectAllToolStripMenuItem, Me.selectObjectsToolStripMenuItem, Me.selectTextWithSimilarFontToolStripMenuItem})
            Me.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton4.Name = "toolStripDropDownButton4"
            Me.toolStripDropDownButton4.Size = New System.Drawing.Size(54, 19)
            Me.toolStripDropDownButton4.Text = "Select"
            '
            'selectAllToolStripMenuItem
            '
            Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
            Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
            Me.selectAllToolStripMenuItem.Text = "Select All"
            '
            'selectObjectsToolStripMenuItem
            '
            Me.selectObjectsToolStripMenuItem.Name = "selectObjectsToolStripMenuItem"
            Me.selectObjectsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
            Me.selectObjectsToolStripMenuItem.Text = "Select Objects"
            '
            'selectTextWithSimilarFontToolStripMenuItem
            '
            Me.selectTextWithSimilarFontToolStripMenuItem.Name = "selectTextWithSimilarFontToolStripMenuItem"
            Me.selectTextWithSimilarFontToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
            Me.selectTextWithSimilarFontToolStripMenuItem.Text = "Select Text with Similar Font"
            '
            'quickButtonReflectable2
            '
            Me.quickButtonReflectable2.Name = "quickButtonReflectable2"
            Me.quickButtonReflectable2.ReflectedButton = Me.messageCutToolStripButton
            Me.quickButtonReflectable2.Size = New System.Drawing.Size(23, 20)
            Me.quickButtonReflectable2.ToolTipText = "Cut"
            '
            'quickButtonReflectable3
            '
            Me.quickButtonReflectable3.Name = "quickButtonReflectable3"
            Me.quickButtonReflectable3.ReflectedButton = Me.messageCopyToolStripButton
            Me.quickButtonReflectable3.Size = New System.Drawing.Size(23, 20)
            Me.quickButtonReflectable3.ToolTipText = "Copy"
            '
            'quickButtonReflectable1
            '
            Me.quickButtonReflectable1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.quickButtonReflectable1.Name = "quickButtonReflectable1"
            Me.quickButtonReflectable1.ReflectedButton = Me.messagePasteToolStripButton
            Me.quickButtonReflectable1.Size = New System.Drawing.Size(36, 36)
            Me.quickButtonReflectable1.ToolTipText = "Paste"
            '
            'toolStripDropDownButton23
            '
            Me.toolStripDropDownButton23.Image = CType(resources.GetObject("toolStripDropDownButton23.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton23.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton23.Name = "toolStripDropDownButton23"
            Me.toolStripDropDownButton23.Size = New System.Drawing.Size(50, 67)
            Me.toolStripDropDownButton23.Text = "Follow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Up"
            Me.toolStripDropDownButton23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator6
            '
            Me.toolStripSeparator6.Name = "toolStripSeparator6"
            Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 70)
            '
            'toolStripPanelItem30
            '
            Me.toolStripPanelItem30.CausesValidation = False
            Me.toolStripPanelItem30.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem30.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton54, Me.toolStripButton55})
            Me.toolStripPanelItem30.Name = "toolStripPanelItem30"
            Me.toolStripPanelItem30.Size = New System.Drawing.Size(27, 70)
            Me.toolStripPanelItem30.Text = "toolStripPanelItem30"
            Me.toolStripPanelItem30.Transparent = True
            '
            'toolStripButton54
            '
            Me.toolStripButton54.AutoSize = False
            Me.toolStripButton54.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton54.Image = CType(resources.GetObject("toolStripButton54.Image"), System.Drawing.Image)
            Me.toolStripButton54.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton54.Name = "toolStripButton54"
            Me.toolStripButton54.Size = New System.Drawing.Size(23, 30)
            Me.toolStripButton54.Text = "toolStripButton54"
            '
            'toolStripButton55
            '
            Me.toolStripButton55.AutoSize = False
            Me.toolStripButton55.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton55.Image = CType(resources.GetObject("toolStripButton55.Image"), System.Drawing.Image)
            Me.toolStripButton55.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton55.Name = "toolStripButton55"
            Me.toolStripButton55.Size = New System.Drawing.Size(23, 30)
            Me.toolStripButton55.Text = "toolStripButton55"
            '
            'toolStripPanelItem31
            '
            Me.toolStripPanelItem31.CausesValidation = False
            Me.toolStripPanelItem31.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem31.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton56, Me.toolStripDropDownButton24})
            Me.toolStripPanelItem31.Name = "toolStripPanelItem31"
            Me.toolStripPanelItem31.Size = New System.Drawing.Size(60, 70)
            Me.toolStripPanelItem31.Text = "toolStripPanelItem31"
            Me.toolStripPanelItem31.Transparent = True
            '
            'toolStripButton56
            '
            Me.toolStripButton56.AutoSize = False
            Me.toolStripButton56.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton56.Image = CType(resources.GetObject("toolStripButton56.Image"), System.Drawing.Image)
            Me.toolStripButton56.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton56.Name = "toolStripButton56"
            Me.toolStripButton56.Size = New System.Drawing.Size(23, 30)
            Me.toolStripButton56.Text = "toolStripButton56"
            '
            'toolStripDropDownButton24
            '
            Me.toolStripDropDownButton24.AutoSize = False
            Me.toolStripDropDownButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownButton24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem14, Me.toolStripMenuItem15, Me.toolStripMenuItem16, Me.toolStripMenuItem17, Me.toolStripMenuItem18, Me.toolStripMenuItem19, Me.toolStripMenuItem20})
            Me.toolStripDropDownButton24.Image = CType(resources.GetObject("toolStripDropDownButton24.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton24.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton24.Name = "toolStripDropDownButton24"
            Me.toolStripDropDownButton24.Size = New System.Drawing.Size(56, 30)
            Me.toolStripDropDownButton24.Text = "Spelling"
            '
            'toolStripMenuItem14
            '
            Me.toolStripMenuItem14.Name = "toolStripMenuItem14"
            Me.toolStripMenuItem14.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem14.Text = "Spelling"
            '
            'toolStripMenuItem15
            '
            Me.toolStripMenuItem15.Name = "toolStripMenuItem15"
            Me.toolStripMenuItem15.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem15.Text = "Grammar"
            '
            'toolStripMenuItem16
            '
            Me.toolStripMenuItem16.Name = "toolStripMenuItem16"
            Me.toolStripMenuItem16.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem16.Text = "Thesaurus"
            '
            'toolStripMenuItem17
            '
            Me.toolStripMenuItem17.Name = "toolStripMenuItem17"
            Me.toolStripMenuItem17.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem17.Text = "Translate"
            '
            'toolStripMenuItem18
            '
            Me.toolStripMenuItem18.Name = "toolStripMenuItem18"
            Me.toolStripMenuItem18.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem18.Text = "Translate ScreenTip"
            '
            'toolStripMenuItem19
            '
            Me.toolStripMenuItem19.Name = "toolStripMenuItem19"
            Me.toolStripMenuItem19.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem19.Text = "Set Language"
            '
            'toolStripMenuItem20
            '
            Me.toolStripMenuItem20.Name = "toolStripMenuItem20"
            Me.toolStripMenuItem20.Size = New System.Drawing.Size(177, 22)
            Me.toolStripMenuItem20.Text = "Word Count"
            '
            'toolStripPanelItem27
            '
            Me.toolStripPanelItem27.CausesValidation = False
            Me.toolStripPanelItem27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem27.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton15, Me.toolStripDropDownButton16, Me.toolStripDropDownButton17})
            Me.toolStripPanelItem27.Name = "toolStripPanelItem27"
            Me.toolStripPanelItem27.Size = New System.Drawing.Size(94, 73)
            Me.toolStripPanelItem27.Text = "toolStripPanelItem27"
            Me.toolStripPanelItem27.Transparent = True
            '
            'toolStripDropDownButton15
            '
            Me.toolStripDropDownButton15.Enabled = False
            Me.toolStripDropDownButton15.Image = CType(resources.GetObject("toolStripDropDownButton15.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton15.Name = "toolStripDropDownButton15"
            Me.toolStripDropDownButton15.Size = New System.Drawing.Size(80, 20)
            Me.toolStripDropDownButton15.Text = "Text Box"
            '
            'toolStripDropDownButton16
            '
            Me.toolStripDropDownButton16.Enabled = False
            Me.toolStripDropDownButton16.Image = CType(resources.GetObject("toolStripDropDownButton16.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton16.Name = "toolStripDropDownButton16"
            Me.toolStripDropDownButton16.Size = New System.Drawing.Size(96, 20)
            Me.toolStripDropDownButton16.Text = "Quick Parts"
            '
            'toolStripDropDownButton17
            '
            Me.toolStripDropDownButton17.Enabled = False
            Me.toolStripDropDownButton17.Image = CType(resources.GetObject("toolStripDropDownButton17.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton17.Name = "toolStripDropDownButton17"
            Me.toolStripDropDownButton17.Size = New System.Drawing.Size(81, 20)
            Me.toolStripDropDownButton17.Text = "WordArt"
            '
            'toolStripPanelItem28
            '
            Me.toolStripPanelItem28.CausesValidation = False
            Me.toolStripPanelItem28.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem28.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton18, Me.toolStripDropDownButton19, Me.toolStripDropDownButton20})
            Me.toolStripPanelItem28.Name = "toolStripPanelItem28"
            Me.toolStripPanelItem28.Size = New System.Drawing.Size(85, 73)
            Me.toolStripPanelItem28.Text = "toolStripPanelItem28"
            Me.toolStripPanelItem28.Transparent = True
            '
            'toolStripDropDownButton18
            '
            Me.toolStripDropDownButton18.Enabled = False
            Me.toolStripDropDownButton18.Image = CType(resources.GetObject("toolStripDropDownButton18.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton18.Name = "toolStripDropDownButton18"
            Me.toolStripDropDownButton18.Size = New System.Drawing.Size(83, 20)
            Me.toolStripDropDownButton18.Text = "DropCap"
            '
            'toolStripDropDownButton19
            '
            Me.toolStripDropDownButton19.Enabled = False
            Me.toolStripDropDownButton19.Image = CType(resources.GetObject("toolStripDropDownButton19.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton19.Name = "toolStripDropDownButton19"
            Me.toolStripDropDownButton19.Size = New System.Drawing.Size(87, 20)
            Me.toolStripDropDownButton19.Text = "DateTime"
            '
            'toolStripDropDownButton20
            '
            Me.toolStripDropDownButton20.Enabled = False
            Me.toolStripDropDownButton20.Image = CType(resources.GetObject("toolStripDropDownButton20.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton20.Name = "toolStripDropDownButton20"
            Me.toolStripDropDownButton20.Size = New System.Drawing.Size(71, 20)
            Me.toolStripDropDownButton20.Text = "Object"
            '
            'toolStripPanelItem29
            '
            Me.toolStripPanelItem29.CausesValidation = False
            Me.toolStripPanelItem29.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem29.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton21, Me.toolStripDropDownButton22, Me.toolStripButton53})
            Me.toolStripPanelItem29.Name = "toolStripPanelItem29"
            Me.toolStripPanelItem29.Size = New System.Drawing.Size(101, 73)
            Me.toolStripPanelItem29.Text = "toolStripPanelItem29"
            Me.toolStripPanelItem29.Transparent = True
            '
            'toolStripDropDownButton21
            '
            Me.toolStripDropDownButton21.Enabled = False
            Me.toolStripDropDownButton21.Image = CType(resources.GetObject("toolStripDropDownButton21.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton21.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton21.Name = "toolStripDropDownButton21"
            Me.toolStripDropDownButton21.Size = New System.Drawing.Size(83, 20)
            Me.toolStripDropDownButton21.Text = "Equation"
            '
            'toolStripDropDownButton22
            '
            Me.toolStripDropDownButton22.Enabled = False
            Me.toolStripDropDownButton22.Image = CType(resources.GetObject("toolStripDropDownButton22.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton22.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton22.Name = "toolStripDropDownButton22"
            Me.toolStripDropDownButton22.Size = New System.Drawing.Size(76, 20)
            Me.toolStripDropDownButton22.Text = "Symbol"
            '
            'toolStripButton53
            '
            Me.toolStripButton53.Enabled = False
            Me.toolStripButton53.Image = CType(resources.GetObject("toolStripButton53.Image"), System.Drawing.Image)
            Me.toolStripButton53.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton53.Name = "toolStripButton53"
            Me.toolStripButton53.Size = New System.Drawing.Size(107, 20)
            Me.toolStripButton53.Text = "Horizontal Line"
            '
            'toolStripDropDownButton10
            '
            Me.toolStripDropDownButton10.Image = CType(resources.GetObject("toolStripDropDownButton10.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton10.Name = "toolStripDropDownButton10"
            Me.toolStripDropDownButton10.Size = New System.Drawing.Size(53, 77)
            Me.toolStripDropDownButton10.Text = "Follow " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Up"
            Me.toolStripDropDownButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator5
            '
            Me.toolStripSeparator5.Name = "toolStripSeparator5"
            Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 80)
            '
            'toolStripPanelItem25
            '
            Me.toolStripPanelItem25.CausesValidation = False
            Me.toolStripPanelItem25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem25.GroupedButtons = True
            Me.toolStripPanelItem25.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton40, Me.toolStripButton41})
            Me.toolStripPanelItem25.Name = "toolStripPanelItem25"
            Me.toolStripPanelItem25.Size = New System.Drawing.Size(27, 80)
            Me.toolStripPanelItem25.Text = "toolStripPanelItem25"
            Me.toolStripPanelItem25.Transparent = True
            '
            'toolStripButton40
            '
            Me.toolStripButton40.AutoSize = False
            Me.toolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton40.Image = CType(resources.GetObject("toolStripButton40.Image"), System.Drawing.Image)
            Me.toolStripButton40.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton40.Name = "toolStripButton40"
            Me.toolStripButton40.Size = New System.Drawing.Size(23, 35)
            Me.toolStripButton40.Text = "toolStripButton40"
            '
            'toolStripButton41
            '
            Me.toolStripButton41.AutoSize = False
            Me.toolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton41.Image = CType(resources.GetObject("toolStripButton41.Image"), System.Drawing.Image)
            Me.toolStripButton41.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton41.Name = "toolStripButton41"
            Me.toolStripButton41.Size = New System.Drawing.Size(23, 35)
            Me.toolStripButton41.Text = "toolStripButton41"
            '
            'toolStripPanelItem26
            '
            Me.toolStripPanelItem26.CausesValidation = False
            Me.toolStripPanelItem26.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem26.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton42, Me.toolStripDropDownButton11})
            Me.toolStripPanelItem26.Name = "toolStripPanelItem26"
            Me.toolStripPanelItem26.Size = New System.Drawing.Size(60, 80)
            Me.toolStripPanelItem26.Text = "toolStripPanelItem26"
            Me.toolStripPanelItem26.Transparent = True
            '
            'toolStripButton42
            '
            Me.toolStripButton42.AutoSize = False
            Me.toolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton42.Image = CType(resources.GetObject("toolStripButton42.Image"), System.Drawing.Image)
            Me.toolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton42.Name = "toolStripButton42"
            Me.toolStripButton42.Size = New System.Drawing.Size(56, 35)
            Me.toolStripButton42.Text = "toolStripButton42"
            '
            'toolStripDropDownButton11
            '
            Me.toolStripDropDownButton11.AutoSize = False
            Me.toolStripDropDownButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem7, Me.toolStripMenuItem8, Me.toolStripMenuItem9, Me.toolStripMenuItem10, Me.toolStripMenuItem11, Me.toolStripMenuItem12, Me.toolStripMenuItem13})
            Me.toolStripDropDownButton11.Image = CType(resources.GetObject("toolStripDropDownButton11.Image"), System.Drawing.Image)
            Me.toolStripDropDownButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownButton11.Name = "toolStripDropDownButton11"
            Me.toolStripDropDownButton11.Size = New System.Drawing.Size(56, 30)
            Me.toolStripDropDownButton11.Text = "Spelling"
            '
            'toolStripMenuItem7
            '
            Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
            Me.toolStripMenuItem7.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem7.Text = "Spelling & Grammar"
            '
            'toolStripMenuItem8
            '
            Me.toolStripMenuItem8.Name = "toolStripMenuItem8"
            Me.toolStripMenuItem8.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem8.Text = "Research"
            '
            'toolStripMenuItem9
            '
            Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
            Me.toolStripMenuItem9.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem9.Text = "Thesaurus"
            '
            'toolStripMenuItem10
            '
            Me.toolStripMenuItem10.Name = "toolStripMenuItem10"
            Me.toolStripMenuItem10.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem10.Text = "Translate"
            '
            'toolStripMenuItem11
            '
            Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
            Me.toolStripMenuItem11.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem11.Text = "Translation Screen Tip"
            '
            'toolStripMenuItem12
            '
            Me.toolStripMenuItem12.Name = "toolStripMenuItem12"
            Me.toolStripMenuItem12.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem12.Text = "Set Language"
            '
            'toolStripMenuItem13
            '
            Me.toolStripMenuItem13.Name = "toolStripMenuItem13"
            Me.toolStripMenuItem13.Size = New System.Drawing.Size(191, 22)
            Me.toolStripMenuItem13.Text = "Word Count"
            '
            'subjectTextBox
            '
            Me.subjectTextBox.Location = New System.Drawing.Point(142, 66)
            Me.subjectTextBox.Name = "subjectTextBox"
            Me.subjectTextBox.Size = New System.Drawing.Size(866, 20)
            Me.subjectTextBox.TabIndex = 7
            '
            'ccTextBoxExt
            '
            Me.ccTextBoxExt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ccTextBoxExt.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ccTextBoxExt.Location = New System.Drawing.Point(143, 40)
            Me.ccTextBoxExt.Name = "ccTextBoxExt"
            Me.ccTextBoxExt.OverflowIndicatorToolTipText = Nothing
            Me.ccTextBoxExt.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.ccTextBoxExt.Size = New System.Drawing.Size(866, 20)
            Me.ccTextBoxExt.TabIndex = 6
            '
            'toTextBoxExt
            '
            Me.toTextBoxExt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.toTextBoxExt.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.toTextBoxExt.Location = New System.Drawing.Point(143, 14)
            Me.toTextBoxExt.Name = "toTextBoxExt"
            Me.toTextBoxExt.OverflowIndicatorToolTipText = Nothing
            Me.toTextBoxExt.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.toTextBoxExt.Size = New System.Drawing.Size(866, 20)
            Me.toTextBoxExt.TabIndex = 5
            '
            'autoLabel1
            '
            Me.autoLabel1.BackColor = System.Drawing.Color.Transparent
            Me.autoLabel1.Location = New System.Drawing.Point(85, 70)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(52, 13)
            Me.autoLabel1.TabIndex = 3
            Me.autoLabel1.Text = "Subject..."
            '
            'ccbuttonAdv1
            '
            Me.ccbuttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ccbuttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ccbuttonAdv1.Location = New System.Drawing.Point(96, 40)
            Me.ccbuttonAdv1.Name = "ccbuttonAdv1"
            Me.ccbuttonAdv1.Size = New System.Drawing.Size(41, 20)
            Me.ccbuttonAdv1.TabIndex = 2
            Me.ccbuttonAdv1.Text = "Cc..."
            Me.ccbuttonAdv1.UseVisualStyle = True
            '
            'toButtonAdv
            '
            Me.toButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.toButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toButtonAdv.Location = New System.Drawing.Point(96, 13)
            Me.toButtonAdv.Name = "toButtonAdv"
            Me.toButtonAdv.Size = New System.Drawing.Size(41, 21)
            Me.toButtonAdv.TabIndex = 1
            Me.toButtonAdv.Text = "To..."
            Me.toButtonAdv.UseVisualStyle = True
            '
            'sendButtonAdv
            '
            Me.sendButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.sendButtonAdv.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.sendButtonAdv.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.sendButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.sendButtonAdv.Location = New System.Drawing.Point(11, 14)
            Me.sendButtonAdv.Name = "sendButtonAdv"
            Me.sendButtonAdv.Size = New System.Drawing.Size(68, 73)
            Me.sendButtonAdv.TabIndex = 0
            Me.sendButtonAdv.Text = "Send"
            Me.sendButtonAdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.sendButtonAdv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.sendButtonAdv.UseCompatibleTextRendering = True
            Me.sendButtonAdv.UseVisualStyle = True
            Me.sendButtonAdv.UseVisualStyleBackColor = False
            '
            'richTextBox1
            '
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Location = New System.Drawing.Point(6, 255)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(1012, 507)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = ""
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "")
            Me.imageList1.Images.SetKeyName(9, "")
            Me.imageList1.Images.SetKeyName(10, "")
            Me.imageList1.Images.SetKeyName(11, "")
            Me.imageList1.Images.SetKeyName(12, "")
            Me.imageList1.Images.SetKeyName(13, "")
            Me.imageList1.Images.SetKeyName(14, "")
            Me.imageList1.Images.SetKeyName(15, "")
            Me.imageList1.Images.SetKeyName(16, "")
            Me.imageList1.Images.SetKeyName(17, "")
            Me.imageList1.Images.SetKeyName(18, "")
            Me.imageList1.Images.SetKeyName(19, "")
            Me.imageList1.Images.SetKeyName(20, "")
            Me.imageList1.Images.SetKeyName(21, "")
            Me.imageList1.Images.SetKeyName(22, "")
            Me.imageList1.Images.SetKeyName(23, "")
            Me.imageList1.Images.SetKeyName(24, "")
            Me.imageList1.Images.SetKeyName(25, "")
            Me.imageList1.Images.SetKeyName(26, "")
            Me.imageList1.Images.SetKeyName(27, "")
            Me.imageList1.Images.SetKeyName(28, "")
            Me.imageList1.Images.SetKeyName(29, "")
            Me.imageList1.Images.SetKeyName(30, "")
            Me.imageList1.Images.SetKeyName(31, "")
            Me.imageList1.Images.SetKeyName(32, "")
            Me.imageList1.Images.SetKeyName(33, "")
            Me.imageList1.Images.SetKeyName(34, "")
            Me.imageList1.Images.SetKeyName(35, "")
            Me.imageList1.Images.SetKeyName(36, "")
            Me.imageList1.Images.SetKeyName(37, "")
            Me.imageList1.Images.SetKeyName(38, "")
            Me.imageList1.Images.SetKeyName(39, "")
            Me.imageList1.Images.SetKeyName(40, "")
            Me.imageList1.Images.SetKeyName(41, "")
            Me.imageList1.Images.SetKeyName(42, "")
            Me.imageList1.Images.SetKeyName(43, "")
            Me.imageList1.Images.SetKeyName(44, "")
            Me.imageList1.Images.SetKeyName(45, "")
            Me.imageList1.Images.SetKeyName(46, "")
            Me.imageList1.Images.SetKeyName(47, "")
            Me.imageList1.Images.SetKeyName(48, "")
            Me.imageList1.Images.SetKeyName(49, "today.png")
            '
            'superToolTip1
            '
            Me.superToolTip1.MetroColor = System.Drawing.Color.Empty
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.toTextBoxExt)
            Me.panel1.Controls.Add(Me.subjectTextBox)
            Me.panel1.Controls.Add(Me.sendButtonAdv)
            Me.panel1.Controls.Add(Me.ccTextBoxExt)
            Me.panel1.Controls.Add(Me.toButtonAdv)
            Me.panel1.Controls.Add(Me.autoLabel1)
            Me.panel1.Controls.Add(Me.ccbuttonAdv1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(6, 155)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1012, 100)
            Me.panel1.TabIndex = 8
            '
            'NewMailForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1024, 768)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.ribbonControlAdv1)
            Me.HelpButton = True
            Me.HelpButtonImage = CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image)
            Me.Name = "NewMailForm"
            Me.Text = "New Mail"
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ribbonControlAdv1.ResumeLayout(False)
            Me.ribbonControlAdv1.PerformLayout()
            Me.messageTabStripItem.Panel.ResumeLayout(False)
            Me.toolStripEx3.ResumeLayout(False)
            Me.toolStripEx3.PerformLayout()
            Me.toolStripEx4.ResumeLayout(False)
            Me.toolStripEx4.PerformLayout()
            Me.toolStripEx10.ResumeLayout(False)
            Me.toolStripEx10.PerformLayout()
            Me.toolStripEx11.ResumeLayout(False)
            Me.toolStripEx11.PerformLayout()
            Me.toolStripEx12.ResumeLayout(False)
            Me.toolStripEx12.PerformLayout()
            Me.toolStripTabItem1.Panel.ResumeLayout(False)
            Me.toolStripEx13.ResumeLayout(False)
            Me.toolStripEx13.PerformLayout()
            Me.toolStripEx14.ResumeLayout(False)
            Me.toolStripEx14.PerformLayout()
            Me.toolStripEx15.ResumeLayout(False)
            Me.toolStripEx15.PerformLayout()
            Me.toolStripEx16.ResumeLayout(False)
            Me.toolStripEx16.PerformLayout()
            Me.toolStripEx17.ResumeLayout(False)
            Me.toolStripEx17.PerformLayout()
            Me.toolStripTabItem2.Panel.ResumeLayout(False)
            Me.toolStripEx5.ResumeLayout(False)
            Me.toolStripEx5.PerformLayout()
            Me.toolStripEx6.ResumeLayout(False)
            Me.toolStripEx6.PerformLayout()
            Me.toolStripEx7.ResumeLayout(False)
            Me.toolStripEx7.PerformLayout()
            Me.toolStripEx8.ResumeLayout(False)
            Me.toolStripEx8.PerformLayout()
            Me.toolStripEx9.ResumeLayout(False)
            Me.toolStripEx9.PerformLayout()
            Me.toolStripTabItem3.Panel.ResumeLayout(False)
            Me.formatClipboardToolStripEx.ResumeLayout(False)
            Me.formatClipboardToolStripEx.PerformLayout()
            Me.fontToolStripEx.ResumeLayout(False)
            Me.fontToolStripEx.PerformLayout()
            Me.paragraphToolStripEx.ResumeLayout(False)
            Me.paragraphToolStripEx.PerformLayout()
            Me.stylesToolStripEx.ResumeLayout(False)
            Me.stylesToolStripEx.PerformLayout()
            Me.toolStripEx2.ResumeLayout(False)
            Me.toolStripEx2.PerformLayout()
            Me.toolStripEx1.ResumeLayout(False)
            Me.toolStripEx1.PerformLayout()
            CType(Me.ccTextBoxExt, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toTextBoxExt, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
		Private messageTabStripItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem3 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private formatClipboardToolStripEx As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem9 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents messagePasteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem10 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents messageCutToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents messageCopyToolStripButton As System.Windows.Forms.ToolStripButton
		Private formatPaintertoolStripButton4 As System.Windows.Forms.ToolStripButton
		Private fontToolStripEx As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem11 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents fontToolStripComboBox As System.Windows.Forms.ToolStripComboBox
		Private WithEvents fontSizeComboBox As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem12 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private growtoolStripButton2 As System.Windows.Forms.ToolStripButton
		Private shrinktoolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem13 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents boldtoolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents italictoolStripButton4 As System.Windows.Forms.ToolStripButton
		Private WithEvents underlinetoolStripButton5 As System.Windows.Forms.ToolStripButton
		Private WithEvents strikethroughtoolStripButton6 As System.Windows.Forms.ToolStripButton
		Private subscripttoolStripButton7 As System.Windows.Forms.ToolStripButton
		Private superscripttoolStripButton8 As System.Windows.Forms.ToolStripButton
		Private changecaseToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
		Private sentenceCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private lowerCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private upperCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private capitalizeEachWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tOGGLECASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem14 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private textHighlightColorToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
		Private formatColorToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
		Private paragraphToolStripEx As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem15 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private bulletToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
		Private numericBulletToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
		Private numberBulletToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
		Private changeListLevelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewBulletToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewNumberFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private setNumericValueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewMultiLevelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private defineNewListStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem16 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents leftindenttoolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents rightindenttoolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem17 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem18 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private formattextLeftAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private formattextCenterAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private formattextRightAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private formattextJustifyAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem19 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
		Private toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem20 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
		Private noColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSplitButton3 As System.Windows.Forms.ToolStripSplitButton
		Private bottomBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private rightBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private leftBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private topBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private noBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private allBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private insideBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private outsideBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private insideHorizontalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private insideVerticalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private diagonalDownBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private diagonalUpBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private horizontalLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private drawTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private viewGridLinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private borderAndShadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private stylesToolStripEx As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
		Private saveSelectionAsNewStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clearFormattingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents applyStylesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton9 As System.Windows.Forms.ToolStripButton
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private findToolStripDropDownButton As System.Windows.Forms.ToolStripSplitButton
		Private findToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private gotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripDropDownButton4 As System.Windows.Forms.ToolStripSplitButton
		Private selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private selectObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private selectTextWithSimilarFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx3 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents formattextPasteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton5 As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteSpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents formattextCutToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents formattextCopyAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private toolStripEx4 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents messageFontListComboBox As System.Windows.Forms.ToolStripComboBox
		Private WithEvents messageFontSizeComboBox As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton15 As System.Windows.Forms.ToolStripButton
		Private toolStripButton16 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButton4 As System.Windows.Forms.ToolStripSplitButton
		Private toolStripSplitButton5 As System.Windows.Forms.ToolStripSplitButton
		Private changeListLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private defineNewBulletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewNumberFormatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private setNumberingValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton17 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem7 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents messageBoldToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents messageItalicToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents messageUnderlineToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem8 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButton6 As System.Windows.Forms.ToolStripSplitButton
		Private noColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSplitButton7 As System.Windows.Forms.ToolStripSplitButton
		Private moreColorsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem21 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private messageLeftAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private messageCenterAlignToolStripButton As System.Windows.Forms.ToolStripButton
		Private messageRightToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem22 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents messageIndentToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents messageOutdentToolStripButton As System.Windows.Forms.ToolStripButton
		Private sendButtonAdv As Syncfusion.Windows.Forms.ButtonAdv
		Private ccbuttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private toButtonAdv As Syncfusion.Windows.Forms.ButtonAdv
		Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private ccTextBoxExt As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private toTextBoxExt As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private subjectTextBox As System.Windows.Forms.TextBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private toolStripEx5 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private themesToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem23 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripSplitButton8 As System.Windows.Forms.ToolStripSplitButton
		Private toolStripSplitButton9 As System.Windows.Forms.ToolStripSplitButton
		Private toolStripSplitButton10 As System.Windows.Forms.ToolStripSplitButton
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private toolStripDropDownButton6 As System.Windows.Forms.ToolStripDropDownButton
		Private noColorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
		Private fillEffectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton26 As System.Windows.Forms.ToolStripButton
		Private toolStripButton27 As System.Windows.Forms.ToolStripButton
		Private toolStripEx7 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton28 As System.Windows.Forms.ToolStripButton
		Private toolStripButton29 As System.Windows.Forms.ToolStripButton
		Private toolStripButton30 As System.Windows.Forms.ToolStripButton
		Private toolStripEx8 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem24 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton31 As System.Windows.Forms.ToolStripButton
		Private toolStripButton32 As System.Windows.Forms.ToolStripButton
		Private toolStripEx9 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripSplitButton11 As System.Windows.Forms.ToolStripSplitButton
		Private otherFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private useDefaultFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private donotSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripButton33 As System.Windows.Forms.ToolStripButton
		Private toolStripButton34 As System.Windows.Forms.ToolStripButton
		Private toolStripEx10 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton35 As System.Windows.Forms.ToolStripButton
		Private toolStripButton36 As System.Windows.Forms.ToolStripButton
		Private toolStripEx11 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton37 As System.Windows.Forms.ToolStripButton
		Private toolStripButton38 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton8 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton39 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton9 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton10 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private toolStripPanelItem25 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton40 As System.Windows.Forms.ToolStripButton
		Private toolStripButton41 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem26 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton42 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton11 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx13 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton43 As System.Windows.Forms.ToolStripButton
		Private toolStripButton44 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton12 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton45 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton13 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripEx14 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton46 As System.Windows.Forms.ToolStripButton
		Private toolStripEx15 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton47 As System.Windows.Forms.ToolStripButton
		Private toolStripButton48 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton14 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton49 As System.Windows.Forms.ToolStripButton
		Private toolStripButton50 As System.Windows.Forms.ToolStripButton
		Private toolStripEx16 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton51 As System.Windows.Forms.ToolStripButton
		Private toolStripButton52 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem27 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton15 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton16 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton17 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem28 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton18 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton19 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton20 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem29 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton21 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton22 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton53 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton23 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
		Private toolStripPanelItem30 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton54 As System.Windows.Forms.ToolStripButton
		Private toolStripButton55 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem31 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton56 As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownButton24 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx12 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton25 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripEx17 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem32 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton26 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton27 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripDropDownButton28 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripPanelItem33 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripDropDownButton29 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripButton58 As System.Windows.Forms.ToolStripButton
		Private toolStripButton59 As System.Windows.Forms.ToolStripButton
		Private otherBusinessCardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private signToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private signaturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private quickButtonReflectable1 As Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
		Private quickButtonReflectable2 As Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
		Private quickButtonReflectable3 As Syncfusion.Windows.Forms.Tools.QuickButtonReflectable
		Private toolStripSplitButton12 As System.Windows.Forms.ToolStripSplitButton
		Private WithEvents blueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents blackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents silverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
		Private newMailMessageToolStripButton1 As System.Windows.Forms.ToolStripButton
		Private sendtoolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
		Private savetoolStripButton As System.Windows.Forms.ToolStripButton
		Private saveasToolStripButton As System.Windows.Forms.ToolStripButton
		Private deleteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
		Private propertiesToolStripButton1 As System.Windows.Forms.ToolStripButton
		Private closeToolStripButton As System.Windows.Forms.ToolStripButton
		Private panel1 As System.Windows.Forms.Panel
		Private officeSplitButton1 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private toolStripButton7 As System.Windows.Forms.ToolStripButton
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton8 As System.Windows.Forms.ToolStripButton
		Private toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private toolStripButton12 As System.Windows.Forms.ToolStripButton
		Private toolStripButton13 As System.Windows.Forms.ToolStripButton
		Private toolStripButton18 As System.Windows.Forms.ToolStripButton
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

