namespace SubGraphLayout
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
            this.panel1 = new DemoCommon.Diagram.TitlePanel();
            this.panel2 = new DemoCommon.Diagram.Expander();
            this.label2 = new System.Windows.Forms.Label();
            this.lMarigin = new System.Windows.Forms.Label();
            this.comboLytDirection = new System.Windows.Forms.ComboBox();
            this.vSpacing = new System.Windows.Forms.Label();
            this.txtVSpacing = new System.Windows.Forms.TextBox();
            this.hSpacing = new System.Windows.Forms.Label();
            this.txtHSpacing = new System.Windows.Forms.TextBox();
            this.tMarigin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.txtLMarigin = new System.Windows.Forms.TextBox();
            this.chkAutoLayout = new System.Windows.Forms.CheckBox();
            this.txtTMarigin = new System.Windows.Forms.TextBox();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.model2 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panel1.ControlBox = false;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Form = this;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 86);
            this.panel1.TabIndex = 0;
            this.panel1.TitleText = "SubGraph Tree Layout";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel2.Caption = "Properties";
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lMarigin);
            this.panel2.Controls.Add(this.comboLytDirection);
            this.panel2.Controls.Add(this.vSpacing);
            this.panel2.Controls.Add(this.txtVSpacing);
            this.panel2.Controls.Add(this.hSpacing);
            this.panel2.Controls.Add(this.txtHSpacing);
            this.panel2.Controls.Add(this.tMarigin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.apply);
            this.panel2.Controls.Add(this.txtLMarigin);
            this.panel2.Controls.Add(this.chkAutoLayout);
            this.panel2.Controls.Add(this.txtTMarigin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1195, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel2.Size = new System.Drawing.Size(351, 538);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Direction Selection";
            // 
            // lMarigin
            // 
            this.lMarigin.AutoSize = true;
            this.lMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarigin.Location = new System.Drawing.Point(17, 160);
            this.lMarigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMarigin.Name = "lMarigin";
            this.lMarigin.Size = new System.Drawing.Size(89, 20);
            this.lMarigin.TabIndex = 23;
            this.lMarigin.Text = "Left Marigin";
            // 
            // comboLytDirection
            // 
            this.comboLytDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLytDirection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLytDirection.FormattingEnabled = true;
            this.comboLytDirection.Items.AddRange(new object[] {
            "TopToBottom",
            "TopRight",
            "TopLeft",
            "RightToLeft",
            "LeftToRight",
            "BottomToTop",
            "BottomLeft",
            "BottomRight"});
            this.comboLytDirection.Location = new System.Drawing.Point(200, 305);
            this.comboLytDirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboLytDirection.Name = "comboLytDirection";
            this.comboLytDirection.Size = new System.Drawing.Size(132, 28);
            this.comboLytDirection.TabIndex = 39;
            // 
            // vSpacing
            // 
            this.vSpacing.AutoSize = true;
            this.vSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSpacing.Location = new System.Drawing.Point(17, 111);
            this.vSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vSpacing.Name = "vSpacing";
            this.vSpacing.Size = new System.Drawing.Size(116, 20);
            this.vSpacing.TabIndex = 20;
            this.vSpacing.Text = "Vertical Spacing";
            // 
            // txtVSpacing
            // 
            this.txtVSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVSpacing.Location = new System.Drawing.Point(200, 108);
            this.txtVSpacing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVSpacing.Name = "txtVSpacing";
            this.txtVSpacing.Size = new System.Drawing.Size(132, 27);
            this.txtVSpacing.TabIndex = 22;
            // 
            // hSpacing
            // 
            this.hSpacing.AutoSize = true;
            this.hSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSpacing.Location = new System.Drawing.Point(17, 62);
            this.hSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hSpacing.Name = "hSpacing";
            this.hSpacing.Size = new System.Drawing.Size(136, 20);
            this.hSpacing.TabIndex = 19;
            this.hSpacing.Text = "Horizontal Spacing";
            // 
            // txtHSpacing
            // 
            this.txtHSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSpacing.Location = new System.Drawing.Point(200, 59);
            this.txtHSpacing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSpacing.Name = "txtHSpacing";
            this.txtHSpacing.Size = new System.Drawing.Size(132, 27);
            this.txtHSpacing.TabIndex = 21;
            // 
            // tMarigin
            // 
            this.tMarigin.AutoSize = true;
            this.tMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarigin.Location = new System.Drawing.Point(17, 209);
            this.tMarigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tMarigin.Name = "tMarigin";
            this.tMarigin.Size = new System.Drawing.Size(90, 20);
            this.tMarigin.TabIndex = 24;
            this.tMarigin.Text = "Top Marigin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Auto Layout";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(121, 357);
            this.apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(107, 37);
            this.apply.TabIndex = 33;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // txtLMarigin
            // 
            this.txtLMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMarigin.Location = new System.Drawing.Point(200, 158);
            this.txtLMarigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLMarigin.Name = "txtLMarigin";
            this.txtLMarigin.Size = new System.Drawing.Size(132, 27);
            this.txtLMarigin.TabIndex = 25;
            // 
            // chkAutoLayout
            // 
            this.chkAutoLayout.FlatAppearance.BorderSize = 0;
            this.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoLayout.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLayout.Location = new System.Drawing.Point(200, 244);
            this.chkAutoLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAutoLayout.Name = "chkAutoLayout";
            this.chkAutoLayout.Size = new System.Drawing.Size(19, 36);
            this.chkAutoLayout.TabIndex = 27;
            this.chkAutoLayout.UseVisualStyleBackColor = true;
            // 
            // txtTMarigin
            // 
            this.txtTMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMarigin.Location = new System.Drawing.Point(200, 207);
            this.txtTMarigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTMarigin.Name = "txtTMarigin";
            this.txtTMarigin.Size = new System.Drawing.Size(132, 27);
            this.txtTMarigin.TabIndex = 26;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(3, 88);
            this.diagram1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(1192, 538);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
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
            this.diagram1.VScroll = true;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 1200F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(1200F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // model2
            // 
            this.model2.BackgroundStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model2.DocumentScale.DisplayName = "No Scale";
            this.model2.DocumentScale.Height = 1F;
            this.model2.DocumentScale.Width = 1F;
            this.model2.DocumentSize.Height = 1169F;
            this.model2.DocumentSize.Width = 827F;
            this.model2.LineStyle.DashPattern = null;
            this.model2.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model2.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 628);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Graph Layout";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DemoCommon.Diagram.TitlePanel panel1;
        private DemoCommon.Diagram.Expander panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.TextBox txtVSpacing;
        private System.Windows.Forms.Label lMarigin;
        private System.Windows.Forms.TextBox txtHSpacing;
        private System.Windows.Forms.Label vSpacing;
        private System.Windows.Forms.Label hSpacing;
        private System.Windows.Forms.Label tMarigin;
        private System.Windows.Forms.TextBox txtLMarigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTMarigin;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.CheckBox chkAutoLayout;
        private Syncfusion.Windows.Forms.Diagram.Model model2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLytDirection;

    }
}

