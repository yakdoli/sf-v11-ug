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
using System.Xml;
using System.Xml.XPath; 
using System.Xml.Xsl;


namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		Assembly _assembly;
		Stream _htmlStream;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AutoRunScripts = true;
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(525, 359);
			this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(240)));
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(552, 374);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=71, Height=15}\" xlocation=\"{X=10,Y=20}\">htmluiControl1</bo" +
				"dy></html>";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.htmluiControl1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XSL Transform";
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

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.resfile.htm");
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//LoadHTMLResource();
			Transform();
		}

		private void Transform()
		{
			try
			{
				Stream _xmlStream = new MemoryStream();
				Stream _htmlStream = new MemoryStream();
				_assembly = Assembly.GetExecutingAssembly();
				_xmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.xmldata.xml");
				XPathDocument myXPathDoc = new XPathDocument(_xmlStream) ;
                XslCompiledTransform myXslTrans = LoadXslTransformResource("xsltfile.xslt");
				myXslTrans.Transform(myXPathDoc,null, _htmlStream);  
				XmlTextWriter myWriter = new XmlTextWriter("result.html", null);
				myXslTrans.Transform(myXPathDoc,null, myWriter);        
				myWriter.Close() ;
				this.htmluiControl1.LoadHTML(Application.StartupPath.ToString()+"\\result.html");
			}
			catch(Exception e)
			{

				Console.WriteLine("Exception: {0}", e.ToString());
			}

		}

		public XslCompiledTransform LoadXslTransformResource(String ResourceName) 
		{
			XslCompiledTransform xslt = new XslCompiledTransform(); 
			String sXML = ResourceToString(ResourceName);
			XmlTextReader rdr = new XmlTextReader(sXML, XmlNodeType.Document, null);
            xslt.Load(rdr) ;
			return xslt;
		}

		private string ResourceToString(string ResourceName)
		{
			String strNameSpace = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
			Stream str = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples." + ResourceName);
			if(str == null) 
				return String.Empty;
			
			Byte[] ba = new Byte[str.Length];
			str.Read(ba, 0, (int)str.Length);
			System.Text.ASCIIEncoding oEncoder = new System.Text.ASCIIEncoding();
			return oEncoder.GetString(ba);
		}



	}
}
