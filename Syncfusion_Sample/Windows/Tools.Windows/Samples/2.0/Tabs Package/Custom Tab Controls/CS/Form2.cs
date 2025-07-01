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
using System.Drawing.Drawing2D;

using Syncfusion.Windows.Forms.Tools;

namespace CustomTabControls
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

		public Form2()
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
				if(components != null)
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
			this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
			this.tabControlAdv1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlAdv1
			// 
			this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.Lavender;
			this.tabControlAdv1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tabControlAdv1.BackColor = System.Drawing.Color.White;
			this.tabControlAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.tabPageAdv1,
																						 this.tabPageAdv2,
																						 this.tabPageAdv3});
			this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.WhiteSmoke;
			this.tabControlAdv1.ItemSize = new System.Drawing.Size(80, 30);
			this.tabControlAdv1.Location = new System.Drawing.Point(8, 56);
			this.tabControlAdv1.Name = "tabControlAdv1";
			this.tabControlAdv1.Size = new System.Drawing.Size(260, 136);
			this.tabControlAdv1.TabIndex = 0;
			this.tabControlAdv1.TabStyle = typeof(CustomTabControls.TabRendererNotched);
			// 
			// tabPageAdv1
			// 
			this.tabPageAdv1.BackColor = System.Drawing.Color.Lavender;
			this.tabPageAdv1.Location = new System.Drawing.Point(1, 33);
			this.tabPageAdv1.Name = "tabPageAdv1";
			this.tabPageAdv1.Size = new System.Drawing.Size(257, 101);
			this.tabPageAdv1.TabIndex = 0;
			this.tabPageAdv1.Text = "Tab1";
			// 
			// tabPageAdv2
			// 
			this.tabPageAdv2.BackColor = System.Drawing.Color.Lavender;
			this.tabPageAdv2.Location = new System.Drawing.Point(1, 33);
			this.tabPageAdv2.Name = "tabPageAdv2";
			this.tabPageAdv2.Size = new System.Drawing.Size(257, 101);
			this.tabPageAdv2.TabIndex = 1;
			this.tabPageAdv2.Text = "Tab2";
			// 
			// tabPageAdv3
			// 
			this.tabPageAdv3.BackColor = System.Drawing.Color.Lavender;
			this.tabPageAdv3.Location = new System.Drawing.Point(1, 33);
			this.tabPageAdv3.Name = "tabPageAdv3";
			this.tabPageAdv3.Size = new System.Drawing.Size(257, 101);
			this.tabPageAdv3.TabIndex = 2;
			this.tabPageAdv3.Text = "Tab3";
			// 
			// designTimeTabTypeLoader
			// 
			this.designTimeTabTypeLoader.TypesToLoadList.Add(new Syncfusion.Reflection.TypeName("CustomTabControls.TabRendererNotched"));
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Custom Notched appearance:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(24, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 48);
			this.label2.TabIndex = 2;
			this.label2.Text = "Build this project for the tab to appear properly in this designer.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(288, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.tabControlAdv1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Custom Tabs: Notched";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
			this.tabControlAdv1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e)
		{
			// Set the custom notched tab renderer here, if not already set above.
			//this.tabControlAdv1.TabStyle = typeof(TabRendererNotched);
		}
	}

	// Provides certain default properties for the Notched Tab Renderer.
	public class TabPanelPropertyNotched : TabUIDefaultProperties
	{
		// The selected tab's bounds will overlap the normal tab's bounds by this much.
		public override SizeF GetOverlapSize(SizeF tabSize)
		{
			return new SizeF(6, 3);
		}
	}

	// Implement a tab renderer that can draw a notched tab.
	public class TabRendererNotched : TabRendererBase
	{
		// A reference to the default properties provdier.
		static TabUIDefaultProperties tabPanelPropertyExtender_;
		// Exposes the default appearance properties to the tab panel renderer.
		public static TabUIDefaultProperties TabPanelPropertyExtender
		{
			get{return tabPanelPropertyExtender_;}
		}

		// Specifies the name by which this renderer will be identified.
		public static string TabStyleName { get{return "Notched";}
		}

		// Necessary for the TabControlAdv to pick up this custom tab type.
		static TabRendererNotched()
		{
			tabPanelPropertyExtender_ = new TabPanelPropertyNotched();
			TabRendererFactory.RegisterTabType(TabStyleName, typeof(TabRendererNotched), TabPanelPropertyExtender );
		}

		public TabRendererNotched(ITabControl parent, ITabPanelRenderer panelRenderer)
			: base(parent, panelRenderer)
		{
		}

		public override SizeF GetOverlapSize(SizeF tabSize)
		{
			return TabPanelPropertyExtender.GetOverlapSize(tabSize);
		}

		protected RectangleF AdjustBoundsAndGraphicsForAlignment(Graphics g, RectangleF oldBounds, TabAlignment align)
		{
			// Increase tab bounds based on alignment
			RectangleF newBounds = oldBounds;
			switch(align)
			{
				case TabAlignment.Top: newBounds.Height += 3;break;
				case TabAlignment.Right: newBounds.Offset(-3, 0); newBounds.Width += 3; break;
				case TabAlignment.Left: newBounds.Width += 3; break;
				case TabAlignment.Bottom: newBounds.Offset(0, -3); newBounds.Height += 3; break;
			}

			g.SetClip(new Region(oldBounds), CombineMode.Intersect);
			return newBounds;
		}

		// Polygon border that gives a notched appearance
		public PointF[] GetPolygonFromBounds(RectangleF bounds, TabAlignment curAlign)
		{
			PointF[] polygon = null;
			switch(curAlign)
			{
				case TabAlignment.Top:
					polygon = new PointF[]{new PointF(bounds.Left, bounds.Bottom - 3),
									   new PointF(bounds.Left, bounds.Top + 6),
									   new PointF(bounds.Left + 6, bounds.Top),
									   new PointF(bounds.Right - 3, bounds.Top),
									   new PointF(bounds.Right - 1, bounds.Top + 2),
									   new PointF(bounds.Right - 1, bounds.Bottom - 3),
									   new PointF(bounds.Right - 3, bounds.Bottom - 1),
									   new PointF(bounds.Left + 2, bounds.Bottom - 1)
								   };
					break;
				case TabAlignment.Left:
					polygon = new PointF[]{new PointF(bounds.Left, bounds.Bottom - 6),
								   new PointF(bounds.Left, bounds.Top + 2),
								   new PointF(bounds.Left + 2, bounds.Top),
								   new PointF(bounds.Right - 3, bounds.Top),
								   new PointF(bounds.Right - 1, bounds.Top + 2),
								   new PointF(bounds.Right - 1, bounds.Bottom - 3),
								   new PointF(bounds.Right - 3, bounds.Bottom - 1),
								   new PointF(bounds.Left + 6, bounds.Bottom - 1)
							   };
					break;
				case TabAlignment.Bottom:
				case TabAlignment.Right:
					polygon = new PointF[]{new PointF(bounds.Left, bounds.Bottom - 3),
								   new PointF(bounds.Left, bounds.Top + 2),
								   new PointF(bounds.Left + 2, bounds.Top),
								   new PointF(bounds.Right - 3, bounds.Top),
								   new PointF(bounds.Right - 1, bounds.Top + 2),
								   new PointF(bounds.Right - 1, bounds.Bottom - 8),
								   new PointF(bounds.Right - 8, bounds.Bottom - 1),
								   new PointF(bounds.Left + 2, bounds.Bottom - 1)
							   };
					break;
			}
			return polygon;
		}

		// Draws the background of the tab.
		protected override void DrawBackground(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;

			RectangleF currentBounds = RectangleF.FromLTRB(drawItemInfo.Bounds.Left,
											drawItemInfo.Bounds.Top,
											drawItemInfo.Bounds.Right,
											drawItemInfo.Bounds.Bottom);
			Region oldClipRegion = g.Clip;
			currentBounds = AdjustBoundsAndGraphicsForAlignment(g, currentBounds, this.TabAlignment);		

			PointF[] polygon = GetPolygonFromBounds(currentBounds, this.TabAlignment);
			g.FillPolygon(new SolidBrush(drawItemInfo.BackColor), polygon);

			g.SetClip(oldClipRegion, CombineMode.Replace);
		}

		// Draws the borders of the tab.
		protected override void DrawBorders(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;

			RectangleF currentBounds = RectangleF.FromLTRB(drawItemInfo.Bounds.Left,
														drawItemInfo.Bounds.Top,
														drawItemInfo.Bounds.Right,
														drawItemInfo.Bounds.Bottom);
			Region oldClipRegion = g.Clip;
			currentBounds = AdjustBoundsAndGraphicsForAlignment(g, currentBounds, this.TabAlignment);		

			PointF[] polygon = GetPolygonFromBounds(currentBounds, this.TabAlignment);

			// Draw left line
			g.DrawLine(new Pen(SystemColors.ControlLightLight), polygon[0],
				polygon[1]);
			// Draw Top-Left Hatch
			g.DrawLine(new Pen(SystemColors.ControlLightLight), polygon[1], polygon[2]);
			// top line
			g.DrawLine(new Pen(SystemColors.ControlLightLight), polygon[2], polygon[3]);
			// right hatch
			g.DrawLine(new Pen(SystemColors.ControlLightLight), polygon[3], polygon[4]);
			// right line
			g.DrawLine(new Pen(SystemColors.ControlDarkDark), polygon[4], polygon[5]);
			// right shade
			g.DrawLine(new Pen(Color.DarkGray), new PointF(polygon[4].X - 1, polygon[4].Y - 1),
				new PointF(polygon[5].X - 1, polygon[5].Y + 2));
			// bottom line
			g.DrawLine(new Pen(SystemColors.ControlDarkDark), polygon[6], polygon[7]);
			// bottom shade
			g.DrawLine(new Pen(Color.DarkGray), new PointF(polygon[6].X + 1, polygon[6].Y - 1),
				new PointF(polygon[7].X - 2, polygon[7].Y - 1));
			// Right-Bottom hatch
			PointF point2 = new PointF(polygon[6].X - 1, polygon[6].Y + 1);
			g.DrawLine(new Pen(SystemColors.ControlDarkDark), polygon[5], point2);
			// left-bottom hatch
			if(this.TabAlignment == TabAlignment.Left)
			{
				point2 = new PointF(polygon[0].X, polygon[0].Y - 1);
				g.DrawLine(new Pen(SystemColors.ControlDarkDark), polygon[7], point2);
			}

			g.SetClip(oldClipRegion, CombineMode.Replace);
		}

		// Draws the interior of the tab.
		protected override void DrawInterior(DrawTabEventArgs drawItemInfo)
		{
			Graphics g = drawItemInfo.Graphics;
			
			// Convert to horizontal co-ords...
			RectangleF boundsF = RectangleF.FromLTRB(drawItemInfo.BoundsInterior.Left,
				drawItemInfo.BoundsInterior.Top,
				drawItemInfo.BoundsInterior.Right,
				drawItemInfo.BoundsInterior.Bottom);
			RectangleF rectTextAndImage = TabUtils.ApplyTransform(g, this.TabAlignment, boundsF, true);

			// ... and apply the same transform to g, so that we can have a single drawing logic
			// for all alignments
			ApplyTransform(g);

			// Use TabRendererBase's default drawing logic.
			DrawTextAndImage(g, rectTextAndImage, drawItemInfo);

			// Uncomment this if the tabcontrol should draw a focus rect when in focus.
//			if(((int)drawItemInfo.State & (int)DrawItemState.Focus) > 0)
//				DrawFocusRect(g, this.Bounds, drawItemInfo.ForeColor, drawItemInfo.BackColor);

			g.ResetTransform();
		}
	}
}
