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
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Design;

namespace FlatTabs
{
	// This class is overridden to better redraw performance.
	// This is a special case because, in this app, the XPTaskBar gets drawn with
	// a transparent background over a Control (tab control) that is not it's parent
	// and also has it's background drawn with a gradient brush.
	public class CustomXPTaskBar : XPTaskBar
	{
		public CustomXPTaskBar()
		{
			// To avoid flicker while the box collapses/expands.
			base.SetStyle(ControlStyles.DoubleBuffer, true);
		}
		// Overridden, to avoid flicker while the box collapses/expands.
		protected override void OnLayout(LayoutEventArgs levent)
		{
			base.OnLayout(levent);
			if(NeedLayout)
			{
				this.Layout(this.CreateGraphics());
			}
		}
	}
}
