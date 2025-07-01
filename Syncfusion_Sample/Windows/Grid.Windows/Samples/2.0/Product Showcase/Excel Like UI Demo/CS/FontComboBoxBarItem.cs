using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Grid;

namespace ExcelLikeUI_2005
{
	/// <summary>
	/// Summary description for FontComboBoxBarItem.
	/// </summary>
	public class FontComboBoxBarItem : ComboBoxBarItem
	{
		public FontComboBoxBarItem()
			:base()
		{
			//
			// TODO: Add constructor logic here
			//
			this.ListBox = new FontListBox();
			
		}
		protected FontComboBoxBarItem(SerializationInfo info, StreamingContext context)
			:base(info, context)
		{
			this.ListBox = new FontListBox();
		}

		
	}


	public class FontListBox : System.Windows.Forms.ListBox
	{
		#region Private variables
		//private ArrayList favourites;
		private string[] nonreadable;
		private Image image;
		private Font defaultFont;
		private StringFormat nonReadableStringFormat;
		private StringFormat standardStringFormat;
		#endregion

		#region Constructors
		public FontListBox()
		{
			this.DrawMode = DrawMode.OwnerDrawFixed;

			//maxFavourites = 5;
			image = null;
			defaultFont = new Font("Tahoma", 8);
			nonReadableStringFormat = new StringFormat();
			nonReadableStringFormat.LineAlignment = StringAlignment.Center;

			standardStringFormat = new StringFormat();
			standardStringFormat.FormatFlags = StringFormatFlags.NoWrap;
			//favourites = new ArrayList();

			if (!DesignMode)
			{
				GetFonts(this.CreateGraphics());

				//favourites.Add("Arial");
				//this.Items.Insert(0, favourites[0].ToString());
			}

			nonreadable = new string[]{"CommercialPi BT","GreekC","GreekS","Marlett", "Monotype Corsiva", "MS Outlook","Nokia PC Composer", 
										  "UniversalMath1 BT", "Symusic", "Symeteo", "Symbol", "Symath", "Symap", "Syastro",
										  "Webdings", "Wingdings", "Wingdings 2", "Wingdings 3"};
		}

		#endregion

		#region Public Properties
		[DefaultValue(null)]
		public System.Drawing.Image Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				this.Invalidate();
			}
		}

		[Browsable(false)]
		public string[] NonReadableFonts
		{
			get
			{
				return nonreadable;
			}
			set
			{
				nonreadable = value;
				this.Invalidate();
			}
		}

//		[DefaultValue(5)]
//		public int MaximumFavourites
//		{
//			get
//			{
//				return maxFavourites;
//			}
//			set
//			{
//				maxFavourites = value;
//				this.Invalidate();
//			}
//		}

		#endregion

		#region Private Functions
		private void GetFonts(Graphics g)
		{
			System.Drawing.Text.InstalledFontCollection installedFonts = new System.Drawing.Text.InstalledFontCollection();

			FontFamily[] fonts = installedFonts.Families;
			this.BeginUpdate();
			string name = "";
			foreach (FontFamily font in fonts)
			{
				name = font.Name.Trim();
				if (!this.Items.Contains(name))
				{
					this.Items.Add(name);
				}
			}
			this.EndUpdate();
		}

		private void DrawSeperator(Graphics g, Rectangle rect)
		{
			Pen pen = new Pen(ControlPaint.LightLight(this.ForeColor));
			g.DrawLine(pen, rect.X + 1, rect.Y + rect.Height - 3, rect.X + rect.Width - 2, rect.Y + rect.Height - 3);
			g.DrawLine(pen, rect.X + 1, rect.Y + rect.Height - 1, rect.X + rect.Width - 2, rect.Y + rect.Height - 1);
		}

		private bool IsNonReadableFont(string FontName)
		{
			foreach (string non in nonreadable)
			{
				if (FontName == non)
				{
					return true;
				}
			}
			return false;
		}

		#endregion

		#region Overriden Functions / Events
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if (e.Index < 0)
			{
				return;
			}
			if ((e.Index == 0) && (Items.Count == 0))
			{
				return;
			}
			Graphics g = e.Graphics;
			Rectangle imgRect;
			Rectangle textRect;
			Font font = null;
			SolidBrush brush = new SolidBrush(e.ForeColor);
			string fontName = this.Items[e.Index].ToString();

			try
			{
				font = new Font(fontName, this.Font.Size);
			}
			catch
			{
				font = defaultFont;
			}
			

			e.DrawBackground();

			if (image != null)
			{
				imgRect = new Rectangle(e.Bounds.X, e.Bounds.Y, image.Width, image.Height);
			}
			else
			{
				// No image
				imgRect = new Rectangle(e.Bounds.X, e.Bounds.Y, 0, 0);
			}

			textRect = new Rectangle(imgRect.X + imgRect.Width + 2, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

			if (image != null)
			{
				g.DrawImage(image, imgRect);
			}

			if (IsNonReadableFont(fontName))
			{
				g.DrawString(fontName, defaultFont, brush, textRect, nonReadableStringFormat);
				int wordwidth = g.MeasureString(fontName, defaultFont).ToSize().Width;
				g.DrawString(fontName, font, brush, new Rectangle(textRect.X + wordwidth, textRect.Y, e.Bounds.Width, e.Bounds.Height), standardStringFormat);
			}
			else
			{
				g.DrawString(fontName, font, brush, textRect, standardStringFormat);
			}

			e.DrawFocusRectangle();

//			if (favourites.Count - 1 == e.Index)
//			{
//				DrawSeperator(g, e.Bounds);
//			}
		}
		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			base.OnSelectedIndexChanged(e);

			string fontName = this.Text;

			if (fontName == "") { return; }
//			int indexOf = favourites.IndexOf(fontName);
//			if (indexOf == -1)
//			{
//				if (maxFavourites > favourites.Count)
//				{
//					// Insert new
//					favourites.Insert(0, fontName);
//					this.Items.Insert(0, fontName);
//				}
//				else
//				{
//					// Don't add any new fonts - replace instead
//					favourites.RemoveAt(maxFavourites - 1);
//					favourites.Insert(0, fontName);
//					this.Items.RemoveAt(maxFavourites - 1);
//					this.Items.Insert(0, fontName);
//				}
//			}
//			else
			{
//				// Move existing arount
//				if (favourites.Count > 1)
//				{
//					favourites.RemoveAt(indexOf);
//					favourites.Insert(0, fontName);
//					this.Items.RemoveAt(indexOf);
//					this.Items.Insert(0, fontName);
//				}
			}
			this.EndUpdate();

		}

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.ItemHeight = this.Font.Height + 3;
			// 3 is used here to allow for the favourites seperator line 
		}

		#endregion

		#region Hidden Properties
		[Browsable(false)]
		public override DrawMode DrawMode
		{
			get
			{
				return base.DrawMode;
			}
			set
			{
				base.DrawMode = value;
			}
		}
		[Browsable(false)]
		public override SelectionMode SelectionMode
		{
			get
			{
				return base.SelectionMode;
			}
			set
			{
				base.SelectionMode = value;
			}
		}
		//		[Browsable(false)]
		//		public override int ItemHeight
		//		{
		//			get
		//			{
		//				return base.ItemHeight;
		//			}
		//			set
		//			{
		//				base.ItemHeight = value;
		//			}
		//		}
		#endregion

		
	}
}
