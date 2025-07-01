Namespace NavigationViewDemo_2005
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
        
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container()
            Dim bar1 As New Syncfusion.Windows.Forms.Tools.Navigation.Bar()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.navigationView1 = New Syncfusion.Windows.Forms.Tools.NavigationView()
            Me.customButton1 = New Syncfusion.Windows.Forms.Tools.Navigation.CustomButton()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
            Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
            Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.HistorycheckBox = New System.Windows.Forms.CheckBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.RTLChkBox = New System.Windows.Forms.CheckBox()
            Me.BarImgChkBox = New System.Windows.Forms.CheckBox()
            Me.CutmBtnChkBox = New System.Windows.Forms.CheckBox()
            Me.HisbtnChkBox = New System.Windows.Forms.CheckBox()
            Me.VisStyleCmbBox = New System.Windows.Forms.ComboBox()
            Me.listView1 = New System.Windows.Forms.ListView()
            DirectCast((Me.navigationView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationView1.SuspendLayout()
            DirectCast((Me.gradientPanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            DirectCast((Me.xpTaskBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar1.SuspendLayout()
            Me.xpTaskBarBox2.SuspendLayout()
            DirectCast((Me.gradientPanel4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' navigationView1
            ' 
            bar1.ImageIndex = 2
            bar1.Text = "My Computer"
            Me.navigationView1.Bars.AddRange(New Syncfusion.Windows.Forms.Tools.Navigation.Bar() {bar1})
            Me.navigationView1.BorderColor = System.Drawing.Color.Navy
            Me.navigationView1.Controls.Add(Me.customButton1)
            Me.navigationView1.Dock = System.Windows.Forms.DockStyle.Top
            Me.navigationView1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            'Me.navigationView1.HistoryEnabled = True
            Me.navigationView1.ImageList = Me.imageList1
            Me.navigationView1.Location = New System.Drawing.Point(0, 0)
            Me.navigationView1.Name = "navigationView1"
            Me.navigationView1.SelectedBar = bar1
            Me.navigationView1.ShowHistoryButtons = True
            Me.navigationView1.ShowRootBarText = True
            Me.navigationView1.Size = New System.Drawing.Size(565, 28)
            Me.navigationView1.TabIndex = 0
            Me.navigationView1.Text = "navigationView1"
            AddHandler Me.navigationView1.BarSelectionChanging, AddressOf Me.navigationView1_BarSelectionChanging
            ' 
            ' customButton1
            ' 
            Me.customButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.customButton1.ImageIndex = 3
            Me.customButton1.ImageList = Me.imageList1
            Me.customButton1.KeepFocusRectangle = False
            Me.customButton1.Location = New System.Drawing.Point(539, 3)
            Me.customButton1.Name = "customButton1"
            Me.customButton1.Size = New System.Drawing.Size(26, 21)
            Me.customButton1.TabIndex = 5
            Me.customButton1.UseVisualStyle = True
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = DirectCast((resources.GetObject("imageList1.ImageStream")), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "floppydrive2.ico")
            Me.imageList1.Images.SetKeyName(1, "cddrive2.ico")
            Me.imageList1.Images.SetKeyName(2, "COMPUTER.ico")
            Me.imageList1.Images.SetKeyName(3, "SEARCH.gif")
            Me.imageList1.Images.SetKeyName(4, "open_icon.png")
            Me.imageList1.Images.SetKeyName(5, "file.ico")
            Me.imageList1.Images.SetKeyName(6, "folder.ico")
            Me.imageList1.Images.SetKeyName(7, "New.ico")
            Me.imageList1.Images.SetKeyName(8, "folder.bmp")
            ' 
            ' gradientPanel2
            ' 
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CInt(CByte((220))), CInt(CByte((235))), CInt(CByte((254)))), System.Drawing.Color.FromArgb(CInt(CByte((189))), CInt(CByte((215))), CInt(CByte((252)))))
            Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CInt(CByte((189))), CInt(CByte((215))), CInt(CByte((252))))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.xpTaskBar1)
            Me.gradientPanel2.Controls.Add(Me.listView1)
            Me.gradientPanel2.Controls.Add(Me.navigationView1)
            Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel2.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(567, 396)
            Me.gradientPanel2.TabIndex = 37
            ' 
            ' xpTaskBar1
            ' 
            Me.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
            Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
            Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.xpTaskBar1.Location = New System.Drawing.Point(0, 28)
            Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar1.Name = "xpTaskBar1"
            Me.xpTaskBar1.Size = New System.Drawing.Size(139, 366)
            Me.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar1.TabIndex = 34
            Me.xpTaskBar1.VerticalPadding = 9
            ' 
            ' xpTaskBarBox1
            ' 
            Me.xpTaskBarBox1.DrawFocusRect = False
            Me.xpTaskBarBox1.FocusOnClick = False
            Me.xpTaskBarBox1.HeaderImageIndex = -1
            Me.xpTaskBarBox1.HitTaskBoxArea = False
            Me.xpTaskBarBox1.ImageList = Me.imageList1
            Me.xpTaskBarBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Documents", System.Drawing.Color.Empty, 8, Nothing, "", True, _
            	True, "XPTaskBarItem0", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Pictures", System.Drawing.Color.Empty, 8, Nothing, "", True, _
            	True, "XPTaskBarItem1", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Music", System.Drawing.Color.Empty, 8, Nothing, "", True, _
            	True, "XPTaskBarItem2", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("More >>", System.Drawing.Color.Empty, -1, Nothing, "", True, _
            	True, "XPTaskBarItem3", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6)})
            Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
            Me.xpTaskBarBox1.PreferredChildPanelHeight = 40
            Me.xpTaskBarBox1.Size = New System.Drawing.Size(137, 92)
            Me.xpTaskBarBox1.TabIndex = 0
            Me.xpTaskBarBox1.Text = "Favorite Links"
            ' 
            ' xpTaskBarBox2
            ' 
            Me.xpTaskBarBox2.Controls.Add(Me.gradientPanel4)
            Me.xpTaskBarBox2.DrawFocusRect = False
            Me.xpTaskBarBox2.FocusOnClick = False
            Me.xpTaskBarBox2.HeaderImageIndex = -1
            Me.xpTaskBarBox2.HitTaskBoxArea = False
            Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 101)
            Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
            Me.xpTaskBarBox2.PreferredChildPanelHeight = 250
            Me.xpTaskBarBox2.Size = New System.Drawing.Size(137, 274)
            Me.xpTaskBarBox2.TabIndex = 1
            Me.xpTaskBarBox2.Text = "Features"
            ' 
            ' gradientPanel4
            ' 
            Me.gradientPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CInt(CByte((220))), CInt(CByte((235))), CInt(CByte((254)))), System.Drawing.Color.FromArgb(CInt(CByte((189))), CInt(CByte((215))), CInt(CByte((252)))))
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CInt(CByte((189))), CInt(CByte((215))), CInt(CByte((252))))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.HistorycheckBox)
            Me.gradientPanel4.Controls.Add(Me.label1)
            Me.gradientPanel4.Controls.Add(Me.RTLChkBox)
            Me.gradientPanel4.Controls.Add(Me.BarImgChkBox)
            Me.gradientPanel4.Controls.Add(Me.CutmBtnChkBox)
            Me.gradientPanel4.Controls.Add(Me.HisbtnChkBox)
            Me.gradientPanel4.Controls.Add(Me.VisStyleCmbBox)
            Me.gradientPanel4.Location = New System.Drawing.Point(2, 22)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(133, 250)
            Me.gradientPanel4.TabIndex = 32
            ' 
            ' HistorycheckBox
            ' 
            Me.HistorycheckBox.AutoSize = True
            Me.HistorycheckBox.BackColor = System.Drawing.Color.Transparent
            Me.HistorycheckBox.Checked = True
            Me.HistorycheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.HistorycheckBox.Location = New System.Drawing.Point(7, 16)
            Me.HistorycheckBox.Name = "HistorycheckBox"
            Me.HistorycheckBox.Size = New System.Drawing.Size(100, 17)
            Me.HistorycheckBox.TabIndex = 1
            Me.HistorycheckBox.Text = "History Enabled"
            Me.HistorycheckBox.UseVisualStyleBackColor = False
            AddHandler Me.HistorycheckBox.CheckedChanged, AddressOf Me.HistorycheckBox_CheckedChanged
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(4, 81)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(61, 13)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Visual Style"
            ' 
            ' RTLChkBox
            ' 
            Me.RTLChkBox.AutoSize = True
            Me.RTLChkBox.BackColor = System.Drawing.Color.Transparent
            Me.RTLChkBox.Location = New System.Drawing.Point(4, 204)
            Me.RTLChkBox.Name = "RTLChkBox"
            Me.RTLChkBox.Size = New System.Drawing.Size(82, 17)
            Me.RTLChkBox.TabIndex = 4
            Me.RTLChkBox.Text = "RightToLeft"
            Me.RTLChkBox.UseVisualStyleBackColor = False
            AddHandler Me.RTLChkBox.CheckedChanged, AddressOf Me.RTLChkBox_CheckedChanged
            ' 
            ' BarImgChkBox
            ' 
            Me.BarImgChkBox.AutoSize = True
            Me.BarImgChkBox.BackColor = System.Drawing.Color.Transparent
            Me.BarImgChkBox.Checked = True
            Me.BarImgChkBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.BarImgChkBox.Location = New System.Drawing.Point(4, 167)
            Me.BarImgChkBox.Name = "BarImgChkBox"
            Me.BarImgChkBox.Size = New System.Drawing.Size(106, 17)
            Me.BarImgChkBox.TabIndex = 3
            Me.BarImgChkBox.Text = "Show BarImages"
            Me.BarImgChkBox.UseVisualStyleBackColor = False
            AddHandler Me.BarImgChkBox.CheckedChanged, AddressOf Me.BarImgChkBox_CheckedChanged
            ' 
            ' CutmBtnChkBox
            ' 
            Me.CutmBtnChkBox.AutoSize = True
            Me.CutmBtnChkBox.BackColor = System.Drawing.Color.Transparent
            Me.CutmBtnChkBox.Checked = True
            Me.CutmBtnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CutmBtnChkBox.Location = New System.Drawing.Point(4, 134)
            Me.CutmBtnChkBox.Name = "CutmBtnChkBox"
            Me.CutmBtnChkBox.Size = New System.Drawing.Size(125, 17)
            Me.CutmBtnChkBox.TabIndex = 2
            Me.CutmBtnChkBox.Text = "Show Custom Button"
            Me.CutmBtnChkBox.UseVisualStyleBackColor = False
            AddHandler Me.CutmBtnChkBox.CheckedChanged, AddressOf Me.CutmBtnChkBox_CheckedChanged
            ' 
            ' HisbtnChkBox
            ' 
            Me.HisbtnChkBox.AutoSize = True
            Me.HisbtnChkBox.BackColor = System.Drawing.Color.Transparent
            Me.HisbtnChkBox.Checked = True
            Me.HisbtnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.HisbtnChkBox.Location = New System.Drawing.Point(7, 48)
            Me.HisbtnChkBox.Name = "HisbtnChkBox"
            Me.HisbtnChkBox.Size = New System.Drawing.Size(127, 17)
            Me.HisbtnChkBox.TabIndex = 0
            Me.HisbtnChkBox.Text = "Show History Buttons"
            Me.HisbtnChkBox.UseVisualStyleBackColor = False
            AddHandler Me.HisbtnChkBox.CheckedChanged, AddressOf Me.HisbtnChkBox_CheckedChanged
            ' 
            ' VisStyleCmbBox
            ' 
            Me.VisStyleCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.VisStyleCmbBox.FormattingEnabled = True
            Me.VisStyleCmbBox.Items.AddRange(New Object() {"VistaStyle", "Office2007Style"})
            Me.VisStyleCmbBox.Location = New System.Drawing.Point(3, 97)
            Me.VisStyleCmbBox.Name = "VisStyleCmbBox"
            Me.VisStyleCmbBox.Size = New System.Drawing.Size(121, 21)
            Me.VisStyleCmbBox.TabIndex = 6
            AddHandler Me.VisStyleCmbBox.SelectedIndexChanged, AddressOf Me.VisStyleCmbBox_SelectedIndexChanged
            ' 
            ' listView1
            ' 
            Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listView1.LargeImageList = Me.imageList1
            Me.listView1.Location = New System.Drawing.Point(0, 28)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(565, 366)
            Me.listView1.TabIndex = 33
            Me.listView1.UseCompatibleStateImageBehavior = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(567, 396)
            Me.Controls.Add(Me.gradientPanel2)
            Me.Icon = DirectCast((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.Text = "Navigation View"
            AddHandler Me.Load, AddressOf Me.Form1_Load
            DirectCast((Me.navigationView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationView1.ResumeLayout(False)
            DirectCast((Me.gradientPanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            DirectCast((Me.xpTaskBar1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar1.ResumeLayout(False)
            Me.xpTaskBarBox2.ResumeLayout(False)
            DirectCast((Me.gradientPanel4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.gradientPanel4.PerformLayout()
            Me.ResumeLayout(False)
            
        End Sub
        
        #End Region
        
        Private navigationView1 As Syncfusion.Windows.Forms.Tools.NavigationView
        Private imageList1 As System.Windows.Forms.ImageList
        Private customButton1 As Syncfusion.Windows.Forms.Tools.Navigation.CustomButton
        Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private listView1 As System.Windows.Forms.ListView
        Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
        Private xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private HistorycheckBox As System.Windows.Forms.CheckBox
        Private label1 As System.Windows.Forms.Label
        Private RTLChkBox As System.Windows.Forms.CheckBox
        Private BarImgChkBox As System.Windows.Forms.CheckBox
        Private CutmBtnChkBox As System.Windows.Forms.CheckBox
        Private HisbtnChkBox As System.Windows.Forms.CheckBox
        Private VisStyleCmbBox As System.Windows.Forms.ComboBox
    End Class
    
End Namespace

