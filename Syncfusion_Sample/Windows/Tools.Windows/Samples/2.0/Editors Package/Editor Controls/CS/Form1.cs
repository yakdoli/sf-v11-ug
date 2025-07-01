using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace EditorControls
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        #region Declarations
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private EditorControls.DataSet1 dataSet11;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private Label label34;
        private Label label13;
        private CheckBox checkBox5;
        private Label label35;
        private Label label26;
        private Label label11;
        private Label label9;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private ColorDialog colorDialog1;
        private Label label5;
        private Label label2;
        private Label label8;
        private Label label12;
        private TabPageAdv tabPageAdv2;
        private Label label17;
        private ComboBox comboBox1;
        private Label label15;
        private Label label16;
        private Label label19;
        private Label label20;
        private Label label18;
        private ComboBox comboBox2;
        private RadioButton radFinancial;
        private RadioButton radWinStd;
        private CheckBox checkBox12;
        private RadioButton radWinXP;
        private RadioButton radOfficeXP;
        private RadioButton radOffice2003;
        private RadioButton radOffice2007;
        private RadioButton radOffice2000;
        private RadioButton radClassic;
        private Label label21;
        private Label label22;
        private Label label23;
        private ComboBox cboButtonType;
        private CheckBox checkBox13;
        private TabPageAdv tabPageAdv3;
        private ComboBox comboBox3;
        private Label label30;
        private Label label29;
        private Label label28;
        private ComboBox comboBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private Label label36;
        private ToolTip toolTip1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private DoubleTextBox doubleTextBox1;
        private IntegerTextBox integerTextBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Label label40;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label42;
        private Label label43;
        private Label label44;
        private CheckBox checkBox16;
        private TextBox textBox3;
        private Label label55;
        private Label label54;
        private IntegerTextBox integerTextBox3;
        private Label label53;
        private TextBox textBox2;
        private Label label52;
        private Label label46;
        private Label label58;
        private Label label61;
        private Label label62;
        private Label label69;
        private TextBox textBox4;
        private Label label67;
        private Label label68;
        private NumericUpDownExt numericUpDownExt1;
        private Label label70;
        private IntegerTextBox integerTextBox7;
        private Label label72;
        private TextBox textBox6;
        private Label label73;
        private NumericUpDownExt numericUpDownExt2;
        private NumericUpDownExt numericUpDownExt3;
        private NumericUpDownExt numericUpDownExt4;
        private NumericUpDownExt numericUpDownExt5;
        private Label label76;
        private PercentTextBox percentTextBox1;
        private Label label82;
        private Label label83;
        private CheckBox checkBox18;
        private CheckBox checkBox17;
        private Label label86;
        private Label label85;
        private GroupBox groupBox1;
        private Label label84;
        private Label label87;
        private Label label88;
        private Label label89;
        private Label label91;
        private Label label92;
        private DomainUpDownExt domainUpDownExt1;
        private CheckBox checkBox19;
        private Label label27;
        private Label label32;
        private DataGrid dataGrid2;
        private ButtonEdit NegativeColorEdit;
        private ButtonEditChildButton buttonEditChildButton1;
        private TextBoxExt textBoxExt2;
        private ButtonEdit PositiveColorEdit;
        private ButtonEditChildButton buttonEditChildButton5;
        private TextBoxExt textBoxExt1;
        private TabPageAdv tabPageAdv5;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton2;
        private TextBoxExt textBoxExt3;
        private CheckBox checkBox21;
        private TextBoxExt textBoxExt4;
        private Label label103;
        private Label label104;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private Label label105;
        private ComboBox comboBox10;
        private ComboBox comboBox11;
        private Label label106;
        private Label label107;
        private ComboBox comboBox12;
        private ComboBox comboBox9;
        private Label label101;
        private ComboBox comboBox8;
        private Label label100;
        private Label label108;
        private CheckBox checkBox25;
        private CheckBox checkBox24;
        private CheckBox checkBox23;
        private CheckBox checkBox22;
        private Label label109;
        private Label label110;
        private TextBox textBox11;
        private Label label102;
        private CheckBox checkBox26;
        private Label label113;
        private Label label114;
        private Label label111;
        private Label label112;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton4;
        private Label label115;
        private TabPageAdv tabPageAdv6;
        private EditableList editableList2;
        private GradientPanel gradientPanel3;
        private Label label116;
        private EditableList editableList1;
        private Label label118;
        private Label label119;
        private Label label120;
        private Label label121;
        private GradientPanel gradientPanel4;
        private Label label122;
        private ComboBox comboBox13;
        private Label label117;
        private Label label123;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private ButtonEdit DomainBorderColorEdit;
        private ButtonEditChildButton buttonEditChildButton6;
        private Label label31;
        private TreeViewAdv treeViewAdv1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel5;
        private GradientPanel gradientPanel6;
        private Label label33;
        private Label label37;
        private GradientPanel gradientPanel7;
        private GradientPanel gradientPanel8;
        private Label label38;
        private Label label56;
        private GradientPanel gradientPanel11;
        private GradientPanel gradientPanel9;
        private GradientPanel gradientPanel12;
        private Label label45;
        private Label label47;
        private GradientPanel gradientPanel10;
        private Label label57;
        private Label label63;
        private GradientLabel gradientLabel1;
        private Label label48;
        private Label label49;
        private Label label1;
        private Label label10;
        private Label label50;
        private Label label51;
        private Label label39;
        private Label label41;
        private Label label66;
        private NumericUpDownExt numericUpDownExt7;
        private Label label24;
        private Label label25;
        private Label label65;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label14;
        private CheckBox checkBox20;
        private Label label59;
        private Label label60;
        private Panel panel1;
        private CurrencyEdit currencyEdit1;
        private TabPageAdv tabPageAdv4;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private Label label80;
        private Label label81;
        private Label label90;
        private ComboBox comboBox7;
        private Label label93;
        private Label label94;
        private RadioButton radioButton8;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton7;
        private RadioButton radioButton9;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton8;
        private Label label95;
        private ComboBox comboBox14;
        private Label label96;
        private Label label97;
        private Label label71;
        private Label label74;
        private GroupBox groupBox6;
        private MaskedEditBox maskedEditBox1;
        private Label label64;
        private Label label98;
        private ComboBox comboBox15;
        private Label label79;
        private CheckBox checkBox29;
        private ComboBox comboBox16;
        private CheckBox checkBox30;
        private ComboBox comboBox17;
        private Label label125;
        private Label label126;
        private ComboBox comboBox18;
        private Label label75;
        private ComboBox comboBox19;
        private Label label77;
        private Label label78;
        private Button button1;
        private ButtonEdit bannerClrEdit;
        private ButtonEditChildButton buttonEditChildButton9;
        private TextBoxExt textBoxExt5;
        private RadioButton rdoFocus;
        private RadioButton rdoEdit;
        private TextBox txtBanner;
        private Label label127;
        private Label label124;
        private Label label99;
        private BannerTextProvider bannerTextProvider1;
        private Label label128;
        private Label label129;
        private ComboBoxAdv cmbMode;
        private TextBox txtBnr;
        private Label label130;
        private Label label131;
        private Label label132;
        private Button btnSetBanner;
        private ButtonEdit bannerClr;
        private ButtonEditChildButton buttonEditChildButton10;
        private TextBoxExt textBoxExt6;
        private TextBox textBanner;
        private Label label136;
        private Label label135;
        private Label label134;
        private Label label133;
        private ButtonEdit bEditBanner;
        private TextBoxExt textBoxExt7;
        private ComboBoxAdv comboMode;
        private ButtonEditChildButton buttonEditChildButton11;
        private Button buttonBanner;
        private RadioButton radioButton12;
        private Label label137;
        private Label label138;
        private NumericUpDownExt numericUpDownExt8;
        private NumericUpDownExt numericUpDownExt6;
        private NumericUpDownExt numericUpDownExt9;
        private Label label139;
        private DataTable Dt;
        private CheckBox checkBox32;
        private CheckBox checkBox31;
        private CheckBox chkPullCharOnDelete;

        private System.ComponentModel.IContainer components;
        #endregion

        #region Form constructor and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo5 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo6 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo7 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.currencyTextBox1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel11 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.numericUpDownExt8 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label138 = new System.Windows.Forms.Label();
            this.bannerClr = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton10 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSetBanner = new System.Windows.Forms.Button();
            this.cmbMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtBnr = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.NegativeColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.PositiveColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gradientPanel12 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.integerTextBox2 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.gradientPanel10 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label57 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDownExt3 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label67 = new System.Windows.Forms.Label();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label60 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.percentTextBox1 = new Syncfusion.Windows.Forms.Tools.PercentTextBox();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label38 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.numericUpDownExt5 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.integerTextBox7 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDownExt4 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.doubleTextBox1 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.integerTextBox3 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.buttonBanner = new System.Windows.Forms.Button();
            this.comboMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.bEditBanner = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton11 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt7 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBanner = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExt7 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.domainUpDownExt1 = new Syncfusion.Windows.Forms.Tools.DomainUpDownExt();
            this.label66 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.DomainBorderColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.numericUpDownExt6 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label137 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton9 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.rdoFocus = new System.Windows.Forms.RadioButton();
            this.rdoEdit = new System.Windows.Forms.RadioButton();
            this.txtBanner = new System.Windows.Forms.TextBox();
            this.label127 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxExt4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label109 = new System.Windows.Forms.Label();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label108 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.label115 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.label113 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.label114 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.label111 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.label102 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.currencyEdit1 = new Syncfusion.Windows.Forms.Tools.CurrencyEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radClassic = new System.Windows.Forms.RadioButton();
            this.label85 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radWinStd = new System.Windows.Forms.RadioButton();
            this.radFinancial = new System.Windows.Forms.RadioButton();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radOffice2000 = new System.Windows.Forms.RadioButton();
            this.radOffice2007 = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.radOfficeXP = new System.Windows.Forms.RadioButton();
            this.cboButtonType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.radWinXP = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.radOffice2003 = new System.Windows.Forms.RadioButton();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.label123 = new System.Windows.Forms.Label();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label117 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label122 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.editableList2 = new Syncfusion.Windows.Forms.Tools.EditableList();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label116 = new System.Windows.Forms.Label();
            this.editableList1 = new Syncfusion.Windows.Forms.Tools.EditableList();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chkPullCharOnDelete = new System.Windows.Forms.CheckBox();
            this.numericUpDownExt9 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label139 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label126 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label125 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label95 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maskedEditBox1 = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataSet11 = new EditorControls.DataSet1();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel11)).BeginInit();
            this.gradientPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClr)).BeginInit();
            this.bannerClr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativeColorEdit)).BeginInit();
            this.NegativeColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositiveColorEdit)).BeginInit();
            this.PositiveColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).BeginInit();
            this.gradientPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel12)).BeginInit();
            this.gradientPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).BeginInit();
            this.gradientPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditBanner)).BeginInit();
            this.bEditBanner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt7)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DomainBorderColorEdit)).BeginInit();
            this.DomainBorderColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.tabPageAdv5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "App.ico");
            this.imageList1.Images.SetKeyName(2, "textBoxExt4.FarImage.png");
            // 
            // currencyTextBox1
            // 
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "<Value>";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.currencyTextBox1, bannerTextInfo1);
            this.currencyTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.currencyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencyTextBox1.CurrentCultureRefresh = true;
            this.currencyTextBox1.DecimalValue = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            this.currencyTextBox1.Location = new System.Drawing.Point(61, 78);
            this.currencyTextBox1.MinimumSize = new System.Drawing.Size(10, 6);
            this.currencyTextBox1.Name = "currencyTextBox1";
            this.currencyTextBox1.NegativeInputPendingOnSelectAll = false;
            this.currencyTextBox1.NullString = "";
            this.currencyTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.currencyTextBox1.ShowOverflowIndicator = false;
            this.currencyTextBox1.Size = new System.Drawing.Size(73, 20);
            this.currencyTextBox1.TabIndex = 0;
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.integerTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox1.IntegerValue = ((long)(2));
            this.integerTextBox1.Location = new System.Drawing.Point(105, 178);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.NegativeInputPendingOnSelectAll = false;
            this.integerTextBox1.NullString = "0";
            this.integerTextBox1.OverflowIndicatorToolTipText = null;
            this.integerTextBox1.Size = new System.Drawing.Size(60, 20);
            this.integerTextBox1.TabIndex = 7;
            this.integerTextBox1.ThemesEnabled = false;
            this.integerTextBox1.IntegerValueChanged += new System.EventHandler(this.integerTextbox1_IntegerValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Decimal Digits \r\n(Between 0-99)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "$";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Currency Symbol";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.IgnoreThemeBackground = true;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(460, 49);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(69, 22);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Left";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Align";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(377, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ThemesEnabled";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Culture Settings";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxAdv2.IgnoreThemeBackground = true;
            this.comboBoxAdv2.Location = new System.Drawing.Point(460, 85);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(134, 22);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxAdv2.TabIndex = 4;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(600, 69);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(210, 179);
            this.dataGrid1.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(600, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(133, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Bind To DataBase";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PurchaseDate", "PurchaseDate")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Amount, ID, PurchaseDate FROM Sales";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(163, 54);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(10, 5);
            this.tabControlAdv1.Size = new System.Drawing.Size(837, 636);
            this.tabControlAdv1.TabGap = 15;
            this.tabControlAdv1.TabIndex = 3;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.gradientPanel11);
            this.tabPageAdv1.Controls.Add(this.gradientPanel9);
            this.tabPageAdv1.Controls.Add(this.gradientPanel7);
            this.tabPageAdv1.Controls.Add(this.gradientPanel5);
            this.tabPageAdv1.Controls.Add(this.gradientPanel1);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Input Controls";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // gradientPanel11
            // 
            this.gradientPanel11.BackColor = System.Drawing.Color.White;
            this.gradientPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel11.Controls.Add(this.numericUpDownExt8);
            this.gradientPanel11.Controls.Add(this.label138);
            this.gradientPanel11.Controls.Add(this.bannerClr);
            this.gradientPanel11.Controls.Add(this.btnSetBanner);
            this.gradientPanel11.Controls.Add(this.cmbMode);
            this.gradientPanel11.Controls.Add(this.txtBnr);
            this.gradientPanel11.Controls.Add(this.label130);
            this.gradientPanel11.Controls.Add(this.label131);
            this.gradientPanel11.Controls.Add(this.label132);
            this.gradientPanel11.Controls.Add(this.label128);
            this.gradientPanel11.Controls.Add(this.label129);
            this.gradientPanel11.Controls.Add(this.checkBox20);
            this.gradientPanel11.Controls.Add(this.NegativeColorEdit);
            this.gradientPanel11.Controls.Add(this.label2);
            this.gradientPanel11.Controls.Add(this.label5);
            this.gradientPanel11.Controls.Add(this.dataGrid1);
            this.gradientPanel11.Controls.Add(this.label42);
            this.gradientPanel11.Controls.Add(this.comboBox6);
            this.gradientPanel11.Controls.Add(this.checkBox2);
            this.gradientPanel11.Controls.Add(this.label46);
            this.gradientPanel11.Controls.Add(this.label58);
            this.gradientPanel11.Controls.Add(this.label61);
            this.gradientPanel11.Controls.Add(this.label62);
            this.gradientPanel11.Controls.Add(this.radioButton6);
            this.gradientPanel11.Controls.Add(this.buttonEdit1);
            this.gradientPanel11.Controls.Add(this.radioButton7);
            this.gradientPanel11.Controls.Add(this.PositiveColorEdit);
            this.gradientPanel11.Controls.Add(this.label40);
            this.gradientPanel11.Controls.Add(this.comboBox5);
            this.gradientPanel11.Controls.Add(this.checkBox16);
            this.gradientPanel11.Controls.Add(this.label8);
            this.gradientPanel11.Controls.Add(this.label43);
            this.gradientPanel11.Controls.Add(this.label44);
            this.gradientPanel11.Controls.Add(this.label12);
            this.gradientPanel11.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel11.Controls.Add(this.label3);
            this.gradientPanel11.Controls.Add(this.label6);
            this.gradientPanel11.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel11.Controls.Add(this.checkBox1);
            this.gradientPanel11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel11.Location = new System.Drawing.Point(12, 303);
            this.gradientPanel11.Name = "gradientPanel11";
            this.gradientPanel11.Size = new System.Drawing.Size(814, 292);
            this.gradientPanel11.TabIndex = 124;
            // 
            // numericUpDownExt8
            // 
            this.numericUpDownExt8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt8.Location = new System.Drawing.Point(84, 100);
            this.numericUpDownExt8.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt8.Name = "numericUpDownExt8";
            this.numericUpDownExt8.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownExt8.TabIndex = 143;
            this.numericUpDownExt8.ValueChanged += new System.EventHandler(this.numericUpDownExt8_ValueChanged);
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(3, 101);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(73, 14);
            this.label138.TabIndex = 141;
            this.label138.Text = "CornerRadius";
            // 
            // bannerClr
            // 
            this.bannerClr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannerClr.Buttons.Add(this.buttonEditChildButton10);
            this.bannerClr.Controls.Add(this.buttonEditChildButton10);
            this.bannerClr.Controls.Add(this.textBoxExt6);
            this.bannerClr.Location = new System.Drawing.Point(245, 114);
            this.bannerClr.Name = "bannerClr";
            this.bannerClr.ShowTextBox = false;
            this.bannerClr.Size = new System.Drawing.Size(107, 21);
            this.bannerClr.TabIndex = 135;
            this.bannerClr.TextBox = this.textBoxExt6;
            this.bannerClr.UseVisualStyle = true;
            this.bannerClr.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClr_ButtonClicked);
            // 
            // buttonEditChildButton10
            // 
            this.buttonEditChildButton10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton10.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton10.Image = null;
            this.buttonEditChildButton10.Name = "buttonEditChildButton10";
            this.buttonEditChildButton10.PreferredWidth = 20;
            this.buttonEditChildButton10.TabIndex = 1;
            this.buttonEditChildButton10.Text = "...";
            // 
            // textBoxExt6
            // 
            this.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt6.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt6.Name = "textBoxExt6";
            this.textBoxExt6.OverflowIndicatorToolTipText = null;
            this.textBoxExt6.Size = new System.Drawing.Size(95, 13);
            this.textBoxExt6.TabIndex = 0;
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetBanner.Location = new System.Drawing.Point(213, 167);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(113, 23);
            this.btnSetBanner.TabIndex = 2;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbMode.IgnoreThemeBackground = true;
            this.cmbMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.cmbMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbMode, "EditMode"));
            this.cmbMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbMode, "FocusMode"));
            this.cmbMode.Location = new System.Drawing.Point(245, 78);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(107, 22);
            this.cmbMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbMode.TabIndex = 134;
            // 
            // txtBnr
            // 
            this.txtBnr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBnr.Location = new System.Drawing.Point(245, 41);
            this.txtBnr.Name = "txtBnr";
            this.txtBnr.Size = new System.Drawing.Size(107, 20);
            this.txtBnr.TabIndex = 130;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(191, 43);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(28, 14);
            this.label130.TabIndex = 131;
            this.label130.Text = "Text";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(190, 81);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(33, 14);
            this.label131.TabIndex = 132;
            this.label131.Text = "Mode";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(190, 121);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(32, 14);
            this.label132.TabIndex = 133;
            this.label132.Text = "Color";
            // 
            // label128
            // 
            this.label128.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label128.Image = ((System.Drawing.Image)(resources.GetObject("label128.Image")));
            this.label128.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label128.Location = new System.Drawing.Point(180, 3);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(142, 24);
            this.label128.TabIndex = 122;
            this.label128.Text = "BannerText Settings";
            this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label129
            // 
            this.label129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label129.Location = new System.Drawing.Point(200, 27);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(150, 1);
            this.label129.TabIndex = 121;
            // 
            // checkBox20
            // 
            this.checkBox20.Location = new System.Drawing.Point(377, 193);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(179, 24);
            this.checkBox20.TabIndex = 120;
            this.checkBox20.Text = "OverFlowIndicatorToolTip";
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // NegativeColorEdit
            // 
            this.NegativeColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NegativeColorEdit.Buttons.Add(this.buttonEditChildButton1);
            this.NegativeColorEdit.Controls.Add(this.buttonEditChildButton1);
            this.NegativeColorEdit.Location = new System.Drawing.Point(84, 220);
            this.NegativeColorEdit.Name = "NegativeColorEdit";
            this.NegativeColorEdit.ShowTextBox = false;
            this.NegativeColorEdit.Size = new System.Drawing.Size(91, 26);
            this.NegativeColorEdit.TabIndex = 118;
            this.NegativeColorEdit.UseVisualStyle = true;
            this.NegativeColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.NegativeColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Positive Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Negative Color";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 257);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 14);
            this.label42.TabIndex = 48;
            this.label42.Text = "Border Color";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Enabled = false;
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox6.ForeColor = System.Drawing.Color.Black;
            this.comboBox6.Location = new System.Drawing.Point(84, 126);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(91, 22);
            this.comboBox6.TabIndex = 49;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label46.Image = ((System.Drawing.Image)(resources.GetObject("label46.Image")));
            this.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label46.Location = new System.Drawing.Point(3, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(142, 24);
            this.label46.TabIndex = 75;
            this.label46.Text = "Appearance Settings";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label58.Location = new System.Drawing.Point(12, 24);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(150, 1);
            this.label58.TabIndex = 74;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label61.Image = ((System.Drawing.Image)(resources.GetObject("label61.Image")));
            this.label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label61.Location = new System.Drawing.Point(375, 3);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(126, 24);
            this.label61.TabIndex = 79;
            this.label61.Text = "Behavior Settings";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label62.Location = new System.Drawing.Point(377, 28);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(150, 1);
            this.label62.TabIndex = 78;
            // 
            // radioButton6
            // 
            this.radioButton6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(84, 69);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 26);
            this.radioButton6.TabIndex = 54;
            this.radioButton6.Text = "Fixed3D";
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.Color.White;
            this.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit1.Location = new System.Drawing.Point(84, 250);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(91, 26);
            this.buttonEdit1.TabIndex = 119;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // radioButton7
            // 
            this.radioButton7.Checked = true;
            this.radioButton7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(84, 41);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(91, 26);
            this.radioButton7.TabIndex = 53;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "FixedSingle";
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // PositiveColorEdit
            // 
            this.PositiveColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PositiveColorEdit.Buttons.Add(this.buttonEditChildButton5);
            this.PositiveColorEdit.Controls.Add(this.buttonEditChildButton5);
            this.PositiveColorEdit.Location = new System.Drawing.Point(84, 191);
            this.PositiveColorEdit.Name = "PositiveColorEdit";
            this.PositiveColorEdit.ShowTextBox = false;
            this.PositiveColorEdit.Size = new System.Drawing.Size(91, 26);
            this.PositiveColorEdit.TabIndex = 117;
            this.PositiveColorEdit.UseVisualStyle = true;
            this.PositiveColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.PositiveColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 47);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(67, 14);
            this.label40.TabIndex = 52;
            this.label40.Text = "Border Style";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox5.Location = new System.Drawing.Point(84, 157);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(91, 22);
            this.comboBox5.TabIndex = 50;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox16.Location = new System.Drawing.Point(377, 160);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(123, 24);
            this.checkBox16.TabIndex = 60;
            this.checkBox16.Text = "OverFlowIndicator";
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(597, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Data Binding";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 158);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(70, 14);
            this.label43.TabIndex = 47;
            this.label43.Text = "Border Sides";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 125);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(80, 14);
            this.label44.TabIndex = 46;
            this.label44.Text = "Border3D Style";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label12.Location = new System.Drawing.Point(608, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 1);
            this.label12.TabIndex = 23;
            // 
            // gradientPanel9
            // 
            this.gradientPanel9.BackColor = System.Drawing.Color.White;
            this.gradientPanel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel9.Controls.Add(this.currencyTextBox1);
            this.gradientPanel9.Controls.Add(this.label1);
            this.gradientPanel9.Controls.Add(this.label10);
            this.gradientPanel9.Controls.Add(this.gradientPanel12);
            this.gradientPanel9.Controls.Add(this.label4);
            this.gradientPanel9.Controls.Add(this.textBox1);
            this.gradientPanel9.Controls.Add(this.label7);
            this.gradientPanel9.Controls.Add(this.integerTextBox1);
            this.gradientPanel9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel9.Location = new System.Drawing.Point(12, 7);
            this.gradientPanel9.Name = "gradientPanel9";
            this.gradientPanel9.Size = new System.Drawing.Size(193, 278);
            this.gradientPanel9.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 127;
            this.label1.Text = "Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.Location = new System.Drawing.Point(84, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 1);
            this.label10.TabIndex = 126;
            // 
            // gradientPanel12
            // 
            this.gradientPanel12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel12.Controls.Add(this.label45);
            this.gradientPanel12.Controls.Add(this.label47);
            this.gradientPanel12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel12.Location = new System.Drawing.Point(3, -1);
            this.gradientPanel12.Name = "gradientPanel12";
            this.gradientPanel12.Size = new System.Drawing.Size(156, 76);
            this.gradientPanel12.TabIndex = 124;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label45.Location = new System.Drawing.Point(0, 18);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(156, 58);
            this.label45.TabIndex = 1;
            this.label45.Text = "CurrencyTextBox control is a textbox derived control for different currencies pre" +
                "sent.";
            // 
            // label47
            // 
            this.label47.Dock = System.Windows.Forms.DockStyle.Top;
            this.label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(156, 18);
            this.label47.TabIndex = 123;
            this.label47.Text = "CurrencyTextBox";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.White;
            this.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.label59);
            this.gradientPanel7.Controls.Add(this.integerTextBox2);
            this.gradientPanel7.Controls.Add(this.label50);
            this.gradientPanel7.Controls.Add(this.label51);
            this.gradientPanel7.Controls.Add(this.gradientPanel10);
            this.gradientPanel7.Controls.Add(this.label69);
            this.gradientPanel7.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel7.Controls.Add(this.label68);
            this.gradientPanel7.Controls.Add(this.textBox4);
            this.gradientPanel7.Controls.Add(this.numericUpDownExt3);
            this.gradientPanel7.Controls.Add(this.label67);
            this.gradientPanel7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel7.Location = new System.Drawing.Point(219, 7);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(193, 278);
            this.gradientPanel7.TabIndex = 122;
            // 
            // label59
            // 
            this.label59.Image = ((System.Drawing.Image)(resources.GetObject("label59.Image")));
            this.label59.Location = new System.Drawing.Point(167, 143);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(20, 20);
            this.label59.TabIndex = 128;
            this.toolTip1.SetToolTip(this.label59, "When a negative value is entered, the value can be\r\ndisplayed in various pattern " +
                    "such as the symbol in \r\nfront of the number and so on.");
            // 
            // integerTextBox2
            // 
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = "<Value>";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.integerTextBox2, bannerTextInfo2);
            this.integerTextBox2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.integerTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox2.Culture = new System.Globalization.CultureInfo("bg-BG");
            this.integerTextBox2.IntegerValue = ((long)(2));
            this.integerTextBox2.Location = new System.Drawing.Point(51, 79);
            this.integerTextBox2.Name = "integerTextBox2";
            this.integerTextBox2.NegativeInputPendingOnSelectAll = false;
            this.integerTextBox2.NullString = "";
            this.integerTextBox2.NumberGroupSizes = new int[] {
        2};
            this.integerTextBox2.NumberNegativePattern = 2;
            this.integerTextBox2.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.integerTextBox2.Size = new System.Drawing.Size(73, 20);
            this.integerTextBox2.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            this.integerTextBox2.TabIndex = 0;
            this.integerTextBox2.UseNullString = true;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label50.Image = ((System.Drawing.Image)(resources.GetObject("label50.Image")));
            this.label50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label50.Location = new System.Drawing.Point(3, 116);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(81, 24);
            this.label50.TabIndex = 127;
            this.label50.Text = "Properties";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label51.Location = new System.Drawing.Point(84, 129);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(74, 1);
            this.label51.TabIndex = 126;
            // 
            // gradientPanel10
            // 
            this.gradientPanel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel10.Controls.Add(this.label57);
            this.gradientPanel10.Controls.Add(this.label63);
            this.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel10.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel10.Name = "gradientPanel10";
            this.gradientPanel10.Size = new System.Drawing.Size(191, 76);
            this.gradientPanel10.TabIndex = 123;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label57.Location = new System.Drawing.Point(0, 18);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(191, 58);
            this.label57.TabIndex = 1;
            this.label57.Text = "Integer TextBox is used to display Int64 values ";
            // 
            // label63
            // 
            this.label63.Dock = System.Windows.Forms.DockStyle.Top;
            this.label63.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label63.Location = new System.Drawing.Point(0, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(191, 18);
            this.label63.TabIndex = 123;
            this.label63.Text = "IntegerTextBox";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 146);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(86, 14);
            this.label69.TabIndex = 90;
            this.label69.Text = "Negative Pattern";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(106, 143);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownExt1.TabIndex = 92;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 178);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(88, 14);
            this.label68.TabIndex = 86;
            this.label68.Text = "Group Separator";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 89;
            this.textBox4.Text = ",";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numericUpDownExt3
            // 
            this.numericUpDownExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt3.Location = new System.Drawing.Point(106, 213);
            this.numericUpDownExt3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownExt3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt3.Name = "numericUpDownExt3";
            this.numericUpDownExt3.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownExt3.TabIndex = 104;
            this.numericUpDownExt3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt3.ValueChanged += new System.EventHandler(this.numericUpDownExt3_ValueChanged);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 210);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(67, 14);
            this.label67.TabIndex = 87;
            this.label67.Text = "Group Sizes";
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.label60);
            this.gradientPanel5.Controls.Add(this.label48);
            this.gradientPanel5.Controls.Add(this.label49);
            this.gradientPanel5.Controls.Add(this.percentTextBox1);
            this.gradientPanel5.Controls.Add(this.gradientPanel8);
            this.gradientPanel5.Controls.Add(this.label73);
            this.gradientPanel5.Controls.Add(this.textBox6);
            this.gradientPanel5.Controls.Add(this.label72);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt5);
            this.gradientPanel5.Controls.Add(this.integerTextBox7);
            this.gradientPanel5.Controls.Add(this.label76);
            this.gradientPanel5.Controls.Add(this.label70);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt4);
            this.gradientPanel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel5.Location = new System.Drawing.Point(633, 8);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(193, 278);
            this.gradientPanel5.TabIndex = 121;
            // 
            // label60
            // 
            this.label60.Image = ((System.Drawing.Image)(resources.GetObject("label60.Image")));
            this.label60.Location = new System.Drawing.Point(165, 235);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(20, 20);
            this.label60.TabIndex = 129;
            this.toolTip1.SetToolTip(this.label60, "When a negative value is entered, the value can be\r\ndisplayed in various pattern " +
                    "such as the symbol in \r\nfront of the number and so on.");
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label48.Image = ((System.Drawing.Image)(resources.GetObject("label48.Image")));
            this.label48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label48.Location = new System.Drawing.Point(3, 115);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 24);
            this.label48.TabIndex = 125;
            this.label48.Text = "Properties";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label49.Location = new System.Drawing.Point(83, 128);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(74, 1);
            this.label49.TabIndex = 124;
            // 
            // percentTextBox1
            // 
            bannerTextInfo3.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo3.Text = "<Value>";
            bannerTextInfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.percentTextBox1, bannerTextInfo3);
            this.percentTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentTextBox1.DoubleValue = 0.53;
            this.percentTextBox1.Location = new System.Drawing.Point(58, 77);
            this.percentTextBox1.Name = "percentTextBox1";
            this.percentTextBox1.NegativeInputPendingOnSelectAll = false;
            this.percentTextBox1.NullString = "";
            this.percentTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.percentTextBox1.PercentGroupSeparator = "@";
            this.percentTextBox1.PercentGroupSizes = new int[] {
        2};
            this.percentTextBox1.Size = new System.Drawing.Size(73, 20);
            this.percentTextBox1.TabIndex = 0;
            this.percentTextBox1.UseNullString = true;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.label38);
            this.gradientPanel8.Controls.Add(this.label56);
            this.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(191, 76);
            this.gradientPanel8.TabIndex = 123;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label38.Location = new System.Drawing.Point(0, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(191, 58);
            this.label38.TabIndex = 1;
            this.label38.Text = "PercentTextBox is used to display percentage values. ";
            // 
            // label56
            // 
            this.label56.Dock = System.Windows.Forms.DockStyle.Top;
            this.label56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label56.Location = new System.Drawing.Point(0, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(191, 18);
            this.label56.TabIndex = 123;
            this.label56.Text = "PercentTextBox";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(12, 177);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(94, 14);
            this.label73.TabIndex = 93;
            this.label73.Text = "Decimal separator";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 171);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 94;
            this.textBox6.Text = ".";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(12, 209);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(84, 28);
            this.label72.TabIndex = 95;
            this.label72.Text = "Decimal Digits\r\n(Between 0-99)";
            // 
            // numericUpDownExt5
            // 
            this.numericUpDownExt5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt5.Location = new System.Drawing.Point(107, 139);
            this.numericUpDownExt5.Name = "numericUpDownExt5";
            this.numericUpDownExt5.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownExt5.TabIndex = 108;
            this.numericUpDownExt5.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDownExt5.ValueChanged += new System.EventHandler(this.numericUpDownExt5_ValueChanged);
            // 
            // integerTextBox7
            // 
            this.integerTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.integerTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox7.IntegerValue = ((long)(2));
            this.integerTextBox7.Location = new System.Drawing.Point(108, 203);
            this.integerTextBox7.Name = "integerTextBox7";
            this.integerTextBox7.NegativeInputPendingOnSelectAll = false;
            this.integerTextBox7.NullString = "0";
            this.integerTextBox7.OverflowIndicatorToolTipText = null;
            this.integerTextBox7.Size = new System.Drawing.Size(53, 20);
            this.integerTextBox7.TabIndex = 96;
            this.integerTextBox7.ThemesEnabled = false;
            this.integerTextBox7.TextChanged += new System.EventHandler(this.integerTextBox7_TextChanged);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(12, 145);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(75, 14);
            this.label76.TabIndex = 107;
            this.label76.Text = "Percent Value";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(12, 241);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(81, 14);
            this.label70.TabIndex = 98;
            this.label70.Text = "Positive Pattern";
            // 
            // numericUpDownExt4
            // 
            this.numericUpDownExt4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt4.Location = new System.Drawing.Point(107, 235);
            this.numericUpDownExt4.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownExt4.Name = "numericUpDownExt4";
            this.numericUpDownExt4.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownExt4.TabIndex = 105;
            this.numericUpDownExt4.ValueChanged += new System.EventHandler(this.numericUpDownExt4_ValueChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label39);
            this.gradientPanel1.Controls.Add(this.label41);
            this.gradientPanel1.Controls.Add(this.doubleTextBox1);
            this.gradientPanel1.Controls.Add(this.gradientPanel6);
            this.gradientPanel1.Controls.Add(this.label52);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.label53);
            this.gradientPanel1.Controls.Add(this.integerTextBox3);
            this.gradientPanel1.Controls.Add(this.label54);
            this.gradientPanel1.Controls.Add(this.label55);
            this.gradientPanel1.Controls.Add(this.textBox3);
            this.gradientPanel1.Controls.Add(this.numericUpDownExt2);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(426, 8);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(193, 278);
            this.gradientPanel1.TabIndex = 120;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label39.Image = ((System.Drawing.Image)(resources.GetObject("label39.Image")));
            this.label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label39.Location = new System.Drawing.Point(3, 115);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(82, 24);
            this.label39.TabIndex = 127;
            this.label39.Text = "Properties";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label41.Location = new System.Drawing.Point(83, 128);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(74, 1);
            this.label41.TabIndex = 126;
            // 
            // doubleTextBox1
            // 
            bannerTextInfo4.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo4.Text = "<Value>";
            bannerTextInfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.doubleTextBox1, bannerTextInfo4);
            this.doubleTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.doubleTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleTextBox1.DoubleValue = 1;
            this.doubleTextBox1.Location = new System.Drawing.Point(56, 77);
            this.doubleTextBox1.Name = "doubleTextBox1";
            this.doubleTextBox1.NegativeInputPendingOnSelectAll = false;
            this.doubleTextBox1.NullString = "";
            this.doubleTextBox1.NumberGroupSizes = new int[] {
        2};
            this.doubleTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.doubleTextBox1.Size = new System.Drawing.Size(73, 20);
            this.doubleTextBox1.TabIndex = 0;
            this.doubleTextBox1.UseNullString = true;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.label33);
            this.gradientPanel6.Controls.Add(this.label37);
            this.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(191, 76);
            this.gradientPanel6.TabIndex = 122;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label33.Location = new System.Drawing.Point(0, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(191, 58);
            this.label33.TabIndex = 1;
            this.label33.Text = "The DoubleTextBox supports display and collection of double values.";
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Top;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(191, 18);
            this.label37.TabIndex = 123;
            this.label37.Text = "DoubleTextBox";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(11, 148);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(94, 14);
            this.label52.TabIndex = 63;
            this.label52.Text = "Decimal separator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = ".";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(11, 180);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(73, 14);
            this.label53.TabIndex = 65;
            this.label53.Text = "Decimal Digits";
            // 
            // integerTextBox3
            // 
            this.integerTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.integerTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox3.IntegerValue = ((long)(2));
            this.integerTextBox3.Location = new System.Drawing.Point(111, 177);
            this.integerTextBox3.Name = "integerTextBox3";
            this.integerTextBox3.NegativeInputPendingOnSelectAll = false;
            this.integerTextBox3.NullString = "0";
            this.integerTextBox3.OverflowIndicatorToolTipText = null;
            this.integerTextBox3.Size = new System.Drawing.Size(46, 20);
            this.integerTextBox3.TabIndex = 66;
            this.integerTextBox3.ThemesEnabled = false;
            this.integerTextBox3.TextChanged += new System.EventHandler(this.integerTextBox3_TextChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(11, 212);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(88, 14);
            this.label54.TabIndex = 67;
            this.label54.Text = "Group Separator";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(11, 244);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(67, 14);
            this.label55.TabIndex = 69;
            this.label55.Text = "Group Sizes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 71;
            this.textBox3.Text = ",";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Location = new System.Drawing.Point(111, 241);
            this.numericUpDownExt2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownExt2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExt2.TabIndex = 103;
            this.numericUpDownExt2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.buttonBanner);
            this.tabPageAdv3.Controls.Add(this.comboMode);
            this.tabPageAdv3.Controls.Add(this.bEditBanner);
            this.tabPageAdv3.Controls.Add(this.textBanner);
            this.tabPageAdv3.Controls.Add(this.label136);
            this.tabPageAdv3.Controls.Add(this.label135);
            this.tabPageAdv3.Controls.Add(this.label134);
            this.tabPageAdv3.Controls.Add(this.label133);
            this.tabPageAdv3.Controls.Add(this.label75);
            this.tabPageAdv3.Controls.Add(this.comboBox19);
            this.tabPageAdv3.Controls.Add(this.panel1);
            this.tabPageAdv3.Controls.Add(this.radioButton2);
            this.tabPageAdv3.Controls.Add(this.radioButton1);
            this.tabPageAdv3.Controls.Add(this.label14);
            this.tabPageAdv3.Controls.Add(this.groupBox3);
            this.tabPageAdv3.Controls.Add(this.groupBox2);
            this.tabPageAdv3.Controls.Add(this.label88);
            this.tabPageAdv3.Controls.Add(this.label84);
            this.tabPageAdv3.Controls.Add(this.label89);
            this.tabPageAdv3.Controls.Add(this.DomainBorderColorEdit);
            this.tabPageAdv3.Controls.Add(this.checkBox14);
            this.tabPageAdv3.Controls.Add(this.dataGrid2);
            this.tabPageAdv3.Controls.Add(this.checkBox19);
            this.tabPageAdv3.Controls.Add(this.label28);
            this.tabPageAdv3.Controls.Add(this.label91);
            this.tabPageAdv3.Controls.Add(this.label32);
            this.tabPageAdv3.Controls.Add(this.label92);
            this.tabPageAdv3.Controls.Add(this.label29);
            this.tabPageAdv3.Controls.Add(this.checkBox15);
            this.tabPageAdv3.Controls.Add(this.label27);
            this.tabPageAdv3.Controls.Add(this.label30);
            this.tabPageAdv3.Controls.Add(this.label36);
            this.tabPageAdv3.Controls.Add(this.label87);
            this.tabPageAdv3.Controls.Add(this.comboBox4);
            this.tabPageAdv3.Controls.Add(this.comboBox3);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv3.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "UpDownExt Controls";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // buttonBanner
            // 
            this.buttonBanner.Location = new System.Drawing.Point(253, 427);
            this.buttonBanner.Name = "buttonBanner";
            this.buttonBanner.Size = new System.Drawing.Size(99, 23);
            this.buttonBanner.TabIndex = 2;
            this.buttonBanner.Text = "Set Banner Text";
            this.buttonBanner.UseVisualStyleBackColor = true;
            this.buttonBanner.Click += new System.EventHandler(this.buttonBanner_Click);
            // 
            // comboMode
            // 
            this.comboMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboMode.IgnoreThemeBackground = true;
            this.comboMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.comboMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboMode, "EditMode"));
            this.comboMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboMode, "FocusMode"));
            this.comboMode.Location = new System.Drawing.Point(274, 337);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(101, 21);
            this.comboMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboMode.TabIndex = 138;
            // 
            // bEditBanner
            // 
            this.bEditBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bEditBanner.Buttons.Add(this.buttonEditChildButton11);
            this.bEditBanner.Controls.Add(this.buttonEditChildButton11);
            this.bEditBanner.Controls.Add(this.textBoxExt7);
            this.bEditBanner.Location = new System.Drawing.Point(274, 379);
            this.bEditBanner.Name = "bEditBanner";
            this.bEditBanner.ShowTextBox = false;
            this.bEditBanner.Size = new System.Drawing.Size(100, 22);
            this.bEditBanner.TabIndex = 137;
            this.bEditBanner.TextBox = this.textBoxExt7;
            this.bEditBanner.UseVisualStyle = true;
            this.bEditBanner.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bEditBanner_ButtonClicked);
            // 
            // buttonEditChildButton11
            // 
            this.buttonEditChildButton11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton11.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton11.Image = null;
            this.buttonEditChildButton11.Name = "buttonEditChildButton11";
            this.buttonEditChildButton11.PreferredWidth = 20;
            this.buttonEditChildButton11.TabIndex = 1;
            this.buttonEditChildButton11.Text = "...";
            // 
            // textBoxExt7
            // 
            this.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt7.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt7.Name = "textBoxExt7";
            this.textBoxExt7.OverflowIndicatorToolTipText = null;
            this.textBoxExt7.Size = new System.Drawing.Size(95, 14);
            this.textBoxExt7.TabIndex = 0;
            // 
            // textBanner
            // 
            this.textBanner.Location = new System.Drawing.Point(274, 302);
            this.textBanner.Name = "textBanner";
            this.textBanner.Size = new System.Drawing.Size(100, 21);
            this.textBanner.TabIndex = 136;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(225, 384);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(32, 13);
            this.label136.TabIndex = 135;
            this.label136.Text = "Color";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(225, 341);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(33, 13);
            this.label135.TabIndex = 134;
            this.label135.Text = "Mode";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(225, 305);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(29, 13);
            this.label134.TabIndex = 133;
            this.label134.Text = "Text";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(412, 437);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(102, 13);
            this.label133.TabIndex = 132;
            this.label133.Text = "Office2007 Style:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(409, 379);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(97, 26);
            this.label75.TabIndex = 131;
            this.label75.Text = "DomainUpdownExt\r\nSpin Orientation";
            // 
            // comboBox19
            // 
            this.comboBox19.BackColor = System.Drawing.Color.White;
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.ForeColor = System.Drawing.Color.Black;
            this.comboBox19.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBox19.Location = new System.Drawing.Point(412, 408);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(137, 21);
            this.comboBox19.TabIndex = 130;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.UpdownExtSpinOrientation_Changed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(412, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 96);
            this.panel1.TabIndex = 129;
            // 
            // radioButton12
            // 
            this.radioButton12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(3, 72);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(141, 15);
            this.radioButton12.TabIndex = 56;
            this.radioButton12.Text = "Managed Color Scheme";
            this.radioButton12.CheckedChanged += new System.EventHandler(this.OfficeStyle_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(3, 51);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(126, 15);
            this.radioButton5.TabIndex = 55;
            this.radioButton5.Text = "Black Color Scheme";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.OfficeStyle_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(3, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 15);
            this.radioButton4.TabIndex = 54;
            this.radioButton4.Text = "Silver Color Scheme";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.OfficeStyle_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(3, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 15);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.Text = "Blue Color Scheme";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.OfficeStyle_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(111, 329);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 25);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.Text = "Fixed3D";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(111, 305);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 18);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FixedSingle";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 128;
            this.label14.Text = "Border Style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownExt7);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(236)))));
            this.groupBox3.Location = new System.Drawing.Point(455, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 142);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NumericUpDownExt";
            // 
            // numericUpDownExt7
            // 
            bannerTextInfo5.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo5.Text = "<value>";
            bannerTextInfo5.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.numericUpDownExt7, bannerTextInfo5);
            this.numericUpDownExt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt7.Location = new System.Drawing.Point(107, 90);
            this.numericUpDownExt7.Name = "numericUpDownExt7";
            this.numericUpDownExt7.Size = new System.Drawing.Size(136, 21);
            this.numericUpDownExt7.TabIndex = 124;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label24.Location = new System.Drawing.Point(3, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(329, 56);
            this.label24.TabIndex = 1;
            this.label24.Text = "NumericUpdownExt is an advanced NumericUpdown control to increment/decrement nume" +
                "ric values. It enables XP Themed look-and-feel for the UpDown.\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.domainUpDownExt1);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(236)))));
            this.groupBox2.Location = new System.Drawing.Point(58, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 142);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DomainUpDownExt";
            // 
            // domainUpDownExt1
            // 
            bannerTextInfo6.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo6.Text = "<Value>";
            bannerTextInfo6.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.domainUpDownExt1, bannerTextInfo6);
            this.domainUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDownExt1.Items.Add("Item1");
            this.domainUpDownExt1.Items.Add("Item2");
            this.domainUpDownExt1.Items.Add("Item3");
            this.domainUpDownExt1.Items.Add("Item4");
            this.domainUpDownExt1.Items.Add("Item5");
            this.domainUpDownExt1.Location = new System.Drawing.Point(80, 90);
            this.domainUpDownExt1.Name = "domainUpDownExt1";
            this.domainUpDownExt1.Size = new System.Drawing.Size(135, 21);
            this.domainUpDownExt1.TabIndex = 52;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Dock = System.Windows.Forms.DockStyle.Top;
            this.label66.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label66.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label66.Location = new System.Drawing.Point(3, 17);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(313, 56);
            this.label66.TabIndex = 1;
            this.label66.Text = "DomainUpDownEx is an advanced DomainUpDown control to increment/decrement string " +
                "values. It enables XP Themed look-and-feel for the UpDown.\r\n";
            // 
            // label88
            // 
            this.label88.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label88.Image = ((System.Drawing.Image)(resources.GetObject("label88.Image")));
            this.label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label88.Location = new System.Drawing.Point(225, 255);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(149, 24);
            this.label88.TabIndex = 87;
            this.label88.Text = "BannerText Settings";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label84
            // 
            this.label84.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label84.Image = ((System.Drawing.Image)(resources.GetObject("label84.Image")));
            this.label84.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label84.Location = new System.Drawing.Point(409, 256);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(66, 24);
            this.label84.TabIndex = 89;
            this.label84.Text = "General";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label89
            // 
            this.label89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label89.Location = new System.Drawing.Point(225, 279);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(150, 1);
            this.label89.TabIndex = 86;
            // 
            // DomainBorderColorEdit
            // 
            this.DomainBorderColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DomainBorderColorEdit.Buttons.Add(this.buttonEditChildButton6);
            this.DomainBorderColorEdit.Controls.Add(this.buttonEditChildButton6);
            this.DomainBorderColorEdit.Location = new System.Drawing.Point(110, 461);
            this.DomainBorderColorEdit.Name = "DomainBorderColorEdit";
            this.DomainBorderColorEdit.ShowTextBox = false;
            this.DomainBorderColorEdit.Size = new System.Drawing.Size(82, 27);
            this.DomainBorderColorEdit.TabIndex = 120;
            this.DomainBorderColorEdit.UseVisualStyle = true;
            this.DomainBorderColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.DomainBorderColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // checkBox14
            // 
            this.checkBox14.Location = new System.Drawing.Point(412, 305);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(137, 24);
            this.checkBox14.TabIndex = 48;
            this.checkBox14.Text = "ThemesEnabled";
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(576, 355);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(235, 133);
            this.dataGrid2.TabIndex = 94;
            // 
            // checkBox19
            // 
            this.checkBox19.Location = new System.Drawing.Point(591, 305);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(147, 24);
            this.checkBox19.TabIndex = 92;
            this.checkBox19.Text = "Bind To DataBase";
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(30, 359);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 13);
            this.label28.TabIndex = 28;
            this.label28.Text = "Border3D Style";
            // 
            // label91
            // 
            this.label91.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label91.Image = ((System.Drawing.Image)(resources.GetObject("label91.Image")));
            this.label91.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label91.Location = new System.Drawing.Point(30, 255);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(114, 24);
            this.label91.TabIndex = 85;
            this.label91.Text = "Border Settings";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label32.Location = new System.Drawing.Point(591, 281);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(150, 1);
            this.label32.TabIndex = 95;
            // 
            // label92
            // 
            this.label92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label92.Location = new System.Drawing.Point(30, 279);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(150, 1);
            this.label92.TabIndex = 84;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(29, 409);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 13);
            this.label29.TabIndex = 29;
            this.label29.Text = "Border Sides";
            // 
            // checkBox15
            // 
            this.checkBox15.Checked = true;
            this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox15.Location = new System.Drawing.Point(412, 335);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(126, 24);
            this.checkBox15.TabIndex = 49;
            this.checkBox15.Text = "InterceptArrowKeys";
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(591, 257);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 24);
            this.label27.TabIndex = 96;
            this.label27.Text = "Data Binding";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 461);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Border Color";
            // 
            // label36
            // 
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.Location = new System.Drawing.Point(536, 338);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 20);
            this.label36.TabIndex = 50;
            this.toolTip1.SetToolTip(this.label36, "Allows users to to use the UP ARROW and DOWN ARROW keys to select values.");
            // 
            // label87
            // 
            this.label87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label87.Location = new System.Drawing.Point(409, 280);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(140, 1);
            this.label87.TabIndex = 88;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox4.Location = new System.Drawing.Point(110, 409);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(84, 21);
            this.comboBox4.TabIndex = 41;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.Location = new System.Drawing.Point(111, 360);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(84, 21);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.checkBox32);
            this.tabPageAdv5.Controls.Add(this.checkBox31);
            this.tabPageAdv5.Controls.Add(this.numericUpDownExt6);
            this.tabPageAdv5.Controls.Add(this.label137);
            this.tabPageAdv5.Controls.Add(this.button1);
            this.tabPageAdv5.Controls.Add(this.bannerClrEdit);
            this.tabPageAdv5.Controls.Add(this.rdoFocus);
            this.tabPageAdv5.Controls.Add(this.rdoEdit);
            this.tabPageAdv5.Controls.Add(this.txtBanner);
            this.tabPageAdv5.Controls.Add(this.label127);
            this.tabPageAdv5.Controls.Add(this.label124);
            this.tabPageAdv5.Controls.Add(this.label99);
            this.tabPageAdv5.Controls.Add(this.label77);
            this.tabPageAdv5.Controls.Add(this.label78);
            this.tabPageAdv5.Controls.Add(this.groupBox4);
            this.tabPageAdv5.Controls.Add(this.label109);
            this.tabPageAdv5.Controls.Add(this.checkBox21);
            this.tabPageAdv5.Controls.Add(this.label31);
            this.tabPageAdv5.Controls.Add(this.label103);
            this.tabPageAdv5.Controls.Add(this.label107);
            this.tabPageAdv5.Controls.Add(this.checkBox22);
            this.tabPageAdv5.Controls.Add(this.buttonEdit2);
            this.tabPageAdv5.Controls.Add(this.label108);
            this.tabPageAdv5.Controls.Add(this.label106);
            this.tabPageAdv5.Controls.Add(this.checkBox23);
            this.tabPageAdv5.Controls.Add(this.label115);
            this.tabPageAdv5.Controls.Add(this.comboBox12);
            this.tabPageAdv5.Controls.Add(this.comboBox11);
            this.tabPageAdv5.Controls.Add(this.checkBox24);
            this.tabPageAdv5.Controls.Add(this.label113);
            this.tabPageAdv5.Controls.Add(this.comboBox9);
            this.tabPageAdv5.Controls.Add(this.comboBox10);
            this.tabPageAdv5.Controls.Add(this.checkBox25);
            this.tabPageAdv5.Controls.Add(this.label114);
            this.tabPageAdv5.Controls.Add(this.label101);
            this.tabPageAdv5.Controls.Add(this.label105);
            this.tabPageAdv5.Controls.Add(this.checkBox26);
            this.tabPageAdv5.Controls.Add(this.label111);
            this.tabPageAdv5.Controls.Add(this.comboBox8);
            this.tabPageAdv5.Controls.Add(this.radioButton11);
            this.tabPageAdv5.Controls.Add(this.label102);
            this.tabPageAdv5.Controls.Add(this.label112);
            this.tabPageAdv5.Controls.Add(this.label100);
            this.tabPageAdv5.Controls.Add(this.radioButton10);
            this.tabPageAdv5.Controls.Add(this.textBox11);
            this.tabPageAdv5.Controls.Add(this.label104);
            this.tabPageAdv5.Controls.Add(this.label110);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv5.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "TextBoxExt";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Checked = true;
            this.checkBox32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox32.Location = new System.Drawing.Point(638, 478);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(72, 17);
            this.checkBox32.TabIndex = 146;
            this.checkBox32.Text = "FarImage";
            this.checkBox32.UseVisualStyleBackColor = true;
            this.checkBox32.CheckedChanged += new System.EventHandler(this.checkBox32_CheckedChanged);
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Checked = true;
            this.checkBox31.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox31.Location = new System.Drawing.Point(724, 480);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(82, 17);
            this.checkBox31.TabIndex = 145;
            this.checkBox31.Text = "Near Image";
            this.checkBox31.UseVisualStyleBackColor = true;
            this.checkBox31.CheckedChanged += new System.EventHandler(this.checkBox31_CheckedChanged);
            // 
            // numericUpDownExt6
            // 
            this.numericUpDownExt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt6.Location = new System.Drawing.Point(111, 383);
            this.numericUpDownExt6.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt6.Name = "numericUpDownExt6";
            this.numericUpDownExt6.Size = new System.Drawing.Size(91, 21);
            this.numericUpDownExt6.TabIndex = 144;
            this.numericUpDownExt6.ValueChanged += new System.EventHandler(this.numericUpDownExt6_ValueChanged);
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(21, 383);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(81, 13);
            this.label137.TabIndex = 139;
            this.label137.Text = "Corner Radious";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(345, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 138;
            this.button1.Text = "Set Banner Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton9);
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton9);
            this.bannerClrEdit.Controls.Add(this.textBoxExt5);
            this.bannerClrEdit.Location = new System.Drawing.Point(303, 478);
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.ShowTextBox = false;
            this.bannerClrEdit.Size = new System.Drawing.Size(125, 22);
            this.bannerClrEdit.TabIndex = 137;
            this.bannerClrEdit.TextBox = this.textBoxExt5;
            this.bannerClrEdit.UseVisualStyle = true;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton9
            // 
            this.buttonEditChildButton9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton9.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton9.Image = null;
            this.buttonEditChildButton9.Name = "buttonEditChildButton9";
            this.buttonEditChildButton9.PreferredWidth = 20;
            this.buttonEditChildButton9.TabIndex = 1;
            this.buttonEditChildButton9.Text = "...";
            // 
            // textBoxExt5
            // 
            this.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt5.Location = new System.Drawing.Point(3, 4);
            this.textBoxExt5.Name = "textBoxExt5";
            this.textBoxExt5.OverflowIndicatorToolTipText = null;
            this.textBoxExt5.Size = new System.Drawing.Size(95, 14);
            this.textBoxExt5.TabIndex = 0;
            // 
            // rdoFocus
            // 
            this.rdoFocus.AutoSize = true;
            this.rdoFocus.Checked = true;
            this.rdoFocus.Location = new System.Drawing.Point(502, 480);
            this.rdoFocus.Name = "rdoFocus";
            this.rdoFocus.Size = new System.Drawing.Size(82, 17);
            this.rdoFocus.TabIndex = 136;
            this.rdoFocus.TabStop = true;
            this.rdoFocus.Text = "Focus Mode";
            this.rdoFocus.UseVisualStyleBackColor = true;
            // 
            // rdoEdit
            // 
            this.rdoEdit.AutoSize = true;
            this.rdoEdit.Location = new System.Drawing.Point(502, 451);
            this.rdoEdit.Name = "rdoEdit";
            this.rdoEdit.Size = new System.Drawing.Size(72, 17);
            this.rdoEdit.TabIndex = 135;
            this.rdoEdit.TabStop = true;
            this.rdoEdit.Text = "Edit Mode";
            this.rdoEdit.UseVisualStyleBackColor = true;
            // 
            // txtBanner
            // 
            this.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanner.Location = new System.Drawing.Point(303, 449);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(125, 21);
            this.txtBanner.TabIndex = 134;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(448, 451);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(33, 13);
            this.label127.TabIndex = 133;
            this.label127.Text = "Mode";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(259, 480);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(32, 13);
            this.label124.TabIndex = 132;
            this.label124.Text = "Color";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(255, 449);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(29, 13);
            this.label99.TabIndex = 131;
            this.label99.Text = "Text";
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label77.Image = ((System.Drawing.Image)(resources.GetObject("label77.Image")));
            this.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label77.Location = new System.Drawing.Point(235, 409);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(150, 24);
            this.label77.TabIndex = 130;
            this.label77.Text = "Banner Text Settings";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label78.Location = new System.Drawing.Point(259, 435);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(320, 1);
            this.label78.TabIndex = 129;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBoxExt4);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(236)))));
            this.groupBox4.Location = new System.Drawing.Point(235, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 207);
            this.groupBox4.TabIndex = 128;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TextBoxExt";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.Location = new System.Drawing.Point(3, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(333, 56);
            this.label25.TabIndex = 1;
            this.label25.Text = "TextBoxExt is an advanced Textbox control that supports different border colors a" +
                "nd styles, options to show text overflow indicators and over flow indicator tool" +
                "tips. ";
            // 
            // textBoxExt4
            // 
            bannerTextInfo7.Text = "<Text>";
            bannerTextInfo7.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.textBoxExt4, bannerTextInfo7);
            this.textBoxExt4.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt4.FarImage = ((System.Drawing.Image)(resources.GetObject("textBoxExt4.FarImage")));
            this.textBoxExt4.Location = new System.Drawing.Point(42, 76);
            this.textBoxExt4.MinimumSize = new System.Drawing.Size(22, 18);
            this.textBoxExt4.Name = "textBoxExt4";
            this.textBoxExt4.NearImage = ((System.Drawing.Image)(resources.GetObject("textBoxExt4.NearImage")));
            this.textBoxExt4.OverflowIndicatorToolTipText = null;
            this.textBoxExt4.ShowOverflowIndicatorToolTip = true;
            this.textBoxExt4.Size = new System.Drawing.Size(242, 21);
            this.textBoxExt4.TabIndex = 0;
            this.textBoxExt4.ThemesEnabled = false;
            // 
            // label109
            // 
            this.label109.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label109.Image = ((System.Drawing.Image)(resources.GetObject("label109.Image")));
            this.label109.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label109.Location = new System.Drawing.Point(421, 281);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(126, 24);
            this.label109.TabIndex = 100;
            this.label109.Text = "OverflowIndicator";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox21
            // 
            this.checkBox21.Location = new System.Drawing.Point(421, 330);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(63, 24);
            this.checkBox21.TabIndex = 61;
            this.checkBox21.Text = "Visible";
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // label31
            // 
            this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
            this.label31.Location = new System.Drawing.Point(484, 331);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 20);
            this.label31.TabIndex = 122;
            this.toolTip1.SetToolTip(this.label31, "Set the multiLine property as False and enter lengthy text in the \r\nTextBoxExt to" +
                    " view the OverFlowIndicator.\r\n");
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label103.Image = ((System.Drawing.Image)(resources.GetObject("label103.Image")));
            this.label103.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label103.Location = new System.Drawing.Point(21, 281);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(114, 24);
            this.label103.TabIndex = 84;
            this.label103.Text = "Border Settings";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(21, 429);
            this.label107.Margin = new System.Windows.Forms.Padding(0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(79, 13);
            this.label107.TabIndex = 76;
            this.label107.Text = "Border3D Style";
            // 
            // checkBox22
            // 
            this.checkBox22.Checked = true;
            this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox22.Location = new System.Drawing.Point(303, 326);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(85, 24);
            this.checkBox22.TabIndex = 92;
            this.checkBox22.Text = "Word Wrap";
            this.checkBox22.CheckedChanged += new System.EventHandler(this.checkBox22_CheckedChanged);
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackColor = System.Drawing.Color.White;
            this.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit2.Controls.Add(this.textBoxExt3);
            this.buttonEdit2.Location = new System.Drawing.Point(111, 529);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(95, 22);
            this.buttonEdit2.TabIndex = 121;
            this.buttonEdit2.TextBox = this.textBoxExt3;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BackColor = System.Drawing.Color.White;
            this.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt3.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.OverflowIndicatorToolTipText = null;
            this.textBoxExt3.ShowOverflowIndicatorToolTip = true;
            this.textBoxExt3.Size = new System.Drawing.Size(97, 14);
            this.textBoxExt3.TabIndex = 0;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(638, 383);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(55, 13);
            this.label108.TabIndex = 91;
            this.label108.Text = "Text Align";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(21, 479);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(67, 13);
            this.label106.TabIndex = 77;
            this.label106.Text = "Border Sides";
            // 
            // checkBox23
            // 
            this.checkBox23.Location = new System.Drawing.Point(724, 425);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(89, 24);
            this.checkBox23.TabIndex = 93;
            this.checkBox23.Text = "Right To Left";
            this.checkBox23.CheckedChanged += new System.EventHandler(this.checkBox23_CheckedChanged);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(21, 530);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(67, 13);
            this.label115.TabIndex = 120;
            this.label115.Text = "Border Color";
            // 
            // comboBox12
            // 
            this.comboBox12.BackColor = System.Drawing.Color.White;
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.ForeColor = System.Drawing.Color.Black;
            this.comboBox12.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox12.Location = new System.Drawing.Point(738, 372);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(75, 21);
            this.comboBox12.TabIndex = 90;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.BackColor = System.Drawing.Color.White;
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.Enabled = false;
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.ForeColor = System.Drawing.Color.Black;
            this.comboBox11.Location = new System.Drawing.Point(111, 427);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(95, 21);
            this.comboBox11.TabIndex = 78;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // checkBox24
            // 
            this.checkBox24.Location = new System.Drawing.Point(638, 425);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(112, 24);
            this.checkBox24.TabIndex = 94;
            this.checkBox24.Text = "Read Only";
            this.checkBox24.CheckedChanged += new System.EventHandler(this.checkBox24_CheckedChanged);
            // 
            // label113
            // 
            this.label113.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label113.Image = ((System.Drawing.Image)(resources.GetObject("label113.Image")));
            this.label113.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label113.Location = new System.Drawing.Point(638, 281);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(75, 24);
            this.label113.TabIndex = 104;
            this.label113.Text = "General";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.ForeColor = System.Drawing.Color.Black;
            this.comboBox9.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.comboBox9.Location = new System.Drawing.Point(286, 369);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(96, 21);
            this.comboBox9.TabIndex = 88;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.White;
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.ForeColor = System.Drawing.Color.Black;
            this.comboBox10.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox10.Location = new System.Drawing.Point(111, 479);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(95, 21);
            this.comboBox10.TabIndex = 79;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // checkBox25
            // 
            this.checkBox25.Location = new System.Drawing.Point(238, 326);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(112, 24);
            this.checkBox25.TabIndex = 95;
            this.checkBox25.Text = "MultiLine";
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // label114
            // 
            this.label114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label114.Location = new System.Drawing.Point(638, 305);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(150, 1);
            this.label114.TabIndex = 103;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(232, 372);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(53, 13);
            this.label101.TabIndex = 87;
            this.label101.Text = "Scrollbars";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(21, 330);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(66, 13);
            this.label105.TabIndex = 80;
            this.label105.Text = "Border Style";
            // 
            // checkBox26
            // 
            this.checkBox26.Location = new System.Drawing.Point(520, 330);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(94, 24);
            this.checkBox26.TabIndex = 96;
            this.checkBox26.Text = "ToolTip visible";
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // label111
            // 
            this.label111.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label111.Image = ((System.Drawing.Image)(resources.GetObject("label111.Image")));
            this.label111.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label111.Location = new System.Drawing.Point(238, 281);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(84, 24);
            this.label111.TabIndex = 102;
            this.label111.Text = "MultiLine";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.ForeColor = System.Drawing.Color.Black;
            this.comboBox8.Items.AddRange(new object[] {
            "Normal",
            "Upper Case",
            "Lower Case"});
            this.comboBox8.Location = new System.Drawing.Point(734, 327);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(75, 21);
            this.comboBox8.TabIndex = 86;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(111, 328);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(83, 20);
            this.radioButton11.TabIndex = 81;
            this.radioButton11.Text = "FixedSingle";
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(418, 372);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(63, 13);
            this.label102.TabIndex = 97;
            this.label102.Text = "ToolTipText";
            // 
            // label112
            // 
            this.label112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label112.Location = new System.Drawing.Point(238, 306);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(150, 1);
            this.label112.TabIndex = 101;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(638, 331);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(90, 13);
            this.label100.TabIndex = 85;
            this.label100.Text = "Character Casing";
            // 
            // radioButton10
            // 
            this.radioButton10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(111, 352);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(74, 15);
            this.radioButton10.TabIndex = 82;
            this.radioButton10.Text = "Fixed3D";
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(487, 369);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(91, 21);
            this.textBox11.TabIndex = 98;
            this.textBox11.Text = "Text Overflowed";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label104
            // 
            this.label104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label104.Location = new System.Drawing.Point(21, 305);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(150, 1);
            this.label104.TabIndex = 83;
            // 
            // label110
            // 
            this.label110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label110.Location = new System.Drawing.Point(421, 309);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(150, 1);
            this.label110.TabIndex = 99;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.groupBox5);
            this.tabPageAdv2.Controls.Add(this.label15);
            this.tabPageAdv2.Controls.Add(this.label16);
            this.tabPageAdv2.Controls.Add(this.label86);
            this.tabPageAdv2.Controls.Add(this.comboBox1);
            this.tabPageAdv2.Controls.Add(this.radClassic);
            this.tabPageAdv2.Controls.Add(this.label85);
            this.tabPageAdv2.Controls.Add(this.label83);
            this.tabPageAdv2.Controls.Add(this.label17);
            this.tabPageAdv2.Controls.Add(this.label82);
            this.tabPageAdv2.Controls.Add(this.groupBox1);
            this.tabPageAdv2.Controls.Add(this.checkBox13);
            this.tabPageAdv2.Controls.Add(this.comboBox2);
            this.tabPageAdv2.Controls.Add(this.radOffice2000);
            this.tabPageAdv2.Controls.Add(this.radOffice2007);
            this.tabPageAdv2.Controls.Add(this.label23);
            this.tabPageAdv2.Controls.Add(this.label18);
            this.tabPageAdv2.Controls.Add(this.radOfficeXP);
            this.tabPageAdv2.Controls.Add(this.cboButtonType);
            this.tabPageAdv2.Controls.Add(this.label20);
            this.tabPageAdv2.Controls.Add(this.radWinXP);
            this.tabPageAdv2.Controls.Add(this.label21);
            this.tabPageAdv2.Controls.Add(this.label19);
            this.tabPageAdv2.Controls.Add(this.radOffice2003);
            this.tabPageAdv2.Controls.Add(this.checkBox18);
            this.tabPageAdv2.Controls.Add(this.label22);
            this.tabPageAdv2.Controls.Add(this.checkBox12);
            this.tabPageAdv2.Controls.Add(this.checkBox17);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Currency Edit";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.currencyEdit1);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(236)))));
            this.groupBox5.Location = new System.Drawing.Point(237, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 142);
            this.groupBox5.TabIndex = 129;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CurrencyEdit";
            // 
            // label65
            // 
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Dock = System.Windows.Forms.DockStyle.Top;
            this.label65.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label65.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label65.Location = new System.Drawing.Point(3, 17);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(320, 56);
            this.label65.TabIndex = 1;
            this.label65.Text = "Currency Edit is used to display currency values with a calculator button to disp" +
                "lay a dropdown calculator.\r\n";
            // 
            // currencyEdit1
            // 
            this.currencyEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.currencyEdit1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.currencyEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            // 
            // 
            // 
            this.currencyEdit1.CalculatorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currencyEdit1.CalculatorButton.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator;
            this.currencyEdit1.CalculatorButton.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.currencyEdit1.CalculatorButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.currencyEdit1.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("currencyEdit1.CalculatorButton.Image")));
            this.currencyEdit1.CalculatorButton.Name = "";
            this.currencyEdit1.CalculatorButton.PreferredWidth = 24;
            this.currencyEdit1.CalculatorButton.TabIndex = 1;
            this.currencyEdit1.CloseAction = Syncfusion.Windows.Forms.Tools.CalcActions.CalcOperatorEquals;
            this.currencyEdit1.FlatBorderColor = System.Drawing.SystemColors.ControlLight;
            this.currencyEdit1.Location = new System.Drawing.Point(55, 86);
            this.currencyEdit1.Name = "currencyEdit1";
            this.currencyEdit1.PopupCalculatorAlignment = Syncfusion.Windows.Forms.Tools.CalculatorPopupAlignment.Left;
            this.currencyEdit1.ShowCalculator = true;
            this.currencyEdit1.ShowTextBox = false;
            this.currencyEdit1.Size = new System.Drawing.Size(177, 22);
            this.currencyEdit1.TabIndex = 4;
            // 
            // 
            // 
            this.currencyEdit1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currencyEdit1.TextBox.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyEdit1.TextBox.Location = new System.Drawing.Point(2, 4);
            this.currencyEdit1.TextBox.Name = "";
            this.currencyEdit1.TextBox.NegativeInputPendingOnSelectAll = false;
            this.currencyEdit1.TextBox.NullString = "0";
            this.currencyEdit1.TextBox.OverflowIndicatorToolTipText = null;
            this.currencyEdit1.TextBox.Size = new System.Drawing.Size(91, 14);
            this.currencyEdit1.TextBox.TabIndex = 0;
            this.currencyEdit1.TextBox.Visible = false;
            this.currencyEdit1.UseVisualStyle = true;
            this.currencyEdit1.CalculatorShowing += new System.ComponentModel.CancelEventHandler(this.currencyEdit1_CalculatorShowing);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(27, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 24);
            this.label15.TabIndex = 26;
            this.label15.Text = "Culture Settings";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label16.Location = new System.Drawing.Point(27, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 1);
            this.label16.TabIndex = 25;
            // 
            // label86
            // 
            this.label86.Image = ((System.Drawing.Image)(resources.GetObject("label86.Image")));
            this.label86.Location = new System.Drawing.Point(774, 350);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(20, 20);
            this.label86.TabIndex = 94;
            this.toolTip1.SetToolTip(this.label86, "Specifies whether to transfer the calculated value to the edit control.\r\n");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(30, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radClassic
            // 
            this.radClassic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radClassic.Location = new System.Drawing.Point(450, 279);
            this.radClassic.Name = "radClassic";
            this.radClassic.Size = new System.Drawing.Size(96, 27);
            this.radClassic.TabIndex = 0;
            this.radClassic.Text = "Classic";
            this.radClassic.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // label85
            // 
            this.label85.Image = ((System.Drawing.Image)(resources.GetObject("label85.Image")));
            this.label85.Location = new System.Drawing.Point(774, 383);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(20, 20);
            this.label85.TabIndex = 52;
            this.toolTip1.SetToolTip(this.label85, "Specifies whether to transfer the value from the edit control to the calculator\r\n" +
                    "\r\n");
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label83.Location = new System.Drawing.Point(628, 264);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(150, 1);
            this.label83.TabIndex = 86;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Culture Full Name";
            // 
            // label82
            // 
            this.label82.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label82.Image = ((System.Drawing.Image)(resources.GetObject("label82.Image")));
            this.label82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label82.Location = new System.Drawing.Point(626, 235);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(66, 24);
            this.label82.TabIndex = 87;
            this.label82.Text = "Others";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radWinStd);
            this.groupBox1.Controls.Add(this.radFinancial);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(214, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 93);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator Type";
            // 
            // radWinStd
            // 
            this.radWinStd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWinStd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radWinStd.Location = new System.Drawing.Point(6, 20);
            this.radWinStd.Name = "radWinStd";
            this.radWinStd.Size = new System.Drawing.Size(132, 25);
            this.radWinStd.TabIndex = 33;
            this.radWinStd.Text = "Windows Standard";
            this.radWinStd.CheckedChanged += new System.EventHandler(this.radWinStd_CheckedChanged);
            // 
            // radFinancial
            // 
            this.radFinancial.Checked = true;
            this.radFinancial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFinancial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radFinancial.Location = new System.Drawing.Point(6, 56);
            this.radFinancial.Name = "radFinancial";
            this.radFinancial.Size = new System.Drawing.Size(132, 25);
            this.radFinancial.TabIndex = 34;
            this.radFinancial.TabStop = true;
            this.radFinancial.Text = "Financial";
            this.radFinancial.CheckedChanged += new System.EventHandler(this.radFinancial_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.ForeColor = System.Drawing.Color.Black;
            this.checkBox13.Location = new System.Drawing.Point(632, 427);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(146, 24);
            this.checkBox13.TabIndex = 41;
            this.checkBox13.Text = "Read Only";
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.Location = new System.Drawing.Point(30, 361);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // radOffice2000
            // 
            this.radOffice2000.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOffice2000.Location = new System.Drawing.Point(450, 396);
            this.radOffice2000.Name = "radOffice2000";
            this.radOffice2000.Size = new System.Drawing.Size(96, 27);
            this.radOffice2000.TabIndex = 1;
            this.radOffice2000.Text = "Office 2000";
            this.radOffice2000.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // radOffice2007
            // 
            this.radOffice2007.Checked = true;
            this.radOffice2007.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOffice2007.Location = new System.Drawing.Point(450, 474);
            this.radOffice2007.Name = "radOffice2007";
            this.radOffice2007.Size = new System.Drawing.Size(96, 27);
            this.radOffice2007.TabIndex = 2;
            this.radOffice2007.TabStop = true;
            this.radOffice2007.Text = "Office 2007";
            this.radOffice2007.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(632, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Button Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 341);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Culture Short Name";
            // 
            // radOfficeXP
            // 
            this.radOfficeXP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOfficeXP.Location = new System.Drawing.Point(450, 357);
            this.radOfficeXP.Name = "radOfficeXP";
            this.radOfficeXP.Size = new System.Drawing.Size(96, 27);
            this.radOfficeXP.TabIndex = 5;
            this.radOfficeXP.Text = "Office XP";
            this.radOfficeXP.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // cboButtonType
            // 
            this.cboButtonType.BackColor = System.Drawing.Color.White;
            this.cboButtonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboButtonType.ForeColor = System.Drawing.Color.Black;
            this.cboButtonType.Location = new System.Drawing.Point(635, 305);
            this.cboButtonType.Name = "cboButtonType";
            this.cboButtonType.Size = new System.Drawing.Size(143, 21);
            this.cboButtonType.TabIndex = 39;
            this.cboButtonType.SelectedIndexChanged += new System.EventHandler(this.cboButtonType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Location = new System.Drawing.Point(214, 263);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 1);
            this.label20.TabIndex = 31;
            // 
            // radWinXP
            // 
            this.radWinXP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWinXP.Location = new System.Drawing.Point(450, 318);
            this.radWinXP.Name = "radWinXP";
            this.radWinXP.Size = new System.Drawing.Size(96, 27);
            this.radWinXP.TabIndex = 6;
            this.radWinXP.Text = "Windows XP";
            this.radWinXP.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(435, 235);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "Button Style";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(214, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 24);
            this.label19.TabIndex = 32;
            this.label19.Text = "Calculator Settings";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radOffice2003
            // 
            this.radOffice2003.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOffice2003.Location = new System.Drawing.Point(450, 435);
            this.radOffice2003.Name = "radOffice2003";
            this.radOffice2003.Size = new System.Drawing.Size(96, 27);
            this.radOffice2003.TabIndex = 3;
            this.radOffice2003.Text = "Office 2003";
            this.radOffice2003.CheckedChanged += new System.EventHandler(this.ButtonStyle_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.ForeColor = System.Drawing.Color.Black;
            this.checkBox18.Location = new System.Drawing.Point(632, 387);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(148, 17);
            this.checkBox18.TabIndex = 91;
            this.checkBox18.Text = "TransferToCalculator";
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label22.Location = new System.Drawing.Point(435, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(150, 1);
            this.label22.TabIndex = 36;
            // 
            // checkBox12
            // 
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.ForeColor = System.Drawing.Color.Black;
            this.checkBox12.Location = new System.Drawing.Point(214, 285);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(120, 16);
            this.checkBox12.TabIndex = 35;
            this.checkBox12.Text = "Show Calculator";
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.Checked = true;
            this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox17.ForeColor = System.Drawing.Color.Black;
            this.checkBox17.Location = new System.Drawing.Point(632, 348);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(146, 16);
            this.checkBox17.TabIndex = 90;
            this.checkBox17.Text = "TransferFromCalculator";
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv6.Controls.Add(this.checkBox28);
            this.tabPageAdv6.Controls.Add(this.label123);
            this.tabPageAdv6.Controls.Add(this.checkBox27);
            this.tabPageAdv6.Controls.Add(this.comboBox13);
            this.tabPageAdv6.Controls.Add(this.label117);
            this.tabPageAdv6.Controls.Add(this.gradientPanel4);
            this.tabPageAdv6.Controls.Add(this.label118);
            this.tabPageAdv6.Controls.Add(this.label119);
            this.tabPageAdv6.Controls.Add(this.label120);
            this.tabPageAdv6.Controls.Add(this.label121);
            this.tabPageAdv6.Controls.Add(this.editableList2);
            this.tabPageAdv6.Controls.Add(this.gradientPanel3);
            this.tabPageAdv6.Controls.Add(this.editableList1);
            this.tabPageAdv6.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv6.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv6.TabIndex = 6;
            this.tabPageAdv6.Text = "Editable List";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // checkBox28
            // 
            this.checkBox28.Location = new System.Drawing.Point(548, 283);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(89, 24);
            this.checkBox28.TabIndex = 87;
            this.checkBox28.Text = "Right To Left";
            this.checkBox28.CheckedChanged += new System.EventHandler(this.checkBox28_CheckedChanged);
            // 
            // label123
            // 
            this.label123.Image = ((System.Drawing.Image)(resources.GetObject("label123.Image")));
            this.label123.Location = new System.Drawing.Point(422, 287);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(20, 20);
            this.label123.TabIndex = 86;
            this.toolTip1.SetToolTip(this.label123, "Shows/Hides the button that appears to the right while editing.");
            // 
            // checkBox27
            // 
            this.checkBox27.Checked = true;
            this.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox27.Location = new System.Drawing.Point(327, 283);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(89, 24);
            this.checkBox27.TabIndex = 85;
            this.checkBox27.Text = "Want Button";
            this.checkBox27.CheckedChanged += new System.EventHandler(this.checkBox27_CheckedChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.ForeColor = System.Drawing.Color.Black;
            this.comboBox13.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox13.Location = new System.Drawing.Point(169, 280);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(75, 21);
            this.comboBox13.TabIndex = 84;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(71, 283);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(92, 13);
            this.label117.TabIndex = 83;
            this.label117.Text = "ListBox Text Align";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.label122);
            this.gradientPanel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel4.Location = new System.Drawing.Point(169, 403);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(449, 48);
            this.gradientPanel4.TabIndex = 82;
            // 
            // label122
            // 
            this.label122.BackColor = System.Drawing.Color.Transparent;
            this.label122.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label122.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label122.Image = ((System.Drawing.Image)(resources.GetObject("label122.Image")));
            this.label122.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label122.Location = new System.Drawing.Point(0, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(447, 46);
            this.label122.TabIndex = 1;
            this.label122.Text = "Drag file names from Windows Explorer and drop them into EditableList. \r\nDouble C" +
                "lick on to any item to edit";
            // 
            // label118
            // 
            this.label118.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label118.Image = ((System.Drawing.Image)(resources.GetObject("label118.Image")));
            this.label118.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label118.Location = new System.Drawing.Point(67, 237);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(86, 24);
            this.label118.TabIndex = 81;
            this.label118.Text = "Properties";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label119
            // 
            this.label119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label119.Location = new System.Drawing.Point(67, 261);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(650, 1);
            this.label119.TabIndex = 80;
            // 
            // label120
            // 
            this.label120.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label120.Image = ((System.Drawing.Image)(resources.GetObject("label120.Image")));
            this.label120.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label120.Location = new System.Drawing.Point(63, 365);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(109, 24);
            this.label120.TabIndex = 79;
            this.label120.Text = "Drag And Drop";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label121
            // 
            this.label121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label121.Location = new System.Drawing.Point(63, 389);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(650, 1);
            this.label121.TabIndex = 78;
            // 
            // editableList2
            // 
            this.editableList2.AllowDrop = true;
            this.editableList2.AutoScroll = true;
            // 
            // 
            // 
            this.editableList2.Button.BackColor = System.Drawing.Color.Azure;
            this.editableList2.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editableList2.Button.ImageList = this.imageList1;
            this.editableList2.Button.Location = new System.Drawing.Point(112, 120);
            this.editableList2.Button.Name = "button";
            this.editableList2.Button.Size = new System.Drawing.Size(30, 20);
            this.editableList2.Button.TabIndex = 2;
            this.editableList2.Button.Text = "...";
            this.editableList2.Button.UseVisualStyleBackColor = false;
            this.editableList2.Button.Visible = false;
            // 
            // 
            // 
            this.editableList2.ListBox.ColumnWidth = 1;
            this.editableList2.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editableList2.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.editableList2.ListBox.Location = new System.Drawing.Point(0, 0);
            this.editableList2.ListBox.Name = "listBox";
            this.editableList2.ListBox.Size = new System.Drawing.Size(354, 97);
            this.editableList2.ListBox.TabIndex = 0;
            this.editableList2.Location = new System.Drawing.Point(217, 457);
            this.editableList2.Name = "editableList2";
            this.editableList2.Size = new System.Drawing.Size(354, 97);
            this.editableList2.TabIndex = 9;
            // 
            // 
            // 
            this.editableList2.TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.editableList2.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editableList2.TextBox.Location = new System.Drawing.Point(8, 120);
            this.editableList2.TextBox.Name = "textBox";
            this.editableList2.TextBox.TabIndex = 2;
            this.editableList2.TextBox.Visible = false;
            this.editableList2.DragDrop += new System.Windows.Forms.DragEventHandler(this.editableList2_DragDrop);
            this.editableList2.DragEnter += new System.Windows.Forms.DragEventHandler(this.editableList2_DragEnter);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.label116);
            this.gradientPanel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel3.Location = new System.Drawing.Point(89, 16);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(602, 55);
            this.gradientPanel3.TabIndex = 8;
            // 
            // label116
            // 
            this.label116.BackColor = System.Drawing.Color.Transparent;
            this.label116.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label116.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label116.Image = ((System.Drawing.Image)(resources.GetObject("label116.Image")));
            this.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label116.Location = new System.Drawing.Point(0, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(600, 53);
            this.label116.TabIndex = 1;
            this.label116.Text = "EditableList control provides an editable Windows Forms list box with a Windows F" +
                "orms text box and button on \r\nthe current row to facilitate in-place editing.You" +
                " need to double Click on items to edit";
            // 
            // editableList1
            // 
            this.editableList1.AllowDrop = true;
            this.editableList1.AutoScroll = true;
            this.editableList1.BackColor = System.Drawing.Color.White;
            this.editableList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // 
            // 
            this.editableList1.Button.BackColor = System.Drawing.Color.Azure;
            this.editableList1.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editableList1.Button.ImageIndex = 0;
            this.editableList1.Button.Location = new System.Drawing.Point(448, 64);
            this.editableList1.Button.Name = "button";
            this.editableList1.Button.Size = new System.Drawing.Size(30, 20);
            this.editableList1.Button.TabIndex = 2;
            this.editableList1.Button.Text = "...";
            this.editableList1.Button.UseVisualStyleBackColor = false;
            this.editableList1.Button.Visible = false;
            this.editableList1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.editableList1.ListBox.ColumnWidth = 1;
            this.editableList1.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editableList1.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.editableList1.ListBox.Items.AddRange(new object[] {
            "C:\\Program Files\\Syncfusion\\Essential Suite\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\CS\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\VB\\"});
            this.editableList1.ListBox.Location = new System.Drawing.Point(0, 0);
            this.editableList1.ListBox.Name = "listBox";
            this.editableList1.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.editableList1.ListBox.Size = new System.Drawing.Size(354, 113);
            this.editableList1.ListBox.TabIndex = 0;
            this.editableList1.Location = new System.Drawing.Point(217, 94);
            this.editableList1.Name = "editableList1";
            this.editableList1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editableList1.Size = new System.Drawing.Size(354, 113);
            this.editableList1.TabIndex = 7;
            // 
            // 
            // 
            this.editableList1.TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.editableList1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editableList1.TextBox.Location = new System.Drawing.Point(2, 64);
            this.editableList1.TextBox.Name = "textBox";
            this.editableList1.TextBox.Size = new System.Drawing.Size(446, 21);
            this.editableList1.TextBox.TabIndex = 2;
            this.editableList1.TextBox.Visible = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.chkPullCharOnDelete);
            this.tabPageAdv4.Controls.Add(this.numericUpDownExt9);
            this.tabPageAdv4.Controls.Add(this.label139);
            this.tabPageAdv4.Controls.Add(this.comboBox18);
            this.tabPageAdv4.Controls.Add(this.label126);
            this.tabPageAdv4.Controls.Add(this.label79);
            this.tabPageAdv4.Controls.Add(this.checkBox29);
            this.tabPageAdv4.Controls.Add(this.comboBox16);
            this.tabPageAdv4.Controls.Add(this.checkBox30);
            this.tabPageAdv4.Controls.Add(this.comboBox17);
            this.tabPageAdv4.Controls.Add(this.label125);
            this.tabPageAdv4.Controls.Add(this.label98);
            this.tabPageAdv4.Controls.Add(this.comboBox15);
            this.tabPageAdv4.Controls.Add(this.buttonEdit3);
            this.tabPageAdv4.Controls.Add(this.label80);
            this.tabPageAdv4.Controls.Add(this.label81);
            this.tabPageAdv4.Controls.Add(this.label90);
            this.tabPageAdv4.Controls.Add(this.comboBox7);
            this.tabPageAdv4.Controls.Add(this.label93);
            this.tabPageAdv4.Controls.Add(this.label94);
            this.tabPageAdv4.Controls.Add(this.radioButton8);
            this.tabPageAdv4.Controls.Add(this.buttonEdit4);
            this.tabPageAdv4.Controls.Add(this.radioButton9);
            this.tabPageAdv4.Controls.Add(this.buttonEdit5);
            this.tabPageAdv4.Controls.Add(this.label95);
            this.tabPageAdv4.Controls.Add(this.comboBox14);
            this.tabPageAdv4.Controls.Add(this.label96);
            this.tabPageAdv4.Controls.Add(this.label97);
            this.tabPageAdv4.Controls.Add(this.label71);
            this.tabPageAdv4.Controls.Add(this.label74);
            this.tabPageAdv4.Controls.Add(this.groupBox6);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 26);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.Size = new System.Drawing.Size(835, 609);
            this.tabPageAdv4.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv4.TabIndex = 7;
            this.tabPageAdv4.Text = "Masked Edit";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // chkPullCharOnDelete
            // 
            this.chkPullCharOnDelete.Location = new System.Drawing.Point(101, 562);
            this.chkPullCharOnDelete.Name = "chkPullCharOnDelete";
            this.chkPullCharOnDelete.Size = new System.Drawing.Size(207, 24);
            this.chkPullCharOnDelete.TabIndex = 171;
            this.chkPullCharOnDelete.Text = "Pull Char On Delete";
            this.toolTip1.SetToolTip(this.chkPullCharOnDelete, "Pulls the adjacent character to the postion being deleted like MS MaskedTextBox.");
            this.chkPullCharOnDelete.CheckedChanged += new System.EventHandler(this.chkPullCharOnDelete_CheckedChanged);
            // 
            // numericUpDownExt9
            // 
            this.numericUpDownExt9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(178)))));
            this.numericUpDownExt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt9.Location = new System.Drawing.Point(556, 361);
            this.numericUpDownExt9.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt9.Name = "numericUpDownExt9";
            this.numericUpDownExt9.Size = new System.Drawing.Size(110, 21);
            this.numericUpDownExt9.TabIndex = 170;
            this.numericUpDownExt9.ValueChanged += new System.EventHandler(this.numericUpDownExt9_ValueChanged);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(472, 361);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(72, 13);
            this.label139.TabIndex = 169;
            this.label139.Text = "CornerRadius";
            // 
            // comboBox18
            // 
            this.comboBox18.BackColor = System.Drawing.Color.White;
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox18.ForeColor = System.Drawing.Color.Black;
            this.comboBox18.Items.AddRange(new object[] {
            "*",
            "#",
            "@"});
            this.comboBox18.Location = new System.Drawing.Point(223, 390);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(120, 21);
            this.comboBox18.TabIndex = 168;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(101, 393);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(104, 13);
            this.label126.TabIndex = 167;
            this.label126.Text = "Password Character";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(101, 428);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(55, 13);
            this.label79.TabIndex = 162;
            this.label79.Text = "Text Align";
            // 
            // checkBox29
            // 
            this.checkBox29.Location = new System.Drawing.Point(101, 521);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(112, 24);
            this.checkBox29.TabIndex = 163;
            this.checkBox29.Text = "Right To Left";
            this.checkBox29.CheckedChanged += new System.EventHandler(this.checkBox29_CheckedChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.BackColor = System.Drawing.Color.White;
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.ForeColor = System.Drawing.Color.Black;
            this.comboBox16.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox16.Location = new System.Drawing.Point(222, 425);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(121, 21);
            this.comboBox16.TabIndex = 161;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // checkBox30
            // 
            this.checkBox30.Location = new System.Drawing.Point(101, 469);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(112, 24);
            this.checkBox30.TabIndex = 164;
            this.checkBox30.Text = "Read Only";
            this.checkBox30.CheckedChanged += new System.EventHandler(this.checkBox30_CheckedChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.BackColor = System.Drawing.Color.White;
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.ForeColor = System.Drawing.Color.Black;
            this.comboBox17.Items.AddRange(new object[] {
            "Normal",
            "Upper Case",
            "Lower Case"});
            this.comboBox17.Location = new System.Drawing.Point(223, 349);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(120, 21);
            this.comboBox17.TabIndex = 160;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(101, 352);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(90, 13);
            this.label125.TabIndex = 159;
            this.label125.Text = "Character Casing";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(101, 305);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(31, 13);
            this.label98.TabIndex = 157;
            this.label98.Text = "Mask";
            // 
            // comboBox15
            // 
            this.comboBox15.BackColor = System.Drawing.Color.White;
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox15.ForeColor = System.Drawing.Color.Black;
            this.comboBox15.Items.AddRange(new object[] {
            "None",
            "##/##/####",
            "##.##",
            "###-########"});
            this.comboBox15.Location = new System.Drawing.Point(222, 305);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(120, 21);
            this.comboBox15.TabIndex = 156;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.textBoxExt2);
            this.buttonEdit3.Location = new System.Drawing.Point(556, 514);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(110, 22);
            this.buttonEdit3.TabIndex = 154;
            this.buttonEdit3.TextBox = this.textBoxExt2;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(97, 14);
            this.textBoxExt2.TabIndex = 0;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(472, 473);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(57, 13);
            this.label80.TabIndex = 141;
            this.label80.Text = "Back Color";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(472, 519);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(57, 13);
            this.label81.TabIndex = 142;
            this.label81.Text = "Fore Color";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(472, 571);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(67, 13);
            this.label90.TabIndex = 145;
            this.label90.Text = "Border Color";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Enabled = false;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox7.ForeColor = System.Drawing.Color.Black;
            this.comboBox7.Location = new System.Drawing.Point(558, 390);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(108, 21);
            this.comboBox7.TabIndex = 146;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label93
            // 
            this.label93.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label93.Image = ((System.Drawing.Image)(resources.GetObject("label93.Image")));
            this.label93.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label93.Location = new System.Drawing.Point(452, 247);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(142, 24);
            this.label93.TabIndex = 152;
            this.label93.Text = "Appearance Settings";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label94
            // 
            this.label94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label94.Location = new System.Drawing.Point(461, 271);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(250, 1);
            this.label94.TabIndex = 151;
            // 
            // radioButton8
            // 
            this.radioButton8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(558, 330);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(91, 26);
            this.radioButton8.TabIndex = 150;
            this.radioButton8.Text = "Fixed3D";
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackColor = System.Drawing.Color.White;
            this.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit4.Location = new System.Drawing.Point(556, 562);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(110, 27);
            this.buttonEdit4.TabIndex = 155;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton7.Image = null;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "...";
            // 
            // radioButton9
            // 
            this.radioButton9.Checked = true;
            this.radioButton9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(556, 303);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(91, 26);
            this.radioButton9.TabIndex = 149;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "FixedSingle";
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Controls.Add(this.textBoxExt1);
            this.buttonEdit5.Location = new System.Drawing.Point(556, 466);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(110, 22);
            this.buttonEdit5.TabIndex = 153;
            this.buttonEdit5.TextBox = this.textBoxExt1;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton8.Image = null;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 1;
            this.buttonEditChildButton8.Text = "...";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(97, 14);
            this.textBoxExt1.TabIndex = 0;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(472, 308);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(66, 13);
            this.label95.TabIndex = 148;
            this.label95.Text = "Border Style";
            // 
            // comboBox14
            // 
            this.comboBox14.BackColor = System.Drawing.Color.White;
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.ForeColor = System.Drawing.Color.Black;
            this.comboBox14.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox14.Location = new System.Drawing.Point(556, 424);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(110, 21);
            this.comboBox14.TabIndex = 147;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(472, 432);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(67, 13);
            this.label96.TabIndex = 144;
            this.label96.Text = "Border Sides";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(472, 390);
            this.label97.Margin = new System.Windows.Forms.Padding(0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(79, 13);
            this.label97.TabIndex = 143;
            this.label97.Text = "Border3D Style";
            // 
            // label71
            // 
            this.label71.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label71.Image = ((System.Drawing.Image)(resources.GetObject("label71.Image")));
            this.label71.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label71.Location = new System.Drawing.Point(91, 246);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(82, 24);
            this.label71.TabIndex = 140;
            this.label71.Text = "Properties";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label74
            // 
            this.label74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label74.Location = new System.Drawing.Point(97, 270);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(250, 1);
            this.label74.TabIndex = 139;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maskedEditBox1);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(236)))));
            this.groupBox6.Location = new System.Drawing.Point(268, 45);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(326, 142);
            this.groupBox6.TabIndex = 130;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MaskedEdit";
            // 
            // maskedEditBox1
            // 
            this.maskedEditBox1.AccessibleDescription = "MaskedEdit TextBox";
            this.maskedEditBox1.AccessibleName = "MaskedEditBox";
            this.maskedEditBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.maskedEditBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedEditBox1.Location = new System.Drawing.Point(109, 85);
            this.maskedEditBox1.Name = "maskedEditBox1";
            this.maskedEditBox1.OverflowIndicatorToolTipText = null;
            this.maskedEditBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedEditBox1.TabIndex = 2;
            this.maskedEditBox1.ThemesEnabled = false;
            this.maskedEditBox1.UseLocaleDefault = false;
            this.maskedEditBox1.WordWrap = false;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Dock = System.Windows.Forms.DockStyle.Top;
            this.label64.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label64.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label64.Location = new System.Drawing.Point(3, 17);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(320, 56);
            this.label64.TabIndex = 1;
            this.label64.Text = resources.GetString("label64.Text");
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(13, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 24);
            this.label34.TabIndex = 16;
            this.label34.Text = "More Options";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(13, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 1);
            this.label13.TabIndex = 13;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(26, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 18);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "First Tab";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(291, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(133, 24);
            this.label35.TabIndex = 17;
            this.label35.Text = "Custom Primitives";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(13, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 24);
            this.label26.TabIndex = 15;
            this.label26.Text = "Visibility";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.Location = new System.Drawing.Point(291, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 1);
            this.label11.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label9.Location = new System.Drawing.Point(13, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(510, 1);
            this.label9.TabIndex = 7;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(142, 139);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(118, 18);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Show Close button";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(26, 139);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(110, 18);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Show DropDown";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(304, 139);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 18);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Show Custom Primitive";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(294, 55);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 18);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Next Tab";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(369, 55);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 18);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Next Page";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(100, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 18);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Previous Page";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(449, 55);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(68, 18);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Last Tab";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(202, 55);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(89, 18);
            this.checkBox11.TabIndex = 3;
            this.checkBox11.Text = "Previous Tab";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AccelerateScrolling = Syncfusion.Windows.Forms.AccelerateScrollingBehavior.Immediate;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253))))), System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(245))))));
            treeNodeAdvStyleInfo1.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(132))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(132)))))});
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(92)))), ((int)(((byte)(140)))));
            treeNodeAdvStyleInfo2.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253))))), System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(245))))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo3.BaseStyle = "Style1";
            treeNodeAdvStyleInfo3.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo3.ShowPlusMinus = false;
            treeNodeAdvStyleInfo3.ThemesEnabled = false;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Style1", treeNodeAdvStyleInfo1),
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Style2", treeNodeAdvStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo3)});
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAdv1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.White;
            this.treeViewAdv1.FullRowSelect = true;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.HotTracking = true;
            this.treeViewAdv1.ItemHeight = 56;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 49);
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.BaseStyle = "Style2";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.Text = "Input Controls";
            treeNodeAdv2.BaseStyle = "Style2";
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Expanded = true;
            treeNodeAdv2.Text = "UpDownExt Controls";
            treeNodeAdv3.BaseStyle = "Style2";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Text = "TextBoxExt";
            treeNodeAdv4.BaseStyle = "Style2";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.Text = "Currency Edit";
            treeNodeAdv5.BaseStyle = "Style2";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Text = "Editable List";
            treeNodeAdv6.BaseStyle = "Style2";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Text = "Masked Edit";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(132))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(132)))))});
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.Black;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.ShowPlusMinus = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(156, 647);
            this.treeViewAdv1.TabIndex = 4;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.ThemesEnabled = false;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.AfterSelect += new System.EventHandler(this.treeViewAdv1_AfterSelect);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))))});
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top)
                        | System.Windows.Forms.Border3DSide.Right)
                        | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(92)))), ((int)(((byte)(140)))));
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(1002, 49);
            this.gradientLabel1.TabIndex = 5;
            this.gradientLabel1.Text = " Editor Controls";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel1.Click += new System.EventHandler(this.gradientLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1002, 696);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.tabControlAdv1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel11)).EndInit();
            this.gradientPanel11.ResumeLayout(false);
            this.gradientPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClr)).EndInit();
            this.bannerClr.ResumeLayout(false);
            this.bannerClr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativeColorEdit)).EndInit();
            this.NegativeColorEdit.ResumeLayout(false);
            this.NegativeColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositiveColorEdit)).EndInit();
            this.PositiveColorEdit.ResumeLayout(false);
            this.PositiveColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).EndInit();
            this.gradientPanel9.ResumeLayout(false);
            this.gradientPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel12)).EndInit();
            this.gradientPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).EndInit();
            this.gradientPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditBanner)).EndInit();
            this.bEditBanner.ResumeLayout(false);
            this.bEditBanner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DomainBorderColorEdit)).EndInit();
            this.DomainBorderColorEdit.ResumeLayout(false);
            this.DomainBorderColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPageAdv6.ResumeLayout(false);
            this.tabPageAdv6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }


        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Currency TextBox
            PopulateCultures();
            this.comboBoxAdv1.SelectedIndex = 0;
            //Syncfusion.Windows.Forms.WinFormsUtils.UpdateDirectoryPath(this.oleDbConnection1, "Data", "CurrencyDataBinding.mdb");
            string mdbFile = Application.StartupPath + @" \..\..\..\..\..\..\..\..\..\Common\Data\CurrencyDataBinding.mdb";

           

            // Database connection string
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbFile;

            //CurrencyEdit
            // Load all Specific Cultures to the Combo Box
            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox1.Items.Add(info.DisplayName);
                comboBox2.Items.Add(info.Name);
            }
            // Populate cboButtontype Combo Box with ButtonTypes
            string[] str = Enum.GetNames(typeof(ButtonTypes));
            cboButtonType.Items.AddRange(str);

            cboButtonType.SelectedIndex = 1;
            comboBox1.SelectedIndex = 64;

            //Populate DomainUpDown Border3DStyles
            string[] str1 = Enum.GetNames(typeof(Border3DStyle));
            comboBox3.Items.AddRange(str1);
            //Populate TextBoxes Border3DStyles
            comboBox6.Items.AddRange(str1);
            //Populate TextBoxExt Border3DStyles
            comboBox11.Items.AddRange(str1);
            //Populate MaskedEdit Border3DStyles
            comboBox7.Items.AddRange(str1);

            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 5;
            comboBox5.SelectedIndex = 5;
            comboBox6.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox10.SelectedIndex = 5;
            comboBox9.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox15.SelectedIndex = 1;
            comboBox17.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox14.SelectedIndex = 5;

            comboBox1.SelectedItem = "English (Australia)";
            comboBox13.SelectedIndex = 0;
            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0];
            this.treeViewAdv1.Nodes[0].BaseStyle = "Style1";
            foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
            {
                tabPage.Hide();
            }
            this.tabPageAdv1.Show();
            cmbMode.SelectedIndex = 0;
            comboMode.SelectedIndex = 0;
            Application.Idle += new EventHandler(Application_Idle);
            this.ColorScheme = Office2007Theme.Blue;
            CreateDatatable();
        }

        #endregion

        #region TextBox

        #region TextBox Culture Settings
        private void PopulateCultures()
        {
            comboBoxAdv2.Items.Add("(Default)");
            comboBoxAdv2.Items.Add("(UICulture)");
            comboBoxAdv2.Items.Add("(InstalledUICulture)");
            foreach (CultureInfo c in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBoxAdv2.Items.Add(c.Name);
            }

            this.comboBoxAdv2.SelectedIndex = 0;
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selected = this.comboBoxAdv2.SelectedItem.ToString();

            if (selected.Equals("(Default)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.percentTextBox1.UseUserOverride);
            }
            else if (selected.Equals("(UICulture)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.percentTextBox1.UseUserOverride);

            }
            else if (selected.Equals("(InstalledUICulture)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.percentTextBox1.UseUserOverride);

            }
            else
            {

                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.None;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.currencyTextBox1.Culture = new CultureInfo(selected, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(selected, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(selected, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(selected, this.percentTextBox1.UseUserOverride);

            }

            this.currencyTextBox1.Text = this.currencyTextBox1.Text;
        }
        #endregion

        #region TextBox DataBinding
        //Databinding
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.currencyTextBox1.DataBindings.Add("Text", Dt, "Amount");
                this.doubleTextBox1.DataBindings.Add("Text", Dt, "Amount");
                this.integerTextBox2.DataBindings.Add("Text", Dt, "Amount");
                

                this.dataGrid1.DataSource = Dt;
            }
            else
            {
                this.currencyTextBox1.DataBindings.Clear();
                this.doubleTextBox1.DataBindings.Clear();
                this.integerTextBox2.DataBindings.Clear();
                this.currencyTextBox1.Text = "1";
                this.dataGrid1.DataSource = null;
            }
        }
        public void CreateDatatable()
        {
            Dt = new DataTable();
            DataColumn column1 = new DataColumn("ID", typeof(int));
            DataColumn column2 = new DataColumn("PurchaseDate", typeof(DateTime));
            DataColumn column3 = new DataColumn("Amount", typeof(int));
            //DataColumn[] cols=new DataColumn[]  {column1,column2,column3};
            Dt.Columns.Add(column1);
            Dt.Columns.Add(column2);
            Dt.Columns.Add(column3);

            Dt.Rows.Add("1", "12/1/2004", 21);
            Dt.Rows.Add("2", "11/5/2004", 33);
            Dt.Rows.Add("3", "8/4/2005", 4434);
            Dt.Rows.Add("4", "5/7/2006", 4555);
            Dt.Rows.Add("5", "12/6/2007", 3466);


        }
        #endregion

        #region TextBox Text Colors
        //Positive color
        private void PositiveColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PositiveColorEdit.TextBox.BackColor = colorDialog1.Color;
                this.currencyTextBox1.PositiveColor = colorDialog1.Color;
                this.doubleTextBox1.PositiveColor = colorDialog1.Color;
                this.integerTextBox2.PositiveColor = colorDialog1.Color;
                this.percentTextBox1.PositiveColor = colorDialog1.Color;

            }

        }
        //Negative color
        private void NegativeColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NegativeColorEdit.TextBox.BackColor = colorDialog1.Color;
                this.currencyTextBox1.NegativeColor = colorDialog1.Color;
                this.doubleTextBox1.NegativeColor = colorDialog1.Color;
                this.integerTextBox2.NegativeColor = colorDialog1.Color;
                this.percentTextBox1.NegativeColor = colorDialog1.Color;
            }
        }
        #endregion

        #region TextBox BorderStyle
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
            {
                this.currencyTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.doubleTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.integerTextBox2.BorderStyle = BorderStyle.FixedSingle;
                this.percentTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox6.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
            {
                this.numericUpDownExt8.Value = 0;
                this.currencyTextBox1.CornerRadius = 0;
                this.doubleTextBox1.CornerRadius = 0;
                this.integerTextBox2.CornerRadius = 0;
                this.percentTextBox1.CornerRadius = 0;
                this.currencyTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.doubleTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.integerTextBox2.BorderStyle = BorderStyle.Fixed3D;
                this.percentTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox6.Enabled = true;
            }
        }
        #endregion

        #region TextBox Controls Border3DStyle
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkBox1.Checked = false;
            switch (comboBox6.Items[comboBox6.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;

                    break;
                case "Adjust":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Adjust;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Bump;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Bump;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Bump;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Bump;

                    break;
                case "Etched":

                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Etched;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Etched;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Etched;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Etched;


                    break;
                case "Flat":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Flat;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Flat;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Flat;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Flat;


                    break;
                case "Raised":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Raised;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Raised;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Raised;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Raised;


                    break;
                case "RaisedInner":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.RaisedInner;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Sunken;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Sunken;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Sunken;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Sunken;

                    break;
                case "SunkenInner":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.SunkenInner;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;

                    break;
            }
        }
        #endregion

        #region TextBox BorderColor
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.radioButton7.Checked = true;
                this.buttonEdit1.TextBox.BackColor = colorDialog1.Color;
                this.currencyTextBox1.BorderColor = colorDialog1.Color;
                this.doubleTextBox1.BorderColor = colorDialog1.Color;
                this.integerTextBox2.BorderColor = colorDialog1.Color;
                this.percentTextBox1.BorderColor = colorDialog1.Color;
            }
        }
        #endregion

        #region TextBox BorderSides
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.Items[comboBox5.SelectedIndex].ToString())
            {
                case "Left":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;

                    break;
                case "Top":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }
        }
        #endregion

        #region TextBox TextAlignment
        private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.Text == "Left")
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Left;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Left;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Left;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Left;
            }
            else if (this.comboBoxAdv1.Text == "Right")
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Right;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Right;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Right;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Center;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Center;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Center;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Center;
            }
        }
        #endregion

        #region TextBox ThemesEnabled
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.currencyTextBox1.ThemesEnabled = this.checkBox1.Checked;
            this.doubleTextBox1.ThemesEnabled = this.checkBox1.Checked;
            this.integerTextBox2.ThemesEnabled = this.checkBox1.Checked;
            this.percentTextBox1.ThemesEnabled = this.checkBox1.Checked;
        }
        #endregion

        #region TextBox ShowOverFlowIndicator
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
            this.doubleTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
            this.integerTextBox2.ShowOverflowIndicator = this.checkBox16.Checked;
            this.percentTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
        }
        #endregion

        #region TextBox ShowOverFlowIndicatorToolTip
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.doubleTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.integerTextBox2.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.percentTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
   
        }
        #endregion

        #region Properties

        #region Currency TextBox Properties
        //To set the currency symbol of the Currency TextBox
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.currencyTextBox1.CurrencySymbol = this.textBox1.Text;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                this.textBox1.Text = "$";
            }
        }

        //To set the CurrencyDecimalDigits of the IntegerTextBox
        private void integerTextbox1_IntegerValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.currencyTextBox1.CurrencyDecimalDigits = (int)(this.integerTextBox1.IntegerValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Values between 0 to 99 are only allowed");
                this.integerTextBox1.IntegerValue = -this.integerTextBox1.IntegerValue;
            }            
        }
        #endregion

        #region DoubleTextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                this.doubleTextBox1.NumberDecimalSeparator = this.textBox2.Text;
            }

        }

        private void integerTextBox3_TextChanged(object sender, EventArgs e)
        {
            int decimalValue = Convert.ToInt16(this.integerTextBox3.Text);
            if (decimalValue > 0 & decimalValue < 99)
                this.doubleTextBox1.NumberDecimalDigits = Convert.ToInt16(this.integerTextBox3.Text);
            else
                this.integerTextBox3.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.doubleTextBox1.NumberGroupSeparator = this.textBox3.Text;
        }


        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt2.Value);
            this.doubleTextBox1.NumberGroupSizes = new int[] { x };
  }

        #endregion

        #region PercentTextBox
        //To set the Percent Value of the PercentTextBox
        private void numericUpDownExt5_ValueChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(this.numericUpDownExt5.Value);
            this.percentTextBox1.PercentValue = x;
        }

        //To set the Decimal Separator of PercentTextBox
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox6.Text != "")
            {
                this.percentTextBox1.PercentDecimalSeparator = this.textBox6.Text;
            }
        }
        //To set the Decimal Digits of PercentTextBox
        private void integerTextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.percentTextBox1.PercentDecimalDigits = Convert.ToInt16(this.integerTextBox7.Text);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Values between 0 to 99 are only allowed");
                this.integerTextBox7.IntegerValue = -this.integerTextBox7.IntegerValue;
            }
        }



        //To set the PercentPositivePattern  of PercentTextBox
        private void numericUpDownExt4_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt4.Value);

            this.percentTextBox1.PercentPositivePattern = x;
        }
       
        #endregion

        #region IntegerTextBox properties
        //To set the NumberNegativePattern of IntegerTextBox
        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt1.Value);

            this.integerTextBox2.NumberNegativePattern = x;

        }

        //To set the NumberGroupSeparator of IntegerTextBox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox4.Text != "")
            {
                this.integerTextBox2.NumberGroupSeparator = this.textBox4.Text;
            }
        }

        //To set the NumberGroupSizes of IntegerTextBox
        private void numericUpDownExt3_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt3.Value);
            this.integerTextBox2.NumberGroupSizes = new int[] { x };

        }




        #endregion

        #endregion

        #endregion

        #region Currency Edit

        #region Culture Settings
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            string culture = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            currencyEdit1.TextBox.SpecialCultureValue = SpecialCultureValues.UICulture;
            currencyEdit1.TextBox.Culture = new System.Globalization.CultureInfo(culture);
        }
        #endregion

        #region Calculator Type
        private void radWinStd_CheckedChanged(object sender, EventArgs e)
        {
            if (radWinStd.Checked == true)
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.WindowsStandard;

        }

        private void radFinancial_CheckedChanged(object sender, EventArgs e)
        {
            if (radFinancial.Checked == true)
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.Financial;

        }
        #endregion

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.Text = "0";
            this.currencyEdit1.ShowCalculator = this.checkBox12.Checked;

        }

        private void currencyEdit1_CalculatorShowing(object sender, CancelEventArgs e)
        {
            currencyEdit1.CalcPopup.Calculator.UseVerticalAndHorizontalSpacing = true;
            currencyEdit1.CalcPopup.Calculator.HorizontalSpacing = 0;
            currencyEdit1.CalcPopup.Calculator.VerticalSpacing = 0;

        }
        

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TransferFromCalculator = this.checkBox17.Checked;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TransferToCalculator = this.checkBox18.Checked;

        }


        #region Set Button Style

        private void ButtonStyle_CheckedChanged(object sender, System.EventArgs e)
        {
            if (sender == radClassic)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.Classic;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Classic;
            }
            else if (sender == radOffice2000)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2000;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2000;
            }
            else if (sender == radOffice2003)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2003;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2003;
            }
            else if (sender == radOffice2007)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2007;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2007;
            }
            else if (sender == radOfficeXP)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.OfficeXP;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.OfficeXP;
            }
            else if (sender == radWinXP)
            {

                currencyEdit1.ButtonStyle = ButtonAppearance.WindowsXP;
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.WindowsXP;
            }
        }

        #endregion

        #region Currency Edit Button Type
        private void cboButtonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboButtonType.Items[cboButtonType.SelectedIndex].ToString())
            {
                case "Browse":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Browse;
                    break;
                case "Calculator":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Calculator;
                    break;
                case "Check":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Check;
                    break;
                case "ComboXPDown":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.ComboXPDown;
                    break;
                case "Currency":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Currency;
                    break;
                case "Down":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Down;
                    break;
                case "Left":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Left;
                    break;
                case "LeftEnd":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.LeftEnd;
                    break;
                case "Normal":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Normal;
                    break;
                case "Redo":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Redo;
                    break;
                case "Right":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Right;
                    break;
                case "RightEnd":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.RightEnd;
                    break;
                case "Undo":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Undo;
                    break;
                case "Up":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Up;
                    break;
            }
        }
        #endregion

        #region ReadOnly
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TextBox.ReadOnly = checkBox13.Checked;
            this.currencyEdit1.CalculatorButton.Enabled = !checkBox13.Checked;
        }
        #endregion

        #endregion

        #region DomainUpDownExt

        #region Border3DStyle
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Items[comboBox3.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Adjust;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Bump;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Etched;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Flat;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Raised;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Sunken":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Sunken;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region BorderSides

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Items[comboBox4.SelectedIndex].ToString())
            {
                case "Left":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    break;
                case "Top":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }


        }
        #endregion

        #region BorderColor
        private void DomainBorderColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.radioButton1.Checked = true;
                this.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle;
                DomainBorderColorEdit.TextBox.BackColor = colorDialog1.Color;
                this.domainUpDownExt1.BorderColor = colorDialog1.Color;
                this.numericUpDownExt7.BorderColor = colorDialog1.Color;
            }
        }
        #endregion

        #region UpDownExt BorderStyle
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle;
                this.numericUpDownExt7.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.domainUpDownExt1.BorderStyle = BorderStyle.Fixed3D;
                this.numericUpDownExt7.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = false;
            }
        }
        #endregion

        #region UpDownExt Themes Enabled

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox14.Checked)
            {
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                DomainBorderColorEdit.Enabled = false;
                this.radioButton1.Enabled = false;
                this.radioButton2.Enabled = false;
                this.domainUpDownExt1.ThemesEnabled = true;
                this.numericUpDownExt7.ThemesEnabled = true;
            }
            else
            {
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = true;
                this.radioButton1.Enabled = true;
                this.radioButton2.Enabled = true;
                this.domainUpDownExt1.ThemesEnabled = false;
                this.numericUpDownExt7.ThemesEnabled = false;
            }
        }
        #endregion

        #region UpDownExt InterceptArrowKeys
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.checkBox15.Checked);
            this.domainUpDownExt1.InterceptArrowKeys = this.checkBox15.Checked;
            this.numericUpDownExt7.InterceptArrowKeys = this.checkBox15.Checked;
        }
        #endregion

        #region UpDownExt Office2007Style
        private void OfficeStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
                this.domainUpDownExt1.ColorScheme = Office2007Theme.Blue;
                this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
                this.numericUpDownExt7.ColorScheme = Office2007Theme.Blue;
            }
            if (this.radioButton4.Checked)
            {
                this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
                this.domainUpDownExt1.ColorScheme = Office2007Theme.Silver;
                this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
                this.numericUpDownExt7.ColorScheme = Office2007Theme.Silver;
            }
            if (this.radioButton5.Checked)
            {
                this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
                this.domainUpDownExt1.ColorScheme = Office2007Theme.Black;
                this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
                this.numericUpDownExt7.ColorScheme = Office2007Theme.Black;
            }

            if (this.radioButton12.Checked)
            {
                this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
                this.domainUpDownExt1.ColorScheme = Office2007Theme.Managed;
                this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
                this.numericUpDownExt7.ColorScheme = Office2007Theme.Managed;
                Office2007Colors.ApplyManagedColors(this, Color.Orange);
            }
        }
        #endregion

        #region UpDownExt DataBinding
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox19.Checked == true)
            {
                //this.domainUpDownExt1.DataBindings.Add("Text", this.dataSet11.Sales, "Amount");
                //this.numericUpDownExt7.DataBindings.Add("Text", this.dataSet11.Sales, "Amount");
                //this.oleDbDataAdapter1.Fill(this.dataSet11.Sales);
                //this.dataGrid2.DataSource = this.dataSet11.Sales;

                this.domainUpDownExt1.DataBindings.Add("Text", Dt, "Amount");
                this.numericUpDownExt7.DataBindings.Add("Text", Dt, "Amount");
                this.dataGrid2.DataSource = Dt;

                
            }
            else
            {
                this.domainUpDownExt1.DataBindings.Clear();
                this.numericUpDownExt7.DataBindings.Clear();
                this.dataGrid2.DataSource = null;
            }
        }
        #endregion

        #region DomainUpDownSpinOrientation

        private void UpdownExtSpinOrientation_Changed( object sender, EventArgs e ) {
            this.domainUpDownExt1.SpinOrientation = ( Orientation )Enum.Parse( typeof( Orientation ), this.comboBox19.SelectedItem.ToString() );
        } 
        #endregion


        #endregion

        #region TextBoxExt
     

        #region TextBoxExt BorderStyle
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton11.Checked)
            {
                this.textBoxExt4.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox11.Enabled = false;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton10.Checked)
            {
                this.textBoxExt4.CornerRadius = 0;
                this.numericUpDownExt6 .Value = 0;
                this.textBoxExt4.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox11.Enabled = true;
            }
        }
        #endregion

        #region TextBoxExt BorderSides
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.Items[comboBox10.SelectedIndex].ToString())
            {
                case "Left":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    break;
                case "Top":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }
        }
        #endregion

        #region TextBoxExt Border3DStyle
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox11.Items[comboBox11.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region TextBoxExt Character casing
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Items[comboBox8.SelectedIndex].ToString())
            {
                case "Normal":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Normal;
                    break;
                case "Upper Case":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "Lower Case":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Lower;
                    break;
            }
        }
        #endregion

        #region TextBoxExt TextAlign
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox12.Items[comboBox12.SelectedIndex].ToString())
            {
                case "Left":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Left;
                    break;
                case "Right":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Right;
                    break;
                case "Center":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Center;
                    break;
            }
        }
