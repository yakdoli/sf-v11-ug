#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace CustomOffice2007Colors_2005
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Main")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Standard")
            Me.bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Format")
            Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar
            Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem4 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.textBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem
            Me.dropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Bars.Add(Me.bar3)
            Me.mainFrameBarManager1.Categories.Add("Edit")
            Me.mainFrameBarManager1.Categories.Add("Standard")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.barItem4, Me.barItem5, Me.parentBarItem2, Me.barItem6, Me.parentBarItem3, Me.barItem7, Me.barItem8, Me.barItem9, Me.comboBoxBarItem2, Me.parentBarItem4, Me.barItem3, Me.barItem10, Me.barItem11})
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "Main"
            Me.bar1.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "Main"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem3, Me.parentBarItem2})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 1
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem4, Me.barItem4, Me.barItem5})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {2})
            Me.parentBarItem1.Text = "&File"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 1
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "New"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem3, Me.barItem10})
            Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem4.Text = "New"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 1
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "Document"
            Me.barItem3.Text = "Document"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 1
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.ID = "Image File"
            Me.barItem10.Text = "Image File"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 1
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "&Open"
            Me.barItem4.Text = "&Open"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 1
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "E&xit"
            Me.barItem5.Text = "E&xit"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 0
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "&Edit"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem7, Me.barItem8, Me.barItem9, Me.comboBoxBarItem2, Me.barItem11})
            Me.parentBarItem3.SeparatorIndices.AddRange(New Integer() {2})
            Me.parentBarItem3.Text = "&Edit"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 0
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "&Undo"
            Me.barItem7.Text = "&Undo"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 0
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "&Redo"
            Me.barItem8.Text = "&Redo"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 0
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "&Find and Replace"
            Me.barItem9.Text = "&Find and Replace"
            '
            'comboBoxBarItem2
            '
            Me.comboBoxBarItem2.CategoryIndex = 0
            Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"Item1", "Item2", "Item3", "Item4", "Item5"})
            Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem2.ID = "Combo"
            Me.comboBoxBarItem2.MinWidth = 100
            Me.comboBoxBarItem2.Text = "Test"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 0
            Me.barItem11.Checked = True
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem11.ID = "Show GroupBar"
            Me.barItem11.Text = "Show GroupBar"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 2
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Help"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem6})
            Me.parentBarItem2.Text = "&Help"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 2
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "A&bout"
            Me.barItem6.Text = "A&bout..."
            '
            'bar2
            '
            Me.bar2.BarName = "Standard"
            Me.bar2.Caption = "Standard"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem4, Me.barItem4})
            Me.bar2.Manager = Me.mainFrameBarManager1
            '
            'bar3
            '
            Me.bar3.BarName = "Format"
            Me.bar3.Caption = "Format"
            Me.bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem7, Me.barItem8, Me.comboBoxBarItem2, Me.barItem11})
            Me.bar3.Manager = Me.mainFrameBarManager1
            Me.bar3.SeparatorIndices.AddRange(New Integer() {2})
            '
            'groupBar1
            '
            Me.groupBar1.AllowDrop = True
            Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupBar1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
            Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBar1.GroupBarItemHeight = 26
            Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() {Me.groupBarItem1, Me.groupBarItem2, Me.groupBarItem3, Me.groupBarItem4})
            Me.groupBar1.Location = New System.Drawing.Point(0, 50)
            Me.groupBar1.Name = "groupBar1"
            Me.groupBar1.SelectedItem = 3
            Me.groupBar1.Size = New System.Drawing.Size(178, 303)
            Me.groupBar1.TabIndex = 4
            Me.groupBar1.Text = "groupBar1"
            Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'groupBarItem1
            '
            Me.groupBarItem1.Client = Nothing
            Me.groupBarItem1.Image = CType(resources.GetObject("groupBarItem1.Image"), System.Drawing.Image)
            Me.groupBarItem1.LargeImageMode = True
            Me.groupBarItem1.Padding = 5
            Me.groupBarItem1.Text = "GroupBarItem0"
            '
            'groupBarItem2
            '
            Me.groupBarItem2.Client = Nothing
            Me.groupBarItem2.Image = CType(resources.GetObject("groupBarItem2.Image"), System.Drawing.Image)
            Me.groupBarItem2.LargeImageMode = True
            Me.groupBarItem2.Padding = 5
            Me.groupBarItem2.Text = "GroupBarItem1"
            '
            'groupBarItem3
            '
            Me.groupBarItem3.Client = Nothing
            Me.groupBarItem3.Image = CType(resources.GetObject("groupBarItem3.Image"), System.Drawing.Image)
            Me.groupBarItem3.LargeImageMode = True
            Me.groupBarItem3.Padding = 5
            Me.groupBarItem3.Text = "GroupBarItem2"
            '
            'groupBarItem4
            '
            Me.groupBarItem4.Client = Nothing
            Me.groupBarItem4.Image = CType(resources.GetObject("groupBarItem4.Image"), System.Drawing.Image)
            Me.groupBarItem4.LargeImageMode = True
            Me.groupBarItem4.Padding = 5
            Me.groupBarItem4.Text = "GroupBarItem3"
            '
            'xpToolBar1
            '
            Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar1.Bar.BarName = ""
            Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.textBoxBarItem1, Me.dropDownBarItem1})
            Me.xpToolBar1.Bar.Manager = Nothing
            Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.xpToolBar1.Location = New System.Drawing.Point(0, 353)
            Me.xpToolBar1.Name = "xpToolBar1"
            Me.xpToolBar1.Size = New System.Drawing.Size(565, 25)
            Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar1.TabIndex = 0
            Me.xpToolBar1.Text = "xpToolBar1"
            '
            'barItem1
            '
            Me.barItem1.ID = "Item1"
            Me.barItem1.Text = "Insert"
            '
            'barItem2
            '
            Me.barItem2.ID = "Item2"
            Me.barItem2.Text = "Option"
            '
            'textBoxBarItem1
            '
            Me.textBoxBarItem1.MinWidth = 100
            Me.textBoxBarItem1.Value = ""
            '
            'dropDownBarItem1
            '
            Me.dropDownBarItem1.ID = "DItem1"
            Me.dropDownBarItem1.Text = "Format"
            '
            'comboBoxBarItem1
            '
            Me.comboBoxBarItem1.ChoiceList.AddRange(New String() {"Item1", "Item2", "Item3", "Item4"})
            Me.comboBoxBarItem1.MinWidth = 100
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.Color.White
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Location = New System.Drawing.Point(178, 50)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(387, 303)
            Me.richTextBox1.TabIndex = 19
            Me.richTextBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(565, 378)
            Me.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.groupBar1)
            Me.Controls.Add(Me.xpToolBar1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Custom Office Style Colors Demo"
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
        Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
        Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
        Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
        Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
        Private groupBarItem4 As Syncfusion.Windows.Forms.Tools.GroupBarItem
        Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
        Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private textBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem
        Private dropDownBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
        Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private richTextBox1 As System.Windows.Forms.RichTextBox
    End Class
End Namespace

