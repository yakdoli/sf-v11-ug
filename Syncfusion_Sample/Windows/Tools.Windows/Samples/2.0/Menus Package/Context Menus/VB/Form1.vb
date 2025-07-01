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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms

Namespace XPToolbarsAndContextMenus


	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private popupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents popupMenu2 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents copyItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents cutItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents pasteItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents undoItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents redoItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private fontColorItem As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private WithEvents aboutItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private textBox1 As System.Windows.Forms.TextBox
		Private popupControlContainer1 As PopupControlContainer
		Private WithEvents colorPickerUIAdv1 As ColorPickerUIAdv
		Private WithEvents comboBox1 As ComboBox
		Private label1 As Label
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			comboBox1.SelectedIndex = 3

			colorPickerUIAdv1.MoreColorsButton.Visible = False
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
			Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
			Me.popupMenu2 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.copyItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.cutItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.pasteItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.undoItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.redoItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.fontColorItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem()
			Me.aboutItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.popupControlContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Controls.Add(Me.popupControlContainer1)
			Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.groupBox1.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(12, 63)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(518, 218)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "PopupMenus"
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textBox1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox1.Location = New System.Drawing.Point(6, 16)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(504, 196)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = resources.GetString("textBox1.Text")
			Me.popupMenusManager1.SetXPContextMenu(Me.textBox1, Me.popupMenu2)
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.Controls.Add(Me.colorPickerUIAdv1)
			Me.popupControlContainer1.Location = New System.Drawing.Point(299, 19)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(174, 193)
			Me.popupControlContainer1.TabIndex = 3
			' 
			' colorPickerUIAdv1.RecentGroup
			' 
			Me.colorPickerUIAdv1.RecentGroup.Name = "RecentColors"
			Me.colorPickerUIAdv1.RecentGroup.Visible = False
			' 
			' colorPickerUIAdv1.StandardGroup
			' 
			Me.colorPickerUIAdv1.StandardGroup.Name = "StandardColors"
			' 
			' colorPickerUIAdv1.ThemeGroup
			' 
			Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
			Me.colorPickerUIAdv1.ThemeGroup.Name = "ThemeColors"
			' 
			' colorPickerUIAdv1
			' 
			Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
			Me.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.colorPickerUIAdv1.Location = New System.Drawing.Point(0, 0)
			Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
			Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.Size = New System.Drawing.Size(174, 195)
			Me.colorPickerUIAdv1.TabIndex = 0
			Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
'			Me.colorPickerUIAdv1.ItemSelection += New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(Me.colorPickerUIAdv1_ItemSelection)
'			Me.colorPickerUIAdv1.Picked += New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(Me.colorPickerUIAdv1_Picked)
			' 
			' popupMenusManager1
			' 
			Me.popupMenusManager1.ParentForm = Me
			' 
			' popupMenu2
			' 
			Me.popupMenu2.ParentBarItem = Me.parentBarItem2
'			Me.popupMenu2.BeforePopup += New Syncfusion.Windows.Forms.CancelMouseEventHandler(Me.popupMenu2_BeforePopup)
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.copyItem, Me.cutItem, Me.pasteItem, Me.undoItem, Me.redoItem, Me.fontColorItem, Me.aboutItem})
			Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() { 3, 5, 6})
			Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' copyItem
			' 
			Me.copyItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.copyItem.ID = "&Copy"
			Me.copyItem.ImageIndex = 1
			Me.copyItem.ImageList = Me.imageList1
			Me.copyItem.Text = "&Copy"
'			Me.copyItem.Click += New System.EventHandler(Me.copyItem_Click)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "CutHS.png")
			Me.imageList1.Images.SetKeyName(1, "CopyHS.png")
			Me.imageList1.Images.SetKeyName(2, "PasteHS.png")
			Me.imageList1.Images.SetKeyName(3, "Edit_RedoHS.png")
			Me.imageList1.Images.SetKeyName(4, "Edit_UndoHS.png")
			Me.imageList1.Images.SetKeyName(5, "Color_font.png")
			Me.imageList1.Images.SetKeyName(6, "syncfusion_icon_16.png")
			' 
			' cutItem
			' 
			Me.cutItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cutItem.ID = "Cu&t"
			Me.cutItem.ImageIndex = 0
			Me.cutItem.ImageList = Me.imageList1
			Me.cutItem.Text = "Cu&t"