#endregion

        //To set as MultiLine
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox25.Checked)
            {
                this.textBoxExt4.Multiline = true;
                this.textBoxExt4.Text = "We are a leading provider of software components and tools for the Microsoft .NET platform. Powerful and feature-rich, Syncfusion’s broad range of products are vital to mission-critical applications in organizations ranging from small businesses to multinational Fortune 100 companies.  Syncfusion's mission is to produce world-class software components that enable developers to produce quality software for the most demanding of environments. Our innovative libraries are designed to be extensible to ensure maximum benefit to customers, and we provide full source code to enable seamless integration of our libraries with our customers' projects. We firmly believe that our success is closely tied to that of our customers. To help our customers succeed, we strive to offer technical support that is accessible, accurate, and fast.";
                this.textBoxExt4.Size = new Size(242, 77);
            }
            else
            {
                this.textBoxExt4.Multiline = false;
                this.textBoxExt4.Text = "TextBoxExt";
            }
        }

        //To make the TextBoxExt as readOnly
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ReadOnly = this.checkBox24.Checked;
        }

        //Right To Left
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox23.Checked)
            {

                this.textBoxExt4.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.textBoxExt4.RightToLeft = RightToLeft.No;
            }
        }

        //To set Word Wrap
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.WordWrap = this.checkBox22.Checked;
        }

        #region TextBoxExt ScrollBars
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.Items[comboBox9.SelectedIndex].ToString())
            {
                case "None":
                    this.textBoxExt4.ScrollBars = ScrollBars.None;
                    break;
                case "Horizontal":
                    this.textBoxExt4.ScrollBars = ScrollBars.Horizontal;
                    break;
                case "Vertical":
                    this.textBoxExt4.ScrollBars = ScrollBars.Vertical;
                    break;
                case "Both":
                    this.textBoxExt4.ScrollBars = ScrollBars.Both;
                    break;
            }
        }
