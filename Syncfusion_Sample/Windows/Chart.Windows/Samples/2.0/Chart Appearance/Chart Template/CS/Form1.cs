using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using System.IO;

namespace ChartTemplate_2005
{
    public partial class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        Color[] color1 = new Color[] { Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231) };
        Color[] color2 = new Color[] { Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206) };
        Form2 frm = new Form2();
        string filePath;
        string defaultPath;
     
        #region Constructor
        public Form1()
        {
            InitializeComponent();
           
            this.propertyGrid1.SelectedObject = this.chartControl1;
            this.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(213, 228, 242);
            this.propertyGrid1.LineColor = System.Drawing.Color.FromArgb(213, 228, 242);
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(213, 228, 242);
            this.ActiveControl = this.buttonAdv1;
            this.buttonAdv1.State = ButtonAdvState.Pressed;
            frm.buttonAdv1.Click +=new EventHandler(buttonAdv1_Click);
            frm.buttonAdv2.Click +=new EventHandler(buttonAdv2_Click);
           
            //Copies the required template files to the Debug folder from Template folder
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            di = di.Parent.Parent;
            filePath = di.FullName + @"\..\Templates";
            defaultPath = Application.StartupPath.ToString();
            DirectoryInfo dir = new DirectoryInfo(filePath);
            FileInfo[] files = dir.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                Char[] ch = new Char[]{'D','e','b','u','g'};
                string newFile = file.Name.TrimStart(ch);
                defaultPath = Application.StartupPath.ToString() + "\\" + newFile;
                file.CopyTo(defaultPath, true);
            }
            InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion
        
        #region InitializeChartData
        public void InitializeChart()
        {
            // Initialize ChartSeries
            ChartSeries series1 = new ChartSeries("Hard Device");
             
            series1.Points.Add(1, 187);
            series1.Points.Add(2, 151);
            series1.Points.Add(3, 180);
            series1.Points.Add(4, 206);
            series1.Points.Add(5, 122);
            series1.Points.Add(6, 31);
            series1.Points.Add(7, 189);
            series1.Points.Add(8, 54);
            series1.Points.Add(9, 181);
            series1.Points.Add(10, 201);
            series1.Points.Add(11, 391);
            series1.Points.Add(12, 311);

            series1.Styles[0].Text = string.Format("{0}", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("{0}", series1.Points[1].YValues[0]);
            series1.Styles[2].Text = string.Format("{0}", series1.Points[2].YValues[0]);
            series1.Styles[3].Text = string.Format("{0}", series1.Points[3].YValues[0]);
            series1.Styles[4].Text = string.Format("{0}", series1.Points[4].YValues[0]);

            series1.Style.TextColor = Color.Black;
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Monitor");           
            series2.Points.Add(1, 256);
            series2.Points.Add(2, 451);
            series2.Points.Add(3, 382);
            series2.Points.Add(4, 437);
            series2.Points.Add(5, 321);
            series2.Points.Add(6, 234);
            series2.Points.Add(7, 425);
            series2.Points.Add(8, 257);
            series2.Points.Add(9, 382);
            series2.Points.Add(10, 301);
            series2.Points.Add(11, 472);
            series2.Points.Add(12, 421);

            series2.Styles[0].Text = string.Format("{0}", series1.Points[0].YValues[0]);
            series2.Styles[1].Text = string.Format("{0}", series1.Points[1].YValues[0]);
            series2.Styles[2].Text = string.Format("{0}", series1.Points[2].YValues[0]);
            series2.Styles[3].Text = string.Format("{0}", series1.Points[3].YValues[0]);
            series2.Styles[4].Text = string.Format("{0}", series1.Points[4].YValues[0]);
            series2.Style.TextColor = Color.Black;

            this.chartControl1.Series.Add(series2);
            chartControl1.Series[0].Style.Border.Color = Color.Gray;
            chartControl1.Series[1].Style.Border.Color = Color.Gray;
            chartControl1.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
            chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 13, 1);
            ChartTemplate ct = new ChartTemplate(typeof(ChartControl));
            ct.Load("Column_Square.xml");
            ct.Apply(this.chartControl1);
            chartControl1.Series3D = false;     
        }

        #endregion      

        #region Save Template
        int templateCount = 0;
        string saveTemplateFile = "";
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
           //Saves file to the same template
            if (frm.radioButton1.Checked)
            {
                 ChartTemplate.Save(this.chartControl1, currentTemplate);
            }
            //Saves file to a new template
            if (frm.radioButton2.Checked)
            {
                if (templateCount < 2)
                 {        
                   if (templateCount == 0)
                   {
                    this.buttonAdv7.Visible = true;
                   }
                   if (templateCount == 1)
                   {
                    this.buttonAdv10.Visible = true;
                   }                 
                   templateCount = templateCount + 1;
                
                  
                 saveTemplateFile = "Template" + templateCount.ToString() + ".xml";
                 ChartTemplate.Save(this.chartControl1, saveTemplateFile); 
                
                }
             else
             {
                MessageBox.Show("Programmed to add only two user defined templates");
             }
            }
            frm.Hide();
            
        }
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }
       
        private void SaveTemplate_Click(object sender, EventArgs e)
        {
           
            frm.Show();
          
        }
        #endregion

        #region ContextMenu - Copy To clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cc = "";
            switch (this.contextMenuStrip1.SourceControl.Name)
            {              
                case "buttonAdv1":
                    cc =  Application.StartupPath.ToString() + "\\Column_Cylinder.xml";
                    break;
                case "buttonAdv2":
                    cc = Application.StartupPath.ToString() + "\\Column_Square.xml";
                    break;
                case "buttonAdv3":
                    cc = Application.StartupPath.ToString() + "\\Area.xml";
                    break;
                case "buttonAdv4":
                    cc = Application.StartupPath.ToString() + "\\Area_3D.xml";
                    break;
                case "buttonAdv5":
                    cc = Application.StartupPath.ToString() + "\\Line.xml";
                    break;
                case "buttonAdv6":
                    cc = Application.StartupPath.ToString() + "\\Line_3D.xml";
                    break;
                case "buttonAdv7":
                    cc = Application.StartupPath.ToString() + "\\Template1.xml";
                    break;
                case "buttonAdv10":
                    cc = Application.StartupPath.ToString() + "\\Template2.xml";
                    break;
            }
            Clipboard.SetDataObject(cc, true);
        }
        #endregion

        #region Load template
        string currentTemplate = "Column_Square.xml";
        private void ChartType_Click(object sender, EventArgs e)
        {
            ButtonAdv chartButton = sender as ButtonAdv;
            string filePath = Application.StartupPath.ToString();
            foreach (ButtonAdv buttonAdv in this.panel1.Controls)
            {
                buttonAdv.State = ButtonAdvState.Default;
                buttonAdv.Refresh();
            }
            if (chartButton == this.buttonAdv1)
            {
                #region Control settings
                color2 = new Color[] { Color.FromArgb(255, 158, 49), Color.FromArgb(255, 158, 49), Color.FromArgb(255, 158, 49) };
                color1 = new Color[] { Color.FromArgb(255, 199, 165), Color.FromArgb(255, 199, 165), Color.FromArgb(255, 199, 165) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Column_Cylinder.xml";
                currentTemplate = "Column_Cylinder.xml";
                this.buttonAdv1.State = ButtonAdvState.Pressed;
                 #endregion
                
            }
            if (chartButton == this.buttonAdv2)
            {
                #region Control settings
                color1 = new Color[] { Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231), Color.FromArgb(173, 211, 231) };
                color2 = new Color[] { Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206), Color.FromArgb(74, 174, 206) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Column_Square.xml";
                this.buttonAdv2.State = ButtonAdvState.Pressed;
                currentTemplate = "Column_Square.xml";
                #endregion
               
            }
            if (chartButton == this.buttonAdv3)
            {
                #region Control settings
                color1 = new Color[] { Color.FromArgb(189, 178, 206), Color.FromArgb(189, 178, 206), Color.FromArgb(189, 178, 206) };
                color2 = new Color[] { Color.FromArgb(132, 101, 173), Color.FromArgb(132, 101, 173), Color.FromArgb(132, 101, 173) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Area.xml";
                this.buttonAdv3.State = ButtonAdvState.Pressed;
                currentTemplate = "Area.xml";
                #endregion
              
            }
            if (chartButton == this.buttonAdv4)
            {
                #region Control settings
                color1 = new Color[] { Color.FromArgb(198, 195, 198), Color.FromArgb(198, 195, 198), Color.FromArgb(198, 195, 198) };
                color2 = new Color[] { Color.FromArgb(140, 142, 140), Color.FromArgb(140, 142, 140), Color.FromArgb(140, 142, 140) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Area_3D.xml";
                this.buttonAdv4.State = ButtonAdvState.Pressed;
                currentTemplate = "Area_3D.xml";
                #endregion
               
            }
            if (chartButton == this.buttonAdv5)
            {
                #region Control settings
                color1 = new Color[] { Color.FromArgb(156, 186, 82), Color.FromArgb(156, 186, 82), Color.FromArgb(156, 186, 82) };
                color2 = new Color[] { Color.FromArgb(132, 154, 74), Color.FromArgb(132, 154, 74), Color.FromArgb(132, 154, 74) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Line.xml";
                this.buttonAdv5.State = ButtonAdvState.Pressed;
                currentTemplate = "Line.xml";
                #endregion
               
            }
            if (chartButton == this.buttonAdv6)
            {
                #region Control settings
                color1 = new Color[] { Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194) };
                color2 = new Color[] { Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90) };
                this.toolStripStatusLabel1.Text = filePath  + "\\Line_3D.xml";
                this.buttonAdv6.State = ButtonAdvState.Pressed;
                currentTemplate = "Line_3D.xml";
                #endregion
               
            }
            if (chartButton == this.buttonAdv7)
            {
                #region Control settings
                color1 = new Color[] { Color.White, Color.WhiteSmoke, Color.White };
                color2 = new Color[] { Color.Black, Color.Gray, Color.Black};
               
                this.toolStripStatusLabel1.Text = filePath  + "\\Template1.xml";
                this.buttonAdv7.State = ButtonAdvState.Pressed;
                currentTemplate = "Template1.xml";
                #endregion
               
            }
            if (chartButton == this.buttonAdv10)
            {
                #region Control settings
                this.toolStripStatusLabel1.Text = filePath  + "\\Template2.xml";
                this.buttonAdv10.State = ButtonAdvState.Pressed;
                currentTemplate = "Template2.xml";
                 #endregion
            
            }

            ChartTemplate.Load(this.chartControl1, currentTemplate);
              
            #region Control settings
            this.chartControl1.Series[0].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color1);
            this.chartControl1.Series[1].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color2);
            this.propertyGrid1.Refresh();
            #endregion
        }
        #endregion        

    }
}