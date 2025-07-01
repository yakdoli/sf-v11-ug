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
using System.Resources;
using System.IO; 

using Syncfusion.Windows.Forms.Grid;

namespace Syncfusion.Samples.GridPad
{
    /// <summary>
    ///    Provides the entry point for GridPad.exe.
    /// </summary>
    public class ApplicationMain
    {
		internal static string manifestNamespace = "Syncfusion.Samples.GridPad.Resources.";
		internal static string menuNamespace = "Syncfusion.Samples.GridPad.Actions.";
		
		internal static ResourceManager IconResources;

		/// <summary>
		/// Entry Point method.
		/// </summary>
		[STAThreadAttribute()]
		public static void Main(string[] args)
		{
			ApplicationMain i = new ApplicationMain();
			IconResources   = new ResourceManager(manifestNamespace + "MainMenuItemResources", i.GetType().Module.Assembly, null);
			Application.Run(new MainWindow());
		}
	}
}
