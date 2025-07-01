using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace nesteddockinglayout
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		#region Variable declaration

		private Syncfusion.Windows.Forms.Tools.DockingManager dm;
		private System.ComponentModel.IContainer components;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlpanel1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlpanel2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlpanel3;
		private bool bNestedTab;

		#endregion

		#region VS Form code ( Constructor , Initialization and Disposing )

		public UserControl1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
            Syncfusion.Windows.Forms.Tools.CaptionButton captionButton1 = new Syncfusion.Windows.Forms.Tools.CaptionButton();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.CaptionButton captionButton2 = new Syncfusion.Windows.Forms.Tools.CaptionButton();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.CaptionButton captionButton3 = new Syncfusion.Windows.Forms.Tools.CaptionButton();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.CaptionButton captionButton4 = new Syncfusion.Windows.Forms.Tools.CaptionButton();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.dm = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.pnlpanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pnlpanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pnlpanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.ActiveCaptionFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionButton1.ImageIndex = -1;
            captionButton1.Name = "CloseButton";
            captionButton1.SuperToolTipInfo = toolTipInfo1;
            captionButton1.ToolTip = "Close";
            captionButton1.TransparentImageColor = System.Drawing.Color.Transparent;
            captionButton1.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close;
            captionButton2.ImageIndex = -1;
            captionButton2.Name = "PinButton";
            captionButton2.SuperToolTipInfo = toolTipInfo2;
            captionButton2.ToolTip = "Auto Hide";
            captionButton2.TransparentImageColor = System.Drawing.Color.Transparent;
            captionButton2.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin;
            captionButton3.ImageIndex = -1;
            captionButton3.Name = "MenuButton";
            captionButton3.SuperToolTipInfo = toolTipInfo3;
            captionButton3.ToolTip = "Window Position";
            captionButton3.TransparentImageColor = System.Drawing.Color.Transparent;
            captionButton3.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu;
            captionButton4.ImageIndex = -1;
            captionButton4.Name = "MaximizeButton";
            captionButton4.SuperToolTipInfo = toolTipInfo4;
            captionButton4.ToolTip = "Maximize";
            captionButton4.TransparentImageColor = System.Drawing.Color.Transparent;
            captionButton4.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize;
            this.dm.CaptionButtons.Add(captionButton1);
            this.dm.CaptionButtons.Add(captionButton2);
            this.dm.CaptionButtons.Add(captionButton3);
            this.dm.CaptionButtons.Add(captionButton4);
            this.dm.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dm.DockLayoutStream")));
            this.dm.DockToFill = true;
            this.dm.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005;
            this.dm.HostControl = this;
            this.dm.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dm.DockAllow += new Syncfusion.Windows.Forms.Tools.DockAllowEventHandler(this.dm_DockAllow);
            this.dm.SetDockLabel(this.pnlpanel1, "Orange");
            this.dm.SetDockLabel(this.pnlpanel2, "Blue");
            this.dm.SetDockLabel(this.pnlpanel3, "Maroon");
            // 
            // pnlpanel1
            // 
            this.pnlpanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(57))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(132))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(132))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))))});
            this.pnlpanel1.BorderColor = System.Drawing.Color.Black;
            this.dm.SetEnableDocking(this.pnlpanel1, true);
            this.pnlpanel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlpanel1.Location = new System.Drawing.Point(3, 22);
            this.pnlpanel1.Name = "pnlpanel1";
            this.pnlpanel1.Size = new System.Drawing.Size(177, 335);
            this.pnlpanel1.TabIndex = 8;
            this.pnlpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel1_Paint);
            // 
            // pnlpanel2
            // 
            this.pnlpanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(117)))), ((int)(((byte)(165))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(203)))), ((int)(((byte)(231))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(203)))), ((int)(((byte)(231))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(117)))), ((int)(((byte)(165)))))});
            this.pnlpanel2.BorderColor = System.Drawing.Color.Black;
            this.dm.SetEnableDocking(this.pnlpanel2, true);
            this.pnlpanel2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.pnlpanel2.Location = new System.Drawing.Point(3, 22);
            this.pnlpanel2.Name = "pnlpanel2";
            this.pnlpanel2.Size = new System.Drawing.Size(151, 359);
            this.pnlpanel2.TabIndex = 9;
            // 
            // pnlpanel3
            // 
            this.pnlpanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(56)))), ((int)(((byte)(41))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(93)))), ((int)(((byte)(74))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(93)))), ((int)(((byte)(74))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))))});
            this.pnlpanel3.BorderColor = System.Drawing.Color.Black;
            this.dm.SetEnableDocking(this.pnlpanel3, true);
            this.pnlpanel3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.pnlpanel3.Location = new System.Drawing.Point(3, 22);
            this.pnlpanel3.Name = "pnlpanel3";
            this.pnlpanel3.Size = new System.Drawing.Size(177, 335);
            this.pnlpanel3.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(344, 384);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlpanel3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		#endregion

		#region Properties

		//Assigning Themes to the DockingManager
		public bool ThemesEnabled
		{
			set
			{
				dm.ThemesEnabled=value;
			}
		}

		//Assigning VisualStyles to the DockingManager
		public VisualStyle VisualStyle
		{
			set
			{
				dm.VisualStyle=value;
			}
		}

		//Assigning DragProviderStyle to the DockingManager
		public DragProviderStyle DragProviderStyle
		{
			set
			{
				dm.DragProviderStyle=value;
			}
		}

		//Assigning NextedTabbing to the DockingManager
		public bool NestedTabbing
		{
			get
			{
				return bNestedTab;
			}
			set
			{
				bNestedTab=value;
				if(bNestedTab)
				{
					this.dm.LockHostFormUpdate();

                    if (dm.GetDockVisibility(pnlpanel1) && dm.GetDockVisibility(pnlpanel2) && dm.GetDockVisibility(pnlpanel3))
                    {
                        dm.DockControl(pnlpanel1, this, DockingStyle.Left, this.Width - 10);
                        dm.DockControl(pnlpanel2, pnlpanel1, DockingStyle.Tabbed, 100);
                        dm.DockControl(pnlpanel3, pnlpanel2, DockingStyle.Tabbed, 100, true);
                    }

					this.dm.UnlockHostFormUpdate();
				}
			}
		}

		#endregion

		#region Event Handlers 

		private void UserControl1_Load(object sender, System.EventArgs e)
		{
		
		}

		//Not allowing nexted tabbing when NextedTabbing is on.
		private void dm_DockAllow(object sender, Syncfusion.Windows.Forms.Tools.DockAllowEventArgs arg)
		{
			if(this.NestedTabbing && arg.DockStyle !=DockingStyle.Tabbed)
			{
				arg.Cancel =true;
			}
		}

		#endregion

		private void pnlPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

	}
}
