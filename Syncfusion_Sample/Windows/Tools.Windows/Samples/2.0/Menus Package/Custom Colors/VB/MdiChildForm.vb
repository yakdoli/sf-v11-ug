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


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace Tutorial
	''' <summary>
	''' Summary description for MdiChildForm.
	''' </summary>
	Public Class MdiChildForm : Inherits System.Windows.Forms.Form
		Private childFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
		Private mainMenuBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private standardBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private largeImageList As System.Windows.Forms.ImageList
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private popupMenu1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private editDropDownItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private popupMenu2 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private popupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

            Me.barItem4.Enabled = False
            Me.barItem5.Enabled = False
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiChildForm))
            Me.childFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
            Me.mainMenuBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "MainMenu")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.editDropDownItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.standardBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "Standard")
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.popupMenu2 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
            Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'childFrameBarManager1
            '
            Me.childFrameBarManager1.BarPositionInfo = CType(resources.GetObject("childFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.childFrameBarManager1.Bars.Add(Me.mainMenuBar)
            Me.childFrameBarManager1.Bars.Add(Me.standardBar)
            Me.childFrameBarManager1.Categories.Add("Popups")
            Me.childFrameBarManager1.Categories.Add("File")
            Me.childFrameBarManager1.Categories.Add("Edit")
            Me.childFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.childFrameBarManager1.Form = Me
            Me.childFrameBarManager1.ImageList = Me.imageList1
            Me.childFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem2, Me.parentBarItem1, Me.barItem3, Me.barItem4, Me.editDropDownItem, Me.barItem5, Me.barItem6, Me.barItem1})
            Me.childFrameBarManager1.LargeImageList = Me.largeImageList
            Me.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.[Default]
            '
            'mainMenuBar
            '
            Me.mainMenuBar.BarName = "MainMenu"
            Me.mainMenuBar.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.mainMenuBar.Caption = "MainMenu"
            Me.mainMenuBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.editDropDownItem})
            Me.mainMenuBar.Manager = Me.childFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1})
            Me.parentBarItem1.Text = "&File"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 1
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "&Save"
            Me.barItem1.ImageIndex = 6
            Me.barItem1.MergeOrder = 2
            Me.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.barItem1.Text = "&Save"
            '
            'editDropDownItem
            '
            Me.editDropDownItem.CategoryIndex = 0
            Me.editDropDownItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.editDropDownItem.ID = "&Edit"
            Me.editDropDownItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.barItem6})
            Me.editDropDownItem.SeparatorIndices.AddRange(New Integer() {2})
            Me.editDropDownItem.Text = "&Edit"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 2
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "&Undo"
            Me.barItem2.ImageIndex = 4
            Me.barItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
            Me.barItem2.Text = "&Undo"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 2
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "&Redo"
            Me.barItem3.ImageIndex = 5
            Me.barItem3.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlY
            Me.barItem3.Text = "&Redo"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 2
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "Cu&t"
            Me.barItem4.ImageIndex = 1
            Me.barItem4.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.barItem4.Text = "Cu&t"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 2
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "&Copy"
            Me.barItem5.ImageIndex = 0
            Me.barItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlC
            Me.barItem5.Text = "&Copy"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 2
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "&Paste"
            Me.barItem6.ImageIndex = 2
            Me.barItem6.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlV
            Me.barItem6.Text = "&Paste"
            '
            'standardBar
            '
            Me.standardBar.BarName = "Standard"
            Me.standardBar.Caption = "Standard"
            Me.standardBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1})
            Me.standardBar.Manager = Me.childFrameBarManager1
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
            '
            'largeImageList
            '
            Me.largeImageList.ImageStream = CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.largeImageList.Images.SetKeyName(0, "")
            Me.largeImageList.Images.SetKeyName(1, "")
            Me.largeImageList.Images.SetKeyName(2, "")
            Me.largeImageList.Images.SetKeyName(3, "")
            Me.largeImageList.Images.SetKeyName(4, "")
            Me.largeImageList.Images.SetKeyName(5, "")
            Me.largeImageList.Images.SetKeyName(6, "")
            '
            'richTextBox1
            '
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Font = New System.Drawing.Font("Calibri", 12.0!)
            Me.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(456, 285)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = "MDI Child"
            Me.popupMenusManager1.SetXPContextMenu(Me.richTextBox1, Me.popupMenu1)
            '
            'popupMenu1
            '
            Me.popupMenu1.ParentBarItem = Me.editDropDownItem
            '
            'popupMenu2
            '
            Me.popupMenu2.ParentBarItem = Me.parentBarItem2
            '
            'parentBarItem2
            '
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem9, Me.barItem7, Me.barItem8})
            '
            'barItem9
            '
            Me.barItem9.ID = "Cut"
            Me.barItem9.ImageIndex = 1
            Me.barItem9.ImageList = Me.imageList1
            Me.barItem9.LargeImageList = Me.largeImageList
            Me.barItem9.Text = "Cut"
            '
            'barItem7
            '
            Me.barItem7.ID = "Copy"
            Me.barItem7.ImageIndex = 0
            Me.barItem7.ImageList = Me.imageList1
            Me.barItem7.LargeImageList = Me.largeImageList
            Me.barItem7.Text = "Copy"
            '
            'barItem8
            '
            Me.barItem8.ID = "Paste"
            Me.barItem8.ImageIndex = 2
            Me.barItem8.ImageList = Me.imageList1
            Me.barItem8.LargeImageList = Me.largeImageList
            Me.barItem8.Text = "Paste"
            '
            'xpToolBar1
            '
            Me.xpToolBar1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(234, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(234, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(234, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(247, Byte), Integer))})
            '
            '
            '
            Me.xpToolBar1.Bar.BarName = ""
            Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.barItem6})
            Me.xpToolBar1.Bar.Manager = Nothing
            Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.xpToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.xpToolBar1.Location = New System.Drawing.Point(0, 285)
            Me.xpToolBar1.Name = "xpToolBar1"
            Me.xpToolBar1.Size = New System.Drawing.Size(456, 25)
            Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.[Default]
            Me.xpToolBar1.TabIndex = 1
            Me.xpToolBar1.Text = "xpToolBar1"
            '
            'barItem11
            '
            Me.barItem11.ID = "Find"
            Me.barItem11.ImageIndex = 7
            Me.barItem11.ImageList = Me.imageList1
            Me.barItem11.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem11.Text = "FindString"
            '
            'barItem10
            '
            Me.barItem10.ID = "sdf"
            Me.barItem10.Text = "sdf"
            '
            'MdiChildForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(456, 310)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.xpToolBar1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MdiChildForm"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Editor"
        Private Sub cmdItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem4.Click
            Me.richTextBox1.Cut()
        End Sub

        Private Sub barItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem2.Click
            Me.richTextBox1.Undo()
        End Sub

        Private Sub barItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem3.Click
            Me.richTextBox1.Redo()
        End Sub

        Private Sub barItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem5.Click
            Me.richTextBox1.Copy()
        End Sub

        Private Sub barItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem6.Click
            Me.richTextBox1.Paste()
        End Sub
#End Region

        Private Sub richTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles richTextBox1.MouseUp
            ' This method lets you show a popup menu at any give point in a control.
            ' This is not necessary in this form, since the popupMenu2 is associated with the RichTextBox via the
            ' PopupMenusManager
            'this.popupMenu2.Show(this.richTextBox1, new Point(e.X, e.Y));
        End Sub


        Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
            Dim filename As String = ""
            Dim savefDlg As SaveFileDialog = New SaveFileDialog()
            savefDlg.Filter = "text files(*.txt)|*.txt"

            If savefDlg.ShowDialog() = DialogResult.OK Then
                filename = savefDlg.FileName
                Dim wstr As StreamWriter = New StreamWriter(filename, False, System.Text.Encoding.Unicode)

                Dim line As String
                For Each line In richTextBox1.Lines
                    wstr.WriteLine(line)
                Next line
                wstr.Close()
            End If

        End Sub


        Private Sub TextSelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged
            EnableItems()
        End Sub


        Private Sub EnableItems()
            If richTextBox1.SelectionLength = 0 Then
                Me.barItem4.Enabled = False
                Me.barItem5.Enabled = False
            Else
                Me.barItem4.Enabled = True
                Me.barItem5.Enabled = True
            End If
        End Sub
    End Class
End Namespace