'			Me.cutItem.Click += New System.EventHandler(Me.cutItem_Click)
			' 
			' pasteItem
			' 
			Me.pasteItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.pasteItem.ID = "&Paste"
			Me.pasteItem.ImageIndex = 2
			Me.pasteItem.ImageList = Me.imageList1
			Me.pasteItem.Text = "&Paste"
'			Me.pasteItem.Click += New System.EventHandler(Me.pasteItem_Click)
			' 
			' undoItem
			' 
			Me.undoItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.undoItem.ID = "&Undo"
			Me.undoItem.ImageIndex = 4
			Me.undoItem.ImageList = Me.imageList1
			Me.undoItem.Text = "&Undo"
'			Me.undoItem.Click += New System.EventHandler(Me.undoItem_Click)
			' 
			' redoItem
			' 
			Me.redoItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.redoItem.ID = "&Redo"
			Me.redoItem.ImageIndex = 3
			Me.redoItem.ImageList = Me.imageList1
			Me.redoItem.Text = "&Redo"
'			Me.redoItem.Click += New System.EventHandler(Me.redoItem_Click)
			' 
			' fontColorItem
			' 
			Me.fontColorItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.fontColorItem.ID = "Font Color"
			Me.fontColorItem.ImageIndex = 5
			Me.fontColorItem.ImageList = Me.imageList1
			Me.fontColorItem.PopupControlContainer = Me.popupControlContainer1
			Me.fontColorItem.Text = "Font Color"
			' 
			' aboutItem
			' 
			Me.aboutItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.aboutItem.ID = "&About Syncfusion"
			Me.aboutItem.ImageIndex = 6
			Me.aboutItem.ImageList = Me.imageList1
			Me.aboutItem.Text = "&About Syncfusion..."
'			Me.aboutItem.Click += New System.EventHandler(Me.aboutItem_Click)
			' 
			' comboBox1
			' 
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Default", "Office2003", "VS2005", "Office2007Blue", "Office2007Black", "Office2007Silver", "Office2007Managed", "Offic2007Outlook"})
			Me.comboBox1.Location = New System.Drawing.Point(16, 29)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 4
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label1.Location = New System.Drawing.Point(13, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(103, 14)
			Me.label1.TabIndex = 5
			Me.label1.Text = "PopupMenu Style"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.ClientSize = New System.Drawing.Size(538, 293)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.groupBox1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Context Menus"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.popupControlContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#Region "AboutForm_Logic"
		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private Sub aboutItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles aboutItem.Click
			aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			aboutForm.ShowDialog()
		End Sub
		#End Region

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
			Me.textBox1.ForeColor = Me.colorPickerUIAdv1.SelectedItem.Color
			Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
		End Sub

		Private Sub colorPickerUIAdv1_ItemSelection(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.ItemSelection
			Me.textBox1.ForeColor = args.Color
		End Sub

		Private Sub popupMenu2_BeforePopup(ByVal sender As Object, ByVal e As CancelMouseEventArgs) Handles popupMenu2.BeforePopup
			Select Case comboBox1.SelectedIndex
				Case 0
					popupMenu2.ParentBarItem.Style = VisualStyle.Default
				Case 1
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2003
				Case 2
					popupMenu2.ParentBarItem.Style = VisualStyle.VS2005
				Case 3
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2007
					popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Blue
				Case 4
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2007
					popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Black
				Case 5
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2007
					popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Silver
				Case 6
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2007
					popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Managed

				Case 7
					popupMenu2.ParentBarItem.Style = VisualStyle.Office2007Outlook
			End Select
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Select Case comboBox1.SelectedIndex
				Case 0, 1, 3, 2, 7
					  Me.ColorScheme = Office2007Theme.Blue
				  Case 4
					Me.ColorScheme = Office2007Theme.Black
				Case 5
					Me.ColorScheme = Office2007Theme.Silver
				Case 6
					Me.ColorScheme = Office2007Theme.Managed
					Office2007Colors.ApplyManagedColors(Me, Color.Red)


			End Select
		End Sub

		Private Sub copyItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyItem.Click
			Me.textBox1.Copy()
		End Sub

		Private Sub cutItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cutItem.Click
			Me.textBox1.Cut()
		End Sub

		Private Sub pasteItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pasteItem.Click
			Me.textBox1.Paste()
		End Sub

		Private Sub redoItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redoItem.Click
			Me.textBox1.Undo()
		End Sub

		Private Sub undoItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles undoItem.Click
			Me.textBox1.Undo()
		End Sub

	End Class
End Namespace


