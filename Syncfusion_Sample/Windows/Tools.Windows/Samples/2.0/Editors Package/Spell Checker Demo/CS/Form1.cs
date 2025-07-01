using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Syncfusion.Text;
using System.IO;

namespace ClipboardFunctionsDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        #region Designer declarations
        private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem19;
        private MenuItem SpellCheck;
        private MenuItem about;
        private RichTextBox richTextBox1;
        private Syncfusion.Text.SpellChecker spellChecker1;
        private IContainer components;
        #endregion

        #region constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
        }
        #endregion

        #region Destructor
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.SpellCheck = new System.Windows.Forms.MenuItem();
            this.about = new System.Windows.Forms.MenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.spellChecker1 = new Syncfusion.Text.SpellChecker(this.components);
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem1,
            this.SpellCheck,
            this.about});
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem15,
            this.menuItem17,
            this.menuItem19});
            this.menuItem11.Text = "File";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "New";
            this.menuItem12.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "Open";
            this.menuItem13.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "-";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 3;
            this.menuItem15.Text = "Save";
            this.menuItem15.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 4;
            this.menuItem17.Text = "-";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            this.menuItem19.Text = "Exit";
            this.menuItem19.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8,
            this.menuItem9,
            this.menuItem10});
            this.menuItem1.Text = "&Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Undo";
            this.menuItem2.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "&Redo";
            this.menuItem3.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "Cu&t";
            this.menuItem5.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "&Copy";
            this.menuItem6.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "&Paste";
            this.menuItem7.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 7;
            this.menuItem9.Text = "Select &All";
            this.menuItem9.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 8;
            this.menuItem10.Text = "Ca&ncel Selection";
            this.menuItem10.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // SpellCheck
            // 
            this.SpellCheck.Index = 2;
            this.SpellCheck.Text = "Spell Check";
            this.SpellCheck.Click += new System.EventHandler(this.SpellCheck_Click);
            // 
            // about
            // 
            this.about.Index = 3;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(878, 495);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // spellChecker1
            // 
            this.spellChecker1.DictionaryPath = "Syncfusion_en_us.dic";
            this.spellChecker1.ExcludeEmailAddress = true;
            this.spellChecker1.ExcludeFileNames = true;
            this.spellChecker1.ExcludeHtmlTags = true;
            this.spellChecker1.ExcludeInternetAddresses = true;
            this.spellChecker1.ExcludeRepeatedWords = true;
            this.spellChecker1.ExcludeSpecialSymbols = true;
            this.spellChecker1.ExcludeWordsInUpperCase = true;
            this.spellChecker1.ExcludeWordsWithNumbers = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(878, 495);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spell Checker Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

        #region Main
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
        }
        #endregion

        #region Event Handlers
        private void MainMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "New" :
                    this.richTextBox1.Clear();
					break;
                case "Open":
                    {
                        OpenFileDialog dlgOpen = new OpenFileDialog();
                        dlgOpen.Filter = "Rich Text Format(*.rtf)|(*.rtf)|Text Files(*.txt)|(*.txt)";
                        if (dlgOpen.ShowDialog() == DialogResult.OK)
                        {
                            this.richTextBox1.LoadFile(dlgOpen.FileName);
                        }
                    }
                    break;
				case "Save" :
                    FolderBrowserDialog dlgBrowser = new FolderBrowserDialog();
                    if (dlgBrowser.ShowDialog() == DialogResult.OK)
                    {
                        this.richTextBox1.SaveFile(dlgBrowser.SelectedPath + Path.DirectorySeparatorChar + "SpellChecler.rft",RichTextBoxStreamType.RichText);
                    }
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}

		private void EditMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "&Undo" :
                    this.richTextBox1.Undo();
					break;
				case "&Redo" :
                    this.richTextBox1.Redo();
					break;
				case "Cu&t" :
                    this.richTextBox1.Cut();
					break;
				case "&Copy" :
                    this.richTextBox1.Copy();
					break;
				case "&Paste" :
                    this.richTextBox1.Paste();
					break;
				case "Select &All" :
                    this.richTextBox1.SelectAll();
					break;
				case "Ca&ncel Selection" :
                    this.richTextBox1.Select(0, 0);
					break;
			}
        }

        private void SpellCheck_Click(object sender, EventArgs e)
        {
            this.spellChecker1.SpellCheck(new SpellEditorWrapper(this.richTextBox1));
        }
        private void about_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm help = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            help.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("..\\..\\..\\images\\document.rtf", RichTextBoxStreamType.RichText);
        }

        #endregion
    }
}
