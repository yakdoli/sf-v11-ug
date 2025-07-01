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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace LinkedManagers
{
	/// <summary>
	/// Summary description for TabPageClientControl.
	/// </summary>
	public class TabPageClientControl : System.Windows.Forms.UserControl
	{
		# region Members declaration
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
		private System.ComponentModel.IContainer components;
# endregion
		# region Properties
		public DockingManager DockingManager
		{
			get { return this.dockingManager1; }
		}
		# endregion
		# region Initaialization
		public TabPageClientControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Set the DockingManager's HostActivatedVisibility to False so that docking windows are not 
			// hidden when the parent TabPage is deactivated.
			this.dockingManager1.HostActivatedVisibility = false;
			
			// Setting the DockingManager's ControlScopeImages property specifies that the control icons 
			// will be provided by the dockable controls themselves and can be dereferenced prior to 
			// disposing of the control.
			this.dockingManager1.ControlScopeImages = true;

			// AutoHide tabs are always displayed on the left side of the form. 
			this.dockingManager1.RestrictDockFillAutoHideBorder(DockingStyle.Left);
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TabPageClientControl));
			this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
			// 
			// dockingManager1
			// 
			this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
			this.dockingManager1.DockToFill = true;
			this.dockingManager1.HostControl = this;
			// 
			// TabPageClientControl
			// 
			this.Name = "TabPageClientControl";
			this.Size = new System.Drawing.Size(488, 376);
			((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();

		}
		#endregion
# endregion
	}
}
