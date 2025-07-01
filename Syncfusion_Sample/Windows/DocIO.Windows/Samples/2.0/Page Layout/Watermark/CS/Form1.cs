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

using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;

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
        private Label label1;
        private RadioButton word2013RadioBtn;
        private Label label6;
        private Label label7;
        private Label label24;
        private RadioButton word2010RadioBtn;
        private RadioButton word2003RadioBtn;
        private RadioButton word2007RadioBtn;
        private Label label5;
        private Panel panel2;
        private Label label3;
        private RadioButton rdbTextWatermark;
        private RadioButton rdbPicWatermark;
        private Label label4;
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.word2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2007RadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTextWatermark = new System.Windows.Forms.RadioButton();
            this.rdbPicWatermark = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(221, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label1, "Saves the document in Word 2013 format");
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(107, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 18);
            this.label6.TabIndex = 102;
            this.toolTip1.SetToolTip(this.label6, "Saves the document in Word 2010 format");
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(221, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label7, "Saves the document in Word 2007 format");
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(107, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 100;
            this.toolTip1.SetToolTip(this.label24, "Saves the document in Word 97-2003 format\r\n");
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(82, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 52;
            this.toolTip1.SetToolTip(this.label3, "Saves the Document in Microsoft Word 2003 format");
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(80, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 53;
            this.toolTip1.SetToolTip(this.label4, "Saves the Document in Microsoft Word 2007 format");
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
            this.button1.Location = new System.Drawing.Point(281, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 68;
            this.button1.Text = "Generate";
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
            this.pictureBox1.Size = new System.Drawing.Size(392, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 50);
            this.label2.TabIndex = 75;
            this.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.word2013RadioBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.word2010RadioBtn);
            this.groupBox1.Controls.Add(this.word2003RadioBtn);
            this.groupBox1.Controls.Add(this.word2007RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 70);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // word2013RadioBtn
            // 
            this.word2013RadioBtn.AutoSize = true;
            this.word2013RadioBtn.Checked = true;
            this.word2013RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2013RadioBtn.Location = new System.Drawing.Point(139, 46);
            this.word2013RadioBtn.Name = "word2013RadioBtn";
            this.word2013RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2013RadioBtn.TabIndex = 103;
            this.word2013RadioBtn.TabStop = true;
            this.word2013RadioBtn.Text = "Word 2013";
            this.word2013RadioBtn.UseVisualStyleBackColor = true;
            // 
            // word2010RadioBtn
            // 
            this.word2010RadioBtn.AutoSize = true;
            this.word2010RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2010RadioBtn.Location = new System.Drawing.Point(6, 46);
            this.word2010RadioBtn.Name = "word2010RadioBtn";
            this.word2010RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2010RadioBtn.TabIndex = 46;
            this.word2010RadioBtn.Text = "Word 2010";
            this.word2010RadioBtn.UseVisualStyleBackColor = true;
            // 
            // word2003RadioBtn
            // 
            this.word2003RadioBtn.AutoSize = true;
            this.word2003RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.word2003RadioBtn.Location = new System.Drawing.Point(6, 20);
            this.word2003RadioBtn.Name = "word2003RadioBtn";
            this.word2003RadioBtn.Size = new System.Drawing.Size(105, 17);
            this.word2003RadioBtn.TabIndex = 44;
            this.word2003RadioBtn.Text = "Word 97-2003";
            this.word2003RadioBtn.UseVisualStyleBackColor = true;
            // 
            // word2007RadioBtn
            // 
            this.word2007RadioBtn.AutoSize = true;
            this.word2007RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.word2007RadioBtn.Location = new System.Drawing.Point(139, 20);
            this.word2007RadioBtn.Name = "word2007RadioBtn";
            this.word2007RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2007RadioBtn.TabIndex = 45;
            this.word2007RadioBtn.Text = "Word 2007";
            this.word2007RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 103;
            this.label5.Text = "Watermark";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdbTextWatermark);
            this.panel2.Controls.Add(this.rdbPicWatermark);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 68);
            this.panel2.TabIndex = 102;
            // 
            // rdbTextWatermark
            // 
            this.rdbTextWatermark.AutoSize = true;
            this.rdbTextWatermark.Location = new System.Drawing.Point(18, 43);
            this.rdbTextWatermark.Name = "rdbTextWatermark";
            this.rdbTextWatermark.Size = new System.Drawing.Size(46, 17);
            this.rdbTextWatermark.TabIndex = 1;
            this.rdbTextWatermark.Text = "Text";
            // 
            // rdbPicWatermark
            // 
            this.rdbPicWatermark.AutoSize = true;
            this.rdbPicWatermark.Checked = true;
            this.rdbPicWatermark.Location = new System.Drawing.Point(18, 15);
            this.rdbPicWatermark.Name = "rdbPicWatermark";
            this.rdbPicWatermark.Size = new System.Drawing.Size(58, 17);
            this.rdbPicWatermark.TabIndex = 0;
            this.rdbPicWatermark.TabStop = true;
            this.rdbPicWatermark.Text = "Picture";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 296);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
		{

            if (!(rdbPicWatermark.Checked) && !(rdbTextWatermark.Checked))
            {
                MessageBox.Show("Please select a watermark type");

            }

            else
            {
                //Open an existing word document 
                WordDocument doc = new WordDocument(@"..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Watermark.doc");

                if (rdbTextWatermark.Checked)
                {
                    //Add text watermark.
                    TextWatermark textWatermark = new TextWatermark();
                    doc.Watermark = textWatermark;

                    //Set the text for the watermark.
                    textWatermark.Text = "Demo";

                    //Set the color for the watermark text.
                    textWatermark.Color = Color.Gray;

                    //Set the size.
                    textWatermark.Size = 120;

                }

                else if (rdbPicWatermark.Checked)
                {

                    //Add Picture watermark to the word document.
                    PictureWatermark picWatermark = new PictureWatermark();
                    doc.Watermark = picWatermark;

                    //Set the picture.
                    picWatermark.Picture = Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\Images\DocIO\syncfusion_logo.gif");

                    //Set the properties for the watermark.
                    picWatermark.Scaling = 100.0f;
                    picWatermark.Washout = false;

                }

                //Save as word 2003 format
                if (word2003RadioBtn.Checked)
                {
                    //Saving the document to disk.
                    doc.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc");
                        //Exit
                        this.Close();
                    }
                }
                //Save as word 2007 format
                else if (word2007RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2007);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2007 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as word 2010  format
                else if (word2010RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2010);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2010 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as word 2013  format
                else if (word2013RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2013);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2013 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
               

                
            }
		}
        #endregion

    }
}
