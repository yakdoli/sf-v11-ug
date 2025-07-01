using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Printing;
using System.Threading;
using System.Diagnostics;
using DemoCommon.Diagram;

namespace LocalizingDialogs
{
    public class Form1 : DemoForm
    {
        #region Memberrs

        private Button PageSetup;
        private Button PageBorder;
        private Expander panel2;
        private Button HeaderFooter;
        private TitlePanel panel1;
        private Panel panel3;
        private Diagram diagram1;
        private Model model1;
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Form Initialize

        public Form1()
        {
            InitializeComponent();
            
            //Code to fetch the German resources at run time.
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");

            //Load a diagram.
            diagram1.LoadBinary("..\\..\\Data\\SimpleDiagram.edd");
                diagram1.Model.BackgroundStyle.Color = Color.White;
            foreach (Node node in diagram1.Model.Nodes)
                node.EditStyle.AllowSelect = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PageSetup = new System.Windows.Forms.Button();
            this.PageBorder = new System.Windows.Forms.Button();
            this.panel2 = new DemoCommon.Diagram.Expander();
            this.HeaderFooter = new System.Windows.Forms.Button();
            this.panel1 = new DemoCommon.Diagram.TitlePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageSetup
            // 
            this.PageSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.PageSetup.FlatAppearance.BorderSize = 0;
            this.PageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageSetup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSetup.ForeColor = System.Drawing.Color.White;
            this.PageSetup.Location = new System.Drawing.Point(13, 143);
            this.PageSetup.Name = "PageSetup";
            this.PageSetup.Size = new System.Drawing.Size(153, 25);
            this.PageSetup.TabIndex = 36;
            this.PageSetup.Text = "PageSetup Dialog";
            this.PageSetup.UseVisualStyleBackColor = false;
            this.PageSetup.Click += new System.EventHandler(this.PageSetup_Click);
            // 
            // PageBorder
            // 
            this.PageBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.PageBorder.FlatAppearance.BorderSize = 0;
            this.PageBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageBorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageBorder.ForeColor = System.Drawing.Color.White;
            this.PageBorder.Location = new System.Drawing.Point(13, 97);
            this.PageBorder.Name = "PageBorder";
            this.PageBorder.Size = new System.Drawing.Size(153, 25);
            this.PageBorder.TabIndex = 35;
            this.PageBorder.Text = "PageBorder Dialog";
            this.PageBorder.UseVisualStyleBackColor = false;
            this.PageBorder.Click += new System.EventHandler(this.PageBorder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel2.Caption = "Dialogs";
            this.panel2.Controls.Add(this.PageSetup);
            this.panel2.Controls.Add(this.PageBorder);
            this.panel2.Controls.Add(this.HeaderFooter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(553, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(200, 386);
            this.panel2.TabIndex = 4;
            // 
            // HeaderFooter
            // 
            this.HeaderFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.HeaderFooter.FlatAppearance.BorderSize = 0;
            this.HeaderFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderFooter.ForeColor = System.Drawing.Color.White;
            this.HeaderFooter.Location = new System.Drawing.Point(13, 50);
            this.HeaderFooter.Name = "HeaderFooter";
            this.HeaderFooter.Size = new System.Drawing.Size(153, 25);
            this.HeaderFooter.TabIndex = 34;
            this.HeaderFooter.Text = "HeaderFooter Dialog";
            this.HeaderFooter.UseVisualStyleBackColor = false;
            this.HeaderFooter.Click += new System.EventHandler(this.HeaderFooter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panel1.ControlBox = false;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Form = this;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 70);
            this.panel1.TabIndex = 7;
            this.panel1.TitleText = "Localization Demo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diagram1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 386);
            this.panel3.TabIndex = 8;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(551, 386);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            this.diagram1.VScroll = true;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localization Demo";            
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string targetPath = Application.StartupPath + "\\" + "de-DE";
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\Syncfusion.Diagram.Windows.resources.dll");
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                System.IO.File.Copy(sourceFile, targetPath + "\\Syncfusion.Diagram.Windows.resources.dll");
            }
            ProcessStartInfo pstart = new ProcessStartInfo("..\\..\\Data\\run.bat");
            pstart.UseShellExecute = false;
            //Hide DOS window
            pstart.CreateNoWindow = true;
            Process.Start(pstart);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion

        #region Class Events
        private void HeaderFooter_Click(object sender, EventArgs e)
        {
            HeaderFooterDialog dlgHF = new HeaderFooterDialog();
            dlgHF.Header = diagram1.Model.HeaderFooterData.Header;
            dlgHF.Footer = diagram1.Model.HeaderFooterData.Footer;
            dlgHF.MeasurementUnits = diagram1.Model.MeasurementUnits;
            if (dlgHF.ShowDialog() == DialogResult.OK)
            {
                diagram1.Model.HeaderFooterData.Header = dlgHF.Header;
                diagram1.Model.HeaderFooterData.Footer = dlgHF.Footer;
            }
        }

        private void PageBorder_Click(object sender, EventArgs e)
        {
            PageBorderDialog borderDialog = new PageBorderDialog();
            borderDialog.PageBorderStyle = diagram1.View.PageBorderStyle;
            if (borderDialog.ShowDialog() == DialogResult.OK)
            {
                diagram1.View.PageBorderStyle = borderDialog.PageBorderStyle;
                diagram1.View.RefreshPageSettings();
                diagram1.UpdateView();
            }
        }

        private void PageSetup_Click(object sender, EventArgs e)
        {
            PrintSetupDialog dlgPrintSetup = new PrintSetupDialog();

            // Made to make values more user friendly. 
            dlgPrintSetup.PageSettings = this.diagram1.View.PageSettings;
            dlgPrintSetup.PrintZoom = this.diagram1.View.PrintZoom;

            if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
            {
                this.diagram1.View.PageSettings = dlgPrintSetup.PageSettings;
                this.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom;
                this.diagram1.View.RefreshPageSettings();
            }
        }

       
        #endregion                   
    }
}