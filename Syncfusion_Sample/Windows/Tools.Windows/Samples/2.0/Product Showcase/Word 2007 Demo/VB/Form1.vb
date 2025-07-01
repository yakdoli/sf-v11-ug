#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
'
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
Imports Syncfusion.Windows.Forms

Imports Syncfusion.Drawing
Imports System.IO

Namespace Word2007Demo_2005
	' RibbonForm class is derived from a System.Windows.Forms to have Office 2007 look and feel.
	Partial Public Class Form1 : Inherits RibbonForm
		Private Shadows font As Font
		Private pt As Point
		Private progressBarAdv As ProgressBarAdv

		Public Sub New()
            InitializeComponent()
            Me.SplashControl1.ShowDialogSplash(Me)
            Me.ribbonControlAdv1.Header.AddQuickItem(Me.saveToolstripBtn)
            Me.ribbonControlAdv1.Header.AddQuickItem(Me.undoToolStripBtn)
            Me.ribbonControlAdv1.Header.AddQuickItem(Me.redoToolStripBtn)
			progressBarAdv = New ProgressBarAdv()
			progressBarAdv.BackColor = System.Drawing.SystemColors.Control
			progressBarAdv.BackGradientEndColor = System.Drawing.Color.White
			progressBarAdv.BackGradientStartColor = System.Drawing.Color.LightGray
			progressBarAdv.BackMultipleColors = New System.Drawing.Color() {}
			progressBarAdv.BackSegments = False
			progressBarAdv.BackTubeEndColor = System.Drawing.Color.White
			progressBarAdv.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarAdv.BorderColor = System.Drawing.Color.Black
			progressBarAdv.BorderStyle = System.Windows.Forms.BorderStyle.None
			progressBarAdv.CustomWaitingRender = False
			progressBarAdv.FontColor = System.Drawing.Color.White
			progressBarAdv.ForegroundImage = Nothing
			progressBarAdv.ForeSegments = False
			progressBarAdv.GradientEndColor = System.Drawing.Color.Lime
			progressBarAdv.GradientStartColor = System.Drawing.Color.Red
			progressBarAdv.Location = New System.Drawing.Point(2, 3)
			progressBarAdv.MultipleColors = New System.Drawing.Color() {}
			progressBarAdv.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			progressBarAdv.SegmentWidth = 12
			progressBarAdv.Size = New System.Drawing.Size(113, 16)
			progressBarAdv.TabIndex = 1
			progressBarAdv.TextVisible = False
			progressBarAdv.ThemesEnabled = True
			progressBarAdv.TubeEndColor = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(231)))), (CInt((CByte(122)))))
			progressBarAdv.TubeStartColor = System.Drawing.Color.FromArgb((CInt((CByte(107)))), (CInt((CByte(155)))), (CInt((CByte(35)))))
			progressBarAdv.WaitingGradientWidth = 400
			progressBarAdv.Text = "Progress"
			progressBarAdv.Value = 0
			progressTimer.Start()
			AddHandler progressTimer.Tick, AddressOf progressTimer_Tick

			'To host any .Net control into ToolStripEx, StatusStrip,
			' User can make use of ToolStripControlHost class
			' and host the control inside it and add the host
			' to item collection.
			Dim host As ToolStripControlHost = New ToolStripControlHost(progressBarAdv)
            Me.statusStripEx1.Items.Add(host)
            AddHandler Me.Load, AddressOf Form1_Load
            AddHandler richTextBox1.MouseUp, AddressOf richTextBox1_MouseUp
            AddHandler richTextBox1.TextChanged, AddressOf richTextBox1_TextChanged
            AddHandler growfontToolStripBtn.Click, AddressOf growfontToolStripBtn_Click
            AddHandler shrinkfontToolStripBtn.Click, AddressOf shrinkfontToolStripBtn_Click
            AddHandler boldToolstripBtn.Click, AddressOf boldToolstripBtn_Click
            AddHandler italicToolStripBtn.Click, AddressOf italicToolStripBtn_Click
            AddHandler underlineToolStripSplitBtn.Click, AddressOf underlineToolStripSplitBtn_Click
            AddHandler undoToolStripBtn.Click, AddressOf undoToolStripBtn_Click
            AddHandler strikethroToolStripBtn.Click, AddressOf strikethroToolStripBtn_Click
            AddHandler clearToolstripBtn.Click, AddressOf cleartoolStripBtn_Click
            AddHandler toolStripBtnCopy.Click, AddressOf toolStripBtnCopy_Click
            AddHandler toolStripBtnCut.Click, AddressOf toolStripBtnCut_Click
            AddHandler toolStripBtnPaste.Click, AddressOf toolStripBtnPaste_Click
            AddHandler deindentToolStripBtn.Click, AddressOf deindentToolStripBtn_Click
            AddHandler inindentToolStripBtn.Click, AddressOf inindentToolStripBtn_Click
            AddHandler selectAllToolStripMenuItem.Click, AddressOf selectAllToolStripMenuItem1_Click
            AddHandler redoToolStripBtn.Click, AddressOf redoToolStripBtn_Click
            AddHandler blueToolStripMenuItem.Click, AddressOf blueToolStripMenuItem_Click
            AddHandler blackToolStripMenuItem.Click, AddressOf blackToolStripMenuItem_Click
            AddHandler silverToolStripMenuItem.Click, AddressOf silverToolStripMenuItem_Click

        End Sub

