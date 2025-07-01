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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv
            Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.clipboardToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripBtnPaste = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownBtnPaste = New System.Windows.Forms.ToolStripDropDownButton
            Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteAsHyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripBtnCut = New System.Windows.Forms.ToolStripButton
            Me.toolStripBtnCopy = New System.Windows.Forms.ToolStripButton
            Me.toolStripBtnPaint = New System.Windows.Forms.ToolStripButton
            Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx
            Me.StatusStripLabel1 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ribbonControlAdv1.SuspendLayout()
            Me.toolStripTabItem1.Panel.SuspendLayout()
            Me.clipboardToolStripExt.SuspendLayout()
            Me.toolStripEx1.SuspendLayout()
            Me.statusStripEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ribbonControlAdv1
            '

            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton2))
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3))
            Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton4))
            Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
            Me.ribbonControlAdv1.MenuButtonImage = CType(resources.GetObject("ribbonControlAdv1.MenuButtonImage"), System.Drawing.Image)
            Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
            '
            'ribbonControlAdv1.OfficeMenu
            '
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.toolStripSeparator1, Me.toolStripButton5})
            Me.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4})
            Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
            Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(197, 162)
            Me.ribbonControlAdv1.Size = New System.Drawing.Size(549, 159)
            Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
            Me.ribbonControlAdv1.TabIndex = 0
            Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
            '
            'toolStripTabItem1
            '
            Me.toolStripTabItem1.Name = "toolStripTabItem1"
            Me.toolStripTabItem1.Padding = New System.Windows.Forms.Padding(15, 1, 3, 1)
            '
            'ribbonControlAdv1.RibbonPanel1
            '
            Me.toolStripTabItem1.Panel.Controls.Add(Me.clipboardToolStripExt)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx1)
            Me.toolStripTabItem1.Panel.Name = "RibbonPanel1"
            Me.toolStripTabItem1.Panel.ScrollPosition = 0
            Me.toolStripTabItem1.Panel.TabIndex = 2
            Me.toolStripTabItem1.Panel.Text = "Home"
            Me.toolStripTabItem1.Size = New System.Drawing.Size(56, 19)
            Me.toolStripTabItem1.Text = "Home"
            '
            'clipboardToolStripExt
            '
            Me.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard"
            Me.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.clipboardToolStripExt.Image = CType(resources.GetObject("clipboardToolStripExt.Image"), System.Drawing.Image)
            Me.clipboardToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem15, Me.toolStripPanelItem1})
            Me.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
            Me.clipboardToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.clipboardToolStripExt.Name = "clipboardToolStripExt"
            Me.clipboardToolStripExt.Size = New System.Drawing.Size(163, 98)
            Me.clipboardToolStripExt.TabIndex = 1
            Me.clipboardToolStripExt.Text = "Clipboard"
            '
            'toolStripPanelItem15
            '
            Me.toolStripPanelItem15.CausesValidation = False
            Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBtnPaste, Me.toolStripDropDownBtnPaste})
            Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Size = New System.Drawing.Size(42, 80)
            Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Transparent = True
            '
            'toolStripBtnPaste
            '
            Me.toolStripBtnPaste.AutoToolTip = False
            Me.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripBtnPaste.Image = CType(resources.GetObject("toolStripBtnPaste.Image"), System.Drawing.Image)
            Me.toolStripBtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnPaste.Name = "toolStripBtnPaste"
            Me.toolStripBtnPaste.Size = New System.Drawing.Size(36, 36)
            Me.toolStripBtnPaste.Text = "toolStripButton39"
            '
            'toolStripDropDownBtnPaste
            '
            Me.toolStripDropDownBtnPaste.AutoToolTip = False
            Me.toolStripDropDownBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownBtnPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem, Me.pasteAsHyperlinkToolStripMenuItem})
            Me.toolStripDropDownBtnPaste.Image = CType(resources.GetObject("toolStripDropDownBtnPaste.Image"), System.Drawing.Image)
            Me.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste"
            Me.SetShortcut(Me.toolStripDropDownBtnPaste, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys))
            Me.toolStripDropDownBtnPaste.ShowDropDownArrow = False
            Me.toolStripDropDownBtnPaste.Size = New System.Drawing.Size(38, 17)
            Me.toolStripDropDownBtnPaste.Text = "Paste"
            '
            'pasteToolStripMenuItem
            '
            Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
            Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteToolStripMenuItem.Text = "&Paste"
            '
            'pasteSpecialToolStripMenuItem
            '
            Me.pasteSpecialToolStripMenuItem.Image = CType(resources.GetObject("pasteSpecialToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
            Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteSpecialToolStripMenuItem.Text = "Paste &Special..."
            '
            'pasteAsHyperlinkToolStripMenuItem
            '
            Me.pasteAsHyperlinkToolStripMenuItem.Enabled = False
            Me.pasteAsHyperlinkToolStripMenuItem.Image = CType(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem"
            Me.pasteAsHyperlinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteAsHyperlinkToolStripMenuItem.Text = "Paste as &Hyperlink"
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBtnCut, Me.toolStripBtnCopy, Me.toolStripBtnPaint})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(102, 80)
            Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripBtnCut
            '
            Me.toolStripBtnCut.AutoToolTip = False
            Me.toolStripBtnCut.Image = CType(resources.GetObject("toolStripBtnCut.Image"), System.Drawing.Image)
            Me.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnCut.Name = "toolStripBtnCut"
            Me.SetShortcut(Me.toolStripBtnCut, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys))
            Me.toolStripBtnCut.Size = New System.Drawing.Size(44, 20)
            Me.toolStripBtnCut.Text = "Cut"
            '
            'toolStripBtnCopy
            '
            Me.toolStripBtnCopy.AutoToolTip = False
            Me.toolStripBtnCopy.Image = CType(resources.GetObject("toolStripBtnCopy.Image"), System.Drawing.Image)
            Me.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnCopy.Name = "toolStripBtnCopy"
            Me.SetShortcut(Me.toolStripBtnCopy, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys))
            Me.toolStripBtnCopy.Size = New System.Drawing.Size(52, 20)
            Me.toolStripBtnCopy.Text = "Copy"
            '
            'toolStripBtnPaint
            '
            Me.toolStripBtnPaint.AutoToolTip = False
            Me.toolStripBtnPaint.Image = CType(resources.GetObject("toolStripBtnPaint.Image"), System.Drawing.Image)
            Me.toolStripBtnPaint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnPaint.Name = "toolStripBtnPaint"
            Me.SetShortcut(Me.toolStripBtnPaint, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys))
            Me.toolStripBtnPaint.Size = New System.Drawing.Size(98, 20)
            Me.toolStripBtnPaint.Text = "Format Painter"
            '
            'toolStripEx1
            '
            Me.toolStripEx1.AutoSize = False
            Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx1.Image = Nothing
            Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1})
            Me.toolStripEx1.Location = New System.Drawing.Point(163, 1)
            Me.toolStripEx1.Name = "toolStripEx1"
            Me.toolStripEx1.Size = New System.Drawing.Size(73, 98)
            Me.toolStripEx1.TabIndex = 2
            Me.toolStripEx1.Text = "Insert"
            '
            'toolStripButton1
            '
            Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
            Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
            Me.toolStripButton1.Size = New System.Drawing.Size(66, 77)
            Me.toolStripButton1.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
            Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton2
            '
            Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
            Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton2.Size = New System.Drawing.Size(69, 36)
            Me.toolStripButton2.Text = "New"
            '
            'toolStripButton3
            '
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton3.Size = New System.Drawing.Size(69, 36)
            Me.toolStripButton3.Text = "Open"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
            Me.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton4.Size = New System.Drawing.Size(69, 36)
            Me.toolStripButton4.Text = "Save"
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(114, 13)
            Me.toolStripLabel1.Text = "Recent Documents"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(98, 2)
            '
            'toolStripButton5
            '
            Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(114, 17)
            Me.toolStripButton5.Text = "Document1.doc"
            Me.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'statusStripEx1
            '
            Me.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom
            Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripLabel1})
            Me.statusStripEx1.Location = New System.Drawing.Point(6, 492)
            Me.statusStripEx1.Name = "statusStripEx1"
            Me.statusStripEx1.Size = New System.Drawing.Size(539, 22)
            Me.statusStripEx1.TabIndex = 2
            Me.statusStripEx1.Text = "statusStripEx1"
            '
            'StatusStripLabel1
            '
            Me.StatusStripLabel1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.StatusStripLabel1.Name = "StatusStripLabel1"
            Me.StatusStripLabel1.Size = New System.Drawing.Size(241, 13)
            Me.StatusStripLabel1.Text = "Click on 'New File' to create a child window"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.HelpButton=True 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(551, 520)
            Me.Controls.Add(Me.statusStripEx1)
            Me.Controls.Add(Me.ribbonControlAdv1)
            Me.IsMdiContainer = True
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Ribbon Merging Demo"
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ribbonControlAdv1.ResumeLayout(False)
            Me.ribbonControlAdv1.PerformLayout()
            Me.toolStripTabItem1.Panel.ResumeLayout(False)
            Me.toolStripTabItem1.Panel.PerformLayout()
            Me.clipboardToolStripExt.ResumeLayout(False)
            Me.clipboardToolStripExt.PerformLayout()
            Me.toolStripEx1.ResumeLayout(False)
            Me.toolStripEx1.PerformLayout()
            Me.statusStripEx1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
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
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
        Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
        Friend WithEvents StatusStripLabel1 As Syncfusion.Windows.Forms.Tools.StatusStripLabel
    End Class
End Namespace

