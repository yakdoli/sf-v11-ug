using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;

namespace PrintPageLayout
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            gridControl1.RowCount = 153;
            gridControl1.ColCount = 45;
        }

        #region Event Handlers
        LayoutSupportHelper layoutHelper;
        GridPrintDocument pd;
        private void Form1_Load(object sender, EventArgs e)
        {
            pd = new GridPrintDocument(gridControl1);
            if (pd.PrinterSettings.IsValid)
                layoutHelper = new LayoutSupportHelper(gridControl1);

            gridControl1.HorizontalThumbTrack = true;
            gridControl1.VerticalThumbTrack = true;
            colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
        }

       
        void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            if(layoutHelper != null)
                layoutHelper.LineColor = colorPickerButton1.SelectedColor;
            gridControl1.Invalidate();
        }

        void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            if(layoutHelper != null)
                layoutHelper.TextColor = colorPickerButton2.SelectedColor;
            gridControl1.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(layoutHelper != null)
                layoutHelper.ShowLayoutLines = this.checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion
    }
}