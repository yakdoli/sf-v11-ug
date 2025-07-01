#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;

namespace MarketSimulation
{
    internal class OrderAgreementQueuerC : MetroForm
    {
        private QuoteManagerC.QuotesUpdatedDelegate quotesUpdateDelegate;

        // Added these to try and improve performance
        private FieldDescriptor symbolColumn;
        private FieldDescriptor openColumn;
        private FieldDescriptor bidColumn;
        private FieldDescriptor askColumn;
        private FieldDescriptor lastColumn;
        private Panel panel1;
        private GridC grid;

        private RecordListDictionary symbolRecordMap = new RecordListDictionary();

        public OrderAgreementQueuerC()
        {
            InitializeComponent();
			grid.SetStyle();
			LoadData();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
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

		
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BeginInvoke(new MethodInvoker(subscribeQuotes));
        }

        void subscribeQuotes()
        {
            Application.DoEvents();
            QuoteManagerC.Manager.QuotesUpdate += new QuoteManagerC.QuotesUpdatedDelegate(Manager_QuotesUpdate);
        }

        void Manager_QuotesUpdate(QuoteC[] quoteList)
        {
            // Quote updates come in on a separate thread, so call Control.Invoke()
            try
            {
                if (!IsDisposed)
                    Invoke(quotesUpdateDelegate, new object[] { quoteList });
            }
            catch (Exception)
            { }
        }

        void QuotesUpdate(QuoteC[] quoteList)
        {
			if (grid.IsDisposed)
				return;

            foreach (QuoteC quote in quoteList)
            {
                if (symbolRecordMap.ContainsKey(quote.Symbol))
                {
                    foreach (Record record in symbolRecordMap[quote.Symbol])
                    {
                        DataRow data = (DataRow) record.GetData();
                        data.BeginEdit();
                        data[openColumn.MappingName] = quote.Open;
                        data[bidColumn.MappingName] = quote.Bid;
                        data[askColumn.MappingName] = quote.Ask;
                        data[lastColumn.MappingName] = quote.Last;
                        data.EndEdit();
                    }
                }
            }

            this.grid.Update(); // calls PaintUpdateRecordFields.
        }

        protected void LoadData()
        {
            // In this prototype, the orders will not change... but the market data will
            OrderAgreementListC records = new OrderAgreementListC();

            for (int i = 0; i < Program.NumberOfRows; i++)
            {
                OrderAgreementC orderAgreement = OrderAgreementC.GenerateRandom();
                records.Add(orderAgreement);
            }

            DataTable table = GridC.CreateDataTable(records);

            grid.BindToCurrencyManager = false;
            grid.AllowSwapDataViewWithDataTableList = true;
            grid.DataSource = table;

            symbolColumn = grid.TableDescriptor.Fields["Symbol"];
            openColumn = grid.TableDescriptor.Fields["Opn"];
            bidColumn = grid.TableDescriptor.Fields["Bid"];
            askColumn = grid.TableDescriptor.Fields["Ask"];
            lastColumn = grid.TableDescriptor.Fields["Last"];

            // Cache symbol -> records map for faster market data updates
            int count = grid.Table.Records.Count;
            for (int n = 0; n < count; n++)
            {
                Record record = grid.Table.Records[n];
                string symbol = (string)record.GetValue(symbolColumn);
                if (symbol == null)
                    continue;

                RecordList recordList;                
                if (symbolRecordMap.ContainsKey(symbol))
                {
                    recordList = symbolRecordMap[symbol];
                }
                else
                {
                    recordList = new RecordList();
                    symbolRecordMap.Add(symbol, recordList);
                }
                recordList.Add(record);
            }
            this.grid.GridVisualStyles = GridVisualStyles.Metro;
            this.grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            quotesUpdateDelegate = new QuoteManagerC.QuotesUpdatedDelegate(QuotesUpdate);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid = new MarketSimulation.GridC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 426);
            this.panel1.TabIndex = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.SystemColors.Window;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(813, 426);
            this.grid.TabIndex = 1;
            this.grid.Text = "gridGroupingControl1";
            // 
            // OrderAgreementQueuerC
            // 
            this.BackColor = Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(846, 455);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Name = "OrderAgreementQueuerC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Simulation Demo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

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
            if (disposing)
            {
                QuoteManagerC.Manager.QuotesUpdate -= new QuoteManagerC.QuotesUpdatedDelegate(Manager_QuotesUpdate);
                QuoteManagerC.Manager.Dispose();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion
    }
	
	#if SyncfusionFramework2_0
    class RecordList : List<Record>
    {
    }

    class RecordListDictionary : Dictionary<string, RecordList>
    {
    }
#else
    class RecordList : ArrayList
    {
        public new Record this[int index]
        {
            get
            {
                return (Record) base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }

    class RecordListDictionary : Hashtable
    {
        public RecordList this[string key]
        {
            get
            {
                return (RecordList) base[key];
            }
            set
            {
                base[key] = value;
            }
        }
    }
#endif
}