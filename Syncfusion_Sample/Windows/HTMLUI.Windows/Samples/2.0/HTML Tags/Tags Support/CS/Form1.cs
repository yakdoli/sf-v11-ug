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

namespace HTMLUITagsSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox listBox1;

		private string templateText = "<html><head>$head</head><body>$body</body></html>";
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Form1 ) );
            this.panel1 = new System.Windows.Forms.Panel( );
            this.listBox1 = new System.Windows.Forms.ListBox( );
            this.panel2 = new System.Windows.Forms.Panel( );
            this.label1 = new System.Windows.Forms.Label( );
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.panel1.SuspendLayout( );
            this.panel2.SuspendLayout( );
            ( ( System.ComponentModel.ISupportInitialize )( this.htmluiControl1 ) ).BeginInit( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // panel1
            // 
            this.panel1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.panel1.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 193 ) ) ) ), ( ( int )( ( ( byte )( 200 ) ) ) ), ( ( int )( ( ( byte )( 219 ) ) ) ) );
            this.panel1.Controls.Add( this.listBox1 );
            this.panel1.Font = new System.Drawing.Font( "Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 224, 376 );
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Font = new System.Drawing.Font( "Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange( new object[] {
            "A (Link) ",
            "B (Bold) ",
            "BR (Break line) ",
            "EM (Makes text italic) ",
            "FONT (Inline element for text) ",
            "H1 (Heading 1)",
            "H2 (Heading 2)",
            "H3 (Heading 3)",
            "H4 (Heading 4)",
            "H5 (Heading 5)",
            "H6 (Heading 6)",
            "HR (Horizontal line) ",
            "I (Makes text italic) ",
            "U(Underlines text) ",
            "IMG (Displays images) ",
            "LINK (Used for attaching CSS document) ",
            "SPAN (Inline element for applying CSS style) ",
            "STRONG (Makes text bold) ",
            "STYLE (Used for attaching CSS inside html document) ",
            "TITLE (You can see it on the top of control) ",
            "INPUT(Windows Forms controls, such a button, textbox, etc...) ",
            "SELECT(ListBox or ComboBox win controls) ",
            "TEXTAREA(Multiline TextBox win control) ",
            "CHECKBOX(CheckBox win control) ",
            "RADIO(RadioBox win control) ",
            "CODE(Inlinetag for representing code sample) ",
            "DIV(Block tag container) ",
            "FORM(Container for win controls) ",
            "BODY(Container of visual document data) ",
            "HEAD(Container for document\'s settings) ",
            "LI(Simple item of the list) ",
            "OL(Ordered list container) ",
            "P(Container of text paragraph) ",
            "PRE(Container of formated text) ",
            "SCRIPT(Container of script code) ",
            "TABLE(Represents table container) ",
            "TR(Container of single row in the table) ",
            "TD(Container of single cell in the table) ",
            "TH(Header of the column in the table) ",
            "UL(Unordered list container) "} );
            this.listBox1.Location = new System.Drawing.Point( 8, 8 );
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size( 208, 356 );
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler( this.listBox1_SelectedIndexChanged );
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 223 ) ) ) ), ( ( int )( ( ( byte )( 228 ) ) ) ), ( ( int )( ( ( byte )( 240 ) ) ) ) );
            this.panel2.Controls.Add( this.groupBox2 );
            this.panel2.Controls.Add( this.groupBox1 );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point( 224, 0 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 328, 374 );
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font( "Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
            this.label1.ForeColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 103 ) ) ) ), ( ( int )( ( ( byte )( 110 ) ) ) ), ( ( int )( ( ( byte )( 154 ) ) ) ) );
            this.label1.Location = new System.Drawing.Point( 10, 22 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 312, 48 );
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 223 ) ) ) ), ( ( int )( ( ( byte )( 228 ) ) ) ), ( ( int )( ( ( byte )( 240 ) ) ) ) );
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.EnableMultithreading = false;
            this.htmluiControl1.Font = new System.Drawing.Font( "Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
            this.htmluiControl1.ForeColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 193 ) ) ) ), ( ( int )( ( ( byte )( 200 ) ) ) ), ( ( int )( ( ( byte )( 219 ) ) ) ) );
            this.htmluiControl1.IsOriginalTextCached = true;
            this.htmluiControl1.Location = new System.Drawing.Point( 3, 16 );
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size( 322, 250 );
            this.htmluiControl1.StartupDocument = "";
            this.htmluiControl1.StartupFolder = "";
            this.htmluiControl1.TabIndex = 4;
            this.htmluiControl1.Text = resources.GetString( "htmluiControl1.Text" );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.htmluiControl1 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point( 0, 105 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 328, 269 );
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTML Output:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.label1 );
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 328, 86 );
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTML Tag code:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.ClientSize = new System.Drawing.Size( 552, 374 );
            this.Controls.Add( this.panel2 );
            this.Controls.Add( this.panel1 );
            this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tags Support";
            this.Load += new System.EventHandler( this.Form1_Load );
            this.panel1.ResumeLayout( false );
            this.panel2.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.htmluiControl1 ) ).EndInit( );
            this.groupBox1.ResumeLayout( false );
            this.groupBox2.ResumeLayout( false );
            this.ResumeLayout( false );

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

		private void LoadHTML()
		{
			this.htmluiControl1.LoadFromString(templateText);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTML();
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string changedText = String.Empty;
			string elementText = String.Empty;
			switch(this.listBox1.SelectedIndex)
			{
				case 0://A Link
					elementText = "<a href='test.htm'>Link</a>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 1://B
					elementText = "<b>Sample Text</b>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 2://BR
					elementText = "Line 1 <br />Line 2 <br />Line 3";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 3://EM
					elementText = "<em>This &lt;em&gt; tag</em>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 4://FONT
					elementText = "<font face=\"Courier New\" size=\"6\">This is Courier New</font>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 5://H1
					elementText = "<h1>This is Heading 1</h1>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 6://H2
					elementText = "<h2>This is Heading 2</h2>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 7://H3
					elementText = "<h3>This is Heading 3</h3>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 8://H4
					elementText = "<h4>This is Heading 4</h4>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 9://H5
					elementText = "<h5>This is Heading 5</h5>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 10://H6
					elementText = "<h6>This is Heading 6</h6>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 11://HR
					elementText = "<hr>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 12://I
					elementText = "<i>This is &lt;i&gt; tag</i>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 13://U
					elementText = "<u>This is underlined text</u>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 14://IMG
					elementText = "<img src=\"http://www.syncfusion.com/common/images/prodimages/htmlui_590_150.gif\"></img>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 15://LINK
					elementText = "<LINK href=\"http://www.syncfusion.com/include/ie4.css\" rel=\"stylesheet\" type=\"text/css\">";
					changedText = templateText.Replace("$head", elementText);
					elementText = "<p>Link to style sheet</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 16://SPAN
					elementText = "<p>This is a paragraph <span style=\"color:#0000FF;\">This is a paragraph</span> This is a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 17://STRONG (Makes text bold) 
					elementText = "<strong>Bold Text</strong>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 18://STYLE (Used for attaching CSS inside html document) 
					elementText = "<p>This is a paragraph <span style=\"color:#0000FF;\">This is a paragraph</span> This is a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 19://TITLE (You can see it on the top of control) 
					elementText = "<title>HTMLUI Sample Title</title>";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 20://INPUT(Windows Forms controls, such a button, textbox, etc...) 
					elementText = "<form><input type=\"text\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 21://SELECT(ListBox or ComboBox win controls) 
					elementText = "<form><select><option value =\"volvo\">Volvo</option><option value =\"saab\">Saab</option><option value =\"opel\">Opel</option><option value =\"audi\">Audi</option></select></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 22://TEXTAREA(Multiline TextBox win control) 
					elementText = "<form><textarea rows=\"2\" cols=\"20\">Sample for textarea tag in HTMLUI.....</textarea></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 23://CHECKBOX(CheckBox win control) 
					elementText = "<form><input type=\"checkbox\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 24://RADIO(RadioBox win control) 
					elementText = "<form><input type=\"radio\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 25://CODE(Inlinetag for representing code sample) 
					elementText = "<code>Computer code text</code>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 26://DIV(Block tag container) 
					elementText = "This is some text <div style=\"color:#FF0000;\"><h4>This is a header in a div section</h4><p>This is a paragraph in a div section</p></div>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 27://FORM(Container for win controls) 
					elementText = "<form><input type=\"radio\"><input type=\"checkbox\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 28://BODY(Container of visual document data) 
					elementText = "Text in body tag";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 29://HEAD(Container for document\'s settings) 
					elementText = "Head tag";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 30://LI(Simple item of the list) 
					elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 31://OL(Ordered list container)
					elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 32://P(Container of text paragraph)
					elementText = "<p>This is some text in a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 33://PRE(Container of formated text)
					elementText = "<pre>This text is in a fixed-pitch font, and it preserves       spaces</pre>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 34://SCRIPT(Container of script code)
					elementText = "<script language=\"C#\">Please refer to the scripting sample</script>";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 35://TABLE(Represents table container)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 36://TR(Container of single row in the table)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 37://TD(Container of single cell in the table)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 38://TH(Header of the column in the table) 
					elementText = "<table border = \"1\"><tr><th>Header 1</th><th>Header 2</th></tr><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 39://UL(Unordered list container)
					elementText = "<ul><li>Windows Forms</li><li>ASP.NET</li></ul>";
					changedText = templateText.Replace("$body", elementText);
					break;
				default:
					elementText = "Tag not specified";
					changedText = templateText.Replace("$body", elementText);
					break;
			}
			
			this.label1.Text = elementText;
			this.htmluiControl1.LoadFromString(changedText);
		}
	}
}
