#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using System.IO;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
using System.Resources;
using Syncfusion.Windows.Forms.InternalMenus;

namespace Syncfusion.Samples.GridPad
{
	/// <summary>
	///    Summary description for MainFrame.
	/// </summary>
	public class MainWindow : Syncfusion.Windows.Forms.MetroForm // System.Windows.Forms.Form
	{
		/// <summary>
		///    Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		protected MenuItem lastfiles;
		public ArrayList BufferOpenMenuItems = new ArrayList();
		public StatusBar      statusBar       = new StatusBar();
		public StatusBarPanel statusBarPanel  = new StatusBarPanel();
		StatusBarPanel statusBarPanel1 = new StatusBarPanel();
		StatusBarPanel statusBarPanel2 = new StatusBarPanel();
		protected ToolBar standardtoolbar;
		MenuFactory menuFactory;
		public MainWindow()
		{
			InitializeComponent();
            this.Size = new System.Drawing.Size(300, 300);

            this.Text = "Grid Pad Demo";          
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
			try
			{
				InitializeMenu();
			
				StandardStatusBar(null, null);
				statusBarPanel.BorderStyle = StatusBarPanelBorderStyle.None;                
				statusBarPanel.Width = 500;
				statusBarPanel.AutoSize = StatusBarPanelAutoSize.Spring;
				
				statusBarPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
				statusBarPanel1.Width = 50;
				statusBarPanel1.AutoSize = StatusBarPanelAutoSize.None;

				statusBarPanel2.BorderStyle = StatusBarPanelBorderStyle.Sunken;
				statusBarPanel2.Width = 50;                      
				statusBarPanel2.AutoSize = StatusBarPanelAutoSize.None;
				statusBar.ShowPanels = true;
				statusBar.Panels.Add(statusBarPanel);
				statusBar.Panels.Add(statusBarPanel1);
				statusBar.Panels.Add(statusBarPanel2);

				this.IsMdiContainer = true;
				Anchor = ~AnchorStyles.None;
				MenuComplete += new EventHandler(StandardStatusBar);
				
				// set the old form start position
				this.Size = new System.Drawing.Size(640, 480);

				this.Controls.Add(statusBar);
			}  
			catch
			{
			}  
		}

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

		/// <summary>
		///    Clean up any resources being used.
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

		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

		}

		void StandardStatusBar(object sender, EventArgs e)
		{
			statusBarPanel.Text = "Ready";            
		}

		public void UpdateLastFiles()
		{
			if (lastfiles != null) 
			{
				lastfiles.MenuItems.Clear();
				MenuItem tmp = new MenuItem("last files");
				tmp.Enabled  = false;                
				lastfiles.MenuItems.Add(tmp);
			}
		}

		private bool InitializeMenu()
		{
			try
			{
				string maintoolbarResource = ApplicationMain.manifestNamespace + "DefaultToolbarItems.xml";
				string menuResource = ApplicationMain.manifestNamespace + "DefaultMenuItems.xml";
				FactoryType ft;
#if SyncfusionFramework2_0	
                ft = FactoryType.WhidbeyMenuFactory;
#else
				ft = FactoryType.WinFormsMenuFactory;
#endif
				menuFactory = MenuLoader.CreateFactory(ft, ApplicationMain.menuNamespace, new string[] { maintoolbarResource },
					new string[] { menuResource }, ApplicationMain.IconResources, this);
                
				if (menuFactory.ToolBars != null)
					this.Controls.AddRange(menuFactory.ToolBars as Control[]);

				if (menuFactory.Menus != null)
				{
					if (typeof(Menu).IsInstanceOfType(menuFactory.Menus[0]))
					{                        
						Menu = menuFactory.Menus[0] as MainMenu;
                       
					}
					else
					{
						this.Controls.Add(menuFactory.Menus[0] as Control);                          
					}
				}


			}
			catch (Exception ex)
			{
				Trace.WriteLine("Unable to create menu factory due to the following error:");
				Trace.WriteLine(ex.ToString());
				return false;
			}
			return true;
		}
	}
}
