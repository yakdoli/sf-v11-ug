using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Windows.Forms;

namespace BackStageDemo
{
    public partial class Form1 : RibbonForm
    {
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        public Form1()
        {
            InitializeComponent();
            getPath();

            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toolStripTabGroup1.Name = "Layout";
            toolStripTabGroup1.Visible = true;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.toolStripButton42.Visible = false;
            
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 5;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(2, -45);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 149);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(181, 195);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.ItemSelection += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_ItemSelection);
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            this.toolStripEx10.Width = 121;
            Panel panel1 = new Panel();
            panel1.Controls.Add(this.colorPickerUIAdv1);
            this.colorPickerUIAdv1.Style  = ColorPickerUIAdv.visualstyle.Metro;

            panel1.Height = 10;
            panel1.Width = 175;

            getTree();
            getTabControl();
            populateTreeViewAdv();
      

            getMainPanel();
        
            this.treeViewAdv1.Style = TreeStyle.Metro;
            this.treeViewAdv1.Click += new EventHandler(treeViewAdv1_Click);
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.Load += new EventHandler(Form1_Load);

            ToolStripControlHost host2 = new ToolStripControlHost(panel1);
            this.toolStripEx11.Items.Add(host2);

            this.colorPickerUIAdv1 .SelectedColor = ColorTranslator .FromHtml ("#119EDA");
                setMetroColor (colorPickerUIAdv1 .SelectedColor );
                getOfficeImages();

                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds;
                timer1 = new Timer();
                timer1.Interval = 20;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();

