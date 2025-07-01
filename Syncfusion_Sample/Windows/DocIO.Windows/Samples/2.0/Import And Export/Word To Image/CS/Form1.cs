#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace EssentialDocIOSamples
{

    public class Form1 : System.Windows.Forms.Form
    {
        #region Private Members

        private ToolTip toolTip1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label24;
        private RadioButton emfRadioBtn;
        private RadioButton pngRadioBtn;
        private RadioButton jpegRadioBtn;
        private Label label4;
        private RadioButton bmpRadioBtn;
        private Label label5;
        private Button button3;
        private TextBox textBox1;
        private Label label9;
        private OpenFileDialog openFileDialog1;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bmpRadioBtn = new System.Windows.Forms.RadioButton();
            this.emfRadioBtn = new System.Windows.Forms.RadioButton();
            this.pngRadioBtn = new System.Windows.Forms.RadioButton();
            this.jpegRadioBtn = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(323, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 102;
            this.toolTip1.SetToolTip(this.label3, "Converts the Word document to EMF image");
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label1, "Converts the Word document to JPEG image");
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(66, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 100;
            this.toolTip1.SetToolTip(this.label24, "Converts the Word document to PNG image.");
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(240, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 18);
            this.label4.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label4, "Converts the Word document to BMP image");
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(118, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label5, "Browse for a word document to convert it to Image");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(268, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 62;
            this.button1.Text = "WordToImage";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 97);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 44);
            this.label2.TabIndex = 68;
            this.label2.Text = "Clicking the button below will result in a Image being converted from word docume" +
    "nt using Essential DocIO.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bmpRadioBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.emfRadioBtn);
            this.groupBox1.Controls.Add(this.pngRadioBtn);
            this.groupBox1.Controls.Add(this.jpegRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 51);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert To";
            // 
            // bmpRadioBtn
            // 
            this.bmpRadioBtn.AutoSize = true;
            this.bmpRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bmpRadioBtn.Location = new System.Drawing.Point(193, 22);
            this.bmpRadioBtn.Name = "bmpRadioBtn";
            this.bmpRadioBtn.Size = new System.Drawing.Size(49, 17);
            this.bmpRadioBtn.TabIndex = 103;
            this.bmpRadioBtn.Text = "BMP";
            this.bmpRadioBtn.UseVisualStyleBackColor = true;
            // 
            // emfRadioBtn
            // 
            this.emfRadioBtn.AutoSize = true;
            this.emfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emfRadioBtn.Location = new System.Drawing.Point(277, 21);
            this.emfRadioBtn.Name = "emfRadioBtn";
            this.emfRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.emfRadioBtn.TabIndex = 46;
            this.emfRadioBtn.Text = "EMF";
            this.emfRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pngRadioBtn
            // 
            this.pngRadioBtn.AutoSize = true;
            this.pngRadioBtn.Checked = true;
            this.pngRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pngRadioBtn.Location = new System.Drawing.Point(13, 22);
            this.pngRadioBtn.Name = "pngRadioBtn";
            this.pngRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.pngRadioBtn.TabIndex = 44;
            this.pngRadioBtn.TabStop = true;
            this.pngRadioBtn.Text = "PNG";
            this.pngRadioBtn.UseVisualStyleBackColor = true;
            // 
            // jpegRadioBtn
            // 
            this.jpegRadioBtn.AutoSize = true;
            this.jpegRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.jpegRadioBtn.Location = new System.Drawing.Point(105, 23);
            this.jpegRadioBtn.Name = "jpegRadioBtn";
            this.jpegRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.jpegRadioBtn.TabIndex = 45;
            this.jpegRadioBtn.Text = "JPEG";
            this.jpegRadioBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(349, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 103;
            this.button3.Text = ". . .";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(2, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Word Document";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 310);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordToImage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                // Load the Document
                WordDocument wordDoc = new WordDocument((string)textBox1.Tag, Syncfusion.DocIO.FormatType.Automatic);
                // Convert Word Document into image
                Image[] image = wordDoc.RenderAsImages(ImageType.Metafile);
                int pageNumber = 0;
                //Save as Bitmap image
                if (bmpRadioBtn.Checked)
                {
                    for (int i = 0; i < image.Length; i++)
                    {
                        image[i].Save(@"WordToImage_" + ++pageNumber + ".bmp", ImageFormat.Bmp);
                    }
                    if (MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(@"WordToImage_1.bmp");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as PNG image
                else if (pngRadioBtn.Checked)
                {
                    for (int i = 0; i < image.Length; i++)
                    {
                        image[i].Save(@"WordToImage_" + ++pageNumber + ".png", ImageFormat.Png);
                    }
                    if (MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(@"WordToImage_1.png");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as JPEG image
                else if (jpegRadioBtn.Checked)
                {
                    for (int i = 0; i < image.Length; i++)
                    {
                        image[i].Save(@"WordToImage_" + ++pageNumber + ".jpeg", ImageFormat.Jpeg);
                    }
                    if (MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(@"WordToImage_1.jpeg");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as EMF image
                else if (emfRadioBtn.Checked)
                {
                    for (int i = 0; i < image.Length; i++)
                    {
                        MemoryStream stream = (MemoryStream)wordDoc.RenderAsImages(i, ImageFormat.Emf);
                        using (FileStream fstream = new FileStream(@"WordToImage_" + ++pageNumber + ".emf", FileMode.OpenOrCreate))
                        {
                            stream.WriteTo(fstream);
                        }
                    }
                    if (MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(@"WordToImage_1.emf");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Browse a word document and click the button to convert as a Image.");
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToImage.docx";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToImage.docx";
        }
    }
}

