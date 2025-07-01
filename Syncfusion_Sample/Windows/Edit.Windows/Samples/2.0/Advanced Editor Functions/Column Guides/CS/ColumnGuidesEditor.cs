#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ColumnGuidesDemo
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class ColumnGuidesEditor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		public static string[] columnnumber,color;
		private char[] colorchar;
		public static string columnnumbers,colors;
		public static int columncount,colorcount;
        private int index,arrayindex=0;
		public static bool invalidinput=false;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ColumnGuidesEditor()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            this.AcceptButton.DialogResult = DialogResult.OK;
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(277, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the column numbers separated by commas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the column guide colors (eg. Red) separated by commas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 1;
            // 
            // ColumnGuidesEditor
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(370, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ColumnGuidesEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Column Guides Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void button1_Click(object sender, System.EventArgs e)
		{   
			if(this.textBox1.Text != "" && this.textBox2.Text != "")
			{
				columncount = 1;
				arrayindex = 0;
				colorcount = 1;
                columnnumber = new string[10];
                color = new string[30];
                colorchar = new char[30];
                this.textBox1.Text = this.textBox1.Text.Replace(" ", "");
                this.textBox2.Text = this.textBox2.Text.Replace(" ", "");

                columnnumbers = this.textBox1.Text;
				for(;;)
				{
                    index = columnnumbers.LastIndexOf(",");
					if(index != -1)
					{
                        columnnumber[arrayindex++] = columnnumbers.Substring(index + 1);
                        columnnumbers = columnnumbers.Substring(0, index);
                        columncount++;
					}
					else
					{
                        columnnumber[arrayindex] = columnnumbers;
						break;
					}
				}
                arrayindex = 0;
                colors = this.textBox2.Text.ToLower();

                for (; ; )
                {
                    index = colors.LastIndexOf(",");
					if(index != -1)
					{
                        color[arrayindex] = colors.Substring(index + 1);
                       
                        colorchar = color[arrayindex].ToCharArray();
                        if (colorchar.Length > 0)
                        {
                            color[arrayindex] = ((colorchar[0].ToString()).ToUpper());
                            color[arrayindex] = string.Concat(color[arrayindex], colors.Substring(index + 2));
                            arrayindex++;
                            colors = colors.Substring(0, index);
                            colorcount++;
                        }
                        else
                            break;
					}
                    else
                    {
                        color[arrayindex] = colors;
                        colorchar = color[arrayindex].ToCharArray();
                        color[arrayindex] = ((colorchar[0].ToString()).ToUpper());
                        color[arrayindex] = string.Concat(color[arrayindex], colors.Substring(1, colors.Length - 1));
                        break;
                    }
                }
				if(columncount == colorcount)
				{
                    invalidinput = false;
					this.Close(); 
				}
				else
				{
					MessageBox.Show("Number of Colors should be equal to the number of Columns");
                    invalidinput = true;
				}
			    
			}
		}
	}
}