#Region "FormLoad"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.font = Me.richTextBox1.SelectionFont

			For Each item As Object In Me.fontListBox1.Items
				Me.toolStripFontfaceComboBox.Items.Add(item)
				Me.FontFaceCombo.Items.Add(item)
			Next item

			Me.toolStripFontfaceComboBox.SelectedItem = "Arial"
			Me.toolStripFontSizeComboBox.SelectedIndex = 0
			Me.FontFaceCombo.SelectedItem = "Arial"
			Me.FontSize.SelectedIndex = 0

			Me.richTextBox1.Text = ""
			Dim path As String = Application.StartupPath.ToString() & "..\..\..\Introduction.rtf"
			If File.Exists(path) Then
				Me.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText)
            End If
            statusStripLabel1.Text = statusStripLabel1.Text & ": " & statusStripLabel1.StatusString
            AddHandler statusStripEx1.ContextMenuStrip.Opening, AddressOf ContextMenuStrip_Opening

            Me.MiniToolBar.AssociatedControl = Me.richTextBox1

            AddHandler EditorContextMenuStripEx.Opened, AddressOf EditorContextMenuStripEx_Opened

            'Add tooltip
            Me.toolStripGallery2.Items(0).ToolTipText = "Heading 1"
            Me.toolStripGallery2.Items(1).ToolTipText = "Heading 2"
            Me.toolStripGallery2.Items(2).ToolTipText = "No Spacing"
            Me.toolStripGallery2.Items(3).ToolTipText = "Intense Emphasis"
            Me.toolStripGallery2.Items(4).ToolTipText = "Strong"
            Me.toolStripGallery2.Items(5).ToolTipText = "Intense Reference"
            Me.toolStripGallery2.Items(6).ToolTipText = "Title"
            Me.toolStripGallery2.Items(7).ToolTipText = "Strong"
            Me.toolStripGallery2.Items(8).ToolTipText = "BookTitle"

		End Sub

#End Region
        Private Sub ContextMenuStrip_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
            statusStripEx1.ContextMenuStrip.Items(2).Text = "Page"
        End Sub

        Sub EditorContextMenuStripEx_Opened(ByVal sender As Object, ByVal e As EventArgs)
            Me.MiniToolBar.Visible = True
        End Sub

