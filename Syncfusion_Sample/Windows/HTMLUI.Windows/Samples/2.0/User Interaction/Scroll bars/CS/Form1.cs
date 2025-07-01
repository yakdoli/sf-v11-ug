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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		bool checkState = false;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		IHTMLElement[] body = null;

		public Form1()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(365, 359);
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(160, 0);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(392, 374);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "htmluiControl1";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.panel2,
																				 this.label1,
																				 this.treeView1});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(152, 374);
			this.panel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(172)), ((System.Byte)(85)));
			this.label3.Location = new System.Drawing.Point(8, 239);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "   Scroll Options";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(240)));
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2,
																				 this.checkBox1,
																				 this.button1});
			this.panel2.Location = new System.Drawing.Point(8, 263);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(134, 96);
			this.panel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(80)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "   Scroll To Rectangle";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(80)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(8, 64);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(120, 32);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Enable AutoScroll";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(79)), ((System.Byte)(117)), ((System.Byte)(153)));
			this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(8, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "Scroll To End";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(172)), ((System.Byte)(85)));
			this.label1.Location = new System.Drawing.Point(8, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "    Scroll To Element";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// treeView1
			// 
			this.treeView1.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.treeView1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(240)));
			this.treeView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(8, 31);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(134, 184);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.htmluiControl1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scroll bars";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#region Class Events
		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLFile(@"doc.htm");
			this.checkState = this.htmluiControl1.AutoScroll;
			LoadTree(this.htmluiControl1.Document);
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.checkState == false)
			{
				MessageBox.Show("AutoScroll looks disabled. Please enable it to use this functionality.");
				return;
			}

			IHTMLElement elem = e.Node.Tag as IHTMLElement;
			if(elem == null)
			{
				return;
			}
			this.htmluiControl1.ScrollToElement(elem);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked == true)
			{
				this.htmluiControl1.AutoScroll = true;
				this.checkState = true;
			}

			if(this.checkBox1.Checked == false)
			{
				this.htmluiControl1.AutoScroll = false;
				this.checkState = false;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.checkState == false)
			{
				MessageBox.Show("AutoScroll looks disabled. Please enable it to use this functionality.");
				return;
			}

			ScrollToEnd();
		}

		#endregion

		#region Class Methods
		private void LoadHTMLFile(string fileName)
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			this.htmluiControl1.StartupDocument = System.IO.Path.Combine(path, fileName);	
		}

		private void LoadTree(IInputHTML document)
		{
			this.treeView1.Nodes.Clear();
			this.body = document.GetElementsByName("body");
			TreeNode tnode = null;
			tnode = this.treeView1.Nodes.Add(this.body[0].Name);
			tnode.Tag = this.body[0];
			AddElements(this.body[0], tnode);
		}

		private void AddElements(IHTMLElement element, TreeNode parentNode)
		{
			IHTMLElementsCollection coll = element.Children;
			foreach(IHTMLElement elem in coll)
			{
				TreeNode tnode = null;
				tnode = parentNode.Nodes.Add(elem.Name);
				tnode.Tag = elem;
				AddElements(elem, tnode);
			}
		}

		private void ScrollToEnd()
		{
			IHTMLElement elem = this.htmluiControl1.Document.RenderRoot;
			Point lastPoint = new Point(0, (elem.Location.Y + elem.Size.Height));
			Rectangle rect = new Rectangle(new Point(10, lastPoint.Y-10), new Size(10,10));
			this.htmluiControl1.ScrollToRectangle(rect, this.htmluiControl1.Document);
		}
		#endregion

	}
}
