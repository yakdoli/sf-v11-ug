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
using System.IO;
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		Assembly _assembly;
		Stream _htmlStream;

		static private int [,] GameEndIndexes = new int[,]
		{
			{0,1,2},
			{3,4,5},
			{6,7,8},
			{0,3,6},
			{1,4,7},
			{2,5,8},
			{0,4,8},
			{2,4,6}
		};

		Hashtable htmlelements = new Hashtable();
		BaseElement ttt1;
		BaseElement ttt2;
		BaseElement ttt3;
		BaseElement ttt4;
		BaseElement ttt5;
		BaseElement ttt6;
		BaseElement ttt7;
		BaseElement ttt8;
		BaseElement ttt9;
		private BaseElement [] _elementArray; 


		private bool gameOver = false;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(525, 338);
			this.htmluiControl1.BackColor = System.Drawing.SystemColors.Control;
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(552, 353);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=77, Height=14}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "Game";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Reset";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Exit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "View";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "HTML";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 353);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();			
		}

		#region LOADUI
		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.dialog.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}
		#endregion

		#region UI_EVENTS
		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			WireElements();
		}

		private void WireElements()
		{
			try
			{
				htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

				this.ttt1 = htmlelements["ttt1"] as BaseElement;
				this.ttt2 = htmlelements["ttt2"] as BaseElement;
				this.ttt3 = htmlelements["ttt3"] as BaseElement;
				this.ttt4 = htmlelements["ttt4"] as BaseElement;
				this.ttt5 = htmlelements["ttt5"] as BaseElement;
				this.ttt6 = htmlelements["ttt6"] as BaseElement;
				this.ttt7 = htmlelements["ttt7"] as BaseElement;
				this.ttt8 = htmlelements["ttt8"] as BaseElement;
				this.ttt9 = htmlelements["ttt9"] as BaseElement;

				this.ttt1.Click += new EventHandler( ttt1_Click );
				this.ttt2.Click += new EventHandler( ttt2_Click );
				this.ttt3.Click += new EventHandler( ttt3_Click );
				this.ttt4.Click += new EventHandler( ttt4_Click );
				this.ttt5.Click += new EventHandler( ttt5_Click );
				this.ttt6.Click += new EventHandler( ttt6_Click );
				this.ttt7.Click += new EventHandler( ttt7_Click );
				this.ttt8.Click += new EventHandler( ttt8_Click );
				this.ttt9.Click += new EventHandler( ttt9_Click );

				_elementArray = new BaseElement[9] {ttt1, ttt2,ttt3, ttt4, ttt5, ttt6, ttt7, ttt8, ttt9};

			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void ttt1_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt1);

		}

		private void ttt2_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt2);

		}

		private void ttt3_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt3);

		}

		private void ttt4_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt4);

		}

		private void ttt5_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt5);

		}

		private void ttt6_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt6);

		}

		private void ttt7_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt7);
		}

		private void ttt8_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt8);
		}

		private void ttt9_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt9);
		}

		#endregion

		#region TIC_TAC_TOE

		bool lastWasX = false;
		private string GetXorO()
		{
			string ret = "X";
			if(lastWasX == true)
				ret = "O";
			lastWasX = !lastWasX;
			return ret;
		}

		private void HandleElementClick(BaseElement target)
		{
			if(target.InnerHTML == "" && this.gameOver == false)
			{
				target.InnerHTML = this.GetXorO();
			}
			this.ApplyGameRules();

		}

		private void ResetGame()
		{
			for(int i =0; i < 9; i++)
			{
				this._elementArray[i].InnerHTML ="";
				this._elementArray[i].Attributes["class"].Value = "tttDisplay";
			}

			this.lastWasX = false;
			this.gameOver = false;
		}

		public bool ApplyGameRules()
		{
			int gameEndCombinations = GameEndIndexes.Length/3;
			for(int i = 0; i < gameEndCombinations; i++)
			{
				BaseElement element1 = _elementArray[GameEndIndexes[i,0]];
				BaseElement element2 = _elementArray[GameEndIndexes[i,1]];
				BaseElement element3 = _elementArray[GameEndIndexes[i,2]];

				if(element1.InnerHTML != "" && element2.InnerHTML != "" && element3.InnerHTML != "" )
				{
					if(element1.InnerHTML == element2.InnerHTML && element1.InnerHTML == element3.InnerHTML )
					{
						element1.Attributes["class"].Value = "tttWinDisplay";
						element2.Attributes["class"].Value = "tttWinDisplay";
						element3.Attributes["class"].Value = "tttWinDisplay";
						gameOver = true;
						break;
					}
				}
			}  
			return false;
		}

		#endregion

		#region MENU_HANDLING

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.ResetGame();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion
	}
}
