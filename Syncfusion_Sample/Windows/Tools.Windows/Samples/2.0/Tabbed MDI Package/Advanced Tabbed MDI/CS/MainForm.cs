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

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace AdvancedTabbedMDI
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : Office2007Form
	{
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ComboBoxAdv customerChoices;
		private ComboBoxAdv orderChoices;
		private ArrayList customerForms;
		private ArrayList orderForms;
        private TabbedGroupedMDIManager tabbedMDIManager;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private GradientPanel gradientPanel3;
        private Label label3;
        private GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Initialize the forms list in the comboboxes.
			this.customerForms = new ArrayList(this.customerChoices.Items.Count);
			for(int i = 0; i < this.customerChoices.Items.Count; i++)
				this.customerForms.Add(null);

			this.orderForms = new ArrayList(this.orderChoices.Items.Count);
			for(int i = 0; i < this.orderChoices.Items.Count; i++)
				this.orderForms.Add(null);

			// Initialize the tabbed MDI manager
			this.tabbedMDIManager = new TabbedGroupedMDIManager();
			this.tabbedMDIManager.TabControlAdded += new TabbedMDITabControlEventHandler(tabbedMDIManager_TabControlAdded);
			this.tabbedMDIManager.AllowTabGroupCustomizing = false;
			this.tabbedMDIManager.Horizontal = true;
			this.tabbedMDIManager.DropDownButtonVisible = true;
			this.tabbedMDIManager.BeforeDropDownPopup += new DropDownPopupEventHandler(tabbedMDIManager_BeforeDropDownPopup); 
			
			this.tabbedMDIManager.CloseItem.ImageList  = this.imageList1;
			this.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
			this.tabbedMDIManager.CloseItem.ImageIndex = 1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.orderChoices = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerChoices = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderChoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(169, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 389);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 389);
            this.panel1.TabIndex = 3;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.buttonAdv1);
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Controls.Add(this.gradientPanel4);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(169, 389);
            this.gradientPanel1.TabIndex = 7;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.Location = new System.Drawing.Point(21, 283);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(112, 28);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Custom Weights";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.custWeights_Click);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(171)))), ((int)(((byte)(206)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.label3);
            this.gradientPanel3.Location = new System.Drawing.Point(8, 14);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(149, 49);
            this.gradientPanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "This sample shows you how \r\nto associate child forms \r\nto specific tab groups.";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(171)))), ((int)(((byte)(206)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.orderChoices);
            this.gradientPanel4.Controls.Add(this.label1);
            this.gradientPanel4.Controls.Add(this.label2);
            this.gradientPanel4.Controls.Add(this.customerChoices);
            this.gradientPanel4.Location = new System.Drawing.Point(8, 86);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(149, 164);
            this.gradientPanel4.TabIndex = 6;
            // 
            // orderChoices
            // 
            this.orderChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderChoices.IgnoreThemeBackground = true;
            this.orderChoices.Items.AddRange(new object[] {
            "Order 1",
            "Order 2",
            "Order 3",
            "Order 4",
            "Order 5"});
            this.orderChoices.Location = new System.Drawing.Point(12, 132);
            this.orderChoices.Name = "orderChoices";
            this.orderChoices.Size = new System.Drawing.Size(112, 21);
            this.orderChoices.SuppressDropDownEvent = false;
            this.orderChoices.TabIndex = 3;
            this.orderChoices.SelectionChangeCommitted += new System.EventHandler(this.orderChoices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Customer info in Customers tab group:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show Orders in Orders tab group:";
            // 
            // customerChoices
            // 
            this.customerChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerChoices.IgnoreThemeBackground = true;
            this.customerChoices.Items.AddRange(new object[] {
            "Customer 1",
            "Customer 2",
            "Customer 3",
            "Customer 4",
            "Customer 5"});
            this.customerChoices.Location = new System.Drawing.Point(12, 60);
            this.customerChoices.Name = "customerChoices";
            this.customerChoices.Size = new System.Drawing.Size(112, 21);
            this.customerChoices.SuppressDropDownEvent = false;
            this.customerChoices.TabIndex = 1;
            this.customerChoices.SelectionChangeCommitted += new System.EventHandler(this.customerChoices_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(608, 389);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Tabbed MDI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderChoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerChoices)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
            this.orderChoices.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.customerChoices.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;

			this.tabbedMDIManager.AttachToMdiContainer(this);
			// Specifiy the tab groups:
			this.tabbedMDIManager.TabbedGroups.Add(new TabbedGroup("Customers"));
			this.tabbedMDIManager.TabbedGroups.Add(new TabbedGroup("Orders"));
		}


		// Creating customer type child forms
		private CustomerInfoForm CreateCustomerInfoForm(string text)
		{
			CustomerInfoForm form = new CustomerInfoForm(text);

			// Add the CustomerInfoForm to a specific group.
			this.tabbedMDIManager.TabbedGroups["Customers"].AddForm(form);
			return form;
		}


		// Creating order type chid forms
		private OrderInfoForm CreateOrderInfoForm(string text)
		{
			OrderInfoForm form = new OrderInfoForm(text);

			// Add the OrderInfoForm to a specific group.
			this.tabbedMDIManager.TabbedGroups["Orders"].AddForm(form);
			return form;
		}


		// User wanted to show a customer form
		private void customerChoices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Verify if a Form exists already...
			Form existingForm = this.customerForms[this.customerChoices.SelectedIndex] as Form;
			// Ensure that the Form is not disposed.
			if(existingForm != null && existingForm.IsDisposed)
			{
				this.customerForms[this.customerChoices.SelectedIndex] = null;
				existingForm = null;
			}
			
			// Create a new form if not already available.
			if(existingForm == null)
				this.customerForms[this.customerChoices.SelectedIndex]
					= this.CreateCustomerInfoForm(this.customerChoices.SelectedItem.ToString());

			Form form = this.customerForms[this.customerChoices.SelectedIndex] as Form;
			form.Activate();
		}


		// User wanted to show a order form
		private void orderChoices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Verify if a Form exists already...
			Form existingForm = this.orderForms[this.orderChoices.SelectedIndex] as Form;
			// Ensure that the Form is not disposed.
			if(existingForm != null && existingForm.IsDisposed)
			{
				this.orderForms[this.orderChoices.SelectedIndex] = null;
				existingForm = null;
			}

			// Create a new form if not already available.
			if(existingForm == null)
				this.orderForms[this.orderChoices.SelectedIndex]
					= this.CreateOrderInfoForm(this.orderChoices.SelectedItem.ToString());

			Form form = this.orderForms[this.orderChoices.SelectedIndex] as Form;
			form.Activate();
		}


		// Optionally, you can maximize a tab group when a child form gets activated by the user.
		protected override void OnMdiChildActivate(EventArgs e)
		{
			// Sometimes the tab host might be activated; ignore such cases.
			if(this.ActiveMdiChild != null && !(this.ActiveMdiChild is TabHost))
			{
				// Get the corresponding tab host.
				TabHost tabHost = this.tabbedMDIManager.GetTabHostFromForm(this.ActiveMdiChild);
				// If the group is "minimized" (weight 0) then,
				// make the group containing this Form occupy the maximum area.
				if(tabHost.MdiChildAutoScaleBaseDim == 0)
					this.tabbedMDIManager.MaximizeTabGroup(tabHost);
			}
			base.OnMdiChildActivate(e);
		}


		// Set custom weights for tab groups:
		private void custWeights_Click(object sender, System.EventArgs e)
		{
			this.tabbedMDIManager.SetTabGroupWeights();
		}


		private void tabbedMDIManager_TabControlAdded(object sender, TabbedMDITabControlEventArgs args)
		{
			args.TabControl.TabStyle = typeof(TabRendererOffice2007);
			args.TabControl.ThemesEnabled = true;
			args.TabControl.TabPanelBackColor = Color.White;
			args.TabControl.TabGap =10;
		}

		
		private void tabbedMDIManager_BeforeDropDownPopup(object sender, DropDownPopupEventArgs e)
		{
			e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
		}	
	}
}
