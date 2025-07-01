Imports Microsoft.VisualBasic
Imports System
Namespace BannerTextDemo_2005
    Partial Class Form1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt3 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt5 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt6 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt7 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label7 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.staticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.label40 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBoxExt9 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label11 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label8 = New System.Windows.Forms.Label
            Me.textBoxExt8 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt4 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label6 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'comboBoxBarItem1
            '
            Me.bannerTextProvider1.SetBannerText(Me.comboBoxBarItem1, New Syncfusion.Windows.Forms.BannerTextInfo("Font Face", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.comboBoxBarItem1.ChoiceList.AddRange(New String() {"Arial", "Courier New", "MS Sans Serif", "Times New Roman"})
            Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem1.ID = "Font Face"
            Me.comboBoxBarItem1.MinWidth = 150
            Me.comboBoxBarItem1.TextBoxValue = "Arial"
            '
            'textBoxExt2
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt2, New Syncfusion.Windows.Forms.BannerTextInfo("Address Line 1", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.textBoxExt2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.textBoxExt2.Location = New System.Drawing.Point(78, 31)
            Me.textBoxExt2.Name = "textBoxExt2"
            Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt2.Size = New System.Drawing.Size(138, 20)
            Me.textBoxExt2.TabIndex = 2
            '
            'textBoxExt3
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt3, New Syncfusion.Windows.Forms.BannerTextInfo("Address Line 2", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.textBoxExt3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.textBoxExt3.Location = New System.Drawing.Point(80, 62)
            Me.textBoxExt3.Name = "textBoxExt3"
            Me.textBoxExt3.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt3.Size = New System.Drawing.Size(138, 20)
            Me.textBoxExt3.TabIndex = 3
            '
            'textBoxExt5
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt5, New Syncfusion.Windows.Forms.BannerTextInfo("Valid Email Address", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.textBoxExt5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.textBoxExt5.Location = New System.Drawing.Point(80, 127)
            Me.textBoxExt5.Name = "textBoxExt5"
            Me.textBoxExt5.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt5.Size = New System.Drawing.Size(138, 20)
            Me.textBoxExt5.TabIndex = 4
            '
            'textBoxExt6
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt6, New Syncfusion.Windows.Forms.BannerTextInfo("Area", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.textBoxExt6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.textBoxExt6.Location = New System.Drawing.Point(94, 162)
            Me.textBoxExt6.Name = "textBoxExt6"
            Me.textBoxExt6.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt6.Size = New System.Drawing.Size(43, 20)
            Me.textBoxExt6.TabIndex = 5
            '
            'textBoxExt7
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt7, New Syncfusion.Windows.Forms.BannerTextInfo("Number", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.textBoxExt7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.textBoxExt7.Location = New System.Drawing.Point(143, 162)
            Me.textBoxExt7.Name = "textBoxExt7"
            Me.textBoxExt7.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt7.Size = New System.Drawing.Size(75, 20)
            Me.textBoxExt7.TabIndex = 6
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.Transparent
            Me.groupBox2.Controls.Add(Me.comboBoxAdv1)
            Me.groupBox2.Controls.Add(Me.label7)
            Me.groupBox2.Controls.Add(Me.label5)
            Me.groupBox2.Controls.Add(Me.textBoxExt2)
            Me.groupBox2.Controls.Add(Me.textBoxExt7)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.textBoxExt6)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Controls.Add(Me.textBoxExt3)
            Me.groupBox2.Controls.Add(Me.textBoxExt5)
            Me.groupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox2.Location = New System.Drawing.Point(337, 42)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(245, 197)
            Me.groupBox2.TabIndex = 10
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "FocusMode"
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.bannerTextProvider1.SetBannerText(Me.comboBoxAdv1, New Syncfusion.Windows.Forms.BannerTextInfo("--Select--", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.comboBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxAdv1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"England", "Japan", "India", "United States"})
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "England"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Japan"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "India"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "United States"))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(80, 95)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(138, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv1.SuppressDropDownEvent = False
            Me.comboBoxAdv1.TabIndex = 13
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label7.Location = New System.Drawing.Point(6, 95)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(45, 14)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Country"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label5.Location = New System.Drawing.Point(75, 165)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(19, 14)
            Me.label5.TabIndex = 11
            Me.label5.Text = "+1"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label3.Location = New System.Drawing.Point(6, 162)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(37, 14)
            Me.label3.TabIndex = 11
            Me.label3.Text = "Phone"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(6, 37)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(49, 14)
            Me.label2.TabIndex = 11
            Me.label2.Text = "Address"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label4.Location = New System.Drawing.Point(6, 133)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(31, 14)
            Me.label4.TabIndex = 11
            Me.label4.Text = "Email"
            '
            'xpToolBar1
            '
            Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar1.Bar.BarName = ""
            Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.staticBarItem1, Me.comboBoxBarItem1, Me.comboBoxBarItem2})
            Me.xpToolBar1.Bar.Manager = Nothing
            Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.xpToolBar1.Location = New System.Drawing.Point(0, 0)
            Me.xpToolBar1.Name = "xpToolBar1"
            Me.xpToolBar1.Size = New System.Drawing.Size(594, 29)
            Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar1.TabIndex = 0
            Me.xpToolBar1.Text = "xpToolBar1"
            '
            'staticBarItem1
            '
            Me.staticBarItem1.CustomTextFont = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.staticBarItem1.ID = "Menus"
            Me.staticBarItem1.Text = "Format:"
            '
            'comboBoxBarItem2
            '
            Me.bannerTextProvider1.SetBannerText(Me.comboBoxBarItem2, New Syncfusion.Windows.Forms.BannerTextInfo("Font Size", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"Small", "Medium", "Large"})
            Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem2.ID = "Size"
            Me.comboBoxBarItem2.MinWidth = 100
            Me.comboBoxBarItem2.Text = "Size"
            Me.comboBoxBarItem2.TextBoxValue = "Small"
            '
            'label40
            '
            Me.label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label40.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label40.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label40.Image = CType(resources.GetObject("label40.Image"), System.Drawing.Image)
            Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label40.Location = New System.Drawing.Point(0, 254)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(594, 47)
            Me.label40.TabIndex = 2
            Me.label40.Text = "BannerTextProvider is a component used to provide cue banner help text for editor" & _
                " controls such as " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TextBoxExt and Combobox based controls. It provides two edit" & _
                "ing modes, FocusMode and EditMode."
            Me.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.Transparent
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.textBoxExt9)
            Me.groupBox1.Controls.Add(Me.label11)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Controls.Add(Me.label9)
            Me.groupBox1.Controls.Add(Me.comboBoxAdv2)
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.textBoxExt8)
            Me.groupBox1.Controls.Add(Me.textBoxExt4)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox1.Location = New System.Drawing.Point(12, 42)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(307, 197)
            Me.groupBox1.TabIndex = 9
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Edit Mode"
            '
            'textBox1
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBox1, New Syncfusion.Windows.Forms.BannerTextInfo("First Name", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.textBox1.Location = New System.Drawing.Point(106, 28)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(99, 20)
            Me.textBox1.TabIndex = 14
            '
            'textBox2
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBox2, New Syncfusion.Windows.Forms.BannerTextInfo("Last Name", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.textBox2.Location = New System.Drawing.Point(211, 28)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(83, 20)
            Me.textBox2.TabIndex = 15
            '
            'textBoxExt9
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt9, New Syncfusion.Windows.Forms.BannerTextInfo("In Years", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.textBoxExt9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt9.Location = New System.Drawing.Point(106, 159)
            Me.textBoxExt9.Name = "textBoxExt9"
            Me.textBoxExt9.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt9.Size = New System.Drawing.Size(60, 20)
            Me.textBoxExt9.TabIndex = 21
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label11.Location = New System.Drawing.Point(172, 162)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(37, 14)
            Me.label11.TabIndex = 20
            Me.label11.Text = "Years"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label10.Location = New System.Drawing.Point(12, 162)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(89, 14)
            Me.label10.TabIndex = 19
            Me.label10.Text = "Work Experience"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label9.Location = New System.Drawing.Point(12, 127)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(40, 14)
            Me.label9.TabIndex = 18
            Me.label9.Text = "Project"
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.bannerTextProvider1.SetBannerText(Me.comboBoxAdv2, New Syncfusion.Windows.Forms.BannerTextInfo("Designation", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.comboBoxAdv2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"CEO", "Managing Director", "Project Manager", "HR Manager", "Team Leader", "Developer"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "CEO"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Managing Director"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Project Manager"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "HR Manager"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Team Leader"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Developer"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(106, 95)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(188, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.SuppressDropDownEvent = False
            Me.comboBoxAdv2.TabIndex = 17
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label8.Location = New System.Drawing.Point(12, 95)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(26, 14)
            Me.label8.TabIndex = 16
            Me.label8.Text = "Title"
            '
            'textBoxExt8
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt8, New Syncfusion.Windows.Forms.BannerTextInfo("Title of the current project", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.textBoxExt8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt8.Location = New System.Drawing.Point(106, 127)
            Me.textBoxExt8.Name = "textBoxExt8"
            Me.textBoxExt8.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt8.Size = New System.Drawing.Size(188, 20)
            Me.textBoxExt8.TabIndex = 15
            '
            'textBoxExt4
            '
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt4, New Syncfusion.Windows.Forms.BannerTextInfo("Employer", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.EditMode))
            Me.textBoxExt4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt4.Location = New System.Drawing.Point(106, 62)
            Me.textBoxExt4.Name = "textBoxExt4"
            Me.textBoxExt4.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt4.Size = New System.Drawing.Size(188, 20)
            Me.textBoxExt4.TabIndex = 14
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label6.Location = New System.Drawing.Point(12, 62)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(52, 14)
            Me.label6.TabIndex = 12
            Me.label6.Text = "Company"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label1.Location = New System.Drawing.Point(12, 31)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(34, 14)
            Me.label1.TabIndex = 11
            Me.label1.Text = "Name"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(594, 301)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.xpToolBar1)
            Me.Controls.Add(Me.label40)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Banner Text Provider"
            Me.UseOffice2007SchemeBackColor = True
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
        Private label40 As System.Windows.Forms.Label
        Private staticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
        Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label4 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private textBoxExt3 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private textBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private label3 As System.Windows.Forms.Label
        Private textBoxExt6 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private textBoxExt5 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private label5 As System.Windows.Forms.Label
        Private textBoxExt7 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private bannerTextProvider1 As Syncfusion.Windows.Forms.BannerTextProvider
        Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private textBoxExt4 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private label8 As System.Windows.Forms.Label
        Private textBoxExt8 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private label9 As System.Windows.Forms.Label
        Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private textBoxExt9 As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private label11 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private textBox2 As System.Windows.Forms.TextBox
    End Class
End Namespace

