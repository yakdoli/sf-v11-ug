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
using System.Xml;
using System.IO;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation;



namespace IntellisenseFromXMLDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.ComponentModel.IContainer components;
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
		private System.Windows.Forms.MenuItem menuItem9;
        private XmlTextReader reader; 

		private string intellisensePath	= Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Intellisense.xml";
		private string ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.editControl1.Configurator.Open(ConfigPath);
			this.editControl1.ApplyConfiguration("CustomLanguage");
			
			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}

			this.editControl1.Text = "/* Type 'this' or 'me' and a DOT to see the context choice list. After you type 'this.', select 'Find' (or any of the items)from the context choice list and type a BRACE '(' to see the context prompt  */";
			this.editControl1.Text += "\n\n";
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
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
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
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.White;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.MarkLineWrapping = false;
			this.editControl1.MarkWrappedLines = false;
			this.editControl1.Name = "editControl1";
			this.editControl1.SaveOnClose = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowOutliningCollapsers = false;
			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0;
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "";
			this.editControl1.WordWrap = true;
			this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
			this.editControl1.ContextPromptBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextPromptBeforeOpen);
			this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
			this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
			this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
			this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
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
			this.menuItem2.Text = "&New";
			this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Open";
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
			this.menuItem5.Text = "&Save";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "Save&As";
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
			this.menuItem9.Text = "C&lose";
			this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "E&xit";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Intellisense From XML";
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
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "C&lose" :
					this.editControl1.Close();
					break;
				case "E&xit" :
					this.Close();
					break;
			}
		}

		#region Context Choice Implementation
		private void editControl1_ContextChoiceBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextChoiceCharIndex(lexemLine);
            if (ind <= 0)
            {
                e.Cancel = true;
                return;
            }
			ILexem lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
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

		private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
		{
		   reader=new XmlTextReader(intellisensePath);
			while(reader.Read())
			{
				string itemname="",tooltip="";
				switch(reader.NodeType)
				{
					case(XmlNodeType.Element):
						
						if(reader.Name=="Items")
						{
							if(reader.AttributeCount>0)
							{
								while(reader.MoveToNextAttribute())
								{
									if(reader.Name=="Name")
									{                             			
										itemname=reader.Value;										
									}
									if(reader.Name=="Tooltip")
									{
										tooltip=reader.Value;
									}
									if(reader.Name=="Image")
									{
										controller.Items.Add(itemname,tooltip,this.editControl1.ContextChoiceController.Images[reader.Value]);
									}
								}
							}
						}

						break;
					
				}
			}
			
		}

		private void editControl1_ContextChoiceItemSelected(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController sender, Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs e)
		{
			Console.WriteLine("SelectedItem : " + e.SelectedItem.Text);
		}

		private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
		{
			controller.Items.Clear();
			reader.Close();
		}
		#endregion

		#region Context Prompt Implementation
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

        string contextPromptLexem = "";	
		// Method that populates the context prompt list based on the lexem invoking it
		private void PopulateContextPromptItems (ContextPromptUpdateEventArgs e)
		{
			switch (this.contextPromptLexem)
			{
				case "Chat" :
					e.List.Clear();
					GetFunctionNames(e);
					break;

				case "Database" :
					e.List.Clear();
					GetFunctionNames(e);
					break;
				case "NewFile" :
					e.List.Clear();
					GetFunctionNames(e);
     				break;
				case "Find" :
					e.List.Clear();
					GetFunctionNames(e);
					break;
				case "Home" :
					e.List.Clear();
					GetFunctionNames(e);
					break;
				case "PieChart" :
					e.List.Clear();
					GetFunctionNames(e);
					break;
				case "Tools" :
					e.List.Clear();
					GetFunctionNames(e);
					break;
			}
		}

		string function="";
		private void GetFunctionNames(ContextPromptUpdateEventArgs e)
		{
			reader=new XmlTextReader(intellisensePath);
			function="";
			int i=1;
			while(reader.Read())
			{
				function="";
				switch(reader.NodeType)
				{
					case(XmlNodeType.Element):
						
						if(reader.Name=="Function")
						{
							reader.MoveToFirstAttribute();
							if(reader.Value==this.contextPromptLexem)
							{
							 while(reader.MoveToNextAttribute())
								{
								 if(reader.Name=="overloads"+i)
								 {
									function=reader.Value;
																
								 }
								 else 
								 {	 
									 if(reader.Name=="Description"+i)
									 {
										 
										 e.AddPrompt(function,reader.Value); 
										 i++;
									 }
								 }
									
								}
							}
						}

						break;
					
				}
			}
			
		}

		private void editControl1_ContextPromptBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextPromptCharIndex(lexemLine);
            if (ind <= 0)
            {
                e.Cancel = true;
                return;
            }
			ILexem lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
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

		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			if (this.contextPromptLexem != "")
			{
				PopulateContextPromptItems(e);
			}
		}
		#endregion
	}
}
