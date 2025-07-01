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

namespace PopupsInDepth
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms;
	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms.Tools.XPMenus;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private System.Windows.Forms.Label label1;
		private TextBoxWithPopup sourceTextBox;
		private System.Windows.Forms.TextBox popupTextBox_;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button cancelButton_;
		private System.Windows.Forms.Button popupInvokeButton;
		private System.Windows.Forms.Button popupMenuButton;
		private PopupMenu popupMenu;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.ComponentModel.IContainer components;

		public Form1()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.cancelButton_ = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.popupTextBox_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.popupInvokeButton = new System.Windows.Forms.Button();
            this.popupMenuButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sourceTextBox = new PopupsInDepth.TextBoxWithPopup();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.cancelButton_);
            this.popupControlContainer1.Controls.Add(this.OK);
            this.popupControlContainer1.Controls.Add(this.popupTextBox_);
            this.popupControlContainer1.Location = new System.Drawing.Point(152, 112);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(136, 136);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupControlContainer1_BeforePopup);
            // 
            // cancelButton_
            // 
            this.cancelButton_.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton_.Location = new System.Drawing.Point(59, 89);
            this.cancelButton_.Name = "cancelButton_";
            this.cancelButton_.Size = new System.Drawing.Size(48, 24);
            this.cancelButton_.TabIndex = 2;
            this.cancelButton_.Text = "Cancel";
            this.cancelButton_.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.Location = new System.Drawing.Point(6, 89);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(48, 24);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // popupTextBox_
            // 
            this.popupTextBox_.Dock = System.Windows.Forms.DockStyle.Top;
            this.popupTextBox_.Location = new System.Drawing.Point(0, 0);
            this.popupTextBox_.Multiline = true;
            this.popupTextBox_.Name = "popupTextBox_";
            this.popupTextBox_.Size = new System.Drawing.Size(136, 72);
            this.popupTextBox_.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList2;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popup here will overlap with the Edit control to give a seamless appearance.";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            // 
            // popupInvokeButton
            // 
            this.popupInvokeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.popupInvokeButton.Location = new System.Drawing.Point(16, 112);
            this.popupInvokeButton.Name = "popupInvokeButton";
            this.popupInvokeButton.Size = new System.Drawing.Size(48, 24);
            this.popupInvokeButton.TabIndex = 3;
            this.popupInvokeButton.Text = "Popup";
            this.popupInvokeButton.Click += new System.EventHandler(this.popupInvoke_Click);
            // 
            // popupMenuButton
            // 
            this.popupMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.popupMenuButton.Location = new System.Drawing.Point(16, 144);
            this.popupMenuButton.Name = "popupMenuButton";
            this.popupMenuButton.Size = new System.Drawing.Size(96, 24);
            this.popupMenuButton.TabIndex = 4;
            this.popupMenuButton.Text = "Popup Menu";
            this.popupMenuButton.Click += new System.EventHandler(this.popupMenuButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.FriendlyControl = null;
            this.sourceTextBox.Location = new System.Drawing.Point(16, 88);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.PopupControlContainer = null;
            this.sourceTextBox.PopupTextBox = null;
            this.sourceTextBox.Size = new System.Drawing.Size(200, 20);
            this.sourceTextBox.TabIndex = 2;
            this.sourceTextBox.Text = "Alt+DownArrow or button click for popup";
            this.sourceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPopupParent_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(402, 280);
            this.Controls.Add(this.popupMenuButton);
            this.Controls.Add(this.popupInvokeButton);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popupControlContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popups in Depth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}

		#region OpenClosePopup
		private void textBoxPopupParent_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// If user pressed key down, then show the popup.
			if(e.Alt && e.KeyCode == Keys.Down
				&& !this.popupControlContainer1.IsShowing())
			{
				// Let the popup align around the source textBox.
				this.popupControlContainer1.ParentControl = this.sourceTextBox;
				// Passing Point.Empty will align it automatically around the above ParentControl.
				this.popupControlContainer1.ShowPopup(Point.Empty);

				e.Handled = true;
			}
			// Escape should close the popup.
			if(e.KeyCode == Keys.Escape && this.popupControlContainer1.IsShowing())
				this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);

		}

		private void OK_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}
		#endregion OpenClosePopup

		private void Form1_Load(object sender, System.EventArgs e)
		{
			#region Initialize the custom TextBox
			// Initialize the custom TextBox
			this.sourceTextBox.PopupControlContainer = this.popupControlContainer1;
			this.sourceTextBox.PopupTextBox = this.popupTextBox_;
			// The popup will then not close when clicking on this FriendlyControl.
			this.sourceTextBox.FriendlyControl = this.popupInvokeButton;
			#endregion
			#region Create a popup menu
			// Create a popup menu
			this.popupMenu = new PopupMenu();
			this.popupMenu.ParentBarItem = new ParentBarItem();

			// Init the menu with 2 items.

			Syncfusion.Windows.Forms.Tools.XPMenus.BarItem v=new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
			this.popupMenu.ParentBarItem.Items.Add (v);
			
			v.Text ="Menu Item1 ";
			v.ImageList =this.imageList1 ;
			v.ImageIndex =0;
			
			Syncfusion.Windows.Forms.Tools.XPMenus.BarItem v1=new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
			this.popupMenu.ParentBarItem.Items.Add (v1);
			
			v1.Text ="Menu Item2 ";
			v1.ImageList =this.imageList1 ;
			v1.ImageIndex =1;
			#endregion
			
		}
		    #region ShowPopup
		private void popupInvoke_Click(object sender, System.EventArgs e)
		{
			// Toggle popup.
			if(this.popupControlContainer1.IsShowing())
				this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
			else
				this.popupControlContainer1.ShowPopup(Point.Empty);
		}
		#endregion
		    #region popupMenu
		private void popupMenuButton_Click(object sender, System.EventArgs e)
		{
			if(this.popupMenu.IsShowing())
				return;
			
			// Hide the popup if already open
			this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);

			// Show the menu now.
			// Use this method instead of the Show method in the PopupMenu
			// to allow the sourceTextBox to provide popup layout info.
			this.popupMenu.ShowChildrenUI(Point.Empty, this.sourceTextBox);
		}
		#endregion
		    #region BeforePopup
		// <samplecodeblock name="Resizable Popup sample">
		// The PopupControlContainer's BeforePopup event handler
		private void popupControlContainer1_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Create a reziable Popup

			// Make the popup host's border style resizable.
			this.popupControlContainer1.PopupHost.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.popupControlContainer1.PopupHost.BackColor = this.BackColor;

			// Necessary to set the host's client size every time, especially since the
			// popup's Dock style is set to DockStyle.Fill.
			if(!(this.popupControlContainer1.PopupHost.Size.Width >= 140))
				this.popupControlContainer1.PopupHost.Size = new System.Drawing.Size(140, 150);

			// So that the popup container will Fill the entire popup host when resized.
			this.popupControlContainer1.Dock = DockStyle.Fill;
		}
		// </samplecodeblock>
	}
	#endregion

	        #region Implementing IPopupParent
	// Implementing IPopupParent gives more control over the alignment and 
	// activation/deactivation of the popup.
	public class TextBoxWithPopup : TextBox, IPopupParent
	{
		private PopupControlContainer popupContainer;
		private TextBox popupTextBox_;

		public Control friendlyControl_;

		public PopupControlContainer PopupControlContainer
		{
			get{return this.popupContainer;}
			set
			{
				if(this.popupContainer != value)
				{
					this.popupContainer = value;
					this.popupContainer.PopupParent = this;
					this.popupContainer.BeforePopup += new CancelEventHandler(this.BeforePopup);
					this.popupContainer.Popup+= new EventHandler(this.AfterPopup);
					// Make sure to unsubscribe somewhere in your application.
				}
			}
		}

		// The text box in the popup.
		public TextBox PopupTextBox
		{
			get{return this.popupTextBox_;}
			set{this.popupTextBox_ = value;}
		}

		// Control which when selected will not close the popup.
		public Control FriendlyControl
		{
			get{return this.friendlyControl_;}
			set{this.friendlyControl_ = value;}
		}

		// Open/Close popup.
		protected override void OnKeyDown(KeyEventArgs e)
		{
			// If user pressed key down, then show the popup.
			if(e.Alt && e.KeyCode == Keys.Down
				&& !this.PopupControlContainer.IsShowing())
			{
				// Let the popup align around the source textBox.
				this.PopupControlContainer.ParentControl = this.popupTextBox_;
				// Passing Point.Empty will align it automatically around the above ParentControl.
				this.PopupControlContainer.ShowPopup(Point.Empty);

				e.Handled = true;
			}
			// Escape should close the popup.
			if(e.KeyCode == Keys.Escape && this.PopupControlContainer.IsShowing())
				this.PopupControlContainer.HidePopup(PopupCloseType.Canceled);

			base.OnKeyDown(e);
		}

		private void BeforePopup(object sender, CancelEventArgs args)
		{
			// Set the text to be edited with the text in the form text box.
			this.PopupTextBox.Text = this.Text;
		}

		private void AfterPopup(object sender, EventArgs args)
		{
			// Set the focus on the text box inside the popup after its open.
			this.PopupTextBox.Focus();
			this.PopupTextBox.SelectionStart = 0;
			this.PopupTextBox.SelectionLength = 0;
		}

		#region IPopupParent_Imp
		public Control GetPopupParentControl()
		{
			// Popup will align around this control if GetLocationForPopupAlignment\
			// returned Point.Empty.
			return this;
		}
		public bool IsRelatedControl(Control control, bool askPopupParent)
		{
			// The popup will then not lose focus automatically when Controls below
			// get the focus.
			if(control == this.friendlyControl_ || control == this)
				return true;
			else
				return false;
		}
		public void ChildClosing(IPopupChild childUI, PopupCloseType popupCloseType)
		{
			// Transfer data from the popup.
			if(popupCloseType == PopupCloseType.Done)
			{
				this.Text = this.PopupTextBox.Text;
			}
			// Set focus back to textbox.
			if(popupCloseType == PopupCloseType.Done
				|| popupCloseType == PopupCloseType.Canceled)
				this.Focus();
		}
		// Lets you provide a preferred location for popup.
		public Point GetLocationForPopupAlignment(PopupRelativeAlignment prevAlignment, 
			out PopupRelativeAlignment newAlignment)
		{
			Rectangle bounds = this.Bounds;
			// This utility method takes a rectangle and returns the 8 positions around
			// it 1 at a time. It will start with the alignment specified in the 3rd argument.
			Point pos = PopupUtils.ComputeDefaultPopupAlignment(prevAlignment, out newAlignment,
				PopupRelativeAlignment.RightTop, PopupRelativeAlignment.RightTop, bounds);

			return this.Parent.PointToScreen(pos);
		}

		public Point[] GetBorderOverlapCue(PopupRelativeAlignment relativeAlignment)
		{
			Rectangle bounds = this.Bounds;

			// This utility fucntion takes a rectangular bounds and relative alignemnt
			// and returns a line (array of 2 points) that represet the boundary
			// for the specified alignemnt.
			return PopupUtils.ComputeDefaultBorderOverlapCue(relativeAlignment, 
				this.RectangleToScreen(bounds));
		}
		public bool IsRightToLeft
		{
			get{return this.RightToLeft == RightToLeft.Yes;}
		}
		#endregion IPopupParent_Imp
	}
	#endregion
}
