﻿#region Copyright Syncfusion Inc. 2001 - 2011
//
//  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Diagram;

namespace ControlsGalore
{
	/// <summary>
	/// Sample application form.
	/// </summary>
	public class Form1: DemoForm
	{
        #region Form controls

        private OpenFileDialog openDiagramDialog;
        private SaveFileDialog saveDiagramDialog;
        private DemoCommon.Diagram.TitlePanel panel1;
        private Panel panel3;
        private PropertyEditor propertyEditor1;
        private Panel panel4;
        private Diagram diagram1;
        private Model model1;
        private Panel panel2;
        private PaletteGroupBar paletteGroupBar1;
        private System.ComponentModel.IContainer components;
        #endregion
		
        #region Class Initialize/Finalize methods
        /// <summary>
        /// Default Applcation constructor.
        /// </summary>
        public Form1()
        {
            // The Syncfusion.Windows.Forms.Diagram.ControlNode and Syncfusion.Windows.Forms.Diagram.ActivateStyle types 
            // have been moved from the Syncfusion.Diagram.Base to the Syncfusion.Diagram.Windows assembly.
            // The following binding information is required to correctly resolve the ControlNode and ActivateStyle types.
            string controlnodebinding = "Syncfusion.Windows.Forms.Diagram.ControlNodeSyncfusion.Diagram.Base";
            string activatestylebinding = "Syncfusion.Windows.Forms.Diagram.ActivateStyleSyncfusion.Diagram.Base";
            Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder.TypeNamesVsAssembly.Add(
            	controlnodebinding.ToLower(), typeof( Diagram ).Assembly );
            Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder.TypeNamesVsAssembly.Add(
            	activatestylebinding.ToLower(), typeof( Diagram ).Assembly );

            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.diagram1.Model = this.model1;
           
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
            this.openDiagramDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new DemoCommon.Diagram.TitlePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.propertyEditor1 = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDiagramDialog
            // 
            this.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*";
            this.openDiagramDialog.Title = "Open Diagram";
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.FileName = "doc1";
            this.saveDiagramDialog.Filter = "Diagram files|*.edd|All files|*.*";
            this.saveDiagramDialog.Title = "SaveDiagram";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panel1.ControlBox = false;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Form = this;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 70);
            this.panel1.TabIndex = 0;
            this.panel1.TitleText = "Control Galore";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.propertyEditor1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(764, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 423);
            this.panel3.TabIndex = 0;
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Diagram = this.diagram1;
            this.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyEditor1.Location = new System.Drawing.Point(0, 0);
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size(240, 423);
            this.propertyEditor1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paletteGroupBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 423);
            this.panel2.TabIndex = 1;
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.FlatLook = true;
            this.paletteGroupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paletteGroupBar1.ForeColor = System.Drawing.Color.White;
            this.paletteGroupBar1.GroupBarDropDownToolTip = null;
            this.paletteGroupBar1.GroupBarItemHeight = 32;
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.Size = new System.Drawing.Size(200, 423);
            this.paletteGroupBar1.TabIndex = 1;
            this.paletteGroupBar1.Text = "paletteGroupBar1";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.diagram1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(202, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 423);
            this.panel4.TabIndex = 2;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(562, 423);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.Color.White;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 497);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls Galore";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#endregion

        #region MAIN
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.Run(new Form1());
        }

        #endregion

        #region Class Public Methods
        #endregion

        #region File Menu Handlers
        /// <summary>
        /// Open diagram menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void menuItem3_Click(object sender, EventArgs e)
		{
			// Open diagram
			if (this.openDiagramDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.OpenFile(this.openDiagramDialog.FileName);
				this.diagram1.Refresh();
			}
		}

        /// <summary>
        /// Save diagram menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void menuItem6_Click(object sender, EventArgs e)
		{
			// Save diagram
			Diagram docForm = this.diagram1;
			if (docForm != null)
			{
				if (this.saveDiagramDialog.ShowDialog(this) == DialogResult.OK)
				{
					string fileName = this.saveDiagramDialog.FileName;
					FileStream oStream;
			
					try
					{
						oStream = new FileStream(fileName, FileMode.Create);
					}
					catch (Exception ex)
					{
						oStream = null;  // just to be sure
						MessageBox.Show("Error opening " + fileName + " - " + ex.Message);
					}

					if (oStream != null)
					{
						try
						{
							this.diagram1.SaveBinary(oStream);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Serialization error - " + ex.Message);
						}
						finally
						{
							oStream.Close();
						}
					}
				}
			}
		}

        /// <summary>
        /// Exit diagram menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void menuItem5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        /// <summary>
        /// Close diagram menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void menuItem2_Click(object sender, EventArgs e)
		{
			this.diagram1.Controller.Delete();
			this.diagram1.Model.Clear();
			this.diagram1.Refresh();
		}
		#endregion

        #region Links Menu Handlers
        /// <summary>
        /// Create LinkTool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemLink_Click(object sender, EventArgs e)
        {
            this.diagram1.ActivateTool("LineLinkTool");
        }

        /// <summary>
        /// Create OrthogonalLink tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemOrthogonalLink_Click(object sender, EventArgs e)
        {
            this.diagram1.ActivateTool("OrthogonalLinkTool");
        }

        /// <summary>
        /// Create DirectedlineLink tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemDirectedlineLink_Click(object sender, EventArgs e)
        {
            this.diagram1.ActivateTool("DirectedLineLinkTool");
        }

        /// <summary>
        /// Create ArcLink tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemArcLink_Click(object sender, EventArgs e)
        {
            this.diagram1.ActivateTool("SplineTool");
        }

        #endregion

        #region Edit Menu Handlers
        /// <summary>
        /// Copy selection nodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            Diagram diagram = this.diagram1;
            if (diagram != null)
            {
                diagram.Controller.Copy();
            }
        }

        /// <summary>
        /// Cut selection nodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemCut_Click(object sender, EventArgs e)
        {
            Diagram diagram = this.diagram1;
            if ( diagram != null )
            {
                diagram.Controller.Cut();
            }
        }

        /// <summary>
        /// Paste saved nodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            Diagram diagram = this.diagram1;
            if ( diagram != null )
            {
                diagram.Controller.Paste();
            }
        }		

        #endregion

		#region Helper methods
		/// <summary>
		/// Open diagram file in sample.
		/// </summary>
		/// <param name="fileName"></param>
		public void OpenFile( string fileName )
		{
			using( FileStream iStream = new FileStream( fileName, FileMode.OpenOrCreate ) )
			{
				diagram1.LoadBinary( iStream );
			}
		}
		private void LoadDocument()
		{
			InsertTextNode();
			InsertTreeNode();
			InsertButton();			
		}
		private void LoadPalette()
		{
			SymbolPalette pal = new SymbolPalette();
            pal.Name = "ControlNodes";
            ButtonAdv btn = new ButtonAdv();            
			btn.Text = @"Button Node";
            btn.UseVisualStyle = true;
            btn.UseVisualStyleBackColor = true;
            btn.Office2007ColorScheme = Office2007Theme.Blue;
            btn.Appearance = ButtonAppearance.Office2007;
        	
			ControlNode ctrlnode = new ControlNode( btn, new RectangleF( 100, 100, 125, 50 ) );
			ctrlnode.Name = "Button Node";
			pal.AppendChild( ctrlnode );
        	
			TextBox txtBox = new TextBox();
			txtBox.Multiline = true;
            txtBox.Text = "This is text in a TextBox";
        	
			ctrlnode = new ControlNode( txtBox, new RectangleF( 100, 100, 140, 50 ) );
			ctrlnode.Name = "Text Node";
			pal.AppendChild( ctrlnode );

			// ListBox
			ctrlnode = new ListBoxControNode();
			ctrlnode.Name = "ListBox Node";
			pal.AppendChild( ctrlnode );
        	
			paletteGroupBar1.AddPalette( pal );
            paletteGroupBar1.FlatLook = true;
		}		
		private void InsertTextNode()
		{
			TextBox txtBox = new TextBox();
			txtBox.Multiline = true;
			txtBox.Text = "This is text in a TextNode";
        	
			ControlNode ctrlnode = new ControlNode( txtBox, new RectangleF( 100, 30, 140, 50 ) );
            ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough;
			this.diagram1.Model.AppendChild( ctrlnode );
		}
		private void InsertButton()
		{
            ButtonAdv btn = new ButtonAdv();
			btn.Text = "Click to activate me";
            btn.UseVisualStyle = true;
            btn.UseVisualStyleBackColor = true;
            btn.Office2007ColorScheme = Office2007Theme.Blue;
            btn.Appearance = ButtonAppearance.Office2007;
			btn.Click += new EventHandler( btn_Click );
        	
			ControlNode ctrlnode = new ControlNode( btn, new RectangleF( 100, 200, 150, 50 ) );
            ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough;
			this.diagram1.Model.AppendChild( ctrlnode );
		}
		private void InsertTreeNode()
		{
			TreeView ctrlTree = new TreeView();
			ctrlTree.Nodes.AddRange( new TreeNode[]
										{
											new TreeNode( "QuickSolutions", 7, 7, new TreeNode[]
																					{
																						new TreeNode(
																						"Solution 1", 3, 3 ),
																						new TreeNode(
																						"Solution 2", 4, 4 ),
																						new TreeNode(
																						"Trial", 5, 5 ),
																						new TreeNode(
																						"Clerks", 5, 5 ),
																						new TreeNode(
																						"WorkIssue", 6, 6 )
																					} ),
											new TreeNode( "BG Group", 4, 4, new TreeNode[]
																				{
																					new TreeNode(
																					"Office1", 4, 4,
																					new TreeNode[]
																							{
																								new TreeNode(
																								"Clients" )
																							} )
																				} ),
											new TreeNode( "XYZ Org", 8, 8, new TreeNode[]
																			{
																				new TreeNode(
																				"Contacts", 3, 3 ),
																				new TreeNode( "Referrals" )
																			} ),
											new TreeNode( "XYZ Sales", 5, 5 ),
											new TreeNode( "BetaSoft", 7, 7 ),
											new TreeNode( "MicroCorp", 6, 6, new TreeNode[]
																				{
																					new TreeNode(
																					"Sales 1", 6, 6 ),
																					new TreeNode(
																					"Sales 2", 6, 6 ),
																					new TreeNode(
																					"Complaints", 4, 4 )
																				} )
										} );
            	
			ControlNode ctrlnode = new ControlNode( ctrlTree, new RectangleF( 340, 200, 180, 100 ) );
            ctrlnode.ActivateStyle = ActivateStyle.ClickPassThrough;
			this.diagram1.Model.AppendChild( ctrlnode );
		}
		#endregion
		
        #region Class events
        /// <summary>
        /// Load sample pallete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDocument();
            LoadPalette();            
            GroupBarAppearance();
            diagram1.View.SelectionList.Clear();

        }
        /// <summary>
        /// Change's the Appearance of Diagram 
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Office2007ScrollBars = true;
            this.diagram1.View.SelectionList.Clear();

        }

       /// <summary>
       /// Change's Appearance of GroupBar
       /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }

        }
		/// <summary>
        /// Delete selection nodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barItemDelete_Click( object sender, EventArgs e )
        {
            if (this.diagram1 != null)
            {
                this.diagram1.Controller.Delete();			
            }
        }

        /// <summary>
        /// Use the ControlNodeTool to create a ControlNode initialized with a Windows Forms TextBox control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miInsertTextBox_Click( object sender, EventArgs e )
        {
        	InsertTextNode();
        }

		/// <summary>
        /// Use the ControlNodeTool to create a ControlNode that initialized with a Windows Forms Button control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miInsertButton_Click_2( object sender, EventArgs e )
        {
			InsertButton();
        }
		/// <summary>
        /// Show control button action on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click( object sender, EventArgs e )
        {
            MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
            MessageBoxAdv.Show( "I am all wired up!", "Controls Galore", MessageBoxButtons.OK,MessageBoxIcon.Information );
        }		
		#endregion
       
    }
}