#endregion

         //To set the TextBoxExt OverflowIndicatorToolTip Text
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox11.Text != "")
            {
                this.textBoxExt4.OverflowIndicatorToolTipText = this.textBox11.Text;
            }
        }

        //To show the TextBoxExt OverflowIndicatorToolTip
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ShowOverflowIndicatorToolTip = this.checkBox26.Checked;
        }
        
        //To show the TextBoxExt OverflowIndicator
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ShowOverflowIndicator = this.checkBox21.Checked;
        }

       //TextBoxExt BorderColor
        private void buttonEdit2_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {               
                this.buttonEdit2.TextBox.BackColor = colorDialog1.Color;
                this.textBoxExt4.BorderColor = colorDialog1.Color;
               }

           }
        #endregion

        #region EditableList

         #region DragDrop
           private void editableList2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData("FileDrop", false);

            foreach (string s in files)
            {
                this.editableList2.ListBox.Items.Add(s.Substring(1 + s.LastIndexOf(@"\")));
            }
        }
        #endregion

        #region DragEnter
        private void editableList2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.All;

            else

                e.Effect = DragDropEffects.None;

        }
        #endregion
           

        #region ListBoxTextAlign

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox13.Items[comboBox13.SelectedIndex].ToString())
            {
                case "Left":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Left;
                    break;
                case "Right":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Right;
                    break;
                case "Center":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Center;
                    break;
            }
        }
        #endregion

        #region Want Button
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            this.editableList1.WantButton = this.checkBox27.Checked;
        }
        #endregion

        #region RightToLeft
        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox28.Checked)
            {
                this.editableList1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                
                this.editableList1.RightToLeft = RightToLeft.No;
            }
        }
           #endregion

