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
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;      
using System.IO;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation;

namespace ContextChoiceAndContextPromptDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components=null;
		private System.Windows.Forms.MenuItem menuItem9;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem12;

		private string ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.ShowContextTooltip = false;
			this.editControl1.ShowOutliningCollapsers = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowVerticalSplitters = false;
			
			this.editControl1.Configurator.Open(ConfigPath);
			this.editControl1.ApplyConfiguration("CustomLanguage");

			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}

			this.editControl1.Text = "/* Type 'this' or 'me' and a DOT to see the context choice list. After you type 'this.', select 'Find' (or any of the items)from the context choice list and type a BRACE '(' to see the context prompt */\n\n";
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config2 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config2;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.SaveOnClose = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.Size = new System.Drawing.Size(542, 445);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            this.editControl1.ContextPromptBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextPromptBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextPromptClose += new Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventHandler(this.editControl1_ContextPromptClose);
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged += new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem10});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem9,
            this.menuItem8});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "New";
            this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Open";
            this.menuItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "Save";
            this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "SaveAs";
            this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 6;
            this.menuItem9.Text = "Close";
            this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "Exit";
            this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem12});
            this.menuItem10.Text = "FilterAutoCompleteItems";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "True";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "False";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.editControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Context Choice and Prompt";
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		
		private void MainMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}

		//Store the lexem name invoking the ContextPrompt popup
		string contextPromptLexem = "";
		private void editControl1_ContextPromptBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{			
			ILexem lex;
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextPromptCharIndex(lexemLine);

			if (ind<=0) 
			{
				e.Cancel = true;
				return;
			}
			lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
			// If the count is less than '2', do not show the ContextPrompt popup
			if (lexemLine.LineLexems.Count<2)
				e.Cancel = true;
			else
			{
				// Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				if ((lex.Text == "Chat") || (lex.Text == "Database") || (lex.Text == "NewFile") || (lex.Text == "Find") || (lex.Text == "Home") || (lex.Text == "PieChart") || (lex.Text == "Tools"))
				{
					this.contextPromptLexem = lex.Text;
					e.Cancel = false;
				}
				else
					e.Cancel = true;
			}
		}


		// Populate the context prompt list on popup
		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			if (this.contextPromptLexem != "")
			{
				PopulateContextPromptItems(e);
			}
		}


		// Method that populates the context prompt list based on the lexem invoking it
		private void PopulateContextPromptItems (ContextPromptUpdateEventArgs e)
		{
			switch (this.contextPromptLexem)
			{
				case "Chat" :
					e.List.Clear();
					e.AddPrompt( "Chat(string chatText, int senderID, int receiverID, int connectionID)", "Specify the chat text, the sender information, the receiver information and the connection ID" );
					e.AddPrompt( "Chat(string chatText, int senderID, bool isBroadCast)", "Specify the chat text, the sender information, and if its a broadcast" );
					break;
				case "Database" :
					e.List.Clear();
					e.AddPrompt( "Database()", "Create a new database" );
					e.AddPrompt( "Database(string dataBaseName)", "Create a new database with the specified name" );
					break;
				case "NewFile" :
					e.List.Clear();
					e.AddPrompt( "NewFile()", "Create a new file" );
					e.AddPrompt( "NewFile(string fileName)", "Create a new file with the specified name" );
					break;
				case "Find" :
					e.List.Clear();
					e.AddPrompt( "Find()", "Display the Find dialog" );
					e.AddPrompt( "Find(string searchText)", "Find occurences of the specified search text" );
					e.AddPrompt( "Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified" );
					break;
				case "Home" :
					e.List.Clear();
					e.AddPrompt( "Home()","Go to the initial application form" );
					break;
				case "PieChart" :
					e.List.Clear();
					e.AddPrompt( "PieChart()","Create an empty Pie-chart" );
					e.AddPrompt( "PieChart(string[] sectionNames, int[] sectionAngles)","Create a Pie-chart containing the specified sections with the specified angles information" );
					e.AddPrompt( "PieChart(string[] sectionNames, int[] sectionAngles, Color[] sectionColors)","Create a Pie-chart containing the specified sections with the specified angles and color information" );
					break;
				case "Tools" :
					e.List.Clear();
					e.AddPrompt( "Tools()","Display the Tools dialog" );
					e.AddPrompt( "Tools(int ToolID)","Display the Tools dialog and select the specified Tool" );
					break;
			}
		}


		// Display the selected Context prompt item's index
		private void editControl1_ContextPromptSelectionChanged(Syncfusion.Windows.Forms.Edit.Forms.Popup.ContextPrompt sender, Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventArgs e)
		{
			Console.WriteLine("SelectedIndex : " + e.SelectedIndex.ToString());
			Console.WriteLine("ContextPromptSelectionChanged");	
		}		


		// Returns the last index of the context prompt character - '(' in the current line
		private int GetContextPromptCharIndex(ILexemLine line)
		{
			int lastPos = -1;

			for (int i=0; i<line.LineLexems.Count; i++)
			{
				ILexem lex = line.LineLexems[i] as ILexem;

				if (lex.Text == "(")
					lastPos = i;
			}

			return lastPos;
		}


		// Clear the context prompt lexem name on close
		private void editControl1_ContextPromptClose(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventArgs e)
		{
			this.contextPromptLexem = "";
		}	
	

		// Ensure that the context choice popup is displayed if the invoking lexems are "this" or "me" only
		private void editControl1_ContextChoiceBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ILexem lex;
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextChoiceCharIndex(lexemLine);

			if (ind<=0) 
			{
				e.Cancel = true;
				return;
			}

			lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
			// If the count is less than '2', do not show the ContextChoice popup
			if (lexemLine.LineLexems.Count<2)
				e.Cancel = true;
			else
			{
				// Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				if ((lex.Text == "this") || (lex.Text == "me"))
					e.Cancel = false;
				else
					e.Cancel = true;
			}
		}


		// Populate the context choice list on popup
		private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
		{			
			controller.Items.Add("Chat", "This is Chat", this.editControl1.ContextChoiceController.Images["Image0"]);
			controller.Items.Add("Database", "This is Database", this.editControl1.ContextChoiceController.Images["Image1"]);    
			controller.Items.Add("NewFile", "This is NewFile", this.editControl1.ContextChoiceController.Images["Image2"]);
			controller.Items.Add("Find", "This is Find", this.editControl1.ContextChoiceController.Images["Image3"]);
			controller.Items.Add("Home", "This is Home", this.editControl1.ContextChoiceController.Images["Image4"]);
			controller.Items.Add("PieChart", "This is PieChart", this.editControl1.ContextChoiceController.Images["Image6"]);   
			controller.Items.Add("Tools", "This is Tools", this.editControl1.ContextChoiceController.Images["Image7"]);  		 
		}


		private void editControl1_ContextChoiceItemSelected(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController sender, Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs e)
		{	
			// Display the Context Choice item selected		
			Console.WriteLine("SelectedItem : " + e.SelectedItem.Text);
		}


		// Clear the Context Choice items list on closing the Context Choice popup
		private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
		{
			controller.Items.Clear();
		}

		// Returns the last index of the context choice character - '.' in the current line
		private int GetContextChoiceCharIndex(ILexemLine line)
		{
			int lastPos = -1;

			for (int i=0; i<line.LineLexems.Count; i++)
			{
				ILexem lex = line.LineLexems[i] as ILexem;

				if (lex.Text == ".")
					lastPos = i;
			}

			return lastPos;
        }
        #region FilterAutoCompleteItems

        private void menuItem11_Click(object sender, EventArgs e)
        {
            //Filters the item in the AutoComplete Context choice and the filtered item alone will be visible.
            this.editControl1.FilterAutoCompleteItems = true;
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            //All the items will be visible and the selection will be navigated to the item. 
            this.editControl1.FilterAutoCompleteItems = false;
        }
        #endregion
    }
}
