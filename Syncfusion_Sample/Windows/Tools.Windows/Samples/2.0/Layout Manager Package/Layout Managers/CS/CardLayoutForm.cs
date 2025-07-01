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

namespace LayoutManagers
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;

	using Syncfusion.Windows.Forms.Tools;

	/// <summary>
	/// Summary description for CardLayoutForm.
	/// </summary>
	public class CardLayoutForm : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.CardLayout cardLayout1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button moveNext;
		private System.Windows.Forms.Button movePrevious;
		private System.ComponentModel.IContainer components;

		public CardLayoutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CardLayoutForm));
			this.cardLayout1 = new Syncfusion.Windows.Forms.Tools.CardLayout(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.moveNext = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.movePrevious = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cardLayout1
			// 
			this.cardLayout1.ContainerControl = this.panel1;
			this.cardLayout1.SelectedCard = "Card1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1,
																				 this.label2,
																				 this.label3,
																				 this.label4,
																				 this.label5,
																				 this.label6,
																				 this.label7,
																				 this.label8,
																				 this.label9,
																				 this.label10});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(456, 316);
			this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.cardLayout1.SetCardName(this.label1, "Card1");
            this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(189, 119);
            this.cardLayout1.SetMinimumSize(this.label1, new System.Drawing.Size(75, 75));
            this.label1.Name = "label1";
            this.cardLayout1.SetPreferredSize(this.label1, new System.Drawing.Size(75, 75));
            this.label1.Size = new System.Drawing.Size(75, 75);
            this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.cardLayout1.SetCardName(this.label2, "Card2");
			this.label2.Image = ((System.Drawing.Bitmap)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(177, 107);
			this.cardLayout1.SetMinimumSize(this.label2, new System.Drawing.Size(100, 100));
			this.label2.Name = "label2";
			this.cardLayout1.SetPreferredSize(this.label2, new System.Drawing.Size(100, 100));
			this.label2.Size = new System.Drawing.Size(100, 100);
			this.label2.TabIndex = 1;
			this.label2.Visible = false;
            // 
            // label3
            // 
            this.cardLayout1.SetCardName(this.label3, "Card3");
            this.label3.Image = ((System.Drawing.Bitmap)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(172, 102);
            this.cardLayout1.SetMinimumSize(this.label3, new System.Drawing.Size(110, 110));
            this.label3.Name = "label3";
            this.cardLayout1.SetPreferredSize(this.label3, new System.Drawing.Size(110, 110));
            this.label3.Size = new System.Drawing.Size(110, 110);
            this.label3.TabIndex = 2;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.cardLayout1.SetCardName(this.label4, "Card4");
            this.label4.Image = ((System.Drawing.Bitmap)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(189, 119);
            this.cardLayout1.SetMinimumSize(this.label4, new System.Drawing.Size(75, 75));
            this.label4.Name = "label4";
            this.cardLayout1.SetPreferredSize(this.label4, new System.Drawing.Size(75, 75));
            this.label4.Size = new System.Drawing.Size(75, 75);
            this.label4.TabIndex = 3;
            this.label4.Visible = false;
			// 
			// label5
			// 
			this.cardLayout1.SetCardName(this.label5, "Card5");
			this.label5.Image = ((System.Drawing.Bitmap)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(177, 107);
			this.cardLayout1.SetMinimumSize(this.label5, new System.Drawing.Size(100, 100));
			this.label5.Name = "label5";
			this.cardLayout1.SetPreferredSize(this.label5, new System.Drawing.Size(100, 100));
			this.label5.Size = new System.Drawing.Size(100, 100);
			this.label5.TabIndex = 4;
			this.label5.Visible = false;
            // 
            // label6
            // 
            this.cardLayout1.SetCardName(this.label6, "Card6");
            this.label6.Image = ((System.Drawing.Bitmap)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(202, 132);
            this.cardLayout1.SetMinimumSize(this.label6, new System.Drawing.Size(50, 50));
            this.label6.Name = "label6";
            this.cardLayout1.SetPreferredSize(this.label6, new System.Drawing.Size(50, 50));
            this.label6.Size = new System.Drawing.Size(50, 50);
            this.label6.TabIndex = 5;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.cardLayout1.SetCardName(this.label7, "Card7");
            this.label7.Image = ((System.Drawing.Bitmap)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(194, 124);
            this.cardLayout1.SetMinimumSize(this.label7, new System.Drawing.Size(65, 65));
            this.label7.Name = "label7";
            this.cardLayout1.SetPreferredSize(this.label7, new System.Drawing.Size(65, 65));
            this.label7.Size = new System.Drawing.Size(65, 65);
            this.label7.TabIndex = 6;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.cardLayout1.SetCardName(this.label8, "Card8");
            this.label8.Image = ((System.Drawing.Bitmap)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(192, 122);
            this.cardLayout1.SetMinimumSize(this.label8, new System.Drawing.Size(70, 70));
            this.label8.Name = "label8";
            this.cardLayout1.SetPreferredSize(this.label8, new System.Drawing.Size(70, 70));
            this.label8.Size = new System.Drawing.Size(70, 70);
            this.label8.TabIndex = 7;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.cardLayout1.SetCardName(this.label9, "Card9");
            this.label9.Image = ((System.Drawing.Bitmap)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(192, 107);
            this.cardLayout1.SetMinimumSize(this.label9, new System.Drawing.Size(70, 100));
            this.label9.Name = "label9";
            this.cardLayout1.SetPreferredSize(this.label9, new System.Drawing.Size(70, 100));
            this.label9.Size = new System.Drawing.Size(70, 100);
            this.label9.TabIndex = 8;
            this.label9.Visible = false;
			// 
			// label10
			// 
			this.cardLayout1.SetCardName(this.label10, "Card10");
			this.label10.Image = ((System.Drawing.Bitmap)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(189, 119);
			this.cardLayout1.SetMinimumSize(this.label10, new System.Drawing.Size(75, 75));
			this.label10.Name = "label10";
			this.cardLayout1.SetPreferredSize(this.label10, new System.Drawing.Size(75, 75));
			this.label10.Size = new System.Drawing.Size(75, 75);
			this.label10.TabIndex = 9;
			this.label10.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label11,
																				 this.moveNext,
																				 this.comboBox1,
																				 this.movePrevious});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(456, 24);
			this.panel2.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 4);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 14);
			this.label11.TabIndex = 3;
			this.label11.Text = "Selected Card:";
			// 
			// moveNext
			// 
			this.moveNext.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.moveNext.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.moveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moveNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.moveNext.ForeColor = System.Drawing.Color.Black;
			this.moveNext.Location = new System.Drawing.Point(352, 0);
			this.moveNext.Name = "moveNext";
			this.moveNext.Size = new System.Drawing.Size(104, 22);
			this.moveNext.TabIndex = 2;
			this.moveNext.Text = "Next Card >>";
			this.moveNext.Click += new System.EventHandler(this.moveNext_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(96, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// movePrevious
			// 
			this.movePrevious.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.movePrevious.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.movePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.movePrevious.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.movePrevious.ForeColor = System.Drawing.Color.Black;
			this.movePrevious.Location = new System.Drawing.Point(224, 0);
			this.movePrevious.Name = "movePrevious";
			this.movePrevious.Size = new System.Drawing.Size(128, 22);
			this.movePrevious.TabIndex = 0;
			this.movePrevious.Text = "<< Previous Card";
			this.movePrevious.Click += new System.EventHandler(this.movePrevious_Click);
			// 
			// CardLayoutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 316);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel2,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CardLayoutForm";
			this.Text = "CardLayout";
			this.Load += new System.EventHandler(this.CardLayoutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.SelectedCard = this.cardLayout1.GetCardName(this.panel2);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.SelectedCard = this.cardLayout1.GetCardName(this.panel1);
		}

		private void CardLayoutForm_Load(object sender, System.EventArgs e)
		{
			foreach(string cardName in this.cardLayout1.GetCardNames())
				this.comboBox1.Items.Add(cardName);
			this.comboBox1.SelectedIndex = 0;

			// Sample Code Block to illustrate initialization without designer.
			// Repeats whatever the deisgner already did in InitializeComponent.
			
			// <samplecodeblock name="Initializing CardLayout">
			// Binding a Control to the CardLayout manager programaitcally
			//this.cardLayout1 = new CardLayout();
	
			// Set the container control; all the child controls of this container control are
			// automatically registered as children with the manager and get default card names.
			//this.cardLayout1.ContainerControl = this.panel1;
			// Set custom card names to replace default card names.
			//this.cardLayout1.SetCardName(this.label1, "MyCard1");

			// To select a card manually, use the SelectedCard property
			//this.cardLayout1.SelectedCard = "MyCard1";
		
			// Or move through the cards like this:
			//this.cardLayout1.Next();
			//this.cardLayout1.Previous();
			// </samplecodeblock>
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.cardLayout1.SelectedCard = this.comboBox1.SelectedItem.ToString();
		}

		private void movePrevious_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Previous();
			this.comboBox1.SelectedItem = this.cardLayout1.SelectedCard;
		}

		private void moveNext_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Next();
			this.comboBox1.SelectedItem = this.cardLayout1.SelectedCard;
		}
	}
}