#endregion
        
        #region Control Visible
        
        private void treeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            this.treeViewAdv1.Nodes[0].BaseStyle = "Style2";
            foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
            {
                tabPage.Hide();
            }
            if (this.treeViewAdv1.SelectedNode.Text == "Input Controls") 
            {
                this.tabPageAdv1.Show();
             }
            if (this.treeViewAdv1.SelectedNode.Text == "UpDownExt Controls")
            {
                this.tabPageAdv3.Show();

            }
            if (this.treeViewAdv1.SelectedNode.Text == "TextBoxExt")
            {
                this.tabPageAdv5.Show();
            }
            if (this.treeViewAdv1.SelectedNode.Text == "Currency Edit")
            {
                this.tabPageAdv2.Show();
            }
            if (this.treeViewAdv1.SelectedNode.Text == "Editable List")
            {
                this.tabPageAdv6.Show();
            }
            if (this.treeViewAdv1.SelectedNode.Text == "Masked Edit")
            {
                this.tabPageAdv4.Show();
            }
        }
#endregion

        #region MaskedEditBox
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.BorderStyle = BorderStyle.FixedSingle;
            this.comboBox7.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
            {
                this.maskedEditBox1.CornerRadius = 0;
                this.numericUpDownExt9.Value = 0;
            this.maskedEditBox1.BorderStyle = BorderStyle.Fixed3D;
            this.comboBox7.Enabled = true;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.Items[comboBox7.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedOuter;
                  
                    break;
                case "Adjust":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Adjust;
                         break;
                case "Bump":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Bump;
                  
                    break;
                case "Etched":

                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Etched;
                 

                    break;
                case "Flat":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Flat;
                  

                    break;
                case "Raised":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Raised;
                  
                    break;
                case "RaisedInner":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedInner;
                        break;
                case "Sunken":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Sunken;
                   
                    break;
                case "SunkenInner":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenInner;
                       break;
                case "SunkenOuter":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenOuter;
                  
                    break;
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.Items[comboBox14.SelectedIndex].ToString())
            {
                case "Left":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                                       break;
                case "Top":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                        break;
                case "Right":
                     this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                        break;
                case "Bottom":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                       break;
                case "Middle":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                       break;
                case "All":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                       break;

            }
        }

        private void buttonEdit5_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
              
                this.buttonEdit5.TextBox.BackColor = colorDialog1.Color;
                this.maskedEditBox1.BackColor = colorDialog1.Color;
              }
        }

        private void buttonEdit3_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.buttonEdit3.TextBox.BackColor = colorDialog1.Color;
                this.maskedEditBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonEdit4_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.buttonEdit4.TextBox.BackColor = colorDialog1.Color;
                this.maskedEditBox1.BorderColor = colorDialog1.Color;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.Items[comboBox15.SelectedIndex].ToString())
            {
                case "None":
                    this.maskedEditBox1.Mask = "";

                    break;

                case "##/##/####":
                    this.maskedEditBox1.Mask = "##/##/####";
                  
                    break;
                case "##.##":
                    this.maskedEditBox1.Mask = "##.##";
                    
                    break;
                case "###-########":
                    this.maskedEditBox1.Mask = "###-########";
                    
                    break;
            }
           


        }

              
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.Items[comboBox17.SelectedIndex].ToString())
            {
                case "Normal":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Normal;
                    break;
                case "Upper Case":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "Lower Case":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Lower;
                    break;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (comboBox16.Items[comboBox16.SelectedIndex].ToString())
            {
                case "Left":
                this.maskedEditBox1.TextAlign = HorizontalAlignment.Left;

                    break;
                case "Right":
                    this.maskedEditBox1.TextAlign = HorizontalAlignment.Right ;

                    break;
                case "Center":
                        this.maskedEditBox1.TextAlign = HorizontalAlignment.Center;

                    break;
                    }

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.ReadOnly = this.checkBox30.Checked;
                  
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox29.Checked)
            {
                this.maskedEditBox1.RightToLeft = RightToLeft.Yes;
            }
            else
            {

                this.maskedEditBox1.RightToLeft = RightToLeft.No;
            }
        }

       
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.Items[comboBox18.SelectedIndex].ToString())
            {
                  case "*":
                    this.maskedEditBox1.PasswordChar = '*';
                    break;
                case "#":
                    this.maskedEditBox1.PasswordChar = '#';
                    break;
                case "@":
                    this.maskedEditBox1.PasswordChar = '@';
                    break;
            }
        }

       

