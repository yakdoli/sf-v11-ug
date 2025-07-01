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

namespace FlatTabs
{
	// A custom TabControlAdv to modifiy the behavior of the tab control
	public class FlatTab : TabControlAdv
	{
		// Pluggin in the custom FlatTabPanelRenderer
		// Plugging in only when not in multiline mode.
		protected override void RendererChanged(TabPanelRenderer rendererNew)
		{
			FlatTabPanelRenderer renderer = null;
			if(this.Multiline == false)
				renderer = new FlatTabPanelRenderer(this);
			base.RendererChanged(renderer);
		}

		// Overridden to remove border(around the tabcontrol) drawing code.
		// Code copied from base class and unwanted code is commented out.
		protected override void OnPaint(PaintEventArgs e )
		{
			if(NeedLayout)
				this.Layout(e.Graphics, true);

			// Background
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);

			DrawPanelBackground(e.Graphics);

			//Draw3DBorder(e.Graphics, Rectangle.Round(GetBorderRect()));

			this.Renderer.OnPaint(e.Graphics, e.ClipRectangle);
		}
	}

	// Custom SingleLineTabPanelRenderer to achieve certain effects in the tab strip portion.
	public class FlatTabPanelRenderer : SingleLineTabPanelRenderer
	{
		public FlatTabPanelRenderer(ITabControl tabControl)
			:base(tabControl)
		{
			// Proivdes indenting to the left of the tabs (4 pixels)
		//	this.PadY += 4.0f;
		}

		// Overridden to draw the gradient background in the tab-strip area.
		public override void OnPaint(Graphics g, Rectangle clipRect)
		{
			if(this.tabRenderers.Count <= 0)
				return;

			if(NeedLayout)
				this.Layout(g, true);

			// Draw the linear background.
			RectangleF rectBG = this.Bounds;
		
			if(rectBG.Width > 0 && rectBG.Height > 0)
			{
				LinearGradientBrush lgb = new LinearGradientBrush(rectBG, SystemColors.Control, SystemColors.ControlDark, LinearGradientMode.Horizontal);

				Blend blend = new Blend(2);
				blend.Factors[0] = 0.0f;
				blend.Factors[1] = 0.3f;

				blend.Positions[0] = 0.0f;
				blend.Positions[1] = 1.0f;

				lgb.Blend = blend;

				g.FillRectangle(lgb, rectBG);
			}
			// Call the base class to continue with normal drawing.
			base.OnPaint(g, clipRect);
		}
		public override Color DefaultTabPanelBackgroundColor()
		{
			// Ensures that the base class doesn't paint the bg.
			return Color.Empty;
		}
		public override bool IsBackgroundSolid()
		{
			// Since we are drawing transparent, there is a chance the bg will be non-solid
			// so specifying false here.
			return false;
		}
	}

	// Custom TabRenderer2D class to customize certain aspects of the tabs.
	public class FlatTabRenderer : TabRenderer2D
	{
		// A custom name for the tab style.
		public new static string TabStyleName { get{return "FlatTab";}
		}

		static FlatTabPanelProperty tabPanelPropertyExtender;

		// Gets the ITabDefaultProperties
		// instance that provides default properites for this renderer.
		public new static FlatTabPanelProperty TabPanelPropertyExtender
		{
			get{return tabPanelPropertyExtender;}
		}
		static FlatTabRenderer()
		{
			// Create the ITabDefaultProperties corresponding to this tab style.
			tabPanelPropertyExtender = new FlatTabPanelProperty();
			// Register the custom tab style with the factory (to make it available to the framework).
			TabRendererFactory.RegisterTabType(TabStyleName, typeof(FlatTabRenderer), TabPanelPropertyExtender);

			// Changing the Top border color.
			// Though this border is "Top", it appears to the left of the tab when drawn
			// because the implementation uses a transformed(rotated) Graphics rectangle 
			// to draw the tabs.
			TabRenderer2D.buttonBorderColors[0] = SystemColors.ControlDarkDark;
		}

		public FlatTabRenderer(ITabControl parent, ITabPanelRenderer panelRenderer)
			: base(parent, panelRenderer)
		{
		}

		// Overridden to only draw the top and left line.
		// Assuming the tabs will be aligned to the left.
		// The code here is copied from the base class and the portions drawing the right and bottom portion is removed.
		protected override void DrawBorders(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;

			// Transformed to horizontal alignment
			RectangleF currentBounds = TabUtils.ApplyTransform(g, this.TabAlignment,
				drawItemInfo.Bounds, true);

			this.ApplyTransform(g);

			// Though we draw the "top" and "right" borders, they end up being the "left" and "bottom"
			// borders when drawn because the implementation uses a transformed(rotated) 
			// Graphics rectangle to draw the tabs.

			// top line
			g.DrawLine(new Pen(BorderColors(BorderSide.top, this.TabAlignment)), new PointF(currentBounds.Left, currentBounds.Top),
				new PointF(currentBounds.Right-1, currentBounds.Top));

			// right line
			g.DrawLine(new Pen(BorderColors(BorderSide.right, this.TabAlignment)), new PointF(currentBounds.Right - 1, currentBounds.Top),
				new PointF(currentBounds.Right - 1, currentBounds.Bottom - 1));

			g.ResetTransform();
		}
	}

	// Overridden to change some default properties for the tabs.
	public class FlatTabPanelProperty : TabPanelProperty2D
	{
		public override Color DefaultInactiveTabColor(ITabPanelData panelData, ITabControl tabControl)
		{
			return Color.Empty;
		}
	}
}
