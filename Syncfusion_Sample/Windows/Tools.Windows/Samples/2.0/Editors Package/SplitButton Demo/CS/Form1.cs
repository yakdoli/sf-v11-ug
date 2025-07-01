using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SplitButtonDemo
{
       
    public partial class Form1 : Office2007Form
    {
        public Color startcolor = Color.LightGreen;
        public Color endcolor = Color.Green ;
           
        public Form1()
        {
            InitializeComponent();
            CustomRenderer renderer = new CustomRenderer();
            renderer.SplitButton = splitButton2;
            splitButton2.Renderer = renderer;
            this.splitButton1.DropDownItems.Add("Item1");
            this.splitButton1.DropDownItems.Add("Item2");
            this.splitButton1.DropDownItems.Add("Item3");
            this.splitButton1.DropDownItems.Add("Item4");
            this.splitButton1.DropDownItems.Add("Item5");
            Image img = Image.FromFile(@"../../logo_16.ico");
            this.splitButton2.DropDownItems.Add("Item1", img );
            this.splitButton2.DropDownItems.Add("Item2", img);
            this.splitButton2.DropDownItems.Add("Item3", img);
            this.splitButton2.DropDownItems.Add("Item4", img);
            this.splitButton2.DropDownItems.Add("Item5", img);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Toggle;
                textBox1.Text = "SplitButton Turns ToogleMode\r\n" + textBox1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal;
                textBox1.Text = "SplitButton Turns NormalMode\r\n" + textBox1.Text;
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (buttonAdv1.Text == "Remove Items")
            {
                this.splitButton1.DropDownItems.Clear();
                textBox1.Text = "DropDownItems Removed\r\n" + textBox1.Text;
                buttonAdv1.Text = "Add Items";
            }
            else
            {
                this.splitButton1.DropDownItems.Add("Item1");
                this.splitButton1.DropDownItems.Add("Item2");
                this.splitButton1.DropDownItems.Add("Item3");
                this.splitButton1.DropDownItems.Add("Item4");
                this.splitButton1.DropDownItems.Add("Item5");
                textBox1.Text = "DropDownItems Added\r\n" + textBox1.Text;
                buttonAdv1.Text = "Remove Items";
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.splitButton1.IsButtonChecked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.splitButton1.IsButtonChecked = false;
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
      
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.splitButton1.IsButtonChecked = true;
            this.splitButton1.Invalidate();
        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Clicked\r\n" + textBox1.Text;
        }

        private void splitButton1_Checked(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Checked\r\n" + textBox1.Text;
        }

        private void splitButton1_UnChecked(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Unchecked\r\n" + textBox1.Text;
        }

        private void splitButton1_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             textBox1.Text = e.ClickedItem.Text + " is Clicked\r\n" + textBox1.Text;
        }




        public class CustomRenderer : ISplitButtonRenderer
        {
            private SplitButton splitButton;

            #region ISplitButtonRenderer Members

          

            public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
            {

                SolidBrush brush = new SolidBrush(color);
                StringFormat format = new StringFormat();
                format.Trimming = StringTrimming.EllipsisCharacter;
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;
                Rectangle textArea = new Rectangle(7, 1, totalwidth - splitwidth, totalheight);
                e.Graphics.DrawString(text, font, brush, textArea, format);

                Rectangle imageRect = new Rectangle(4, 11, 15, totalheight - 24);
                Image img = Image.FromFile(@"../../logo_16.ico");
                e.Graphics.DrawImage(img, imageRect);
                brush.Dispose();
            }

            public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
            {
                // Can Customize the Border Color of the SplitButton 
                // Outer Color is Changed 
                Form1 frm = new Form1();
                Color color1 = frm.startcolor;
                Color color2 = frm.endcolor;
                Brush linearGradientBrush = new LinearGradientBrush(
                              new Rectangle(0, 0, width, height), color1, color2, 90);
                e.Graphics.FillRectangle(linearGradientBrush, new Rectangle(0, 0, width, height));
                linearGradientBrush.Dispose();
                Pen outercolor = new Pen(Color.DarkGreen );
                Pen innercolor = new Pen(Color.LightGreen );
                Pen arrowinner = new Pen(Color.LightGreen);
                Pen arrowouter = new Pen(arrowOuter);
                Pen buttoninner = new Pen(buttonInner);

                e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(width - 2, 1));
                e.Graphics.DrawLine(innercolor, new Point(width - 2, 1), new Point(width - 2, height - 2));
                e.Graphics.DrawLine(innercolor, new Point(1, height - 2), new Point(width - 2, height - 2));
                e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(1, height - 2));

                e.Graphics.DrawLine(arrowouter, new Point(width - splitwidth, 0), new Point(width - splitwidth, height - 1));

                e.Graphics.DrawLine(buttoninner, new Point(width - splitwidth - 1, 2), new Point(width - splitwidth - 1, height - 3));

                e.Graphics.DrawRectangle(arrowinner, width - splitwidth + 1, 1, splitwidth - 3, height - 3);

                e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(width - 2, 0));
                e.Graphics.DrawLine(outercolor, new Point(width - 2, 0), new Point(width - 2, 1));
                e.Graphics.DrawLine(outercolor, new Point(width - 1, 1), new Point(width - 1, height - 2));
                e.Graphics.DrawLine(outercolor, new Point(width - 2, height - 2), new Point(width - 2, height - 1));
                e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(width - 2, height - 1));
                e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(1, height - 2));
                e.Graphics.DrawLine(outercolor, new Point(0, 1), new Point(0, height - 2));
                e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(1, 1));


                buttoninner.Dispose();
                innercolor.Dispose();
                arrowinner.Dispose();
                arrowinner.Dispose();
                outercolor.Dispose();

            }

            public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
            {
                //Customize arrow as image
                Image arrowImage = Image.FromFile(@"../../arrow4.png");
                Rectangle imageRect = new Rectangle(left + 4, top + 14, width - 9, height - 28);
                e.Graphics.DrawImage(arrowImage, imageRect);

            }

            #endregion

            #region ISplitButtonRenderer Members

            public SplitButton SplitButton
            {
                get
                {
                    return splitButton;
                }
                set
                {
                    splitButton = value;
                }
            }

            #endregion
        }

        private void splitButton2_Click(object sender, EventArgs e)
        {

        }

        private void splitButton2_MouseUp(object sender, MouseEventArgs e)
        {
            startcolor = Color.LightGreen;
            endcolor = Color.Green;
        }

        private void splitButton2_MouseDown(object sender, MouseEventArgs e)
        {
            startcolor = Color.DarkGoldenrod;
            this.Invalidate();
        }
    }
}
