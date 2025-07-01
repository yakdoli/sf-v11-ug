#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace OutlookDemo
	Partial Public Class NewMailForm
		Inherits RibbonForm
		Private m_form1 As Form1
		Public Sub New(ByVal parentForm As Form1, ByVal theme As String)
			InitializeComponent()
			Me.m_form1 = parentForm
			SetTheme(theme)
		End Sub

        Private Sub OnNewMailFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.boldtoolStripButton3.Image = My.Resources.boldhs
            toolTipInfo7.Header.Image = My.Resources.boldhs
            Me.ribbonControlAdv1.MenuButtonImage = My.Resources.syncfusion_logo
            Me.toolStripButton8.Image = My.Resources.NewMessageHS
            Me.italictoolStripButton4.Image = My.Resources.ItalicHS
            Me.toolStripButton11.Image = My.Resources.appointment
            Me.toolStripButton12.Image = My.Resources.meetingrequest
            Me.toolStripButton13.Image = My.Resources.business_card
            Me.toolStripButton18.Image = My.Resources.distributionlist
            Me.toolStripButton19.Image = My.Resources.TaskHS
            Me.savetoolStripButton.Image = My.Resources.save
            Me.saveasToolStripButton.Image = My.Resources.saveas
            Me.deleteToolStripButton.Image = My.Resources.delete
            Me.toolStripButton1.Image = My.Resources.folder
            Me.toolStripButton5.Image = My.Resources.folder
            Me.toolStripButton6.Image = My.Resources.folder
            Me.propertiesToolStripButton1.Image = My.Resources.properties
            Me.closeToolStripButton.Image = My.Resources.close
            Me.toolStripMenuItem1.Image = My.Resources.pasteicon
            Me.toolStripMenuItem2.Image = My.Resources.pastespecial
            Me.toolStripSplitButton5.Image = My.Resources.bullet_icon2
            Me.changeListLevelToolStripMenuItem1.Image = My.Resources.bullet_icon4
            Me.toolStripButton17.Image = My.Resources.text_icon7
            Me.messageItalicToolStripButton.Image = My.Resources.ItalicHS
            Me.newMailMessageToolStripButton1.Image = My.Resources.newmailmessage
            Me.sendtoolStripButton.Image = My.Resources.send
            Me.toolStripButton20.Image = My.Resources.note
            Me.officeSplitButton1.Image = My.Resources.moveto
            Me.toolStripEx3.Image = My.Resources.paste
            Me.formattextPasteToolStripButton.Image = My.Resources.paste
            Me.messageCutToolStripButton.Image = My.Resources.cut_icon
            Me.formatClipboardToolStripEx.Image = My.Resources.paste
            Me.messagePasteToolStripButton.Image = My.Resources.paste
            Me.formattextCopyAlignToolStripButton.Image = My.Resources.copy_icon
            Me.messageCopyToolStripButton.Image = My.Resources.copy_icon
            Me.toolStripButton14.Image = My.Resources.format_painter
            Me.fontToolStripEx.Image = My.Resources.text_icon_32_2
            Me.shrinktoolStripButton3.Image = My.Resources.text_icon4
            Me.strikethroughtoolStripButton6.Image = My.Resources.text_icon14
            Me.subscripttoolStripButton7.Image = My.Resources.text_icon15
            Me.changecaseToolStripDropDownButton2.Image = My.Resources.text_icon17
            Me.textHighlightColorToolStripDropDownButton2.Image = My.Resources.text_icon10
            Me.formatColorToolStripDropDownButton3.Image = My.Resources.text_icon9
            Me.bulletToolStripSplitButton2.Image = My.Resources.bullet_icon1
            Me.changeListLevelToolStripMenuItem2.Image = My.Resources.bullet_icon4
            Me.numericBulletToolStripSplitButton.Image = My.Resources.bullet_icon2
            Me.changeListLevelToolStripMenuItem3.Image = My.Resources.bullet_icon4
            Me.numberBulletToolStripSplitButton.Image = My.Resources.bullet_icon3
            Me.changeListLevelToolStripMenuItem4.Image = My.Resources.bullet_icon4
            Me.leftindenttoolStripButton3.Image = My.Resources.IndentHS
            Me.rightindenttoolStripButton4.Image = My.Resources.OutdentHS
            Me.toolStripButton3.Image = My.Resources.SortUpHS
            Me.toolStripButton4.Image = My.Resources.general_icon1
            Me.formattextLeftAlignToolStripButton.Image = My.Resources.left_justity_icon
            Me.formattextCenterAlignToolStripButton.Image = My.Resources.center_justity_icon
            Me.formattextRightAlignToolStripButton.Image = My.Resources.right_justity_icon
            Me.toolStripSplitButton1.Image = My.Resources.line_spacing_icon
            Me.toolStripSplitButton2.Image = My.Resources.painbucket_icon1
            Me.toolStripSplitButton3.Image = My.Resources.border_icon1
            Me.bottomBorderToolStripMenuItem.Image = My.Resources.border_icon1
            Me.rightBorderToolStripMenuItem.Image = My.Resources.border_icon4
            Me.leftBorderToolStripMenuItem.Image = My.Resources.border_icon3
            Me.topBorderToolStripMenuItem.Image = My.Resources.border_icon2
            Me.noBorderToolStripMenuItem.Image = My.Resources.border_icon5
            Me.allBordersToolStripMenuItem.Image = My.Resources.border_icon6
            Me.insideBorderToolStripMenuItem.Image = My.Resources.border_icon8
            Me.outsideBorderToolStripMenuItem.Image = My.Resources.border_icon7
            Me.insideHorizontalBorderToolStripMenuItem.Image = My.Resources.border_icon9
            Me.insideVerticalBorderToolStripMenuItem.Image = My.Resources.border_icon10
            Me.diagonalDownBorderToolStripMenuItem.Image = My.Resources.border_icon11
            Me.diagonalUpBorderToolStripMenuItem.Image = My.Resources.border_icon12
            Me.viewGridLinesToolStripMenuItem.Image = My.Resources.border_icon15
            Me.toolStripDropDownButton3.Image = My.Resources.text_icon_32_2
            Me.formatPaintertoolStripButton4.Image = My.Resources.format_painter
            Me.toolStripEx4.Image = My.Resources.text_icon_32_1
            Me.toolStripButton15.Image = My.Resources.text_icon3
            Me.toolStripSplitButton4.Image = My.Resources.bullet_icon1
            Me.changeListLevelToolStripMenuItem.Image = My.Resources.bullet_icon4
            Me.messageBoldToolStripButton.Image = My.Resources.boldhs
            Me.messageUnderlineToolStripButton.Image = My.Resources.text_icon13
            Me.toolStripSplitButton6.Image = My.Resources.text_icon10
            Me.moreColorsToolStripMenuItem1.Image = My.Resources.general_icon6
            Me.toolStripSplitButton7.Image = My.Resources.text_icon9
            Me.moreColorsToolStripMenuItem2.Image = My.Resources.general_icon6
            Me.messageLeftAlignToolStripButton.Image = My.Resources.left_justity_icon
            Me.messageCenterAlignToolStripButton.Image = My.Resources.center_justity_icon
            Me.messageRightToolStripButton.Image = My.Resources.right_justity_icon
            Me.messageIndentToolStripButton.Image = My.Resources.IndentHS
            Me.messageOutdentToolStripButton.Image = My.Resources.OutdentHS
            Me.toolStripButton35.Image = My.Resources.addressbook
            Me.toolStripButton36.Image = My.Resources.check_names
            Me.toolStripButton37.Image = My.Resources.attach
            Me.toolStripButton38.Image = My.Resources.attach_item
            Me.toolStripButton39.Image = My.Resources.calender
            Me.toolStripDropDownButton9.Image = My.Resources.signature
            Me.toolStripSplitButton12.Image = My.Resources.text_icon_32_2
            Me.toolStripDropDownButton25.Image = My.Resources.spell_check_icon
            Me.toolStripMenuItem21.Image = My.Resources.spell_check_icon_16
            Me.toolStripButton16.Image = My.Resources.text_icon4
            Me.toolStripEx10.Image = My.Resources.addressbook
            Me.toolStripButton43.Image = My.Resources.attach
            Me.toolStripEx13.Image = My.Resources.attach
            Me.toolStripEx11.Image = My.Resources.attach
            Me.toolStripDropDownButton12.Image = My.Resources.business_card
            Me.toolStripDropDownButton8.Image = My.Resources.business_card
            Me.toolStripEx12.Image = My.Resources.spell_check_icon
            Me.toolStripMenuItem22.Image = My.Resources.research_icon_16
            Me.toolStripMenuItem23.Image = My.Resources.thesau_icon_16
            Me.toolStripMenuItem24.Image = My.Resources.translate_icon_16
            Me.toolStripMenuItem26.Image = My.Resources.set_lang_icon_16
            Me.toolStripMenuItem27.Image = My.Resources.word_count_icon_16
            Me.toolStripDropDownButton4.Image = My.Resources.select
            Me.selectAllToolStripMenuItem.Image = My.Resources.selectall
            Me.selectObjectsToolStripMenuItem.Image = My.Resources.select
            Me.toolStripButton45.Image = My.Resources.calender
            Me.toolStripButton44.Image = My.Resources.attach_item
            Me.toolStripDropDownButton13.Image = My.Resources.signature
            Me.toolStripButton46.Image = My.Resources.table_icon
            Me.toolStripButton47.Image = My.Resources.picture_icon
            Me.toolStripButton48.Image = My.Resources.clipart_icon
            Me.toolStripDropDownButton14.Image = My.Resources.shapes_icon
            Me.toolStripButton49.Image = My.Resources.smartart_icon
            Me.toolStripButton50.Image = My.Resources.chart_icon
            Me.toolStripButton51.Image = My.Resources.hyperlink_icon1_16
            Me.toolStripButton52.Image = My.Resources.bookmark_icon_16
            Me.toolStripDropDownButton26.Image = My.Resources.text_icon_32_1
            Me.toolStripDropDownButton27.Image = My.Resources.quickpart_icon
            Me.toolStripDropDownButton28.Image = My.Resources.wordart_icon
            Me.toolStripButton58.Image = My.Resources.date_time_icon_16
            Me.toolStripButton59.Image = My.Resources.object_icon_16
            Me.themesToolStripDropDownButton.Image = My.Resources.themes_icon
            Me.toolStripSplitButton8.Image = My.Resources.color_icon_16
            Me.toolStripSplitButton9.Image = My.Resources.font_icon_16
            Me.toolStripSplitButton10.Image = My.Resources.effect_icon_16
            Me.toolStripDropDownButton6.Image = My.Resources.page_color
            Me.toolStripButton26.Image = My.Resources.show_bcc
            Me.toolStripButton27.Image = My.Resources.show_from
            Me.toolStripDropDownButton7.Image = My.Resources.vote
            Me.toolStripSplitButton11.Image = My.Resources.save_sentitem
            Me.toolStripButton33.Image = My.Resources.delay_delivery
            Me.toolStripButton34.Image = My.Resources.direct_repliesto
            Me.pasteSpecialToolStripMenuItem.Image = My.Resources.pastespecial
            Me.formattextCutToolStripButton.Image = My.Resources.cut_icon
            Me.growtoolStripButton2.Image = My.Resources.text_icon3
            Me.toolStripButton2.Image = My.Resources.text_icon7
            Me.underlinetoolStripButton5.Image = My.Resources.text_icon13
            Me.superscripttoolStripButton8.Image = My.Resources.text_icon16
            Me.toolStripDropDownButton2.Image = My.Resources.text_icon_32_1
            Me.toolStripButton9.Image = My.Resources.zoom_icon
            Me.findToolStripDropDownButton.Image = My.Resources.FindHS
            Me.findToolStripMenuItem.Image = My.Resources.FindHS
            Me.toolStripEx14.Image = My.Resources.TableHS
            Me.toolStripEx15.Image = My.Resources.picture_icon
            Me.toolStripEx16.Image = My.Resources.hyperlink_icon1_16
            Me.toolStripEx17.Image = My.Resources.text_icon_32_1
            Me.toolStripEx5.Image = My.Resources.themes_icon
            Me.pasteToolStripMenuItem.Image = My.Resources.pasteicon
            Me.formattextJustifyAlignToolStripButton.Image = My.Resources.justity_icon
            Me.drawTableToolStripMenuItem.Image = My.Resources.border_icon14
            Me.moreColorsToolStripMenuItem3.Image = My.Resources.general_icon6
            Me.clearFormattingToolStripMenuItem.Image = My.Resources.text_icon7
            Me.toolStripEx2.Image = My.Resources.zoom_icon
            Me.toolStripEx1.Image = My.Resources.FindHS
            toolTipInfo9.Header.Image = My.Resources.text_icon13
            Me.gotoToolStripMenuItem.Image = My.Resources.gotoicon
            toolTipInfo8.Header.Image = My.Resources.ItalicHS
            For Each o As Object In New FontListBox().Items
                Me.messageFontListComboBox.Items.Add(o)
                Me.fontToolStripComboBox.Items.Add(o)
            Next o
            Me.messageFontListComboBox.SelectedItem = "Calibri"
            Me.fontToolStripComboBox.SelectedItem = "Calibri"
            Me.richTextBox1.SelectionFont = New Font("Calibri", 11)
        End Sub

		#Region "TextChange EventHandlers"

		Private Sub OnBoldClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageBoldToolStripButton.Click, boldtoolStripButton3.Click
			Dim boldToolStripBtn As ToolStripButton = TryCast(sender, ToolStripButton)
			If Not boldToolStripBtn.Checked Then
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not(richTextBox1.SelectionFont.Style And FontStyle.Bold)))
			Else
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Bold)
			End If
		End Sub

		Private Sub OnItalicClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageItalicToolStripButton.Click, italictoolStripButton4.Click
			Dim italicToolStripBtn As ToolStripButton = TryCast(sender, ToolStripButton)
			If Not italicToolStripBtn.Checked Then
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not(richTextBox1.SelectionFont.Style And FontStyle.Italic)))
			Else
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Italic)
			End If
		End Sub

		Private Sub OnUnderlineClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageUnderlineToolStripButton.Click, underlinetoolStripButton5.Click
			Dim underlineToolStripBtn As ToolStripButton = TryCast(sender, ToolStripButton)
			If Not underlineToolStripBtn.Checked Then
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not(richTextBox1.SelectionFont.Style And FontStyle.Underline)))
			Else
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Underline)
			End If
		End Sub

		Private Sub OnStrikeThroughClick(ByVal sender As Object, ByVal e As EventArgs) Handles strikethroughtoolStripButton6.Click
			Dim strikeThroughToolStripBtn As ToolStripButton = TryCast(sender, ToolStripButton)
			If Not strikeThroughToolStripBtn.Checked Then
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not(richTextBox1.SelectionFont.Style And FontStyle.Strikeout)))
			Else
				Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Strikeout)
			End If
		End Sub

		Private Sub OnIndentClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageIndentToolStripButton.Click, leftindenttoolStripButton3.Click
			Me.richTextBox1.SelectionIndent += 20
		End Sub

		Private Sub OnOutdentClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageOutdentToolStripButton.Click, rightindenttoolStripButton4.Click
			If Me.richTextBox1.SelectionIndent > 0 Then
				Me.richTextBox1.SelectionIndent -= 20
			End If
		End Sub

		Private Sub OnFontChange(ByVal sender As Object, ByVal e As EventArgs) Handles messageFontListComboBox.SelectedIndexChanged, fontToolStripComboBox.SelectedIndexChanged
			Dim fontListCombo As ToolStripComboBox = TryCast(sender, ToolStripComboBox)
			Me.messageFontListComboBox.SelectedItem = fontListCombo.SelectedItem.ToString()
			Me.fontToolStripComboBox.SelectedItem = fontListCombo.SelectedItem.ToString()
			Me.richTextBox1.SelectionFont = New Font(fontListCombo.SelectedItem.ToString(), Me.richTextBox1.SelectionFont.Size)
		End Sub

		Private Sub OnFontSizeChange(ByVal sender As Object, ByVal e As EventArgs) Handles messageFontSizeComboBox.SelectedIndexChanged, fontSizeComboBox.SelectedIndexChanged
			Dim fontSizeComboBox As ToolStripComboBox = TryCast(sender, ToolStripComboBox)
			Me.richTextBox1.SelectionFont = New Font(Me.messageFontListComboBox.SelectedItem.ToString(), Single.Parse(fontSizeComboBox.SelectedItem.ToString()))
		End Sub

		#End Region

		#Region "Cut,Copy and Paste Event Handlers"

		Private Sub OnPasteClick(ByVal sender As Object, ByVal e As EventArgs) Handles messagePasteToolStripButton.Click, toolStripMenuItem1.Click, formattextPasteToolStripButton.Click, pasteToolStripMenuItem.Click
			Me.richTextBox1.Paste()
		End Sub

		Private Sub OnCutClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageCutToolStripButton.Click, formattextCutToolStripButton.Click
			Me.richTextBox1.Cut()
		End Sub

		Private Sub OnCopyClick(ByVal sender As Object, ByVal e As EventArgs) Handles messageCopyToolStripButton.Click, formattextCopyAlignToolStripButton.Click
			Me.richTextBox1.Copy()
		End Sub

		#End Region

		#Region "Theme Effects"

		Private Sub OnThemeStyleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles blueToolStripMenuItem.Click, blackToolStripMenuItem.Click, silverToolStripMenuItem.Click
			Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
			SetTheme(item.Text)
		End Sub

		Public Sub SetTheme(ByVal theme As String)
			Select Case theme
				Case "Blue"
					Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
					Me.ColorScheme = ColorSchemeType.Blue
					Me.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
					Me.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
					Me.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
					Me.autoLabel1.ForeColor = Color.FromArgb(21, 66, 139)
					Me.blueToolStripMenuItem.Checked = True
					Me.blackToolStripMenuItem.Checked = False
					Me.silverToolStripMenuItem.Checked = False
					Me.panel1.BackColor = Color.FromArgb(227, 239, 255)
					Me.m_form1.SetTheme(theme)
				Case "Black"
					Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
					Me.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
					Me.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
					Me.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
					Me.ColorScheme = ColorSchemeType.Black
					Me.autoLabel1.ForeColor = Color.White
					Me.blueToolStripMenuItem.Checked = False
					Me.blackToolStripMenuItem.Checked = True
					Me.silverToolStripMenuItem.Checked = False
					Me.panel1.BackColor = Color.FromArgb(191, 198, 206)
					Me.m_form1.SetTheme(theme)
				Case "Silver"
					Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					Me.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
					Me.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
					Me.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
					Me.autoLabel1.ForeColor = Color.Black
					Me.ColorScheme = ColorSchemeType.Silver
					Me.blueToolStripMenuItem.Checked = False
					Me.blackToolStripMenuItem.Checked = False
					Me.silverToolStripMenuItem.Checked = True
					Me.panel1.BackColor = Color.FromArgb(231, 234, 240)
					Me.m_form1.SetTheme(theme)
			End Select
			Refresh()
		End Sub

		#End Region
	End Class
End Namespace