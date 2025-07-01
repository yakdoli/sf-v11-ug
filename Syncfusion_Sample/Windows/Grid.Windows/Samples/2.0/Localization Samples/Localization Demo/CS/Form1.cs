using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace AlertMessageLocalization
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm 
    {
        private GridControl gridCtrl = null;
        public Form1()
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            Syncfusion.Windows.Forms.LocalizationProvider.Provider = new Localizer();
            InitializeComponent();            
            InitalizeGrid();
            gridCtrl.InitializeCols();
            gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro;
            gridCtrl.Grid.TableStyle.WrapText = false;
            this.DropShadow = true;
            this.BackColor = Color.White;
        }

        #region Helper Methods
        private void InitalizeGrid()
        {
            this.SuspendLayout();
            gridCtrl = new GridControl();
            this.gridCtrl.Grid.Model.EnableLegacyStyle = true;
            this.gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro;
            this.gridCtrl.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            gridCtrl.Grid.BackColor = Color.White;
            this.gridCtrl.Grid.ThemesEnabled = true;
            this.gridCtrl.Grid.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(gridCtrl.Grid);  
            this.ResumeLayout(false);            
            this.gridCtrl.Grid.ColStyles[2].CellValueType = typeof(DateTime);
            this.gridCtrl.Grid.CurrentCellValidating += new CancelEventHandler(Grid_CurrentCellValidating);
        }

        void Grid_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            string strError = "Please enter valid value";
            string numError = "Please enter less than 10";
            if (checkBox1.Checked)
            {
                numError = "Bitte geben Sie weniger als 10";
                strError = "Geben Sie einen gültigen Wert";
            }
            long result;
            if (this.gridCtrl.Grid.CurrentCell.ColIndex != 2)
            {
                if (long.TryParse(this.gridCtrl.Grid.CurrentCell.Renderer.ControlText, out result))
                {
                    if (result > 10)
                    {
                        this.gridCtrl.Grid.CurrentCell.SetError(numError);
                        e.Cancel = true;
                    }
                }
                else
                    this.gridCtrl.Grid.CurrentCell.SetError(strError);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            this.gridCtrl.Grid.ShowMessageBoxOnDrop = true;            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Localizer loc = new Localizer();
            loc.getstring(checkBox1.Checked);
            LocalizationProvider.Provider = loc;
        }
        #endregion
    }
}