                this.treeViewAdv1.DoubleClick += new EventHandler(treeViewAdv1_DoubleClick);
             
            
        }

        void treeViewAdv1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path + "/" + this.treeViewAdv1.SelectedNode.Parent.Text + "/" + this.treeViewAdv1.SelectedNode.Text);
            }
            catch (Exception ex)
            {
            }
        }



        void timer1_Tick(object sender, EventArgs e)
        {
            if (helper.Top < -50)
                helper.Top = details.Height;

            helper.Top = helper.Top - 1;
            helper1.Top = helper1.Top - 1;
                    }

        Timer timer1 = new Timer();

        private void getOfficeImages()
        {
            bool initial = true;
            for (int i = 0; i < 10; i++)
            {
                Panel panel1 = new Panel( );

                HostPictureBox pic = new HostPictureBox(this.colorPickerUIAdv1 );
                                
                panel1.Controls.Add(pic);
                panel1.BackColor = Color.White;
                 panel1.Size = new Size(100, 80);
                 if (initial)
                 {
                     pic.Location = new Point(8, 18);
                     pic.Width = 85;
                     pic.Height = 50;
                 }
                 else
                 {
                     pic.Location = new Point(10, 20);
                     pic.Width = 80;
                     pic.Height = 40;
                 }
                 initial = false;
                 panel1.Click += new EventHandler(panel1_Click);
                 pic.MouseEnter += new EventHandler(pic_MouseEnter);
                 pic.MouseLeave += new EventHandler(pic_MouseLeave);
                 string img = Application.StartupPath;
                 img = img.Replace("\\Release", "");
                 img = img.Replace("\\Debug", "");
                 img = img.Replace( "bin", "");
                 img = "../../";
                 img = img + "OfficeImages";
                 pic.Click += new EventHandler(pic_Click);
                 DirectoryInfo di = new DirectoryInfo(img);
                 FileInfo[] files = null;
                 DirectoryInfo[] directories = null;
                 string searchPattern = "*.*";

                 try
                 {
                     files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
                 }
                 catch
                 {
                 }
                 this.tabControlAdv1.TabPages.Clear();


                 if (files != null)
                 {
                      int ii = 0;
                     string name = string.Empty;
                     foreach (FileInfo f in files)
                     {
                         if (i == ii)
                         {
                             pic.Image = Image.FromFile(f.FullName);
                             pic.Name = f.Name;
                             pic.Name = pic.Name.Replace(".bmp", "");
                             pic.BorderStyle = BorderStyle.FixedSingle;
                            
                         }
                         ii++;

                     }
                   
                 }
                 else
                 {
                    
                 }
                   ToolStripControlHost host2 = new ToolStripControlHost(panel1);
            this.toolStripEx7.Items.Add(host2);
            }
        }

        void pic_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        void pic_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        void pic_Click(object sender, EventArgs e)
        {
            if (RibbonHeaderImage.Birds.ToString() == (sender as PictureBox ).Name )
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds;
            else if (RibbonHeaderImage.Boxes3D .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D;
            else if (RibbonHeaderImage.Bubbles .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles ;
            else if (RibbonHeaderImage.Butterflies .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies ;
            else if (RibbonHeaderImage.CircleBands .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.CircleBands ;
            else if (RibbonHeaderImage.Circles .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles ;
            else if (RibbonHeaderImage.Circles2 .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2 ;
            else if (RibbonHeaderImage.DottedArrows .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows ;
            else if (RibbonHeaderImage.Floweral .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral ;
            else if (RibbonHeaderImage.Lines .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines ;
            else if (RibbonHeaderImage.Nodes .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes ;
            else if (RibbonHeaderImage.Snowflakes .ToString() == (sender as PictureBox).Name)
                this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Snowflakes ;
            foreach (ToolStripControlHost  host in this.toolStripEx7.Items)
            {
                Control panel = host.Control;

                (panel as Panel).Controls[0].Location = new Point(10, 20);
                (panel as Panel).Controls[0].Size = new Size(80, 40);

            }

            (sender as PictureBox).Location = new Point(8, 16);
            (sender as PictureBox ).Size = new Size (85,50);

        }

        void panel1_Click(object sender, EventArgs e)
        {
 
        }
        GroupBar groupBar1 = new GroupBar();
        private void getGroupBar()
        {

            GroupBarItem groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            GroupBarItem groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            GroupBarItem groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();

            this.groupBar1.GroupBarItems.Clear();
            this.groupBar1.AllowDrop = true;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            groupBarItem1,
            groupBarItem2,
            groupBarItem3});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(71, 54);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(200, 300);
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            groupBar1.BackColor = Color.White;
            groupBarItem1.Text = "Item 1";
            groupBarItem2.Text = "Item 2";
            groupBarItem3.Text = "Item 3";

            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "GroupBar");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            groupBar1.VisualStyle = VisualStyle.Metro;
            groupBar1.BorderColor = Color.White;
            groupBar1.HeaderBackColor = this.colorPickerUIAdv1.SelectedColor;
            this.panel.Controls.Add(groupBar1);
            this.WindowState = FormWindowState.Maximized;
           
        }

        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        Panel panel = new Panel();
        ButtonAdv buttonAdv1 = new ButtonAdv();
        ButtonEdit buttonEdit1 = new ButtonEdit();
        FlowLayout layout = new FlowLayout();

        private void getButton()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ButtonAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            buttonAdv1.Text  = "ButtonAdv";
            buttonAdv1.UseVisualStyle = true;
            buttonAdv1.Appearance = ButtonAppearance.Metro;
            buttonAdv1.Size = new Size(100, 40);
            this.panel.Controls.Add(buttonAdv1);
        }

        private void getButtonEdit()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ButtonEdit");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            buttonEdit1.Text = "ButtonAdv";

            buttonEdit1.ButtonStyle = ButtonAppearance.Metro;
            buttonEdit1.UseVisualStyle = true;
            buttonEdit1.Size = new Size(100, 40);
            buttonEdit1.MetroColor = colorPickerUIAdv.SelectedColor;
            buttonEdit1.Buttons.Clear();
            ButtonEditChildButton buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            buttonEdit1.Buttons.Add(buttonEditChildButton1);
            buttonEditChildButton1.BackColor = colorPickerUIAdv.SelectedColor;
            this.panel.Controls.Add(buttonEdit1);
        }


        private void getMainPanel()
        {

            layout.ContainerControl = panel;
            panel.BackColor = Color.White;

        }
        private void getTree()
        {


            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.treeViewAdv1.CanSelectDisabledNode = false;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.Location = new System.Drawing.Point(1, 19);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.ShowFocusRect = true;
            this.treeViewAdv1.Size = new System.Drawing.Size(134, 441);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Default;
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.DockToFill = true;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.SetDockLabel(this.treeViewAdv1, "Tools Package");
            this.dockingManager1.SetEnableDocking(this.treeViewAdv1, true);


        }

        void treeViewAdv1_Click(object sender, EventArgs e)
        {

            getImage(this.treeViewAdv1.SelectedNode.Parent.Text + "/" + this.treeViewAdv1.SelectedNode.Text);
        
        }

        TabControlAdv tabControlAdv1 = new TabControlAdv();
        private void getTabControl()
        {
            this.Controls.Add(tabControlAdv1);



            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);

        }



        string path = "C:/Users/selvaganapathyk/AppData/Local/Syncfusion/EssentialStudio/10.4.0.42/Windows/Tools.Windows/Samples/2.0";

        private void populateTreeViewAdv()
        {

            path = Path.GetFullPath(path);
            path = path.Replace("\\Release", "");
            path = path.Replace("\\Debug", "");
            path = path.Replace("\\bin", "");
            path = path.Replace("\\CS", "");
            path = path.Replace("\\cs", "");
            path = path.Replace("\\VB", "");
            path = path.Replace("\\Tools Overview", "");
            path = path.Replace("\\Product Showcase", "");
            DirectoryInfo di = new DirectoryInfo(path);

            var directories = di.GetDirectories("*");
            string exePath = path;
            foreach (DirectoryInfo d in directories)
            {
                getNode(d.Name);
            }

        }



        private void getNode(string text)
        {

            TreeNodeAdv node = new TreeNodeAdv(text);
            node.Height = 20;
            this.treeViewAdv1.Nodes.Add(node);
            {
                DirectoryInfo di = new DirectoryInfo(path + "/" + text);
                var directories = di.GetDirectories("*");
                string exePath = path;
                foreach (DirectoryInfo d in directories)
                {
                    TreeNodeAdv treeNodeAdv = new TreeNodeAdv(d.Name);
                    treeNodeAdv.Height = 20;
                    node.Nodes.Add(treeNodeAdv);

                }
            }
        }

        private TabPageAdv getTabPage(Image img, string text)
        {


            TabPageAdv page = new TabPageAdv(text);

            return page;



        }
        private void getImage(string text)
        {
            path = Path.GetFullPath(path);
            string img = path + "/" + text + "/images/";
            DirectoryInfo di = new DirectoryInfo(img);
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;
            string searchPattern = "*.*";

            try
            {
                files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
            }
            catch
            {
            }
            this.tabControlAdv1.TabPages.Clear();

            if (files != null)
            {
                int i = 0;
                string name = string.Empty;
                foreach (FileInfo f in files)
                {
                    i++;
                    Image imgName = Image.FromFile(f.FullName);

                    TabPageAdv page = getTabPage(imgName, "Preview " + Convert.ToString(i));
                    this.dockingManager1.SetDockLabel(tabControlAdv1, this.treeViewAdv1.SelectedNode.Text);
                    page.Image = Image.FromFile(f.FullName);

                    tabControlAdv1.TabPages.Add(page);
                    page.BackgroundImage = Image.FromFile(f.FullName);
                    page.BackgroundImageLayout = ImageLayout.None;
                    name = f.FullName;
                    string replace = "\\"+ f.Name ;
                   name = name.Replace(replace, " ");
                   replace = "\\" + "images";
                   name = name.Replace(replace, " ");
                   replace = "\\" + "Image";
                   name = name.Replace(replace, " ");
                }
                textBox1.Text = this.treeViewAdv1.SelectedNode.Text + " sample's preview image is shown in 'Preview' window."+ " And the "+ this.treeViewAdv1.SelectedNode.Text +"'s demo sample is available at : " + name;
                
            }
            else
            {
                this.dockingManager1.SetDockLabel(tabControlAdv1,"No Preview available");
                open = string.Empty;
                textBox1.Text = "No preview available";
            }



        }

        string open = string.Empty;
        private void colorPickerUIAdv1_ItemSelection(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {

        }

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            setMetroColor(this.colorPickerUIAdv1.SelectedColor);
        }

        private void setMetroColor(Color color)
        {
            buttonAdv1.BackColor = color;
            treeView.MetroColor = color;
            treeViewAdv1.MetroColor = color;
            splitButton1.BackColor = color;
            dockingManager1.MetroColor = color;
            tabControl.ActiveTabColor = color;
            //contextMenuStripEx1.MetroColor = color;
            clock1.StartGradientBackColor = clock1.BorderColor = clock1.EndGradientBackColor = clock1.HourHandColor = clock1.MinuteHandColor = color;
            comboBoxAdv1.MetroColor = color;
            tabControlAdv1.ActiveTabColor = color;
            groupBar1.HeaderBackColor = color;
            trackBarEx.ForeColor = color;
            rangerSlider.ThumbColor  = color;
            radioButtonAdv1.MetroColor = color;
            buttonEdit1.MetroColor = color;
            checkBoxAdv1.MetroColor = color;
            progressBarAdv1.GradientEndColor = progressBarAdv1.GradientStartColor = color;
            xpTaskBar1.MetroColor = color;
            this.ribbonControlAdv1.MenuColor = color;
            this.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor;
            colorPickerUIAdv.MetroColor = color;
            monthCalendarAdv1.MetroColor = color;
            calculatorControl1.MetroColor = color;
            textBox1.ForeColor = color;
            this.ribbonControlAdv1.MenuColor = color;
            this.integerTextBox1.Metrocolor = color;
            
            textBoxExt1.Metrocolor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backStageButton1_Click(object sender, EventArgs e)
        {


        }

        private void backStageButton2_Click(object sender, EventArgs e)
        {

        }

        private void backStageButton3_Click(object sender, EventArgs e)
        {

        }

        TextBox textBox1 = new TextBox();
        Panel details = new Panel();
        Label helper = new Label();
        Label helper1 = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.tabControlAdv1.Size = new Size(300, 300);
            this.dockingManager1.SetDockLabel(tabControlAdv1, "Preview");

            this.dockingManager1.SetEnableDocking(tabControlAdv1, true);

            this.tabControlAdv1.Size = new Size(300, 300);
            this.dockingManager1.SetDockLabel(panel , "Main Panel");

            this.dockingManager1.SetEnableDocking(panel, true);
 
            this.dockingManager1.DockControl(this.tabControlAdv1, this, DockingStyle.Right , 500);
            this.dockingManager1.DockControl(this.treeViewAdv1 , this.tabControlAdv1 , DockingStyle.Top ,200);
            
            textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            textBox1.Multiline = true;
            textBox1.BorderStyle = BorderStyle.None;
            this.dockingManager1.SetDockLabel(textBox1 , "Actions");
            this.dockingManager1.SetEnableDocking(textBox1, true);
            this.dockingManager1.DockControl(textBox1 , panel, DockingStyle.Bottom , 150);
            
            this.dockingManager1.SetDockLabel(details  , "Help instructions");
            this.dockingManager1.SetEnableDocking(details, true);
            this.dockingManager1.DockControl(details,textBox1,  DockingStyle.Bottom, 100);

            details.BackColor = Color.White;
            helper.Font = textBox1.Font;
            helper.ForeColor = textBox1.ForeColor;
            details.Controls.Add(helper);
            helper.AutoSize = true;
            helper.Text = " Choose a tool from the \"Controls\" tab to view the tool. \n\n Pick a color from the \"Options\" to change the metro color";
            getWebBrowser();

        }

        ComboBoxAdv comboBoxAdv1 = new ComboBoxAdv();
        SplitButton splitButton1 = new SplitButton();

        CheckBoxAdv checkBoxAdv1 = new CheckBoxAdv();
        RadioButtonAdv radioButtonAdv1 = new RadioButtonAdv();

        MonthCalendarAdv monthCalendarAdv1 = new MonthCalendarAdv();

        ColorPickerUIAdv colorPickerUIAdv = new ColorPickerUIAdv();

        CalculatorControl calculatorControl1 = new CalculatorControl();

        TextBoxExt textBoxExt1 = new TextBoxExt();

        IntegerTextBox integerTextBox1 = new IntegerTextBox();

        NumericUpDownExt numericUpDown1 = new NumericUpDownExt();

        Clock clock1 = new Clock();

        TrackBarEx trackBarEx = new TrackBarEx();

        RangeSlider rangerSlider = new RangeSlider();

        ProgressBarAdv progressBarAdv1 = new ProgressBarAdv();

        TreeViewAdv treeView = new TreeViewAdv();

        WizardControl wizardControl1 = new WizardControl();

        ScrollersFrame scrollerFrame1 = new ScrollersFrame();

        TabControlAdv tabControl = new TabControlAdv();

        XPTaskBar xpTaskBar1 = new XPTaskBar();

        XPTaskBarBox xpTaskBarBox1 = new XPTaskBarBox();
        XPTaskBarBox xpTaskBarBox2 = new XPTaskBarBox();
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item5ToolStripMenuItem;



        NavigationView navigationView = new NavigationView();

        SplashPanel splashControl1 = new SplashPanel ();

        private void getSplashControl()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "NavigationView");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;

            Panel panel1 = new Panel();
            panel1.Size = new Size(400, 400);
            splashControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(colorPickerUIAdv1 .SelectedColor );
         
            //splashControl1.Size = new Size(200, 200);
            panel.Controls.Add(splashControl1);
        }

        private void getNavigationView()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "SplashPanel");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;

            navigationView.Size = new Size(400, 400);
            panel.Controls.Add(navigationView);
        }

        private void getPath()
        {
            path = Application.StartupPath;
           // path = Directory.GetCurrentDirectory();
            path = "../../";
            path = path.Replace("\\Release", "");
            path = path.Replace("\\Debug", "");
            path = path.Replace("\\bin", "");
            path = path.Replace("\\CS", "");
            path = path.Replace("\\cs", "");
            path = path.Replace("\\VB", "");
            path = path.Replace("\\Tools Overview", "");
            path = path.Replace("\\Product Showcase", "");
           // path = path.Replace("\\", "/");
  
           
            //path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData );
            //path = path.Replace("\\Roaming", "");
            //path = path + "/Local/Syncfusion/EssentialStudio/";
            
            //DirectoryInfo di = new DirectoryInfo(path);
            //var directories = di.GetDirectories("*");
            //string exePath = path;
            //string currentdName = "0";
            //string dir = string.Empty;
            //foreach (DirectoryInfo d in directories)
            //{
            //    string dName = d.Name;

            //    dName  = dName.Replace(".", "");
            //    if (Convert.ToInt32(dName) > Convert.ToInt32(currentdName) && dName.Contains("10"))
            //    {
            //        currentdName = dName;
            //        dir = d.Name;
            //    }
            //}
            //path = path + dir + "/Windows/Tools.Windows/Samples/2.0";
            //path = path.Replace("\\", "/");


        }

        private void getContextMenuStrip()
        {
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.item3ToolStripMenuItem,
            this.item4ToolStripMenuItem,
            this.item5ToolStripMenuItem});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(108, 114);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // item4ToolStripMenuItem
            // 
            this.item4ToolStripMenuItem.Name = "item4ToolStripMenuItem";
            this.item4ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item4ToolStripMenuItem.Text = "Item 4";
            // 
            // item5ToolStripMenuItem
            // 
            this.item5ToolStripMenuItem.Name = "item5ToolStripMenuItem";
            this.item5ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item5ToolStripMenuItem.Text = "Item 5";


            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ContextMenuStripEx");
            layout.ContainerControl = null;
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;

            Panel panel1 = new Panel();
                       
            panel1.Size = new Size(400, 400);
            panel1.BackColor = Color.Gray;
            this.panel.Controls.Add(panel1);

            Label panel2 = new Label();
            panel2.Size = new Size(500, 400);
            panel1.Controls.Add(panel2);
            panel2 .Text = "Right click me to show ContextMenuStripEx";
            this.toolStripEx1  .ContextMenuStrip = this.contextMenuStripEx1;
            this.contextMenuStripEx1.Opening += new CancelEventHandler(contextMenuStripEx1_Opening);
            this.contextMenuStripEx1.Opened += new EventHandler(contextMenuStripEx1_Opened);
        }

        void contextMenuStripEx1_Opened(object sender, EventArgs e)
        {
          
        }

        void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {
            this.textBox1.Text = "ContextMenuStripEx is Opening";
        }

        private void getXpTaskBar()
        {
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Location = new System.Drawing.Point(57, 72);
            this.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor;
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(173, 197);
            this.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Metro;
            this.xpTaskBar1.TabIndex = 1;
            this.xpTaskBar1.ForeColor = Color.White;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.HeaderBackColor = colorPickerUIAdv1.SelectedColor;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = colorPickerUIAdv1.SelectedColor;
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PADY = 2;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(171, 22);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "xpTaskBarBox1";
            this.xpTaskBarBox1.ForeColor = Color.White;
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.HeaderBackColor = colorPickerUIAdv1.SelectedColor;
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ItemBackColor = colorPickerUIAdv1.SelectedColor;
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 23);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PADY = 2;
            this.xpTaskBarBox2.Size = new System.Drawing.Size(171, 22);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "xpTaskBarBox2";
            this.xpTaskBarBox2.ForeColor = Color.White;
            this.xpTaskBar1.MetroColor = colorPickerUIAdv1.SelectedColor;
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "XPTaskBar");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            panel.Controls.Add(xpTaskBar1);
        }

        private void getTabControlAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "TabControlAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            tabControl.TabPages.Clear();
            for (int i = 0; i < 2; i++)
            {
                TabPageAdv tabPage = new TabPageAdv("Page " + Convert.ToString(i));
                tabControl.TabPages.Add(tabPage);
                tabPage.BackColor = Color.LightGray;
            }
            tabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            tabControl.Size = new Size(400, 400);
            panel.Controls.Add(tabControl);
        }

        private void getScrollerFrame()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ScrollersFrame");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;

            //wizardControl1 = TreeStyle.Metro;

            Panel panel1 = new Panel();
            scrollerFrame1.AttachedTo = panel1;
            scrollerFrame1.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            panel1.AutoScroll = true;
            panel1.Size = new Size(200, 200);
            this.panel.Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.Size = new Size(400, 400);
            panel1.Controls.Add(panel2);
        }


        private void getWizardControl()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "WizardControl");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            wizardControl1.Text = "WizardControl";
            wizardControl1.Style = Theme.Metro;
            //wizardControl1 = TreeStyle.Metro;
            wizardControl1.BorderStyle = BorderStyle.FixedSingle;
          
            wizardControl1.Size = new Size(400, 200);
            this.panel.Controls.Add(wizardControl1);
        }

        private void getTreeViewAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "Tools Package");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            treeView.Text = "Tools Package";
            treeView.Style = TreeStyle.Metro;
            treeView.Nodes.Clear();
            for (int i = 0; i < 25; i++)
            {

                TreeNodeAdv node = new TreeNodeAdv("node " + Convert.ToString(i));
                treeView.Nodes.Add(node);
                for (int j = 0; j < 10; j++)
                {
                    TreeNodeAdv node1 = new TreeNodeAdv("node " + Convert.ToString(i));
                node.Nodes.Add(node1);
                }
                if (i % 2 == 0)
                    node.ShowOptionButton = true;
                else
                {
                    node.ShowCheckBox = true;
                    node.CheckState = CheckState.Checked;
                }
                
            }
            treeView.Size = new Size(200, 400);
            this.panel.Controls.Add(treeView);
        }

        private void getProgressBarAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ProgressBarAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            progressBarAdv1.Text = "ProgressBarAdv";
            progressBarAdv1.ProgressStyle = ProgressBarStyles.Metro;
            progressBarAdv1.GradientStartColor = colorPickerUIAdv1 .SelectedColor ;
            progressBarAdv1.GradientEndColor = colorPickerUIAdv1.SelectedColor;
            progressBarAdv1.TextStyle = ProgressBarTextStyles.Custom;
            progressBarAdv1.Size = new Size(200, 50);
            this.panel.Controls.Add(progressBarAdv1);
        }


        private void getRangeSlider()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "RangeSlider");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            rangerSlider.Text = "RangeSlider";
            rangerSlider.VisualStyle  = RangeSlider.RangeSliderStyle.Metro  ;
            rangerSlider.Size = new Size(200, 50);
            rangerSlider.ThumbColor = colorPickerUIAdv1.SelectedColor;
            rangerSlider.RangeColor = Color.Gray;
            this.panel.Controls.Add(rangerSlider);
        }


        private void getTrackBarEx()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "TrackBarEx");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            trackBarEx.Text = "TrackBarEx";
            trackBarEx.Style = TrackBarEx.Theme.Metro;
            trackBarEx.Size = new Size(200, 50);
            this.panel.Controls.Add(trackBarEx);
        }

        private void getClock()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "NumericUpDown");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            clock1.Text = "NumericUpDown";
            Color color = this.colorPickerUIAdv1 .SelectedColor ;
            clock1.IsTransparent = true;
            clock1.StartGradientBackColor = Color.FromArgb(100, color);
            clock1.EndGradientBackColor  = Color.FromArgb(100, color);
            clock1.HourHandColor = color;
            clock1.MinuteHandColor = color;
            clock1.BorderColor = color;
            clock1.ShowMinute = false;
            clock1.ShowSecondHand = false;

            clock1.HourHandThickness = 5;
            clock1.MinuteHandThickness = 4;
            clock1.Size = new Size(250, 250);
            this.panel.Controls.Add(clock1);
        }


        private void getNumericUpDown()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "NumericUpDown");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            numericUpDown1.Text = "NumericUpDown";
            numericUpDown1.VisualStyle = VisualStyle.Metro;
            numericUpDown1.Size = new Size(125, 40);
            numericUpDown1.VisualStyle = VisualStyle.Metro;
        
            this.panel.Controls.Add(numericUpDown1);
        }

        private void getIntegerTextBox()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "IntegerTextBox");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            integerTextBox1.Text = "IntegerTextBox";
            integerTextBox1.Style = TextBoxExt.theme.Metro;
            integerTextBox1.Size = new Size(125, 40);
            this.panel.Controls.Add(integerTextBox1);
        }

        private void getTextBoxExt()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "TextBoxExt");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            textBoxExt1.Text = "TextBoxExt";
            
            textBoxExt1.Size = new Size(125, 40);
            textBoxExt1.Style = TextBoxExt.theme.Metro ;
            this.panel.Controls.Add(textBoxExt1);
        }

        private void getCalculatorControl()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "CalculatorControl");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            calculatorControl1.Text = "CalculatorControl";
            calculatorControl1.ButtonStyle = ButtonAppearance.Metro ;
            calculatorControl1.UseVisualStyle = true;
            calculatorControl1.MetroColor = colorPickerUIAdv1.SelectedColor;
            calculatorControl1.BackColor = ControlPaint .Light (Color.LightGray  );
            this.panel.Controls.Add(calculatorControl1);
        }

        private void getColorPickerUIAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ColorPickerUIAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            colorPickerUIAdv.Text = "ColorPickerUIAdv";
            colorPickerUIAdv.Style  = ColorPickerUIAdv.visualstyle.Metro;

            //colorPickerUIAdv1.Size = new Size(125, 40);
            this.panel.Controls.Add(colorPickerUIAdv);
        }

        private void getMonthCalendarAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "MonthCalendarAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            monthCalendarAdv1.Text = "MonthCalendarAdv";
            monthCalendarAdv1.Style = VisualStyle.Metro;
         
            this.panel.Controls.Add(monthCalendarAdv1);
            monthCalendarAdv1.MetroColor = colorPickerUIAdv1.SelectedColor;
        }


        private void getRadioButtonAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "RadioButtonAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            radioButtonAdv1.Text = "RadioButtonAdv";
            radioButtonAdv1.Style = RadioButtonAdvStyle.Metro;

            radioButtonAdv1.Size = new Size(125, 40);
            this.panel.Controls.Add(radioButtonAdv1);
        }

        private void getCheckBoxAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "CheckBoxAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            checkBoxAdv1.Text = "CheckBoxAdv";
            checkBoxAdv1.Style = CheckBoxAdvStyle.Metro;

            checkBoxAdv1.Size = new Size(125, 40);
            this.panel.Controls.Add(checkBoxAdv1);
        }

        private void getSplitButton()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "SplitButton");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            splitButton1.Text = "SplitButton";
            splitButton1.Style = SplitButtonVisualStyle.Metro;
            splitButton1.BackColor = colorPickerUIAdv1.SelectedColor;
            splitButton1.DropDownItems.Clear();
            splitButton1.DropDownItems.Add("Item1");
            splitButton1.DropDownItems.Add("Item2");
            splitButton1.DropDownItems.Add("Item3");
            splitButton1.DropDownItems.Add("Item4");
            splitButton1.DropDownItems.Add("Item5");
            splitButton1.Size = new Size(150, 40);
            this.panel.Controls.Add(splitButton1);
   
        }

        private void getComboBoxAdv()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, "ComboBoxAdv");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = panel.Height / 4;
            comboBoxAdv1.Text = "ComboBoxAdv";
            comboBoxAdv1.Style = VisualStyle.Metro;
            comboBoxAdv1.Items.Clear();
            comboBoxAdv1.Items.Add("Item1");
            comboBoxAdv1.Items.Add("Item2");
            comboBoxAdv1.Items.Add("Item3");
            comboBoxAdv1.Items.Add("Item4");
            comboBoxAdv1.Items.Add("Item5");
            comboBoxAdv1.Size = new Size(100, 40);
            this.panel.Controls.Add(comboBoxAdv1);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            layout.ContainerControl = panel;
            if (sender is ToolStripItem)
            {
                textBox1.Text = (sender as ToolStripItem).Text + " is Created.";
                switch ((sender as ToolStripItem).Text)
                {
                    case "ButtonAdv":

                        getButton();
                        break;
                    case "ButtonEdit":

                        getButtonEdit ();
                        break;
                    case "ComboBoxAdv":

                        getComboBoxAdv();
                        break;
                    case "SplitButton":

                        getSplitButton();
                        break;
                    case "CheckBoxAdv":

                        getCheckBoxAdv ();
                        break;
                    case "RadioButtonAdv":

                        getRadioButtonAdv ();
                        break;
                    case "MonthCalendarExt":

                        getMonthCalendarAdv ();
                        break;
                    case "ColorPickerUIAdv":

                        getColorPickerUIAdv ();
                        break;

                    case "TextBoxExt":

                       getTextBoxExt ();
                        break;
                    case "CalculatorControl":

                        getCalculatorControl ();
                        break;

                    case "IntegerTextBox":

                        getIntegerTextBox ();
                        break;
                    case "NumericUpDownExt":

                        getNumericUpDown ();
                        break;
                    case "Clock":

                        getClock ();
                        break;

                    case "TrackBarEx":
                        getRangeSlider();
                       
                        break;
                    case "RangerSlider":

                        getTrackBarEx();
                        break;


                    case "ProgressBar":

                        getProgressBarAdv();
                        break;

                    case "GroupBar":

                        getGroupBar();
                        break;

                    case "ScrollerFrame":

                        getScrollerFrame();
                        break;

                    case "TreeViewAdv":

                        getTreeViewAdv();
                        break;

                    case "WizardControl":

                        getWizardControl ();
                        break;

                    case "TabControlExt":

                        getTabControlAdv();
                        break;

                    case "XPTaskBar":

                        getXpTaskBar();
                        break;



                    case "ContextMenuStripEx":

                        getContextMenuStrip ();
                        break;

                    case "NavigationView":

                        getNavigationView  ();
                        break;
                    case "SplashControl":

                        getSplashControl ();
                        break;

                       
                }

            }


        }
        WebBrowser webBrowser1 = new WebBrowser();
        private void getWebBrowser()
        {
            this.panel.Controls.Clear();
            this.dockingManager1.SetDockLabel(panel, " Tools Windows Forms");
            layout.Alignment = FlowAlignment.Center;
            layout.TopMargin = 0;
            layout.ContainerControl = null;
            string file = path.Replace("\\Samples\\2.0","");
            file = file + "sample.htm";
            webBrowser1.Url = new Uri(file);
           
    
            Panel panel1 = new Panel();
            ScrollersFrame sf = new ScrollersFrame();
            sf.AttachedTo = panel1;
            sf.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            panel1.Controls.Add(webBrowser1);
            this.panel.Controls.Add(panel1 );
            panel1.Dock = DockStyle.Fill;
            panel1.AutoScroll = true;
            webBrowser1.Size = new Size(1500, 750);
            textBox1.Text = "Tools overview";
        }

        private void backStageButton6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            getWebBrowser();
           

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.dockingManager1.SetAutoHideMode(this.treeViewAdv1, true);
            this.dockingManager1.SetAutoHideMode(this.tabControlAdv1, true);
            this.dockingManager1.SetAutoHideMode(this.textBox1 , true);
            this.dockingManager1.SetAutoHideMode(details , true);
            textBox1.Text = "Screen cleaned";
           
        }


        public class HostPictureBox : PictureBox
        {
            ColorPickerUIAdv color = new ColorPickerUIAdv();
            public HostPictureBox(ColorPickerUIAdv colorpicker)
            {
                color = colorpicker;
                color1 = Color.Transparent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                SolidBrush brush = new SolidBrush(Color.FromArgb(100, color1 ));
                if(this.Height == 50)
                    brush = new SolidBrush(Color.FromArgb(30, color.SelectedColor ));
                else
                brush = new SolidBrush(Color.FromArgb(100, color1 ));
                e.Graphics .FillRectangle (brush ,new Rectangle (0,0,this.Width ,this.Height ));
                brush .Dispose ();
                
            }

            Color color1 = Color.Red;
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                color1 = color.SelectedColor;
                this.Invalidate();
            }
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                color1 = Color.Transparent ;
                this.Invalidate();
            }
        }

    }
}
