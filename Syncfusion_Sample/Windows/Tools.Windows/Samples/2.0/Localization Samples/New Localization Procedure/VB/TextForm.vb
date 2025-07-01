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

Namespace LocalizationDemo
	''' <summary>
	''' Summary description for TextForm.
	''' </summary>
	Public Class TextForm
		Inherits System.Windows.Forms.Form
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private childFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
		Private imageList1 As System.Windows.Forms.ImageList
		Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private dropDownBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private colorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			AddHandler colorUIControl1.ColorSelected, AddressOf colorUIControl1_ColorSelected
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TextForm))
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.childFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "Edit")
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "Format")
			Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.dropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem()
			Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
			Me.colorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl()
			Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "MainMenu")
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.Font = New System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.richTextBox1.ForeColor = System.Drawing.Color.Crimson
			Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Size = New System.Drawing.Size(442, 440)
			Me.richTextBox1.TabIndex = 14
			Me.richTextBox1.Text = "Essential Tools Lokalisierung Demo"
			' 
			' childFrameBarManager1
			' 
			Me.childFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("childFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.childFrameBarManager1.Bars.Add(Me.bar1)
			Me.childFrameBarManager1.Bars.Add(Me.bar2)
			Me.childFrameBarManager1.Bars.Add(Me.bar3)
			Me.childFrameBarManager1.Categories.Add("Edit")
			Me.childFrameBarManager1.Categories.Add("Format")
			Me.childFrameBarManager1.Categories.Add("Popups")
			Me.childFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
			Me.childFrameBarManager1.Form = Me
			Me.childFrameBarManager1.ImageList = Me.imageList1
			Me.childFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.dropDownBarItem1, Me.parentBarItem1, Me.parentBarItem2})
			Me.childFrameBarManager1.LargeImageList = Nothing
			Me.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "Edit"
			Me.bar1.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "Bearbeiten"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5})
			Me.bar1.Manager = Me.childFrameBarManager1
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = 0
			Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem1.ID = "biCut"
			Me.barItem1.ImageIndex = 3
			Me.barItem1.Text = "Schnitt"
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = 0
			Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem2.ID = "biCopy"
			Me.barItem2.ImageIndex = 4
			Me.barItem2.Text = "&Kopieren"
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = 0
			Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem3.ID = "biPaste"
			Me.barItem3.ImageIndex = 5
			Me.barItem3.Text = "&Einfügen"
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 0
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "biUndo"
			Me.barItem4.ImageIndex = 6
			Me.barItem4.Text = "&Rückgängig machen"
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 0
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "biRedo"
			Me.barItem5.ImageIndex = 7
			Me.barItem5.Text = "&Redo"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Format"
			Me.bar2.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar2.Caption = "Format"
			Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.comboBoxBarItem1, Me.dropDownBarItem1, Me.comboBoxBarItem2})
			Me.bar2.Manager = Me.childFrameBarManager1
			' 
			' comboBoxBarItem1
			' 
			Me.comboBoxBarItem1.CategoryIndex = 1
			Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem1.ID = "Editable"
			Me.comboBoxBarItem1.Text = "Editierbare"
			' 
			' dropDownBarItem1
			' 
			Me.dropDownBarItem1.CategoryIndex = 1
			Me.dropDownBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dropDownBarItem1.ID = "Font DropDown"
			Me.dropDownBarItem1.ImageIndex = 8
			Me.dropDownBarItem1.PopupControlContainer = Me.popupControlContainer1
			Me.dropDownBarItem1.Text = "Font DropDown"
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.Controls.Add(Me.colorUIControl1)
			Me.popupControlContainer1.Location = New System.Drawing.Point(192, 120)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(208, 200)
			Me.popupControlContainer1.TabIndex = 15
			Me.popupControlContainer1.Visible = False
			' 
			' colorUIControl1
			' 
			Me.colorUIControl1.BackColor = System.Drawing.SystemColors.Control
			Me.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.colorUIControl1.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.colorUIControl1.Location = New System.Drawing.Point(0, 0)
			Me.colorUIControl1.Name = "colorUIControl1"
			Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.colorUIControl1.Size = New System.Drawing.Size(208, 200)
			Me.colorUIControl1.TabIndex = 1
			Me.colorUIControl1.Text = "colorUIControl1"
			Me.colorUIControl1.UserTabName = "User Farben"
			' 
			' comboBoxBarItem2
			' 
			Me.comboBoxBarItem2.CategoryIndex = 1
			Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem2.ID = "ChoiceList"
			Me.comboBoxBarItem2.Text = "Auswahlliste"
			' 
			' bar3
			' 
			Me.bar3.BarName = "MainMenu"
			Me.bar3.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar3.Caption = "Hauptmenü"
			Me.bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.parentBarItem2})
			Me.bar3.Manager = Me.childFrameBarManager1
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 2
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "Edit"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5})
			Me.parentBarItem1.MergeOrder = 1
			Me.parentBarItem1.Text = "Bearbeiten"
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CategoryIndex = 2
			Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem2.ID = "Format"
			Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.dropDownBarItem1})
			Me.parentBarItem2.MergeOrder = 3
			Me.parentBarItem2.Text = "Format"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			' 
			' TextForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(442, 440)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.richTextBox1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "TextForm"
			Me.Text = "Textpad"
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private Sub colorUIControl1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			Me.popupControlContainer1.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
		End Sub
		#End Region
	End Class
End Namespace
