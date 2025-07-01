using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace BackStageDemo
{
    public partial class Form1 : RibbonForm
    {
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        public Form1()
        {
            InitializeComponent();
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton18));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton5));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3));
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toolStripTabGroup1.Name = "Layout";
            toolStripTabGroup1.Visible = true;
           // this.ribbonControlAdv1.TabGroups.Add(toolStripTabGroup1);
         //   this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3 , toolStripTabGroup1);
          

            this.toolStripButton18.Enabled = false;
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
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(25, 52);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 149);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(181, 195);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.ItemSelection += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_ItemSelection);
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            this.backStageTab1.Controls.Add(this.colorPickerUIAdv1);
            this.colorPickerUIAdv1.Visible = false;
            this.colorPickerUIAdv1.MetroColor = Color.Blue;
            getIcon(false);
            panel2.drawBorder = true;
            panel3.drawline  = true;
            panel4.drawBorder = true;
           
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left + 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width - 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            this.panel3.point = point;
            this.panel3.Invalidate();
            getMenu();
            this.toolStripComboBox1.Items.Add("TimeNewRoman");
            this.toolStripComboBox1.Items.Add("Arial");
            this.toolStripComboBox1.Items.Add("Caibri");
            this.toolStripComboBox1.Items.Add("Segoe UI");
            this.toolStripComboBox2.Items.Add("1");
            this.toolStripComboBox2.Items.Add("2");
            this.toolStripComboBox2.Items.Add("3");
            this.toolStripComboBox2.Items.Add("4");
            this.toolStripComboBox2.Items.Add("5");
            this.toolStripComboBox2.Items.Add("6");
            this.toolStripComboBox2.Items.Add("7");
            this.toolStripComboBox2.Items.Add("8");
            this.toolStripComboBox2.Items.Add("9");
            this.toolStripComboBox2.Items.Add("10");
            this.toolStripComboBox2.Items.Add("11");
            this.toolStripComboBox2.Items.Add("12");
            this.toolStripComboBox2.Items.Add("13");
            this.toolStripComboBox2.Items.Add("14");
            this.toolStripComboBox2.Items.Add("15");
            this.toolStripComboBox2.Items.Add("16");
            this.toolStripComboBox2.Items.Add("17");
            this.toolStripComboBox2.Items.Add("18");
            this.toolStripComboBox2.Items.Add("19");
            this.toolStripComboBox2.Items.Add("20");
            //this.transparentPanel1.drawborder = false;
            //this.transparentPanel2.drawborder = false;
            //this.transparentPanel3.drawborder = false;
       //     panel2.Size = panel3.Size;
            panel2.Location = new Point(0, 0);
         
        }

        private void colorPickerUIAdv1_ItemSelection(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {

        }

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            toolStripTabGroup1.Color = this.ribbonControlAdv1.MenuColor = this.colorPickerUIAdv1.SelectedColor;
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

        private void Form1_Load(object sender, EventArgs e)
        {
         //   this.ribbonControlAdv1.BackStageView.ShowBackStage();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver  ;
        }


        

        private void transparentPanel1_Click(object sender, EventArgs e)
        {
            this.panel3.drawline = true;
            getDisabled();
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007;
          //  this.transparentPanel4.IsActive = true;
            this.panel2.Visible = false;
            this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources._2007blue ;
            this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources._2007silver ;
            this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources._2007black ;
            getIcon(true);
            Point[] point = new Point[2];
            point[0] = new Point (this.transparentPanel1.Left+2 , this.transparentPanel1.Top +this.transparentPanel1.Height-2 );
            point[1] = new Point(this.transparentPanel1.Left + this.transparentPanel1.Width-2, this.transparentPanel1.Top + this.transparentPanel1.Height-2);
            this.panel3.point = point;
            this.panel3.Invalidate();
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonImage = global::WindowsFormsApplication626.Properties.Resources .icon;
          
           
        }

        private void getMenu()
        {

            ToolStripButton toolStripButton231 = new ToolStripButton();
            ToolStripButton toolStripButton81 = new ToolStripButton();
            ToolStripButton toolStripButton91 = new ToolStripButton();
            ToolStripButton toolStripButton101 = new ToolStripButton();

            ToolStripLabel toolStripLabel13 = new ToolStripLabel();
            ToolStripLabel toolStripLabel17 = new ToolStripLabel();
            ToolStripLabel toolStripLabel18 = new ToolStripLabel();

            ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();

            toolStripButton231.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton231.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           // this.toolStripButton231.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            toolStripButton231.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton231.Name = "toolStripButton23";
            toolStripButton231.Padding = new System.Windows.Forms.Padding(5);
            toolStripButton231.Size = new System.Drawing.Size(128, 27);
            toolStripButton231.Text = "Recent Documents";


            // 
            // toolStripButton8
            // 
            toolStripButton81.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;
          
            toolStripButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton81.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton81.Name = "toolStripButton8";
            toolStripButton81.Size = new System.Drawing.Size(69, 36);
            toolStripButton81.Text = "New";

            // 
            // toolStripButton9
            // 
          toolStripButton91.Image  = global::WindowsFormsApplication626.Properties.Resources.Open32 ;
            toolStripButton91.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton91.Name = "toolStripButton9";
            toolStripButton91.Size = new System.Drawing.Size(69, 36);
            toolStripButton91.Text = "Open";
            // 
            // toolStripButton10
            // 
            toolStripButton101.Image =  global::WindowsFormsApplication626.Properties.Resources.Save32  ;
              toolStripButton101.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton101.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton101.Name = "toolStripButton10";
            toolStripButton101.Size = new System.Drawing.Size(69, 36);
            toolStripButton101.Text = "Save";

            // 
            // toolStripLabel13
            // 
            toolStripLabel13.Name = "toolStripLabel13";
            toolStripLabel13.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel13.Size = new System.Drawing.Size(128, 23);
            toolStripLabel13.Text = "1. Document.doc";
            toolStripLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel17
            // 
            toolStripLabel17.Name = "toolStripLabel17";
            toolStripLabel17.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel17.Size = new System.Drawing.Size(128, 23);
            toolStripLabel17.Text = "2. New Features.doc";
            toolStripLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel18
            // 
            toolStripLabel18.Name = "toolStripLabel18";
            toolStripLabel18.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel18.Size = new System.Drawing.Size(128, 23);
            toolStripLabel18.Text = "3. Report.doc";
            toolStripLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5);
            toolStripSeparator1.Size = new System.Drawing.Size(112, 2);

            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton231,
            toolStripSeparator1,
            toolStripLabel13,
            toolStripLabel17,
            toolStripLabel18});
            ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton81,
            toolStripButton91,
            toolStripButton101});
        }

        private void transparentPanel2_Click(object sender, EventArgs e)
        {
            getDisabled();
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010;
            this.panel2.Visible = false;
            this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources._2010blue ;
            this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources._2010 ;
            this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources._2010black ;
            getIcon(true);
            this.panel3.drawline = true;
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel2.Left+2, this.transparentPanel2.Top + this.transparentPanel2.Height-2);
            point[1] = new Point(this.transparentPanel2.Left + this.transparentPanel2.Width-2, this.transparentPanel2.Top + this.transparentPanel2.Height-2);
            this.panel3.point = point;
            this.panel3.Invalidate();
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.MenuButtonImage = null;
          
        }

        private void transparentPanel3_Click(object sender, EventArgs e)
        {
            this.panel3.drawline = true;
            getDisabled();
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.panel2.Visible = true;
            getIcon(false);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left+2, this.transparentPanel3.Top + this.transparentPanel3.Height-2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width-2, this.transparentPanel3.Top + this.transparentPanel3.Height-2);
            this.panel3.point = point;
            this.panel3.Invalidate();
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.MenuButtonImage = null;
            
         
        }
        private void getIcon(bool value)
        {
            if (value)
            {
                this.backStageButton6.Image = global::WindowsFormsApplication626.Properties.Resources.Exit;
                this.backStageButton5.Image = global::WindowsFormsApplication626.Properties.Resources.Options;
                this.backStageButton4.Image = global::WindowsFormsApplication626.Properties.Resources.Close32;
                this.backStageButton3.Image = global::WindowsFormsApplication626.Properties.Resources.Open32;
                this.backStageButton2.Image = global::WindowsFormsApplication626.Properties.Resources.SaveAs32;
                this.backStageButton1.Image = global::WindowsFormsApplication626.Properties.Resources.Save16;
            }
            else
            {
                this.backStageButton6.Image = null;
                this.backStageButton5.Image = null;
                this.backStageButton4.Image = null;
                this.backStageButton3.Image = null;
                this.backStageButton2.Image = null;
                this.backStageButton1.Image = null;
            }
        }

        private void getDisabled()
        {
            getDisabled(false);
        }
        private void getDisabled(bool value)
        {

            if (!value)
            {
                this.transparentPanel1.IsActive = false;
                this.transparentPanel2.IsActive = false;
                this.transparentPanel3.IsActive = false;
            }
            else
            {
                this.transparentPanel4.IsActive = false;
                this.transparentPanel5.IsActive = false;
                this.transparentPanel6.IsActive = false;
            }
        }

        private void transparentPanel4_Click(object sender, EventArgs e)
        {
            getDisabled(true );
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            if (transparentPanel1.IsActive)
            {
                this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources._2007blue ;
          
            }
            else
            {
                this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010blue ;
            }

        }

        private void transparentPanel5_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            if (transparentPanel1.IsActive)
            {
                this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources._2007silver ;

            }
            else
            {
                this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010 ;
            }
        }

        private void transparentPanel6_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            (sender as TransparentPanel).IsActive = true;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black ;
            if (transparentPanel1.IsActive)
            {
                this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources._2007black ;

            }
            else
            {
                this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010black;
            }
        }

        private void transparentPanel12_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles;
        }

        private void transparentPanel8_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds;
        }

        private void transparentPanel9_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D;
        }

        private void transparentPanel10_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles;
        }

        private void transparentPanel11_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies;
        }

        private void transparentPanel16_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral;
        }

        private void transparentPanel15_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2;
        }

        private void transparentPanel14_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows;
        }

        private void transparentPanel13_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines ;
        }

        private void transparentPanel7_Click(object sender, EventArgs e)
        {
            getPanel();
            TransparentPanel panel = sender as TransparentPanel;
            panel.IsActive = true;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes;

        }

        private void getPanel()
        {
            this.transparentPanel7.IsActive = false;
            this.transparentPanel8.IsActive = false;
            this.transparentPanel9.IsActive = false;
            this.transparentPanel10.IsActive = false;
            this.transparentPanel11.IsActive = false;
            this.transparentPanel12.IsActive = false;
            this.transparentPanel13.IsActive = false;
            this.transparentPanel14.IsActive = false;
            this.transparentPanel15.IsActive = false;
            this.transparentPanel16.IsActive = false;
        }
    }


    public class PanelExt : Panel
    {
        public bool drawBorder = false;

        public bool drawline = false;
        public Point[] point = new Point[2];
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

          //  e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Gray , 1);
            if (drawBorder)
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(1, 1, this.Width-3, this.Height-4));
            }
            if (drawline)
            {
                //e.Graphics.DrawLine(pen, new Point(0, this.Height-1), point[0]);
                //e.Graphics.DrawLine(pen, new Point(this.Width-3 , this.Height-1), point[1]);
            }
            pen.Dispose();
        }
    }

    public class TransparentPanel : Control
    {
        public bool drawborder = true;

        public TransparentPanel()
        {
             this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
             this.BackColor = Color.Transparent;
        }

        private bool isActive = false;
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                this.Invalidate();

            }
        }

        private Image image = null;

        public Image Image
        {
            get { return image; }
            set
            {
                image = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.Gray));
            e.Graphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));
            brush.Dispose();
            if (IsActive)
            {
                if (Image != null)
                    e.Graphics.DrawImage(Image, new Point(0, 0));
                if (drawborder)
                {
                    Pen pen = new Pen(Color.RoyalBlue, 4);
                    e.Graphics.DrawRectangle(pen, new Rectangle(1, 1, this.Width - 2, this.Height - 2));
                    pen.Dispose();
                }
                else
                {
                    Pen pen = new Pen(Color.RoyalBlue, 4);
                    e.Graphics.DrawRectangle(pen, new Rectangle(1, 1, this.Width - 2, this.Height +5));
                    pen.Dispose();
                }
            }
            else
            {

                    if (Image != null)
                        ControlPaint.DrawImageDisabled(e.Graphics, Image, 0, 0, Color.Red);
                    Pen pen = new Pen(Color.Gray);
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                    pen.Dispose();

            }
        }
    }
}
