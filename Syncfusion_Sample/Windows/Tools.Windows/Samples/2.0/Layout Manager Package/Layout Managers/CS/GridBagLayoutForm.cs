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
	using Syncfusion.Windows.Forms.Tools;


	/// <summary>
	/// Summary description for GridBagLayoutForm.
	/// </summary>
	public class GridBagLayoutForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private	ConstraintsContainer selected;
		private System.Windows.Forms.Button button2;
		private Syncfusion.Windows.Forms.Tools.GridBagLayout gridBagLayout1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		public GridBagLayoutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.selected = new ConstraintsContainer();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GridBagLayoutForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.gridBagLayout1 = new Syncfusion.Windows.Forms.Tools.GridBagLayout(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1,
																				 this.button6,
																				 this.button5,
																				 this.button4,
																				 this.button3,
																				 this.button1,
																				 this.button2,
																				 this.button7});
			this.panel1.Location = new System.Drawing.Point(-8, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(304, 300);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridBagLayout1.SetConstraints(this.label1, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(-1, -1, 1, 1, 0, 0, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.None, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, true));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "This Heading Label doesn\'t participate in Layout:";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button6, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 3, 1, 1, 0.60000002384185791, 0.10000000149011612, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Black;
			this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button6.Location = new System.Drawing.Point(59, 213);
			this.gridBagLayout1.SetMinimumSize(this.button6, new System.Drawing.Size(0, 0));
			this.button6.Name = "button6";
			this.gridBagLayout1.SetPreferredSize(this.button6, new System.Drawing.Size(0, 0));
			this.button6.Size = new System.Drawing.Size(184, 27);
			this.button6.TabIndex = 5;
			this.button6.Text = "Span (1, 1), Pos (1, 3)";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button5, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 2, 1, 1, 0.60000002384185791, 0.40000000596046448, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(10, 10, 10, 10), 0, 0, false));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button5.Location = new System.Drawing.Point(69, 95);
			this.gridBagLayout1.SetMinimumSize(this.button5, new System.Drawing.Size(0, 0));
			this.button5.Name = "button5";
			this.gridBagLayout1.SetPreferredSize(this.button5, new System.Drawing.Size(0, 0));
			this.button5.Size = new System.Drawing.Size(164, 108);
			this.button5.TabIndex = 4;
			this.button5.Text = "Span (1, 1), Pos (1, 2)";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button4, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(2, 1, 1, 3, 0.20000000298023224, 0.60000002384185791, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new System.Drawing.Point(243, 58);
			this.gridBagLayout1.SetMinimumSize(this.button4, new System.Drawing.Size(0, 0));
			this.button4.Name = "button4";
			this.gridBagLayout1.SetPreferredSize(this.button4, new System.Drawing.Size(0, 0));
			this.button4.Size = new System.Drawing.Size(54, 182);
			this.button4.TabIndex = 3;
			this.button4.Text = "Span (1, 3), Pos (2, 1)";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button3, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 1, 1, 1, 0.60000002384185791, 0.10000000149011612, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button3.Location = new System.Drawing.Point(59, 58);
			this.gridBagLayout1.SetMinimumSize(this.button3, new System.Drawing.Size(0, 0));
			this.button3.Name = "button3";
			this.gridBagLayout1.SetPreferredSize(this.button3, new System.Drawing.Size(0, 0));
			this.button3.Size = new System.Drawing.Size(184, 27);
			this.button3.TabIndex = 2;
			this.button3.Text = "Span (1, 1), Pos (1, 1)";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button1, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 0, 3, 1, 1, 0.20000000298023224, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new System.Drawing.Point(5, 5);
			this.gridBagLayout1.SetMinimumSize(this.button1, new System.Drawing.Size(0, 0));
			this.button1.Name = "button1";
			this.gridBagLayout1.SetPreferredSize(this.button1, new System.Drawing.Size(0, 0));
			this.button1.Size = new System.Drawing.Size(292, 53);
			this.button1.TabIndex = 0;
			this.button1.Text = "Span (3 , 1), Pos (0, 0)";
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button2, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 1, 1, 3, 0.20000000298023224, 0.60000002384185791, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new System.Drawing.Point(5, 58);
			this.gridBagLayout1.SetMinimumSize(this.button2, new System.Drawing.Size(0, 0));
			this.button2.Name = "button2";
			this.gridBagLayout1.SetPreferredSize(this.button2, new System.Drawing.Size(0, 0));
			this.button2.Size = new System.Drawing.Size(54, 182);
			this.button2.TabIndex = 1;
			this.button2.Text = "Span (1, 3), Pos (0, 1)";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.gridBagLayout1.SetConstraints(this.button7, new Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 4, 3, 1, 1, 0.20000000298023224, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, new Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, false));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button7.Location = new System.Drawing.Point(5, 240);
			this.gridBagLayout1.SetMinimumSize(this.button7, new System.Drawing.Size(0, 0));
			this.button7.Name = "button7";
			this.gridBagLayout1.SetPreferredSize(this.button7, new System.Drawing.Size(0, 0));
			this.button7.Size = new System.Drawing.Size(292, 53);
			this.button7.TabIndex = 6;
			this.button7.Text = "Span (3 , 1), Pos (0, 4)";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.DropDownWidth = 176;
			this.comboBox1.ItemHeight = 13;
			this.comboBox1.Location = new System.Drawing.Point(296, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(184, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.propertyGrid1.BackColor = System.Drawing.SystemColors.Control;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(296, 16);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(184, 288);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Constraints_Changed);
			// 
			// gridBagLayout1
			// 
			this.gridBagLayout1.BottomMargin = 4;
			this.gridBagLayout1.ContainerControl = this.panel1;
			this.gridBagLayout1.HorzFarMargin = 4;
			this.gridBagLayout1.HorzNearMargin = 4;
			this.gridBagLayout1.TopMargin = 4;
			// 
			// GridBagLayoutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(480, 302);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboBox1,
																		  this.propertyGrid1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GridBagLayoutForm";
			this.Text = "GridBagLayout";
			this.Load += new System.EventHandler(this.GridBagLayoutForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		// Optionally, you can provide preferred sizes based on the control's text.
		//		private void gridBagLayout1_ProvideLayoutInformation(object sender, ProvideLayoutInformationEventArgs args)
		//		{
		//			if(args.Requested == LayoutInformationType.PreferredSize)
		//			{
		//				// Get the preferred and minimum sizes based on the Control's text
		//				Graphics g = args.Control.CreateGraphics();
		//				SizeF sizeF = g.MeasureString(args.Control.Text, args.Control.Font);
		//				sizeF += new SizeF(10, 4);
		//				args.Size = Size.Ceiling(sizeF);
		//				args.Handled = true;
		//			}
		//		}

		#region PROPERTYGRID_SETTINGS
		private void GridBagLayoutForm_Load(object sender, System.EventArgs e)
		{
			// Initialization for showing the associated constraints in the property grid.
			foreach(Control control in this.panel1.Controls)
				this.comboBox1.Items.Add(control);
			
			this.comboBox1.DisplayMember = "Text";
			this.comboBox1.SelectedIndex = 0;

			//			foreach(Control control in this.panel1.Controls)
			//				if(control is Button)
			//					this.SetButtonText(control);

			// Sample Code Block to illustrate initialization without designer.
			// Adds 2 components to the gridBagLayout.
			//if(false)
			{
				// <samplecodeblock name="Initializing GridBagLayout">
				// Binding a Control to the GridBagLayout manager programaitcally
//				this.gridBagLayout1 = new GridBagLayout();
//	
//				// Set the container control; all the child controls of this container control are
//				// automatically registered as children with the manager.
//				this.gridBagLayout1.ContainerControl = this.panel1;
//
//				this.gridBagLayout1.SetConstraints(
//					this.button1, 
//					new GridBagConstraints(0, 0, 3, 1, 1, 0.2, AnchorTypes.Center, FillType.Both, new Insets(0, 0, 0, 0), 0, 0, false)
//					);
//				this.gridBagLayout1.SetConstraints(
//					this.button2, 
//					new GridBagConstraints(0, 1, 1, 3, 0.2, 0.6, AnchorTypes.Center, FillType.Both, new Insets(0, 0, 0, 0), 0, 0, false)
//					);
//
//				// Exclude button3 from layout
//				this.gridBagLayout1.SetConstraints(this.button3, GridBagConstraints.Empty);
//		
//				// Modify an exisiting constraint.
//				GridBagConstraints constraints1 = this.gridBagLayout1.GetConstraintsRef(this.button1);
//				constraints1.Fill = FillType.Horizontal;

				// You can prevent automatic layout during the layout event:
				// If you decide to do so, make sure to call gridBagLayout1.LayoutContainer manually.
				// this.gridBagLayout1.AutoLayout = false;
				// </samplecodeblock>
			}
		}

		private void SetButtonText(Control component)
		{
			GridBagConstraints gbc = this.gridBagLayout1.GetConstraints(component);
			component.Text = TypeDescriptor.GetConverter(typeof(GridBagConstraints)).ConvertTo(gbc, typeof(string)) as string;
		}

		// 
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.selected.GridBagConstraints = this.gridBagLayout1.GetConstraintsRef(this.comboBox1.SelectedItem as Control);

			this.propertyGrid1.SelectedObject = this.selected;
			this.propertyGrid1.ExpandAllGridItems();
		}
		private void Constraints_Changed(object sender, PropertyValueChangedEventArgs e)
		{
			this.gridBagLayout1.SetConstraints(
				this.comboBox1.SelectedItem as Control,
				this.selected.GridBagConstraints);
		}

		public class ConstraintsContainer : Component
		{
			private GridBagConstraints _gridBagConstraints;
			public GridBagConstraints GridBagConstraints
			{
				get{return this._gridBagConstraints;}
				set{this._gridBagConstraints = value;}
			}
		}
		#endregion PROPERTYGRID_SETTINGS
	}
}
