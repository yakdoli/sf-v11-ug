Imports Microsoft.VisualBasic
Imports System
Namespace TileLayoutDemo_2008
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.tileLayout1 = New Syncfusion.Windows.Forms.Tools.TileLayout()
			Me.layoutGroup1 = New Syncfusion.Windows.Forms.Tools.LayoutGroup()
			Me.imageStreamer1 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer2 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer3 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer4 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer5 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer6 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer7 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer8 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer9 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.layoutGroup2 = New Syncfusion.Windows.Forms.Tools.LayoutGroup()
			Me.imageStreamer10 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer11 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer12 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer13 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer14 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.imageStreamer15 = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.panel8 = New System.Windows.Forms.Panel()
			Me.label4 = New System.Windows.Forms.Label()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.panel11 = New System.Windows.Forms.Panel()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.panel9 = New System.Windows.Forms.Panel()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.panel10 = New System.Windows.Forms.Panel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			CType(Me.tileLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tileLayout1.SuspendLayout()
			CType(Me.layoutGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutGroup1.SuspendLayout()
			CType(Me.layoutGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutGroup2.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel8.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.panel11.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel4.SuspendLayout()
			Me.panel5.SuspendLayout()
			Me.panel9.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel7.SuspendLayout()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel10.SuspendLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tileLayout1
			' 
			Me.tileLayout1.AllowNewGroup = False
			Me.tileLayout1.AutoScroll = True
			Me.tileLayout1.BackColor = System.Drawing.Color.Black
			Me.tileLayout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.tileLayout1.BorderColor = System.Drawing.Color.BlanchedAlmond
			Me.tileLayout1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.tileLayout1.Controls.Add(Me.layoutGroup1)
			Me.tileLayout1.Controls.Add(Me.layoutGroup2)
			Me.tileLayout1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tileLayout1.ExitButtonImage = Nothing
			Me.tileLayout1.Font = New System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			CType(New Syncfusion.Windows.Forms.Tools.TileGroupCollection(), Syncfusion.Windows.Forms.Tools.TileGroupCollection).AddRange(New Syncfusion.Windows.Forms.Tools.LayoutGroup() { Me.layoutGroup1, Me.layoutGroup2})
			Me.tileLayout1.Items = 0
			Me.tileLayout1.Location = New System.Drawing.Point(0, 0)
			Me.tileLayout1.Name = "tileLayout1"
			Me.tileLayout1.NewGroupButtonImage = Nothing
			Me.tileLayout1.NewGroupIndicatorColor = System.Drawing.Color.Black
			Me.tileLayout1.SetParentFormFlat = False
            Me.tileLayout1.ShowGroupTitle = False
			Me.tileLayout1.ShowItemPreview = False
			Me.tileLayout1.ShowPreviewButtonImage = Nothing
			Me.tileLayout1.Size = New System.Drawing.Size(1039, 626)
			Me.tileLayout1.TabIndex = 0
			Me.tileLayout1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.tileLayout1.TitleFont = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tileLayout1.Transparency = 10
'			Me.tileLayout1.MouseEnter += New System.EventHandler(Me.tileLayout1_MouseEnter)
'			Me.tileLayout1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.tileLayout1_MouseMove)
'			Me.tileLayout1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.tileLayout1_MouseDown)
			' 
			' layoutGroup1
			' 
			Me.layoutGroup1.BackColor = System.Drawing.Color.Transparent
			Me.layoutGroup1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.layoutGroup1.Controls.Add(Me.imageStreamer1)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer2)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer3)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer4)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer5)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer6)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer7)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer8)
			Me.layoutGroup1.Controls.Add(Me.imageStreamer9)
			Me.layoutGroup1.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            CType(New Syncfusion.Windows.Forms.Tools.ImageStreamerCollection(), Syncfusion.Windows.Forms.Tools.ImageStreamerCollection).AddRange(New Syncfusion.Windows.Forms.Tools.ImageStreamer() {Me.imageStreamer1, Me.imageStreamer2, Me.imageStreamer3, Me.imageStreamer4, Me.imageStreamer5, Me.imageStreamer6, Me.imageStreamer7, Me.imageStreamer8, Me.imageStreamer9})
			Me.layoutGroup1.Location = New System.Drawing.Point(100, 116)
			Me.layoutGroup1.Name = "layoutGroup1"
			Me.layoutGroup1.SetItem = True
			Me.layoutGroup1.Size = New System.Drawing.Size(515, 476)
			Me.layoutGroup1.TabIndex = 0
			' 
			' imageStreamer1
			' 
			Me.imageStreamer1.Images = (CType(resources.GetObject("imageStreamer1.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer1.InternalBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.imageStreamer1.Location = New System.Drawing.Point(5, 0)
			Me.imageStreamer1.Name = "imageStreamer1"
			Me.imageStreamer1.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer1.TabIndex = 0
			Me.imageStreamer1.Text = "imageStreamer1"
			' 
			' imageStreamer2
			' 
			Me.imageStreamer2.Images = (CType(resources.GetObject("imageStreamer2.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer2.InternalBackColor = System.Drawing.Color.Yellow
			Me.imageStreamer2.Location = New System.Drawing.Point(130, 0)
			Me.imageStreamer2.Name = "imageStreamer2"
			Me.imageStreamer2.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer2.TabIndex = 1
			Me.imageStreamer2.Text = "imageStreamer2"
			' 
			' imageStreamer3
			' 
			Me.imageStreamer3.Images = (CType(resources.GetObject("imageStreamer3.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer3.InternalBackColor = System.Drawing.Color.Red
			Me.imageStreamer3.Location = New System.Drawing.Point(5, 125)
			Me.imageStreamer3.Name = "imageStreamer3"
			Me.imageStreamer3.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer3.TabIndex = 2
			Me.imageStreamer3.Text = "imageStreamer3"
			' 
			' imageStreamer4
			' 
			Me.imageStreamer4.Images = (CType(resources.GetObject("imageStreamer4.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer4.InternalBackColor = System.Drawing.Color.Navy
			Me.imageStreamer4.Location = New System.Drawing.Point(130, 125)
			Me.imageStreamer4.Name = "imageStreamer4"
			Me.imageStreamer4.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer4.TabIndex = 3
			Me.imageStreamer4.Text = "imageStreamer4"
			' 
			' imageStreamer5
			' 
			Me.imageStreamer5.Images = (CType(resources.GetObject("imageStreamer5.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer5.InternalBackColor = System.Drawing.Color.Fuchsia
			Me.imageStreamer5.Location = New System.Drawing.Point(5, 250)
			Me.imageStreamer5.Name = "imageStreamer5"
			Me.imageStreamer5.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer5.TabIndex = 4
			Me.imageStreamer5.Text = "imageStreamer5"
			' 
			' imageStreamer6
			' 
			Me.imageStreamer6.Images = (CType(resources.GetObject("imageStreamer6.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer6.InternalBackColor = System.Drawing.Color.Maroon
			Me.imageStreamer6.Location = New System.Drawing.Point(130, 250)
			Me.imageStreamer6.Name = "imageStreamer6"
			Me.imageStreamer6.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer6.TabIndex = 5
			Me.imageStreamer6.Text = "imageStreamer6"
			' 
			' imageStreamer7
			' 
			Me.imageStreamer7.Images = (CType(resources.GetObject("imageStreamer7.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer7.InternalBackColor = System.Drawing.Color.Olive
			Me.imageStreamer7.Location = New System.Drawing.Point(255, 0)
			Me.imageStreamer7.Name = "imageStreamer7"
			Me.imageStreamer7.Size = New System.Drawing.Size(245, 120)
			Me.imageStreamer7.TabIndex = 6
			Me.imageStreamer7.Text = "imageStreamer7"
            Me.imageStreamer7.Type = Syncfusion.Windows.Forms.Tools.ImageStreamer.ImageStreamerType.DoubleHorizontal
			' 
			' imageStreamer8
			' 
			Me.imageStreamer8.Images = (CType(resources.GetObject("imageStreamer8.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer8.InternalBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.imageStreamer8.Location = New System.Drawing.Point(255, 125)
			Me.imageStreamer8.Name = "imageStreamer8"
			Me.imageStreamer8.Size = New System.Drawing.Size(245, 120)
			Me.imageStreamer8.TabIndex = 7
			Me.imageStreamer8.Text = "imageStreamer8"
            Me.imageStreamer8.Type = Syncfusion.Windows.Forms.Tools.ImageStreamer.ImageStreamerType.DoubleHorizontal
			' 
			' imageStreamer9
			' 
			Me.imageStreamer9.Images = (CType(resources.GetObject("imageStreamer9.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer9.InternalBackColor = System.Drawing.Color.Silver
			Me.imageStreamer9.Location = New System.Drawing.Point(255, 250)
			Me.imageStreamer9.Name = "imageStreamer9"
			Me.imageStreamer9.Size = New System.Drawing.Size(245, 120)
			Me.imageStreamer9.TabIndex = 8
			Me.imageStreamer9.Text = "imageStreamer9"
            Me.imageStreamer9.Type = Syncfusion.Windows.Forms.Tools.ImageStreamer.ImageStreamerType.DoubleHorizontal
			' 
			' layoutGroup2
			' 
			Me.layoutGroup2.BackColor = System.Drawing.Color.Transparent
			Me.layoutGroup2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.layoutGroup2.Controls.Add(Me.imageStreamer10)
			Me.layoutGroup2.Controls.Add(Me.imageStreamer11)
			Me.layoutGroup2.Controls.Add(Me.imageStreamer12)
			Me.layoutGroup2.Controls.Add(Me.imageStreamer13)
			Me.layoutGroup2.Controls.Add(Me.imageStreamer14)
			Me.layoutGroup2.Controls.Add(Me.imageStreamer15)
			Me.layoutGroup2.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            CType(New Syncfusion.Windows.Forms.Tools.ImageStreamerCollection(), Syncfusion.Windows.Forms.Tools.ImageStreamerCollection).AddRange(New Syncfusion.Windows.Forms.Tools.ImageStreamer() {Me.imageStreamer10, Me.imageStreamer11, Me.imageStreamer12, Me.imageStreamer13, Me.imageStreamer14, Me.imageStreamer15})
			Me.layoutGroup2.Location = New System.Drawing.Point(690, 116)
			Me.layoutGroup2.Name = "layoutGroup2"
			Me.layoutGroup2.SetItem = True
			Me.layoutGroup2.Size = New System.Drawing.Size(515, 476)
			Me.layoutGroup2.TabIndex = 1
			' 
			' imageStreamer10
			' 
			Me.imageStreamer10.Images = (CType(resources.GetObject("imageStreamer10.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer10.InternalBackColor = System.Drawing.Color.Green
			Me.imageStreamer10.Location = New System.Drawing.Point(5, 0)
			Me.imageStreamer10.Name = "imageStreamer10"
			Me.imageStreamer10.Size = New System.Drawing.Size(245, 120)
			Me.imageStreamer10.TabIndex = 0
			Me.imageStreamer10.Text = "imageStreamer10"
            Me.imageStreamer10.Type = Syncfusion.Windows.Forms.Tools.ImageStreamer.ImageStreamerType.DoubleHorizontal
			' 
			' imageStreamer11
			' 
			Me.imageStreamer11.Images = (CType(resources.GetObject("imageStreamer11.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer11.InternalBackColor = System.Drawing.Color.White
			Me.imageStreamer11.Location = New System.Drawing.Point(5, 125)
			Me.imageStreamer11.Name = "imageStreamer11"
			Me.imageStreamer11.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer11.TabIndex = 1
			Me.imageStreamer11.Text = "imageStreamer11"
			' 
			' imageStreamer12
			' 
			Me.imageStreamer12.Images = (CType(resources.GetObject("imageStreamer12.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer12.InternalBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
			Me.imageStreamer12.Location = New System.Drawing.Point(130, 125)
			Me.imageStreamer12.Name = "imageStreamer12"
			Me.imageStreamer12.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer12.TabIndex = 2
			Me.imageStreamer12.Text = "imageStreamer12"
			' 
			' imageStreamer13
			' 
			Me.imageStreamer13.Images = (CType(resources.GetObject("imageStreamer13.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer13.InternalBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			Me.imageStreamer13.Location = New System.Drawing.Point(5, 250)
			Me.imageStreamer13.Name = "imageStreamer13"
			Me.imageStreamer13.Size = New System.Drawing.Size(245, 120)
			Me.imageStreamer13.TabIndex = 3
			Me.imageStreamer13.Text = "imageStreamer13"
            Me.imageStreamer13.Type = Syncfusion.Windows.Forms.Tools.ImageStreamer.ImageStreamerType.DoubleHorizontal
			' 
			' imageStreamer14
			' 
			Me.imageStreamer14.Images = (CType(resources.GetObject("imageStreamer14.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer14.InternalBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))))
			Me.imageStreamer14.Location = New System.Drawing.Point(255, 0)
			Me.imageStreamer14.Name = "imageStreamer14"
			Me.imageStreamer14.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer14.TabIndex = 4
			Me.imageStreamer14.Text = "imageStreamer14"
			' 
			' imageStreamer15
			' 
			Me.imageStreamer15.Images = (CType(resources.GetObject("imageStreamer15.Images"), System.Collections.Generic.List(Of System.Drawing.Image)))
			Me.imageStreamer15.InternalBackColor = System.Drawing.Color.Teal
			Me.imageStreamer15.Location = New System.Drawing.Point(380, 0)
			Me.imageStreamer15.Name = "imageStreamer15"
			Me.imageStreamer15.Size = New System.Drawing.Size(120, 120)
			Me.imageStreamer15.TabIndex = 5
			Me.imageStreamer15.Text = "imageStreamer15"
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.BackColor = System.Drawing.Color.Black
			Me.panel1.Location = New System.Drawing.Point(863, 15)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(84, 76)
			Me.panel1.TabIndex = 1
'			Me.panel1.MouseLeave += New System.EventHandler(Me.panel1_MouseLeave)
'			Me.panel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.panel1_Paint)
'			Me.panel1.MouseEnter += New System.EventHandler(Me.panel1_MouseEnter)
			' 
			' panel2
			' 
			Me.panel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel2.BackColor = System.Drawing.Color.Teal
			Me.panel2.Controls.Add(Me.panel8)
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1039, 125)
			Me.panel2.TabIndex = 2
'			Me.panel2.MouseEnter += New System.EventHandler(Me.panel2_MouseEnter_1)
			' 
			' panel8
			' 
			Me.panel8.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel8.Controls.Add(Me.label4)
			Me.panel8.Location = New System.Drawing.Point(914, 8)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New System.Drawing.Size(113, 103)
			Me.panel8.TabIndex = 2
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.Color.White
			Me.label4.Location = New System.Drawing.Point(26, 62)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(28, 15)
			Me.label4.TabIndex = 5
			Me.label4.Text = "Exit"
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.pictureBox2.Location = New System.Drawing.Point(951, 27)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(86, 79)
			Me.pictureBox2.TabIndex = 0
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.MouseLeave += New System.EventHandler(Me.pictureBox2_MouseLeave)
'			Me.pictureBox2.Click += New System.EventHandler(Me.pictureBox2_Click)
'			Me.pictureBox2.MouseEnter += New System.EventHandler(Me.pictureBox2_MouseEnter)
			' 
			' panel3
			' 
			Me.panel3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel3.BackColor = System.Drawing.Color.Teal
			Me.panel3.Controls.Add(Me.panel11)
			Me.panel3.Controls.Add(Me.panel4)
			Me.panel3.Controls.Add(Me.panel9)
			Me.panel3.Controls.Add(Me.panel7)
			Me.panel3.Controls.Add(Me.panel10)
			Me.panel3.Location = New System.Drawing.Point(0, 503)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(1039, 125)
			Me.panel3.TabIndex = 3
'			Me.panel3.Click += New System.EventHandler(Me.panel3_Click)
'			Me.panel3.MouseEnter += New System.EventHandler(Me.panel2_MouseEnter_1)
			' 
			' panel11
			' 
			Me.panel11.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel11.Controls.Add(Me.pictureBox5)
			Me.panel11.Controls.Add(Me.label5)
			Me.panel11.Location = New System.Drawing.Point(640, 2)
			Me.panel11.Name = "panel11"
			Me.panel11.Size = New System.Drawing.Size(122, 109)
			Me.panel11.TabIndex = 5
'			Me.panel11.Click += New System.EventHandler(Me.panel9_Click)
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Location = New System.Drawing.Point(26, 5)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(83, 54)
			Me.pictureBox5.TabIndex = 4
			Me.pictureBox5.TabStop = False
'			Me.pictureBox5.Click += New System.EventHandler(Me.pictureBox5_Click)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.ForeColor = System.Drawing.Color.White
			Me.label5.Location = New System.Drawing.Point(3, 58)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(108, 15)
			Me.label5.TabIndex = 2
			Me.label5.Text = "BackGround Color"
			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.Teal
			Me.panel4.Controls.Add(Me.label1)
			Me.panel4.Controls.Add(Me.panel5)
			Me.panel4.Location = New System.Drawing.Point(61, 0)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(216, 122)
			Me.panel4.TabIndex = 1
			Me.panel4.Visible = False
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(3, 4)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(101, 15)
			Me.label1.TabIndex = 1
			Me.label1.Text = "BackGroud Color"
			' 
			' panel5
			' 
			Me.panel5.AutoScroll = True
			Me.panel5.Controls.Add(Me.panel6)
			Me.panel5.Location = New System.Drawing.Point(0, 24)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(213, 87)
			Me.panel5.TabIndex = 0
			' 
			' panel6
			' 
			Me.panel6.Location = New System.Drawing.Point(3, -2)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(191, 131)
			Me.panel6.TabIndex = 0
			' 
			' panel9
			' 
			Me.panel9.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel9.Controls.Add(Me.pictureBox4)
			Me.panel9.Controls.Add(Me.label2)
			Me.panel9.Location = New System.Drawing.Point(509, 2)
			Me.panel9.Name = "panel9"
			Me.panel9.Size = New System.Drawing.Size(122, 109)
			Me.panel9.TabIndex = 3
'			Me.panel9.Click += New System.EventHandler(Me.panel9_Click)
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Location = New System.Drawing.Point(24, 5)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(83, 54)
			Me.pictureBox4.TabIndex = 4
			Me.pictureBox4.TabStop = False
'			Me.pictureBox4.Click += New System.EventHandler(Me.pictureBox4_Click)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(-3, 58)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(107, 15)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Current Structure"
			' 
			' panel7
			' 
			Me.panel7.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel7.Controls.Add(Me.checkBoxAdv1)
			Me.panel7.Controls.Add(Me.pictureBox1)
			Me.panel7.Location = New System.Drawing.Point(777, 1)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(127, 109)
			Me.panel7.TabIndex = 2
'			Me.panel7.Click += New System.EventHandler(Me.panel7_Click)
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.DrawFocusRectangle = False
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv1.ForeColor = System.Drawing.Color.White
			Me.checkBoxAdv1.Location = New System.Drawing.Point(-3, 55)
			Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Size = New System.Drawing.Size(110, 19)
			Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv1.TabIndex = 4
			Me.checkBoxAdv1.Text = "Show Preview"
			Me.checkBoxAdv1.ThemesEnabled = False
'			Me.checkBoxAdv1.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv1_CheckStateChanged)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Location = New System.Drawing.Point(22, 5)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(83, 54)
			Me.pictureBox1.TabIndex = 3
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
			' 
			' panel10
			' 
			Me.panel10.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel10.Controls.Add(Me.label3)
			Me.panel10.Controls.Add(Me.pictureBox3)
			Me.panel10.Location = New System.Drawing.Point(910, 1)
			Me.panel10.Name = "panel10"
			Me.panel10.Size = New System.Drawing.Size(127, 109)
			Me.panel10.TabIndex = 4
'			Me.panel10.Click += New System.EventHandler(Me.panel7_Click)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.White
			Me.label3.Location = New System.Drawing.Point(8, 59)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(79, 15)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Refresh Tiles"
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Location = New System.Drawing.Point(20, 5)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(83, 52)
			Me.pictureBox3.TabIndex = 3
			Me.pictureBox3.TabStop = False
'			Me.pictureBox3.Click += New System.EventHandler(Me.pictureBox3_Click_1)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1039, 626)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.pictureBox2)
			Me.Controls.Add(Me.tileLayout1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.tileLayout1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tileLayout1.ResumeLayout(False)
			CType(Me.layoutGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutGroup1.ResumeLayout(False)
			CType(Me.layoutGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutGroup2.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel8.ResumeLayout(False)
			Me.panel8.PerformLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.panel11.ResumeLayout(False)
			Me.panel11.PerformLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel4.ResumeLayout(False)
			Me.panel4.PerformLayout()
			Me.panel5.ResumeLayout(False)
			Me.panel9.ResumeLayout(False)
			Me.panel9.PerformLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel7.ResumeLayout(False)
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel10.ResumeLayout(False)
			Me.panel10.PerformLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents tileLayout1 As Syncfusion.Windows.Forms.Tools.TileLayout
		Private layoutGroup1 As Syncfusion.Windows.Forms.Tools.LayoutGroup
		Private imageStreamer1 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer2 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer3 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer4 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer5 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer6 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer7 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer8 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer9 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private layoutGroup2 As Syncfusion.Windows.Forms.Tools.LayoutGroup
		Private imageStreamer10 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer11 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer12 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer13 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer14 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private imageStreamer15 As Syncfusion.Windows.Forms.Tools.ImageStreamer
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private WithEvents panel2 As System.Windows.Forms.Panel
		Private WithEvents panel3 As System.Windows.Forms.Panel
		Private panel8 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private panel5 As System.Windows.Forms.Panel
		Private panel6 As System.Windows.Forms.Panel
		Private WithEvents panel7 As System.Windows.Forms.Panel
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents panel9 As System.Windows.Forms.Panel
		Private label2 As System.Windows.Forms.Label
		Private WithEvents panel10 As System.Windows.Forms.Panel
		Private label3 As System.Windows.Forms.Label
		Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
		Private label4 As System.Windows.Forms.Label
		Private WithEvents panel11 As System.Windows.Forms.Panel
		Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
	End Class
End Namespace