#endregion

        #region Banner Text Settings

        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;

            if (txtBnr.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;

            if (textBanner.Text == "")
                buttonBanner.Enabled = false;
            else
                buttonBanner.Enabled = true;
        }

        //TextBoxExt
        private void bannerClrEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClrEdit.TextBox.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BannerTextMode mode;
            if (rdoEdit.Checked)
                mode = BannerTextMode.EditMode;
            else
                mode = BannerTextMode.FocusMode;

            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.textBoxExt4);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;

            this.textBoxExt4.Refresh();
        }

        //Input Controls
        private void bannerClr_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClr.TextBox.BackColor = colorDialog1.Color;
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), cmbMode.SelectedItem.ToString());
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.currencyTextBox1);
            binfo.Text = txtBnr.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClr.TextBox.BackColor;
            currencyTextBox1.Refresh();

            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.integerTextBox2);
            binfo2.Text = txtBnr.Text;
            binfo2.Mode = mode;
            binfo2.Color = bannerClr.TextBox.BackColor;
            integerTextBox1.Refresh();

            BannerTextInfo binfo3 = this.bannerTextProvider1.GetBannerText(this.doubleTextBox1);
            binfo3.Text = txtBnr.Text;
            binfo3.Mode = mode;
            binfo3.Color = bannerClr.TextBox.BackColor;
            doubleTextBox1.Refresh();

            BannerTextInfo binfo4 = this.bannerTextProvider1.GetBannerText(this.percentTextBox1);
            binfo4.Text = txtBnr.Text;
            binfo4.Mode = mode;
            binfo4.Color = bannerClr.TextBox.BackColor;
            percentTextBox1.Refresh();
        }

        //UpDown controls
        private void bEditBanner_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bEditBanner.TextBox.BackColor = colorDialog1.Color;
        }

        private void buttonBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), comboMode.SelectedItem.ToString());

            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.domainUpDownExt1);
            binfo.Text = textBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bEditBanner.TextBox.BackColor;
            domainUpDownExt1.Refresh();

            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.numericUpDownExt7);
            binfo2.Text = textBanner.Text;
            binfo2.Mode = mode;
            binfo2.Color = bEditBanner.TextBox.BackColor;
            this.numericUpDownExt7.Refresh();
        }
        #endregion

        private void gradientLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownExt8_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt8 .Value != 0)
            {
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = true;

                this.currencyTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.currencyTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.doubleTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.integerTextBox2.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.percentTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
            }
        }

        private void numericUpDownExt6_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt6 .Value != 0)
            {
                this.radioButton10.Checked = false;
                this.radioButton11.Checked = true;
                this.textBoxExt4.BorderStyle = BorderStyle.FixedSingle;
                this.textBoxExt4.CornerRadius = (int)this.numericUpDownExt6 .Value;
            }
        }

        private void numericUpDownExt9_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt9.Value != 0)
            {
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = true;
                this.maskedEditBox1 .BorderStyle = BorderStyle.FixedSingle;
                this.maskedEditBox1 .CornerRadius = (int)this.numericUpDownExt9.Value;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBox32.Checked)
                this.textBoxExt4.FarImage = null;
            else
                this.textBoxExt4.FarImage = new Bitmap("..//..//FarImage.png");
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBox31.Checked)
                this.textBoxExt4.NearImage = null;
            else
                this.textBoxExt4.NearImage = new Bitmap("..//..//NearImage.png");
        }

        private void chkPullCharOnDelete_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.PullCharOnDelete = this.chkPullCharOnDelete.Checked;
        }

    }
}