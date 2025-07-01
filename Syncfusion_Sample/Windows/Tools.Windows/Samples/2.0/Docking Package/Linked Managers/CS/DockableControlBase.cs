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
	/// Implements a template to be used by the dockable controls.
	/// </summary>
	public class DockableControlBase : System.Windows.Forms.UserControl
	{
		# region Members declaration
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected String controlLabel = String.Empty;
		protected Icon controlIcon = null;
		
		protected DockingManager dockingMgr = null;
		# endregion
		# region Properties
		public DockingManager CurrentDockingManager
		{
			get { return this.dockingMgr; }
			set { this.dockingMgr = value; } 
		}

		public String DockLabel
		{
			get { return this.controlLabel; }
		}

		public Icon DockIcon
		{
			get { return this.controlIcon; }
		}
		# endregion
		# region Initialization
		public DockableControlBase()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(this.dockingMgr != null)
				{
					this.dockingMgr = null;
				}

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
			// 
			// DockableControlBase
			// 
			this.Name = "DockableControlBase";
			this.Size = new System.Drawing.Size(448, 440);

		}
		#endregion		
# endregion
	}
}
