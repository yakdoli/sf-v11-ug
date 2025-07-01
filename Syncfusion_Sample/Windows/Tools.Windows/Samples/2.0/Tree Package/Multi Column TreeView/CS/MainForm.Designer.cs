namespace MultiColumnTreeViewDemo
{
    partial class MainForm
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
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.multiColumnTreeView1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiColumnTreeView1
            // 
            this.multiColumnTreeView1.AddSeparatorAtEnd = true;
            this.multiColumnTreeView1.AutoAdjustMultiLineHeight = true;
            this.multiColumnTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", treeNodeAdvSubItemStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", treeNodeAdvStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", treeColumnAdvStyleInfo2)});
            this.multiColumnTreeView1.ColumnsHeaderBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            this.multiColumnTreeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.multiColumnTreeView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.multiColumnTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.HelpTextControl.Name = "m_helpText";
            this.multiColumnTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.multiColumnTreeView1.HelpTextControl.TabIndex = 0;
            this.multiColumnTreeView1.HelpTextControl.Text = "help text";
            this.multiColumnTreeView1.LabelEdit = true;
            this.multiColumnTreeView1.LoadOnDemand = true;
            this.multiColumnTreeView1.Location = new System.Drawing.Point(0, 52);
            this.multiColumnTreeView1.Name = "multiColumnTreeView1";
            this.multiColumnTreeView1.OwnerDrawNodes = true;
            this.multiColumnTreeView1.Size = new System.Drawing.Size(759, 500);
            this.multiColumnTreeView1.StateImageList = this.imageList1;
            this.multiColumnTreeView1.TabIndex = 0;
            this.multiColumnTreeView1.Text = "MultiColumnTreeViewDemo.csmultiColumnTreeView1";
            // 
            // 
            // 
            this.multiColumnTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.multiColumnTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.ToolTipControl.Name = "m_toolTip";
            this.multiColumnTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.multiColumnTreeView1.ToolTipControl.TabIndex = 1;
            this.multiColumnTreeView1.ToolTipControl.Text = "toolTip";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.ico");
            this.imageList1.Images.SetKeyName(1, "folder.ico");
            this.imageList1.Images.SetKeyName(2, "folder.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorPickerButton3);
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 52);
            this.panel1.TabIndex = 1;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Location = new System.Drawing.Point(40, 12);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.Size = new System.Drawing.Size(212, 23);
            this.colorPickerButton3.TabIndex = 3;
            this.colorPickerButton3.Text = "Header 1 Hightlight Border Color";
            this.colorPickerButton3.UseVisualStyleBackColor = true;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Location = new System.Drawing.Point(295, 12);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorPickerButton2.Size = new System.Drawing.Size(201, 23);
            this.colorPickerButton2.TabIndex = 2;
            this.colorPickerButton2.Text = "Header 2 HighLight Border Color";
            this.colorPickerButton2.UseVisualStyleBackColor = true;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Location = new System.Drawing.Point(557, 12);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.Size = new System.Drawing.Size(190, 23);
            this.colorPickerButton1.TabIndex = 0;
            this.colorPickerButton1.Text = "Header 3 Hightlight Border Color";
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.multiColumnTreeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Multi Column TreeView";
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView multiColumnTreeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
    }
}