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
        private Expander panel3;
        private Diagram diagram1;
        private Model model1;
        private Panel panel4;
        private System.Windows.Forms.Label label17;
        private ColorPickerButton colorPickerButton2;
        private ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.IContainer components;
        #endregion
		
        #region Class Initialize/Finalize methods
        /// <summary>
        /// Default Applcation constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Application.EnableVisualStyles();            
            this.diagram1.Model = this.model1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.diagram1.View.CustomHandleRenderer = new CustomStyle1HandleRenderer();           
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
            this.panel3 = new DemoCommon.Diagram.Expander();
            this.label17 = new System.Windows.Forms.Label();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label2 = new System.Windows.Forms.Label();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 0;
            this.panel1.TitleText = "Custom Selection Handle";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel3.Caption = "Properties";
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.colorPickerButton2);
            this.panel3.Controls.Add(this.colorPickerButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(601, 72);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(200, 474);
            this.panel3.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 18);
            this.label17.TabIndex = 170;
            this.label17.Text = "Handle Color";
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.colorPickerButton2.FlatAppearance.BorderSize = 0;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton2.Location = new System.Drawing.Point(158, 36);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.Size = new System.Drawing.Size(25, 20);
            this.colorPickerButton2.TabIndex = 174;
            this.colorPickerButton2.Text = "....";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.colorPickerButton1.FlatAppearance.BorderSize = 0;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton1.Location = new System.Drawing.Point(158, 69);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.Size = new System.Drawing.Size(25, 20);
            this.colorPickerButton1.TabIndex = 171;
            this.colorPickerButton1.Text = "....";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 173;
            this.label2.Text = "Handle Outline Color";
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(599, 474);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.diagram1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 474);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(803, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls Galore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel4.ResumeLayout(false);
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
		
        #region Class events
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.diagram1.LoadBinary(@"..\..\FlowDiagram.edd");
            DiagramAppearance();
            this.colorPickerButton1.BackColor = this.diagram1.View.HandleRenderer.HandleOutlineColor;
            this.colorPickerButton2.BackColor = this.diagram1.View.HandleRenderer.HandleColor;
        }
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.diagram1.View.HandleRenderer.HandleColor = this.colorPickerButton2.SelectedColor;         
            this.diagram1.Refresh();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.diagram1.View.HandleRenderer.HandleOutlineColor = this.colorPickerButton1.SelectedColor;           
            this.diagram1.Refresh();
        }

        /// <summary>
        /// Change's the Appearance of the Diagram 
        /// </summary>
        public void DiagramAppearance()
        {
            diagram1.Model.LineStyle.LineWidth = 0;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.White;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.DocumentSize = new PageSize(600, 500);
        }
		#endregion

        #region CustomHandleRenderer1
        public class CustomStyle1HandleRenderer : UserHandleRenderer
        {

            public override void OnDrawEndPointOutline(Graphics gfx, RectangleF rectHandle, EndPoint endpoint)
            {
                using (Pen pen = new Pen(Color.FromArgb(77, 115, 153), 1f / gfx.PageScale))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Dot;
                    // Create brush to fill PinPoint interiors
                    LinearGradientBrush br = new LinearGradientBrush(rectHandle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                    ColorBlend clrBlend = new ColorBlend(5);
                    clrBlend.Colors = new Color[] { Color.FromArgb(163, 185, 204), Color.FromArgb(243, 255, 255), Color.FromArgb(235, 255, 255), Color.FromArgb(202, 245, 248), Color.FromArgb(202, 245, 248), Color.FromArgb(243, 255, 255), Color.FromArgb(163, 185, 204) };
                    clrBlend.Positions = new float[] { 0f, 0.2f, 0.3f, 0.4f, 0.5f, 0.75f, 1f };
                    br.InterpolationColors = clrBlend;
                    using (Brush brush = br)
                    {
                        // Fill handle interiors
                        gfx.FillRectangle(brush, rectHandle);

                        // Outline handle
                        gfx.DrawRectangle(pen,
                            rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height);
                    }
                }
            }

            public override void OnDrawOutlineRectangle(Graphics gfx, SizeF size)
            {
                using (Pen pen = new Pen(Color.FromArgb(77, 115, 153), 1f / gfx.PageScale))
                {
                    pen.DashStyle = DashStyle.Solid;
                    gfx.DrawRectangle(pen, 0, 0, size.Width, size.Height);
                }
            }

            public override void OnDrawRotationHandleInterior(Graphics gfx, Node node)
            {

                float fPageScale = gfx.PageScale;
                float fHandleSize = CommonUsedValues.ROTATION_HANDLE_SIZE / fPageScale;
                // get node's dimensions in unit independent values
                SizeF szUnitIndependentPinOffset = ((IUnitIndependent)node).GetPinPointOffset(MeasureUnits.Pixel);

                float fRHO = CommonUsedValues.ROTATION_HANDLE_OFFSET / fPageScale;
                float fYOffset = (szUnitIndependentPinOffset.Height < 0) ? szUnitIndependentPinOffset.Height - fRHO : -fRHO;

                PointF ptRotationHandleLocation = new PointF(szUnitIndependentPinOffset.Width, fYOffset);

                // PointF array for transforming.
                PointF[] pts = new PointF[] { ptRotationHandleLocation };

                Matrix matrixTemp = new Matrix();
                // Get parents rotation angle
                matrixTemp.RotateAt(node.RotationAngle, new PointF(szUnitIndependentPinOffset.Width, szUnitIndependentPinOffset.Height), MatrixOrder.Append);

                // Transform points
                matrixTemp.TransformPoints(pts);

                using (Pen pen = new Pen(m_handleOutlineColor))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Solid;
                    pen.Color = Color.FromArgb(77, 115, 153);

                    //Fill Handled Interior
                    RectangleF rect = new RectangleF(0, 0, fHandleSize, fHandleSize);
                    LinearGradientBrush br = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                    ColorBlend clrBlend = new ColorBlend(7);
                    clrBlend.Colors = new Color[] { Color.FromArgb(214, 255, 179), Color.FromArgb(191, 215, 177), Color.FromArgb(167, 255, 92), Color.FromArgb(148, 240, 70), Color.FromArgb(133, 225, 55), Color.FromArgb(167, 255, 92), Color.FromArgb(214, 255, 179) };
                    clrBlend.Positions = new float[] { 0f, 0.25f, 0.45f, 0.55f, 0.75f, 0.8f, 1f };
                    br.InterpolationColors = clrBlend;

                    using (Brush brush = br)
                    {
                        using (GraphicsPath gp = CreateRotationHandleShape(pts[0], new SizeF(fHandleSize, fHandleSize)))
                        {
                            gfx.FillPath(brush, gp);
                            // Outline handle
                            gfx.DrawPath(pen, gp);
                        }
                    }
                }
            }

            public override void OnDrawResizeHandleShape(Graphics gfx, BoxPosition handle, Node node, RectangleF rectHandle)
            {
                using (Pen pen = new Pen(m_handleOutlineColor))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Solid;
                    pen.Color = Color.FromArgb(77, 115, 153);

                    LinearGradientBrush br = new LinearGradientBrush(rectHandle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                    ColorBlend clrBlend = new ColorBlend(5);
                    clrBlend.Colors = new Color[] { Color.FromArgb(163, 185, 204), Color.FromArgb(243, 255, 255), Color.FromArgb(235, 255, 255), Color.FromArgb(202, 245, 248), Color.FromArgb(202, 245, 248), Color.FromArgb(243, 255, 255), Color.FromArgb(163, 185, 204) };
                    clrBlend.Positions = new float[] { 0f, 0.2f, 0.3f, 0.4f, 0.5f, 0.75f, 1f };
                    br.InterpolationColors = clrBlend;

                    // Create brush to fill PinPoint interiors
                    using (Brush brush = br)
                    {
                        using (GraphicsPath gp = PathFactory.CreateEllipse(rectHandle))
                        {
                            gfx.FillPath(brush, gp);
                            // Outline handle
                            gfx.DrawPath(pen, gp);
                        }
                    }
                }
            }
        }
        #endregion

        #region CustomHandleRenderer2
        public class CustomStyle2HandleRenderer : UserHandleRenderer
        {

            public override void OnDrawEndPointOutline(Graphics gfx, RectangleF rectHandle, EndPoint endpoint)
            {
                using (Pen pen = new Pen(Color.Black, 1f / gfx.PageScale))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Dot;

                    using (Brush brush = new SolidBrush(Color.LightGreen))
                    {
                        // Fill handle interiors
                        gfx.FillRectangle(brush, rectHandle);

                        // Outline handle
                        gfx.DrawRectangle(pen,
                            rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height);
                    }
                }
            }

            public override void OnDrawOutlineRectangle(Graphics gfx, SizeF size)
            {
                using (Pen pen = new Pen(Color.Transparent, 1f / gfx.PageScale))
                {
                    pen.DashStyle = DashStyle.Solid;
                    gfx.DrawRectangle(pen, 0, 0, size.Width, size.Height);
                }
            }

            public override void OnDrawRotationHandleInterior(Graphics gfx, Node node)
            {

                float fPageScale = gfx.PageScale;
                float fHandleSize = CommonUsedValues.ROTATION_HANDLE_SIZE / fPageScale;
                // get node's dimensions in unit independent values
                SizeF szUnitIndependentPinOffset = ((IUnitIndependent)node).GetPinPointOffset(MeasureUnits.Pixel);

                float fRHO = CommonUsedValues.ROTATION_HANDLE_OFFSET / fPageScale;
                float fYOffset = (szUnitIndependentPinOffset.Height < 0) ? szUnitIndependentPinOffset.Height - fRHO : -fRHO;

                PointF ptRotationHandleLocation = new PointF(szUnitIndependentPinOffset.Width, fYOffset);

                // PointF array for transforming.
                PointF[] pts = new PointF[] { ptRotationHandleLocation };

                Matrix matrixTemp = new Matrix();
                // Get parents rotation angle
                matrixTemp.RotateAt(node.RotationAngle, new PointF(szUnitIndependentPinOffset.Width, szUnitIndependentPinOffset.Height), MatrixOrder.Append);

                // Transform points
                matrixTemp.TransformPoints(pts);

                using (Pen pen = new Pen(Color.FromArgb(68, 108, 157)))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Solid;

                    using (Brush brush = new SolidBrush(Color.FromArgb(0, 255, 0)))
                    {
                        using (GraphicsPath gp = CreateRotationHandleShape(pts[0], new SizeF(fHandleSize, fHandleSize)))
                        {
                            gfx.FillPath(brush, gp);
                            // Outline handle
                            gfx.DrawPath(pen, gp);
                        }
                    }
                }
            }

            public override void OnDrawResizeHandleShape(Graphics gfx, BoxPosition handle, Node node, RectangleF rectHandle)
            {
                using (Pen pen = new Pen(Color.FromArgb(68, 108, 157)))
                {
                    pen.Width = 1f / gfx.PageScale;
                    pen.DashStyle = DashStyle.Solid;
                    pen.Color = Color.FromArgb(77, 115, 153);

                    // Create brush to fill PinPoint interiors
                    using (Brush brush = new SolidBrush(Color.FromArgb(99, 154, 231)))
                    {
                        using (GraphicsPath gp = PathFactory.CreateEllipse(rectHandle))
                        {
                            gfx.FillPath(brush, gp);
                            // Outline handle
                            gfx.DrawPath(pen, gp);
                        }
                    }
                }
            }
        }
        #endregion

       
       
    }
}
