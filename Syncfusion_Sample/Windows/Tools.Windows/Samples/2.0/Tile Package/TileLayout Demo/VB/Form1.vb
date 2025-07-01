Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports EnvDTE
Imports System.Diagnostics
Imports System.IO
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace TileLayoutDemo_2008
	Partial Public Class Form1
		Inherits Form
		Private imagePath As String = Application.StartupPath
		Public Sub New()
			InitializeComponent()
			AddHandler Activated, AddressOf Form1_Activated
			Me.tileLayout1.Text = "Start"
            Me.tileLayout1.ForeColor = Drawing.Color.White
			getImageStreamers()
            Me.tileLayout1.NewGroupIndicatorColor = Drawing.Color.White
            'Me.tileLayout1.ExitButtonImage = Image.FromFile(imagePath & "Close.png")
            'Me.tileLayout1.ShowPreviewButtonImage = Image.FromFile(imagePath & "Selection.png")
            'Me.tileLayout1.NewGroupButtonImage = Image.FromFile(imagePath & "Pause.png")
			Dim time As New Timer()
			time.Interval = 1000
			time.Start()
			AddHandler time.Tick, AddressOf time_Tick
			AddHandler openMenu.Tick, AddressOf t_Tick
			AddHandler CloseMenu.Tick, AddressOf CloseMenu_Tick
			Me.openMenu.Interval = 10
			Me.CloseMenu.Interval = 10
			Me.panel2.Height = 0
			Me.panel3.Height = 0
			AddHandler panel1.Click, AddressOf panel1_Click

			AddHandler panel2.MouseLeave, AddressOf panel2_MouseLeave
			AddHandler panel3.MouseLeave, AddressOf panel2_MouseLeave

			AddHandler panel2.MouseEnter, AddressOf panel2_MouseEnter

			Me.layoutGroup1.Text = "Group 1"
			Me.layoutGroup2.Text = "Group 2"

            color.Style = ColorPickerUIAdv.visualstyle.Metro
			Me.panel6.Controls.Add(color)
			color.Location = New Point(0, -40)
			color.Size = New Size(210, 195)
			color.BackColor = Me.panel2.BackColor
			AddHandler color.Picked, AddressOf color_Picked

			Dim scroll As New ScrollersFrame()
			scroll.VisualStyle = ScrollBarCustomDrawStyles.Metro
			scroll.AttachedTo = Me.panel5

			AddHandler treeViewAdv1.Click, AddressOf treeViewAdv1_Click
			treeViewAdv1.Style = TreeStyle.Metro
		  '  this.panel9.Controls.Add(treeViewAdv1);
			treeViewAdv1.Size = New Size(panel9.Width, panel9.Height - 15)
			treeViewAdv1.Location = New Point(0, 15)

			popup.Size = New Size(200, 400)


		   ' panel11.Width  = 200;

			pic.Dock = DockStyle.Fill
			Dim scroll1 As New ScrollersFrame()
			scroll1.VisualStyle = ScrollBarCustomDrawStyles.Metro
			scroll1.AttachedTo = propertyGrid1
			Dim flowLayout As New FlowLayout()
			'flowLayout.ContainerControl = this.panel3;
			flowLayout.HGap = 150
			Me.checkBoxAdv1.Checked = True
			AddHandler popupOpen.Tick, AddressOf popupOpen_Tick
			AddHandler popupClose.Tick, AddressOf popupClose_Tick

			popupOpen.Interval = 10
		End Sub

		Private popup As New Panel()

		Private Sub popupClose_Tick(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

'INSTANT VB NOTE: The variable left was renamed since Visual Basic does not allow class members with the same name:
		Private left_Renamed As Integer = 0
		Private Sub popupOpen_Tick(ByVal sender As Object, ByVal e As EventArgs)
			popup.Left = left_Renamed

			If popup.Top > (Me.panel3.Top - popup.Height +10) Then
				popup.Top = popup.Top - 10
			Else
			   ' popup.Top = popup.Top + 10;
				popupOpen.Stop()
			End If

		End Sub
		Private popupOpen As New Timer()
		Private popupClose As New Timer()

		Private imageStreamer As New ImageStreamer()
		Private pic As New PictureBox()
		Private propertyGrid1 As New PropertyGrid()

		Private Sub treeViewAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
		Private color As New ColorPickerUIAdv()
		Private Sub color_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			Me.tileLayout1.BackColor = color.SelectedColor
			Me.panel1.BackColor = color.SelectedColor
			Me.pictureBox2.BackColor = Me.panel1.BackColor
            If color.SelectedColor <> Drawing.Color.Black Then
                Me.checkBoxAdv1.MetroColor = ControlPaint.Dark(color.SelectedColor)
                Me.panel4.BackColor = Me.checkBoxAdv1.MetroColor
                Me.panel3.BackColor = Me.panel4.BackColor
                Me.panel2.BackColor = Me.panel3.BackColor
            Else
                Me.checkBoxAdv1.MetroColor = Drawing.Color.Teal
                Me.panel4.BackColor = Me.checkBoxAdv1.MetroColor
                Me.panel3.BackColor = Me.panel4.BackColor
                Me.panel2.BackColor = Me.panel3.BackColor
            End If
		End Sub

		Private Sub panel2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
		End Sub



		Private Sub panel2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
		   ' this.CloseMenu.Start();
		End Sub

		Private Sub panel1_Click(ByVal sender As Object, ByVal e As EventArgs)
			getTreeView()
			canClose = False
			Me.openMenu.Start()
		End Sub

		Private Sub CloseMenu_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If Me.panel2.Height > 5 Then
				Me.panel2.Height = Me.panel2.Height - 10
				Me.panel3.Height = Me.panel3.Height - 10
				Me.panel3.Top = Me.Bottom - Me.panel3.Height
			Else
				Me.CloseMenu.Stop()
			End If


		End Sub

		Private openMenu As New Timer()
		Private CloseMenu As New Timer()

		Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If Me.panel2.Height < 72 Then
				Me.panel2.Height = Me.panel2.Height + 10
				Me.panel3.Height = Me.panel3.Height + 10
				Me.panel3.Top = Me.Bottom - Me.panel3.Height
			Else
				Me.openMenu.Stop()
			End If

		End Sub

		Protected Function PreFilterMessage(ByVal msg As Message) As Boolean
			Return True
		End Function


		Public Overrides Function PreProcessMessage(ByRef msg As Message) As Boolean
			Return MyBase.PreProcessMessage(msg)
		End Function

		Private Sub time_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim time As String = Convert.ToString (DateTime.Now.TimeOfDay)
			time = time.Remove(7, time.Length - 8)
			Me.imageStreamer6.SubText.Text = time



		End Sub

		Private Sub Form1_Activated(ByVal sender As Object, ByVal e As EventArgs)
			Me.tileLayout1.SetParentFormFlat = True
			'this.tileLayout1.AllowNewGroup = true;
			'this.tileLayout1.NewGroupIndicatorColor = Color.White;
			'this.tileLayout1.ShowItemPreview = true;
		End Sub
		Private Sub getImageStreamers()
			'ImageStreamer1

			imagePath = imagePath.Replace("\Release", "")
			imagePath = imagePath.Replace("\Debug", "")
			imagePath = imagePath.Replace("\bin", "")
			imagePath = imagePath.Replace("\", "/")
			imagePath = imagePath & "/Images/"
			Me.imageStreamer1.Images.Add(Image.FromFile(imagePath & "Computer.png"))
			'this.imageStreamer1.Images.Add(Image.FromFile(imagePath + "Computer.png"));
			'this.imageStreamer1.Images.Add(Image.FromFile(imagePath + "Computer.png"));
            Me.imageStreamer1.BackColor = Drawing.Color.DarkCyan
			Me.imageStreamer1.SubText.Text = "My Computer"
			AddHandler imageStreamer1.Click, AddressOf imageStreamer1_Click

			'ImageStreamer2

			AddHandler imageStreamer2.Click, AddressOf imageStreamer2_Click
			Me.imageStreamer2.Images.Add(Image.FromFile(imagePath & "Calculation.png"))
			Me.imageStreamer2.Images.Add(Image.FromFile(imagePath & "Calculation.png"))
			Me.imageStreamer2.Images.Add(Image.FromFile(imagePath & "Calculation.png"))
            Me.imageStreamer2.BackColor = Drawing.Color.LawnGreen
			Me.imageStreamer2.SubText.Text = "Calculator"

			'ImageStreamer3
			Me.imageStreamer3.Images.Add(Image.FromFile(imagePath & "Window-Color.png"))
			Me.imageStreamer3.Images.Add(Image.FromFile(imagePath & "Window-Color.png"))
			Me.imageStreamer3.Images.Add(Image.FromFile(imagePath & "Window-Color.png"))
			AddHandler imageStreamer3.Click, AddressOf imageStreamer3_Click
			Me.imageStreamer3.SubText.Text = "Paint"

			'ImageStreamer4
			Me.imageStreamer4.Images.Add(Image.FromFile(imagePath & "Note.png"))
			Me.imageStreamer4.Images.Add(Image.FromFile(imagePath & "Note.png"))
			Me.imageStreamer4.Images.Add(Image.FromFile(imagePath & "Note.png"))
		   AddHandler imageStreamer4.Click, AddressOf imageStreamer4_Click
		   Me.imageStreamer4.SubText.Text = "Notepad"

			'ImageStreamer5
		   Me.imageStreamer5.Images.Add(Image.FromFile(imagePath & "Wrench.png"))
		   Me.imageStreamer5.Images.Add(Image.FromFile(imagePath & "Wrench.png"))
		   Me.imageStreamer5.Images.Add(Image.FromFile(imagePath & "Wrench.png"))
		   Me.imageStreamer5.SubText.Text = "Pgm Seting"
		   AddHandler imageStreamer5.Click, AddressOf imageStreamer5_Click

			'ImageStreamer6
			Me.imageStreamer6.Images.Add(Image.FromFile(imagePath & "Clock.png"))
			Me.imageStreamer6.Images.Add(Image.FromFile(imagePath & "Clock.png"))
			Me.imageStreamer6.Images.Add(Image.FromFile(imagePath & "Clock.png"))
		   AddHandler imageStreamer6.Click, AddressOf imageStreamer6_Click


			'ImageStreamer7
		   Me.imageStreamer7.Images.Add(Image.FromFile(imagePath & "5.png"))
		   Me.imageStreamer7.Images.Add(Image.FromFile(imagePath & "5.png"))
		   Me.imageStreamer7.Images.Add(Image.FromFile(imagePath & "5.png"))
		   AddHandler imageStreamer7.Click, AddressOf imageStreamer7_Click
		   Me.imageStreamer7.SubText.Text = "Desktop"
		   Me.imageStreamer7.SubText.Visible = False

			'ImageStreamer8
		   Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "1.png"))
		   Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "2.png"))
		   Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "3.png"))
		 '  this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "4.png"));
			Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "1.png"))
			Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "2.png"))
			Me.imageStreamer8.Images.Add(Image.FromFile(imagePath & "3.png"))
		 '   this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "4.png"));
			Me.imageStreamer8.ImageStreamDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.StreamDirection.BottomToTop
			Me.imageStreamer8.SlideShow = True
			Me.imageStreamer8.SliderSpeed = 2500
			AddHandler imageStreamer8.Click, AddressOf imageStreamer8_Click
			Me.imageStreamer8.SubText.Text = "Option"
			Me.imageStreamer8.SubText.Visible = False
			'ImageStreamer9
			Me.imageStreamer9.Images.Add(Image.FromFile(imagePath & "Wikimapia.png"))
			Me.imageStreamer9.Images.Add(Image.FromFile(imagePath & "Wikimapia.png"))
			Me.imageStreamer9.Images.Add(Image.FromFile(imagePath & "Wikimapia.png"))
			Me.imageStreamer9.SubText.Text = "Maps"
			AddHandler imageStreamer9.Click, AddressOf imageStreamer9_Click

			'ImageStreamer10
			Me.imageStreamer10.Images.Add(Image.FromFile(imagePath & "10.png"))
			Me.imageStreamer10.Images.Add(Image.FromFile(imagePath & "10.png"))
			Me.imageStreamer10.Images.Add(Image.FromFile(imagePath & "10.png"))
			Me.imageStreamer10.SubText.Text = "Music"
			Me.imageStreamer10.SubText.Visible = False
			AddHandler imageStreamer10.Click, AddressOf imageStreamer10_Click

			'ImageStreamer11
			Me.imageStreamer11.Images.Add(Image.FromFile(imagePath & "g.png"))
			Me.imageStreamer11.Images.Add(Image.FromFile(imagePath & "g.png"))
			Me.imageStreamer11.Images.Add(Image.FromFile(imagePath & "g.png"))
			AddHandler imageStreamer11.Click, AddressOf imageStreamer11_Click
			 Me.imageStreamer11.SubText.Text = "Google"
			 Me.imageStreamer11.SubText.Visible = False
			'ImageStreamer12
            Me.imageStreamer12.BackColor = Drawing.Color.DarkOrange
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Knight.png"))
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Rook.png"))
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Knight.png"))
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Rook.png"))
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Knight.png"))
			Me.imageStreamer12.Images.Add(Image.FromFile(imagePath & "Rook.png"))
			Me.imageStreamer12.SlideShow = True
			Me.imageStreamer12.ImageStreamDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.StreamDirection.RightToLeft
			Me.imageStreamer12.SubText.Text = "Games"

			'ImageStreamer13
			Me.imageStreamer13.Images.Add(Image.FromFile(imagePath & "DashBoard.png"))
			Me.imageStreamer13.Images.Add(Image.FromFile(imagePath & "DashBoard.png"))
			Me.imageStreamer13.Images.Add(Image.FromFile(imagePath & "DashBoard.png"))
			Me.imageStreamer13.SubText.Text = "Syncfusion"
			AddHandler imageStreamer13.Click, AddressOf imageStreamer13_Click
			'ImageStreamer14
			Me.imageStreamer14.Images.Add(Image.FromFile(imagePath & "LAN.png"))
			Me.imageStreamer14.Images.Add(Image.FromFile(imagePath & "LAN.png"))
			Me.imageStreamer14.Images.Add(Image.FromFile(imagePath & "LAN.png"))
			Me.imageStreamer14.SubText.Text = "Remote Desktop"
            Me.imageStreamer14.BackColor = Drawing.Color.DarkMagenta
			AddHandler imageStreamer14.Click, AddressOf imageStreamer14_Click


			'ImageStreamer15
			Me.imageStreamer15.Images.Add(Image.FromFile(imagePath & "Command.png"))
			Me.imageStreamer15.Images.Add(Image.FromFile(imagePath & "Command.png"))
			Me.imageStreamer15.Images.Add(Image.FromFile(imagePath & "Command.png"))
			Me.imageStreamer15.SubText.Text = "Cmd Prompt"
            Me.imageStreamer15.BackColor = Drawing.Color.DarkSeaGreen
			AddHandler imageStreamer15.Click, AddressOf imageStreamer15_Click

			Me.pictureBox2.Image = Image.FromFile(imagePath & "Exit.png")
			Me.pictureBox1.Image = Image.FromFile(imagePath & "Preview.png")
			Me.pictureBox4.Image = Image.FromFile(imagePath & "Tree1.png")
			Me.pictureBox5.Image = Image.FromFile(imagePath & "Color.png")
			Me.panel1.BackgroundImage = Image.FromFile(imagePath & "Settings.png")
			Me.panel1.BackgroundImageLayout = ImageLayout.Center
			For Each group As LayoutGroup In Me.tileLayout1.Groups
				Dim node As New TreeNodeAdv(group.Text)
				For Each img As ImageStreamer In group.Items
					img.Refresh()
				Next img
			Next group
			Me.pictureBox3.Image = Image.FromFile(imagePath & "Refresh.png")


		End Sub

		Private Sub imageStreamer13_Click(ByVal sender As Object, ByVal e As EventArgs)


			Dim path As String = Application.StartupPath

			path = path.Replace("\Release", "")
			path = path.Replace("\Debug", "")
			path = path.Replace("\bin", "")
			path = path.Replace("\CS", "")
			path = path.Replace("\VB", "")
			path = path.Replace("\Tools Overview", "")
			path = path.Replace("\Product Showcase", "")
			path = path.Replace("\", "/")

			'string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles );
			'path = path + "/Syncfusion/Essential Studio/";
			'DirectoryInfo di = new DirectoryInfo(path);
			'var directories = di.GetDirectories ("*");
			'string exePath = path;

			'string currentdName = "0";
			'string dir = string.Empty;

			'foreach (DirectoryInfo d in directories)
			'{


			'    string dName = d.Name;

			'    dName = dName.Replace(".", "");
			'    if (Convert.ToInt32(dName) > Convert.ToInt32(currentdName) && dName.Contains("10"))
			'    {
			'        currentdName = dName;
			'        dir = d.Name;
			'    }
			'}

			'path = path;
			'path = path + dir + "/Infrastructure/Dashboard/4.0/Dashboard.exe";
			'path = "C:/Program Files/Syncfusion/Essential Studio/10.4.0.42/Infrastructure/Dashboard/4.0/Dashboard.exe";
			'    path = path.Replace("\\", "/");
			'    using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(path))
			'    {
			'        exeProcess.WaitForExit();
			'    }   
			System.Diagnostics.Process.Start(path)



		End Sub

		Private Sub imageStreamer8_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			System.Diagnostics.Process.Start(path)
		End Sub

		Private Sub imageStreamer14_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("mstsc")

		End Sub

		Private Sub imageStreamer15_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("cmd")

		End Sub

		Private Sub imageStreamer7_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("Desk.cpl")

		End Sub

		Private Sub imageStreamer10_Click(ByVal sender As Object, ByVal e As EventArgs)
		   ' Process.Start(System.Environment.SystemDirectory + @"\appwiz.cpl");
			Dim myMusicPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
					 System.Diagnostics.Process.Start(myMusicPath)
		   ' Process.Start(startInfo);

		End Sub

		Private Sub imageStreamer9_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim proc As New System.Diagnostics.Process()

			proc.EnableRaisingEvents = False


			proc.StartInfo.FileName = "http://maps.google.co.in/maps?hl=en&tab=wl"

			proc.Start()
		End Sub

		Private Sub imageStreamer11_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim proc As New System.Diagnostics.Process()

			proc.EnableRaisingEvents = False


			proc.StartInfo.FileName = "http://www.google.com"

			proc.Start()
		End Sub

		Private Sub imageStreamer1_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("C:\")
		End Sub

		Private Sub imageStreamer6_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("TimeDate.cpl")

		End Sub

		Private Sub imageStreamer5_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("appwiz.cpl")
		End Sub

		Private Sub imageStreamer4_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("notepad")
		End Sub

		Private Sub imageStreamer3_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("mspaint")
		End Sub

		Private Sub imageStreamer2_Click(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("calc")

		End Sub





		Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel1.Paint

		End Sub

		Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.Click
			Me.Dispose()
		End Sub

		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
			Me.tileLayout1.ShowItemPreview = Not Me.tileLayout1.ShowItemPreview
		End Sub

		Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.Click
			Me.checkBoxAdv1.Checked = Not Me.tileLayout1.ShowItemPreview
			popup.Visible = False
		End Sub

		Private Sub tileLayout1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles tileLayout1.MouseEnter


		End Sub

		Private Sub tileLayout1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tileLayout1.MouseMove
		  '  this.CloseMenu.Start ();
		End Sub


		Private canClose As Boolean = False

		Private Sub panel2_MouseEnter_1(ByVal sender As Object, ByVal e As EventArgs) Handles panel2.MouseEnter, panel3.MouseEnter
			canClose = True
		End Sub

		Private Sub tileLayout1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tileLayout1.MouseDown
			popup.Visible = False
			Me.CloseMenu.Start()

		End Sub

		Private treeViewAdv1 As New TreeViewAdv()

		Private Sub getTreeView()
			treeViewAdv1.Nodes.Clear()

			Dim rootNode As New TreeNodeAdv(Me.tileLayout1.Text)
			Me.treeViewAdv1.Nodes.Add(rootNode)
			Me.treeViewAdv1.Refresh()
			Me.tileLayout1.Refresh()
		   For Each group As LayoutGroup In Me.tileLayout1.Controls
			   Dim node As New TreeNodeAdv(group.Text)
			   For Each img As ImageStreamer In group.Controls
				   Dim node1 As New TreeNodeAdv(img.SubText.Text)
				   node.Nodes.Add(node1)
			   Next img
			   rootNode.Nodes.Add(node)
		   Next group




		End Sub

		Private Sub pictureBox3_Click(ByVal sender As Object, ByVal e As EventArgs)
		  '  this.checkBoxAdv2.Checked = !this.checkBoxAdv2.Checked;

		End Sub

		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
			For Each group As LayoutGroup In Me.tileLayout1.Groups
				For Each img As ImageStreamer In group.Items
					'if(img.Text == "SlideShow"|| img.SlideShow )
					'img.SlideShow = this.checkBoxAdv2.Checked;
				Next img
			Next group
		End Sub

		Private Sub pictureBox3_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox3.Click
			popup.Visible = False
			For Each group As LayoutGroup In Me.tileLayout1.Groups
				Dim node As New TreeNodeAdv(group.Text)
				For Each img As ImageStreamer In group.Items
					img.Refresh()
				Next img
			Next group
		End Sub

		Private Sub panel1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles panel1.MouseEnter
			Me.Cursor = Cursors.Hand

		End Sub

		Private Sub panel1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles panel1.MouseLeave
			Me.Cursor = Cursors.Default

		End Sub

		Private Sub pictureBox4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox4.Click
			popup.Visible = False
			Me.popup.Controls.Clear()
			Me.popup.Controls.Add(Me.treeViewAdv1)
			Me.Controls.Add(popup)
			popup.BringToFront()
			panel3.BringToFront()
			Me.popup.Top = panel3.Top
			Me.popup.BackColor = color.SelectedColor

			Me.treeViewAdv1.Dock = DockStyle.Fill
			popup.Height = panel5.Height *2
			Me.popupOpen.Start()
			Me.left_Renamed = panel9.Left -40
			popup.Visible = True

		End Sub

		Private Sub pictureBox5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.Click
			popup.Visible = False
			Me.popup.Controls.Clear()
			Me.popup.Controls.Add(panel6)
			Me.Controls.Add(popup)
			popup.BringToFront()
			panel3.BringToFront()
			Me.popup.Top = panel3.Top
			Me.popup.BackColor = color.SelectedColor
			Me.panel6.BackColor = Me.panel3.BackColor
			popup.Height = panel6.Height
			popup.Width = panel6.Width
			Me.treeViewAdv1.Dock = DockStyle.Fill
			Me.popupOpen.Start()
			left_Renamed = panel11.Left - 40
			popup.Visible = True
		End Sub

		Private Sub panel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel3.Click
			popup.Visible = False
		End Sub

		Private Sub panel9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel11.Click, panel9.Click
			popup.Visible = False
		End Sub

		Private Sub panel7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel7.Click, panel10.Click
			popup.Visible = False
		End Sub

		Private Sub pictureBox2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.MouseEnter
			Me.Cursor = Cursors.Hand
		End Sub

		Private Sub pictureBox2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.MouseLeave
			Me.Cursor = Cursors.Default
		End Sub
	End Class



End Namespace
