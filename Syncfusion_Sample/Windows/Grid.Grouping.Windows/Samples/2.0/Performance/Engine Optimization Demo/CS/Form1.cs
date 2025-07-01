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

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using System.IO;

namespace TestEngineOptimizations
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm  
	{
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl _gridGroupingControl1;
        private IContainer components;
        public ListboxTextWriter Log;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Panel panel1;
        private ListBox listBox1;

		ConfigCollection configurations;

		public ConfigCollection Configurations
		{
			get
			{
				return configurations;
			}
			set
			{
				configurations = value;
			}
		}

		internal GridGroupingControl gridGroupingControl1
		{
			get
			{
				return this._gridGroupingControl1;
			}
			set
			{
				if (this._gridGroupingControl1 != value)
				{
					if (this._gridGroupingControl1 != null)
					{
						this._gridGroupingControl1.PropertyChanging -= new DescriptorPropertyChangedEventHandler(_gridGroupingControl1_PropertyChanging);
					}
					this._gridGroupingControl1 = value;
					if (this._gridGroupingControl1 != null)
					{
						this._gridGroupingControl1.PropertyChanging += new DescriptorPropertyChangedEventHandler(_gridGroupingControl1_PropertyChanging);
					}
				}
			}
		}


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            try
            {

                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

			configurations = new ConfigCollection();
			configurations.Add(new Config("Reset Datasource"));
			configurations.Add(new Config("Flat Virtual List, 30 million records, Virtual Mode"));
			configurations.Add(new Config("Flat Virtual List, VirtualMode"));
			configurations.Add(new Config("Flat Virtual List, No Optimizations"));
			configurations.Add(new Config("Flat Virtual List, Using Custom Engine"));
			configurations.Add(new Config("Flat Virtual List, Sorted"));
			configurations.Add(new Config("Flat Virtual List, Grouped"));
			configurations.Add(new Config("Flat Virtual List, Grouped, VerticalPixelScroll"));
			configurations.Add(new Config("Flat DataView, VirtualMode, Pass-Through sorting enabled."));
			configurations.Add(new Config("Flat DataView, VirtualMode, Pass-Through sorting disabled."));
			configurations.Add(new Config("Flat DataView, Summaries."));
			configurations.Add(new Config("Flat DataView, Grouped."));
            
////			configurations.Add(new Config());

			InitializeSelectMenu();

			gridGroupingControl1 = new GridGroupingControl();
            Config con = new Config("Flat Virtual List, 30 million records, Virtual Mode");
            con.ApplyTo(this);
            gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            Log = new ListboxTextWriter(this.listBox1);
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

		
		void InitializeSelectMenu()
		{
			System.EventHandler menuItemSelectConfig_Click = new System.EventHandler(this.menuItemSelectConfig_Click);
            ArrayList list = new ArrayList();
			
			foreach (Config config in configurations)
			{				
                list.Add(config.Name);             
               
			}
            this.comboBoxAdv2.DataSource = list;
            this.comboBoxAdv2.SelectedIndex = 1;
		}

		private void menuItemSelectConfig_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = (MenuItem) sender;
			Config config = this.configurations.Find(mi.Text);
			Log.WriteLine();
			Log.WriteLine("Select Configuration: " + mi.Text);
			Log.WriteLine(config.Comment);

			int time = Environment.TickCount;

			Cursor.Current = Cursors.WaitCursor;
			config.ApplyTo(this);
			this.Refresh();
			Cursor.Current = Cursors.Arrow;

			Log.WriteLine("Elapsed Time: {0}", Environment.TickCount-time);
            gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;            
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;

		}

		void LogMemoryUsage()
		{
			// Force garbage collection and get used memory size
			GC.Collect();
			System.Threading.Thread.Sleep(10);
			GC.Collect();
			System.Threading.Thread.Sleep(100);
			GC.Collect();
			Log.Write("Optimizations for {0}: ", this.gridGroupingControl1.TableDescriptor.Name);
			Log.Write("VirtualMode: {0}, ", this.gridGroupingControl1.Table.VirtualMode);
			Log.Write("WithoutCounter: {0}, ", this.gridGroupingControl1.Table.WithoutCounter);
			Log.WriteLine("RecordsAsDisplayElements: {0}, ", this.gridGroupingControl1.Table.RecordsAsDisplayElements);
			Process myProcess = Process.GetCurrentProcess();
#if SyncfusionFramework2_0
			double workingSetSizeinKiloBytes = myProcess.WorkingSet64 / 1000;
#else
			double workingSetSizeinKiloBytes = myProcess.WorkingSet / 1000;
#endif
			string s = "Process's physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb \r\n";
			Log.WriteLine(s);
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAdv2);
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(423, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(105, 54);
            this.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(172, 23);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 1;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Modify",
            "Save to",
            "Open",
            "Exit"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Modify"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Save to"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Open"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Exit"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(105, 19);
            this.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(172, 23);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(411, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(20, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(694, 147);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(736, 489);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engine Optimization Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		Timer t = null;

		private void _gridGroupingControl1_PropertyChanging(object sender, DescriptorPropertyChangedEventArgs e)
		{
			if (Log != null)
			{
				Log.WriteLine(e.ToString());
				if (t != null)
				{
					t.Tick -= new EventHandler(t_Tick);
					t.Dispose();
				}
				t = new Timer();
				t.Interval = 100;
				t.Tick += new EventHandler(t_Tick);
				t.Start();
			}
		}

		private void t_Tick(object sender, EventArgs e)
		{
			Timer t = (Timer) sender;
			t.Tick -= new EventHandler(t_Tick);
			t.Dispose();
			this.LogMemoryUsage();
		}

		private void menuItemModifyConfiguration_Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.configurations.GetType());
			Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
			PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["Configurations"];
			Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
			tdc.ServiceProvider = esc;

			ce.EditValue(tdc, esc, Configurations);
            InitializeSelectMenu();
		}
        System.IO.MemoryStream stream;
		private void menuItemExitApp_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		static XmlSerializer configCollectionSerializer;

		static XmlSerializer ConfigCollectionSerializer
		{
			get
			{
				if (configCollectionSerializer == null)
					configCollectionSerializer = new XmlSerializer(typeof(ConfigCollection));
				return configCollectionSerializer;
			}
		}

		private void menuItemOpenFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				FileDialog dlg = new OpenFileDialog();
				dlg.DefaultExt = "xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					XmlTextReader xr = new XmlTextReader(dlg.FileName);
					this.configurations = (ConfigCollection) ConfigCollectionSerializer.Deserialize(xr);
                    System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
                    this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
					xr.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void menuItemSaveToFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				FileDialog dlg = new SaveFileDialog();
				dlg.DefaultExt = "xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					XmlTextWriter xw = new XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8);
					xw.Formatting = Formatting.Indented;
					ConfigCollectionSerializer.Serialize(xw, configurations);
                    stream = new System.IO.MemoryStream();
                    this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));
                 
                    xw.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void menuItem3_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
		}

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv1.SelectedItem.ToString())
            {
                case "Modify":
                    System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.configurations.GetType());
                    Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
                    PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["Configurations"];
                    Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
                    tdc.ServiceProvider = esc;

                    ce.EditValue(tdc, esc, Configurations);
                    InitializeSelectMenu();
                    break;
                case "Save to":
                    try
                    {
                        FileDialog dlg = new SaveFileDialog();
                        dlg.DefaultExt = "xml";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            XmlTextWriter xw = new XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8);
                            xw.Formatting = Formatting.Indented;
                            ConfigCollectionSerializer.Serialize(xw, configurations);
                            stream = new System.IO.MemoryStream();
                            this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));

                            xw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Open":
                    try
                    {
                        FileDialog dlg = new OpenFileDialog();
                        dlg.DefaultExt = "xml";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            XmlTextReader xr = new XmlTextReader(dlg.FileName);
                            this.configurations = (ConfigCollection)ConfigCollectionSerializer.Deserialize(xr);
                            System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
                            this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
                            xr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Exit":
                    Application.Exit();
                    break;
            }
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Log != null && comboBoxAdv2.SelectedItem != null)
            {
                //MenuItem mi = (ComboBox)sender;
                Config config = this.configurations.Find(comboBoxAdv2.SelectedItem.ToString());
                Log.WriteLine();
                Log.WriteLine("Select Configuration: " + comboBoxAdv2.SelectedItem.ToString());
                Log.WriteLine(config.Comment);
                int time = Environment.TickCount;
                Cursor.Current = Cursors.WaitCursor;
                config.ApplyTo(this);
                this.Refresh();
                Cursor.Current = Cursors.Arrow;
                Log.WriteLine("Elapsed Time: {0}", Environment.TickCount - time);
                gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
                gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
                gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
				gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
                this.BackColor = Color.White;
            }
        }
    }

    #region TextWriter
    public class ListboxTextWriter : TextWriter
    {
        ListBox lb;
        string lastItem = "";

        public ListboxTextWriter(ListBox lb)
        {
            this.lb = lb;
        }

        public override void Write(char[] buffer, int index, int count)
        {
            lastItem = new string(buffer, index, count).TrimEnd('\r', '\n', '\0');
            base.Write(buffer, index, count);
            lb.Items.Add(lastItem);
            lb.SelectedIndex = lb.Items.Count - 1;
        }

        public override System.Text.Encoding Encoding
        {
            get
            {
                return System.Text.Encoding.Unicode;
            }
        }
    }
    #endregion

}
