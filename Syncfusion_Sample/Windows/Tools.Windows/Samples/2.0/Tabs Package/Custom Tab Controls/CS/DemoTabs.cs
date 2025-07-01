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
using System.Reflection ;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace CustomTabControls
{
	// Subclassed control to do custom border drawing
	public class DemoTabControl : TabControlAdv
	{
		protected override Color GetTopLeftBorderColor()
		{
			return Color.FromArgb(42, 67, 126);
		}
		
		protected override Color GetRightBottomBorderColor()
		{
			return Color.FromArgb(42, 67, 126);
		}

		protected override Color GetRightBottomBorderShadeColor()
		{
			return Color.Empty;
		}
	}

	// Some global properties for this Tab Style
	public class DemoTabPanelProperty : TabUIDefaultProperties
	{
		// The selected tab overlaps the inactive tabs by this much. 20 on both sides.
		public override SizeF GetOverlapSize(SizeF tabSize)
		{
			return new SizeF(20, 0);
		}
	}

	// Custom tab renderer
	public class DemoTabsRenderer : TabRenderer3D
	{
		#region TABINIT
		// Use the above DemoTabPanelProperty as my default properties provider.
		static DemoTabPanelProperty tabPropertyExtender;
		public static new DemoTabPanelProperty TabPanelPropertyExtender
		{
			get{return tabPropertyExtender;}
		}

		public static new string TabStyleName { get{return "DemoTabs";}
		}

		static DemoTabsRenderer()
		{
			tabPropertyExtender = new DemoTabPanelProperty();
			TabRendererFactory.RegisterTabType(TabStyleName, typeof(DemoTabsRenderer), TabPanelPropertyExtender);
		}
		public DemoTabsRenderer(ITabControl parent, ITabPanelRenderer panelRenderer)
			: base(parent, panelRenderer)
		{
		}

		public override SizeF GetOverlapSize(SizeF tabSize)
		{
			return tabPropertyExtender.GetOverlapSize(tabSize);
		}

		#endregion TABINIT

		// Use the same path as the DrawBorders method.
		public override bool HitTest(PointF mousePosition)
		{
			GraphicsPath path = null;
			if(this.panelRenderer.TabPanelData.TabsData[this.panelRenderer.TabPanelData.SelectedIndex] == this.TabData)
				path = this.GetSelectedTabBorderPathFromBounds(this.GetCurrentBounds());
			else
			{
				path = this.GetBorderPathFromBounds(this.GetCurrentBounds());
				path.CloseFigure();
			}
			Region region = new Region(path);

			// Hittest the region to verify if the point is in the rect
			if(region.IsVisible(mousePosition))
				return true;
			else
				return false;
		}

		#region DRAWING
		protected override void DrawBackground(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;

			RectangleF curBounds = new RectangleF(drawItemInfo.Bounds.Left,
				drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Width, drawItemInfo.Bounds.Height);


			Color bgColor = drawItemInfo.BackColor;

			// Get the border path and fill it.
			GraphicsPath path = null;
			if((drawItemInfo.State & DrawItemState.Selected) > 0)
			{
				path = this.GetSelectedTabBorderPathFromBounds(curBounds);
				g.FillPath(new SolidBrush(bgColor), path);
			}
			else
			{
				path = this.GetBorderPathFromBounds(curBounds);
				path.CloseFigure();

				LinearGradientBrush brush = 
					new LinearGradientBrush(curBounds, Color.FromArgb(50, bgColor), 
						Color.FromArgb(150, bgColor), LinearGradientMode.ForwardDiagonal);


				g.FillPath(brush, path);
			}
		}

		// Border path for inactive tabs.
		private GraphicsPath GetBorderPathFromBounds(RectangleF bounds)
		{
			GraphicsPath path = new GraphicsPath();
			
			path.AddLine(new PointF(bounds.Left, bounds.Bottom-1),
				new PointF(bounds.Left, bounds.Top + 5));

			path.AddBezier(new PointF(bounds.Left, bounds.Top + 5),
						new PointF(bounds.Left + 1, bounds.Top + 3),
						new PointF(bounds.Left + 3, bounds.Top + 1),
						new PointF(bounds.Left + 5, bounds.Top));

			path.AddLine(new PointF(bounds.Left + 5, bounds.Top),
				new PointF(bounds.Right - 6, bounds.Top));

			path.AddBezier(new PointF(bounds.Right - 7, bounds.Top),
				new PointF(bounds.Right - 2, bounds.Top + 1),
				new PointF(bounds.Right-1, bounds.Top + 4),
				new PointF(bounds.Right-1, bounds.Top + 5));

			path.AddLine(new PointF(bounds.Right, bounds.Top + 5),
						new PointF(bounds.Right, bounds.Bottom));
			return path;
		}

		// Border path for selected tabs.
		private GraphicsPath GetSelectedTabBorderPathFromBounds(RectangleF bounds)
		{
			GraphicsPath path = new GraphicsPath();

			path.AddBezier(new PointF(bounds.Left, bounds.Bottom-1),
							new PointF(bounds.Left + 12, bounds.Bottom-7),
							new PointF(bounds.Left + 10, bounds.Top),
							new PointF(bounds.Left + 25, bounds.Top)
							);

			path.AddLine(new PointF(bounds.Left + 25, bounds.Top),
				new PointF(bounds.Right - 26, bounds.Top));

			path.AddBezier(new PointF(bounds.Right-26, bounds.Top),
							new PointF(bounds.Right-12	, bounds.Top + 3),
							new PointF(bounds.Right - 15, bounds.Bottom-5),
						   new PointF(bounds.Right, bounds.Bottom));

			return path;
		}
		protected override void DrawBorders(DrawTabEventArgs drawItemInfo)
		{
			RectangleF r = new RectangleF(drawItemInfo.Bounds.Left,
				drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Width, drawItemInfo.Bounds.Height);

			Graphics g = drawItemInfo.Graphics;

			SmoothingMode oldSM = g.SmoothingMode;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			
			// Get appropriate path and draw the border.
			if((drawItemInfo.State & DrawItemState.Selected) > 0)
				drawItemInfo.Graphics.DrawPath(new Pen(Color.FromArgb(42, 67, 126), 1), 
					this.GetSelectedTabBorderPathFromBounds(r));
			else
				drawItemInfo.Graphics.DrawPath(new Pen(Color.FromArgb(42, 67, 126), 1), 
					this.GetBorderPathFromBounds(r));

			g.SmoothingMode = oldSM;
		}
		// Same as the base class except this one does not draw the focus rect.
		protected override void DrawInterior(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;

			Rectangle bounds = drawItemInfo.BoundsInterior;
			RectangleF rectTextAndImage = TabUtils.ApplyTransform(g, this.TabAlignment, 
				RectangleF.FromLTRB(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom), true);

			ApplyTransform(g);

			DrawTextAndImage(g, rectTextAndImage, drawItemInfo);

			g.ResetTransform();
		}

		protected override Color GetForeColor()
		{
			return Color.Gray;
		}
		#endregion DRAWING
	}
}
