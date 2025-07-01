Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace BackStageDemo
	Partial Public Class Form1
		Inherits RibbonForm
		Private toolStripTabGroup1 As New Syncfusion.Windows.Forms.Tools.ToolStripTabGroup()
		Private colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Public Sub New()
			InitializeComponent()
			getPath()

			toolStripTabGroup1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			toolStripTabGroup1.Name = "Layout"
			toolStripTabGroup1.Visible = True
			Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013
			Me.toolStripButton42.Visible = False

			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
			Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
			' 
			' colorPickerUIAdv1.RecentGroup
			' 
			Me.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
			Me.colorPickerUIAdv1.RecentGroup.Visible = False
			' 
			' colorPickerUIAdv1.StandardGroup
			' 
			Me.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
			' 
			' colorPickerUIAdv1.ThemeGroup
			' 
			Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
			Me.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
			' 
			' colorPickerUIAdv1
			' 
			Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
			Me.colorPickerUIAdv1.HorizontalItemsSpacing = 5
			Me.colorPickerUIAdv1.Location = New System.Drawing.Point(2, -45)
			Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 149)
			Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
			Me.colorPickerUIAdv1.Size = New System.Drawing.Size(181, 195)
			Me.colorPickerUIAdv1.TabIndex = 0
			Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
			AddHandler colorPickerUIAdv1.ItemSelection, AddressOf colorPickerUIAdv1_ItemSelection
			AddHandler colorPickerUIAdv1.Picked, AddressOf colorPickerUIAdv1_Picked
			Me.toolStripEx10.Width = 121
			Dim panel1 As New Panel()
			panel1.Controls.Add(Me.colorPickerUIAdv1)
			Me.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Metro

			panel1.Height = 10
			panel1.Width = 175

			getTree()
			getTabControl()
			populateTreeViewAdv()


			getMainPanel()

			Me.treeViewAdv1.Style = TreeStyle.Metro
			AddHandler treeViewAdv1.Click, AddressOf treeViewAdv1_Click
			Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			AddHandler Load, AddressOf Form1_Load

			Dim host2 As New ToolStripControlHost(panel1)
			Me.toolStripEx11.Items.Add(host2)

			Me.colorPickerUIAdv1.SelectedColor = ColorTranslator.FromHtml ("#119EDA")
				setMetroColor (colorPickerUIAdv1.SelectedColor)
				getOfficeImages()

				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds
				timer1 = New Timer()
				timer1.Interval = 20
				AddHandler timer1.Tick, AddressOf timer1_Tick
				timer1.Start()

				AddHandler treeViewAdv1.DoubleClick, AddressOf treeViewAdv1_DoubleClick


		End Sub

		Private Sub treeViewAdv1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Try
				System.Diagnostics.Process.Start(path & "/" & Me.treeViewAdv1.SelectedNode.Parent.Text & "/" & Me.treeViewAdv1.SelectedNode.Text)
			Catch ex As Exception
			End Try
		End Sub



		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If helper.Top < -50 Then
				helper.Top = details.Height
			End If

			helper.Top = helper.Top - 1
			helper1.Top = helper1.Top - 1
		End Sub

		Private timer1 As New Timer()

		Private Sub getOfficeImages()
			Dim initial As Boolean = True
			For i As Integer = 0 To 9
				Dim panel1 As New Panel()

				Dim pic As New HostPictureBox(Me.colorPickerUIAdv1)

				panel1.Controls.Add(pic)
				panel1.BackColor = Color.White
				 panel1.Size = New Size(100, 80)
				 If initial Then
					 pic.Location = New Point(8, 18)
					 pic.Width = 85
					 pic.Height = 50
				 Else
					 pic.Location = New Point(10, 20)
					 pic.Width = 80
					 pic.Height = 40
				 End If
				 initial = False
				 AddHandler panel1.Click, AddressOf panel1_Click
				 AddHandler pic.MouseEnter, AddressOf pic_MouseEnter
				 AddHandler pic.MouseLeave, AddressOf pic_MouseLeave
				 Dim img As String = Application.StartupPath
				 img = img.Replace("\Release", "")
				 img = img.Replace("\Debug", "")
				 img = img.Replace("bin", "")
				 img = "../../"
				 img = img & "OfficeImages"
				 AddHandler pic.Click, AddressOf pic_Click
				 Dim di As New DirectoryInfo(img)
				 Dim files() As FileInfo = Nothing
				 Dim directories() As DirectoryInfo = Nothing
				 Dim searchPattern As String = "*.*"

				 Try
					 files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly)
				 Catch
				 End Try
				 Me.tabControlAdv1.TabPages.Clear()


				 If files IsNot Nothing Then
					  Dim ii As Integer = 0
					 Dim name As String = String.Empty
					 For Each f As FileInfo In files
						 If i = ii Then
							 pic.Image = Image.FromFile(f.FullName)
							 pic.Name = f.Name
							 pic.Name = pic.Name.Replace(".bmp", "")
							 pic.BorderStyle = BorderStyle.FixedSingle

						 End If
						 ii += 1

					 Next f

				 Else

				 End If
				   Dim host2 As New ToolStripControlHost(panel1)
			Me.toolStripEx7.Items.Add(host2)
			Next i
		End Sub

		Private Sub pic_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Cursor = Cursors.Default
		End Sub

		Private Sub pic_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Cursor = Cursors.Hand
		End Sub

		Private Sub pic_Click(ByVal sender As Object, ByVal e As EventArgs)
			If RibbonHeaderImage.Birds.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds
			ElseIf RibbonHeaderImage.Boxes3D.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D
			ElseIf RibbonHeaderImage.Bubbles.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles
			ElseIf RibbonHeaderImage.Butterflies.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies
			ElseIf RibbonHeaderImage.CircleBands.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.CircleBands
			ElseIf RibbonHeaderImage.Circles.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles
			ElseIf RibbonHeaderImage.Circles2.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2
			ElseIf RibbonHeaderImage.DottedArrows.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows
			ElseIf RibbonHeaderImage.Floweral.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral
			ElseIf RibbonHeaderImage.Lines.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines
			ElseIf RibbonHeaderImage.Nodes.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes
			ElseIf RibbonHeaderImage.Snowflakes.ToString() = (TryCast(sender, PictureBox)).Name Then
				Me.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Snowflakes
			End If
			For Each host As ToolStripControlHost In Me.toolStripEx7.Items
				Dim panel As Control = host.Control

				TryCast(panel, Panel).Controls(0).Location = New Point(10, 20)
				TryCast(panel, Panel).Controls(0).Size = New Size(80, 40)

			Next host

			TryCast(sender, PictureBox).Location = New Point(8, 16)
			TryCast(sender, PictureBox) .Size = New Size (85,50)

		End Sub

		Private Sub panel1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
		Private groupBar1 As New GroupBar()
		Private Sub getGroupBar()

			Dim groupBarItem1 As GroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Dim groupBarItem2 As GroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Dim groupBarItem3 As GroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()

			Me.groupBar1.GroupBarItems.Clear()
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.ExpandButtonToolTip = Nothing
			Me.groupBar1.GroupBarDropDownToolTip = Nothing
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { groupBarItem1, groupBarItem2, groupBarItem3})
			Me.groupBar1.IndexOnVisibleItems = True
			Me.groupBar1.Location = New System.Drawing.Point(71, 54)
			Me.groupBar1.MinimizeButtonToolTip = Nothing
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.NavigationPaneTooltip = Nothing
			Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.groupBar1.SelectedItem = 2
			Me.groupBar1.Size = New System.Drawing.Size(200, 300)
			Me.groupBar1.TabIndex = 0
			Me.groupBar1.Text = "groupBar1"
			groupBar1.BackColor = Color.White
			groupBarItem1.Text = "Item 1"
			groupBarItem2.Text = "Item 2"
			groupBarItem3.Text = "Item 3"

			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "GroupBar")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			groupBar1.VisualStyle = VisualStyle.Metro
			groupBar1.BorderColor = Color.White
			groupBar1.HeaderBackColor = Me.colorPickerUIAdv1.SelectedColor
			Me.panel.Controls.Add(groupBar1)
			Me.WindowState = FormWindowState.Maximized

		End Sub

		Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private panel As New Panel()
		Private buttonAdv1 As New ButtonAdv()
		Private buttonEdit1 As New ButtonEdit()
		Private layout As New FlowLayout()

		Private Sub getButton()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ButtonAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			buttonAdv1.Text = "ButtonAdv"
			buttonAdv1.UseVisualStyle = True
			buttonAdv1.Appearance = ButtonAppearance.Metro
			buttonAdv1.Size = New Size(100, 40)
			Me.panel.Controls.Add(buttonAdv1)
		End Sub

		Private Sub getButtonEdit()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ButtonEdit")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			buttonEdit1.Text = "ButtonAdv"

			buttonEdit1.ButtonStyle = ButtonAppearance.Metro
			buttonEdit1.UseVisualStyle = True
			buttonEdit1.Size = New Size(100, 40)
			buttonEdit1.MetroColor = colorPickerUIAdv.SelectedColor
			buttonEdit1.Buttons.Clear()
			Dim buttonEditChildButton1 As ButtonEditChildButton = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			buttonEdit1.Buttons.Add(buttonEditChildButton1)
			buttonEditChildButton1.BackColor = colorPickerUIAdv.SelectedColor
			Me.panel.Controls.Add(buttonEdit1)
		End Sub


		Private Sub getMainPanel()

			layout.ContainerControl = panel
			panel.BackColor = Color.White

		End Sub
		Private Sub getTree()


			Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
			Me.treeViewAdv1.CanSelectDisabledNode = False
			' 
			' 
			' 
			Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.HelpTextControl.Name = "helpText"
			Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv1.HelpTextControl.TabIndex = 0
			Me.treeViewAdv1.HelpTextControl.Text = "help text"
			Me.treeViewAdv1.Location = New System.Drawing.Point(1, 19)
			Me.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.treeViewAdv1.Name = "treeViewAdv1"
			Me.treeViewAdv1.ShowFocusRect = True
			Me.treeViewAdv1.Size = New System.Drawing.Size(134, 441)
			Me.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Default
			Me.treeViewAdv1.TabIndex = 2
			Me.treeViewAdv1.Text = "treeViewAdv1"
			' 
			' 
			' 
			Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
			Me.treeViewAdv1.ToolTipControl.TabIndex = 1
			Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
			' 
			' dockingManager1
			' 
			Me.dockingManager1.ActiveCaptionFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.dockingManager1.DockToFill = True
			Me.dockingManager1.HostControl = Me
			Me.dockingManager1.InActiveCaptionFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.dockingManager1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.dockingManager1.ReduceFlickeringInRtl = False
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"))
			Me.dockingManager1.SetDockLabel(Me.treeViewAdv1, "Tools Package")
			Me.dockingManager1.SetEnableDocking(Me.treeViewAdv1, True)


		End Sub

		Private Sub treeViewAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)

			getImage(Me.treeViewAdv1.SelectedNode.Parent.Text & "/" & Me.treeViewAdv1.SelectedNode.Text)

		End Sub

		Private tabControlAdv1 As New TabControlAdv()
		Private Sub getTabControl()
			Me.Controls.Add(tabControlAdv1)



			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)

		End Sub



		Private path As String = "C:/Users/selvaganapathyk/AppData/Local/Syncfusion/EssentialStudio/10.4.0.42/Windows/Tools.Windows/Samples/2.0"

		Private Sub populateTreeViewAdv()

            path = System.IO.Path.GetFullPath(path)
			path = path.Replace("\Release", "")
			path = path.Replace("\Debug", "")
			path = path.Replace("\bin", "")
			path = path.Replace("\CS", "")
			path = path.Replace("\cs", "")
			path = path.Replace("\VB", "")
			'path = path.Replace("\Tools Overview", "")
            'path = path.Replace("\Product Showcase", "")
			Dim di As New DirectoryInfo(path)

			Dim directories = di.GetDirectories("*")
			Dim exePath As String = path
			For Each d As DirectoryInfo In directories
				getNode(d.Name)
			Next d

		End Sub



		Private Sub getNode(ByVal text As String)

			Dim node As New TreeNodeAdv(text)
			node.Height = 20
			Me.treeViewAdv1.Nodes.Add(node)
				Dim di As New DirectoryInfo(path & "/" & text)
				Dim directories = di.GetDirectories("*")
				Dim exePath As String = path
				For Each d As DirectoryInfo In directories
					Dim treeNodeAdv As New TreeNodeAdv(d.Name)
					treeNodeAdv.Height = 20
					node.Nodes.Add(treeNodeAdv)

				Next d
		End Sub

		Private Function getTabPage(ByVal img As Image, ByVal text As String) As TabPageAdv


			Dim page As New TabPageAdv(text)

			Return page



		End Function
		Private Sub getImage(ByVal text As String)
			path = System.IO.Path.GetFullPath(path)
			Dim img As String = path & "/" & text & "/images/"
			Dim di As New DirectoryInfo(img)
			Dim files() As FileInfo = Nothing
			Dim directories() As DirectoryInfo = Nothing
			Dim searchPattern As String = "*.*"

			Try
				files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly)
			Catch
			End Try
			Me.tabControlAdv1.TabPages.Clear()

			If files IsNot Nothing Then
				Dim i As Integer = 0
				Dim name As String = String.Empty
				For Each f As FileInfo In files
					i += 1
					Dim imgName As Image = Image.FromFile(f.FullName)

					Dim page As TabPageAdv = getTabPage(imgName, "Preview " & Convert.ToString(i))
					Me.dockingManager1.SetDockLabel(tabControlAdv1, Me.treeViewAdv1.SelectedNode.Text)
					page.Image = Image.FromFile(f.FullName)

					tabControlAdv1.TabPages.Add(page)
					page.BackgroundImage = Image.FromFile(f.FullName)
					page.BackgroundImageLayout = ImageLayout.None
					name = f.FullName
					Dim replace As String = "\" & f.Name
				   name = name.Replace(replace, " ")
				   replace = "\" & "images"
				   name = name.Replace(replace, " ")
				   replace = "\" & "Image"
				   name = name.Replace(replace, " ")
				Next f
				textBox1.Text = Me.treeViewAdv1.SelectedNode.Text & " sample's preview image is shown in 'Preview' window." & " And the " & Me.treeViewAdv1.SelectedNode.Text & "'s demo sample is available at : " & name

			Else
				Me.dockingManager1.SetDockLabel(tabControlAdv1,"No Preview available")
				open = String.Empty
				textBox1.Text = "No preview available"
			End If



		End Sub

		Private open As String = String.Empty
		Private Sub colorPickerUIAdv1_ItemSelection(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)

		End Sub

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			setMetroColor(Me.colorPickerUIAdv1.SelectedColor)
		End Sub

		Private Sub setMetroColor(ByVal color As Color)
			buttonAdv1.BackColor = color
			treeView.MetroColor = color
			treeViewAdv1.MetroColor = color
			splitButton1.BackColor = color
			dockingManager1.MetroColor = color
			tabControl.ActiveTabColor = color
			'contextMenuStripEx1.MetroColor = color;
			clock1.MinuteHandColor = color
			clock1.HourHandColor = clock1.MinuteHandColor
			clock1.EndGradientBackColor = clock1.HourHandColor
			clock1.BorderColor = clock1.EndGradientBackColor
			clock1.StartGradientBackColor = clock1.BorderColor
			comboBoxAdv1.MetroColor = color
			tabControlAdv1.ActiveTabColor = color
			groupBar1.HeaderBackColor = color
			trackBarEx.ForeColor = color
			rangerSlider.ThumbColor = color
			radioButtonAdv1.MetroColor = color
			buttonEdit1.MetroColor = color
			checkBoxAdv1.MetroColor = color
			progressBarAdv1.GradientStartColor = color
			progressBarAdv1.GradientEndColor = progressBarAdv1.GradientStartColor
			xpTaskBar1.MetroColor = color
			Me.ribbonControlAdv1.MenuColor = color
			Me.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor
			colorPickerUIAdv.MetroColor = color
			monthCalendarAdv1.MetroColor = color
			calculatorControl1.MetroColor = color
			textBox1.ForeColor = color
			Me.ribbonControlAdv1.MenuColor = color
			Me.integerTextBox1.Metrocolor = color

			textBoxExt1.Metrocolor = color
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub backStageButton1_Click(ByVal sender As Object, ByVal e As EventArgs)


		End Sub

		Private Sub backStageButton2_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub backStageButton3_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private textBox1 As New TextBox()
		Private details As New Panel()
		Private helper As New Label()
		Private helper1 As New Label()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Me.tabControlAdv1.Size = New Size(300, 300)
			Me.dockingManager1.SetDockLabel(tabControlAdv1, "Preview")

			Me.dockingManager1.SetEnableDocking(tabControlAdv1, True)

			Me.tabControlAdv1.Size = New Size(300, 300)
			Me.dockingManager1.SetDockLabel(panel, "Main Panel")

			Me.dockingManager1.SetEnableDocking(panel, True)

			Me.dockingManager1.DockControl(Me.tabControlAdv1, Me, DockingStyle.Right, 500)
			Me.dockingManager1.DockControl(Me.treeViewAdv1, Me.tabControlAdv1, DockingStyle.Top,200)

			textBox1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))

			textBox1.Multiline = True
			textBox1.BorderStyle = BorderStyle.None
			Me.dockingManager1.SetDockLabel(textBox1, "Actions")
			Me.dockingManager1.SetEnableDocking(textBox1, True)
			Me.dockingManager1.DockControl(textBox1, panel, DockingStyle.Bottom, 150)

			Me.dockingManager1.SetDockLabel(details, "Help instructions")
			Me.dockingManager1.SetEnableDocking(details, True)
			Me.dockingManager1.DockControl(details,textBox1, DockingStyle.Bottom, 100)

			details.BackColor = Color.White
			helper.Font = textBox1.Font
			helper.ForeColor = textBox1.ForeColor
			details.Controls.Add(helper)
			helper.AutoSize = True
			helper.Text = " Choose a tool from the ""Controls"" tab to view the tool. " & Constants.vbLf + Constants.vbLf & " Pick a color from the ""Options"" to change the metro color"
			getWebBrowser()

		End Sub

		Private comboBoxAdv1 As New ComboBoxAdv()
		Private splitButton1 As New SplitButton()

		Private checkBoxAdv1 As New CheckBoxAdv()
		Private radioButtonAdv1 As New RadioButtonAdv()

		Private monthCalendarAdv1 As New MonthCalendarAdv()

		Private colorPickerUIAdv As New ColorPickerUIAdv()

		Private calculatorControl1 As New CalculatorControl()

		Private textBoxExt1 As New TextBoxExt()

		Private integerTextBox1 As New IntegerTextBox()

		Private numericUpDown1 As New NumericUpDownExt()

		Private clock1 As New Clock()

		Private trackBarEx As New TrackBarEx()

		Private rangerSlider As New RangeSlider()

		Private progressBarAdv1 As New ProgressBarAdv()

		Private treeView As New TreeViewAdv()

		Private wizardControl1 As New WizardControl()

		Private scrollerFrame1 As New ScrollersFrame()

		Private tabControl As New TabControlAdv()

		Private xpTaskBar1 As New XPTaskBar()

		Private xpTaskBarBox1 As New XPTaskBarBox()
		Private xpTaskBarBox2 As New XPTaskBarBox()
		Private contextMenuStripEx1 As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private item1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private item2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private item3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private item4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private item5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem



		Private navigationView As New NavigationView()

		Private splashControl1 As New SplashPanel()

		Private Sub getSplashControl()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "NavigationView")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4

			Dim panel1 As New Panel()
			panel1.Size = New Size(400, 400)
			splashControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(colorPickerUIAdv1.SelectedColor)

			'splashControl1.Size = new Size(200, 200);
			panel.Controls.Add(splashControl1)
		End Sub

		Private Sub getNavigationView()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "SplashPanel")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4

			navigationView.Size = New Size(400, 400)
			panel.Controls.Add(navigationView)
		End Sub

		Private Sub getPath()
			path = Application.StartupPath
		   ' path = Directory.GetCurrentDirectory();
			path = "../../"
			path = path.Replace("\Release", "")
			path = path.Replace("\Debug", "")
			path = path.Replace("\bin", "")
			path = path.Replace("\CS", "")
			path = path.Replace("\cs", "")
			path = path.Replace("\VB", "")
			path = path.Replace("\Tools Overview", "")
			path = path.Replace("\Product Showcase", "")
		   ' path = path.Replace("\\", "/");


			'path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData );
			'path = path.Replace("\\Roaming", "");
			'path = path + "/Local/Syncfusion/EssentialStudio/";

			'DirectoryInfo di = new DirectoryInfo(path);
			'var directories = di.GetDirectories("*");
			'string exePath = path;
			'string currentdName = "0";
			'string dir = string.Empty;
			'foreach (DirectoryInfo d in directories)
			'{
			'    string dName = d.Name;

			'    dName  = dName.Replace(".", "");
			'    if (Convert.ToInt32(dName) > Convert.ToInt32(currentdName) && dName.Contains("10"))
			'    {
			'        currentdName = dName;
			'        dir = d.Name;
			'    }
			'}
			'path = path + dir + "/Windows/Tools.Windows/Samples/2.0";
			'path = path.Replace("\\", "/");


		End Sub

		Private Sub getContextMenuStrip()
			Me.contextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
			Me.item1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.item2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.item3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.item4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.item5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.contextMenuStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contextMenuStripEx1
			' 
			Me.contextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.item1ToolStripMenuItem, Me.item2ToolStripMenuItem, Me.item3ToolStripMenuItem, Me.item4ToolStripMenuItem, Me.item5ToolStripMenuItem})
			Me.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.contextMenuStripEx1.Name = "contextMenuStripEx1"
			Me.contextMenuStripEx1.Size = New System.Drawing.Size(108, 114)
			Me.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default
			' 
			' item1ToolStripMenuItem
			' 
			Me.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem"
			Me.item1ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.item1ToolStripMenuItem.Text = "Item 1"
			' 
			' item2ToolStripMenuItem
			' 
			Me.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem"
			Me.item2ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.item2ToolStripMenuItem.Text = "Item 2"
			' 
			' item3ToolStripMenuItem
			' 
			Me.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem"
			Me.item3ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.item3ToolStripMenuItem.Text = "Item 3"
			' 
			' item4ToolStripMenuItem
			' 
			Me.item4ToolStripMenuItem.Name = "item4ToolStripMenuItem"
			Me.item4ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.item4ToolStripMenuItem.Text = "Item 4"
			' 
			' item5ToolStripMenuItem
			' 
			Me.item5ToolStripMenuItem.Name = "item5ToolStripMenuItem"
			Me.item5ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.item5ToolStripMenuItem.Text = "Item 5"


			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ContextMenuStripEx")
			layout.ContainerControl = Nothing
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4

			Dim panel1 As New Panel()

			panel1.Size = New Size(400, 400)
			panel1.BackColor = Color.Gray
			Me.panel.Controls.Add(panel1)

			Dim panel2 As New Label()
			panel2.Size = New Size(500, 400)
			panel1.Controls.Add(panel2)
			panel2.Text = "Right click me to show ContextMenuStripEx"
			Me.toolStripEx1.ContextMenuStrip = Me.contextMenuStripEx1
			AddHandler contextMenuStripEx1.Opening, AddressOf contextMenuStripEx1_Opening
			AddHandler contextMenuStripEx1.Opened, AddressOf contextMenuStripEx1_Opened
		End Sub

		Private Sub contextMenuStripEx1_Opened(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub contextMenuStripEx1_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.textBox1.Text = "ContextMenuStripEx is Opening"
		End Sub

		Private Sub getXpTaskBar()
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Location = New System.Drawing.Point(57, 72)
			Me.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Size = New System.Drawing.Size(173, 197)
			Me.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Metro
			Me.xpTaskBar1.TabIndex = 1
			Me.xpTaskBar1.ForeColor = Color.White
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.HeaderBackColor = colorPickerUIAdv1.SelectedColor
			Me.xpTaskBarBox1.HeaderImageIndex = -1
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox1.ItemBackColor = colorPickerUIAdv1.SelectedColor
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.PADY = 2
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(171, 22)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "xpTaskBarBox1"
			Me.xpTaskBarBox1.ForeColor = Color.White
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.HeaderBackColor = colorPickerUIAdv1.SelectedColor
			Me.xpTaskBarBox2.HeaderImageIndex = -1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox2.ItemBackColor = colorPickerUIAdv1.SelectedColor
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 23)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.PADY = 2
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(171, 22)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "xpTaskBarBox2"
			Me.xpTaskBarBox2.ForeColor = Color.White
			Me.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "XPTaskBar")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			panel.Controls.Add(xpTaskBar1)
		End Sub

		Private Sub getTabControlAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "TabControlAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			tabControl.TabPages.Clear()
			For i As Integer = 0 To 1
				Dim tabPage As New TabPageAdv("Page " & Convert.ToString(i))
				tabControl.TabPages.Add(tabPage)
				tabPage.BackColor = Color.LightGray
			Next i
			tabControl.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)
			tabControl.Size = New Size(400, 400)
			panel.Controls.Add(tabControl)
		End Sub

		Private Sub getScrollerFrame()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ScrollersFrame")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4

			'wizardControl1 = TreeStyle.Metro;

			Dim panel1 As New Panel()
			scrollerFrame1.AttachedTo = panel1
			scrollerFrame1.VisualStyle = ScrollBarCustomDrawStyles.Metro
			panel1.AutoScroll = True
			panel1.Size = New Size(200, 200)
			Me.panel.Controls.Add(panel1)

			Dim panel2 As New Panel()
			panel2.Size = New Size(400, 400)
			panel1.Controls.Add(panel2)
		End Sub


		Private Sub getWizardControl()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "WizardControl")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			wizardControl1.Text = "WizardControl"
			wizardControl1.Style = Theme.Metro
			'wizardControl1 = TreeStyle.Metro;
			wizardControl1.BorderStyle = BorderStyle.FixedSingle

			wizardControl1.Size = New Size(400, 200)
			Me.panel.Controls.Add(wizardControl1)
		End Sub

		Private Sub getTreeViewAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "Tools Package")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			treeView.Text = "Tools Package"
			treeView.Style = TreeStyle.Metro
			treeView.Nodes.Clear()
			For i As Integer = 0 To 24

				Dim node As New TreeNodeAdv("node " & Convert.ToString(i))
				treeView.Nodes.Add(node)
				For j As Integer = 0 To 9
					Dim node1 As New TreeNodeAdv("node " & Convert.ToString(i))
				node.Nodes.Add(node1)
				Next j
				If i Mod 2 = 0 Then
					node.ShowOptionButton = True
				Else
					node.ShowCheckBox = True
					node.CheckState = CheckState.Checked
				End If

			Next i
			treeView.Size = New Size(200, 400)
			Me.panel.Controls.Add(treeView)
		End Sub

		Private Sub getProgressBarAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ProgressBarAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			progressBarAdv1.Text = "ProgressBarAdv"
			progressBarAdv1.ProgressStyle = ProgressBarStyles.Metro
			progressBarAdv1.GradientStartColor = colorPickerUIAdv1.SelectedColor
			progressBarAdv1.GradientEndColor = colorPickerUIAdv1.SelectedColor
			progressBarAdv1.TextStyle = ProgressBarTextStyles.Custom
			progressBarAdv1.Size = New Size(200, 50)
			Me.panel.Controls.Add(progressBarAdv1)
		End Sub


		Private Sub getRangeSlider()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "RangeSlider")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			rangerSlider.Text = "RangeSlider"
			rangerSlider.VisualStyle = RangeSlider.RangeSliderStyle.Metro
			rangerSlider.Size = New Size(200, 50)
			rangerSlider.ThumbColor = colorPickerUIAdv1.SelectedColor
			rangerSlider.RangeColor = Color.Gray
			Me.panel.Controls.Add(rangerSlider)
		End Sub


		Private Sub getTrackBarEx()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "TrackBarEx")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			trackBarEx.Text = "TrackBarEx"
			trackBarEx.Style = TrackBarEx.Theme.Metro
			trackBarEx.Size = New Size(200, 50)
			Me.panel.Controls.Add(trackBarEx)
		End Sub

		Private Sub getClock()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "NumericUpDown")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			clock1.Text = "NumericUpDown"
			Dim color As Color = Me.colorPickerUIAdv1.SelectedColor
			clock1.IsTransparent = True
			clock1.StartGradientBackColor = Color.FromArgb(100, color)
			clock1.EndGradientBackColor = Color.FromArgb(100, color)
			clock1.HourHandColor = color
			clock1.MinuteHandColor = color
			clock1.BorderColor = color
			clock1.ShowMinute = False
			clock1.ShowSecondHand = False

			clock1.HourHandThickness = 5
			clock1.MinuteHandThickness = 4
			clock1.Size = New Size(250, 250)
			Me.panel.Controls.Add(clock1)
		End Sub


		Private Sub getNumericUpDown()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "NumericUpDown")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			numericUpDown1.Text = "NumericUpDown"
			numericUpDown1.VisualStyle = VisualStyle.Metro
			numericUpDown1.Size = New Size(125, 40)
			numericUpDown1.VisualStyle = VisualStyle.Metro

			Me.panel.Controls.Add(numericUpDown1)
		End Sub

		Private Sub getIntegerTextBox()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "IntegerTextBox")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			integerTextBox1.Text = "IntegerTextBox"
			integerTextBox1.Style = TextBoxExt.theme.Metro
			integerTextBox1.Size = New Size(125, 40)
			Me.panel.Controls.Add(integerTextBox1)
		End Sub

		Private Sub getTextBoxExt()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "TextBoxExt")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			textBoxExt1.Text = "TextBoxExt"

			textBoxExt1.Size = New Size(125, 40)
			textBoxExt1.Style = TextBoxExt.theme.Metro
			Me.panel.Controls.Add(textBoxExt1)
		End Sub

		Private Sub getCalculatorControl()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "CalculatorControl")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			calculatorControl1.Text = "CalculatorControl"
			calculatorControl1.ButtonStyle = ButtonAppearance.Metro
			calculatorControl1.UseVisualStyle = True
			calculatorControl1.MetroColor = colorPickerUIAdv1.SelectedColor
			calculatorControl1.BackColor = ControlPaint.Light (Color.LightGray)
			Me.panel.Controls.Add(calculatorControl1)
		End Sub

		Private Sub getColorPickerUIAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ColorPickerUIAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			colorPickerUIAdv.Text = "ColorPickerUIAdv"
			colorPickerUIAdv.Style = ColorPickerUIAdv.visualstyle.Metro

			'colorPickerUIAdv1.Size = new Size(125, 40);
			Me.panel.Controls.Add(colorPickerUIAdv)
		End Sub

		Private Sub getMonthCalendarAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "MonthCalendarAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			monthCalendarAdv1.Text = "MonthCalendarAdv"
			monthCalendarAdv1.Style = VisualStyle.Metro

			Me.panel.Controls.Add(monthCalendarAdv1)
			monthCalendarAdv1.MetroColor = colorPickerUIAdv1.SelectedColor
		End Sub


		Private Sub getRadioButtonAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "RadioButtonAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			radioButtonAdv1.Text = "RadioButtonAdv"
			radioButtonAdv1.Style = RadioButtonAdvStyle.Metro

			radioButtonAdv1.Size = New Size(125, 40)
			Me.panel.Controls.Add(radioButtonAdv1)
		End Sub

		Private Sub getCheckBoxAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "CheckBoxAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			checkBoxAdv1.Text = "CheckBoxAdv"
			checkBoxAdv1.Style = CheckBoxAdvStyle.Metro

			checkBoxAdv1.Size = New Size(125, 40)
			Me.panel.Controls.Add(checkBoxAdv1)
		End Sub

		Private Sub getSplitButton()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "SplitButton")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			splitButton1.Text = "SplitButton"
			splitButton1.Style = SplitButtonVisualStyle.Metro
			splitButton1.BackColor = colorPickerUIAdv1.SelectedColor
			splitButton1.DropDownItems.Clear()
			splitButton1.DropDownItems.Add("Item1")
			splitButton1.DropDownItems.Add("Item2")
			splitButton1.DropDownItems.Add("Item3")
			splitButton1.DropDownItems.Add("Item4")
			splitButton1.DropDownItems.Add("Item5")
			splitButton1.Size = New Size(150, 40)
			Me.panel.Controls.Add(splitButton1)

		End Sub

		Private Sub getComboBoxAdv()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, "ComboBoxAdv")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = panel.Height \ 4
			comboBoxAdv1.Text = "ComboBoxAdv"
			comboBoxAdv1.Style = VisualStyle.Metro
			comboBoxAdv1.Items.Clear()
			comboBoxAdv1.Items.Add("Item1")
			comboBoxAdv1.Items.Add("Item2")
			comboBoxAdv1.Items.Add("Item3")
			comboBoxAdv1.Items.Add("Item4")
			comboBoxAdv1.Items.Add("Item5")
			comboBoxAdv1.Size = New Size(100, 40)
			Me.panel.Controls.Add(comboBoxAdv1)
		End Sub

		Private Sub Form1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton30.Click, toolStripButton31.Click, toolStripButton32.Click, toolStripButton27.Click, toolStripButton28.Click, toolStripButton29.Click, toolStripButton33.Click, toolStripButton34.Click, toolStripButton35.Click, toolStripButton2.Click, toolStripButton3.Click, toolStripButton4.Click, toolStripButton38.Click, toolStripButton39.Click, toolStripButton40.Click, toolStripButton36.Click, toolStripButton37.Click, toolStripButton44.Click, toolStripButton45.Click, toolStripButton46.Click, toolStripButton41.Click, toolStripButton48.Click, toolStripButton49.Click, toolStripButton50.Click, toolStripButton42.Click, MyBase.Click
			layout.ContainerControl = panel
			If TypeOf sender Is ToolStripItem Then
				textBox1.Text = (TryCast(sender, ToolStripItem)).Text & " is Created."
				Select Case (TryCast(sender, ToolStripItem)).Text
					Case "ButtonAdv"

						getButton()
					Case "ButtonEdit"

						getButtonEdit ()
					Case "ComboBoxAdv"

						getComboBoxAdv()
					Case "SplitButton"

						getSplitButton()
					Case "CheckBoxAdv"

						getCheckBoxAdv ()
					Case "RadioButtonAdv"

						getRadioButtonAdv ()
					Case "MonthCalendarExt"

						getMonthCalendarAdv ()
					Case "ColorPickerUIAdv"

						getColorPickerUIAdv ()

					Case "TextBoxExt"

					   getTextBoxExt ()
					Case "CalculatorControl"

						getCalculatorControl ()

					Case "IntegerTextBox"

						getIntegerTextBox ()
					Case "NumericUpDownExt"

						getNumericUpDown ()
					Case "Clock"

						getClock ()

					Case "TrackBarEx"
						getRangeSlider()

					Case "RangerSlider"

						getTrackBarEx()


					Case "ProgressBar"

						getProgressBarAdv()

					Case "GroupBar"

						getGroupBar()

					Case "ScrollerFrame"

						getScrollerFrame()

					Case "TreeViewAdv"

						getTreeViewAdv()

					Case "WizardControl"

						getWizardControl ()

					Case "TabControlExt"

						getTabControlAdv()

					Case "XPTaskBar"

						getXpTaskBar()



					Case "ContextMenuStripEx"

						getContextMenuStrip ()

					Case "NavigationView"

						getNavigationView ()
					Case "SplashControl"

						getSplashControl ()


				End Select

			End If


		End Sub
		Private webBrowser1 As New WebBrowser()
		Private Sub getWebBrowser()
			Me.panel.Controls.Clear()
			Me.dockingManager1.SetDockLabel(panel, " Tools Windows Forms")
			layout.Alignment = FlowAlignment.Center
			layout.TopMargin = 0
            layout.ContainerControl = Nothing
            Dim file1 As String = path
            If (file1.Contains("\vb")) Then
                file1 = file1.Replace("\vb", "")
            End If
            Dim file As String = file1
            file = file & "sample.htm"
            webBrowser1.Url = New Uri(file)


            Dim panel1 As New Panel()
            Dim sf As New ScrollersFrame()
            sf.AttachedTo = panel1
            sf.VisualStyle = ScrollBarCustomDrawStyles.Metro
            panel1.Controls.Add(webBrowser1)
            Me.panel.Controls.Add(panel1)
            panel1.Dock = DockStyle.Fill
            panel1.AutoScroll = True
            webBrowser1.Size = New Size(1500, 750)
            textBox1.Text = "Tools overview"
        End Sub

		Private Sub backStageButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton6.Click
			Me.Dispose()
		End Sub

		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
			getWebBrowser()


		End Sub

		Private Sub toolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
			Me.dockingManager1.SetAutoHideMode(Me.treeViewAdv1, True)
			Me.dockingManager1.SetAutoHideMode(Me.tabControlAdv1, True)
			Me.dockingManager1.SetAutoHideMode(Me.textBox1, True)
			Me.dockingManager1.SetAutoHideMode(details, True)
			textBox1.Text = "Screen cleaned"

		End Sub


		Public Class HostPictureBox
			Inherits PictureBox
			Private color As New ColorPickerUIAdv()
			Public Sub New(ByVal colorpicker As ColorPickerUIAdv)
				color = colorpicker
                color1 = System.Drawing.Color.Transparent
			End Sub

			Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
				MyBase.OnPaint(e)
                Dim brush As New SolidBrush(System.Drawing.Color.FromArgb(100, color1))
				If Me.Height = 50 Then
                    brush = New SolidBrush(System.Drawing.Color.FromArgb(30, color.SelectedColor))
				Else
                    brush = New SolidBrush(System.Drawing.Color.FromArgb(100, color1))
				End If
				e.Graphics.FillRectangle (brush,New Rectangle (0,0,Me.Width,Me.Height))
				brush.Dispose ()

			End Sub

            Private color1 As Color = System.Drawing.Color.Red
			Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
				MyBase.OnMouseEnter(e)
				color1 = color.SelectedColor
				Me.Invalidate()
			End Sub
			Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
				MyBase.OnMouseLeave(e)
                color1 = System.Drawing.Color.Transparent
				Me.Invalidate()
			End Sub
		End Class

	End Class
End Namespace
