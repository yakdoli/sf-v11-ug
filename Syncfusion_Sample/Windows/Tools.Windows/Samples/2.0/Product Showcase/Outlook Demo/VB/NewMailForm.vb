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
    Partial Class NewMailForm : Inherits RibbonForm
        Private m_form1 As Form1
        Public Sub New(ByVal parentForm As Form1, ByVal theme As String)
            InitializeComponent()
            Me.m_form1 = parentForm
            SetTheme(theme)
        End Sub

        Private Sub OnNewMailFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            For Each o As Object In New FontListBox().Items
                Me.messageFontListComboBox.Items.Add(o)
                Me.fontToolStripComboBox.Items.Add(o)
            Next o
            Me.messageFontListComboBox.SelectedItem = "Calibri"
            Me.fontToolStripComboBox.SelectedItem = "Calibri"
            Me.richTextBox1.SelectionFont = New Font("Calibri", 14)
        End Sub

#Region "TextChange EventHandlers"

        Private Sub OnBoldClick(ByVal sender As Object, ByVal e As EventArgs) Handles boldtoolStripButton3.Click, messageBoldToolStripButton.Click
            Dim boldToolStripBtn As ToolStripButton = CType(IIf(TypeOf sender Is ToolStripButton, sender, Nothing), ToolStripButton)
            If (Not boldToolStripBtn.Checked) Then
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Bold)))
            Else
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Bold)
            End If
        End Sub

        Private Sub OnItalicClick(ByVal sender As Object, ByVal e As EventArgs) Handles italictoolStripButton4.Click, messageItalicToolStripButton.Click
            Dim italicToolStripBtn As ToolStripButton = CType(IIf(TypeOf sender Is ToolStripButton, sender, Nothing), ToolStripButton)
            If (Not italicToolStripBtn.Checked) Then
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Italic)))
            Else
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Italic)
            End If
        End Sub

        Private Sub OnUnderlineClick(ByVal sender As Object, ByVal e As EventArgs) Handles underlinetoolStripButton5.Click, messageUnderlineToolStripButton.Click
            Dim underlineToolStripBtn As ToolStripButton = CType(IIf(TypeOf sender Is ToolStripButton, sender, Nothing), ToolStripButton)
            If (Not underlineToolStripBtn.Checked) Then
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Underline)))
            Else
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Underline)
            End If
        End Sub

        Private Sub OnStrikeThroughClick(ByVal sender As Object, ByVal e As EventArgs) Handles strikethroughtoolStripButton6.Click
            Dim strikeThroughToolStripBtn As ToolStripButton = CType(IIf(TypeOf sender Is ToolStripButton, sender, Nothing), ToolStripButton)
            If (Not strikeThroughToolStripBtn.Checked) Then
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Strikeout)))
            Else
                Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Strikeout)
            End If
        End Sub

        Private Sub OnIndentClick(ByVal sender As Object, ByVal e As EventArgs) Handles rightindenttoolStripButton4.Click, messageIndentToolStripButton.Click
            Me.richTextBox1.SelectionIndent += 20
        End Sub

        Private Sub OnOutdentClick(ByVal sender As Object, ByVal e As EventArgs) Handles leftindenttoolStripButton3.Click, messageOutdentToolStripButton.Click
            If Me.richTextBox1.SelectionIndent > 0 Then
                Me.richTextBox1.SelectionIndent -= 20
            End If
        End Sub

        Private Sub OnFontChange(ByVal sender As Object, ByVal e As EventArgs) Handles fontToolStripComboBox.SelectedIndexChanged, messageFontListComboBox.SelectedIndexChanged
            Dim fontListCombo As ToolStripComboBox = CType(IIf(TypeOf sender Is ToolStripComboBox, sender, Nothing), ToolStripComboBox)
            Me.messageFontListComboBox.SelectedItem = fontListCombo.SelectedItem.ToString()
            Me.fontToolStripComboBox.SelectedItem = fontListCombo.SelectedItem.ToString()
            Me.richTextBox1.SelectionFont = New Font(fontListCombo.SelectedItem.ToString(), Me.richTextBox1.SelectionFont.Size)
        End Sub

        Private Sub OnFontSizeChange(ByVal sender As Object, ByVal e As EventArgs) Handles fontSizeComboBox.SelectedIndexChanged, messageFontSizeComboBox.SelectedIndexChanged
            Dim fontSizeComboBox As ToolStripComboBox = CType(IIf(TypeOf sender Is ToolStripComboBox, sender, Nothing), ToolStripComboBox)
            Me.richTextBox1.SelectionFont = New Font(Me.messageFontListComboBox.SelectedItem.ToString(), Single.Parse(fontSizeComboBox.SelectedItem.ToString()))
        End Sub