#Region "Editor events"

		Private Sub growfontToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.toolStripFontSizeComboBox.SelectedItem.ToString() <> "72" Then
				Me.toolStripFontSizeComboBox.SelectedIndex += 1
			End If
		End Sub

		Private Sub shrinkfontToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.toolStripFontSizeComboBox.SelectedItem.ToString() <> "8" Then
				Me.toolStripFontSizeComboBox.SelectedIndex -= 1
			End If
		End Sub

		Private Sub boldToolstripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.boldToolstripBtn.Checked = Not Me.boldToolstripBtn.Checked
            If Not Me.richTextBox1.SelectionFont Is Nothing Then
                If (Not Me.boldToolstripBtn.Checked) Then
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Bold)))
                Else
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Bold)
                End If
            End If
        End Sub

		Private Sub italicToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.italicToolStripBtn.Checked = Not Me.italicToolStripBtn.Checked
            If Not Me.richTextBox1.SelectionFont Is Nothing Then
                If (Not Me.italicToolStripBtn.Checked) Then
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Italic)))
                Else
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, Me.richTextBox1.SelectionFont.Style Or FontStyle.Italic)
                End If
            End If
        End Sub

        Private Sub underlineToolStripSplitBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.richTextBox1.SelectionFont Is Nothing Then
                If richTextBox1.SelectionFont.Underline Then
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Underline)))
                Else
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Underline)
                End If
            End If
        End Sub

		Private Sub strikethroToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.strikethroToolStripBtn.Checked = Not Me.strikethroToolStripBtn.Checked
            If Not Me.richTextBox1.SelectionFont Is Nothing Then
                If (Not Me.strikethroToolStripBtn.Checked) Then
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style And Not (richTextBox1.SelectionFont.Style And FontStyle.Strikeout)))
                Else
                    Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style Or FontStyle.Strikeout)
                End If
            End If
        End Sub

		Private Sub toolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			'Me.richTextBox1.SelectionFont = New Font(Me.toolStripFontfaceComboBox.SelectedItem.ToString(), Me.richTextBox1.SelectionFont.Size)
		End Sub

		Private Sub toolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			'Me.richTextBox1.SelectionFont = New Font(Me.richTextBox1.SelectionFont.Name, Single.Parse(Me.toolStripFontSizeComboBox.SelectedItem.ToString()))
		End Sub

		Private Sub cleartoolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.richTextBox1.SelectionFont = font
			Me.richTextBox1.Font = font
		End Sub

		Private Sub toolStripBtnCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.richTextBox1.SelectedText Is Nothing Then
				Me.richTextBox1.Copy()
			End If
		End Sub

		Private Sub toolStripBtnCut_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.richTextBox1.SelectedText Is Nothing Then
				Me.richTextBox1.Cut()
			End If
		End Sub

		Private Sub toolStripBtnPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.richTextBox1.Paste()
		End Sub

		Private Sub deindentToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.richTextBox1.SelectionIndent > 0 Then
				Me.richTextBox1.SelectionIndent = Me.richTextBox1.SelectionIndent - 20
			End If
		End Sub

		Private Sub inindentToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.richTextBox1.SelectionIndent = Me.richTextBox1.SelectionIndent + 20
		End Sub

		Private Sub selectAllToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			richTextBox1.SelectAll()
		End Sub

		Private Sub undoToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.richTextBox1.Undo()
		End Sub

		Private Sub redoToolStripBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.richTextBox1.Redo()
		End Sub

		Private Sub richTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.undoToolStripBtn.Enabled = Me.richTextBox1.CanUndo
			Me.redoToolStripBtn.Enabled = Me.richTextBox1.CanRedo
		End Sub

#End Region

#Region "SwitchThemes"

		Private Sub ColorSchemeItemCheck()
			Me.blueToolStripMenuItem.Checked = False
			Me.silverToolStripMenuItem.Checked = False
			Me.blackToolStripMenuItem.Checked = False
		End Sub

		' Blue Theme
		Private Sub blueToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ColorScheme = ColorSchemeType.Blue
			Me.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Blue

			ColorSchemeItemCheck()
			Me.blueToolStripMenuItem.Checked = True

			Me.gradientPanel1.BackgroundColor = New BrushInfo(GradientStyle.PathEllipse, Color.RoyalBlue, Color.FromArgb(194, 217, 240))
		End Sub

		' Silver Theme
		Private Sub silverToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ColorScheme = ColorSchemeType.Silver
			Me.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Silver

			ColorSchemeItemCheck()
			Me.silverToolStripMenuItem.Checked = True

			Me.gradientPanel1.BackgroundColor = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(160, 164, 171), Color.FromArgb(204, 207, 216))
		End Sub

		' Black theme
		Private Sub blackToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ColorScheme = ColorSchemeType.Black
			Me.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Black
			ColorSchemeItemCheck()
			Me.blackToolStripMenuItem.Checked = True

			Me.gradientPanel1.BackgroundColor = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(57, 57, 57), Color.FromArgb(146, 148, 150))
		End Sub

#End Region

		Private Sub richTextBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If Me.richTextBox1.SelectedText <> String.Empty AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
                ' MiniToolbar will be shown above the mouse cursor
                ' when text in RTE is selected
                pt = New Point(e.X, e.Y - 70)

                ' Use show method to display the miniToolBar.
                Me.MiniToolBar.Show(Me.richTextBox1, pt)
                ' Hiding the 'View' tabgroup
                Me.ribbonControlAdv1.TabGroups(1).Visible = True
            Else
                Me.ribbonControlAdv1.TabGroups(1).Visible = False
            End If
		End Sub

		'////////////////////////////////////////////////
		' To trigger click event for the gallery items //
		'////////////////////////////////////////////////
		Private Sub toolStripGallery2_GalleryItemClicked(ByVal sender As Object, ByVal args As ToolStripGalleryItemEventArgs)

		End Sub

		'////////////////////////////////////////////////////////////////
		' Application will be closed on double clicking the menu button//
		'///////////////////////////////////////////////////////////////
		Private Sub ribbonControlAdv1_MenuButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub progressTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.progressBarAdv.Value += 1
			If progressBarAdv.Value >= 100 Then
				progressTimer.Stop()
				progressBarAdv.Value = 0
				progressTimer.Start()
			End If
		End Sub

		Private Sub exitBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Application.Exit()
		End Sub

	End Class
End Namespace