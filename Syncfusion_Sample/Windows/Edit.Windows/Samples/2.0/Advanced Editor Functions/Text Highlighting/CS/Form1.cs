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
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Edit.Interfaces;

namespace TextHighlightingDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MenuItem menuItem9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);

			this.radioButton1.BackColor = ColorTranslator.FromHtml("#85BF75");
			this.radioButton2.BackColor = ColorTranslator.FromHtml("#B4E7F2");
			this.radioButton3.BackColor = ColorTranslator.FromHtml("#FFBF34");
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Beige;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button2,
																				 this.button1,
																				 this.groupBox2,
																				 this.label1,
																				 this.comboBox1,
																				 this.groupBox1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 445);
			this.panel1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(16, 400);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Highlight Selection";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(16, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Highlight Line";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton8,
																					this.radioButton4,
																					this.radioButton5,
																					this.radioButton6});
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.groupBox2.Location = new System.Drawing.Point(16, 216);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(136, 128);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Border";
			// 
			// radioButton8
			// 
			this.radioButton8.Checked = true;
			this.radioButton8.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton8.Location = new System.Drawing.Point(16, 96);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.TabIndex = 5;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "None";
			// 
			// radioButton4
			// 
			this.radioButton4.BackColor = System.Drawing.Color.Chartreuse;
			this.radioButton4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton4.Location = new System.Drawing.Point(16, 72);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 2;
			this.radioButton4.Text = "Chartreuse";
			// 
			// radioButton5
			// 
			this.radioButton5.BackColor = System.Drawing.Color.Crimson;
			this.radioButton5.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton5.Location = new System.Drawing.Point(16, 48);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 1;
			this.radioButton5.Text = "Crimson";
			// 
			// radioButton6
			// 
			this.radioButton6.BackColor = System.Drawing.Color.Magenta;
			this.radioButton6.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton6.Location = new System.Drawing.Point(16, 24);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 0;
			this.radioButton6.Text = "Magenta";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "HatchStyle:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(10, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(155, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton3,
																					this.radioButton2,
																					this.radioButton1,
																					this.radioButton7});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.groupBox1.Location = new System.Drawing.Point(16, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Background";
			// 
			// radioButton3
			// 
			this.radioButton3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton3.Location = new System.Drawing.Point(16, 72);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Orange";
			// 
			// radioButton2
			// 
			this.radioButton2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton2.Location = new System.Drawing.Point(16, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Dull Aqua";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Light Olive";
			// 
			// radioButton7
			// 
			this.radioButton7.ForeColor = System.Drawing.SystemColors.Desktop;
			this.radioButton7.Location = new System.Drawing.Point(16, 96);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.TabIndex = 4;
			this.radioButton7.Text = "None";
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
																					  this.menuItem8,
																					  this.menuItem9});
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
			// menuItem8
			// 
			this.menuItem8.Index = 6;
			this.menuItem8.Text = "Close";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.Gray;
			this.editControl1.Location = new System.Drawing.Point(168, 0);
			this.editControl1.Name = "editControl1";
			this.editControl1.SaveOnClose = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.Size = new System.Drawing.Size(374, 445);
			this.editControl1.StatusBarSettings.CoordsPanel.Width = 148;
			this.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0;
			this.editControl1.StatusBarSettings.EncodingPanel.Width = 165;
			this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.StatusBarSettings.TextPanel.Width = 96;
			this.editControl1.TabIndex = 3;
			this.editControl1.Text = "";
			this.editControl1.TransferFocusOnTab = true;
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 7;
			this.menuItem9.Text = "Exit";
			this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Text Highlighting";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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

		private IBackgroundFormat RegisterFormat()
		{
			Color background = Color.Empty, foreground = Color.Empty;

			if( radioButton1.Checked )
				background = radioButton1.BackColor;
			else if( radioButton2.Checked )
				background = radioButton2.BackColor;
			else if( radioButton3.Checked )
				background = radioButton3.BackColor;

			if( radioButton6.Checked )
				foreground = radioButton6.BackColor;
			else if( radioButton5.Checked )
				foreground = radioButton5.BackColor;
			else if( radioButton4.Checked )
				foreground = radioButton4.BackColor;

			bool bUseHatchFille = comboBox1.SelectedIndex > 0;
			HatchStyle style = ( bUseHatchFille ) 
				? ( HatchStyle )Enum.Parse( typeof( HatchStyle ), 
				comboBox1.SelectedItem.ToString() )
				: HatchStyle.Min;

			IBackgroundFormat format = 
				editControl1.RegisterBackColorFormat( background, foreground, 
				style, bUseHatchFille );
			return format;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			IDynamicFormat[] temp = editControl1.GetLineBackColorFormats( editControl1.CurrentLine );
     
			IBackgroundFormat format = RegisterFormat();
			editControl1.SetLineBackColor( editControl1.CurrentLine, true, format );   
  
			this.editControl1.ResetSelection();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			comboBox1.Items.Clear();
        
			comboBox1.Items.Add( "Solid" );
                       
			foreach( string name in Enum.GetNames( typeof( HatchStyle) ) )
				comboBox1.Items.Add( name );
      
			comboBox1.SelectedText = "Percent05";
			comboBox1.SelectedIndex = 0;

			editControl1.Text += "\n";
			editControl1.CurrentLine = 1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            if (editControl1.Selection != null)
            {
                IBackgroundFormat format = RegisterFormat();
                editControl1.SetSelectionBackColor(format);

                this.editControl1.ResetSelection();
            }
            else
                MessageBox.Show("Please select some text.");
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
	}
}