#End Region

#Region "Cut,Copy and Paste Event Handlers"

        Private Sub OnPasteClick(ByVal sender As Object, ByVal e As EventArgs) Handles pasteToolStripMenuItem.Click, formattextPasteToolStripButton.Click
            Me.richTextBox1.Paste()
        End Sub

        Private Sub OnCutClick(ByVal sender As Object, ByVal e As EventArgs) Handles formattextCutToolStripButton.Click
            Me.richTextBox1.Cut()
        End Sub

        Private Sub OnCopyClick(ByVal sender As Object, ByVal e As EventArgs) Handles formattextCopyAlignToolStripButton.Click
            Me.richTextBox1.Copy()
        End Sub

#End Region

#Region "Theme Effects"

        Private Sub OnThemeStyleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles blueToolStripMenuItem.Click, blackToolStripMenuItem.Click, silverToolStripMenuItem.Click
            Dim item As ToolStripMenuItem = CType(IIf(TypeOf sender Is ToolStripMenuItem, sender, Nothing), ToolStripMenuItem)
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
                    Me.panel1.BackColor = Color.FromArgb(189, 215, 252)
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



        Private Sub NewMailForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.messageItalicToolStripButton.Image = My.Resources.ItalicHS
            Me.messageUnderlineToolStripButton.Image = My.Resources.text_icon13
            Me.messageCutToolStripButton.Image = My.Resources.cut_icon
            Me.messageCopyToolStripButton.Image = My.Resources.copy_icon
            Me.formatPaintertoolStripButton4.Image = My.Resources.format_painter
            Me.toolStripEx4.Image = My.Resources.text_icon_32_1
            Me.toolStripButton15.Image = My.Resources.text_icon3
            Me.toolStripButton16.Image = My.Resources.text_icon4
            Me.toolStripSplitButton4.Image = My.Resources.bullet_icon1
            Me.toolStripSplitButton5.Image = My.Resources.bullet_icon2
            Me.changeListLevelToolStripMenuItem1.Image = My.Resources.bullet_icon4
            Me.toolStripEx3.Image = My.Resources.paste
            Me.messagePasteToolStripButton.Image = My.Resources.paste
            Me.toolStripButton20.Image = My.Resources.note
            Me.toolStripButton19.Image = My.Resources.TaskHS
            Me.toolStripButton18.Image = My.Resources.distributionlist
            Me.toolStripButton13.Image = My.Resources.business_card
            Me.toolStripButton12.Image = My.Resources.meetingrequest
            Me.toolStripButton11.Image = My.Resources.appointment
            Me.toolStripButton8.Image = My.Resources.NewMessageHS
            Me.closeToolStripButton.Image = My.Resources.close
            Me.propertiesToolStripButton1.Image = My.Resources.properties
            Me.toolStripButton6.Image = My.Resources.folder
            Me.toolStripButton5.Image = My.Resources.folder
            Me.toolStripButton1.Image = My.Resources.folder
            Me.officeSplitButton1.Image = My.Resources.moveto
            Me.deleteToolStripButton.Image = My.Resources.delete
            Me.saveasToolStripButton.Image = My.Resources.saveas
            Me.savetoolStripButton.Image = My.Resources.save
            Me.sendtoolStripButton.Image = My.Resources.send
            Me.newMailMessageToolStripButton1.Image = My.Resources.newmailmessage
            Me.ribbonControlAdv1.MenuButtonImage = My.Resources.syncfusion_logo
            Me.sendButtonAdv.Image = My.Resources.NewMessageHS
            Me.toolStripButton17.Image = My.Resources.text_icon7
            Me.messageBoldToolStripButton.Image = My.Resources.boldhs
            'toolTipInfo8.Header.Image = My.Resources.ItalicHS
            Me.toolStripButton37.Image = My.Resources.attach
            Me.toolStripEx11.Image = My.Resources.attach
            Me.toolStripButton36.Image = My.Resources.check_names
            Me.toolStripButton35.Image = My.Resources.addressbook
            Me.toolStripEx10.Image = My.Resources.addressbook
            Me.messageOutdentToolStripButton.Image = My.Resources.OutdentHS
            Me.messageIndentToolStripButton.Image = My.Resources.IndentHS
            Me.messageRightToolStripButton.Image = My.Resources.right_justity_icon
            Me.messageCenterAlignToolStripButton.Image = My.Resources.center_justity_icon
            Me.messageLeftAlignToolStripButton.Image = My.Resources.left_justity_icon
            Me.toolStripSplitButton7.Image = My.Resources.text_icon9
            Me.toolStripSplitButton6.Image = My.Resources.text_icon10
            ' toolTipInfo9.Header.Image = My.Resources.text_icon13
            'toolTipInfo7.Header.Image = My.Resources.boldhs
            Me.toolStripMenuItem2.Image = My.Resources.pastespecial
            Me.toolStripMenuItem1.Image = My.Resources.pasteicon
            Me.changeListLevelToolStripMenuItem.Image = My.Resources.bullet_icon4
            Me.moreColorsToolStripMenuItem1.Image = My.Resources.general_icon6
            Me.moreColorsToolStripMenuItem2.Image = My.Resources.general_icon6
            Me.toolStripDropDownButton25.Image = My.Resources.spell_check_icon
            Me.toolStripEx12.Image = My.Resources.spell_check_icon
            Me.toolStripDropDownButton9.Image = My.Resources.signature
            Me.toolStripButton39.Image = My.Resources.calender
            Me.toolStripDropDownButton8.Image = My.Resources.business_card
            Me.toolStripButton38.Image = My.Resources.attach_item
            Me.toolStripMenuItem21.Image = My.Resources.spell_check_icon_16
            Me.toolStripMenuItem22.Image = My.Resources.research_icon_16
            Me.toolStripMenuItem23.Image = My.Resources.thesau_icon_16
            Me.toolStripMenuItem24.Image = My.Resources.translate_icon_16
            Me.toolStripMenuItem26.Image = My.Resources.set_lang_icon_16
            Me.toolStripMenuItem27.Image = My.Resources.word_count_icon_16
            Me.toolStripEx13.Image = My.Resources.attach
            Me.toolStripButton43.Image = My.Resources.attach
            Me.toolStripButton44.Image = My.Resources.attach_item
            Me.toolStripDropDownButton12.Image = My.Resources.business_card
            Me.toolStripButton45.Image = My.Resources.calender
            Me.toolStripDropDownButton13.Image = My.Resources.signature
            Me.toolStripEx14.Image = My.Resources.TableHS
            Me.toolStripButton46.Image = My.Resources.table_icon
            Me.toolStripEx15.Image = My.Resources.picture_icon
            Me.toolStripButton47.Image = My.Resources.picture_icon
            Me.toolStripButton48.Image = My.Resources.clipart_icon
            Me.toolStripDropDownButton14.Image = My.Resources.shapes_icon
            Me.toolStripButton49.Image = My.Resources.smartart_icon
            Me.toolStripButton50.Image = My.Resources.chart_icon
            Me.toolStripEx16.Image = My.Resources.hyperlink_icon1_16
            Me.toolStripDropDownButton27.Image = My.Resources.quickpart_icon
            Me.toolStripButton52.Image = My.Resources.bookmark_icon_16
            Me.toolStripButton51.Image = My.Resources.hyperlink_icon1_16
            Me.toolStripEx17.Image = My.Resources.text_icon_32_1
            Me.toolStripDropDownButton26.Image = My.Resources.text_icon_32_1
            Me.toolStripDropDownButton28.Image = My.Resources.wordart_icon
            Me.toolStripButton58.Image = My.Resources.date_time_icon_16
            Me.toolStripButton59.Image = My.Resources.object_icon_16
            Me.toolStripEx5.Image = My.Resources.themes_icon
            Me.themesToolStripDropDownButton.Image = My.Resources.themes_icon
            Me.toolStripSplitButton8.Image = My.Resources.color_icon_16
            Me.toolStripButton14.Image = My.Resources.format_painter
            Me.formattextCopyAlignToolStripButton.Image = My.Resources.copy_icon
            Me.formattextCutToolStripButton.Image = My.Resources.cut_icon
            Me.formattextPasteToolStripButton.Image = My.Resources.paste
            Me.formatClipboardToolStripEx.Image = My.Resources.paste
            Me.toolStripSplitButton11.Image = My.Resources.save_sentitem
            Me.toolStripDropDownButton6.Image = My.Resources.page_color
            Me.toolStripSplitButton10.Image = My.Resources.effect_icon_16
            Me.moreColorsToolStripMenuItem3.Image = My.Resources.general_icon6
            Me.toolStripButton26.Image = My.Resources.show_bcc
            Me.toolStripButton27.Image = My.Resources.show_from
            Me.toolStripDropDownButton7.Image = My.Resources.vote
            Me.toolStripButton33.Image = My.Resources.delay_delivery
            Me.toolStripButton34.Image = My.Resources.direct_repliesto
            Me.pasteToolStripMenuItem.Image = My.Resources.pasteicon
            Me.pasteSpecialToolStripMenuItem.Image = My.Resources.pastespecial
            Me.changecaseToolStripDropDownButton2.Image = My.Resources.text_icon17
            Me.superscripttoolStripButton8.Image = My.Resources.text_icon16
            Me.subscripttoolStripButton7.Image = My.Resources.text_icon15
            Me.strikethroughtoolStripButton6.Image = My.Resources.text_icon14
            Me.underlinetoolStripButton5.Image = My.Resources.text_icon13
            Me.italictoolStripButton4.Image = My.Resources.ItalicHS
            Me.boldtoolStripButton3.Image = My.Resources.boldhs
            Me.toolStripButton2.Image = My.Resources.text_icon7
            Me.shrinktoolStripButton3.Image = My.Resources.text_icon4
            Me.growtoolStripButton2.Image = My.Resources.text_icon3
            Me.numberBulletToolStripSplitButton.Image = My.Resources.bullet_icon3
            Me.numericBulletToolStripSplitButton.Image = My.Resources.bullet_icon2

            Me.bulletToolStripSplitButton2.Image = My.Resources.bullet_icon1
            Me.formatColorToolStripDropDownButton3.Image = My.Resources.text_icon9
            Me.textHighlightColorToolStripDropDownButton2.Image = My.Resources.text_icon10
            Me.changeListLevelToolStripMenuItem2.Image = My.Resources.bullet_icon4
            Me.changeListLevelToolStripMenuItem3.Image = My.Resources.bullet_icon4
            Me.changeListLevelToolStripMenuItem4.Image = My.Resources.bullet_icon4

            Me.toolStripSplitButton3.Image = My.Resources.border_icon1
            Me.toolStripSplitButton2.Image = My.Resources.painbucket_icon1
            Me.toolStripSplitButton1.Image = My.Resources.line_spacing_icon
            Me.formattextJustifyAlignToolStripButton.Image = My.Resources.justity_icon
            Me.formattextRightAlignToolStripButton.Image = My.Resources.right_justity_icon
            Me.formattextCenterAlignToolStripButton.Image = My.Resources.center_justity_icon
            Me.formattextLeftAlignToolStripButton.Image = My.Resources.left_justity_icon
            Me.toolStripButton4.Image = My.Resources.general_icon1
            Me.toolStripButton3.Image = My.Resources.SortUpHS
            Me.rightindenttoolStripButton4.Image = My.Resources.OutdentHS
            Me.leftindenttoolStripButton3.Image = My.Resources.IndentHS
            Me.bottomBorderToolStripMenuItem.Image = My.Resources.border_icon1
            Me.rightBorderToolStripMenuItem.Image = My.Resources.border_icon4
            Me.leftBorderToolStripMenuItem.Image = My.Resources.border_icon3
            Me.topBorderToolStripMenuItem.Image = My.Resources.border_icon2
            Me.noBorderToolStripMenuItem.Image = My.Resources.border_icon5
            Me.allBordersToolStripMenuItem.Image = My.Resources.border_icon6
            Me.insideBorderToolStripMenuItem.Image = My.Resources.border_icon8
            Me.outsideBorderToolStripMenuItem.Image = My.Resources.border_icon7
            Me.insideHorizontalBorderToolStripMenuItem.Image = My.Resources.border_icon9
            Me.diagonalDownBorderToolStripMenuItem.Image = My.Resources.border_icon11
            Me.diagonalUpBorderToolStripMenuItem.Image = My.Resources.border_icon12
            Me.toolStripButton9.Image = My.Resources.zoom_icon
            Me.toolStripEx2.Image = My.Resources.zoom_icon
            Me.toolStripDropDownButton2.Image = My.Resources.text_icon_32_1
            Me.toolStripDropDownButton3.Image = My.Resources.text_icon_32_2
            Me.drawTableToolStripMenuItem.Image = My.Resources.border_icon14
            Me.viewGridLinesToolStripMenuItem.Image = My.Resources.border_icon15
            Me.clearFormattingToolStripMenuItem.Image = My.Resources.text_icon7
            Me.toolStripSplitButton12.Image = My.Resources.text_icon_32_2
            Me.toolStripDropDownButton4.Image = My.Resources.selectall

            Me.findToolStripDropDownButton.Image = My.Resources.FindHS
            Me.toolStripEx1.Image = My.Resources.FindHS
            Me.findToolStripMenuItem.Image = My.Resources.FindHS
            Me.gotoToolStripMenuItem.Image = My.Resources.gotoicon
            Me.selectAllToolStripMenuItem.Image = My.Resources.selectall
            Me.selectObjectsToolStripMenuItem.Image = My.Resources.selectall

            Me.fontToolStripEx.Image = My.Resources.text_icon_32_2
            Me.toolStripSplitButton9.Image = My.Resources.font_icon_16
            Me.insideVerticalBorderToolStripMenuItem.Image = My.Resources.border_icon10
        End Sub
    End Class
End Namespace