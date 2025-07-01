using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace GradientPanelExtDemo
{
    public partial class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Declaration
        private Syncfusion.Windows.Forms.Tools.TextPrimitive textPrimitive1;
        private Syncfusion.Windows.Forms.Tools.ImagePrimitive imagePrimitive1;
        
        private Syncfusion.Windows.Forms.Tools.CollapsePrimitive collapsePrimitive1;
        private Syncfusion.Windows.Forms.Tools.HostPrimitive hostPrimitive1;

        #endregion Declaration

        #region Form constructor
        public Form1()
        {
            InitializeComponent();
            this.checkBoxAdv1.Visible = false;
          this.comboBox1.SelectedIndex = 0;
        this.gradientStyleCombo.SelectedIndex = 4;
        this.backcolorEdit.TextBox.BackColor = Color.FromArgb(191, 219, 254);
        this.foreColorEdit.TextBox.BackColor = Color.White;
        this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
          
        }

        #endregion Form constructor

        #region Color Options
        private void backColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
           backcolorEdit.TextBox.BackColor = colorDialog1.Color;
                if (this.gradientStyleCombo.Text == "Vertical")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "Horizontal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "ForwardDiagonal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "BackwardDiagonal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
               
            }
        }

        private void foreColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.foreColorEdit.TextBox.BackColor = colorDialog1.Color;
                if (this.gradientStyleCombo.Text == "Vertical")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "Horizontal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "ForwardDiagonal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else if (this.gradientStyleCombo.Text == "BackwardDiagonal")
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
                else
                    this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);
            }

        }

        private void gradientStyleCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo((Syncfusion.Drawing.GradientStyle)(gradientStyleCombo.SelectedIndex), backcolorEdit.TextBox.BackColor, foreColorEdit.TextBox.BackColor);

        }
        #endregion Color Options
       
        #region Primitives
        
        private void Primitive_Changed(object sender, EventArgs e)
        {
            RadioButtonAdv radioButton = (RadioButtonAdv)sender;

            switch (radioButton.Text)
            {
                case "Text Primitive":
                    AddTextPrimitive();
                    break;

                case "Image Primitive":
                    AddImagePrimitive();
                    break;

                case "Collapse Primitive":
                    AddCollapsePrimitive();
                    break;

                case "Host Primitive":
                    AddHostPrimitive();
                    break;
            }


        }

        private void AddHostPrimitive()
        {
           this.gradientPanelExt1.Primitives.Clear();
           
           this.comboBox1.Enabled = false;
            this.hostPrimitive1 = new Syncfusion.Windows.Forms.Tools.HostPrimitive();
            this.hostPrimitive1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.Visible = true;
                this.hostPrimitive1.HostControl = this.checkBoxAdv1;
                this.hostPrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top;
                this.hostPrimitive1.Size = new Size(100, 20);
                  this.hostPrimitive1.PrimitiveBorderStyle = Syncfusion.Windows.Forms.Tools.PrimitiveBorderStyle.None;
            this.gradientPanelExt1.Primitives.AddRange(new Syncfusion.Windows.Forms.Tools.Primitive[] {
            this.hostPrimitive1});
     }

        private void AddCollapsePrimitive()
        {
            
            this.checkBoxAdv1.Visible = false;
            this.comboBox1.Enabled = true;

            this.gradientPanelExt1.Primitives.Clear();
            this.checkBoxAdv1.Visible = false;
            this.collapsePrimitive1 = new Syncfusion.Windows.Forms.Tools.CollapsePrimitive();
            this.collapsePrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Bottom;
            this.collapsePrimitive1.BackColor = System.Drawing.Color.Transparent;//.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.collapsePrimitive1.Collapsed = false;
            
            this.collapsePrimitive1.BorderColor = Color.Transparent;
            this.collapsePrimitive1.CollapseImage = Image.FromFile(@"..\..\Data\navigate_up2.png");
            this.collapsePrimitive1.ExpandImage = Image.FromFile(@"..\..\Data\navigate_down2.png");
            this.collapsePrimitive1.Size = new System.Drawing.Size(20, 20);
            this.collapsePrimitive1.CollapsedChanged += new EventHandler(collapsePrimitive1_CollapsedChanged);
            this.gradientPanelExt1.Primitives.AddRange(new Syncfusion.Windows.Forms.Tools.Primitive[] {
            this.collapsePrimitive1});
            primitiveAlignment();
        }

        private void collapsePrimitive1_CollapsedChanged(object sender, EventArgs e)
        {
            if (!this.gradientPanelExt1.Collapsed)
                this.checkBoxAdv1.Visible = false;

        }
        private void AddImagePrimitive()
        {
          
         
            this.checkBoxAdv1.Visible = false;
            this.comboBox1.Enabled = true;
            this.gradientPanelExt1.Primitives.Clear();
            this.checkBoxAdv1.Visible = false;
            this.imagePrimitive1 = new Syncfusion.Windows.Forms.Tools.ImagePrimitive();
            this.imagePrimitive1.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top;
            this.imagePrimitive1.Image = Image.FromFile(@"..\..\Data\about.png");
            this.imagePrimitive1.PrimitiveBorderStyle = Syncfusion.Windows.Forms.Tools.PrimitiveBorderStyle.None;
            this.imagePrimitive1.Size = new System.Drawing.Size(30, 30);
             this.gradientPanelExt1.Primitives.AddRange(new Syncfusion.Windows.Forms.Tools.Primitive[] {
             this.imagePrimitive1});
             primitiveAlignment();

        }

        private void AddTextPrimitive()
        {
         
            this.checkBoxAdv1.Visible = false;
            this.comboBox1.Enabled = true;
            this.gradientPanelExt1.Primitives.Clear();
            this.checkBoxAdv1.Visible = false;
            this.textPrimitive1 = new Syncfusion.Windows.Forms.Tools.TextPrimitive();
            this.textPrimitive1.TextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrimitive1.TextColor = System.Drawing.Color.MidnightBlue;
            this.textPrimitive1.BackColor = System.Drawing.Color.Transparent;//.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textPrimitive1.Size = new System.Drawing.Size(90, 30);
            this.textPrimitive1.Text = "Text Primitive";
            this.textPrimitive1.BorderColor = Color.FromArgb(44, 137, 252);
             this.gradientPanelExt1.Primitives.AddRange(new Syncfusion.Windows.Forms.Tools.Primitive[] {
             this.textPrimitive1});
            primitiveAlignment();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddHostPrimitive();
        }

        
        #endregion Primitives

        #region Properties
        private void borderGapUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.gradientPanelExt1.BorderGap = Convert.ToInt32(this.borderGapUpDown.Value);
        }

        private void cornerRadiusUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.gradientPanelExt1.CornerRadius = Convert.ToInt32(this.cornerRadiusUpDown.Value);
        }

        #endregion Properties

        #region primitiveAlignment
    public void primitiveAlignment()
        {
            foreach (Primitive pm in this.gradientPanelExt1.Primitives)
            {
                if (this.comboBox1.SelectedIndex == 0)
                {
                    pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Top;
                }
                if (this.comboBox1.SelectedIndex == 1)
                {
                    pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Bottom;
                }
                if (this.comboBox1.SelectedIndex == 2)
                {
                    pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Left;
                }
                if (this.comboBox1.SelectedIndex == 3)
                {
                    pm.Alignment = Syncfusion.Windows.Forms.Tools.Alignment.Right;
                }
            }
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            primitiveAlignment();
        }
    #endregion

       
     
    }
}