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

namespace LayoutManagers
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;


	/// <summary>
	/// Summary description for NonControlBasedComponents.
	/// </summary>
	public class NonControlBasedComponents : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components = null;
		private MyRectangle myRect1;
		private MyRectangle myRect2;
		private Syncfusion.Windows.Forms.Tools.GridBagLayout gridBagLayout1;
		private MyPanel panel1;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private MyRectangle myRect3;

		public NonControlBasedComponents()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NonControlBasedComponents));
			this.gridBagLayout1 = new Syncfusion.Windows.Forms.Tools.GridBagLayout(this.components);
			this.panel1 = new LayoutManagers.MyPanel();
			this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridBagLayout1
			// 
			this.gridBagLayout1.ContainerControl = this.panel1;
			// 
			// panel1
			// 
			this.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(8, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(496, 224);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(247))), System.Drawing.Color.FromArgb(((System.Byte)(182)), ((System.Byte)(211)), ((System.Byte)(241))));
			this.gradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
				| System.Windows.Forms.Border3DSide.Right) 
				| System.Windows.Forms.Border3DSide.Bottom);
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(512, 40);
			this.gradientLabel1.TabIndex = 2;
			this.gradientLabel1.Text = "3 Non-Control, LayoutItemBase derived objects being laid out:";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NonControlBasedComponents
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.ClientSize = new System.Drawing.Size(512, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gradientLabel1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NonControlBasedComponents";
			this.Text = "Laying out Non-Control derived components";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		// <samplecodeblock name="Initializing LayoutItemBase derived class">
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.SuspendLayout();
			// Current layout manager (Update every time you change the manager)
			
			// Layout Component 1
			this.myRect1 = new MyRectangle(this.gridBagLayout1.ContainerControl, Color.FromArgb(133, 191, 117), "Paint Area 1");
			this.myRect1.Bounds = new Rectangle(10, 10, 80, 20);
			this.myRect1.Visible = true;

			// Layout Component 2
			this.myRect2 = new MyRectangle(this.gridBagLayout1.ContainerControl, Color.FromArgb(222, 100, 19), "Paint Area 2");
			this.myRect2.Bounds = new Rectangle(10, 40, 80, 20);
			this.myRect2.Visible = true;

			// Layout Component 3
			this.myRect3 = new MyRectangle(this.gridBagLayout1.ContainerControl, Color.FromArgb(196, 214, 233), "Paint Area 3");
			this.myRect3.Bounds = new Rectangle(10, 70, 80, 20);
			this.myRect3.Visible = true;


			// Sample GridBagConstraints
			GridBagConstraints gbc1 = new GridBagConstraints();
			GridBagConstraints gbc2 = new GridBagConstraints();
			GridBagConstraints gbc3 = new GridBagConstraints();

			gbc1.Fill = FillType.Both;
			gbc1.WeightX = 0.2;
			gbc1.WeightY = 0.5;
			gbc1.GridPosX = 0;
			gbc1.GridPosY = 0;

			gbc2.Fill = FillType.Both;
			gbc2.WeightX = 0.2;
			gbc2.WeightY = 0.5;
			gbc2.GridPosX = 1;
			gbc2.GridPosY = 0;

			gbc3.Fill = FillType.Both;
			gbc3.WeightX = 0.4;
			gbc3.WeightY = 0.5;
			gbc3.GridPosX = 0;
			gbc3.GridPosY = 1;
			gbc3.CellSpanX = 2;

			// Add all the components that are to participate in Layout Management
			
			// For GridBagLayouts pass gbcs for GridBagLayouts
			this.gridBagLayout1.SetConstraints(this.myRect1.ToControl(), gbc1);	
			this.gridBagLayout1.SetConstraints(this.myRect2.ToControl(), gbc2);
			this.gridBagLayout1.SetConstraints(this.myRect3.ToControl(), gbc3);

			this.ResumeLayout(true);
		}
		//</samplecodeblock>

		private void Panel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(this.myRect1.Bounds.IntersectsWith(e.ClipRectangle)
				&& this.myRect1.Visible)
				myRect1.OnPaint(e);
			if(this.myRect2.Bounds.IntersectsWith(e.ClipRectangle)
				&& this.myRect2.Visible)
				myRect2.OnPaint(e);
			if(this.myRect3.Bounds.IntersectsWith(e.ClipRectangle)
				&& this.myRect3.Visible)
				myRect3.OnPaint(e);
		}

		#region WHEN_USING_CUSTOMLAYOUTBOUNDS
		/* If you use custom layout bounds, then update the custom layout bounds set in 
		 * the manager whenever the ContainerControl's size changes.
		private void Form1_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			this.flowLayout1.CustomLayoutBounds = this.panel1.ClientRectangle;
			this.flowLayout1.LayoutContainer();
			this.Invalidate();
			this.Update();
		}*/
		#endregion WHEN_USING_CUSTOMLAYOUTBOUNDS


		#region WHEN_USING_CARDLAYOUT
		/* Some code for CardLayout
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.First();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Next();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Previous();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Last();
		}*/
		#endregion WHEN_USING_CARDLAYOUT
	}

	//<samplecodeblock name="Sample LayoutItemBase Derived Class">
	public class MyRectangle : LayoutItemBase
	{
		public static Size PrefSize = new Size(0, 0);
		protected Control parent;
		protected Color color;
		protected string text;
		public MyRectangle(Control parent, Color color, string text)
		{
			this.parent = parent;
			this.color = color;
			this.text = text;
		}
		public void OnPaint( PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(color), this.Bounds);
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			RectangleF r = new RectangleF(Bounds.Left, Bounds.Top,
				Bounds.Width, Bounds.Height);
			e.Graphics.DrawString(text, Control.DefaultFont, SystemBrushes.ControlText, r, sf);
		}
		// This override is a good place to repaint.
		// Or you can listen to BoundsChanged event in LayoutItemBase.
		protected override void OnBoundsChanged()
		{
			parent.Invalidate(new Rectangle(0, 0, this.parent.Width, this.parent.Height));
		}

		public override System.Drawing.Size MinimumSize
		{
			get	{	return MyRectangle.PrefSize;	}
		}

		public override System.Drawing.Size PreferredSize
		{
			get	
			{
				return MyRectangle.PrefSize;
			}
		}
	}
	// </samplecodeblock>

	public class ImageUtil
	{
		private Image baseImage;

		private void InitBaseImage(Image baseImage)
		{
			this.baseImage = baseImage.Clone() as Image;
		}

		private Image ApplyNewColorOnImage(Color newColor)
		{
			// Create a new bitmap off the base image.
			Image newImage = this.baseImage.Clone() as Image;
			Bitmap newBitmap = new Bitmap(newImage);
					
			// Set the Color cue pixels to the appropriate color.
			// This logic of course, depends on the actual bitmap.
			for(int i = 12; i <= 14; i++)
			for(int j = 2; j <= 14; j++)
				newBitmap.SetPixel(j, i, newColor);

			return newImage;
		}
	}

	public class MyPanel : Panel
	{
		public MyPanel()
		{
			// So that painting will be smooth on resizing.
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}
