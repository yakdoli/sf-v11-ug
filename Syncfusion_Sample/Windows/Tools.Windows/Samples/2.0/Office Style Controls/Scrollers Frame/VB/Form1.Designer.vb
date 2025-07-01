#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace ScrollersFrame_2005
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
			Dim treeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
			Dim treeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Folders                                          ", 7, 7, New System.Windows.Forms.TreeNode() { treeNode17, treeNode18, treeNode19, treeNode20, treeNode21})
			Dim treeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() { treeNode23, treeNode24, treeNode25})
			Dim treeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outbox", 3, 3)
			Dim treeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Public")
			Dim treeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode27, treeNode28, treeNode29, treeNode30, treeNode31})
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.scrollersFrame2 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			Me.treeView3 = New System.Windows.Forms.TreeView()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Main Menu")
			Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.trackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.ID = "Themes"
			Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem2.Text = "Themes"
			' 
			' scrollersFrame2
			' 
			Me.scrollersFrame2.AttachedTo = Me.treeView3
			Me.scrollersFrame2.HorizontalSmallChange = 7
			Me.scrollersFrame2.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame2.VerticallSmallChange = 13
			Me.scrollersFrame2.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
			' 
			' treeView3
			' 
			Me.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeView3.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeView3.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.treeView3.Indent = 25
			Me.treeView3.ItemHeight = 22
			Me.treeView3.Location = New System.Drawing.Point(0, 25)
			Me.treeView3.MinimumSize = New System.Drawing.Size(2, 110)
			Me.treeView3.Name = "treeView3"
			treeNode17.ImageIndex = 1
			treeNode17.Name = ""
			treeNode17.SelectedImageIndex = 1
			treeNode17.Text = "Deleted Items"
			treeNode18.ImageIndex = 0
			treeNode18.Name = ""
			treeNode18.SelectedImageIndex = 0
			treeNode18.Text = "Junk Email"
			treeNode19.ImageIndex = 2
			treeNode19.Name = ""
			treeNode19.SelectedImageIndex = 2
			treeNode19.Text = "Inbox"
			treeNode20.ImageIndex = 6
			treeNode20.Name = ""
			treeNode20.SelectedImageIndex = 6
			treeNode20.Text = "Sent Items"
			treeNode21.ImageIndex = 4
			treeNode21.Name = ""
			treeNode21.SelectedImageIndex = 4
			treeNode21.Text = "Search Folders"
			treeNode22.ImageIndex = 7
			treeNode22.Name = ""
			treeNode22.SelectedImageIndex = 7
			treeNode22.Text = "Personal Folders                                          "
			treeNode23.ImageIndex = 4
			treeNode23.Name = ""
			treeNode23.SelectedImageIndex = 4
			treeNode23.Text = "Search Folders"
			treeNode24.ImageIndex = 6
			treeNode24.Name = ""
			treeNode24.SelectedImageIndex = 6
			treeNode24.Text = "Sent Items"
			treeNode25.ImageIndex = 1
			treeNode25.Name = ""
			treeNode25.SelectedImageIndex = 1
			treeNode25.Text = "Deleted Items"
			treeNode26.ImageIndex = 8
			treeNode26.Name = ""
			treeNode26.SelectedImageIndex = 8
			treeNode26.Text = "Archive Folders"
			treeNode27.ImageIndex = 5
			treeNode27.Name = ""
			treeNode27.SelectedImageIndex = 5
			treeNode27.Text = "Drafts"
			treeNode28.ImageIndex = 2
			treeNode28.Name = ""
			treeNode28.SelectedImageIndex = 2
			treeNode28.Text = "Inbox"
			treeNode29.ImageIndex = 3
			treeNode29.Name = ""
			treeNode29.SelectedImageIndex = 3
			treeNode29.Text = "Outbox"
			treeNode30.ImageIndex = 6
			treeNode30.Name = ""
			treeNode30.SelectedImageIndex = 6
			treeNode30.Text = "Sent Items"
			treeNode31.Name = ""
			treeNode31.Text = "Public"
			treeNode32.ImageIndex = 8
			treeNode32.Name = ""
			treeNode32.SelectedImageIndex = 8
			treeNode32.Text = "Syncfusion Email"
			Me.treeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode22, treeNode26, treeNode32})
			Me.treeView3.ShowLines = False
			Me.treeView3.Size = New System.Drawing.Size(148, 295)
			Me.treeView3.TabIndex = 16
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo
			Me.buttonAdv1.KeepFocusRectangle = False
			Me.buttonAdv1.Location = New System.Drawing.Point(502, 596)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(18, 17)
			Me.buttonAdv1.TabIndex = 9
			Me.buttonAdv1.Text = "buttonAdv1"
			Me.buttonAdv1.UseVisualStyle = True
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo
			Me.buttonAdv2.KeepFocusRectangle = False
			Me.buttonAdv2.Location = New System.Drawing.Point(549, 596)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(18, 17)
			Me.buttonAdv2.TabIndex = 12
			Me.buttonAdv2.Text = "buttonAdv2"
			Me.buttonAdv2.UseVisualStyle = True
			' 
			' mainFrameBarManager1
			' 
			Me.mainFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.mainFrameBarManager1.Bars.Add(Me.bar1)
			Me.mainFrameBarManager1.Categories.Add("Category1")
			Me.mainFrameBarManager1.CurrentBaseFormType = ""
			Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.mainFrameBarManager1.Form = Me
			Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem7, Me.barItem8, Me.barItem9, Me.parentBarItem4})
			Me.mainFrameBarManager1.ResetCustomization = False
			Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "Main Menu"
			Me.bar1.BarStyle = (CType((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "Main Menu"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem4})
			Me.bar1.Manager = Me.mainFrameBarManager1
			' 
			' parentBarItem4
			' 
			Me.parentBarItem4.CategoryIndex = 0
			Me.parentBarItem4.CustomNormalTextColor = System.Drawing.Color.MidnightBlue
			Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem4.ID = "Office2007 Styles"
			Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem7, Me.barItem8, Me.barItem9})
			Me.parentBarItem4.Text = "Office2007 Styles"
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = 0
			Me.barItem7.Checked = True
			Me.barItem7.CustomNormalTextColor = System.Drawing.Color.MidnightBlue
			Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem7.ID = "Blue"
			Me.barItem7.Text = "Blue"
