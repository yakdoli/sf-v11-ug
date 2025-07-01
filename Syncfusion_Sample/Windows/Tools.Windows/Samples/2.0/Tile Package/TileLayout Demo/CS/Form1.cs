using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using System.Diagnostics;
using System.IO;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace TileLayoutDemo_2008
{
    public partial class Form1 : Form
    {
        string imagePath = Application .StartupPath ;
        public Form1()
        {
            InitializeComponent();
            this.Activated += new EventHandler(Form1_Activated);
            this.tileLayout1.Text = "Start";
            this.tileLayout1.ForeColor = Color.White;
            getImageStreamers();
            this.tileLayout1.NewGroupIndicatorColor = Color.White;
           // this.tileLayout1.ExitButtonImage = Image.FromFile(imagePath + "Close.png");
          //  this.tileLayout1.ShowPreviewButtonImage  = Image.FromFile(imagePath + "Selection.png");
          //  this.tileLayout1.NewGroupButtonImage  = Image.FromFile(imagePath + "Pause.png");
            Timer time = new Timer();
            time.Interval = 1000;
            time.Start();
            time.Tick += new EventHandler(time_Tick);
            openMenu.Tick += new EventHandler(t_Tick);
            CloseMenu.Tick += new EventHandler(CloseMenu_Tick);
            this.openMenu.Interval = 10;
            this.CloseMenu.Interval = 10;
            this.panel2.Height = 0;
            this.panel3.Height = 0;
            this.panel1.Click += new EventHandler(panel1_Click);

            this.panel2.MouseLeave   += new EventHandler(panel2_MouseLeave);
            this.panel3.MouseLeave += new EventHandler(panel2_MouseLeave);

            this.panel2.MouseEnter += new EventHandler(panel2_MouseEnter);

            this.layoutGroup1.Text = "Group 1";
            this.layoutGroup2.Text = "Group 2";
           
            color.Style = ColorPickerUIAdv.visualstyle.Metro;
            this.panel6.Controls.Add(color);
            color.Location = new Point(0, -40);
            color.Size = new Size(210, 195);
            color.BackColor = this.panel2.BackColor;
            color.Picked += new ColorPickerUIAdv.ColorPickedEventHandler(color_Picked);

            ScrollersFrame scroll = new ScrollersFrame();
            scroll.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            scroll.AttachedTo = this.panel5;

            treeViewAdv1.Click += new EventHandler(treeViewAdv1_Click);
            treeViewAdv1.Style = TreeStyle.Metro;
          //  this.panel9.Controls.Add(treeViewAdv1);
            treeViewAdv1.Size = new Size(panel9.Width, panel9.Height - 15);
            treeViewAdv1.Location = new Point(0, 15);

            popup.Size = new Size(200, 400);
           

           // panel11.Width  = 200;

            pic.Dock = DockStyle.Fill;
            ScrollersFrame scroll1 = new ScrollersFrame();
            scroll1.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            scroll1.AttachedTo = propertyGrid1;
            FlowLayout flowLayout = new FlowLayout();
            //flowLayout.ContainerControl = this.panel3;
            flowLayout.HGap = 150;
            this.checkBoxAdv1.Checked = true;
            popupOpen.Tick += new EventHandler(popupOpen_Tick);
            popupClose.Tick += new EventHandler(popupClose_Tick);

            popupOpen.Interval = 10;
        }

        Panel popup = new Panel();

        void popupClose_Tick(object sender, EventArgs e)
        {
           
        }

        int left = 0;
        void popupOpen_Tick(object sender, EventArgs e)
        {
            popup.Left = left;

            if (popup.Top > (this.panel3.Top - popup.Height +10))
            {
                popup.Top = popup.Top - 10;
            }
            else
            {
               // popup.Top = popup.Top + 10;
                popupOpen.Stop();
            }
          
        }
        Timer popupOpen = new Timer();
        Timer popupClose = new Timer();

        ImageStreamer imageStreamer = new ImageStreamer();
        PictureBox pic = new PictureBox();
        PropertyGrid propertyGrid1 = new PropertyGrid();

        void treeViewAdv1_Click(object sender, EventArgs e)
        {
           
        }
        ColorPickerUIAdv color = new ColorPickerUIAdv();
        void color_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.tileLayout1.BackColor = color.SelectedColor;
            this.pictureBox2 .BackColor = this.panel1.BackColor = color.SelectedColor;
            if (color.SelectedColor != Color.Black)
                this.panel2.BackColor = this.panel3.BackColor = this.panel4.BackColor = this.checkBoxAdv1.MetroColor = ControlPaint.Dark(color.SelectedColor);
            else
                this.panel2.BackColor = this.panel3.BackColor = this.panel4.BackColor = this.checkBoxAdv1.MetroColor = Color.Teal;
        }

        void panel2_MouseEnter(object sender, EventArgs e)
        {
                    }



        void panel2_MouseLeave(object sender, EventArgs e)
        {
           // this.CloseMenu.Start();
        }

        void panel1_Click(object sender, EventArgs e)
        {
            getTreeView();
            canClose = false;
            this.openMenu.Start();
        }

        void CloseMenu_Tick(object sender, EventArgs e)
        {
            if (this.panel2.Height > 5)
            {
                this.panel2.Height = this.panel2.Height - 10;
                this.panel3.Height = this.panel3.Height - 10;
                this.panel3.Top = this.Bottom - this.panel3.Height;
            }
            else
            {
                this.CloseMenu.Stop();
            }

            
        }

        Timer openMenu = new Timer();
        Timer CloseMenu = new Timer();

        void t_Tick(object sender, EventArgs e)
        {
            if (this.panel2.Height < 72)
            {
                this.panel2.Height = this.panel2.Height + 10;
                this.panel3.Height = this.panel3.Height + 10;
                this.panel3.Top = this.Bottom - this.panel3.Height;
            }
            else
            {
                this.openMenu.Stop();
            }
            
        }

        protected bool PreFilterMessage(Message msg)
        {
            return true;
        }
        

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

        void time_Tick(object sender, EventArgs e)
        {
            string time =  Convert.ToString (DateTime.Now.TimeOfDay);
            time = time.Remove(7, time.Length - 8);
            this.imageStreamer6.SubText.Text  = time;
  


        }

        void Form1_Activated(object sender, EventArgs e)
        {
            this.tileLayout1.SetParentFormFlat = true;
            //this.tileLayout1.AllowNewGroup = true;
            //this.tileLayout1.NewGroupIndicatorColor = Color.White;
            //this.tileLayout1.ShowItemPreview = true;
        }
        private void getImageStreamers()
        {
            //ImageStreamer1

            imagePath = imagePath.Replace("\\Release", "");
            imagePath = imagePath.Replace("\\Debug", "");
            imagePath = imagePath.Replace("\\bin", "");
            imagePath = imagePath.Replace("\\", "/");
            imagePath = imagePath + "/Images/";
            imagePath = "../../Images/";
            this.imageStreamer1.Images.Add(Image.FromFile(imagePath + "Computer.png"));
            //this.imageStreamer1.Images.Add(Image.FromFile(imagePath + "Computer.png"));
            //this.imageStreamer1.Images.Add(Image.FromFile(imagePath + "Computer.png"));
            this.imageStreamer1.BackColor = Color.DarkCyan ;
            this.imageStreamer1.SubText.Text = "My Computer";
            this.imageStreamer1.Click += new EventHandler(imageStreamer1_Click);

            //ImageStreamer2

            this.imageStreamer2.Click += new EventHandler(imageStreamer2_Click);
            this.imageStreamer2.Images.Add(Image.FromFile(imagePath + "Calculation.png"));
            this.imageStreamer2.Images.Add(Image.FromFile(imagePath + "Calculation.png"));
            this.imageStreamer2.Images.Add(Image.FromFile(imagePath + "Calculation.png"));
            this.imageStreamer2.BackColor = Color.LawnGreen;
            this.imageStreamer2.SubText.Text = "Calculator";

            //ImageStreamer3
            this.imageStreamer3.Images.Add(Image.FromFile(imagePath + "Window-Color.png"));
            this.imageStreamer3.Images.Add(Image.FromFile(imagePath + "Window-Color.png"));
            this.imageStreamer3.Images.Add(Image.FromFile(imagePath + "Window-Color.png"));
            this.imageStreamer3.Click += new EventHandler(imageStreamer3_Click);
            this.imageStreamer3.SubText.Text = "Paint";

            //ImageStreamer4
            this.imageStreamer4.Images.Add(Image.FromFile(imagePath + "Note.png"));
            this.imageStreamer4.Images.Add(Image.FromFile(imagePath + "Note.png"));
            this.imageStreamer4.Images.Add(Image.FromFile(imagePath + "Note.png"));
           this. imageStreamer4.Click += new EventHandler(imageStreamer4_Click);
           this.imageStreamer4.SubText.Text = "Notepad";

            //ImageStreamer5
           this.imageStreamer5.Images.Add(Image.FromFile(imagePath + "Wrench.png"));
           this.imageStreamer5.Images.Add(Image.FromFile(imagePath + "Wrench.png"));
           this.imageStreamer5.Images.Add(Image.FromFile(imagePath + "Wrench.png"));
           this.imageStreamer5.SubText.Text = "Pgm Seting";
           this.imageStreamer5.Click += new EventHandler(imageStreamer5_Click);

            //ImageStreamer6
            this.imageStreamer6.Images.Add(Image.FromFile(imagePath + "Clock.png"));
            this.imageStreamer6.Images.Add(Image.FromFile(imagePath + "Clock.png"));
            this.imageStreamer6.Images.Add(Image.FromFile(imagePath + "Clock.png"));
           this.imageStreamer6.Click += new EventHandler(imageStreamer6_Click);
         
               
            //ImageStreamer7
           this.imageStreamer7.Images.Add(Image.FromFile(imagePath + "5.png"));
           this.imageStreamer7.Images.Add(Image.FromFile(imagePath + "5.png"));
           this.imageStreamer7.Images.Add(Image.FromFile(imagePath + "5.png"));
           this.imageStreamer7.Click += new EventHandler(imageStreamer7_Click);
           this.imageStreamer7.SubText.Text = "Desktop";
           this.imageStreamer7.SubText.Visible = false;

            //ImageStreamer8
           this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "1.png"));
           this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "2.png"));
           this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "3.png"));
         //  this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "4.png"));
            this.imageStreamer8.Images.Add(Image.FromFile( imagePath + "1.png"));
            this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "2.png"));
            this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "3.png"));
         //   this.imageStreamer8.Images.Add(Image.FromFile(imagePath + "4.png"));
            this.imageStreamer8.ImageStreamDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.StreamDirection.BottomToTop;
            this.imageStreamer8.SlideShow = true;
            this.imageStreamer8.SliderSpeed = 2500;
            this.imageStreamer8.Click += new EventHandler(imageStreamer8_Click);
            this.imageStreamer8.SubText.Text = "Option";
            this.imageStreamer8.SubText.Visible = false;
            //ImageStreamer9
            this.imageStreamer9.Images.Add(Image.FromFile(imagePath + "Wikimapia.png"));
            this.imageStreamer9.Images.Add(Image.FromFile(imagePath + "Wikimapia.png"));
            this.imageStreamer9.Images.Add(Image.FromFile(imagePath + "Wikimapia.png"));
            this.imageStreamer9.SubText.Text = "Maps";
            this.imageStreamer9.Click += new EventHandler(imageStreamer9_Click);

            //ImageStreamer10
            this.imageStreamer10.Images.Add(Image.FromFile(imagePath + "10.png"));
            this.imageStreamer10.Images.Add(Image.FromFile(imagePath + "10.png"));
            this.imageStreamer10.Images.Add(Image.FromFile(imagePath + "10.png"));
            this.imageStreamer10.SubText.Text  = "Music";
            this.imageStreamer10.SubText.Visible = false;
            this.imageStreamer10.Click += new EventHandler(imageStreamer10_Click);

            //ImageStreamer11
            this.imageStreamer11.Images.Add(Image.FromFile(imagePath + "g.png"));
            this.imageStreamer11.Images.Add(Image.FromFile(imagePath + "g.png"));
            this.imageStreamer11.Images.Add(Image.FromFile(imagePath + "g.png"));
            this.imageStreamer11.Click += new EventHandler(imageStreamer11_Click);
             this.imageStreamer11.SubText.Text  = "Google";
             this.imageStreamer11.SubText.Visible   =  false ;
            //ImageStreamer12
            this.imageStreamer12.BackColor = Color.DarkOrange ;
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Knight.png"));
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Rook.png"));
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Knight.png"));
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Rook.png"));
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Knight.png"));
            this.imageStreamer12.Images.Add(Image.FromFile(imagePath + "Rook.png"));
            this.imageStreamer12.SlideShow = true;
            this.imageStreamer12.ImageStreamDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.StreamDirection.RightToLeft;
            this.imageStreamer12.SubText.Text = "Games";

            //ImageStreamer13
            this.imageStreamer13.Images.Add(Image.FromFile(imagePath + "DashBoard.png"));
            this.imageStreamer13.Images.Add(Image.FromFile(imagePath + "DashBoard.png"));
            this.imageStreamer13.Images.Add(Image.FromFile(imagePath + "DashBoard.png"));
            this.imageStreamer13.SubText.Text = "Syncfusion";
            this.imageStreamer13.Click += new EventHandler(imageStreamer13_Click);
            //ImageStreamer14
            this.imageStreamer14.Images.Add(Image.FromFile(imagePath + "LAN.png"));
            this.imageStreamer14.Images.Add(Image.FromFile(imagePath + "LAN.png"));
            this.imageStreamer14.Images.Add(Image.FromFile(imagePath + "LAN.png"));
            this.imageStreamer14.SubText.Text = "Remote Desktop";
            this.imageStreamer14.BackColor = Color.DarkMagenta;
            this.imageStreamer14.Click += new EventHandler(imageStreamer14_Click);


            //ImageStreamer15
            this.imageStreamer15.Images.Add(Image.FromFile(imagePath + "Command.png"));
            this.imageStreamer15.Images.Add(Image.FromFile(imagePath + "Command.png"));
            this.imageStreamer15.Images.Add(Image.FromFile(imagePath + "Command.png"));
            this.imageStreamer15.SubText.Text = "Cmd Prompt";
            this.imageStreamer15.BackColor = Color.DarkSeaGreen ;
            this.imageStreamer15.Click += new EventHandler(imageStreamer15_Click);

            this.pictureBox2.Image = Image.FromFile(imagePath + "Exit.png");
            this.pictureBox1.Image = Image.FromFile(imagePath + "Preview.png");
            this.pictureBox4.Image = Image.FromFile(imagePath + "Tree1.png");
            this.pictureBox5.Image = Image.FromFile(imagePath + "Color.png");
            this.panel1 .BackgroundImage  = Image.FromFile(imagePath + "Settings.png");
            this.panel1.BackgroundImageLayout = ImageLayout.Center;
            foreach (LayoutGroup group in this.tileLayout1.Groups)
            {
                TreeNodeAdv node = new TreeNodeAdv(group.Text);
                foreach (ImageStreamer img in group.Items)
                {
                    img.Refresh();
                }
            }
            this.pictureBox3.Image = Image.FromFile(imagePath + "Refresh.png");

            
        }

        void imageStreamer13_Click(object sender, EventArgs e)
        {


            string path = Application.StartupPath;

            path = path.Replace("\\Release", "");
            path = path.Replace("\\Debug", "");
            path = path.Replace("\\bin", "");
            path = path.Replace("\\CS", "");
            path = path.Replace("\\cs", "");
            path = path.Replace("\\VB", "");
            path = path.Replace("\\Tools Overview", "");
            path = path.Replace("\\Product Showcase", "");
            path = path.Replace("\\", "/");
            
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles );
            //path = path + "/Syncfusion/Essential Studio/";
            //DirectoryInfo di = new DirectoryInfo(path);
            //var directories = di.GetDirectories ("*");
            //string exePath = path;

            //string currentdName = "0";
            //string dir = string.Empty;

            //foreach (DirectoryInfo d in directories)
            //{


            //    string dName = d.Name;

            //    dName = dName.Replace(".", "");
            //    if (Convert.ToInt32(dName) > Convert.ToInt32(currentdName) && dName.Contains("10"))
            //    {
            //        currentdName = dName;
            //        dir = d.Name;
            //    }
            //}

            //path = path;
            //path = path + dir + "/Infrastructure/Dashboard/4.0/Dashboard.exe";
            //path = "C:/Program Files/Syncfusion/Essential Studio/10.4.0.42/Infrastructure/Dashboard/4.0/Dashboard.exe";
            //    path = path.Replace("\\", "/");
            //    using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(path))
            //    {
            //        exeProcess.WaitForExit();
            //    }   
            System.Diagnostics.Process.Start(path);

          
            
        }

        void imageStreamer8_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments );
            System.Diagnostics.Process.Start(path);
        }

        void imageStreamer14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mstsc");
           
        }

        void imageStreamer15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd");
       
        }

        void imageStreamer7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Desk.cpl");

        }

        void imageStreamer10_Click(object sender, EventArgs e)
        {
           // Process.Start(System.Environment.SystemDirectory + @"\appwiz.cpl");
            string myMusicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic  );
                     System.Diagnostics.Process.Start(myMusicPath);
           // Process.Start(startInfo);

        }

        void imageStreamer9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;


            proc.StartInfo.FileName = "http://maps.google.co.in/maps?hl=en&tab=wl";

            proc.Start();
        }

        void imageStreamer11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;


            proc.StartInfo.FileName = "http://www.google.com";

            proc.Start();
        }

        void imageStreamer1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\");
        }

        void imageStreamer6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TimeDate.cpl");
             
        }

        void imageStreamer5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("appwiz.cpl");
        }

        void imageStreamer4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        void imageStreamer3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
        }

        void imageStreamer2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
     
        }

    

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.tileLayout1.ShowItemPreview = !this.tileLayout1.ShowItemPreview;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.checkBoxAdv1 .Checked  = !this.tileLayout1.ShowItemPreview;
            popup.Visible = false;
        }

        private void tileLayout1_MouseEnter(object sender, EventArgs e)
        {
           
         
        }

        private void tileLayout1_MouseMove(object sender, MouseEventArgs e)
        {
          //  this.CloseMenu.Start ();
        }


        bool canClose = false;

        private void panel2_MouseEnter_1(object sender, EventArgs e)
        {
            canClose = true;
        }

        private void tileLayout1_MouseDown(object sender, MouseEventArgs e)
        {
            popup.Visible = false;
            this.CloseMenu.Start();

        }

        TreeViewAdv treeViewAdv1 = new TreeViewAdv();
       
        private void getTreeView()
        {
            treeViewAdv1.Nodes.Clear();

            TreeNodeAdv rootNode = new TreeNodeAdv(this.tileLayout1.Text);
            this.treeViewAdv1.Nodes.Add(rootNode);
            this.treeViewAdv1.Refresh();
            this.tileLayout1.Refresh();
           foreach (LayoutGroup group in this.tileLayout1.Controls )
           {
               TreeNodeAdv node = new TreeNodeAdv(group.Text);
               foreach (ImageStreamer img in group.Controls )
               {
                   TreeNodeAdv node1 = new TreeNodeAdv(img.SubText.Text);
                   node.Nodes.Add(node1);
               }
               rootNode.Nodes.Add(node);
           }



            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          //  this.checkBoxAdv2.Checked = !this.checkBoxAdv2.Checked;
    
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (LayoutGroup group in this.tileLayout1.Groups)
            {
                foreach (ImageStreamer img in group.Items)
                {
                    //if(img.Text == "SlideShow"|| img.SlideShow )
                    //img.SlideShow = this.checkBoxAdv2.Checked;
                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            popup.Visible = false;
            foreach (LayoutGroup group in this.tileLayout1.Groups )
            {
                TreeNodeAdv node = new TreeNodeAdv(group.Text);
                foreach (ImageStreamer img in group.Items )
                {
                    img.Refresh();
                }
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            popup.Visible = false;
            this.popup.Controls.Clear();
            this.popup.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(popup);
            popup.BringToFront();
            panel3.BringToFront();
            this.popup.Top = panel3.Top;
            this.popup.BackColor = color.SelectedColor;
            
            this.treeViewAdv1.Dock = DockStyle.Fill;
            popup.Height = panel5.Height *2;
            this.popupOpen.Start();
            this.left = panel9 .Left -40;
            popup.Visible = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            popup.Visible = false;
            this.popup.Controls.Clear();
            this.popup.Controls.Add(panel6);
            this.Controls.Add(popup);
            popup.BringToFront();
            panel3.BringToFront();
            this.popup.Top = panel3.Top;
            this.popup.BackColor = color.SelectedColor;
            this.panel6.BackColor = this.panel3.BackColor;
            popup.Height = panel6.Height;
            popup.Width  = panel6.Width ;
            this.treeViewAdv1.Dock = DockStyle.Fill;
            this.popupOpen.Start();
            left = panel11.Left - 40;
            popup.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            popup.Visible = false;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            popup.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            popup.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }



}
