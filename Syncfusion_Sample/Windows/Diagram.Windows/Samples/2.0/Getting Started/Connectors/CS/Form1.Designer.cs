namespace ConnectorsDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.directLnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.orthoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.polyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bezierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyEditor1 = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 76);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripButton,
            this.directLnToolStripButton,
            this.orthoToolStripButton,
            this.polyToolStripButton,
            this.splineToolStripButton,
            this.bezierToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1029, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lineToolStripButton
            // 
            this.lineToolStripButton.AutoSize = false;
            this.lineToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.lineToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lineToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripButton.Image")));
            this.lineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripButton.Name = "lineToolStripButton";
            this.lineToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lineToolStripButton.Size = new System.Drawing.Size(110, 60);
            this.lineToolStripButton.Text = "LineLinkTool";
            this.lineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.lineToolStripButton.ToolTipText = "LineLinkTool";
            this.lineToolStripButton.Click += new System.EventHandler(this.lineToolStripButton_Click);
            // 
            // directLnToolStripButton
            // 
            this.directLnToolStripButton.AutoSize = false;
            this.directLnToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.directLnToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directLnToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("directLnToolStripButton.Image")));
            this.directLnToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.directLnToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.directLnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.directLnToolStripButton.Name = "directLnToolStripButton";
            this.directLnToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.directLnToolStripButton.Size = new System.Drawing.Size(150, 60);
            this.directLnToolStripButton.Text = "DirectedLineLinkTool";
            this.directLnToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.directLnToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.directLnToolStripButton.ToolTipText = "DirectedLineLinkTool";
            this.directLnToolStripButton.Click += new System.EventHandler(this.directLnToolStripButton_Click);
            // 
            // orthoToolStripButton
            // 
            this.orthoToolStripButton.AutoSize = false;
            this.orthoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.orthoToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orthoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("orthoToolStripButton.Image")));
            this.orthoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orthoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orthoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.orthoToolStripButton.Name = "orthoToolStripButton";
            this.orthoToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.orthoToolStripButton.Size = new System.Drawing.Size(150, 60);
            this.orthoToolStripButton.Text = "OrthogonalLinkTool";
            this.orthoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orthoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.orthoToolStripButton.ToolTipText = "OrthogonalLinkTool";
            this.orthoToolStripButton.Click += new System.EventHandler(this.orthoToolStripButton_Click);
            // 
            // polyToolStripButton
            // 
            this.polyToolStripButton.AutoSize = false;
            this.polyToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("polyToolStripButton.Image")));
            this.polyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.polyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.polyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polyToolStripButton.Name = "polyToolStripButton";
            this.polyToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.polyToolStripButton.Size = new System.Drawing.Size(120, 60);
            this.polyToolStripButton.Text = "PolyLineLinkTool";
            this.polyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.polyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.polyToolStripButton.ToolTipText = "PolyLineLinkTool";
            this.polyToolStripButton.Click += new System.EventHandler(this.polyToolStripButton_Click);
            // 
            // splineToolStripButton
            // 
            this.splineToolStripButton.AutoSize = false;
            this.splineToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("splineToolStripButton.Image")));
            this.splineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.splineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.splineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splineToolStripButton.Name = "splineToolStripButton";
            this.splineToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.splineToolStripButton.Size = new System.Drawing.Size(90, 60);
            this.splineToolStripButton.Text = "SplineTool";
            this.splineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.splineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.splineToolStripButton.Click += new System.EventHandler(this.splineToolStripButton_Click);
            // 
            // bezierToolStripButton
            // 
            this.bezierToolStripButton.AutoSize = false;
            this.bezierToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bezierToolStripButton.Image")));
            this.bezierToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bezierToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bezierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bezierToolStripButton.Name = "bezierToolStripButton";
            this.bezierToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.bezierToolStripButton.Size = new System.Drawing.Size(90, 60);
            this.bezierToolStripButton.Text = "BezierTool";
            this.bezierToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bezierToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bezierToolStripButton.Click += new System.EventHandler(this.bezierToolStripButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.propertyEditor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(682, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 691);
            this.panel2.TabIndex = 1;
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Diagram = this.diagram1;
            this.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyEditor1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyEditor1.Location = new System.Drawing.Point(0, 0);
            this.propertyEditor1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size(347, 691);
            this.propertyEditor1.TabIndex = 0;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Margin = new System.Windows.Forms.Padding(4);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(682, 691);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 900F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(900F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diagram1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 691);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 767);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connectors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton orthoToolStripButton;
        private System.Windows.Forms.ToolStripButton lineToolStripButton;
        private System.Windows.Forms.ToolStripButton directLnToolStripButton;
        private System.Windows.Forms.ToolStripButton polyToolStripButton;
        private System.Windows.Forms.ToolStripButton splineToolStripButton;
        private System.Windows.Forms.ToolStripButton bezierToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor propertyEditor1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
    }
}