'			Me.barItem7.Click += New System.EventHandler(Me.barItem_Click);
			' 
			' barItem8
			' 
			Me.barItem8.CategoryIndex = 0
			Me.barItem8.CustomNormalTextColor = System.Drawing.Color.MidnightBlue
			Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem8.ID = "Silver"
			Me.barItem8.Text = "Silver"
'			Me.barItem8.Click += New System.EventHandler(Me.barItem_Click);
			' 
			' barItem9
			' 
			Me.barItem9.CategoryIndex = 0
			Me.barItem9.CustomNormalTextColor = System.Drawing.Color.MidnightBlue
			Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem9.ID = "Black"
			Me.barItem9.Text = "Black"
'			Me.barItem9.Click += New System.EventHandler(Me.barItem_Click);
			' 
			' trackBarEx1
			' 
			Me.trackBarEx1.Location = New System.Drawing.Point(0, 0)
			Me.trackBarEx1.Name = "trackBarEx1"
			Me.trackBarEx1.Size = New System.Drawing.Size(250, 20)
			Me.trackBarEx1.TabIndex = 0
			Me.trackBarEx1.TimerInterval = 100
			Me.trackBarEx1.Value = 5
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(246))))))
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.label1)
			Me.gradientPanel1.Controls.Add(Me.buttonAdv3)
			Me.gradientPanel1.Location = New System.Drawing.Point(161, 38)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(325, 127)
			Me.gradientPanel1.TabIndex = 21
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.White
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.label1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Image = (CType(resources.GetObject("label1.Image"), System.Drawing.Image))
			Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(323, 125)
			Me.label1.TabIndex = 0
			Me.label1.Text = resources.GetString("label1.Text")
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' buttonAdv3
			' 
			Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv3.Image = (CType(resources.GetObject("buttonAdv3.Image"), System.Drawing.Image))
			Me.buttonAdv3.KeepFocusRectangle = False
			Me.buttonAdv3.Location = New System.Drawing.Point(225, 69)
			Me.buttonAdv3.Name = "buttonAdv3"
			Me.buttonAdv3.Size = New System.Drawing.Size(23, 23)
			Me.buttonAdv3.TabIndex = 22
			Me.buttonAdv3.UseVisualStyle = True
'			Me.buttonAdv3.Click += New System.EventHandler(Me.buttonAdv3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(254))))))
			Me.ClientSize = New System.Drawing.Size(501, 320)
			Me.Controls.Add(Me.gradientPanel1)
			Me.Controls.Add(Me.treeView3)
			Me.Controls.Add(Me.buttonAdv2)
			Me.Controls.Add(Me.buttonAdv1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Scrollers Frame"
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private scrollersFrame2 As Syncfusion.Windows.Forms.ScrollersFrame
		Private buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private treeView3 As System.Windows.Forms.TreeView
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private trackBarEx1 As Syncfusion.Windows.Forms.Tools.TrackBarEx
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label1 As System.Windows.Forms.Label
		Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
	End Class
End Namespace

